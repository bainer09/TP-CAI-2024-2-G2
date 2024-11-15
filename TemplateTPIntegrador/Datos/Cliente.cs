using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Cliente
    {
        public Guid id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }
        public int dni { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public DateTime fechaAlta { get; set; }
        public DateTime? fechaBaja { get; set; }
        public Guid idUsuario { get; set; }
        public string host { get; set; }

        public Cliente(Guid id, string nombre, string apellido, string direccion, string telefono, string email, int dNI, DateTime fechaNacimiento, DateTime fechaAlta, DateTime? fechaBaja, Guid idUsuario, string host = "Grupo 2")
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.direccion = direccion;
            this.telefono = telefono;
            this.email = email;
            this.dni = dNI;
            this.fechaNacimiento = fechaNacimiento;
            this.fechaAlta = fechaAlta;
            this.fechaBaja = fechaBaja;
            this.idUsuario = idUsuario;
            this.host = host;
        }
        public Cliente() {}
    }
    public class AltaCliente
    {
        public Guid idUsuario { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int dni { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public string host { get; set; }

        public AltaCliente(Guid idUsuario, string nombre, string apellido, int DNI, string direccion, string telefono, string email, DateTime fechaNacimiento, string host = "Grupo 2")
        {
            this.idUsuario = idUsuario;
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = DNI;
            this.direccion = direccion;
            this.telefono = telefono;
            this.email = email;
            this.fechaNacimiento = fechaNacimiento;
            this.host = host;
        }
    }
    public class ModificarCliente
    {
        public Guid id { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }

        public ModificarCliente(Guid id, string direccion, string telefono, string email)
        {
            this.id = id;
            this.direccion = direccion;
            this.telefono = telefono;
            this.email = email;
        }
    }
    public class BajaCliente
    {
        public Guid id { get; set; }
        public BajaCliente(Guid id)
        {
            this.id = id;
        }
    }
    public class ReactivarCliente
    {
        public Guid id { get; set; }
        public ReactivarCliente(Guid id)
        {
            this.id = id;
        }
    }
}
