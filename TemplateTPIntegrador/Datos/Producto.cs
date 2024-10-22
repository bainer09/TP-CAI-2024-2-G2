using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Producto
    {
        public string _id { get => _id; set => _id = value; }
        public int _idCategoria { get => _idCategoria; set => _idCategoria = value; }
        public string _Nombre { get => _Nombre; set => _Nombre = value; }
        public DateTime _FechaAlta { get => _FechaAlta; set => _FechaAlta = value; }
        public DateTime? _FechaBaja { get => _FechaBaja; set => _FechaBaja = value; }
        public double _Precio { get => _Precio; set => _Precio = value; }
        public int _Stock { get => _Stock; set => _Stock = value; }
        public string _idUsuario { get => _idUsuario; set => _idUsuario = value; }
        public string _idProveedor { get => _idProveedor; set => _idProveedor = value; }

        public Producto(string id, int idCategoria, string nombre, DateTime FechaAlta, DateTime? FechaBaja, double precio, int stock, string idUsuario, string idProveedor)
        {
            _id = id;
            _idCategoria = idCategoria;
            _Nombre = nombre;
            _FechaAlta = FechaAlta;
            _FechaBaja = FechaBaja;
            _Precio = precio;
            _Stock = stock;
            _idUsuario = idUsuario;
            _idProveedor = idProveedor;
        }
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
