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
using TemplateTPIntegrador;

namespace TemplateTPIntegrador
{
    public partial class FrmVenta : Form
    {

        private int perfilUsuario;
        private Guid guidUsuario;
        private string userLogueado = UsuarioLogueado.nombreUsuario;
        private ProductoNegocio productoNegocio = new ProductoNegocio();
        private ClienteNegocio clienteNegocio = new ClienteNegocio();
        private VentaNegocio ventaNegocio = new VentaNegocio();
        private UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
        private List<CarritoProducto> carrito = new List<CarritoProducto>();
        private FrmComprobante frmComprobante;

        private void FrmVenta_Load(object sender, EventArgs e)
        {
            lblMensajes.Visible = false;
            lblClienteNuevo.Visible = false;
            cargarProductos();
            cargarClientes();
        }


        public FrmVenta(int perfilUsuario, FrmComprobante frmComprobante)
        {
            InitializeComponent();
            this.FormClosing += FrmVenta_FormClosing;
            this.perfilUsuario = perfilUsuario;
            this.frmComprobante = frmComprobante;

            lvCarrito.View = View.Details;
            lvCarrito.FullRowSelect = true;
            lvCarrito.GridLines = true;
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

        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            FrmMain frmMain = new FrmMain(perfilUsuario, usuarioNegocio, productoNegocio);
            frmMain.Show();
            this.Hide();
        }

        private void cargarProductos()
        {
            List<Producto> productos = productoNegocio.ObtenerProductos();
            productos = productos.OrderBy(p => p.nombre).ToList();

            var bindingList = new BindingList<Producto>(productos);
            var source = new BindingSource(bindingList, null);
            dgvProductos.DataSource = source;

            OcultarColumnasInnecesarias();
            dgvProductos.CellFormatting += dataGridViewProducto_CellFormatting;

            dgvProductos.Columns["precio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void OcultarColumnasInnecesarias()
        {
            var columnasAEliminar = new[] { "id", "fechaBaja", "idUsuario", "idProveedor", "stock"};
            foreach (var columna in columnasAEliminar)
            {
                dgvProductos.Columns[columna].Visible = false;
            }
        }

        private void dataGridViewProducto_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvProductos.Columns[e.ColumnIndex].Name == "precio" && e.Value != null && double.TryParse(e.Value.ToString(), out double precio))
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
                Mensajes("Por favor, seleccione un producto para eliminar del carrito.");
                return;
            }

            var itemSeleccionado = lvCarrito.SelectedItems[0];
            CarritoProducto productoSeleccionado = itemSeleccionado.Tag as CarritoProducto;

            if (productoSeleccionado == null)
            {
                Mensajes("Hubo un error al obtener el producto seleccionado. Intente nuevamente.");
                return;
            }

            carrito.Remove(productoSeleccionado);
            ActualizarStockProducto(productoSeleccionado);
            actualizarCarrito();
            actualizarDataGridViewProductos();
            Mensajes("Producto eliminado del carrito", Color.Green);
        }

        private void Mensajes(string mensaje, Color? color = null)
        {
            lblMensajes.Visible = true;
            lblMensajes.ForeColor = color ?? Color.Red;
            lblMensajes.Text = mensaje;
        }

