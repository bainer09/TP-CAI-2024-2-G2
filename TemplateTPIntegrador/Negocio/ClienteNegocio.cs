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

        public void AltaCliente(string idUsuario, string nombre, string apellido, int DNI, string direccion, string telefono, string email, DateTime fechaNacimiento, string host)
        {
            AltaCliente cliente = new AltaCliente(idUsuario, nombre, apellido, DNI, direccion, telefono, email, fechaNacimiento, "Grupo 2");

            try { ClienteWS.AltaCliente(cliente); }
            catch (Exception e) { throw new Exception("Error: ", e); }
        }
        public void ModificarCliente(string idCliente, string direccion, string telefono, string email)
        {
            ModificarCliente cliente = new ModificarCliente(idCliente, direccion, telefono, email);

            try { ClienteWS.ModificarCliente(cliente); }
            catch (Exception e) { throw new Exception("Error: ", e); }
        }
        public List<Cliente> ObtenerClientes()
        {
            return ClienteWS.GetClientes();
        }
        public void BajaCliente(string idCliente)
        {
            BajaCliente cliente = new BajaCliente(idCliente);

            try { ClienteWS.BajaCliente(cliente); }
            catch (Exception e) { throw new Exception("Error: ", e); }
        }
        public void ReactivarCliente(string idCliente)
        {
            ReactivarCliente cliente = new ReactivarCliente(idCliente);

            try { ClienteWS.ReactivarCiente(cliente); }
            catch (Exception e) { throw new Exception("Error: ", e); }
        }
    }
}
