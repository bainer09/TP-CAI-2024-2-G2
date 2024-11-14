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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TemplateTPIntegrador
{
    public partial class FrmReportes : Form
    {
        private UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
        private ProductoNegocio productoNegocio = new ProductoNegocio();
        private int perfilUsuario;
        private ReporteNegocio reporteNegocio = new ReporteNegocio();

        public FrmReportes(int perfilUsuario)
        {
            InitializeComponent();
            this.perfilUsuario = perfilUsuario;
        }

        private void FrmReportes_Load(object sender, EventArgs e)
        {
            cmbReportes.Items.Add("Reporte de ventas por vendedor");
            if (perfilUsuario == 2 || perfilUsuario == 3)
            {
                cmbReportes.Items.Add("Reporte de productos más vendido por categoría");
                cmbReportes.Items.Add("Productos con stock critico");
            }
        }

        private void cmbReportes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int reporteSeleccionado = cmbReportes.SelectedIndex;
            switch (reporteSeleccionado)
            {
                case 0:
                    VentasPorVendedor();
                    break;
                case 1:
                    ProductosMasVendidos();
                    break;
                case 2:
                    ProductosConStockCritico();
                    break;
            }

        }

        private void VentasPorVendedor()
        {
            var informe = reporteNegocio.ReporteVentasPorVendedor();
            if (informe != null && informe.Count > 0)
            {
                dgvReportes.DataSource = informe;
                if (dgvReportes.Columns["MontoTotal"] != null)
                {
                    dgvReportes.Columns["MontoTotal"].DefaultCellStyle.Format = "C";
                    dgvReportes.Columns["MontoTotal"].DefaultCellStyle.FormatProvider = new System.Globalization.CultureInfo("es-AR");
                }
            }
            else
            {
                MensajeSinVentas();
                dgvReportes.DataSource = null;
                cmbReportes.SelectedIndex = -1;
            }
        }

        private void ProductosMasVendidos()
        {
            var informe = reporteNegocio.ReporteProductosMasVendidos();
            if (informe != null && informe.Count > 0)
            {
                dgvReportes.DataSource = informe;
            }
            else
            {
                MensajeSinVentas();
                dgvReportes.DataSource = null;
                cmbReportes.SelectedIndex = -1;
            }
        }

        private void ProductosConStockCritico()
        {
            var informe = reporteNegocio.ReporteProductosConStockCritico();
            if (informe != null && informe.Count > 0)
            {
                dgvReportes.DataSource = informe;
            }
            else
            {
                MessageBox.Show("No hay productos con Stock Critico");
                dgvReportes.DataSource = null;
                cmbReportes.SelectedIndex = -1;
            }
        }

        private void MensajeSinVentas()
        {
            MessageBox.Show("No hay datos disponibles para el informe seleccionado. \nNo han realizado ninguna venta por el momento", FrmReportes.ActiveForm.Text);
        }

        private void btnVolverInicio_Click(object sender, EventArgs e)
        {
            FrmMain frmMain = new FrmMain(perfilUsuario, usuarioNegocio, productoNegocio);
            frmMain.Show();
            this.Hide();
        }
    }
}