        private void ActualizarStockProducto(CarritoProducto productoSeleccionado)
        {
            var productoOriginal = productoNegocio.ObtenerProductos().FirstOrDefault(p => p.id == productoSeleccionado.idProducto);

            if (productoOriginal != null)
            {
                productoOriginal.stock += 1;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            lblClienteNuevo.Visible = false;

            if (cmbCliente.SelectedItem == null)
            {
                Mensajes("Debe seleccionar un cliente antes de agregar productos.");
                return;
            }

            if (dgvProductos.SelectedRows.Count == 0)
            {
                Mensajes("Seleccione un producto de la lista para agregarlo al carrito.");
                return;
            }

            var filaSeleccionada = dgvProductos.SelectedRows[0];
            Producto productoSeleccionado = (Producto)filaSeleccionada.DataBoundItem;
            int cantidadSeleccionada = (int)numericUpDownCantidad.Value;

            if (cantidadSeleccionada > productoSeleccionado.stock)
            {
                Mensajes("No hay suficiente stock disponible para la cantidad seleccionada.");
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
                CarritoProducto productoAgregar = new CarritoProducto
                {
                    idProducto = productoSeleccionado.id,
                    nombre = productoSeleccionado.nombre,
                    precio = productoSeleccionado.precio,
                    stock = productoSeleccionado.stock,
                    idCategoria = productoSeleccionado.idCategoria,
                    idProveedor = productoSeleccionado.idProveedor,
                    cantidadVendida = cantidadSeleccionada
                };
                carrito.Add(productoAgregar);
            }
        }

        private void actualizarCarrito()
        {
            lvCarrito.Items.Clear();

            var productosAgrupados = carrito.GroupBy(p => p.idProducto)
                                            .Select(g => new
                                            {
                                                Producto = g.First(),
                                                Cantidad = g.Sum(p => p.cantidadVendida)   // VER  
                                            }).ToList();

            double totalSinDescuentos = productosAgrupados.Sum(p => p.Producto.precio * p.Cantidad);
            double descuentoPrimeraCompra = ventaNegocio.PromoPrimeraCompra(totalSinDescuentos);
            double descuentoElectroHogar = ventaNegocio.PromoElectroHogar(carrito);
            double totalConDescuento = totalSinDescuentos - descuentoElectroHogar - descuentoPrimeraCompra;
            
            foreach (var item in productosAgrupados)
            {
                var producto = item.Producto;
                var cantidad = item.Cantidad;
                var listViewItem = new ListViewItem(producto.nombre)
                {
                    Tag = producto
                };
                listViewItem.SubItems.Add(producto.precio.ToString("C"));
                listViewItem.SubItems.Add(cantidad.ToString());
                lvCarrito.Items.Add(listViewItem); 
            }

            lblTotal.Text = $"Total: {totalConDescuento:C}";

            Cliente clienteSeleccionado = cmbCliente.SelectedItem as Cliente;
            Guid idCliente = clienteSeleccionado.id;

            bool esPrimeraCompra = ventaNegocio.EsPrimeraCompra(idCliente);

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
                lblMensajes.Visible = true;
                lblAlertadecuentoCatElectroHogar.Text = $"Descuento 5% en productos de Electro Hogar: {descuentoElectroHogar:C}";
            }
            else
            {
                lblAlertadecuentoCatElectroHogar.Visible = false;
            }
        }

        private void actualizarDataGridViewProductos()
        {
            dgvProductos.Refresh();
        }

        private void btnCompletarVenta_Click(object sender, EventArgs e)
        {
            if (carrito.Count == 0)
            {
                lblClienteNuevo.Text = "El carrito está vacío. No puedes completar la venta.";
                return;
            }

            Cliente clienteSeleccionado = cmbCliente.SelectedItem as Cliente;
            if (clienteSeleccionado == null)
            {
                lblClienteNuevo.Text = "Por favor, selecciona un cliente.";
                return;
            }
            Guid idCliente = clienteSeleccionado.id;
            var productosAgrupados = carrito.GroupBy(p => p.idProducto)
                                            .Select(g => new
                                            {
                                                Producto = g.First(),
                                                Cantidad = g.Sum(p => p.cantidadVendida)
                                            }).ToList();

            bool esPrimeraCompra = ventaNegocio.EsPrimeraCompra(clienteSeleccionado.id);
            DateTime fechaVenta = DateTime.Now;
            foreach (var item in productosAgrupados)
            {
                var producto = item.Producto;
                var cantidadVendida = item.Cantidad;
                double montoTotal = producto.precio * cantidadVendida;


                Venta venta = new Venta(idCliente, guidUsuario, producto.idProducto, cantidadVendida, montoTotal, fechaVenta);
                ventaNegocio.AgregarVenta(venta);
                //JSON
                //productoNegocio.ActualizarProductoEnJson(producto.Nombre, producto.Precio, -cantidadVendida);
            }


            var productosListos = productosAgrupados.Select(g => (g.Producto, g.Cantidad)).ToList();
            double totalSinDescuentos = productosListos.Sum(p => p.Producto.precio * p.Cantidad);
            double descuentoPrimeraCompra = esPrimeraCompra ? totalSinDescuentos * 0.05 : 0;


            lblClienteNuevo.Text = "Venta completada con éxito.";

            //GenerarComprobante(clienteSeleccionado, productosListos, descuentoPrimeraCompra);

            carrito.Clear();

            actualizarCarrito();
            cargarProductos();
        }


    }
}

