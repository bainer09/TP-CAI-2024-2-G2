using Negocio;
using Persistencia;
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
using Datos;

namespace TemplateTPIntegrador
{
    public partial class FrmProducto : Form
    {
        public FrmProducto()
        {
            InitializeComponent();
        }
        private int perfilUsuario;
        private int idCategoria;
        private string idProveedor;
        private string nombreProveedor;
        private string apellidoProveedor;
        private ProductoNegocio productoNegocio = new ProductoNegocio();
        private ProveedoresNegocio proveedorNegocio = new ProveedoresNegocio();
        private UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
        private Guid guidUsuario;
        private bool stockModificado = false;
        private Guid idProductoReactivar;


        private void FrmProducto_Load(object sender, EventArgs e)
        {
            //ProductoPersistente.PoblarproductoLocal();
            //cargarProductos();
            cargarProveedores();
            //cargarCategorias();
        }

        public FrmProducto(int perfilUsuario)
        {
            InitializeComponent();
            this.FormClosing += FrmProducto_FormClosing;
            this.perfilUsuario = perfilUsuario;
        }

        

        private void FrmProducto_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            FrmMain frmMain = new FrmMain(perfilUsuario, usuarioNegocio, productoNegocio);
            frmMain.Show();
            this.Hide();
        }


        private void MostrarMensajeAlerta(string mensaje, Color color)
        {
            lblalertaProductos.Visible = true;
            lblalertaProductos.ForeColor = color;
            lblalertaProductos.Text = mensaje;
        }

        private bool EsPrecioValido(string precioTexto, out double precio)
        {
            if (double.TryParse(precioTexto, out precio))
            {
                return true;
            }
            MostrarMensajeAlerta("Ingrese un precio válido.", Color.Red);
            return false;
        }

        private void btnLimpiarSeleccion_Click(object sender, EventArgs e)
        {
            LimpiarSeleccion();
        }

        private void LimpiarSeleccion()
        {
            txtNombre.Clear();
            txtPrecio.Clear();
            numericUpDownStock.Value = numericUpDownStock.Minimum;
            chkAudio.Checked = false;
            chkCelulares.Checked = false;
            chkElectroHogar.Checked = false;
            chkInformatica.Checked = false;
            chkSmartTV.Checked = false;

        }
        //Eliminar?
       /* private Producto ObtenerProductoSeleccionado()
        {
            if (dgwProductoAMostrar.CurrentRow == null)
            {
                MostrarMensajeAlerta("Seleccione un producto antes de continuar.", Color.Red);
                return null;
            }
            return (Producto)dgwProductoAMostrar.CurrentRow.DataBoundItem;
        }*/

        private void cargarProductos()
        {
            List<Producto> productos = productoNegocio.ObtenerProductos();
            productos = productos.OrderBy(p => p.nombre).ToList();
            var bindingList = new BindingList<Producto>(productos);
            var source = new BindingSource(bindingList, null);
            dgvProductosenStock.DataSource = source;
            dgvProductosenStock.Columns["Id"].Visible = false;
            dgvProductosenStock.Columns["FechaBaja"].Visible = false;
            dgvProductosenStock.Columns["IdUsuario"].Visible = false;
            dgvProductosenStock.Columns["IdProveedor"].Visible = false;
            dgvProductosenStock.Columns["Cantidad"].Visible = false;
            dgvProductosenStock.Columns["NombreProveedor"].Visible = false;
            dgvProductosenStock.Columns["ApellidoProveedor"].Visible = false;
            dgvProductosenStock.CellFormatting += DataGridViewProducto_CellFormatting;
        }

