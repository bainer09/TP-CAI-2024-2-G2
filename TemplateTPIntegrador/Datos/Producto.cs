using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Producto
    {
        public Guid id { get; set; }
        public int idCategoria { get; set; }
        public string nombre { get; set; }
        public DateTime fechaAlta { get; set; }
        public DateTime? fechaBaja { get; set; }
        public double precio { get; set; }
        public int stock { get; set; }
        public Guid idUsuario { get; set; }
        public Guid idProveedor { get; set; }

        public Producto(Guid id, int idCategoria, string nombre, DateTime FechaAlta, DateTime? FechaBaja, double precio, int stock)
        {
            this.id = id;
            this.idCategoria = idCategoria;
            this.nombre = nombre;
            fechaAlta = FechaAlta;
            fechaBaja = FechaBaja;
            this.precio = precio;
            this.stock = stock;
        }

        public Producto() { }
    }
    public class AltaProducto
    {
        public int idCategoria { get; set; }
        public Guid idUsuario { get; set; }
        public Guid idProveedor { get; set; }
        public string nombre { get; set; }
        public double precio { get; set; }
        public int stock { get; set; }

        public AltaProducto(int idCategoria, Guid idUsuario, Guid idProveedor, string nombre, double precio, int stock)
        {
            this.idCategoria = idCategoria;
            this.idUsuario = idUsuario;
            this.idProveedor = idProveedor;
            this.nombre = nombre;
            this.precio = precio;
            this.stock = stock;
        }
    }
    public class ModificarProducto
    {
        public Guid id { get; set; }
        public Guid idUsuario { get; set; }
        public double precio { get; set; }
        public int stock { get; set; }

        public ModificarProducto(Guid id, Guid idUsuario, double precio, int stock)
        {
            this.id = id;
            this.idUsuario = idUsuario;
            this.precio = precio;
            this.stock = stock;
        }
    }
    public class BajaProducto
    {
        public Guid id { get; set; }
        public Guid idUsuario { get; set; }

        public BajaProducto(Guid id, Guid idUsuario)
        {
            this.id = id;
            this.idUsuario = idUsuario;
        }
    }
    public class ReactivarProducto
    {
        public Guid id { get; set; }
        public Guid idUsuario { get; set; }

        public ReactivarProducto(Guid id, Guid idUsuario)
        {
            this.id = id;
            this.idUsuario = idUsuario;
        }
    }
    public class CarritoProducto
    {
        public Guid idProducto { get; set; }
        public string nombre { get; set; }
        public double precio { get; set; }
        public int stock { get; set; }
        public int idCategoria { get; set; }
        public Guid idProveedor { get; set; }
        public int cantidadVendida { get; set; }

        public CarritoProducto(Guid idProducto, string nombre, double precio, int stock, int idCategoria, Guid idProveedor, int cantidadVendida)
        {
            this.idProducto = idProducto;
            this.nombre = nombre;
            this.precio = precio;
            this.stock = stock;
            this.idCategoria = idCategoria;
            this.idProveedor = idProveedor;
            this.cantidadVendida = cantidadVendida;
        }

        public CarritoProducto() {}
    }
}
