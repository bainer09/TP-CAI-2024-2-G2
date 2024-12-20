﻿using Negocio;
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
        private int perfilUsuario;
        public FrmProducto(int perfilUsuario)
        {
            InitializeComponent();
            this.FormClosing += FrmProducto_FormClosing;
            this.perfilUsuario = perfilUsuario;
        }
        private int IdCategoria;
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
            cargarProductos();
            cargarProveedores();
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

        private void cargarProductos()
        {
            List<Producto> productos = productoNegocio.ObtenerProductos();
            productos = productos.OrderBy(p => p.nombre).ToList();
            var bindingList = new BindingList<Producto>(productos);
            var source = new BindingSource(bindingList, null);
            dgvProductosenStock.DataSource = source;
            dgvProductosenStock.Columns["id"].Visible = false;
            dgvProductosenStock.Columns["fechaBaja"].Visible = false;
            dgvProductosenStock.Columns["idUsuario"].Visible = false;
            dgvProductosenStock.Columns["idProveedor"].Visible = false;
            dgvProductosenStock.Columns["stock"].Visible = false;
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
                    MostrarMensajeAlerta(cantidadCategorias == 0 ? "Por favor, seleccione una categoría." : "Solo puede elegir una categoría.", Color.Red);
                    return;
                }

                IdCategoria = categoriasSeleccionadas.First(c => c != 0);

                Guid proveedor = proveedorSeleccionado.Id;
                string Nombre = txtNombre.Text.Trim();
                int Stock = (int)numericUpDownStock.Value;
                double Precio = double.Parse(txtPrecio.Text);

                AltaProducto nuevoProducto = new AltaProducto(IdCategoria, guidUsuario, proveedor, Nombre, Precio, Stock)
                {
                    idUsuario = guidUsuario,
                    idCategoria = IdCategoria,
                    idProveedor = proveedor,
                    nombre = Nombre,
                    precio = Precio,
                    stock = Stock,
                };

                productoNegocio.AltaProducto(nuevoProducto);

                cargarProductos();
                MostrarMensajeAlerta("Producto agregado con éxito.", Color.Green);

                LimpiarSeleccion();
            }
            catch (Exception ex)
            {
                MostrarMensajeAlerta("No se ha podido agregar el producto.", Color.Red);


            }
        }

        private void cargarProveedores()
        {

            var proveedores = proveedorNegocio.listarProveedores().OrderBy(c => c.Apellido).ToList();

            var bindingList = new BindingList<Proveedor>(proveedores);

            var source = new BindingSource(bindingList, null);

            dgvProdProveedor.DataSource = source;
            dgvProdProveedor.AutoGenerateColumns = true;
            dgvProdProveedor.Columns["id"].Visible = false;
            dgvProdProveedor.Columns["fechaAlta"].Visible = false;
            dgvProdProveedor.Columns["fechaBaja"].Visible = false;
            dgvProdProveedor.Columns["email"].Visible = false;
            dgvProdProveedor.Columns["idUsuario"].Visible = false;
        
        }

        private void numericUpDownStock_ValueChanged(object sender, EventArgs e)
        {
            stockModificado = true;
        }


    }
}
