using Datos;
using iTextSharp.text;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmDevolverVenta : Form
    {
        private int perfilUsuario;
        private Guid guidUsuario;
        string userLogueado = UsuarioLogueado.nombreUsuario;
        private UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
        private ProductoNegocio productoNegocio = new ProductoNegocio();
        private ClienteNegocio clienteNegocio = new ClienteNegocio();
        private VentaNegocio ventaNegocio = new VentaNegocio();

        public FrmDevolverVenta(int perfilUsuario)
        {
            InitializeComponent();
            this.perfilUsuario = perfilUsuario;
        }

        private void FrmDevolverVenta_Load(object sender, EventArgs e)
        {
            List<Cliente> clientes = clienteNegocio.ObtenerClientes();
            clientes = clientes.OrderBy(c => c.apellido).ToList();
            cbClientes.DataSource = clientes;
            cbClientes.DisplayMember = "NombreCompleto";
            cbClientes.ValueMember = "Id";
            cbClientes.SelectedIndex = -1;

            // Vincular eventos del DataGridView para el manejo de checkbox
            dgvProductoscompradosporCliente.CurrentCellDirtyStateChanged += dgvProductoscompradosporCliente_CurrentCellDirtyStateChanged;
            dgvProductoscompradosporCliente.CellValueChanged += dgvProductoscompradosporCliente_CellValueChanged;
        }

        private void cbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblAlertaDevolucion.Text = "";

            if (cbClientes.SelectedIndex != -1)
            {
                Cliente clienteSeleccionado = cbClientes.SelectedItem as Cliente;
                if (clienteSeleccionado != null)
                {
                    Guid idCliente = clienteSeleccionado.id;
                    List<GetVenta> ventas = ventaNegocio.ObtenerVentasPorCliente(idCliente);

                    TimeZoneInfo timeZone = TimeZoneInfo.FindSystemTimeZoneById("Argentina Standard Time");
                    var ventasOrdenadas = ventas.Select(v => new
                    {
                        v.id,
                        FechaAlta = TimeZoneInfo.ConvertTimeFromUtc(v.fechaAlta, timeZone),
                        v.cantidad,
                        Estado = v.estado == 0 ? "DEVUELTO" : ""
                    })
                    .OrderBy(v => v.FechaAlta)
                    .ToList();

                    dgvProductoscompradosporCliente.DataSource = ventasOrdenadas;

                    // Agregar columna de tipo checkbox después de asignar el DataSource
                    AgregarColumnaCheckbox();

                    // Actualizar estado del botón de devolución
                    ActualizarEstadoBotonDevolucion();
                }
            }
        }
        private void AgregarColumnaCheckbox()
        {
            if (!dgvProductoscompradosporCliente.Columns.Contains("Seleccionar"))
            {
                DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn
                {
                    Name = "Seleccionar",
                    HeaderText = "Seleccionar",
                    Width = 50,
                    TrueValue = true,
                    FalseValue = false
                };

                dgvProductoscompradosporCliente.Columns.Insert(0, checkBoxColumn);
            }
        }


        private void dgvProductoscompradosporCliente_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvProductoscompradosporCliente.Columns["Seleccionar"].Index)
            {
                // Actualizar el estado del botón si se modifica un checkbox
                ActualizarEstadoBotonDevolucion();
            }
        }

        private void dgvProductoscompradosporCliente_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            // Forzar el evento CellValueChanged al modificar un checkbox
            if (dgvProductoscompradosporCliente.IsCurrentCellDirty)
            {
                dgvProductoscompradosporCliente.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void ActualizarEstadoBotonDevolucion()
        {
            bool haySeleccion = dgvProductoscompradosporCliente.Rows.Cast<DataGridViewRow>()
                .Any(row => Convert.ToBoolean(row.Cells["Seleccionar"].Value) == true);

            btnDevolverProducto.Enabled = haySeleccion;
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            try
            {
                List<Usuario> usuarios = usuarioNegocio.listarUsuarios();
                Usuario usuario = usuarios.FirstOrDefault(u => u.nombreUsuario == userLogueado);

                // Verificar si hay filas seleccionadas con el checkbox
                var filasSeleccionadas = dgvProductoscompradosporCliente.Rows
                    .Cast<DataGridViewRow>()
                    .Where(row => Convert.ToBoolean(row.Cells["Seleccionar"].Value) == true)
                    .ToList();

                if (filasSeleccionadas.Count == 0)
                {
                    lblAlertaDevolucion.Text = "Seleccione una venta para devolver.";
                    return;
                }

                guidUsuario = usuario.id;

                foreach (var fila in filasSeleccionadas)
                {
                    Guid idVenta = (Guid)fila.Cells["id"].Value;

                    DevolucionVenta devolucion = new DevolucionVenta(idVenta, guidUsuario);
                    ventaNegocio.DevolucionVenta(devolucion);
                }

                lblAlertaDevolucion.Text = "Devolución realizada correctamente.";
                cbClientes_SelectedIndexChanged(sender, e); // Actualizar la lista de ventas
            }
            catch (Exception ex)
            {
                lblAlertaDevolucion.Text = "Error al realizar la devolución: " + ex.Message;
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
