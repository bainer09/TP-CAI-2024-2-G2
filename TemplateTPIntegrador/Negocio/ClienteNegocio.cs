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
                dni = cliente.dni,
                telefono = cliente.telefono,
                fechaAlta = DateTime.Now,
                fechaBaja = null,
                direccion = cliente.direccion,
                email = cliente.email,
            };
            ClienteP.AltaClienteLocal(nuevoCliente);
        }
        public void ModificarCliente(ModificarCliente cliente, int DNI)
        {
            try {
                ClienteWS.ModificarCliente(cliente);
                ClienteP.ModificarClienteLocal(cliente, DNI);
            }
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
