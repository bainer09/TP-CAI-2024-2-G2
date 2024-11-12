using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Usuario
    {
        public Guid id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int dni { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public DateTime fechaAlta { get; set; }
        public DateTime? fechaBaja { get; set; }
        public string nombreUsuario { get; set; }
        public int host { get; set; }

        public Usuario(Guid Id, string Nombre, string Apellido, int dNI, string Direccion, string Telefono, string Email, DateTime FechaNacimiento, DateTime FechaAlta, DateTime? FechaBaja, string usuario, int Host)
        {
            id = Id;
            nombre = Nombre;
            apellido = Apellido;
            dni = dNI;
            direccion = Direccion;
            telefono = Telefono;
            email = Email;
            fechaNacimiento = FechaNacimiento;
            fechaAlta = FechaAlta;
            fechaBaja = FechaBaja;
            nombreUsuario = usuario;
            host = Host;
        }
    }
    public class AltaUsuario
    {
        public string idUsuario { get; set; }
        public int host { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int dni { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public string nombreUsuario { get; set; }
        public string contraseña { get; set; }
        
        public AltaUsuario(string iduser, int Host, string Nombre, string Apellido, int dNI, string Direccion, string Telefono, string Email, DateTime FechaNacimiento, string Usuario, string contrasenia)
        {
            idUsuario = iduser;
            host = Host;
            nombre = Nombre;
            apellido = Apellido;
            dni = dNI;
            direccion = Direccion;
            telefono = Telefono;
            email = Email;
            fechaNacimiento = FechaNacimiento;
            nombreUsuario = Usuario;
            contraseña = contrasenia;
        }
    }
    public class BajaUsuario
    {
        public string id { get; set; }
        public string idUsuario { get; set; }

        public BajaUsuario(string Id, string IdUsuario)
        {
            id = Id;
            idUsuario = IdUsuario;
        }
    }
    public class ReactivarUsuario
    {
        public string id { get; set; }
        public string idUsuario { get; set; }

        public ReactivarUsuario(string Id, string IdUsuario)
        {
            id = Id;
            idUsuario = IdUsuario;
        }
    }
    public class CambiarContraseña
    {
        public string nombreUsuario { get; set; }
        public string contraseña { get; set; }
        public string contraseñaNueva { get; set; }

        public CambiarContraseña(string usuario, string contrasenia, string contraseniaNueva)
        {
            nombreUsuario = usuario;
            contraseña = contrasenia;
            contraseñaNueva = contraseniaNueva;
        }
    }
    public class UsuarioPersistente
    {
        public string _Usuario { get; set; }
        public string _Contrasenia { get; set; }
        public DateTime? _FechaContrasenia { get; set; }

        public UsuarioPersistente(string usuario, string contrasenia, DateTime? fechaContrasenia)
        {
            _Usuario = usuario;
            _Contrasenia = contrasenia;
            _FechaContrasenia = fechaContrasenia;
        }
    }
    public class UsuarioLogueado
    {
        public static string nombreUsuario { get; private set; }

        public static void SetNombreUsuario(string nombre)
        {
            nombreUsuario = nombre;
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
}
