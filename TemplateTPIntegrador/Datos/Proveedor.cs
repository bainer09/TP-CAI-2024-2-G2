using System;

namespace Datos
{
    public class Proveedor
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Cuit {  get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime? FechaBaja { get; set; }
        public Guid IdUsuario { get; set; }

        public Proveedor() { }
        public Proveedor(Guid idUsuario, string nombre, string apellido, string email, string cuit)
        {
            IdUsuario = idUsuario;
            Nombre = nombre;
            Apellido = apellido;
            Email = email;
            Cuit = cuit;
        }

        public Proveedor(Guid idProveedor, Guid idUsuario, string nombre, string apellido, string email, string cuit) : this(idUsuario, nombre, apellido, email, cuit) {
            this.Id = idProveedor;
        }
    }
}
