using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemplateTPIntegrador
{
    public class ValidacionesUtils
    {
        public string ValidarUsuario(string usuario, string contraseña, int dni, string nombre, string apellido, DateTime fechaNacimiento, int host)
        {
            usuario = usuario.ToLower();
            nombre = nombre.ToLower();
            apellido = apellido.ToLower();

            if (usuario.Length < 8 || usuario.Length > 15)
            {
                return "El nombre de usuario debe de tener entre 8 y 15 caracteres.";
            }
            if (usuario.Contains(nombre) || usuario.Contains(apellido))
            {
                return "El nombre de usuario no puede contener ni el nombre ni el apellido del usuario";
            }
            if (contraseña.Length < 8 || contraseña.Length > 15)
            {
                return "La contraseña debe de tener entre 8 y 15 caracteres entre letras y números.";
            }
            if (!contraseña.Any(char.IsDigit) || !contraseña.Any(char.IsUpper))
            {
                return "La contraseña debe de contener como mínimo una letra mayúscula y un número.";
            }

            if (dni < 1000000 || dni > 99999999)
            {
                return "DNI inválido";
            }
            return string.Empty;
        }
        public string ValidarCamposCompletos(Form form, Dictionary<Control, string> controlEtiquetaMap)
        {
            StringBuilder camposIncompletos = new StringBuilder();

            foreach (Control control in form.Controls)
            {
                if (control is TextBox textBox && string.IsNullOrWhiteSpace(textBox.Text))
                {
                    string etiqueta = "";
                    if (controlEtiquetaMap.TryGetValue(control, out etiqueta))
                    {
                        camposIncompletos.AppendLine($"El campo '{etiqueta}' no puede estar vacío.");
                    }
                    else
                    {
                        camposIncompletos.AppendLine($"El campo '{control.Name}' no puede estar vacío.");
                    }
                }
            }
            return camposIncompletos.ToString();
        }
        public string ValidarContraseña(string contraseñaActual, string nuevaContraseña)
        {
            if (contraseñaActual == nuevaContraseña)
            {
                return "La nueva contraseña no puede ser igual a la actual.";
            }
            if (nuevaContraseña.Length < 8 || nuevaContraseña.Length > 15)
            {
                return "La contraseña debe de tener entre 8 y 15 caracteres entre letras y números."; ;
            }
            if (!nuevaContraseña.Any(char.IsDigit) || !nuevaContraseña.Any(char.IsUpper))
            {
                return "La contraseña debe de contener como mínimo una letra mayúscula y un número.";
            }
            return "";
        }
    }
}
