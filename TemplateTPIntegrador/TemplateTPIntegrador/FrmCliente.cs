using Datos;
using Negocio;
using Persistencia;
using Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace TemplateTPIntegrador
{
    public partial class FrmCliente : Form
    {
        private ClienteNegocio clienteNegocio = new ClienteNegocio();
        private UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
        private ProductoNegocio productoNegocio = new ProductoNegocio();
        private int perfildelusuario;
        private string DNIcliente;
        private Guid idusuario;
        string userLogueado = UsuarioLogueado.nombreUsuario;
        public FrmCliente(int perfiluser)
        {
            InitializeComponent();
            this.perfildelusuario = perfiluser;
            this.FormClosing += FrmCliente_cerrar;

        }
        private void FrmCliente_Load(object sender, EventArgs e)
        {
            alertacliente.Visible = false;
            cargarClientes();


        }

     
        private void cargarClientes()
        {
            List<Cliente> clientes = clienteNegocio.ObtenerClientes();

            clientes = clientes.OrderBy(c => c.apellido).ToList();

            var bindingList = new BindingList<Cliente>(clientes);
            var source = new BindingSource(bindingList, null);
            listaclientes.DataSource = source;
            listaclientes.Columns["id"].Visible = false;
            listaclientes.Columns["fechaBaja"].Visible = false;
            listaclientes.Columns["NombreCompleto"].Visible = false;

        }
        private void listacliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Cliente cliente = (Cliente)listaclientes.Rows[listaclientes.CurrentCell.RowIndex].DataBoundItem;
            textnombrecliente.Text = cliente.nombre;
            Textapellido.Text = cliente.apellido;
            texDNI.Text = cliente.dni.ToString();
            texdireccioncliente.Text = cliente.direccion;
            textelcliente.Text = cliente.telefono;
            texemailcliente.Text = cliente.email;
            fechanaccampo.Value = cliente.fechaNacimiento;
        }

        private void FrmCliente_cerrar(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }



        private void botondardebajacliente_Click(object sender, EventArgs e)
        {

            try
            {
                Cliente cliente = (Cliente)listaclientes.Rows[listaclientes.CurrentCell.RowIndex].DataBoundItem;
                if (cliente == null)
                {
                    alertacliente.Visible = true;
                    alertacliente.ForeColor = Color.Red;
                    alertacliente.Text = "Seleccione un cliente para eliminar.";
                    return;
                }

                BajaCliente clienteaborrar = new BajaCliente(idusuario);
                clienteNegocio.BajaCliente(clienteaborrar);
                alertacliente.Visible = true;
                alertacliente.ForeColor = Color.Green;
                alertacliente.Text = $"El cliente {cliente.nombre} \n {cliente.apellido}\n ha sido dado de baja";
                cargarClientes();

            }
            catch (Exception ex)
            {
                alertacliente.Visible = true;
                alertacliente.ForeColor = Color.Red;
                alertacliente.Text = "Se ha detectado un error. Vuelva a intentarlo, \nsi persiste contacte a su administrador.";
            }

        }

        private void Botonmodificarcliente_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = (Cliente)listaclientes.Rows[listaclientes.CurrentCell.RowIndex].DataBoundItem;

                if (cliente == null)
                {
                    alertacliente.Visible = true;
                    alertacliente.ForeColor = Color.Red;
                    alertacliente.Text = "Seleccione un cliente para modificar.";
                    return;
                }

                string nombreActual = cliente.nombre;
                string apellidoActual = cliente.apellido;
                string nombreNuevo = textnombrecliente.Text;
                string apellidoNuevo = Textapellido.Text;

                if (nombreActual != nombreNuevo || apellidoActual != apellidoNuevo)
                {
                    alertacliente.Visible = true;
                    alertacliente.ForeColor = Color.Red;
                    alertacliente.Text = "No se puede modificar Nombre o Apellido.";
                    return;
                }

                Guid idCliente = cliente.id;
                String direccion = texdireccioncliente.Text;
                String telefono = textelcliente.Text;
                String email = texemailcliente.Text;
                ModificarCliente clienteamodificar = new ModificarCliente(idCliente, direccion, telefono, email);
                idusuario = cliente.id;


                int DNIcliente = int.Parse(texDNI.Text);

                clienteNegocio.ModificarCliente(clienteamodificar, DNIcliente);

                alertacliente.Visible = true;
                alertacliente.ForeColor = Color.Green;
                alertacliente.Text = $"El cliente {cliente.nombre} \n{cliente.apellido} \nha sido modificado correctamente";

                cargarClientes();
            }
            catch (Exception ex)
            {
                alertacliente.Visible = true;
                alertacliente.ForeColor = Color.Red;
                alertacliente.Text = "Se ha detectado un error. Vuelva a intentarlo, \nsi persiste contacte a su administrador.";
            }
        }



        private void Reactivarboton_Click(object sender, EventArgs e)
        {

            try
            {
                Cliente cliente = (Cliente)listaclientes.Rows[listaclientes.CurrentCell.RowIndex].DataBoundItem;
                if (cliente == null)
                {
                    alertacliente.Visible = true;
                    alertacliente.ForeColor = Color.Red;
                    alertacliente.Text = "Seleccione un cliente para reactivar.";
                    return;
                }

                ReactivarCliente clienteareactivar = new ReactivarCliente(idusuario);
                clienteNegocio.ReactivarCliente(clienteareactivar);
                alertacliente.Visible = true;
                alertacliente.ForeColor = Color.Green;
                alertacliente.Text = $"El cliente {cliente.nombre} \n {cliente.apellido}\n ha sido dado de reactivado";
                cargarClientes();

            }
            catch (Exception ex)
            {
                alertacliente.Visible = true;
                alertacliente.ForeColor = Color.Red;
                alertacliente.Text = "Se ha detectado un error. Vuelva a intentarlo, \nsi persiste contacte a su administrador.";
            }

        }

        private void Registrarusuarioboton_Click(object sender, EventArgs e)
        {
            try
            {
                

                string nombre = textnombrecliente.Text;
                string apellido = Textapellido.Text;

                int dni = int.Parse(texDNI.Text);

                if (dni < 1000000 || dni > 99999999)
                {
                    alertacliente.Visible = true;
                    alertacliente.ForeColor = Color.Red;
                    alertacliente.Text = "El 'DNI' debe ser entre 1.000.000 y 99.999.999.";
                    return;
                }

                string direccion = texdireccioncliente.Text;
                string telefono = textelcliente.Text;
                string email = texemailcliente.Text;
                if (!email.Contains("@"))
                {
                    alertacliente.Visible = true;
                    alertacliente.ForeColor = Color.Red;
                    alertacliente.Text = "El campo 'Email' debe contener un '@'.";
                    return;
                }
                if (int.TryParse(texDNI.Text, out dni))
                {
                    alertacliente.Visible = true;
                    alertacliente.ForeColor = Color.Red;
                    alertacliente.Text = "El campo 'DNI' debe ser un número válido.";
                    return;
                }

                DateTime fechaNacimiento = fechanaccampo.Value;

                int edad = DateTime.Now.Year - fechaNacimiento.Year;
                if (fechaNacimiento > DateTime.Now.AddYears(-edad)) edad--;
                if (edad < 18)
                {
                    alertacliente.Visible = true;
                    alertacliente.ForeColor = Color.Red;
                    alertacliente.Text = "El cliente debe tener al menos 18 años.";
                    return;
                }



                List<Usuario> usuarios = usuarioNegocio.listarUsuarios();
                Usuario usuario = usuarios.FirstOrDefault(user => user.nombreUsuario == userLogueado);
                AltaCliente clientearegistrar = new AltaCliente(idusuario,nombre,apellido, dni, direccion, telefono, email,fechaNacimiento,"Grupo 2");

             


                alertacliente.Visible = true;
                alertacliente.ForeColor = Color.Green;
                alertacliente.Text = "Cliente agregado correctamente";

                textnombrecliente.Text = "";
                Textapellido.Text = "";
                texDNI.Text = "";
                texdireccioncliente.Text = "";
                textelcliente.Text = "";
                texemailcliente.Text = "";
                fechanaccampo.Value = fechanaccampo.MaxDate;

                cargarClientes();
            }
            catch (Exception ex)
            {
                alertacliente.Visible = true;
                alertacliente.ForeColor = Color.Red;
                alertacliente.Text = "Se ha producido un error. Vuelva a intentarlo, \nsi persiste contacte a su administrador.";
            }
        }

        private void Volverainicioboton_Click(object sender, EventArgs e)
        {
            FrmMain frmMain = new FrmMain(perfildelusuario,usuarioNegocio, productoNegocio);
            frmMain.Show();
            this.Hide();
        }
    } 
    }

