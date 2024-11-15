using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Datos;
using Persistencia;
using static Datos.Usuario;

namespace Negocio
{
    public class UsuarioNegocio
    {
        private readonly UsuarioWS usuarioService = new UsuarioWS();
        private const string IdAdministrador = "9ea1c0da-e541-4846-a9de-8478664a87bb";
        private const string bajasPath = @"/TemplateTPIntegrador/Persistencia/Data/Bajas_Usuario.json";

        public void AgregarUsuario(string guidUsuarioString, int host, string nombre, string apellido, int dni, string direccion, string telefono, string email, DateTime fechaNacimiento, string nombreUsuario, string contraseña)
        {
            var altaUsuario = new AltaUsuario(guidUsuarioString, host, nombre, apellido, dni, direccion, telefono, email, fechaNacimiento, nombreUsuario, contraseña);
            try
            {
                usuarioService.AltaUsuario(altaUsuario);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar el usuario", ex);
            }
        }
        public void AgregarUsuarioLocal(string nombreUsuario, string contraseña)
        {
            var altaUsuarioLocal = new UsuarioPersistente(nombreUsuario, contraseña, null);
            usuarioService.AltaUsuarioPersistente(altaUsuarioLocal);
        }
        public void borrarUsuarioLocal(string Idusuario)
        {
            try
            {
                usuarioService.BajaUsuarioPersistente(Idusuario);

            }
            catch (Exception ex)
            {
                throw new Exception("Error dando de baja el usuario.", ex);
            }
        }
        public List<Usuario> listarUsuarios()
        {
            return usuarioService.GetUsuarios(IdAdministrador);
        }
        public void bajaUser(Usuario user, Guid userlog)
        {
            string Userguid = user.id.ToString();
            string userLog = userlog.ToString();
            BajaUsuario userBaja = new BajaUsuario(Userguid, userLog);

            try
            {
                usuarioService.BajaUsuario(userBaja);
            }
            catch (Exception ex)
            {
                usuarioService.BajaUsuario(userBaja);

                throw new Exception("Error al dar de baja el Usuario", ex);

            }
        }
        public void reactivarUser(Usuario user, Guid userlog)
        {
            string Userguid = user.id.ToString();
            string userLog = userlog.ToString() ;
            ReactivarUsuario userAReact = new ReactivarUsuario(Userguid, userLog);
            try
            {
                usuarioService.ReactivarUsuario(userAReact);
                EliminarUsuarioDeBajasJson(Userguid);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al dar de baja el Usuario", ex);

            }

        }
        public void BorrarUsuario(string idUsuario, string guidUsuarioString, string nombreUsuario, string nombre, string apellido)
        {
            var bajausuario = new BajaUsuario(idUsuario, guidUsuarioString);
            try
            {
                usuarioService.BajaUsuario(bajausuario);
                GuardarUsuarioBajaLocal(idUsuario, nombreUsuario, nombre, apellido);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al dar de baja el usuario", ex);
            }
        }
        public void BorrarUsuarioLocal(string nombreUsuario)
        {
            usuarioService.BajaUsuarioPersistente(nombreUsuario);
        }
        private void GuardarUsuarioBajaLocal(string idUsuario, string nombreUsuario, string nombre, string apellido)
        {
            var usuariosBaja = CargarUsuariosBajaDesdeJson();
            usuariosBaja.Add(new UsuarioPersistenteBaja(idUsuario, nombreUsuario, nombre, apellido, false, DateTime.Now));
            EscribirUsuariosBajaEnJson(usuariosBaja);
        }
        public void EliminarUsuarioDeBajasJson(string idUsuario)
        {
            List<UsuarioPersistenteBaja> usuariosBaja = new List<UsuarioPersistenteBaja>();

            if (File.Exists(bajasPath))
            {
                var json = File.ReadAllText(bajasPath);
                usuariosBaja = JsonConvert.DeserializeObject<List<UsuarioPersistenteBaja>>(json) ?? new List<UsuarioPersistenteBaja>();
            }

            var usuarioParaEliminar = usuariosBaja.FirstOrDefault(u => u._IdUsuario == idUsuario);
            if (usuarioParaEliminar != null)
            {
                usuariosBaja.Remove(usuarioParaEliminar);
                EscribirUsuariosBajaEnJson(usuariosBaja);
            }
        }
        private List<UsuarioPersistenteBaja> CargarUsuariosBajaDesdeJson()
        {
            return File.Exists(bajasPath)
                ? JsonConvert.DeserializeObject<List<UsuarioPersistenteBaja>>(File.ReadAllText(bajasPath)) ?? new List<UsuarioPersistenteBaja>()
                : new List<UsuarioPersistenteBaja>();
        }
        private void EscribirUsuariosBajaEnJson(List<UsuarioPersistenteBaja> usuariosBaja)
        {
            var serializedData = JsonConvert.SerializeObject(usuariosBaja, Formatting.Indented);
            File.WriteAllText(bajasPath, serializedData);
        }
        public List<UsuarioPersistenteBaja> ObtenerUsuariosDadosDeBaja()
        {
            return CargarUsuariosBajaDesdeJson();
        }
        public void BorrarUsuarioPorLoginFallido(string nombreUsuario)
        {
            List<Usuario> usuarios = usuarioService.GetUsuarios(IdAdministrador);
            var usuario = usuarios.FirstOrDefault(u => u.nombreUsuario == nombreUsuario); 

            if (usuario != null)
            {
                string idUsuario = usuario.id.ToString();
                BorrarUsuario(idUsuario, IdAdministrador, usuario.nombreUsuario, usuario.nombre, usuario.apellido);
            }
        }
        public List<Usuario> ListarUsuarios()
        {
            return usuarioService.GetUsuarios(IdAdministrador);
        }
        public int Login(string usuario, string clave)
        {
            try
            {
                return usuarioService.Login(usuario, clave, IdAdministrador);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al intentar iniciar sesión: " + ex.Message);
            }
        }
        public bool VerificarPrimerLogin(string nombreUsuario)
        {
            return usuarioService.esPrimerLogin(nombreUsuario);
        }
        public bool VerificarExpiracionContraseña(string usuario)
        {
            return usuarioService.VerificarExpiracionContraseña(usuario);
        }
        public bool CambiarContraseña(string usuario, string contraseñaActual, string nuevaContraseña, out string mensajeError)
        {
            mensajeError = string.Empty;

            // Verificar si la combinación usuario-contraseña es correcta
            int loginResult = Login(usuario, contraseñaActual);
            if (loginResult == -1)
            {
                mensajeError = "La contraseña actual es incorrecta.";
                return false; // Cambio no realizado
            }

            // Validar nueva contraseña
            string validacionContraseña = ValidarContraseña(contraseñaActual, nuevaContraseña);
            if (!string.IsNullOrEmpty(validacionContraseña))
            {
                mensajeError = validacionContraseña;
                return false; // Cambio no realizado
            }

            // Intentar realizar el cambio de contraseña en la capa de persistencia
            try
            {
                var cambiarContraseña = new CambiarContraseña(usuario, contraseñaActual, nuevaContraseña);
                usuarioService.CambiarContraseña(cambiarContraseña);

                // Comentar o descomentar según tu implementación actual
                // usuarioService.CambiarContraseñaUsuarioPersistente(usuario, nuevaContraseña);

                return true; // Cambio exitoso
            }
            catch (Exception ex)
            {
                mensajeError = "Error al cambiar la contraseña. Contacte al administrador.";
                // Registrar log aquí, si es necesario, para diagnóstico interno
                Console.WriteLine($"Error en CambiarContraseña: {ex.Message}");
                return false; // Cambio no realizado
            }
        }
        internal string ValidarContraseña(string contraseñaActual, string nuevaContraseña)
        {
            if (contraseñaActual == nuevaContraseña)
            {
                return "Error: La nueva contraseña no puede ser igual a la contraseña actual.";
            }

            if (nuevaContraseña.Length < 8 || nuevaContraseña.Length > 15)
            {
                return "Error: La contraseña debe tener entre 8 y 15 caracteres.";
            }
            if (!nuevaContraseña.Any(char.IsDigit) || !nuevaContraseña.Any(char.IsUpper))
            {
                return "Error: La contraseña debe contener al menos una letra mayúscula y un número.";
            }
            return "";
        }
    }
}