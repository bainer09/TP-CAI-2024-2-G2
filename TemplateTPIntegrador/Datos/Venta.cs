using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Venta
    {
        public Guid id { get; set ; }
        public Guid idCliente { get; set; }
        public Guid idProducto { get; set ; }
        public int cantidad { get; set ; }
        public DateTime fechaVenta { get; set ; }
        public int estado { get ; set; }
        public Guid idUsuario { get ; set; }
        public double montoTotal { get ; set; }


        public Venta(Guid id, Guid idCliente, Guid idProducto, int cantidad, DateTime fechaAlta, int estado, Guid idUsuario, double montoTotal)
        {
            this.id = id;
            this.idCliente = idCliente;
            this.idProducto = idProducto;
            this.cantidad = cantidad;
            this.fechaVenta = fechaAlta;
            this.estado = estado;
            this.idUsuario = idUsuario;
            this.montoTotal = montoTotal;
        }
        public Venta(Guid idCliente, Guid idUsuario, Guid idProducto, int cantidad, double montoTotal, DateTime fechaVenta)
        {
            this.idCliente = idCliente;
            this.idUsuario = idUsuario;
            this.idProducto = idProducto;
            this.cantidad = cantidad;
            this.montoTotal = montoTotal;
            this.fechaVenta = fechaVenta;

        }
        
    }
    public class AgregarVenta
    {
        public Guid idCliente { get; set; }
        public Guid idUsuario { get; set; }
        public Guid idProducto { get; set; }
        public DateTime? fechaVenta { get; set; }
        public int cantidad { get; set; }
        public double montoTotal { get; set; }

        public AgregarVenta(Guid idCliente, Guid idProducto, int cantidad, Guid idUsuario, DateTime? fechaVenta, double montoTotal)
        {
            this.idCliente = idCliente;
            this.idProducto = idProducto;
            this.cantidad = cantidad;
            this.idUsuario = idUsuario;
            this.fechaVenta = fechaVenta;
            this.montoTotal = montoTotal;
        }
        public AgregarVenta() {}
    }
    public class DevolucionVenta
    {
        public Guid id { get; set; }
        public Guid idUsuario { get; set; }

        public DevolucionVenta(Guid id, Guid idUsuario)
        {
            this.id = id;
            this.idUsuario = idUsuario;

        }
    }
    public class GetVenta
    {
        public Guid id { get; set; }
        public int cantidad { get; set; }
        public DateTime fechaAlta { get; set; }
        public int estado { get; set; }

        public GetVenta(Guid id, int cantidad, DateTime fechaAlta, int estado)
        {
            this.id = id;
            this.cantidad = cantidad;
            this.fechaAlta = fechaAlta;
            this.estado = estado;
        }
    }
}
