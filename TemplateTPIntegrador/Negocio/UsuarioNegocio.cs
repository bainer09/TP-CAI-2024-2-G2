using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Datos;
using Persistencia;
using static Datos.Usuario;
using System.Xml;

namespace Negocio
{
    public class UsuarioNegocio
    {
        private readonly UsuarioService usuarioService = new UsuarioService();
        private const string IdAdministrador = "70b37dc1-8fde-4840-be47-9ababd0ee7e5";
        private const string PathDB = @"C:\ElectroHogarDB\usuarios_baja.json";

        public void AgregarUsuario(string guidUsuarioString, int valorPerfil, string nombre, string apellido, int dni, string direccion, string telefono, string email, DateTime fechaNacimiento, string nombreUsuario, string contraseña)
        {
            var altaUsuario = new UsuarioAlta(guidUsuarioString, valorPerfil, nombre, apellido, dni, direccion, telefono, email, fechaNacimiento, nombreUsuario, contraseña, null);
            try
            {
                usuarioService.AgregarUsuario(altaUsuario);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar el usuario", ex);
            }
        }

        public void AgregarUsuarioDBLocal(string nombreUsuario, string contraseña)
        {
            var altaUsuarioDBLocal = new UsuarioDBLocal(nombreUsuario, contraseña, false, null);
            usuarioService.EscribirUsuarioDBLocal(altaUsuarioDBLocal);
        }

        public void BorrarUsuario(string idUsuario, string guidUsuarioString, string nombreUsuario, string nombre, string apellido)
        {
            var bajausuario = new UsuarioBaja(idUsuario, guidUsuarioString);
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

        public void BorrarUsuarioDBLocal(string nombreUsuario)
        {
            usuarioService.EliminarUsuarioDBLocal(nombreUsuario);
        }

        private void GuardarUsuarioBajaLocal(string idUsuario, string nombreUsuario, string nombre, string apellido)
        {
            var usuariosBaja = CargarUsuariosBajaDesdeJson();

            usuariosBaja.Add(new UsuarioBajaDBLocal(idUsuario, nombreUsuario, nombre, apellido, false, DateTime.Now));
            EscribirUsuariosBajaEnJson(usuariosBaja);
        }

        public void EliminarUsuarioDeBajasJson(string idUsuario)
        {
            var usuariosBaja = CargarUsuariosBajaDesdeJson();
            var usuarioParaEliminar = usuariosBaja.FirstOrDefault(u => u.IdUsuario == idUsuario);

            if (usuarioParaEliminar != null)
            {
                usuariosBaja.Remove(usuarioParaEliminar);
                EscribirUsuariosBajaEnJson(usuariosBaja);
            }
        }

        private List<UsuarioBajaDBLocal> CargarUsuariosBajaDesdeJson()
        {
            if (File.Exists(PathDB))
            {
                var json = File.ReadAllText(PathDB);
                return JsonConvert.DeserializeObject<List<UsuarioBajaDBLocal>>(json) ?? new List<UsuarioBajaDBLocal>();
            }
            return new List<UsuarioBajaDBLocal>();
        }

        private void EscribirUsuariosBajaEnJson(List<UsuarioBajaDBLocal> usuariosBaja)
        {
            var serializedData = JsonConvert.SerializeObject(usuariosBaja, Formatting.Indented);
            File.WriteAllText(PathDB, serializedData);
        }

        public void ReactivarUsuario(string idUsuario, string guidUsuario)
        {
            try
            {
                usuarioService.ReactivarUsuario(idUsuario, guidUsuario);
                EliminarUsuarioDeBajasJson(idUsuario);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al reactivar el usuario", ex);
            }
        }

        public List<UsuarioBajaDBLocal> ObtenerUsuariosDadosDeBaja()
        {
            return CargarUsuariosBajaDesdeJson();
        }

        public void BorrarUsuarioPorLoginFallido(string nombreUsuario)
        {
            var usuarios = usuarioService.GetUsuarios(IdAdministrador);
            var usuario = usuarios.FirstOrDefault(u => u.NombreUsuario == nombreUsuario);

            if (usuario != null)
            {
                BorrarUsuario(usuario.id.ToString(), IdAdministrador, usuario.NombreUsuario, usuario.Nombre, usuario.Apellido);
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
            return usuarioService.VerificarPrimerLogin(nombreUsuario);
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
                    usuarioService.CambiarContraseña(usuario, contraseñaActual, nuevaContraseña);
                    usuarioService.ActualizarDBLocal(usuario, nuevaContraseña);
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
