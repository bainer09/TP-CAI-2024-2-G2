using Datos;
using Presentacion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Negocio;

namespace Presentacion
{
    public partial class FrmAltaUsuario : Form
    {
        private UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
        private int perfilUsuario;
        private Guid guidUsuario;
        string userLogueado = UsuarioLogueado.NombreUsuario;

        public FrmAltaUsuario()
        {
            InitializeComponent();
            InitializeComboBox();
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
            FrmMain frmMain = new FrmMain(perfilUsuario, usuarioNegocio, productoNegocio);
            frmMain.Show();
            this.Hide();
        }

        private void btnAltaUsuario_Click(object sender, EventArgs e)
        {
            OcultarAlertas();

            if (!ValidarCamposObligatorios())
            {
                return;
            }

            try
            {
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                int dni;
                if (!int.TryParse(txtDNI.Text, out dni))
                {
                    MostrarError(lblAlertaDni, "Debe completar el campo DNI con números válidos.");
                    return;
                }

                string direccion = txtDireccion.Text;
                string telefono = txtTelefono.Text;
                string email = txtEmail.Text;
                if (!EsCorreoValido(email))
                {
                    MostrarError(lblAlertaEmail, "El formato de email es inválido.");
                    return;
                }

                DateTime fechaNacimiento = dateTimeFechaNacimiento.Value;
                if (!EsMayorDeEdad(fechaNacimiento))
                {
                    MostrarError(lblAlertaFecha, "El usuario debe tener al menos 18 años.");
                    return;
                }

                string nombreUsuario = txtUsuario.Text;
                string contraseña = "CAI20232";
                int perfilSeleccionado = (int)cbPerfiles.SelectedValue;

                ValidadorUtilis validador = new ValidadorUtilis();
                string errorMensaje = validador.ValidarDatosUsuario(nombreUsuario, contraseña, dni, nombre, apellido, fechaNacimiento);

                if (string.IsNullOrEmpty(errorMensaje))
                {
                    List<Usuario> usuarios = usuarioNegocio.ListarUsuarios();
                    Usuario usuario = usuarios.FirstOrDefault(u => u._Usuario == userLogueado);
                    guidUsuario = usuario._id;
                    string guidUsuarioString = guidUsuario.ToString();

                    usuarioNegocio.AgregarUsuario(guidUsuarioString, nombre, apellido, dni, direccion, telefono, email, fechaNacimiento, nombreUsuario, contraseña, perfilSeleccionado);
                    usuarioNegocio.AgregarUsuarioLocal(nombreUsuario, contraseña);

                    MostrarExito("Usuario creado correctamente");
                    LimpiarCampos();
                }
                else
                {
                    MostrarError(lblAlertaAltaUsuario, errorMensaje);
                }
            }
            catch (Exception)
            {
                MostrarError(lblAlertaAltaUsuario, "Se ha producido un error. Vuelva a intentarlo, si persiste contacte a su administrador del sistema.");
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
            OcultarAlertas();
        }

        private void OcultarAlertas()
        {
            lblAlertaAltaUsuario.Visible = false;
            lblAlertaNombre.Visible = false;
            lblAlertaApellido.Visible = false;
            lblAlertaDni.Visible = false;
            lblAlertaDireccion.Visible = false;
            lblAlertaTelefono.Visible = false;
            lblAlertaEmail.Visible = false;
            lblAlertaFecha.Visible = false;
            lblAlertaUsuario.Visible = false;
            lblAlertaPerfil.Visible = false;
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDNI.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            dateTimeFechaNacimiento.Value = DateTime.Now;
            txtUsuario.Clear();
            cbPerfiles.SelectedIndex = -1;
        }

        private bool ValidarCamposObligatorios()
        {
            bool esValido = true;

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MostrarError(lblAlertaNombre, "El nombre es obligatorio.");
                esValido = false;
            }

            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MostrarError(lblAlertaApellido, "El apellido es obligatorio.");
                esValido = false;
            }

            if (string.IsNullOrWhiteSpace(txtDNI.Text))
            {
                MostrarError(lblAlertaDni, "El DNI es obligatorio.");
                esValido = false;
            }

            if (string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                MostrarError(lblAlertaDireccion, "La dirección es obligatoria.");
                esValido = false;
            }

            if (string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MostrarError(lblAlertaTelefono, "El teléfono es obligatorio.");
                esValido = false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MostrarError(lblAlertaEmail, "El email es obligatorio.");
                esValido = false;
            }

            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                MostrarError(lblAlertaUsuario, "El usuario es obligatorio.");
                esValido = false;
            }

            if (cbPerfiles.SelectedIndex == -1)
            {
                MostrarError(lblAlertaPerfil, "Debe seleccionar un perfil.");
                esValido = false;
            }

            return esValido;
        }

        private void MostrarError(Label label, string mensaje)
        {
            label.Text = mensaje;
            label.ForeColor = Color.Red;
            label.Visible = true;
        }

        private void MostrarExito(string mensaje)
        {
            lblAlertaAltaUsuario.Text = mensaje;
            lblAlertaAltaUsuario.ForeColor = Color.Green;
            lblAlertaAltaUsuario.Visible = true;
        }

        private bool EsCorreoValido(string email)
        {
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        private bool EsMayorDeEdad(DateTime fechaNacimiento)
        {
            int edad = DateTime.Now.Year - fechaNacimiento.Year;
            if (fechaNacimiento > DateTime.Now.AddYears(-edad)) edad--;
            return edad >= 18;
        }
    }
}
