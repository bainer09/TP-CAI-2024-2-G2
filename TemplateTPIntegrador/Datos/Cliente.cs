using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Cliente
    {
        public string _id { get => _id; set => _id = value; }
        public string _Nombre { get => _Nombre; set => _Nombre = value; }
        public string _Apellido { get => _Apellido; set => _Apellido = value; }
        public string _Direccion { get => _Direccion; set => _Direccion = value; }
        public string _Telefono { get => _Telefono; set => _Telefono = value; }
        public string _Email { get => _Email; set => _Email = value; }
        public int _DNI { get => _DNI; set => _DNI = value; }
        public DateTime _FechaNacimiento { get => _FechaNacimiento; set => _FechaNacimiento = value; }
        public DateTime _FechaAlta { get => _FechaAlta; set => _FechaAlta = value; }
        public DateTime? _FechaBaja { get => _FechaBaja; set => _FechaBaja = value; }
        public string _idUsuario { get => _idUsuario; set => _idUsuario = value; }
        public string _Host { get => _Host; set => _Host = value; }

        public Cliente(string id, string nombre, string apellido, string direccion, string telefono, string email, int dNI, DateTime fechaNacimiento, DateTime fechaAlta, DateTime? fechaBaja, string idUsuario, string host)
        {
            _id = id;
            _Nombre = nombre;
            _Apellido = apellido;
            _Direccion = direccion;
            _Telefono = telefono;
            _Email = email;
            _DNI = dNI;
            _FechaNacimiento = fechaNacimiento;
            _FechaAlta = fechaAlta;
            _FechaBaja = fechaBaja;
            _idUsuario = idUsuario;
            _Host = host;
        }
    }
    public class AltaCliente
    {
        public string _idUsuario { get => _idUsuario; set => _idUsuario = value; }
        public string _Nombre { get => _Nombre; set => _Nombre = value; }
        public string _Apellido { get => _Apellido; set => _Apellido = value; }
        public int _DNI { get => _DNI; set => _DNI = value; }
        public string _Direccion { get => _Direccion; set => _Direccion = value; }
        public string _Telefono { get => _Telefono; set => _Telefono = value; }
        public string _Email { get => _Email; set => _Email = value; }
        public DateTime _FechaNacimiento { get => _FechaNacimiento; set => _FechaNacimiento = value; }
        public string _Host { get => _Host; set => _Host = value; }

        public AltaCliente(string idUsuario, string nombre, string apellido, int DNI, string direccion, string telefono, string email, DateTime fechaNacimiento, string host)
        {
            _idUsuario = idUsuario;
            _Nombre = nombre;
            _Apellido = apellido;
            _DNI = DNI;
            _Direccion = direccion;
            _Telefono = telefono;
            _Email = email;
            _FechaNacimiento = fechaNacimiento;
            _Host = host;
        }
    }
    public class ModificarCliente
    {
        public string _id { get => _id; set => _id = value; }
        public string _Direccion { get => _Direccion; set => _Direccion = value; }
        public string _Telefono { get => _Telefono; set => _Telefono = value; }
        public string _Email { get => _Email; set => _Email = value; }

        public ModificarCliente(string id, string direccion, string telefono, string email)
        {
            _id = id;
            _Direccion = direccion;
            _Telefono = telefono;
            _Email = email;
        }
    }
    public class BajaCliente
    {
        public string _id { get => _id; set => _id = value; }
        public BajaCliente(string id)
        {
            _id = id;
        }
    }
    public class ReactivarCliente
    {
        public string _id { get => _id; set => _id = value; }
        public ReactivarCliente(string id)
        {
            _id = id;
        }
    }
}
