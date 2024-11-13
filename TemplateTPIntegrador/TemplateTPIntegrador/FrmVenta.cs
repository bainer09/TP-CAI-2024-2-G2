using Datos;
using Negocio;
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

namespace TemplateTPIntegrador
{
    public partial class FrmVenta : Form
    {
        public FrmVenta(FrmComprobante frmComprobante)
        {
            InitializeComponent();
        }
            private int perfilUsuario;
            private Guid guidUsuario;
            private string userLogueado = UsuarioLogueado.NombreUsuario;
            private ProductoNegocio productoNegocio = new ProductoNegocio();
            private ClienteNegocio clienteNegocio = new ClienteNegocio();
            private VentaNegocio ventaNegocio = new VentaNegocio();
            private UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
            private List<Producto> carrito = new List<Producto>();
            private FrmComprobante frmComprobante;


            public FrmVenta(int perfilUsuario, FrmComprobante frmComprobante)
            {
                InitializeComponent();
                this.FormClosing += FrmVenta_FormClosing;
                this.perfilUsuario = perfilUsuario;
                this.frmComprobante = frmComprobante;

                lvCarrito.View = View.Details;
                lvCarrito.FullRowSelect = true;
                lvCarrito.GridLines = true;
                cmbCliente.SelectedIndexChanged += cbCliente_SelectedIndexChanged;
                lvCarrito.Columns.Add("Producto", 400);
                lvCarrito.Columns.Add("Precio", 100);
                lvCarrito.Columns.Add("Cantidad", 100);
            }

            private void FrmVenta_FormClosing(object sender, FormClosingEventArgs e)
            {
                if (e.CloseReason == CloseReason.UserClosing)
                {
                    Application.Exit();
                }
            }

            private void btnVolverInicio_Click(object sender, EventArgs e)
            {
                //VER CON MYR
                //FrmMain frmMain = new FrmMain(perfilUsuario);
                //frmMain.Show();
                this.Hide();
            }

            private void FrmVenta_Load(object sender, EventArgs e)
            {
                lblMensajeCarrito.Visible = false;
                lblMensajeVentas.Visible = false;
                cargarProductos();
                cargarClientes();
            }

