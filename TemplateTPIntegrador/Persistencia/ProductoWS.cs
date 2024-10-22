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
    public class ProductoWS
    {
        public void AltaProducto(AltaProducto producto)
        {
            string apiPath = "Producto/AgregarProducto";

            var request = JsonConvert.SerializeObject(producto);

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
            catch (Exception e) { throw new Exception($"Error: ", e); }
        }
        public void BajaProducto(BajaProducto producto)
        {
            string apiPath = "Producto/BajaProducto";

            var request = JsonConvert.SerializeObject(producto);

            try
            {
                HttpResponseMessage response = WebHelper.DeleteWithBody(apiPath, request);
                if (response.IsSuccessStatusCode)
                {
                    var reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
                    string respuesta = reader.ReadToEnd();
                }
                else { throw new Exception($"Error: {response.StatusCode} - {response.ReasonPhrase}"); }
            }
            catch (Exception e) { throw new Exception($"Error: ", e); }
        }
        public void ModificarProducto(ModificarProducto producto)
        {
            string apiPath = "Producto/ModificarProducto";

            var request = JsonConvert.SerializeObject(producto);

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
            catch (Exception e) { throw new Exception($"Error: ", e); }
        }
        public void ReactivarProducto(ReactivarProducto producto)
        {
            string apiPath = "Producto/ReactivarProducto";

            var request = JsonConvert.SerializeObject(producto);

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
            catch (Exception e) { throw new Exception($"Error: ", e); }
        }
        public List<Producto> GetProductos()
        {
            String apiPath = "Producto/TraerProductos";
            List<Producto> productos = new List<Producto>();
            try
            {
                HttpResponseMessage response = WebHelper.Get(apiPath);
                if (response.IsSuccessStatusCode)
                {
                    var contentStream = response.Content.ReadAsStringAsync().Result;
                    List<Producto> listadoProductos = JsonConvert.DeserializeObject<List<Producto>>(contentStream);
                    return listadoProductos;
                }
                else { Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}"); }
            }
            catch (Exception e) { throw new Exception($"Error: ", e); }

            return productos;

        }
        public List<Producto> GetProductosporCategoria(int categoria)
        {
            string apiPath = $"Producto/TraerProductosPorCategoria?catnum={categoria}";

            List<Producto> productos = new List<Producto>();
            try
            {
                HttpResponseMessage response = WebHelper.Get(apiPath);
                if (response.IsSuccessStatusCode)
                {
                    var contentStream = response.Content.ReadAsStringAsync().Result;
                    List<Producto> productosCategoria = JsonConvert.DeserializeObject<List<Producto>>(contentStream);
                    return productosCategoria;
                }
                else { Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}"); }
            }
            catch (Exception e) { throw new Exception($"Error: ", e); }

            return productos;
        }
    }
}
