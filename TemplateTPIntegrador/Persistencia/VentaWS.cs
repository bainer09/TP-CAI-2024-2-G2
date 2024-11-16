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
        public void AgregarVenta(Venta venta)
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
        public List<GetVenta> GetVentasPorCliente(Guid idCliente)
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
        string dir = AppDomain.CurrentDomain.BaseDirectory;

        public void AgregarVentaLocal(AgregarVenta venta)
        {
            List<AgregarVenta> ventas;
            string ventasPath = dir + "Ventas.json";

            if (!File.Exists(ventasPath))
            {
                File.Create(ventasPath).Close();
            }

            
            try
            {
                var json = File.ReadAllText(ventasPath);
                ventas = JsonConvert.DeserializeObject<List<AgregarVenta>>(json) ?? new List<AgregarVenta>();
                ventas.Add(venta);

                var serializedData = JsonConvert.SerializeObject(ventas, Formatting.Indented);
                File.WriteAllText(ventasPath, serializedData);
            } catch (Exception e) { throw new Exception("Error al agregar la venta en forma local.\n", e); }
        }
        
    }
}
