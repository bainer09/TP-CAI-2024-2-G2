using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Presentacion
{
    public partial class FrmComprobante : Form
    {
        public FrmComprobante()
        {
            InitializeComponent();
        }

        private void FrmComprobante_Load(object sender, EventArgs e)
        {
        }

        private void btnGuardarPDF_Click(object sender, EventArgs e)
        {
            // Configuración del cuadro de diálogo para guardar archivo
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                saveFileDialog.Title = "Guardar Comprobante como PDF";
                saveFileDialog.FileName = $"Comprobante_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    // Crear el documento y el archivo PDF
                    Document document = new Document();
                    PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));

                    // Asignar el evento para encabezado y pie de página
                    Pdf eventHandler = new Pdf();
                    writer.PageEvent = eventHandler;

                    // Abrir el documento y agregar contenido
                    document.Open();
                    document.Add(new Paragraph("Comprobante de Venta"));
                    document.Add(new Paragraph("Fecha: " + txtFecha.Text));
                    document.Add(new Paragraph("Cliente: " + txtCliente.Text));
                    document.Add(new Paragraph(" "));

                    // Crear la tabla de detalles
                    PdfPTable table = new PdfPTable(4);
                    table.AddCell("Descripción");
                    table.AddCell("Cantidad");
                    table.AddCell("Monto Unitario");
                    table.AddCell("Monto Total");

                    foreach (DataGridViewRow row in dataGridViewDetalles.Rows)
                    {
                        if (row.IsNewRow) continue;

                        table.AddCell(row.Cells["Descripción"].Value?.ToString());
                        table.AddCell(row.Cells["Cantidad"].Value?.ToString());
                        table.AddCell(row.Cells["MontoUnitario"].Value?.ToString());
                        table.AddCell(row.Cells["MontoTotal"].Value?.ToString());
                    }

                    document.Add(table);

                    // Agregar más detalles
                    document.Add(new Paragraph(" "));
                    document.Add(new Paragraph("Descuento: " + txtDescuento.Text));
                    document.Add(new Paragraph("Total a Pagar: " + txtTotalAPagar.Text));

                    document.Close();

                    // Confirmación de guardado
                    MessageBox.Show($"El comprobante se ha guardado correctamente como PDF en: {filePath}",
                        "Guardado Exitoso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    this.Close();
                }
            }
        }
    }
}
