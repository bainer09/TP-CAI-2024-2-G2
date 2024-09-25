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
    public partial class Modulobajausuario : Form
    {
        public Modulobajausuario()
        {
            InitializeComponent();
        }

        private void Modulobajausuario_Load(object sender, EventArgs e)
        {

        }

        private void Botondardebaja_Click(object sender, EventArgs e)
        {

        }





        private void Buscarusuarioboton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Iddeusuariotexto.Text) && string.IsNullOrWhiteSpace(Iddenombretexto.Text))
            {
                MessageBox.Show("Por favor, ingrese al menos un número o nombre de usuario.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void Botonreactivarusuario_Click(object sender, EventArgs e)
        {

        }
    }
}
}
