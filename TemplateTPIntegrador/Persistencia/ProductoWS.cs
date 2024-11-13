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
            catch (Exception e) { throw new Exception($"Error al dar de alta el producto.\n", e); }
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
            catch (Exception e) { throw new Exception($"Error al dar de baja el producto.\n", e); }
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
            catch (Exception e) { throw new Exception($"Error al modificar el producto.\n", e); }
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
            catch (Exception e) { throw new Exception($"Error al reactivar el producto.\n", e); }
        }
        public List<Producto> GetProductos()
        {
            string apiPath = "Producto/TraerProductos";
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
            catch (Exception e) { throw new Exception($"Error al obtener el listado de productos.\n", e); }

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
            catch (Exception e) { throw new Exception($"Error al obtener el listado de productos de la categoria N°{categoria}.\n", e); }

            return productos;
        }
        public List<Producto> GetProductosDadosDeBaja()
        {
            try
            {
                List<Producto> productos = GetProductos();
                return productos.Where(p => p._FechaBaja != null).ToList();
            } catch (Exception e) { throw new Exception("Error al obtener el listado de productos dados de baja.\n", e); }
        }
    }
    public class ProductoPersistente
    {
        private const string productosPath = @"/TemplateTPIntegrador/Persistencia/Data/Productos.json";
        public void AltaProductoLocal(Producto producto)
        {
            List<Producto> productos;

            if (File.Exists(productosPath))
            {
                string json = File.ReadAllText(productosPath);
                productos = JsonConvert.DeserializeObject<List<Producto>>(json);
            }
            else
            {
                productos = new List<Producto>();
            }
            productos.Add(producto);

            try
            {
                string nuevaData = JsonConvert.SerializeObject(productos, Formatting.Indented);
                File.WriteAllText(productosPath, nuevaData);
            }
            catch (Exception e) { throw new Exception("Error al dar de alta al producto en forma local.\n", e); }

        }
        public void BajaProductoLocal(string nombreProducto)
        {
            string json = File.ReadAllText(productosPath);
            List<Producto> productos = JsonConvert.DeserializeObject<List<Producto>>(json);

            Producto productoBaja = productos.Find(p => p._Nombre == nombreProducto);

            if (productoBaja == null) { throw new Exception("Producto no encontrado."); }

            productoBaja._FechaBaja = DateTime.Now;

            try
            {
                string nuevaData = JsonConvert.SerializeObject(productos, Formatting.Indented);
                File.WriteAllText(productosPath, nuevaData);
            }
            catch (Exception e) { throw new Exception("Error al dar de baja el producto en forma local.\n", e); }
        }
        public void ModificarProductoLocal(string idProducto, double precio, int stock)
        {
            string json = File.ReadAllText(productosPath);
            List<Producto> productos = JsonConvert.DeserializeObject<List<Producto>>(json);
            Producto productoModificacion = productos.Find(p => p._id == idProducto);

            if (productoModificacion == null) { throw new Exception("Producto no encontrado."); }

            productoModificacion._Precio = precio;
            productoModificacion._Stock = stock;

            try
            {
                string nuevaData = JsonConvert.SerializeObject(productos, Formatting.Indented);
                File.WriteAllText(productosPath, nuevaData);
            }
            catch (Exception e) { throw new Exception("Error al modificar el producto en forma local.\n", e); }
        }
        public void ReactivarProductoLocal(string idProducto)
        {
            string json = File.ReadAllText(productosPath);
            List<Producto> productos = JsonConvert.DeserializeObject<List<Producto>>(json);

            Producto productoReactivado = productos.Find(p => p._id == idProducto);

            if (productoReactivado == null) { throw new Exception("Producto no encontrado."); }

            productoReactivado._FechaBaja = null;

            try
            {
                string nuevaData = JsonConvert.SerializeObject(productos, Formatting.Indented);
                File.WriteAllText(productosPath, nuevaData);
            }
            catch (Exception e) { throw new Exception("Error al reactivar el producto en forma local.\n", e); }

        }

        //Metodo que no esta funcionando por problema en el foreach
        /*public void PoblarProductosLocales()
        {
            try
            {
                if (!File.Exists(productosPath) || new FileInfo(productosPath).Length == 0)
                {
                    var productos = new List<Producto>();

                    foreach (int Categoria in Categorias.categoriasProducto.Keys)
                    {
                        var productosPorCategoria = ProductoWS.GetProductosporCategoria((int)categoria);

                        if (productosPorCategoria != null && productosPorCategoria.Any())
                        {
                            productos.AddRange(productosPorCategoria);
                        }
                    }
                    var serializedData = JsonConvert.SerializeObject(productos, Formatting.Indented);

                    File.WriteAllText(productosPath, serializedData);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cargar los productos desde en forma local");
            }
        }*/

    }
}