using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Venta
    {
        public string _id { get; set ; }
        public string _idCliente { get; set; }
        public string _idProducto { get; set ; }
        public int _Cantidad { get; set ; }
        public DateTime _FechaAlta { get; set ; }
        public int _Estado { get ; set; }
        public string _idUsuario { get ; set; }
        public double _montoTotal { get ; set; }


        public Venta(string id, string idCliente, string idProducto, int cantidad, DateTime fechaAlta, int estado, string idUsuario, double montoTotal)
        {
            _id = id;
            _idCliente = idCliente;
            _idProducto = idProducto;
            _Cantidad = cantidad;
            _FechaAlta = fechaAlta;
            _Estado = estado;
            _idUsuario = idUsuario;
            _montoTotal = montoTotal;
        }
        
    }
    public class AgregarVenta
    {
        public string _idCliente { get; set; }
        public DateTime? _fechaVenta { get; set; }
        public string _idProducto { get; set; }
        public int _Cantidad { get; set; }
        public string _idUsuario { get; set; }

        public double _montoTotal { get; set; }

        public AgregarVenta(string idCliente, string idProducto, int cantidad, string idUsuario, DateTime? fechaVenta, double montoTotal)
        {
            _idCliente = idCliente;
            _idProducto = idProducto;
            _Cantidad = cantidad;
            _idUsuario = idUsuario;
            _fechaVenta = fechaVenta;
            _montoTotal = montoTotal;
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
