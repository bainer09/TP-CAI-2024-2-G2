using Datos;
using Persistencia;
using System;
using System.Collections.Generic;

namespace Negocio
{
    public class ProveedoresNegocio
    {
        private ProveedorWS proveedorService = new ProveedorWS();
        public List<Proveedor> listarProveedores()
        {
            return proveedorService.GetProveedores();
        }
        public void agregar(Guid idUsuario, string nombre, string apellido, string email, string cuit)
        {
            Proveedor altaProveedor = new Proveedor(idUsuario, nombre, apellido, email, cuit);
            try
            {
                proveedorService.AltaProveedor(altaProveedor);
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo agregar el proveedor", ex);
            }
        }


        public void modificar(Guid idProveedor, Guid idUsuario, string nombre, string apellido, string email, string cuit)
        {
            Proveedor modificarProveedor = new Proveedor(idProveedor, idUsuario, nombre, apellido, email, cuit);
            try
            {
                proveedorService.ModificarProveedor(modificarProveedor);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar el proveedor", ex);
            }
        }

        public void eliminar(Guid idProveedor, Guid idUsuario)
        {
            try
            {
                proveedorService.BajaProveedor(idProveedor, idUsuario);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el proveedor", ex);
            }
        }

        public void reactivar(Guid idProveedor, Guid idUsuario)
        {
            try
            {
                proveedorService.ReactivarProveedor(idProveedor, idUsuario);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al reactivar el proveedor", ex);
            }
        }
    }
}
