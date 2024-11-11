using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Presentacion
{
    public class ValidadorUtilis
    {
        public string ValidarDatosUsuario(string nombreUsuario, string contraseña, int dni, string nombre, string apellido, DateTime fechaNacimiento)
        {
            // Convertir a minúsculas para evitar coincidencias no deseadas.
            nombreUsuario = nombreUsuario.ToLower();
            nombre = nombre.ToLower();
            apellido = apellido.ToLower();

            // Validar cada componente y devolver el mensaje de error correspondiente.
            if (!EsNombreUsuarioValido(nombreUsuario, nombre, apellido))
                return "Error: El nombre de usuario debe tener entre 8 y 15 caracteres y no contener el nombre o apellido.";

            if (!EsContraseñaValida(contraseña))
                return "Error: La contraseña debe tener entre 8 y 15 caracteres, con al menos una letra mayúscula y un número.";

            if (!EsDniValido(dni))
                return "Error: El DNI debe estar entre 1.000.000 y 99.999.999.";

            if (!EsFechaNacimientoValida(fechaNacimiento))
                return "Error: La fecha de nacimiento indica que el usuario debe tener al menos 18 años.";

            return string.Empty;
        }

        public string ValidarCamposCompletos(Form form, Dictionary<Control, string> controlEtiquetaMap)
        {
            StringBuilder camposIncompletos = new StringBuilder();

            foreach (Control control in form.Controls)
            {
                if (control is TextBox textBox && string.IsNullOrWhiteSpace(textBox.Text))
                {
                    if (controlEtiquetaMap.TryGetValue(control, out string etiqueta))
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
                return "Error: La nueva contraseña no puede ser igual a la contraseña actual.";
            }

            if (!EsContraseñaValida(nuevaContraseña))
            {
                return "Error: La nueva contraseña debe tener entre 8 y 15 caracteres, con al menos una letra mayúscula y un número.";
            }

            return string.Empty;
        }

        // Métodos auxiliares para la validación específica.

        private bool EsNombreUsuarioValido(string nombreUsuario, string nombre, string apellido)
        {
            return nombreUsuario.Length >= 8 && nombreUsuario.Length <= 15 &&
                   !nombreUsuario.Contains(nombre) && !nombreUsuario.Contains(apellido);
        }

        private bool EsContraseñaValida(string contraseña)
        {
            return contraseña.Length >= 8 && contraseña.Length <= 15 &&
                   contraseña.Any(char.IsDigit) && contraseña.Any(char.IsUpper);
        }

        private bool EsDniValido(int dni)
        {
            return dni >= 1000000 && dni <= 99999999;
        }

        private bool EsFechaNacimientoValida(DateTime fechaNacimiento)
        {
            int edadMinima = 18;
            return (DateTime.Now.Year - fechaNacimiento.Year) >= edadMinima;
        }
    }
}
