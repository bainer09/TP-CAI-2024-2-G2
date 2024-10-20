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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace TemplateTPIntegrador
{
    public partial class FrmProveedores : Form
    {
        private ProveedoresNegocio proveedorNegocio = new ProveedoresNegocio();
        ValidacionesUtils validaciones = new ValidacionesUtils();
        bool tieneErrorFormatoMail = true;


        public FrmProveedores()
        {
            InitializeComponent();
        }

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string apellido = txtApellido.Text.Trim();
            string email = txtMail.Text.Trim();
            string cuit = txtCuit.Text.Trim();

            bool tieneCamposVacios = validaciones.ValidarCamposTexto(new List<string> { nombre, apellido, email, cuit });

            bool tieneCheckboxVacios = validaciones.ValidarCamposCheckbox(new List<bool> { checkAudio.Checked, checkCelulares.Checked, checkElectroHogar.Checked, checkInformatica.Checked, checkSmartTV.Checked });

            bool tieneLongitudCuitErronea = validaciones.ValidarLongitud(cuit, 11);

            bool camposEstanOK = !tieneCamposVacios && !tieneCheckboxVacios && !tieneErrorFormatoMail && !tieneLongitudCuitErronea;

            lblValidaciones.Visible = tieneCamposVacios;
            lblValidacionCategoria.Visible = tieneCheckboxVacios;
            lblValidacionCuit.Visible = !string.IsNullOrEmpty(cuit) && tieneLongitudCuitErronea;

            if (camposEstanOK)
            {
                MessageBox.Show("Guardado con éxito", FrmProveedores.ActiveForm.Text);
                LimpiarCampos();
            }
       
        }

        private void txtMail_TextChanged(object sender, EventArgs e)
        {
            string mail = txtMail.Text;
            tieneErrorFormatoMail = !String.IsNullOrEmpty(mail) && validaciones.ValidarFormatoMail(txtMail.Text);

            lblValidacionMail.Visible = tieneErrorFormatoMail;
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtMail.Text = "";
            txtCuit.Text = "";
            checkAudio.Checked = false;
            checkCelulares.Checked = false;
            checkElectroHogar.Checked = false;
            checkInformatica.Checked = false;
            checkSmartTV.Checked = false;
        }
    }
}
