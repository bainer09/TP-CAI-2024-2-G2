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
        private string userLogueado = UsuarioLogueado.NombreUsuario;

        public FrmAltaUsuario(int perfilUsuario)
        {
            InitializeComponent();
            InitializeComboBox();
            InitializeFormEvents();
            this.perfilUsuario = perfilUsuario;
        }

        private void InitializeFormEvents()
        {
            this.FormClosing += FrmAltaUsuario_FormClosing;
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
            NavigateToForm(new FrmMain(perfilUsuario));
        }

/*        private void strpAltaUsuariosMenu_Click(object sender, EventArgs e)
        {
            NavigateToForm(new FrmAltaUsuario(perfilUsuario));
        }

        private void strpBajaUsuariosMenu_Click(object sender, EventArgs e)
        {
            NavigateToForm(new FrmBajaModUsuario(perfilUsuario));
        }
*/
        private void NavigateToForm(Form form)
        {
            form.Show();
            this.Hide();
        }

        private void btnAltaUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateFormInputs(out var datosUsuario)) return;

                string errorMensaje = ValidateUserDetails(datosUsuario);

                if (string.IsNullOrEmpty(errorMensaje))
                {
                    CrearUsuario(datosUsuario);
                    MostrarMensaje("Usuario creado correctamente", Color.Green);
                    LimpiarFormulario();
                }
                else
                {
                    MostrarMensaje(errorMensaje, Color.Red);
                }
            }
            catch (Exception ex)
            {
                MostrarMensaje("Se ha producido un error. Vuelva a intentarlo, \nsi persiste contacte a su administrador del Sistema", Color.Red);
            }
        }

        private bool ValidateFormInputs(out UsuarioDatos datosUsuario)
        {
            datosUsuario = new UsuarioDatos();
            var controlEtiquetaMap = CrearControlEtiquetaMap();

            if (!VerificarCamposSeleccionados(controlEtiquetaMap)) return false;
            if (!VerificarDNI(txtDNI.Text, out datosUsuario.Dni)) return false;
            if (!VerificarEmail(txtEmail.Text)) return false;
            if (!VerificarEdadMinima(dateTimeFechaNacimiento.Value)) return false;

            datosUsuario = CrearDatosUsuario();
            return true;
        }

        private Dictionary<Control, string> CrearControlEtiquetaMap()
        {
            return new Dictionary<Control, string>
            {
                { txtNombre, "Nombre" },
                { txtApellido, "Apellido" },
                { txtDNI, "DNI" },
                { txtDireccion, "Dirección" },
                { txtTelefono, "Teléfono" },
                { txtEmail, "Email" },
                { txtUsuario, "Nombre de Usuario" }
            };
        }

        private bool VerificarCamposSeleccionados(Dictionary<Control, string> controlEtiquetaMap)
        {
            if (cbPerfiles.SelectedIndex == -1)
            {
                MostrarMensaje("Debe seleccionar un perfil.", Color.Red);
                return false;
            }

            string errorCamposIncompletos = new ValidadorUtilis().ValidarCamposCompletos(this, controlEtiquetaMap);

            if (!string.IsNullOrEmpty(errorCamposIncompletos))
            {
                MostrarMensaje(errorCamposIncompletos, Color.Red);
                return false;
            }

            return true;
        }

        private bool VerificarDNI(string dniText, out int dni)
        {
            if (!int.TryParse(dniText, out dni))
            {
                MostrarMensaje("Debe completar el campo DNI con numeros validos", Color.Red);
                return false;
            }
            return true;
        }

        private bool VerificarEmail(string email)
        {
            if (!email.Contains("@"))
            {
                MostrarMensaje("El campo 'Email' debe contener un '@'.", Color.Red);
                return false;
            }
            return true;
        }

        private bool VerificarEdadMinima(DateTime fechaNacimiento)
        {
            int edad = DateTime.Now.Year - fechaNacimiento.Year;
            if (fechaNacimiento > DateTime.Now.AddYears(-edad)) edad--;

            if (edad < 18)
            {
                MostrarMensaje("El usuario debe tener al menos 18 años.", Color.Red);
                return false;
            }
            return true;
        }

        private UsuarioDatos CrearDatosUsuario()
        {
            return new UsuarioDatos
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Direccion = txtDireccion.Text,
                Telefono = txtTelefono.Text,
                Email = txtEmail.Text,
                FechaNacimiento = dateTimeFechaNacimiento.Value,
                NombreUsuario = txtUsuario.Text,
                Contraseña = "CAI20232",
                ValorPerfil = (int)cbPerfiles.SelectedValue,
                FechaAlta = DateTime.Now
            };
        }

        private string ValidateUserDetails(UsuarioDatos datosUsuario)
        {
            var validador = new ValidadorUtilis();
            return validador.ValidarDatosUsuario(datosUsuario.NombreUsuario, datosUsuario.Contraseña, datosUsuario.Dni,
                                                 datosUsuario.Nombre, datosUsuario.Apellido, datosUsuario.FechaNacimiento);
        }

        private void CrearUsuario(UsuarioDatos datosUsuario)
        {
            List<Usuario> usuarios = usuarioNegocio.listarUsuarios();
            Usuario usuario = usuarios.FirstOrDefault(u => u.NombreUsuario == userLogueado);
            guidUsuario = usuario.id;

            usuarioNegocio.agregarUsuario(guidUsuario.ToString(), datosUsuario.ValorPerfil, datosUsuario.Nombre, datosUsuario.Apellido, datosUsuario.Dni,
                                          datosUsuario.Direccion, datosUsuario.Telefono, datosUsuario.Email, datosUsuario.FechaNacimiento,
                                          datosUsuario.NombreUsuario, datosUsuario.Contraseña);

            usuarioNegocio.agregarUsuarioDBLocal(datosUsuario.NombreUsuario, datosUsuario.Contraseña);
        }

        private void MostrarMensaje(string mensaje, Color color)
        {
            lblAlertaAltaUsuario.Visible = true;
            lblAlertaAltaUsuario.ForeColor = color;
            lblAlertaAltaUsuario.Text = mensaje;
        }

        private void LimpiarFormulario()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDNI.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            dateTimeFechaNacimiento.Value = DateTime.Now;
            txtUsuario.Clear();
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

    public class UsuarioDatos
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Dni { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public int ValorPerfil { get; set; }
        public DateTime FechaAlta { get; set; }
    }
}