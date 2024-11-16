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

namespace TemplateTPIntegrador
{
    public partial class FrmCliente : Form
    {
        private ClienteNegocio clienteNegocio = new ClienteNegocio();
        private UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
        private ProductoNegocio productoNegocio = new ProductoNegocio();
        private int perfilUsuario;
        private string DNIcliente;
        private Guid idUsuario;
        string userLogueado = UsuarioLogueado.nombreUsuario;

        public FrmCliente(int perfilUsuario)
        {
            InitializeComponent();
            this.perfilUsuario = perfilUsuario;
            this.FormClosing += FrmCliente_cerrar;
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            lblAlertaClientes.Visible = false;
            cargarClientes();
        }

        private void cargarClientes()
        {
            List<Cliente> clientes = clienteNegocio.ObtenerClientes();

            clientes = clientes.OrderBy(c => c.apellido).ToList();

            var bindingList = new BindingList<Cliente>(clientes);
            var source = new BindingSource(bindingList, null);
            listaclientes.DataSource = source;

            // Se ocultan las columnas no necesarias
            listaclientes.Columns["id"].Visible = false;
            listaclientes.Columns["fechaBaja"].Visible = false;
            listaclientes.Columns["idusuario"].Visible = false;
            listaclientes.Columns["fechaNacimiento"].Visible = false;
            listaclientes.Columns["fechaAlta"].Visible = false;
        }

        private void listacliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Cliente cliente = (Cliente)listaclientes.Rows[listaclientes.CurrentCell.RowIndex].DataBoundItem;
            txtNombreCliente.Text = cliente.nombre;
            txtApellido.Text = cliente.apellido;
            txtDNI.Text = cliente.dni.ToString();
            txtDireccionCliente.Text = cliente.direccion;
            txtTelCliente.Text = cliente.telefono;
            txtEmailCliente.Text = cliente.email;
            fechanaccampo.Value = cliente.fechaNacimiento;
        }

        private void FrmCliente_cerrar(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void btnVolverInicio_Click(object sender, EventArgs e)
        {
            FrmMain frmMain = new FrmMain(perfilUsuario, usuarioNegocio, productoNegocio);
            frmMain.Show();
            this.Hide();
        }

        private void btnDarBajaCliente_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = (Cliente)listaclientes.Rows[listaclientes.CurrentCell.RowIndex].DataBoundItem;
                if (cliente == null)
                {
                    lblAlertaClientes.Visible = true;
                    lblAlertaClientes.ForeColor = Color.Red;
                    lblAlertaClientes.Text = "Seleccione un cliente para eliminar.";
                    return;
                }

                BajaCliente clienteaborrar = new BajaCliente(idUsuario);
                clienteNegocio.BajaCliente(clienteaborrar);

                lblAlertaClientes.Visible = true;
                lblAlertaClientes.ForeColor = Color.Green;
                lblAlertaClientes.Text = $"El cliente {cliente.nombre} {cliente.apellido} ha sido dado de baja";
                cargarClientes();
            }
            catch (Exception ex)
            {
                lblAlertaClientes.Visible = true;
                lblAlertaClientes.ForeColor = Color.Red;
                lblAlertaClientes.Text = "Se ha detectado un error. Vuelva a intentarlo, si persiste contacte a su administrador.";
            }
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = (Cliente)listaclientes.Rows[listaclientes.CurrentCell.RowIndex].DataBoundItem;

                if (cliente == null)
                {
                    lblAlertaClientes.Visible = true;
                    lblAlertaClientes.ForeColor = Color.Red;
                    lblAlertaClientes.Text = "Seleccione un cliente para modificar.";
                    return;
                }

                string nombreActual = cliente.nombre;
                string apellidoActual = cliente.apellido;
                string nombreNuevo = txtNombreCliente.Text;
                string apellidoNuevo = txtApellido.Text;

                if (nombreActual != nombreNuevo || apellidoActual != apellidoNuevo)
                {
                    lblAlertaClientes.Visible = true;
                    lblAlertaClientes.ForeColor = Color.Red;
                    lblAlertaClientes.Text = "No se puede modificar Nombre o Apellido.";
                    return;
                }

                Guid idCliente = cliente.id;
                String direccion = txtDireccionCliente.Text;
                String telefono = txtTelCliente.Text;
                String email = txtEmailCliente.Text;
                ModificarCliente clienteamodificar = new ModificarCliente(idCliente, direccion, telefono, email);
                idUsuario = cliente.id;

                int DNIcliente = int.Parse(txtDNI.Text);

                clienteNegocio.ModificarCliente(clienteamodificar, DNIcliente);

                lblAlertaClientes.Visible = true;
                lblAlertaClientes.ForeColor = Color.Green;
                lblAlertaClientes.Text = $"El cliente {cliente.nombre} {cliente.apellido} ha sido modificado correctamente";

