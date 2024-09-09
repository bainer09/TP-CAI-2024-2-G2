using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ValidacionesUtils
    {
        public bool ValidarNombreUsuario(string username)
        {
            if (username.Length < 8)
            {
                return true;
            }

            return false;
        }
    }
}
