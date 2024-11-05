using Datos;
using Persistencia;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ClienteNegocio
    {
        private ClienteWS ClienteWS = new ClienteWS();
        private ClientePersistente ClienteP = new ClientePersistente();
        public void AltaCliente(AltaCliente cliente)
        {
            ClienteWS.AltaCliente(cliente);
            Cliente nuevoCliente = new Cliente
            {
                _DNI = cliente._DNI,
                _Telefono = cliente._Telefono,
                _FechaAlta = DateTime.Now,
                _FechaBaja = null,
                _Direccion = cliente._Direccion,
                _Email = cliente._Email,
            };
            ClienteP.AltaClienteLocal(nuevoCliente);
        }
        public void ModificarCliente(ModificarCliente cliente)
        {
            try { ClienteWS.ModificarCliente(cliente); }
            catch (Exception e) { throw new Exception("Error: ", e); }
        }
        public List<Cliente> ObtenerClientes()
        {
            return ClienteWS.GetClientes();
        }
        public void BajaCliente(BajaCliente cliente)
        {
            try { ClienteWS.BajaCliente(cliente); }
            catch (Exception e) { throw new Exception("Error: ", e); }
        }
        public void ReactivarCliente(ReactivarCliente cliente)
        {
            try { ClienteWS.ReactivarCiente(cliente); }
            catch (Exception e) { throw new Exception("Error: ", e); }
        }
    }
}
