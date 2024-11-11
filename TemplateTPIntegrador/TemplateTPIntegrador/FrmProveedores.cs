using Datos;
using Negocio;
using Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace TemplateTPIntegrador
{
    public partial class FrmProveedores : Form
    {
        private ProveedoresNegocio proveedorNegocio = new ProveedoresNegocio();
        ValidacionesUtils validaciones = new ValidacionesUtils();
        bool tieneErrorFormatoMail = true;
        bool modoEdicion = false;
        Guid proveedorIDSeleccionado;
        private UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
        private ProductoNegocio productoNegocio = new ProductoNegocio();
        private int perfilUsuario;

        public FrmProveedores()
        {
            InitializeComponent();
        }

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            try
            {
                Guid usuarioLogueado = Guid.Parse("9ea1c0da-e541-4846-a9de-8478664a87bb");

                string nombre = txtNombre.Text.Trim();
                string apellido = txtApellido.Text.Trim();
                string email = txtMail.Text.Trim();
                string cuit = txtCuit.Text.Trim();

                bool tieneCamposVacios = validaciones.ValidarCamposTexto(new List<string> { nombre, apellido, email, cuit });

                bool tieneLongitudCuitErronea = validaciones.ValidarLongitud(cuit, 11);

                bool camposEstanOK = !tieneCamposVacios && !tieneErrorFormatoMail && !tieneLongitudCuitErronea;

                lblValidaciones.Visible = tieneCamposVacios;
                lblValidacionCuit.Visible = !string.IsNullOrEmpty(cuit) && tieneLongitudCuitErronea;

                if (camposEstanOK)
                {
                    if (modoEdicion) {
                        proveedorNegocio.modificar(proveedorIDSeleccionado, usuarioLogueado, nombre, apellido, email, cuit);
                        MessageBox.Show("Modificado con éxito", FrmProveedores.ActiveForm.Text);
                    } else
                    {
                        proveedorNegocio.agregar(usuarioLogueado, nombre, apellido, email, cuit);
                        MessageBox.Show("Guardado con éxito", FrmProveedores.ActiveForm.Text);
                    }
                    
                    listarProveedores();
                    LimpiarCampos();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, FrmProveedores.ActiveForm.Text);

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
            modoEdicion = false;
            proveedorIDSeleccionado = Guid.Empty;
            txtCuit.Enabled = !modoEdicion;
        }
        private void listarProveedores()
        {
            List<Proveedor> listadoProveedores = proveedorNegocio.listarProveedores();

            listadoProveedores = listadoProveedores.OrderBy(c => c.Apellido).ToList();

            var bindingList = new BindingList<Proveedor>(listadoProveedores);
            var source = new BindingSource(bindingList, null);
            dataGridProveedores.DataSource = source;
            dataGridProveedores.CurrentCell = null;
            dataGridProveedores.Columns["Id"].Visible = false;
            dataGridProveedores.Columns["FechaAlta"].Visible = false;
            dataGridProveedores.Columns["FechaBaja"].Visible = false;
            dataGridProveedores.Columns["IdUsuario"].Visible = false;
        }

        private void FrmProveedores_Load(object sender, EventArgs e)
        {
            listarProveedores();
        }

        private void btnModificarProveedor_Click(object sender, EventArgs e)
        {
            if (dataGridProveedores.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un proveedor", FrmProveedores.ActiveForm.Text);
                return;
            }

            DataGridViewRow filaSeleccionada = dataGridProveedores.SelectedRows[0];
            txtNombre.Text = filaSeleccionada.Cells[1].Value.ToString();
            txtApellido.Text = filaSeleccionada.Cells[2].Value.ToString();
            txtMail.Text = filaSeleccionada.Cells[3].Value.ToString();
            txtCuit.Text = filaSeleccionada.Cells[4].Value.ToString();
            proveedorIDSeleccionado = Guid.Parse(filaSeleccionada.Cells[0].Value.ToString());

            modoEdicion = true;
            txtCuit.Enabled = !modoEdicion;

        }

        private void btnEliminarProveedor_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridProveedores.CurrentRow == null)
                {
                    MessageBox.Show("Debe seleccionar un proveedor", FrmProveedores.ActiveForm.Text);
                    return;
                }

                Guid usuarioLogueado = Guid.Parse("9ea1c0da-e541-4846-a9de-8478664a87bb");
                DataGridViewRow filaSeleccionada = dataGridProveedores.SelectedRows[0];
                proveedorIDSeleccionado = Guid.Parse(filaSeleccionada.Cells[0].Value.ToString());

                proveedorNegocio.eliminar(proveedorIDSeleccionado, usuarioLogueado);
                MessageBox.Show("Eliminado con éxito", FrmProveedores.ActiveForm.Text);
                listarProveedores();


            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, FrmProveedores.ActiveForm.Text);
            }


        }

        private void btnReactivarProveedor_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridProveedores.CurrentRow == null)
                {
                    MessageBox.Show("Debe seleccionar un proveedor", FrmProveedores.ActiveForm.Text);
                    return;
                }

                Guid usuarioLogueado = Guid.Parse("9ea1c0da-e541-4846-a9de-8478664a87bb");
                DataGridViewRow filaSeleccionada = dataGridProveedores.SelectedRows[0];
                proveedorIDSeleccionado = Guid.Parse(filaSeleccionada.Cells[0].Value.ToString());

                proveedorNegocio.reactivar(proveedorIDSeleccionado, usuarioLogueado);
                MessageBox.Show("Reactivado con éxito", FrmProveedores.ActiveForm.Text);
                listarProveedores();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, FrmProveedores.ActiveForm.Text);
            }
        }

        private void btnVolverInicio_Click(object sender, EventArgs e)
        {
            FrmMain frmMain = new FrmMain(perfilUsuario, usuarioNegocio, productoNegocio);
            frmMain.Show();
            this.Hide();
        }
    }
}
