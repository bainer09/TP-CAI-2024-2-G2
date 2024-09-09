using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateTPIntegrador
{
    public internal class ValidacionesUtils
    {
        public bool ValidarStringVacio (string dato)
        {
            if (dato == "")
            {
                return true;
            }

            return false;
        }
    }
}
