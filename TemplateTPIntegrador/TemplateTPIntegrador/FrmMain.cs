using Negocio;
using Datos;
using Presentacion;
using PresentacionLayer;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using TemplateTPIntegrador;


namespace Presentacion
{
    public partial class FrmMain : Form
    {
        private readonly UsuarioNegocio usuarioNegocio;
        private readonly ProductoNegocio productoNegocio;
        private int perfilUsuario;

        public FrmMain(int perfilUsuario, UsuarioNegocio usuarioNegocio, ProductoNegocio productoNegocio)
        {
            InitializeComponent();
            this.usuarioNegocio = usuarioNegocio ?? throw new ArgumentNullException(nameof(usuarioNegocio));
            this.productoNegocio = productoNegocio ?? throw new ArgumentNullException(nameof(productoNegocio));
            this.FormClosing += FrmMain_FormClosing;
            this.perfilUsuario = perfilUsuario;
            ConfigurarMenu();
            VerificarStockCritico();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void ConfigurarMenu()
        {
            var controlesPorPerfil = new Dictionary<int, List<ToolStripMenuItem>>
            {
                { 1, new List<ToolStripMenuItem> { strpProductosMenu, strpProveedoresMenu, strpUsuariosMenu, strpDevolucionVenta } },
                { 2, new List<ToolStripMenuItem> { strpUsuariosMenu, strpProveedoresMenu, strpNuevaVenta } },
                { 3, new List<ToolStripMenuItem> { strpVentasMenu } }
            };

            if (controlesPorPerfil.TryGetValue(perfilUsuario, out var controlesADeshabilitar))
            {
                foreach (var control in controlesADeshabilitar)
                {
                    control.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Perfil de usuario no reconocido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void VerificarStockCritico()
        {
            lblStockCritico.Visible = perfilUsuario == 2 || perfilUsuario == 3;
            if (lblStockCritico.Visible)
            {
                int cantidadProductosCriticos = productoNegocio.ContarProductosConStockCritico(); //Falta de Belu y Myr
                lblStockCritico.Text = cantidadProductosCriticos > 0
                    ? $"{cantidadProductosCriticos} productos en stock crítico."
                    : string.Empty;
            }
        }

        private void AbrirFormulario(Form formulario)
        {
            formulario.Show();
            this.Hide();
        }

        public void strpAltaUsuariosMenu_Click(object sender, EventArgs e) => AbrirFormulario(new FrmAltaUsuario());
        public void strpBajaUsuariosMenu_Click(object sender, EventArgs e) => AbrirFormulario(new FrmBajaModUsuario());
        public void strpClientesMenu_Click(object sender, EventArgs e) => AbrirFormulario(new FrmCliente());
        public void strpProductosMenu_Click(object sender, EventArgs e) => AbrirFormulario(new FrmProducto());
        public void strpProveedoresMenu_Click(object sender, EventArgs e) => AbrirFormulario(new FrmProveedores());
        public void strpReportesMenu_Click(object sender, EventArgs e) => AbrirFormulario(new FrmReportes());
        public void btnLogOut_Click(object sender, EventArgs e) => AbrirFormulario(new FrmLogin());
        public void strpNuevaVenta_Click(object sender, EventArgs e)
        {
            FrmComprobante frmComprobante = new FrmComprobante();
            AbrirFormulario(new FrmVenta(frmComprobante));
        }
        public void strpDevolucionVenta_Click(object sender, EventArgs e) => AbrirFormulario(new FrmDevolverVenta());
        private void FrmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
