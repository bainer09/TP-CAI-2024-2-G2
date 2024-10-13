using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Usuario
    {
        public string _id { get => _id; set => _id = value; }
        public string _Nombre { get => _Nombre; set => _Nombre = value; }
        public string _Apellido { get => _Apellido; set => _Apellido = value; }
        public int _DNI { get => _DNI; set => _DNI = value; }
        public string _Direccion {  get => _Direccion; set => _Direccion = value; }
        public string _Telefono { get => _Telefono; set => _Telefono = value; }
        public string _Email { get => _Email; set => _Email = value; }
        public DateTime _FechaNacimiento { get => _FechaNacimiento; set => _FechaNacimiento = value; }
        public DateTime _FechaAlta { get => _FechaAlta; set => _FechaAlta = value; }
        public DateTime? _FechaBaja { get => _FechaBaja; set => _FechaBaja = value; }
        public string _Usuario { get => _Usuario; set => _Usuario = value; }
        public string _Contraseña { get => _Contraseña; set => _Contraseña = value; }
        public int _Host { get => _Host; set => _Host = value; }

        public Usuario (string id, string nombre, string apellido, int dNI, string direccion, string telefono, string email, DateTime fechaNacimiento, DateTime fechaAlta, DateTime? fechaBaja, string usuario, string contraseña, int host)
        {
            _id = id;
            _Nombre = nombre;
            _Apellido = apellido;
            _DNI = dNI;
            _Direccion = direccion;
            _Telefono = telefono;
            _Email = email;
            _FechaNacimiento = fechaNacimiento;
            _FechaAlta = fechaAlta;
            _FechaBaja = fechaBaja;
            _Usuario = usuario;
            _Contraseña = contraseña;
            _Host = host;
        }
    }
    public class BajaUsuario
    {
        public string _id { get => _id; set => _id = value; }
        public string _idUsuario { get => _idUsuario; set => _idUsuario = value; }

        public BajaUsuario(string id, string idUsuario)
        {
            _id = id;
            _idUsuario = idUsuario;
        }
    }
    public class ReactivarUsuario
    {
        public string _id { get => _id; set => _id = value; }
        public string _idUsuario { get => _idUsuario; set => _idUsuario = value; }

        public ReactivarUsuario(string id, string idUsuario)
        {
            _id = id;
            _idUsuario = idUsuario;
        }
    }
    public class CambiarContraseña
    {
        public string _Usuario { get => _Usuario; set => _Usuario = value; }
        public string _Contraseña { get => _Contraseña; set => _Contraseña = value; }
        public string _ContraseñaNueva { get => _ContraseñaNueva; set => _ContraseñaNueva = value; }

        public CambiarContraseña(string usuario, string contraseña, string contraseñaNueva)
        {
            _Usuario = usuario;
            _Contraseña = contraseña;
            _ContraseñaNueva = contraseñaNueva;
        }
    }
    public class Login
    {
        public string _Usuario { get => _Usuario; set => _Usuario = value; }
        public string _Contraseña { get => _Contraseña; set => _Contraseña = value; }

        public Login(string usuario, string contraseña)
        {
            _Usuario = usuario;
            _Contraseña = contraseña;
        }
    }
}
