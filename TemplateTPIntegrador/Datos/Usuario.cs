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
        public string _Direccion { get => _Direccion; set => _Direccion = value; }
        public string _Telefono { get => _Telefono; set => _Telefono = value; }
        public string _Email { get => _Email; set => _Email = value; }
        public DateTime _FechaNacimiento { get => _FechaNacimiento; set => _FechaNacimiento = value; }
        public DateTime _FechaAlta { get => _FechaAlta; set => _FechaAlta = value; }
        public DateTime? _FechaBaja { get => _FechaBaja; set => _FechaBaja = value; }
        public string _Usuario { get => _Usuario; set => _Usuario = value; }
        public int _Host { get => _Host; set => _Host = value; }

        public Usuario(string id, string nombre, string apellido, int dNI, string direccion, string telefono, string email, DateTime fechaNacimiento, DateTime fechaAlta, DateTime? fechaBaja, string usuario, int host)
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
            _Host = host;
        }


    }
    public class AltaUsuario
    {
        public string _idUsuario { get => _idUsuario; set => _idUsuario = value; }
        public string _Nombre { get => _Nombre; set => _Nombre = value; }
        public string _Apellido { get => _Apellido; set => _Apellido = value; }
        public int _DNI { get => _DNI; set => _DNI = value; }
        public string _Direccion { get => _Direccion; set => _Direccion = value; }
        public string _Telefono { get => _Telefono; set => _Telefono = value; }
        public string _Email { get => _Email; set => _Email = value; }
        public DateTime _FechaNacimiento { get => _FechaNacimiento; set => _FechaNacimiento = value; }
        public string _Usuario { get => _Usuario; set => _Usuario = value; }
        public string _Contrasenia { get => _Contrasenia; set => _Contrasenia = value; }
        public int _Host { get => _Host; set => _Host = value; }

        public AltaUsuario(string idUsuario, string nombre, string apellido, int dNI, string direccion, string telefono, string email, DateTime fechaNacimiento, string usuario, string contrasenia, int host)
        {
            _idUsuario = idUsuario;
            _Nombre = nombre;
            _Apellido = apellido;
            _DNI = dNI;
            _Direccion = direccion;
            _Telefono = telefono;
            _Email = email;
            _FechaNacimiento = fechaNacimiento;
            _Usuario = usuario;
            _Contrasenia = contrasenia;
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
        public string _Contrasenia { get => _Contrasenia; set => _Contrasenia = value; }
        public string _ContraseniaNueva { get => _ContraseniaNueva; set => _ContraseniaNueva = value; }

        public CambiarContraseña(string usuario, string contrasenia, string contraseniaNueva)
        {
            _Usuario = usuario;
            _Contrasenia = contrasenia;
            _ContraseniaNueva = contraseniaNueva;
        }
    }
    public class UsuarioPersistente
    {
        public string _Usuario { get => _Usuario; set => _Usuario = value; }
        public string _Contrasenia { get => _Contrasenia; set => _Contrasenia = value; }
        public DateTime _FechaContrasenia { get => _FechaContrasenia; set => _FechaContrasenia = value; }

        public UsuarioPersistente(string usuario, string contrasenia, DateTime fechaContrasenia)
        {
            _Usuario = usuario;
            _Contrasenia = contrasenia;
            _FechaContrasenia = fechaContrasenia;
        }
    }
}
