using System.Drawing;
using System.Windows.Forms;

namespace Presentacion
{
    partial class FrmComprobante
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Required method for Designer support - do not modify the contents of this method with the code editor.
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            lblCliente = new Label();
            lblFecha = new Label();
            lblDetalle = new Label();
            lblPromociones = new Label();
            lblNombrePromocion = new Label();
            dataGridViewDetalles = new DataGridView();
            dataGridViewPromociones = new DataGridView();
            lblMontoDescuento = new Label();
            txtDescuento = new TextBox();
            lblTotalAPagar = new Label();
            txtTotalAPagar = new TextBox();
            txtCliente = new TextBox();
            txtFecha = new TextBox();
            btnGuardarPDF = new Button();
            lblElectroHogar = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDetalles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPromociones).BeginInit();
            SuspendLayout();
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCliente.Location = new Point(52, 66);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(58, 21);
            lblCliente.TabIndex = 0;
            lblCliente.Text = "Cliente";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFecha.Location = new Point(56, 110);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(50, 21);
            lblFecha.TabIndex = 1;
            lblFecha.Text = "Fecha";
            // 
            // lblDetalle
            // 
            lblDetalle.AutoSize = true;
            lblDetalle.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDetalle.Location = new Point(52, 166);
            lblDetalle.Name = "lblDetalle";
            lblDetalle.Size = new Size(58, 21);
            lblDetalle.TabIndex = 2;
            lblDetalle.Text = "Detalle";
            // 
            // lblPromociones
            // 
            lblPromociones.AutoSize = true;
            lblPromociones.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPromociones.Location = new Point(60, 303);
            lblPromociones.Name = "lblPromociones";
            lblPromociones.Size = new Size(101, 21);
            lblPromociones.TabIndex = 3;
            lblPromociones.Text = "Promociones";
            // 
            // lblNombrePromocion
            // 
            lblNombrePromocion.AutoSize = true;
            lblNombrePromocion.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombrePromocion.Location = new Point(338, 389);
            lblNombrePromocion.Name = "lblNombrePromocion";
            lblNombrePromocion.Size = new Size(171, 21);
            lblNombrePromocion.TabIndex = 4;
            lblNombrePromocion.Text = "Promociones Aplicadas";
            // 
            // dataGridViewDetalles
            // 
            dataGridViewDetalles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewDetalles.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewDetalles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewDetalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewDetalles.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewDetalles.Location = new Point(52, 190);
            dataGridViewDetalles.Name = "dataGridViewDetalles";
            dataGridViewDetalles.RowTemplate.Height = 25;
            dataGridViewDetalles.Size = new Size(662, 150);
            dataGridViewDetalles.TabIndex = 5;
            // 
            // dataGridViewPromociones
            // 
            dataGridViewPromociones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPromociones.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewPromociones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewPromociones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridViewPromociones.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewPromociones.Location = new Point(159, 413);
            dataGridViewPromociones.Name = "dataGridViewPromociones";
            dataGridViewPromociones.RowTemplate.Height = 25;
            dataGridViewPromociones.Size = new Size(466, 89);
            dataGridViewPromociones.TabIndex = 6;
            // 
            // lblMontoDescuento
            // 
            lblMontoDescuento.AutoSize = true;
            lblMontoDescuento.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMontoDescuento.Location = new Point(514, 557);
            lblMontoDescuento.Name = "lblMontoDescuento";
            lblMontoDescuento.Size = new Size(133, 21);
            lblMontoDescuento.TabIndex = 7;
            lblMontoDescuento.Text = "Monto Descuento";
            // 
            // txtDescuento
            // 
            txtDescuento.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescuento.Location = new Point(465, 581);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.Size = new Size(220, 29);
            txtDescuento.TabIndex = 8;
            // 
            // lblTotalAPagar
            // 
            lblTotalAPagar.AutoSize = true;
            lblTotalAPagar.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalAPagar.Location = new Point(514, 640);
            lblTotalAPagar.Name = "lblTotalAPagar";
            lblTotalAPagar.Size = new Size(131, 21);
            lblTotalAPagar.TabIndex = 9;
            lblTotalAPagar.Text = "TOTAL A PAGAR";
            // 
            // txtTotalAPagar
            // 
            txtTotalAPagar.Font = new Font("Ebrima", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txtTotalAPagar.Location = new Point(465, 664);
            txtTotalAPagar.Name = "txtTotalAPagar";
            txtTotalAPagar.Size = new Size(220, 38);
            txtTotalAPagar.TabIndex = 10;
            // 
            // txtCliente
            // 
            txtCliente.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCliente.Location = new Point(120, 63);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(594, 29);
            txtCliente.TabIndex = 11;
            // 
            // txtFecha
            // 
            txtFecha.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtFecha.Location = new Point(120, 107);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(594, 29);
            txtFecha.TabIndex = 12;
            // 
            // btnGuardarPDF
            // 
            btnGuardarPDF.FlatAppearance.BorderColor = Color.Blue;
            btnGuardarPDF.FlatAppearance.BorderSize = 5;
            btnGuardarPDF.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardarPDF.Location = new Point(60, 664);
            btnGuardarPDF.Name = "btnGuardarPDF";
            btnGuardarPDF.Size = new Size(135, 52);
            btnGuardarPDF.TabIndex = 13;
            btnGuardarPDF.Text = "GUARDAR COMPROBANTE";
            btnGuardarPDF.UseVisualStyleBackColor = true;
            btnGuardarPDF.Click += btnGuardarPDF_Click;
            // 
            // lblElectroHogar
            // 
            lblElectroHogar.AutoSize = true;
            lblElectroHogar.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblElectroHogar.Location = new Point(564, 9);
            lblElectroHogar.Name = "lblElectroHogar";
            lblElectroHogar.Size = new Size(138, 21);
            lblElectroHogar.TabIndex = 14;
            lblElectroHogar.Text = "Electro Hogar SA";
            // 
            // FrmComprobante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 745);
            Controls.Add(lblElectroHogar);
            Controls.Add(btnGuardarPDF);
            Controls.Add(txtFecha);
            Controls.Add(txtCliente);
            Controls.Add(txtTotalAPagar);
            Controls.Add(lblTotalAPagar);
            Controls.Add(txtDescuento);
            Controls.Add(lblMontoDescuento);
            Controls.Add(dataGridViewPromociones);
            Controls.Add(dataGridViewDetalles);
            Controls.Add(lblNombrePromocion);
            Controls.Add(lblPromociones);
            Controls.Add(lblDetalle);
            Controls.Add(lblFecha);
            Controls.Add(lblCliente);
            Name = "FrmComprobante";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Comprobante Venta";
            Load += FrmComprobante_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewDetalles).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPromociones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        public Label lblCliente;
        public Label lblFecha;
        public Label lblDetalle;
        public Label lblPromociones;
        public Label lblNombrePromocion;
        public DataGridView dataGridViewDetalles;
        public DataGridView dataGridViewPromociones;
        public Label lblMontoDescuento;
        public TextBox txtDescuento;
        public Label lblTotalAPagar;
        public TextBox txtTotalAPagar;
        public TextBox txtCliente;
        public TextBox txtFecha;
        private Button btnGuardarPDF;
        private Label lblElectroHogar;
    }
}