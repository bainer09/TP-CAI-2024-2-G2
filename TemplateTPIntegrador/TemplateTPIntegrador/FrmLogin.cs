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
using Negocio;
using Persistencia;
using Datos;

namespace PresentacionLayer
{
    public partial class FrmLogin : Form
    {
        private UsuarioNegocio usuarioNegocio;
        private int intentosFallidos = 0;
        private string ultimoUsuarioIntentado = string.Empty;

        public FrmLogin()
        {
            InitializeComponent();
            usuarioNegocio = new UsuarioNegocio();
            this.FormClosing += FrmLogin_FormClosing;
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string usuario = txtUsername.Text;
                string clave = txtPassword.Text;

                if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(clave))
                {
                    MostrarMensaje("Por favor, ingrese su nombre de usuario y contraseña.");
                    return;
                }

                if (usuario != ultimoUsuarioIntentado)
                {
                    intentosFallidos = 0;
                    ultimoUsuarioIntentado = usuario;
                }

                bool primerLogin = usuarioNegocio.VerificarPrimerLogin(usuario);
                if (primerLogin)
                {
                    MostrarMensaje("Es su primer Login, debe cambiar la clave para ingresar");
                    return;
                }

                bool contraseñaExpirada = usuarioNegocio.VerificarExpiracionContraseña(usuario);
                if (contraseñaExpirada)
                {
                    MostrarMensaje("Su contraseña ha expirado. Debe cambiarla para ingresar.");
                    return;
                }

                int perfilUsuario = usuarioNegocio.Login(usuario, clave);

                if (perfilUsuario != -1)
                {
                    intentosFallidos = 0; // Resetear intentos fallidos solo si el login es exitoso
                    UsuarioLogueado.SetNombreUsuario(usuario);
                    var usuarioNegocio = new UsuarioNegocio();
                    var productoNegocio = new ProductoNegocio(); //NOTAS: De Myrna o Belu!!!
                    FrmMain frmMain = new FrmMain(perfilUsuario, usuarioNegocio, productoNegocio);
                    frmMain.Show();
                    this.Hide();
                }
                else
                {
                    intentosFallidos++;
                    MostrarMensaje("Nombre de usuario o contraseña incorrectos");
                    ReiniciarCampos();

                    if (intentosFallidos == 2)
                    {
                        MostrarMensaje("Ante un nuevo ingreso erróneo, su usuario será bloqueado.");
                    }
                    else if (intentosFallidos >= 3)
                    {
                        usuarioNegocio.BloquearUsuarioPorLoginFallido(usuario); //NOTAS: Metodo de VALEN en BAJA!!!
                        MostrarMensaje("Ha superado el límite de intentos. Contacte a su Administrador para reactivar su usuario.");
                        intentosFallidos = 0; // Reiniciar intentos después de bloquear
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar sesión. Por favor, intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarMensaje(string mensaje)
        {
            lblLoginIncorrecto.Text = mensaje;
            lblLoginIncorrecto.Visible = true;
        }

        private void ReiniciarCampos()
        {
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }

        private void linklblCambioClave_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
            FrmContraseña frmContraseña = new FrmContraseña(usuarioNegocio);
            frmContraseña.Show();
            this.Hide();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void lblLoginIncorrecto_Click(object sender, EventArgs e)
        {

        }
    }

}