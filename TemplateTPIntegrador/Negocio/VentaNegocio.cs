using System;
using System.Collections.Generic;
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

        public double PromoElectroHogar(List<Venta> carrito, List<Producto> productos)
        {
            double MontoElectroHogar = carrito
                .Where(v => productos.Any(p => p.id == v._idProducto && p.idCategoria == 3))
                .Sum(v => productos.First(p => p.id == v._idProducto).precio * v._Cantidad);

            if (MontoElectroHogar >= MontoMinimoElectroHogar) { return MontoElectroHogar * PromoClienteNuevoDescuento; }
            
            return 0.0;
        }
        public bool EsPrimeraCompra(string idCliente)
        {
            List<GetVenta> ventasCliente = VentaWS.GetVentasPorCliente(idCliente);
            return ventasCliente.Count == 0;
        }
        public (double TotalConDescuento, double DescuentoElectroHogar) ObtenerTotalConDescuento(List<Producto> productos, List<Venta> carrito, bool EsPrimeraCompra)
        {
            double Monto = carrito.Sum(v => productos.First(p => p.id == v._idProducto).precio * v._Cantidad);
            double DescuentoElectroHogar = PromoElectroHogar(carrito, productos);
            double DescuentoPrimeraCompra = 0;

            if (EsPrimeraCompra)
            {
                DescuentoPrimeraCompra = Monto * PromoClienteNuevoDescuento;
            }
            double TotalConDescuento = Monto - DescuentoElectroHogar - DescuentoPrimeraCompra;

            return (TotalConDescuento, DescuentoElectroHogar);
        }
        public void AgregarVenta(AgregarVenta venta)
        {
            VentaWS.AgregarVenta(venta);
            AgregarVenta nuevaVenta = new AgregarVenta(
                venta._idCliente,
                venta._idProducto,
                venta._Cantidad,
                venta._idUsuario,
                DateTime.Now,
                venta._montoTotal
            );
            VentaP.AgregarVentaLocal(nuevaVenta);
        }
        public List<GetVenta> ObtenerVentasPorCliente(string idCliente)
        {
            return VentaWS.GetVentasPorCliente(idCliente);
        }
        public void DevolucionVenta(DevolucionVenta venta)
        {
            VentaWS.DevolverVenta(venta);
        }
    }
}
