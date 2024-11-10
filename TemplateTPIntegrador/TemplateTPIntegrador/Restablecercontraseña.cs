using Datos;
using Negocio;
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
    public partial class Restablecercontraseña : Form

    {
        Usuarionegocio usuarioNegocio = new Usuarionegocio();
        AltaUsuario altausuariodatos = new AltaUsuario();
        public Restablecercontraseña()
        {
            InitializeComponent();
        }

        private void Volverboton_Click(object sender, EventArgs e)
        {
            frmLogin formLogin = new frmLogin();
            formLogin.Show();
            this.Hide();
        }

        private void Restablecerboton_Click(object sender, EventArgs e)
        {
            string email = emailtex.Text;
            string usuario = usuariotex.Text;
            string contraseñaactual = altausuariodatos._Contrasenia;
            string nuevaContraseña = nuevacontratex.Text;
            string repetirContraseña = repetircontratex.Text;

            if (email == null || usuario ==null || nuevaContraseña == null || repetircontraseña == null)
            {
                contraseñaerror.ForeColor = Color.Red;
                contraseñaerror.Text = "Por favor, complete los campos solicitados";
                contraseñaerror.Visible = true;
                return;
            }

            if (nuevaContraseña != repetirContraseña)
            {
                contraseñaerror.ForeColor = Color.Red;
                contraseñaerror.Text = "Por favor, ingrese las mismas contraseñas.";
                contraseñaerror.Visible = true;
                nuevacontratex.Text = "";
                repetircontratex.Text = "";
                return;
            }

            try
            {
                usuarioNegocio.CambiarContraseña(usuario, contraseñaactual, nuevaContraseña);
                contraseñaerror.Text = "";
                contraseñaerror.ForeColor = Color.White;
                contraseñaok.Text = "Contraseña modificada exitosamente";
                contraseñaok.Visible = true;
                emailtex.Text = "";
                usuariotex.Text = "";
                nuevacontratex.Text = "";
                repetircontratex.Text = "";
            }
            catch (Exception ex)
            {
                contraseñaerror.ForeColor = Color.OrangeRed;
                contraseñaerror.Text = "Se ha producido un error. Compruebe los datos ingresados y vuelva a intentarlo.\nSi persiste, contacte a su administrador del sistema.";
                contraseñaerror.Visible = true;
            }
        }
    }
}
