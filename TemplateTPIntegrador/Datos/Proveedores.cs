using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Proveedores
    {
        string _id;
        List<int> _Categorias;
        string _Nombre;
        string _Apellido;
        DateTime _FechaAlta;
        DateTime? _FechaBaja;
        string _CUIT;
        string _Email;
        string _idUsuario;

        public Proveedores(string id, List<int> categorias, string nombre, string apellido, DateTime fechaAlta, DateTime? fechaBaja, string CUIT, string email, string idUsuario)
        {
            _id = id;
            _Categorias = categorias;
            _Nombre = nombre;
            _Apellido = apellido;
            _FechaAlta = fechaAlta;
            _FechaBaja = fechaBaja;
            _CUIT = CUIT;
            _Email = email;
            _idUsuario = idUsuario;
        }

        public string Id { get => _id; set => _id = value; }
        public List<int> Categorias { get => _Categorias; set => _Categorias = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Apellido { get => _Apellido; set => _Apellido = value; }
        public DateTime FechaAlta { get => _FechaAlta; set => _FechaAlta = value; }
        public DateTime? FechaBaja { get => _FechaBaja; set => _FechaBaja = value; }
        public string CUIT { get => _CUIT; set => _CUIT = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string idUsuario { get => _idUsuario; set => _idUsuario = value; }




    }
}
