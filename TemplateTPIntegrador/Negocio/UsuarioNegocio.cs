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
        private const string PathDB = @"/TemplateTPIntegrador/Persistencia/Data/Usuarios.json";

        public void AgregarUsuario(string guidUsuarioString, string nombre, string apellido, int dni, string direccion, string telefono, string email, DateTime fechaNacimiento, string nombreUsuario, string contraseña, int host)
        {
            var altaUsuario = new AltaUsuario(guidUsuarioString, nombre, apellido, dni, direccion, telefono, email, fechaNacimiento, nombreUsuario, contraseña, host);
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

            if (File.Exists(PathDB))
            {
                var json = File.ReadAllText(PathDB);
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
            return File.Exists(PathDB)
                ? JsonConvert.DeserializeObject<List<UsuarioPersistenteBaja>>(File.ReadAllText(PathDB)) ?? new List<UsuarioPersistenteBaja>()
                : new List<UsuarioPersistenteBaja>();
        }

        private void EscribirUsuariosBajaEnJson(List<UsuarioPersistenteBaja> usuariosBaja)
        {
            var serializedData = JsonConvert.SerializeObject(usuariosBaja, Formatting.Indented);
            File.WriteAllText(PathDB, serializedData);
        }


        public List<UsuarioPersistenteBaja> ObtenerUsuariosDadosDeBaja()
        {
            return CargarUsuariosBajaDesdeJson();
        }

        public void BorrarUsuarioPorLoginFallido(string nombreUsuario)
        {
            List<Usuario> usuarios = usuarioService.GetUsuarios(IdAdministrador);
            var usuario = usuarios.FirstOrDefault(u => u.NombreUsuario == nombreUsuario); 

            if (usuario != null)
            {
                string idUsuario = usuario.id.ToString();
                BorrarUsuario(idUsuario, IdAdministrador, usuario.NombreUsuario, usuario._Nombre, usuario._Apellido);
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

        public void CambiarContraseña(string usuario, string contraseñaActual, string nuevaContraseña)
        {
            try
            {
                int loginResult = Login(usuario, contraseñaActual);
                if (loginResult != -1)
                {
                    string validacionContraseña = ValidarContraseña(contraseñaActual, nuevaContraseña);
                    if (!string.IsNullOrEmpty(validacionContraseña))
                    {
                        throw new Exception(validacionContraseña);
                    }
                    // Crear un objeto de CambiarContraseña y pasar a la capa de persistencia
                    var cambiarContraseña = new CambiarContraseña(usuario, contraseñaActual, nuevaContraseña);
                    UsuarioWS usuarioWS = new UsuarioWS();
                    usuarioWS.CambiarContraseña(cambiarContraseña);
                    usuarioWS.CambiarContraseñaUsuarioPersistente(usuario, nuevaContraseña);
                }
                else
                {
                    throw new Exception("La contraseña actual es incorrecta");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cambiar la contraseña en la capa de negocio.", ex);
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
