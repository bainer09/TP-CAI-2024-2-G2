using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Venta
    {
        public string _id { get => _id; set => _id = value; }
        public string _idCliente { get => _idCliente; set => _idCliente = value; }
        public string _idProducto { get => _idProducto; set => _idProducto = value; }
        public int _Cantidad { get => _Cantidad; set => _Cantidad = value; }
        public DateTime _FechaAlta { get => _FechaAlta; set => _FechaAlta = value; }
        public int _Estado { get => _Estado; set => _Estado = value; }
        public string _idUsuario { get => _idUsuario; set => _idUsuario = value; }

        public Venta(string id, string idCliente, string idProducto, int cantidad, DateTime fechaAlta, int estado, string idUsuario)
        {
            _id = id;
            _idCliente = idCliente;
            _idProducto = idProducto;
            _Cantidad = cantidad;
            _FechaAlta = fechaAlta;
            _Estado = estado;
            _idUsuario = idUsuario;
        }
    }
    public class AgregarVenta
    {
        public string _idCliente { get => _idCliente; set => _idCliente = value; }
        public string _idProducto { get => _idProducto; set => _idProducto = value; }
        public int _Cantidad { get => _Cantidad; set => _Cantidad = value; }
        public string _idUsuario { get => _idUsuario; set => _idUsuario = value; }

        public AgregarVenta(string idCliente, string idProducto, int cantidad, string idUsuario)
        {
            _idCliente = idCliente;
            _idProducto = idProducto;
            _Cantidad = cantidad;
            _idUsuario = idUsuario;
        }
    }
    public class DevolucionVenta
    {
        public string _id { get => _id; set => _id = value; }
        public string _idUsuario { get => _idUsuario; set => _idUsuario = value; }

        public DevolucionVenta(string id, string idUsuario)
        {
            _id = id;
            _idUsuario = idUsuario;

        }
    }
    public class GetVenta
    {
        public string _id { get => _id; set => _id = value; }
        public int _Cantidad { get => _Cantidad; set => _Cantidad = value; }
        public DateTime _FechaAlta { get => _FechaAlta; set => _FechaAlta = value; }
        public int _Estado { get => _Estado; set => _Estado = value; }

        public GetVenta(string id, int cantidad, DateTime fechaAlta, int estado)
        {
            _id = id;
            _Cantidad = cantidad;
            _FechaAlta = fechaAlta;
            _Estado = estado;
        }
    }
}
