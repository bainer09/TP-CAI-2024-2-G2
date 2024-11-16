using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Newtonsoft.Json;
using Persistencia.Utils;

namespace Persistencia
{
    public class ClienteWS
    {
        public List<Cliente> GetClientes()
        {
            string apiPath = "Cliente/GetClientes";
            List<Cliente> clientes = new List<Cliente>();
            try
            {
                HttpResponseMessage response = WebHelper.Get(apiPath);
                if (response.IsSuccessStatusCode)
                {
                    var contentStream = response.Content.ReadAsStringAsync().Result;
                    List<Cliente> listadoClientes = JsonConvert.DeserializeObject<List<Cliente>>(contentStream);
                    return listadoClientes;
                }
                else { Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}"); }
            }
            catch (Exception e) { throw new Exception($"Error: ", e); }

            return clientes;
        }
        public void AltaCliente(AltaCliente cliente)
        {
            string apiPath = "Cliente/AgregarCliente";
            var request = JsonConvert.SerializeObject(cliente);

            try
            {
                HttpResponseMessage response = WebHelper.Post(apiPath, request);
                if (response.IsSuccessStatusCode)
                {
                    var reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
                    string respuesta = reader.ReadToEnd();
                }
                else
                {
                    var reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
                    string respuesta = reader.ReadToEnd();
                    throw new Exception($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (Exception e) { throw new Exception($"Error al hacer la solicitud a la API: {e.Message}\n{e.StackTrace}", e); }
            //{ throw new Exception("Error: ", e); }
            }
            public void ModificarCliente(ModificarCliente cliente)
        {
            string apiPath = "Cliente/PatchCliente";
            var request = JsonConvert.SerializeObject(cliente);

            try
            {
                HttpResponseMessage response = WebHelper.Patch(apiPath, request);
                if (response.IsSuccessStatusCode)
                {
                    var reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
                    string respuesta = reader.ReadToEnd();
                }
                else
                {
                    var reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
                    string respuesta = reader.ReadToEnd();
                    throw new Exception($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (Exception e) { throw new Exception("Error: ", e); }
        }
        public void BajaCliente(BajaCliente cliente)
        {
            string apiPath = $"Cliente/BajaCliente?id={cliente}";

            try
            {
                HttpResponseMessage response = WebHelper.Delete(apiPath);
                if (response.IsSuccessStatusCode)
                {
                    var reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
                    string respuesta = reader.ReadToEnd();
                }
                else
                {
                    var reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
                    string respuesta = reader.ReadToEnd();
                    throw new Exception($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (Exception e) { throw new Exception("Error: ", e); }
        }
        public void ReactivarCiente(ReactivarCliente cliente)
        {
            string apiPath = $"Cliente/ReactivarCliente?id={cliente}";
            var request = JsonConvert.SerializeObject(cliente);

            try
            {
                HttpResponseMessage response = WebHelper.Patch(apiPath, request);
                if (response.IsSuccessStatusCode)
                {
                    var reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
                    string respuesta = reader.ReadToEnd();
                }
                else
                {
                    var reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
                    string respuesta = reader.ReadToEnd();
                    throw new Exception($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (Exception e) { throw new Exception("Error: ", e); }
        }
    }
    public class ClientePersistente
    {
        private const string clientesPath = @"/TemplateTPIntegrador/Persistencia/Data/Clientes.json";
        public void AltaClienteLocal(Cliente cliente)
        {
            List<Cliente> clientes;

            if (File.Exists(clientesPath))
            {
                string json = File.ReadAllText(clientesPath);
                clientes = JsonConvert.DeserializeObject<List<Cliente>>(json);
            }
            else
            {
                clientes = new List<Cliente>();
            }
            clientes.Add(cliente);

            try
            {
                string nuevaData = JsonConvert.SerializeObject(clientes, Formatting.Indented);
                File.WriteAllText(clientesPath, nuevaData);
            }
            catch (Exception e) { throw new Exception("Error al dar de alta al cliente en forma local.\n", e); }

        }   
        public void ModificarClienteLocal(ModificarCliente cliente, int DNI)
        {
            string json = File.ReadAllText(clientesPath);
            List<Cliente> clientes = JsonConvert.DeserializeObject<List<Cliente>>(json);
            Cliente clienteModificacion = clientes.Find(c => c.dni == DNI);

            if (clienteModificacion == null) { throw new Exception("Cliente no encontrado."); }

            clienteModificacion.direccion = cliente.direccion;
            clienteModificacion.telefono = cliente.telefono;
            clienteModificacion.email = cliente.email;

            try
            {
                string nuevaData = JsonConvert.SerializeObject(clientes, Formatting.Indented);
                File.WriteAllText(clientesPath, nuevaData);
            }
            catch (Exception e) { throw new Exception("Error al modificar el cliente en forma local.\n", e); }
        }
        public void BajaClienteLocal(int DNI)
        {
            string json = File.ReadAllText(clientesPath);
            List<Cliente> clientes = JsonConvert.DeserializeObject<List<Cliente>>(json);
            List<Cliente> clientesFiltrados = clientes.FindAll(c => c.dni != DNI);

            try
            {
                string nuevaData = JsonConvert.SerializeObject(clientesFiltrados, Formatting.Indented);
                File.WriteAllText(clientesPath, nuevaData);
            }
            catch (Exception e) { throw new Exception("Error al dar de baja al cliente en forma local.\n", e); }
        }
    }
}