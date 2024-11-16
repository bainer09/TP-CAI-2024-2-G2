namespace Presentacion
{
    partial class FrmDevolverVenta
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDevolverProducto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbClientes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvProductoscompradosporCliente = new System.Windows.Forms.DataGridView();
            this.btnVolverInicio = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblAlertaDevolucion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductoscompradosporCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDevolverProducto
            // 
            this.btnDevolverProducto.Font = new System.Drawing.Font("Century Gothic", 10.75F, System.Drawing.FontStyle.Bold);
            this.btnDevolverProducto.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnDevolverProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDevolverProducto.Location = new System.Drawing.Point(208, 278);
            this.btnDevolverProducto.Margin = new System.Windows.Forms.Padding(2);
            this.btnDevolverProducto.Name = "btnDevolverProducto";
            this.btnDevolverProducto.Size = new System.Drawing.Size(209, 52);
            this.btnDevolverProducto.TabIndex = 4;
            this.btnDevolverProducto.Text = "Devolver Producto";
            this.btnDevolverProducto.UseVisualStyleBackColor = true;
            this.btnDevolverProducto.Click += new System.EventHandler(this.btnDevolver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(232, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione el cliente";
            // 
            // cbClientes
            // 
            this.cbClientes.FormattingEnabled = true;
            this.cbClientes.Location = new System.Drawing.Point(185, 63);
            this.cbClientes.Margin = new System.Windows.Forms.Padding(2);
            this.cbClientes.Name = "cbClientes";
            this.cbClientes.Size = new System.Drawing.Size(255, 21);
            this.cbClientes.TabIndex = 1;
            this.cbClientes.SelectedIndexChanged += new System.EventHandler(this.cbClientes_SelectedIndexChanged);
            this.cbClientes.Click += new System.EventHandler(this.cbClientes_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(192, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Seleccione la venta a devolver";
            // 
            // dgvProductoscompradosporCliente
            // 
            this.dgvProductoscompradosporCliente.BackgroundColor = System.Drawing.Color.White;
            this.dgvProductoscompradosporCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductoscompradosporCliente.Location = new System.Drawing.Point(75, 116);
            this.dgvProductoscompradosporCliente.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProductoscompradosporCliente.Name = "dgvProductoscompradosporCliente";
            this.dgvProductoscompradosporCliente.RowHeadersWidth = 62;
            this.dgvProductoscompradosporCliente.RowTemplate.Height = 28;
            this.dgvProductoscompradosporCliente.Size = new System.Drawing.Size(487, 140);
            this.dgvProductoscompradosporCliente.TabIndex = 3;
            // 
            // btnVolverInicio
            // 
            this.btnVolverInicio.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVolverInicio.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverInicio.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnVolverInicio.Location = new System.Drawing.Point(1260, 500);
            this.btnVolverInicio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVolverInicio.Name = "btnVolverInicio";
            this.btnVolverInicio.Size = new System.Drawing.Size(267, 51);
            this.btnVolverInicio.TabIndex = 20;
            this.btnVolverInicio.Text = "MENU PRINCIPAL";
            this.btnVolverInicio.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkCyan;
            this.button1.Location = new System.Drawing.Point(421, 448);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 33);
            this.button1.TabIndex = 21;
            this.button1.Text = "MENU PRINCIPAL";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnVolverInicio_Click);
            // 
            // lblAlertaDevolucion
            // 
            this.lblAlertaDevolucion.AutoSize = true;
            this.lblAlertaDevolucion.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlertaDevolucion.ForeColor = System.Drawing.Color.Black;
            this.lblAlertaDevolucion.Location = new System.Drawing.Point(205, 341);
            this.lblAlertaDevolucion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAlertaDevolucion.Name = "lblAlertaDevolucion";
            this.lblAlertaDevolucion.Size = new System.Drawing.Size(38, 16);
            this.lblAlertaDevolucion.TabIndex = 22;
            this.lblAlertaDevolucion.Text = "Alerta";
            // 
            // FrmDevolverVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(636, 494);
            this.Controls.Add(this.lblAlertaDevolucion);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnVolverInicio);
            this.Controls.Add(this.btnDevolverProducto);
            this.Controls.Add(this.dgvProductoscompradosporCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbClientes);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmDevolverVenta";
            this.Text = "Devolver Venta";
            this.Load += new System.EventHandler(this.FrmDevolverVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductoscompradosporCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbClientes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvProductoscompradosporCliente;
        private System.Windows.Forms.Button btnDevolverProducto;
        private System.Windows.Forms.Button btnVolverInicio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblAlertaDevolucion;
    }
}