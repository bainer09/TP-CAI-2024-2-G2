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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.lblPromociones = new System.Windows.Forms.Label();
            this.lblNombrePromocion = new System.Windows.Forms.Label();
            this.dataGridViewDetalles = new System.Windows.Forms.DataGridView();
            this.dataGridViewPromociones = new System.Windows.Forms.DataGridView();
            this.lblMontoDescuento = new System.Windows.Forms.Label();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.lblTotalAPagar = new System.Windows.Forms.Label();
            this.txtTotalAPagar = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.btnGuardarPDF = new System.Windows.Forms.Button();
            this.btnVolverInicio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPromociones)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblCliente.Location = new System.Drawing.Point(45, 57);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(66, 21);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblFecha.Location = new System.Drawing.Point(48, 95);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(59, 21);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Fecha";
            // 
            // lblDetalle
            // 
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalle.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblDetalle.Location = new System.Drawing.Point(48, 130);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(66, 21);
            this.lblDetalle.TabIndex = 2;
            this.lblDetalle.Text = "Detalle";
            // 
            // lblPromociones
            // 
            this.lblPromociones.AutoSize = true;
            this.lblPromociones.Font = new System.Drawing.Font("Ebrima", 12F);
            this.lblPromociones.Location = new System.Drawing.Point(51, 263);
            this.lblPromociones.Name = "lblPromociones";
            this.lblPromociones.Size = new System.Drawing.Size(101, 21);
            this.lblPromociones.TabIndex = 3;
            this.lblPromociones.Text = "Promociones";
            // 
            // lblNombrePromocion
            // 
            this.lblNombrePromocion.AutoSize = true;
            this.lblNombrePromocion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombrePromocion.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblNombrePromocion.Location = new System.Drawing.Point(48, 301);
            this.lblNombrePromocion.Name = "lblNombrePromocion";
            this.lblNombrePromocion.Size = new System.Drawing.Size(191, 21);
            this.lblNombrePromocion.TabIndex = 4;
            this.lblNombrePromocion.Text = "Promociones Aplicadas";
            // 
            // dataGridViewDetalles
            // 
            this.dataGridViewDetalles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDetalles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Ebrima", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDetalles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Ebrima", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewDetalles.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewDetalles.Location = new System.Drawing.Point(52, 154);
            this.dataGridViewDetalles.Name = "dataGridViewDetalles";
            this.dataGridViewDetalles.RowTemplate.Height = 25;
            this.dataGridViewDetalles.Size = new System.Drawing.Size(575, 130);
            this.dataGridViewDetalles.TabIndex = 5;
            // 
            // dataGridViewPromociones
            // 
            this.dataGridViewPromociones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPromociones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Ebrima", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPromociones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewPromociones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Ebrima", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPromociones.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewPromociones.Location = new System.Drawing.Point(52, 325);
            this.dataGridViewPromociones.Name = "dataGridViewPromociones";
            this.dataGridViewPromociones.RowTemplate.Height = 25;
            this.dataGridViewPromociones.Size = new System.Drawing.Size(399, 77);
            this.dataGridViewPromociones.TabIndex = 6;
            // 
            // lblMontoDescuento
            // 
            this.lblMontoDescuento.AutoSize = true;
            this.lblMontoDescuento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoDescuento.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblMontoDescuento.Location = new System.Drawing.Point(48, 419);
            this.lblMontoDescuento.Name = "lblMontoDescuento";
            this.lblMontoDescuento.Size = new System.Drawing.Size(151, 21);
            this.lblMontoDescuento.TabIndex = 7;
            this.lblMontoDescuento.Text = "Monto Descuento";
            // 
            // txtDescuento
            // 
            this.txtDescuento.Font = new System.Drawing.Font("Ebrima", 12F);
            this.txtDescuento.Location = new System.Drawing.Point(52, 443);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(189, 29);
            this.txtDescuento.TabIndex = 8;
            // 
            // lblTotalAPagar
            // 
            this.lblTotalAPagar.AutoSize = true;
            this.lblTotalAPagar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAPagar.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblTotalAPagar.Location = new System.Drawing.Point(48, 475);
            this.lblTotalAPagar.Name = "lblTotalAPagar";
            this.lblTotalAPagar.Size = new System.Drawing.Size(130, 19);
            this.lblTotalAPagar.TabIndex = 9;
            this.lblTotalAPagar.Text = "TOTAL A PAGAR";
            // 
            // txtTotalAPagar
            // 
            this.txtTotalAPagar.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Bold);
            this.txtTotalAPagar.Location = new System.Drawing.Point(52, 497);
            this.txtTotalAPagar.Name = "txtTotalAPagar";
            this.txtTotalAPagar.Size = new System.Drawing.Size(189, 38);
            this.txtTotalAPagar.TabIndex = 10;
            // 
            // txtCliente
            // 
            this.txtCliente.Font = new System.Drawing.Font("Ebrima", 12F);
            this.txtCliente.Location = new System.Drawing.Point(117, 54);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(510, 29);
            this.txtCliente.TabIndex = 11;
            // 
            // txtFecha
            // 
            this.txtFecha.Font = new System.Drawing.Font("Ebrima", 12F);
            this.txtFecha.Location = new System.Drawing.Point(117, 92);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(510, 29);
            this.txtFecha.TabIndex = 12;
            // 
            // btnGuardarPDF
            // 
            this.btnGuardarPDF.BackColor = System.Drawing.Color.DarkCyan;
            this.btnGuardarPDF.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnGuardarPDF.FlatAppearance.BorderSize = 5;
            this.btnGuardarPDF.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarPDF.ForeColor = System.Drawing.Color.White;
            this.btnGuardarPDF.Location = new System.Drawing.Point(52, 554);
            this.btnGuardarPDF.Name = "btnGuardarPDF";
            this.btnGuardarPDF.Size = new System.Drawing.Size(250, 65);
            this.btnGuardarPDF.TabIndex = 13;
            this.btnGuardarPDF.Text = "GUARDAR COMPROBANTE";
            this.btnGuardarPDF.UseVisualStyleBackColor = false;
            // 
            // btnVolverInicio
            // 
            this.btnVolverInicio.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVolverInicio.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverInicio.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnVolverInicio.Location = new System.Drawing.Point(456, 656);
            this.btnVolverInicio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVolverInicio.Name = "btnVolverInicio";
            this.btnVolverInicio.Size = new System.Drawing.Size(225, 49);
            this.btnVolverInicio.TabIndex = 21;
            this.btnVolverInicio.Text = "MENU PRINCIPAL";
            this.btnVolverInicio.UseVisualStyleBackColor = false;
            // 
            // FrmComprobante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 708);
            this.Controls.Add(this.btnVolverInicio);
            this.Controls.Add(this.btnGuardarPDF);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.txtTotalAPagar);
            this.Controls.Add(this.lblTotalAPagar);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.lblMontoDescuento);
            this.Controls.Add(this.dataGridViewPromociones);
            this.Controls.Add(this.dataGridViewDetalles);
            this.Controls.Add(this.lblNombrePromocion);
            this.Controls.Add(this.lblPromociones);
            this.Controls.Add(this.lblDetalle);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblCliente);
            this.Name = "FrmComprobante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comprobante Venta";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPromociones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private Button btnVolverInicio;
    }
}