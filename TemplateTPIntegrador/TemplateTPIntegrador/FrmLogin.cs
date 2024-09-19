using Negocio;
using System;
using System.Windows.Forms;

namespace TemplateTPIntegrador
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ValidacionesUtils validacionesUtils = new ValidacionesUtils();

            string usuario = textUsername.Text;
            string contrasena = textPassword.Text;

            validacionesUtils.ValidarStringVacio(usuario);    

            LoginNegocio ln = new LoginNegocio();
            ln.Login(usuario, contrasena);

        }
    }
}