                cargarClientes();
            }
            catch (Exception ex)
            {
                lblAlertaClientes.Visible = true;
                lblAlertaClientes.ForeColor = Color.Red;
                lblAlertaClientes.Text = "Se ha detectado un error. Vuelva a intentarlo, si persiste contacte a su administrador.";
            }
        }

        private void btnReactivarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = (Cliente)listaclientes.Rows[listaclientes.CurrentCell.RowIndex].DataBoundItem;
                if (cliente == null)
                {
                    lblAlertaClientes.Visible = true;
                    lblAlertaClientes.ForeColor = Color.Red;
                    lblAlertaClientes.Text = "Seleccione un cliente para reactivar.";
                    return;
                }

                ReactivarCliente clienteareactivar = new ReactivarCliente(idUsuario);
                clienteNegocio.ReactivarCliente(clienteareactivar);

                lblAlertaClientes.Visible = true;
                lblAlertaClientes.ForeColor = Color.Green;
                lblAlertaClientes.Text = $"El cliente {cliente.nombre} {cliente.apellido} ha sido reactivado";
                cargarClientes();
            }
            catch (Exception ex)
            {
                lblAlertaClientes.Visible = true;
                lblAlertaClientes.ForeColor = Color.Red;
                lblAlertaClientes.Text = "Se ha detectado un error. Vuelva a intentarlo, si persiste contacte a su administrador.";
            }
        }

        // Métodos de Validación
        private bool ValidarCamposRequeridos(Dictionary<Control, string> controlEtiquetaMap)
        {
            ValidadorUtilis validador = new ValidadorUtilis();
            string errorCamposIncompletos = validador.ValidarCamposCompletos(this, controlEtiquetaMap);

            if (!string.IsNullOrEmpty(errorCamposIncompletos))
            {
                MostrarMensaje(errorCamposIncompletos, Color.Red);
                return false;
            }
            return true;
        }

        private bool ValidarDNI(string dniTexto)
        {
            if (!int.TryParse(dniTexto, out int dni))
            {
                MostrarMensaje("El campo 'DNI' debe ser un número válido.", Color.Red);
                return false;
            }
            if (dni < 1000000 || dni > 99999999)
            {
                MostrarMensaje("El 'DNI' debe ser entre 1.000.000 y 99.999.999.", Color.Red);
                return false;
            }
            return true;
        }

        private bool ValidarEmail(string email)
        {
            if (!email.Contains("@"))
            {
                MostrarMensaje("El campo 'Email' debe contener un '@'.", Color.Red);
                return false;
            }
            return true;
        }

        private bool ValidarEdad(DateTime fechaNacimiento)
        {
            int edad = DateTime.Now.Year - fechaNacimiento.Year;
            if (fechaNacimiento > DateTime.Now.AddYears(-edad)) edad--;
            if (edad < 18)
            {
                MostrarMensaje("El cliente debe tener al menos 18 años.", Color.Red);
                return false;
            }
            return true;
        }

        // Método para mostrar mensajes en el label de alerta
        private void MostrarMensaje(string mensaje, Color color)
        {
            lblAlertaClientes.Visible = true;
            lblAlertaClientes.ForeColor = color;
            lblAlertaClientes.Text = mensaje;
        }

        // Método para limpiar los campos
        private void LimpiarCampos()
        {
            txtNombreCliente.Text = "";
            txtApellido.Text = "";
            txtDNI.Text = "";
            txtDireccionCliente.Text = "";
            txtTelCliente.Text = "";
            txtEmailCliente.Text = "";
            fechanaccampo.Value = fechanaccampo.MaxDate;
        }

        private void btnAltaCliente_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Map de controles y etiquetas
                var controlEtiquetaMap = new Dictionary<Control, string>
        {
            { txtNombreCliente, "Nombre" },
            { txtApellido, "Apellido" },
            { txtDNI, "DNI" },
            { txtDireccionCliente, "Dirección" },
            { txtTelCliente, "Teléfono" },
            { txtEmailCliente, "Email" }
        };

                // Validación de campos
                if (!ValidarCamposRequeridos(controlEtiquetaMap)) return;

                // Validación de DNI
                if (!ValidarDNI(txtDNI.Text)) return;

                // Validación de Email
                if (!ValidarEmail(txtEmailCliente.Text)) return;

                // Validación de Edad
                if (!ValidarEdad(fechanaccampo.Value)) return;

                // Registro de Cliente
                int dni = int.Parse(txtDNI.Text);
                DateTime fechaNacimiento = fechanaccampo.Value;  // Agregado para almacenar la fecha de nacimiento

                // Creación del GUID para idUsuario
                Guid idUsuario = Guid.NewGuid();  // Generación de un GUID único

                // Creación de la instancia de AltaCliente con el GUID
                AltaCliente clienteNuevo = new AltaCliente(idUsuario, txtNombreCliente.Text, txtApellido.Text, dni, txtDireccionCliente.Text, txtTelCliente.Text, txtEmailCliente.Text, fechaNacimiento);

                clienteNegocio.AltaCliente(clienteNuevo);

                LimpiarCampos();
                cargarClientes();

                MostrarMensaje("Cliente agregado correctamente", Color.Green);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al agregar el cliente: " + ex.Message + "\n\n" + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
