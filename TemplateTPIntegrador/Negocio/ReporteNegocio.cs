using Datos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ReporteNegocio
    {
        private UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
        private ProductoNegocio productoNegocio = new ProductoNegocio();
        private string dir = AppDomain.CurrentDomain.BaseDirectory;


        private readonly Dictionary<int, string> categorias = new Dictionary<int, string>
        {
            { 1, "Audio" },
            { 2, "Celulares" },
            { 3, "Electro Hogar" },
            { 4, "Informatica" },
            { 5, "Smart TV" }
        };

        public List<dynamic> ReporteVentasPorVendedor()
        {
            List<Venta> ventas = LeerVentasDesdeJson();
            List<Usuario> usuarios = usuarioNegocio.listarUsuarios();

            var informe = ventas
                .GroupBy(v => new { v.idUsuario, Mes = v.fechaVenta.ToString("yyyy-MM") })
                .Select(g => new
                {
                    IdUsuario = g.Key.idUsuario,
                    Mes = g.Key.Mes,
                    CantidadVentas = g.Count(),
                    MontoTotal = g.Sum(v => v.montoTotal)
                })
                .Join(usuarios,
                      venta => venta.IdUsuario,
                      usuario => usuario.id,
                      (venta, usuario) => new
                      {
                          Vendedor = $"{usuario.nombre} {usuario.apellido}",
                          Mes = venta.Mes,
                          CantidadVentas = venta.CantidadVentas,
                          MontoTotal = venta.MontoTotal
                      })
                .OrderBy(i => i.Vendedor)
                .ThenBy(i => i.Mes)
                .ToList<dynamic>();

            return informe;
        }

        public List<dynamic> ReporteProductosMasVendidos()
        {
            List<Venta> ventas = LeerVentasDesdeJson();
            List<Producto> productos = productoNegocio.ObtenerProductos();

            var informe = ventas
                .GroupBy(v => v.idProducto)
                .Select(g => new
                {
                    IdProducto = g.Key,
                    CantidadVentas = g.Sum(v => v.cantidad)
                })
                .Join(productos,
                      venta => venta.IdProducto,
                      producto => producto.id,
                      (venta, producto) => new
                      {
                          Producto = producto.nombre,
                          Categoria = categorias.ContainsKey(producto.idCategoria) ? categorias[producto.idCategoria] : "Desconocida",
                          CantidadVentas = venta.CantidadVentas
                      })
                .OrderByDescending(i => i.CantidadVentas)
                .ThenBy(i => i.Producto)
                .ToList<dynamic>();

            return informe;
        }

        public List<dynamic> ReporteProductosConStockCritico()
        {
            List<Producto> productosCriticos = productoNegocio.ObtenerProductosConStockCritico();

            var informe = productosCriticos
                .GroupBy(p => p.id)
                .SelectMany(g => g.Select(p => new
                {
                    Producto = p.nombre,
                    Stock = p.stock
                }))
                .OrderBy(p => p.Stock)
                .ThenBy(p => p.Producto)
                .ToList<dynamic>();

            return informe;
        }

        private List<Venta> LeerVentasDesdeJson()
        {
            string ventasPath = dir + "Ventas.json";

            if (File.Exists(ventasPath))
            {
                var json = File.ReadAllText(ventasPath);
                return JsonConvert.DeserializeObject<List<Venta>>(json) ?? new List<Venta>();
            }
            return new List<Venta>();
        }
    }

}
