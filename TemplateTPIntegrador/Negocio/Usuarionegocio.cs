using Datos;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Usuarionegocio


    {
        private UsuarioWS usuariows = new UsuarioWS();
        private String idAdmin = "70b37dc1-8fde-4840-be47-9ababd0ee7e5";

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

        public void borrarUsuarioLocal(string Idusuario)
        {
            try
            {
                usuariows.BajaUsuarioLocal(Idusuario);

            }
            catch (Exception ex)
            {
                throw new Exception("Error dando de baja el usuario.", ex);
            }
        }
        public void CambiarContraseña(string usuario, string contraseñaActual, string nuevaContraseña)
        {
            CambiarContraseña c = new CambiarContraseña(usuario, contraseñaActual, nuevaContraseña);

            try
            {
                usuariows.CambiarContraseña(c);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar la contraseña.", ex);
            }

        }
        public List<Usuario> listarUsuarios()
        {
            return usuariows.GetUsuarios(idAdmin);
        }


        public void bajaUser(Usuario user)
        {
            BajaUsuario userBaja = new BajaUsuario(user._id, idAdmin);

            try
            {
                usuariows.BajaUsuario(userBaja);

            }
            catch (Exception ex)
            {
                usuariows.BajaUsuario(userBaja);

                throw new Exception("Error al dar de baja el Usuario", ex);

            }
        }

        public void reactivarUser(Usuario user)
        {

            ReactivarUsuario userAReact = new ReactivarUsuario(user._id, idAdmin);
            try
            {
                usuariows.ReactivarUsuario(userAReact);

            }
            catch (Exception ex)
            {
                throw new Exception("Error al dar de baja el Usuario", ex);

            }

        }
    }
}
