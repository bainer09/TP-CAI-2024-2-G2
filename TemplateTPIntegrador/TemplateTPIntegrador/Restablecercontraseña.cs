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
      
        }
    }
}
