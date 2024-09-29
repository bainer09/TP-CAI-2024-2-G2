using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class BajaProveedores
    {
        string _id;
        string _idUsuario;

        public BajaProveedores(string id, string idUsuario)
        {
            _id = id;
            _idUsuario = idUsuario;
        }

        public string id { get => _id; set => _id = value; }
        public string idUsuario { get => _idUsuario; set => _idUsuario = value; }
    }
}
