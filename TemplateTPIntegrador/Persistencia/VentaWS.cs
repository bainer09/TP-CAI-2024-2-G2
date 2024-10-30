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
    public class VentaWS
    {
        public void AgregarVenta(AgregarVenta venta)
        {
            string apiPath = "Venta/AgregarVenta";
            var request = JsonConvert.SerializeObject(venta);

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
        public List<GetVenta> GetVentasPorCliente(string idCliente)
        {
            string apiPath = $"Venta/GetVentaByCliente?id={idCliente}";
            List<GetVenta> ventas = new List<GetVenta>();
            try
            {
                HttpResponseMessage response = WebHelper.Get(apiPath);
                if (response.IsSuccessStatusCode)
                {
                    var contentStream = response.Content.ReadAsStringAsync().Result;
                    List<GetVenta> listadoVentas = JsonConvert.DeserializeObject<List<GetVenta>>(contentStream);
                    return listadoVentas;
                }
                else { Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}"); }
            }
            catch (Exception e) { throw new Exception($"Error: ", e); }
            
            return ventas;
        }
        public void DevolverVenta(DevolucionVenta venta)
        {
            string apiPath = "Venta/DevolverVenta";

            var request = JsonConvert.SerializeObject(venta);

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

    public class VentaPersistente
    {
        private const string ventasPath = @"/TemplateTPIntegrador/Persistencia/Data/Ventas.json";

        public void AgregarVentaLocal(AgregarVenta venta)
        {
            List<Venta> ventas;

            if (File.Exists(ventasPath))
            {
                string json = File.ReadAllText(ventasPath);
                ventas = JsonConvert.DeserializeObject<List<Venta>>(json);
            }
            else
            {
                ventas = new List<Venta>();
            }
            ventas.Add(venta);

            try
            {
                string nuevaData = JsonConvert.SerializeObject(ventas, Formatting.Indented);
                File.WriteAllText(ventasPath, nuevaData);
            } catch (Exception e) { throw new Exception("Error al agregar la venta en forma local.\n", e); }
        }


    }
}
