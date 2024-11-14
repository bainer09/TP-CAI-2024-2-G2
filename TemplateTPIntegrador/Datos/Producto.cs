using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Producto
    {
        public string id { get; set; }
        public int idCategoria { get; set; }
        public string nombre { get; set; }
        public DateTime fechaAlta { get; set; }
        public DateTime? fechaBaja { get; set; }
        public double precio { get; set; }
        public int stock { get; set; }
        public string idUsuario { get; set ; }
        public string idProveedor { get; set; }

        public Producto(string id, int idCategoria, string nombre, DateTime FechaAlta, DateTime? FechaBaja, double precio, int stock)
        {
            this.id = id;
            this.idCategoria = idCategoria;
            this.nombre = nombre;
            fechaAlta = FechaAlta;
            fechaBaja = FechaBaja;
            this.precio = precio;
            this.stock = stock;
        }

        public Producto () {}
    }
    public class AltaProducto
    {
        public int _idCategoria { get => _idCategoria; set => _idCategoria = value; }
        public string _idUsuario { get => _idUsuario; set => _idUsuario = value; }
        public string _idProveedor { get => _idProveedor; set => _idProveedor = value; }
        public string _Nombre { get => _Nombre; set => _Nombre = value; }
        public double _Precio { get => _Precio; set => _Precio = value; }
        public int _Stock { get => _Stock; set => _Stock = value; }

        public AltaProducto(int idCategoria, string idUsuario, string idProveedor, string nombre, double precio, int stock)
        {
            _idCategoria = idCategoria;
            _idUsuario = idUsuario;
            _idProveedor = idProveedor;
            _Nombre = nombre;
            _Precio = precio;
            _Stock = stock;
        }
    }
    public class ModificarProducto
    {
        public string _id { get => _id; set => _id = value; }
        public string _idUsuario { get => _idUsuario; set => _idUsuario = value; }
        public double _Precio { get => _Precio; set => _Precio = value; }
        public int _Stock { get => _Stock; set => _Stock = value; }

        public ModificarProducto(string id, string idUsuario, double precio, int stock)
        {
            _id = id;
            _idUsuario = idUsuario;
            _Precio = precio;
            _Stock = stock;
        }
    }
    public class BajaProducto
    {
        public string _id { get => _id; set => _id = value; }
        public string _idUsuario { get => _idUsuario; set => _idUsuario = value; }

        public BajaProducto(string id, string idUsuario)
        {
            _id = id;
            _idUsuario = idUsuario;
        }
    }
    public class ReactivarProducto
    {
        public string _id { get => _id; set => _id = value; }
        public string _idUsuario { get => _idUsuario; set => _idUsuario = value; }

        public ReactivarProducto(string id, string idUsuario)
        {
            _id = id;
            _idUsuario = idUsuario;
        }
    }
}
