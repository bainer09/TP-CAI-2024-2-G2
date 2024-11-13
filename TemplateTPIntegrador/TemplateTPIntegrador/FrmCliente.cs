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
        private int perfilUsuario;
        public FrmCliente(int perfilUsuario)
        {
            InitializeComponent();
            this.perfilUsuario = perfilUsuario;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void contrafondologo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
