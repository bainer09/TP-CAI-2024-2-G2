using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TemplateTPIntegrador
{
    public class ValidacionesUtils
    {
        public bool ValidarStringVacio(string dato)
        {
            if (dato == "")
            {
                return true;
            }

            return false;
        }

        public bool ValidarCamposTexto(List<string> campos)
        {
            return campos.Any(campo => string.IsNullOrEmpty(campo));
        }

        public bool ValidarCamposCheckbox(List<bool> campos)
        {
            return campos.All(campo => campo == false);
        }

        public bool ValidarFormatoMail(string mail)
        {

            return !Regex.IsMatch(mail, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");

        }

        public bool ValidarLongitud(string campo, int longitud)
        {
            return campo.Length < longitud;
        }
    }
}
