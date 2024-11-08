using Datos;
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
using static Datos.Usuario;
using Negocio;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net;

namespace Presentacion
{
    public partial class FrmAltaUsuario : Form
    {
        private UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
        private int perfilUsuario;
        private Guid guidUsuario;
        string userLogueado = UsuarioLogueado.NombreUsuario;

        public FrmAltaUsuario(int perfilUsuario)
        {
            InitializeComponent();
            InitializeComboBox();
            this.FormClosing += FrmAltaUsuario_FormClosing;
            this.perfilUsuario = perfilUsuario;
        }

        private void FrmAltaUsuario_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnAltaUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                var controlEtiquetaMap = new Dictionary<Control, string>
                {
                    { txtNombre, "Nombre" },
                    { txtApellido, "Apellido" },
                    { txtDNI, "DNI" },
                    { txtDireccion, "Dirección" },
                    { txtTelefono, "Teléfono" },
                    { txtEmail, "Email" },
                    { txtUsuario, "Nombre de Usuario" }
                };
                if (cbPerfiles.SelectedIndex == -1)
                {
                    lblAlertaAltaUsuario.Visible = true;
                    lblAlertaAltaUsuario.ForeColor = Color.Red;
                    lblAlertaAltaUsuario.Text = "Debe seleccionar un perfil.";
                    return;
                }

                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                int dni;
                if (!Int32.TryParse(txtDNI.Text, out dni))
                {
                    lblAlertaAltaUsuario.Visible = true;
                    lblAlertaAltaUsuario.ForeColor = Color.Red;
                    lblAlertaAltaUsuario.Text = "Debe completar el campo DNI con numeros validos";
                    return;
                }
                string direccion = txtDireccion.Text;
                string telefono = txtTelefono.Text;
                string email = txtEmail.Text;
                if (!email.Contains("@"))
                {
                    lblAlertaAltaUsuario.Visible = true;
                    lblAlertaAltaUsuario.ForeColor = Color.Red;
                    lblAlertaAltaUsuario.Text = "El campo 'Email' debe contener un '@'.";
                    return;
                }
                DateTime fechaNacimiento = dateTimeFechaNacimiento.Value;
                string nombreUsuario = txtUsuario.Text;
                string contraseña = "CAI20232";
                int host = (int)cbPerfiles.SelectedValue;

                DateTime fechaAlta = DateTime.Now;

                ValidadorUtilis validador = new ValidadorUtilis();

                string errorCamposIncompletos = validador.ValidarCamposCompletos(this, controlEtiquetaMap);

                if (!string.IsNullOrEmpty(errorCamposIncompletos))
                {
                    lblAlertaAltaUsuario.ForeColor = Color.Red;
                    lblAlertaAltaUsuario.Text = errorCamposIncompletos;
                    return;
                }

                int edad = DateTime.Now.Year - fechaNacimiento.Year;
                if (fechaNacimiento > DateTime.Now.AddYears(-edad)) edad--;
                if (edad < 18)
                {
                    lblAlertaAltaUsuario.ForeColor = Color.Red;
                    lblAlertaAltaUsuario.Text = "El usuario debe tener al menos 18 años.";
                    return;
                }

                string errorMensaje = validador.ValidarDatosUsuario(nombreUsuario, contraseña, dni, nombre, apellido, fechaNacimiento);

                if (string.IsNullOrEmpty(errorMensaje))
                {
                    List<Usuario> usuarios = usuarioNegocio.ListarUsuarios();
                    Usuario usuario = usuarios.FirstOrDefault(u => u._Usuario == userLogueado);
                    guidUsuario = usuario._id;
                    string guidUsuarioString = guidUsuario.ToString();

                    usuarioNegocio.AgregarUsuario(guidUsuarioString, nombre, apellido, dni, direccion, telefono, email, fechaNacimiento, nombreUsuario, contraseña, host);
                    usuarioNegocio.AgregarUsuarioLocal(nombreUsuario, contraseña);

                    lblAlertaAltaUsuario.Visible = true;
                    lblAlertaAltaUsuario.ForeColor = Color.Green;
                    lblAlertaAltaUsuario.Text = "Usuario creado correctamente";

                    txtNombre.Text = "";
                    txtApellido.Text = "";
                    txtDNI.Text = "";
                    txtDireccion.Text = "";
                    txtTelefono.Text = "";
                    txtEmail.Text = "";
                    dateTimeFechaNacimiento.Value = DateTime.Now;
                    txtUsuario.Text = "";
                }
                else
                {
                    lblAlertaAltaUsuario.Visible = true;
                    lblAlertaAltaUsuario.ForeColor = Color.Red;
                    lblAlertaAltaUsuario.Text = errorMensaje;
                }
            }
            catch (Exception ex)
            {
                lblAlertaAltaUsuario.Visible = true;
                lblAlertaAltaUsuario.ForeColor = Color.Red;
                lblAlertaAltaUsuario.Text = "Se ha producido un error. Vuelva a intentarlo, \nsi persiste contacte a su administrador del Sistema";
            }
        }

        private void InitializeComboBox()
        {
            cbPerfiles.DropDownStyle = ComboBoxStyle.DropDownList;

            var perfiles = new[]
            {
                new { Nombre = "Vendedor", Valor = 1 },
                new { Nombre = "Supervisor", Valor = 2 },
                new { Nombre = "Administrador", Valor = 3 }
            };

            cbPerfiles.DataSource = perfiles;
            cbPerfiles.DisplayMember = "Nombre";
            cbPerfiles.ValueMember = "Valor";
            cbPerfiles.SelectedIndex = -1;
        }

        private void FrmAltaUsuario_Load(object sender, EventArgs e)
        {
            lblAlertaAltaUsuario.Visible = false;
        }
    }
}
