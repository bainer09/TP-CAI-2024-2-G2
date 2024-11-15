using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Datos;
using Persistencia;

namespace Negocio
{
    public class VentaNegocio
    {
        private VentaWS VentaWS = new VentaWS();
        private VentaPersistente VentaP = new VentaPersistente();
        private ProductoNegocio ProductoNegocio = new ProductoNegocio();

        private const double MontoMinimoElectroHogar = 100000.0;
        private const double PromoElectroHogarDescuento = 0.05;
        private const double PromoClienteNuevoDescuento = 0.05;

        public double PromoElectroHogar(List<CarritoProducto> carrito)
        {
            double MontoElectroHogar = carrito
                .Where(p => p.idCategoria == 3)
                .Sum(p => p.precio * p.cantidadVendida);

            if (MontoElectroHogar >= MontoMinimoElectroHogar) { return MontoElectroHogar * PromoClienteNuevoDescuento; }
            
            return 0.0;
        }
        public bool EsPrimeraCompra(Guid idCliente)
        {
            List<GetVenta> ventasCliente = VentaWS.GetVentasPorCliente(idCliente);
            return ventasCliente.Count == 0;
        }
        public double PromoPrimeraCompra(double monto)
        {
            return monto * PromoClienteNuevoDescuento;
        }
        public void AgregarVenta(Venta venta)
        {
            VentaWS.AgregarVenta(venta);
            AgregarVenta nuevaVenta = new AgregarVenta(
                venta.idCliente,
                venta.idProducto,
                venta.cantidad,
                venta.idUsuario,
                DateTime.Now,
                venta.montoTotal
            );
            //VentaP.AgregarVentaLocal(nuevaVenta);
        }
        public List<GetVenta> ObtenerVentasPorCliente(Guid idCliente)
        {
            return VentaWS.GetVentasPorCliente(idCliente);
        }
        public void DevolucionVenta(DevolucionVenta venta)
        {
            VentaWS.DevolverVenta(venta);
        }
    }
}