            private void cargarProductos()
            {
                List<Producto> productos = productoNegocio.ObtenerProductos();
                productos = productos.OrderBy(p => p.nombre).ToList();

                var bindingList = new BindingList<Producto>(productos);
                var source = new BindingSource(bindingList, null);
                dgvProductosaRegistrar.DataSource = source;

                OcultarColumnasInnecesarias();
                dgvProductosaRegistrar.CellFormatting += dataGridViewProducto_CellFormatting;

                dgvProductosaRegistrar.Columns["Precio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            private void OcultarColumnasInnecesarias()
            {
                var columnasAEliminar = new[] { "Id", "FechaBaja", "IdUsuario", "IdProveedor", "Cantidad", "NombreProveedor", "ApellidoProveedor" };
                foreach (var columna in columnasAEliminar)
                {
                    dgvProductosaRegistrar.Columns[columna].Visible = false;
                }
            }

            private void dataGridViewProducto_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
            {
                if (dgvProductosaRegistrar.Columns[e.ColumnIndex].Name == "Precio" && e.Value != null && double.TryParse(e.Value.ToString(), out double precio))
                {
                    e.Value = precio.ToString("C");
                    e.FormattingApplied = true;
                }
            }

            private void cargarClientes()
            {
                List<Cliente> clientes = clienteNegocio.ObtenerClientes();
                clientes = clientes.OrderBy(c => c.apellido).ToList();

                cmbCliente.DataSource = clientes;
                cmbCliente.DisplayMember = "NombreCompleto";
                cmbCliente.ValueMember = "Id";
                cmbCliente.SelectedIndex = -1;
            }

            private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
            {
                if (cmbCliente.SelectedIndex != -1)
                {
                    Cliente clienteSeleccionado = cmbCliente.SelectedItem as Cliente;
                    if (clienteSeleccionado != null)
                    {
                        Guid idCliente = clienteSeleccionado.id;
                        bool esPrimeraCompra = ventaNegocio.EsPrimeraCompra(idCliente);
                        lblPrimeraCompra.Visible = esPrimeraCompra;
                        lblPrimeraCompra.Text = esPrimeraCompra ? "Descuento primera compra: 5%" : string.Empty;
                    }
                }
                else
                {
                    lblPrimeraCompra.Visible = false;
                }
            }

            private void btnRemover_Click(object sender, EventArgs e)
            {
                if (lvCarrito.SelectedItems.Count == 0)
                {
                    MostrarAlerta("Por favor, seleccione un producto para eliminar del carrito.");
                    return;
                }

                var itemSeleccionado = lvCarrito.SelectedItems[0];
                Producto productoSeleccionado = itemSeleccionado.Tag as Producto;

                if (productoSeleccionado == null)
                {
                    MostrarAlerta("Hubo un error al obtener el producto seleccionado. Intente nuevamente.");
                    return;
                }

                carrito.Remove(productoSeleccionado);
                ActualizarStockProducto(productoSeleccionado);
                actualizarCarrito();
                actualizarDataGridViewProductos();
                MostrarAlerta("Producto eliminado del carrito", Color.Green);
            }

            private void MostrarAlerta(string mensaje, Color? color = null)
            {
                lblMensajeCarrito.Visible = true;
                lblMensajeCarrito.ForeColor = color ?? Color.Red;
                lblMensajeCarrito.Text = mensaje;
            }

            private void ActualizarStockProducto(Producto productoSeleccionado)
            {
                var productoOriginal = productoNegocio.ObtenerProductos().FirstOrDefault(p => p.id == productoSeleccionado.id);
                if (productoOriginal != null)
                {
                    productoOriginal.Stock += 1;
                }
            }

            private void btnAgregar_Click(object sender, EventArgs e)
            {
                lblMensajeVentas.Visible = false;

                if (cmbCliente.SelectedItem == null)
                {
                    MostrarAlerta("Debe seleccionar un cliente antes de agregar productos.");
                    return;
                }

                if (dgvProductosaRegistrar.SelectedRows.Count == 0)
                {
                    MostrarAlerta("Seleccione un producto de la lista para agregarlo al carrito.");
                    return;
                }

                var filaSeleccionada = dgvProductosaRegistrar.SelectedRows[0];
                Producto productoSeleccionado = (Producto)filaSeleccionada.DataBoundItem;
                int cantidadSeleccionada = (int)numericUpDownCantidad.Value;


            if (cantidadSeleccionada > productoSeleccionado.stock)
                {
                    MostrarAlerta("No hay suficiente stock disponible para la cantidad seleccionada.");
                    return;
                }

                productoSeleccionado.stock -= cantidadSeleccionada;
                AgregarProductosAlCarrito(productoSeleccionado, cantidadSeleccionada);
                actualizarCarrito();
                actualizarDataGridViewProductos();
            }

            private void AgregarProductosAlCarrito(Producto productoSeleccionado, int cantidadSeleccionada)
            {
                for (int i = 0; i < cantidadSeleccionada; i++)
                {
                    /*carrito.Add(new Producto
                    {
                        id = productoSeleccionado.id,
                        nombre = productoSeleccionado.nombre,
                        precio = productoSeleccionado.precio,
                        stock = productoSeleccionado.stock,
                        idCategoria = productoSeleccionado.idCategoria,
                        idProveedor = productoSeleccionado.idProveedor,
                        Cantidad = cantidadSeleccionada
                    });*/
                }
            }

        //MYR a chequear
        /*private void actualizarCarrito()
        {
            lvCarrito.Items.Clear();

            var productosAgrupados = carrito.GroupBy(p => p.id)
                                            .Select(g => new
                                            {
                                                Producto = g.First(),
                                                Cantidad = g.Sum(p => p.Cantidad)
                                            }).ToList();

            double totalSinDescuentos = productosAgrupados.Sum(p => p.Producto.Precio * p.Cantidad);
            double descuentoPrimeraCompra = PromoPrimeraCompra(totalSinDescuentos);
            var (totalConDescuento, descuentoElectroHogar) = ventaNegocio.ObtenerTotalConDescuento(
                productosAgrupados);

            totalConDescuento = totalSinDescuentos - descuentoElectroHogar - descuentoPrimeraCompra;

            foreach (var item in productosAgrupados)
            {
                var producto = item.Producto;
                var cantidad = item.Cantidad;
                var listViewItem = new ListViewItem(producto.Nombre)
                {
                    Tag = producto
                };
                listViewItem.SubItems.Add(producto.Precio.ToString("C"));
                listViewItem.SubItems.Add(cantidad.ToString());
                lstCarrito.Items.Add(listViewItem);
            }

            lblTotal.Text = $"Total: {totalConDescuento:C}";

            if (esPrimeraCompra)
            {
                lblClienteNuevo.Visible = true;
                lblClienteNuevo.Text = $"Descuento primera compra: {descuentoPrimeraCompra:C}";
            }
            else
            {
                lblClienteNuevo.Visible = false;
            }

            if (descuentoElectroHogar > 0)
            {
                lblAlertadecuentoCatElectroHogar.Visible = true;
                lblAlertadecuentoCatElectroHogar.Text = $"Descuento 5% en productos de Electro Hogar: {descuentoElectroHogar:C}";
            }
            else
            {
                lblAlertadecuentoCatElectroHogar.Visible = false;
            }
        } */

        private void actualizarDataGridViewProductos()
            {
                dgvProductosaRegistrar.Refresh();
            }

            private void btnCompletarVenta_Click(object sender, EventArgs e)
            {
                if (carrito.Count == 0)
                {
                    lblMensajeVentas.Text = "El carrito está vacío. No puedes completar la venta.";
                    return;
                }

                Cliente clienteSeleccionado = cmbCliente.SelectedItem as Cliente;
                if (clienteSeleccionado == null)
                {
                    lblMensajeVentas.Text = "Por favor, selecciona un cliente.";
                    return;
                }

                Guid idCliente = clienteSeleccionado.id;
                var productosAgrupados = carrito.GroupBy(p => p.id)
                                                .Select(g => new
                                                {
                                                    Producto = g.First(),
                                                    Cantidad = g.Sum(p => p.Cantidad)
                                                }).ToList();

                bool esPrimeraCompra = ventaNegocio.EsPrimeraCompra(clienteSeleccionado.id);
                DateTime fechaVenta = DateTime.Now;

                foreach (var item in productosAgrupados)
                {
                    var producto = item.Producto;
                    var cantidadVendida = item.Cantidad;
                    double montoTotal = producto.Precio * cantidadVendida;

                    //MYR a chequear
                    AgregarVenta venta = new AgregarVenta(idCliente.ToString(), guidUsuario.ToString(), producto.Id.ToString(), cantidadVendida, montoTotal, fechaVenta);
                    
                    ventaNegocio.AgregarVenta(venta);
                    //productoNegocio.ActualizarProductoEnJson(producto.Nombre, producto.Precio, -cantidadVendida);
                }

                var productosListos = productosAgrupados.Select(g => (g.Producto, g.Cantidad)).ToList();
                double totalSinDescuentos = productosListos.Sum(p => p.Producto.Precio * p.Cantidad);
                double descuentoPrimeraCompra = esPrimeraCompra ? totalSinDescuentos * 0.05 : 0;

                lblMensajeVentas.Text = "Venta completada con éxito.";

                //Rodri a hacer lo de generar comprobante

                //GenerarComprobante(clienteSeleccionado, productosListos, descuentoPrimeraCompra);

                carrito.Clear();
                //actualizarCarrito();
                cargarProductos();


                
            }
        }
    }
