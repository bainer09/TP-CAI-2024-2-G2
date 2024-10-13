using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Proveedor
    {
        public string _id { get => _id; set => _id = value; }
        public List<int> _Categorias { get => _Categorias; set => _Categorias = value; }
        public string _Nombre { get => _Nombre; set => _Nombre = value; }
        public string _Apellido { get => _Apellido; set => _Apellido = value; }
        public DateTime _FechaAlta { get => _FechaAlta; set => _FechaAlta = value; }
        public DateTime? _FechaBaja { get => _FechaBaja; set => _FechaBaja = value; }
        public string _CUIT { get => _CUIT; set => _CUIT = value; }
        public string _Email { get => _Email; set => _Email = value; }
        public string _idUsuario { get => _idUsuario; set => _idUsuario = value; }

        public Proveedor(string id, List<int> categorias, string nombre, string apellido, DateTime fechaAlta, DateTime? fechaBaja, string CUIT, string email, string idUsuario)
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
    }
    public class AltaProveedor
    {
        public string _idUsuario { get => _idUsuario; set => _idUsuario = value; }
        public string _Nombre { get => _Nombre; set => _Nombre = value; }
        public string _Apellido { get => _Apellido; set => _Apellido = value; }
        public string _Email { get => _Email; set => _Email = value; }
        public string _CUIT { get => _CUIT; set => _CUIT = value; }

        public AltaProveedor(string idUsuario, string Nombre, string Apellido, string Email, string CUIT)
        {
            _idUsuario = idUsuario;
            _Nombre = Nombre;
            _Apellido = Apellido;
            _Email = Email;
            _CUIT = CUIT;
        }
    }
    public class ModificarProveedor
    {
        public string _id { get => _id; set => _id = value; }
        public string _idUsuario { get => _idUsuario; set => _idUsuario = value; }
        public string _Nombre { get => _Nombre; set => _Nombre = value; }
        public string _Apellido { get => _Apellido; set => _Apellido = value; }
        public string _Email { get => _Email; set => _Email = value; }
        public string _CUIT { get => _CUIT; set => _CUIT = value; }

        public ModificarProveedor(string id, string idUsuario, string Nombre, string Apellido, string Email, string CUIT)
        {
            _id = id;
            _idUsuario = idUsuario;
            _Nombre = Nombre;
            _Apellido = Apellido;
            _Email = Email;
            _CUIT = CUIT;
        }
    }
    public class BajaProveedor
    {
        public string _id { get => _id; set => _id = value; }
        public string _idUsuario { get => _idUsuario; set => _idUsuario = value; }

        public BajaProveedor(string id, string idUsuario)
        {
            _id = id;
            _idUsuario = idUsuario;
        }
    }
    public class ReactivarProveedor
    {
        public string _id { get => _id; set => _id = value; }
        public string _idUsuario { get => _idUsuario; set => _idUsuario = value; }

        public ReactivarProveedor(string id, string idUsuario)
        {
            _id = id;
            _idUsuario = idUsuario;
        }
    }
}
