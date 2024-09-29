using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class AltaProveedores
    {
        public string _idUsuario { get; set; }
        public string _Nombre { get; set; }
        public string _Apellido { get; set; }
        public string _Email { get; set; }
        public string _CUIT { get; set; }

        public AltaProveedores(string idUsuario, string Nombre, string Apellido, string Email, string CUIT) {
            _idUsuario = idUsuario;
            _Nombre = Nombre;
            _Apellido = Apellido;
            _Email = Email;
            _CUIT = CUIT;
        }

        public string IdUsuario { get => _idUsuario; set => _idUsuario = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Apellido { get => _Apellido; set => _Apellido = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string CUIT { get => _CUIT; set => _CUIT = value; }
    }
}
