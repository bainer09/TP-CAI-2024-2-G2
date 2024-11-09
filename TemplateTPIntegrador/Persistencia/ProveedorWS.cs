using System;
using System.Collections.Generic;
using System.Net.Http;
using System.IO;
using Newtonsoft.Json;
using Persistencia.Utils;
using Datos;

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
                else {
                    throw new Exception($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (Exception e) {
                throw new Exception("Error: ", e);
            }

            return proveedores;
        }
        public void AltaProveedor(Proveedor altaProveedor)
        {
            string apiPath = "Proveedor/AgregarProveedor";

            var request = JsonConvert.SerializeObject(altaProveedor);

            try
            {
                HttpResponseMessage response = WebHelper.Post(apiPath, request);
                if (!response.IsSuccessStatusCode)
                {
                   
                throw new Exception($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            } catch (Exception e) {
                throw new Exception("Error: ", e);
            }
        }
        public void BajaProveedor(Guid idProveedor, Guid idUsuario)
        {
            string apiPath = "Proveedor/BajaProveedor";
            Dictionary<string, string> map = new Dictionary<string, string>();
            map.Add("id", idProveedor.ToString());
            map.Add("idUsuario", idUsuario.ToString());

            var jsonRequest = JsonConvert.SerializeObject(map);

            try
            {
                HttpResponseMessage response = WebHelper.DeleteWithBody(apiPath, jsonRequest);
                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al comunicarse con el servicio", ex);
            }

        }
        public void ModificarProveedor(Proveedor proveedorModificado)
        {
            string apiPath = "Proveedor/ModificarProveedor";
            var request = JsonConvert.SerializeObject(proveedorModificado);

            try
            {
                HttpResponseMessage response = WebHelper.Patch(apiPath, request);
                if (response.IsSuccessStatusCode)
                {
                    var reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
                    string respuesta = reader.ReadToEnd();
                }
                else { throw new Exception($"Error: {response.StatusCode} - {response.ReasonPhrase}"); }
            }
            catch (Exception e) { throw new Exception("Error al comunicarse con el servicio", e); }
        }
        public void ReactivarProveedor(Guid idProveedor, Guid idUsuario)
        {
            string apiPath = "Proveedor/ReactivarProveedor";
            Dictionary<string, string> map = new Dictionary<string, string>();
            map.Add("id", idProveedor.ToString());
            map.Add("idUsuario", idUsuario.ToString());

            var jsonRequest = JsonConvert.SerializeObject(map);

            try
            {
                HttpResponseMessage response = WebHelper.Patch(apiPath, jsonRequest);
                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al comunicarse con el servicio", ex);
            }
        }
    }
}
