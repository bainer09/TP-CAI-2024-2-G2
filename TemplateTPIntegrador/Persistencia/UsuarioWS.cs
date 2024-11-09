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
    public class UsuarioWS
    {
        private const string usuariosPath = @"/TemplateTPIntegrador/Persistencia/Data/Usuarios.json";

        public List<Usuario> GetUsuarios(string admin)
        {
            string apiPath = $"Usuario/TraerUsuariosActivos?id={admin}";
            List<Usuario> usuarios = new List<Usuario>();

            try
            {
                HttpResponseMessage response = WebHelper.Get(apiPath);
                if (response.IsSuccessStatusCode)
                {
                    var contentStream = response.Content.ReadAsStringAsync().Result;
                    List<Usuario> listadoUsuarios = JsonConvert.DeserializeObject<List<Usuario>>(contentStream);
                    return listadoUsuarios;
                }
                else
                {
                    Console.WriteLine($"Código de error: {response.StatusCode}");
                }
            }
            catch (Exception e) { Console.WriteLine(e.Message); }

            return usuarios;

        }
        public void AltaUsuario(AltaUsuario usuario)
        {
            string apiPath = "Usuario/AgregarUsuario";

            var request = JsonConvert.SerializeObject(usuario);

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
                    throw new Exception($"Código de error: {response.StatusCode}");
                }
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
        }
        public void AltaUsuarioPersistente(UsuarioPersistente usuario)
        {
            List<UsuarioPersistente> usuarios;

            if (File.Exists(usuariosPath))
            {
                string json = File.ReadAllText(usuariosPath);
                usuarios = JsonConvert.DeserializeObject<List<UsuarioPersistente>>(json);
            }
            else
            {
                usuarios = new List<UsuarioPersistente>();
            }
            usuarios.Add(usuario);

            string nuevoJson = JsonConvert.SerializeObject(usuarios, Formatting.Indented);
            File.WriteAllText(usuariosPath, nuevoJson);
        }
        public void LeerUsuarioPersistente()
        {
            if (!File.Exists(usuariosPath)) { throw new FileNotFoundException("Archivo no encontrado."); }
            string json = File.ReadAllText(usuariosPath);
            List<UsuarioPersistente> usuarios = JsonConvert.DeserializeObject<List<UsuarioPersistente>>(json);

            if (usuarios != null && usuarios.Count > 0)
            {
                foreach (var usuario in usuarios)
                {
                    string nombreUsuario = usuario._Usuario;
                    string contraseña = usuario._Contrasenia;
                    DateTime? fechaCambioClave = usuario._FechaContrasenia;
                }
            }

        }
        public void CambiarContraseñaUsuarioPersistente(string usuario, string nuevaClave)
        {
            try
            {
                if (!File.Exists(usuariosPath)) { throw new FileNotFoundException("Archivo no encontrado."); }

                string json = File.ReadAllText(usuariosPath);
                List<UsuarioPersistente> usuarios = JsonConvert.DeserializeObject<List<UsuarioPersistente>>(json);

                bool usuarioEncontrado = false;
                foreach (var u in usuarios)
                {
                    if (u._Usuario == usuario)
                    {
                        u._Contrasenia = nuevaClave;
                        u._FechaContrasenia = DateTime.Now;
                        usuarioEncontrado = true;
                        break;
                    }
                }
                if (!usuarioEncontrado) { throw new Exception("Usuario no encontrado."); }

                string jsonActualizado = JsonConvert.SerializeObject(usuarios, Formatting.Indented);
                File.WriteAllText(usuariosPath, jsonActualizado);
            }
            catch (Exception e) { throw new Exception("Error: ", e); }

        }
        public void BajaUsuarioPersistente(string usuario)
        {
            try
            {
                if (!File.Exists(usuariosPath)) { throw new FileNotFoundException("Archivo no encontrado."); }

                string json = File.ReadAllText(usuariosPath);
                List<UsuarioPersistente> usuarios = JsonConvert.DeserializeObject<List<UsuarioPersistente>>(json);

                UsuarioPersistente usuarioAEliminar = usuarios.Find(u => u._Usuario == usuario);

                if (usuarioAEliminar == null) { throw new Exception("Usuario no encontrado."); }

                usuarios.Remove(usuarioAEliminar);

                string jsonActualizado = JsonConvert.SerializeObject(usuarios, Formatting.Indented);
                File.WriteAllText(usuariosPath, jsonActualizado);
            }
            catch (Exception e) { throw new Exception("Error al eliminar el usuario: ", e); }
        }
        public bool esPrimerLogin(string nombreUsuario)
        {
            if (File.Exists(usuariosPath))
            {
                string json = File.ReadAllText(usuariosPath);
                List<UsuarioPersistente> usuarios = JsonConvert.DeserializeObject<List<UsuarioPersistente>>(json);

                UsuarioPersistente usuario = usuarios.Find(u => u._Usuario == nombreUsuario);

                if (usuario != null && usuario._Contrasenia == "CAI20232")
                {
                    return true;
                }
            }
            return false;
        }
        public bool VerificarExpiracionContraseña(string usuario)
        {
            if (File.Exists(usuariosPath))
            {
                string json = File.ReadAllText(usuariosPath);
                List<UsuarioPersistente> usuarios = JsonConvert.DeserializeObject<List<UsuarioPersistente>>(json);

                UsuarioPersistente usuarioEncontrado = usuarios.Find(u => u._Usuario == usuario);

                if (usuarioEncontrado._FechaContrasenia.HasValue &&
                    (DateTime.Now - usuarioEncontrado._FechaContrasenia.Value).TotalDays > 30)
                {
                    return true;
                }
            }
            return false;
        }
        public int Login(string usuario, string clave, string admin = "9ea1c0da-e541-4846-a9de-8478664a87bb")
        {
            string apiPath = "Usuario/Login";
            try
            {
                var usuarioData = new
                {
                    nombreUsuario = usuario,
                    contrasenia = clave
                };

                string request = JsonConvert.SerializeObject(usuarioData);

                HttpResponseMessage response = WebHelper.Post(apiPath, request);

                if (response.IsSuccessStatusCode)
                {
                    List<Usuario> usuarios = GetUsuarios(admin);
                    Usuario usuarioLogueado = usuarios.FirstOrDefault(u => u._Usuario == usuario);

                    int perfilUsuario = usuarioLogueado._Host;
                    return perfilUsuario;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e) { throw new Exception("Error al intentar iniciar sesión: " + e.Message); }
        }
        public void CambiarContraseña(CambiarContraseña usuario)
        {
            string apiPath = "Usuario/CambiarContraseña";
            var request = JsonConvert.SerializeObject(usuario);

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
            catch (Exception e) { throw new Exception("Error: ", e); }
        }
        public void BajaUsuario(BajaUsuario usuarioBaja)
        {
            string apiPath = "Usuario/BajaUsuario";
            var request = JsonConvert.SerializeObject(usuarioBaja);

            try
            {
                HttpResponseMessage response = WebHelper.DeleteWithBody(apiPath, request);
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
            catch (Exception ex) { throw new Exception($"Error: {ex.Message}", ex); }
        }
        public void ReactivarUsuario(ReactivarUsuario usuario)
        {
            string apiPath = "Usuario/ReactivarUsuario";
            var request = JsonConvert.SerializeObject(usuario);

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
            catch (Exception e) { throw new Exception($"Error: ", e); }
        }
    }
}
