using Negocio;
using PresentacionLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmContrasenia : Form
    {
        private readonly UsuarioNegocio usuarioNegocio;

        public FrmContrasenia(UsuarioNegocio usuarioNegocio)
        {
            InitializeComponent();
            this.usuarioNegocio = usuarioNegocio ?? throw new ArgumentNullException(nameof(usuarioNegocio));
            this.FormClosing += FrmContraseña_FormClosing;

            lblMsjError.Visible = false;
            lblContraseñaOk.Visible = false;
        }

        private void FrmContraseña_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void FrmContraseña_Load(object sender, EventArgs e)
        {

        }

        private void btnCambioContraseña_Click_1(object sender, EventArgs e)
        {
            lblMsjError.Visible = false;
            lblContraseñaOk.Visible = false;

            string usuario = txtUsuario.Text.Trim();
            string contraseñaActual = txtContraseñaActual.Text;
            string nuevaContraseña = txtNuevaContraseña.Text;
            string confirmacionContraseña = txtConfirmacion.Text;

            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contraseñaActual) ||
                string.IsNullOrWhiteSpace(nuevaContraseña) || string.IsNullOrWhiteSpace(confirmacionContraseña))
            {
                MostrarError("Todos los campos son obligatorios.");
                return;
            }

            if (nuevaContraseña != confirmacionContraseña)
            {
                MostrarError("La nueva contraseña y la confirmación no coinciden.");
                LimpiarCampos();
                return;
            }

            try
            {
                usuarioNegocio.CambiarContraseña(usuario, contraseñaActual, nuevaContraseña);
                lblMsjError.Visible = false;
                lblContraseñaOk.Text = "Contraseña modificada exitosamente";
                lblContraseñaOk.ForeColor = Color.Green;
                lblContraseñaOk.Visible = true;
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MostrarError("La contraseña actual ingresada no es correcta o ha ocurrido un error. Contacte al administrador si el problema persiste.");
            }
        }

        private void btnVolverInicio_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            this.Hide();
        }

        private void MostrarError(string mensaje)
        {
            lblMsjError.Text = mensaje;
            lblMsjError.ForeColor = Color.OrangeRed;
            lblMsjError.Visible = true;
        }

        private void LimpiarCampos()
        {
            txtUsuario.Text = "";
            txtContraseñaActual.Text = "";
            txtNuevaContraseña.Text = "";
            txtConfirmacion.Text = "";
        }
    }
}