        private void DataGridViewProducto_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvProductosenStock.Columns[e.ColumnIndex].Name == "Precio")
            {
                if (e.Value != null && double.TryParse(e.Value.ToString(), out double precio))
                {
                    e.Value = precio.ToString("C");
                    e.FormattingApplied = true;
                }
            }
        }


        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrWhiteSpace(txtNombre.Text) || numericUpDownStock.Value == 0)

                {
                    MostrarMensajeAlerta("Por favor, complete todos los campos para continuar.", Color.Red);
                    return;
                }

                if (!EsPrecioValido(txtPrecio.Text, out double precio)) return;

                if (dgvProdProveedor.CurrentRow == null)
                {
                    MostrarMensajeAlerta("Por favor, seleccione un proveedor.", Color.Red);
                    return;
                }

                var proveedorSeleccionado = (Proveedor)dgvProdProveedor.CurrentRow.DataBoundItem;

                int[] categoriasSeleccionadas = {
                    chkAudio.Checked ? 1 : 0,
                    chkCelulares.Checked ? 2 : 0,
                    chkElectroHogar.Checked ? 3 : 0,
                    chkInformatica.Checked ? 4 : 0,
                    chkSmartTV.Checked ? 5 : 0
                };
                int cantidadCategorias = categoriasSeleccionadas.Count(c => c != 0);

                if (cantidadCategorias == 0 || cantidadCategorias > 1)
                {
                    MostrarMensajeAlerta(cantidadCategorias == 0 ? "Seleccione una categoría." : "Solo puede elegir una categoría.", Color.Red);
                    return;
                }

                idCategoria = categoriasSeleccionadas.First(c => c != 0);

                //MYR a chequear
                //productoNegocio.AltaProducto(guidUsuario.ToString(), idCategoria, proveedorSeleccionado.Id.ToString(), proveedorSeleccionado.Nombre, proveedorSeleccionado.Apellido, txtNombre.Text.Trim(), precio, (int)numericUpDownStock.Value);

                //cargarProductos();
                MostrarMensajeAlerta("Producto agregado con éxito.", Color.Green);

                LimpiarSeleccion();
            }
            catch (Exception ex)
            {
                MostrarMensajeAlerta("Se ha producido un error. Contacte a su administrador del sistema.", Color.Red);
            }
        }

        private void cargarProveedores()
        {

            var proveedores = proveedorNegocio.listarProveedores().OrderBy(c => c.Apellido).ToList();

            var bindingList = new BindingList<Proveedor>(proveedores);

            var source = new BindingSource(bindingList, null);

            dgvProdProveedor.DataSource = source;
            dgvProdProveedor.AutoGenerateColumns = true;
            dgvProdProveedor.Columns["Id"].Visible = false;
            dgvProdProveedor.Columns["FechaAlta"].Visible = false;
            dgvProdProveedor.Columns["FechaBaja"].Visible = false;
            dgvProdProveedor.Columns["Email"].Visible = false;
            dgvProdProveedor.Columns["IdUsuario"].Visible = false;
        
        }

        /*private void cargarCategorias()
        {
            var categorias = new Categorias().categoriasProducto.Select(c => new { Name = c.Value, Value = c.Key }).ToList();
            cbCategoriasdeProductos.DataSource = categorias;
            cbCategoriasdeProductos.DisplayMember = "Name";
            cbCategoriasdeProductos.ValueMember = "Value";
            cbCategoriasdeProductos.SelectedIndex = -1;
            cbCategoriasdeProductos.SelectedIndexChanged += cbCategoriasdeProductos_SelectedIndexChanged;
        }*/



        /*private void dataGridViewProductoporCategoria_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvProductoporCategoria.Columns[e.ColumnIndex].Name == "Precio" && e.Value != null && double.TryParse(e.Value.ToString(), out double precio))
            {
                e.Value = precio.ToString("C");
                e.FormattingApplied = true;
            }
        }*/

        private void numericUpDownStock_ValueChanged(object sender, EventArgs e)
        {
            stockModificado = true;
        }



        //Para sacar?
        /*
         * 
         *private void numericUpDownStock_ValueChanged(object sender, EventArgs e)
            {
                stockModificado = true;
            }

         * private void linkLabelProductosporCategoria_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MostrarGroupBox(groupBoxProdporCategoria);
        }

        private void linkLabelStock_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MostrarGroupBox(groupBoxStock);
        }

        private void MostrarGroupBox(GroupBox groupBoxToShow)
        {
            groupBoxProductosBaja.Visible = false;
            groupBoxProdporCategoria.Visible = false;
            groupBoxStock.Visible = false;
            groupBoxToShow.Visible = true;
        }
        */

    }
}
