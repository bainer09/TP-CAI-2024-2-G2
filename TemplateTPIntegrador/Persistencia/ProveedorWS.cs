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
    public class ProveedorWS
    {
        public List<Proveedor> GetProveedores()
        {
            string apiPath = "Proveedor/TraerProveedores";
            List<Proveedor> proveedores = new List<Proveedor>();
            try
            {
                HttpResponseMessage response = WebHelper.Get(apiPath);
                if (response.IsSuccessStatusCode)
                {
                    var contentStream = response.Content.ReadAsStringAsync().Result;
                    List<Proveedor> listadoProveedores = JsonConvert.DeserializeObject<List<Proveedor>>(contentStream);
                    return listadoProveedores;
                }
                else { Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}"); }
            }
            catch (Exception e) { throw new Exception($"Error: ", e); }

            return proveedores;
        }
        public void AltaProveedor(AltaProveedor proveedor)
        {
            string apiPath = "Proveedor/AgregarProveedor";

            var request = JsonConvert.SerializeObject(proveedor);

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
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (Exception e) { throw new Exception($"Error: ", e); }
        }
        public void BajaProveedor(BajaProveedor proveedor)
        {
            string apiPath = "Proveedor/BajaProveedor";
            var request = JsonConvert.SerializeObject(proveedor);

            try
            {
                HttpResponseMessage response = WebHelper.DeleteWithBody(apiPath, request);
                if (response.IsSuccessStatusCode)
                {
                    var reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
                    string respuesta = reader.ReadToEnd();
                }
                else { Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}"); }
            }
            catch (Exception e) { throw new Exception($"Error: ", e); }

        }
        public void ModificarProveedor(ModificarProveedor proveedor)
        {
            string apiPath = "Proveedor/ModificarProveedor";
            var request = JsonConvert.SerializeObject(proveedor);

            try
            {
                HttpResponseMessage response = WebHelper.Patch(apiPath, request);
                if (response.IsSuccessStatusCode)
                {
                    var reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
                    string respuesta = reader.ReadToEnd();
                }
                else { Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}"); }
            }
            catch (Exception e) { throw new Exception($"Error: ", e); }
        }
        public void ReactivarProveedor(ReactivarProveedor proveedor)
        {
            string apiPath = "Proveedor/ReactivarProveedor";
            var request = JsonConvert.SerializeObject(proveedor);

            try
            {
                HttpResponseMessage response = WebHelper.Patch(apiPath, request);
                if (response.IsSuccessStatusCode)
                {
                    var reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
                    string respuesta = reader.ReadToEnd();
                }
                else { Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}"); }
            }
            catch (Exception e) { throw new Exception($"Error: ", e); }
        }
    }
}
