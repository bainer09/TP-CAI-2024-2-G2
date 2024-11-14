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

                //BELU a SACAR?
                /*cmbCliente.SelectedIndexChanged += cbCliente_SelectedIndexChanged;*/
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

        private void FrmVenta_Load(object sender, EventArgs e)
            {
                lblMensajes.Visible = false;
                lblMensajeVentas.Visible = false;
                cargarProductos();
                cargarClientes();
            }

            private void cargarProductos()
            {
                List<Producto> productos = productoNegocio.ObtenerProductos();
                //CORREGIR nombre
                //productos = productos.OrderBy(p => p.nombre).ToList();

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
                //CORREGIR apellido
                //clientes = clientes.OrderBy(c => c.apellido).ToList();

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
                        //CORREGIR id
                        //Guid idCliente = clienteSeleccionado.id;
                        //CORREGIR cliente
                        //bool esPrimeraCompra = ventaNegocio.EsPrimeraCompra(idCliente);

                        //MYR arreglar metodo
                        //lblPrimeraCompra.Visible = esPrimeraCompra;
                        //lblPrimeraCompra.Text = esPrimeraCompra ? "Descuento primera compra: 5%" : string.Empty;
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
                Producto productoSeleccionado = itemSeleccionado.Tag as Producto;

                if (productoSeleccionado == null)
                {
                    Mensajes("Hubo un error al obtener el producto seleccionado. Intente nuevamente.");
                    return;
                }

                carrito.Remove(productoSeleccionado);
                ActualizarStockProducto(productoSeleccionado);
                //MYR a actualizar metodo
                //actualizarCarrito();
                actualizarDataGridViewProductos();
                Mensajes("Producto eliminado del carrito", Color.Green);
            }

            private void Mensajes(string mensaje, Color? color = null)
            {
                lblMensajes.Visible = true;
                lblMensajes.ForeColor = color ?? Color.Red;
                lblMensajes.Text = mensaje;
            }

            private void ActualizarStockProducto(Producto productoSeleccionado)
            {
            //CORREGIR id
            //var productoOriginal = productoNegocio.ObtenerProductos().FirstOrDefault(p => p.id == productoSeleccionado.id);
            //Comento para que no pinche:
                /*if (productoOriginal != null)
                {
                    productoOriginal.Stock += 1;
                }*/
            }

            private void btnAgregar_Click(object sender, EventArgs e)
            {
                lblMensajeVentas.Visible = false;

                if (cmbCliente.SelectedItem == null)
                {
                    Mensajes("Debe seleccionar un cliente antes de agregar productos.");
                    return;
                }

                if (dgvProductosaRegistrar.SelectedRows.Count == 0)
                {
                    Mensajes("Seleccione un producto de la lista para agregarlo al carrito.");
                    return;
                }

                var filaSeleccionada = dgvProductosaRegistrar.SelectedRows[0];
                Producto productoSeleccionado = (Producto)filaSeleccionada.DataBoundItem;
                int cantidadSeleccionada = (int)numericUpDownCantidad.Value;

            //CORREGIR stock
            //if (cantidadSeleccionada > productoSeleccionado.stock)
                {
                    Mensajes("No hay suficiente stock disponible para la cantidad seleccionada.");
                    return;
                }
            //Comento para que no pinche:
            /*
                productoSeleccionado.stock -= cantidadSeleccionada;
                AgregarProductosAlCarrito(productoSeleccionado, cantidadSeleccionada);

                //MYR a actualizar metodo
                //actualizarCarrito();
                actualizarDataGridViewProductos();
            */
            }

            private void AgregarProductosAlCarrito(Producto productoSeleccionado, int cantidadSeleccionada)
            {
                for (int i = 0; i < cantidadSeleccionada; i++)
                {
                    //MYR a chequear nombres
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
                //CORREGIR id
                //Guid idCliente = clienteSeleccionado.id;
                /*var productosAgrupados = carrito.GroupBy(p => p.id)
                                                .Select(g => new
                                                {
                                                    Producto = g.First(),
                                                    Cantidad = g.Sum(p => p.Cantidad)
                                                }).ToList();*/

                //CORREGIR id
                //bool esPrimeraCompra = ventaNegocio.EsPrimeraCompra(clienteSeleccionado.id);
                DateTime fechaVenta = DateTime.Now;
                //Comento para que no pinche
                /*foreach (var item in productosAgrupados)
                {
                    var producto = item.Producto;
                    var cantidadVendida = item.Cantidad;
                    double montoTotal = producto.Precio * cantidadVendida;
                */

                    //MYR a chequear
                    //AgregarVenta venta = new AgregarVenta(idCliente.ToString(), guidUsuario.ToString(), producto.Id.ToString(), cantidadVendida, montoTotal, fechaVenta);
                    
            //CORREGIR venta
                    //ventaNegocio.AgregarVenta(venta);
                    //JSON
                    //productoNegocio.ActualizarProductoEnJson(producto.Nombre, producto.Precio, -cantidadVendida);
                }

                //Comento para que no pinche:
/*
var productosListos = productosAgrupados.Select(g => (g.Producto, g.Cantidad)).ToList();
double totalSinDescuentos = productosListos.Sum(p => p.Producto.Precio * p.Cantidad);
double descuentoPrimeraCompra = esPrimeraCompra ? totalSinDescuentos * 0.05 : 0;


lblMensajeVentas.Text = "Venta completada con éxito.";
*/

//RODRI a hacer lo de generar comprobante
//GenerarComprobante(clienteSeleccionado, productosListos, descuentoPrimeraCompra);

//Comento para que no pinche:
/*
carrito.Clear();
*/

//MYR a actualizar metodo
//actualizarCarrito();

//Comento para que no pinche:
/*
cargarProductos();
*/


}
}

