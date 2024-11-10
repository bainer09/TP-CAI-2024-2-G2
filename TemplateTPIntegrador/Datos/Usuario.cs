using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Usuario
    {
        public string id { get; set; }
        public string _Nombre { get; set; }
        public string _Apellido { get; set; }
        public int _DNI { get; set; }
        public string _Direccion { get; set; }
        public string _Telefono { get; set; }
        public string _Email { get; set; }
        public DateTime _FechaNacimiento { get; set; }
        public DateTime _FechaAlta { get; set; }
        public DateTime? _FechaBaja { get; set; }
        public string NombreUsuario { get; set; }
        public int _Host { get; set; }

        public Usuario(string Id, string nombre, string apellido, int dNI, string direccion, string telefono, string email, DateTime fechaNacimiento, DateTime fechaAlta, DateTime? fechaBaja, string usuario, int host)
        {
            id = Id;
            _Nombre = nombre;
            _Apellido = apellido;
            _DNI = dNI;
            _Direccion = direccion;
            _Telefono = telefono;
            _Email = email;
            _FechaNacimiento = fechaNacimiento;
            _FechaAlta = fechaAlta;
            _FechaBaja = fechaBaja;
            NombreUsuario = usuario;
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
        public DateTime? _FechaContrasenia { get => _FechaContrasenia; set => _FechaContrasenia = value; }

        public UsuarioPersistente(string usuario, string contrasenia, DateTime? fechaContrasenia)
        {
            _Usuario = usuario;
            _Contrasenia = contrasenia;
            _FechaContrasenia = fechaContrasenia;
        }
    }

    public class UsuarioLogueado
    {
        public static string NombreUsuario { get; private set; }

        public static void SetNombreUsuario(string nombre)
        {
            NombreUsuario = nombre;
        }

    }
}
public class UsuarioPersistenteBaja
{
    public string _IdUsuario { get; set; }
    public string _NombreUsuario { get; set; }
    public string _Nombre { get; set; }
    public string _Apellido { get; set; }
    public bool _Estado { get; set; }
    public DateTime _FechaBaja { get; set; }

    public UsuarioPersistenteBaja(string idUsuario, string nombreUsuario, string nombre, string apellido, bool estado, DateTime fechaBaja)
    {
        _IdUsuario = idUsuario;
        _NombreUsuario = nombreUsuario;
        _Nombre = nombre;
        _Apellido = apellido;
        _Estado = estado;
        _FechaBaja = fechaBaja;
    }
}