using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Persistencia;

namespace Negocio
{
    public class Reportes
    {
        private string _persistenciaPath;
        private UsuarioNegocio _usuarios = new UsuarioNegocio();
        private ProductoNegocio _productos = new ProductoNegocio();
        private VentaPersistente VentaP = new VentaPersistente();

        public ReportesNegocio(string persistenciaPath, UsuarioNegocio usuarios, ProductoNegocio productos)
        {
            _persistenciaPath = persistenciaPath;
            _usuarios = usuarios;
            _productos = productos;
        }
        public List<dynamic> VentasPorVendedor()
        {
            List<AgregarVenta> ventas = VentaP.LeerVentasLocal();
            List<Producto> productos = _productos.ObtenerProductos();
            List<Usuario> usuarios = _usuarios.ListarUsuarios();
                

            var reporte = ventas
                .GroupBy(v => new { v._idUsuario, Mes = v._fechaVenta.HasValue ? v._fechaVenta.Value.ToString("yyyy-MM") : "Sin Fecha" })
                .Select(r => new
                {
                    IdUsuario = r.Key._idUsuario,
                    Mes = r.Key.Mes,
                    CantidadVentas = r.Count(),
                    MontoTotal = r.Sum(v =>
                    {
                        var producto = productos.FirstOrDefault(p => p._id == v._idProducto);
                        return producto != null ? v._Cantidad * producto._Precio: 0;
                    })
                })
                .Join(usuarios,
                    venta => venta.IdUsuario,
                    usuario => usuario._id,
                    (venta, usuario) => new
                    {
                        usuario._Usuario,
                        venta.Mes,
                        venta.CantidadVentas,
                        venta.MontoTotal
                    })
                 .ToList<dynamic>();

            return reporte;
        }

        public List<dynamic> GenerarReporteProductosMasVendidos()
        {
            List<VentaAlta> ventas = LeerVentasDesdeJson();
            List<ProductoDatos> productos = productoNegocio.listarProductos();

            var informe = ventas
                .GroupBy(v => v.IdProducto)
                .Select(g => new
                {
                    IdProducto = g.Key,
                    CantidadVentas = g.Sum(v => v.Cantidad)
                })
                .Join(productos,
                      venta => venta.IdProducto,
                      producto => producto.Id.ToString(),
                      (venta, producto) => new
                      {
                          Producto = producto.Nombre,
                          Categoria = categorias.ContainsKey(producto.IdCategoria) ? categorias[producto.IdCategoria] : "Desconocida",
                          CantidadVentas = venta.CantidadVentas
                      })
                .OrderByDescending(i => i.CantidadVentas)
                .ThenBy(i => i.Producto)
                .ToList<dynamic>();

            return informe;
        }

        public List<dynamic> GenerarReporteProductosConStockCritico()
        {
            List<ProductoDatos> productosCriticos = productoNegocio.ObtenerProductosConStockCritico();

            var informe = productosCriticos
                .GroupBy(p => p.IdCategoria)
                .SelectMany(g => g.Select(p => new
                {
                    Producto = p.Nombre,
                    Categoria = categorias.ContainsKey(p.IdCategoria) ? categorias[p.IdCategoria] : "Desconocida",
                    Stock = p.Stock
                }))
                .OrderBy(p => p.Categoria)
                .ThenBy(p => p.Producto)
                .ToList<dynamic>();

            return informe;
        }
    }
}
