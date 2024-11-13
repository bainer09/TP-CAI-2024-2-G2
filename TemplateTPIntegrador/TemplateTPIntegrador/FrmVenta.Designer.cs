namespace TemplateTPIntegrador
{
    partial class FrmVenta
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lvCarrito = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvProductosaRegistrar = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button3 = new System.Windows.Forms.Button();
            this.dateTimePickerVenta = new System.Windows.Forms.DateTimePicker();
            this.lblMensajeVentas = new System.Windows.Forms.Label();
            this.lblMensajeCarrito = new System.Windows.Forms.Label();
            this.lblPrimeraCompra = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosaRegistrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(64, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente";
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(69, 123);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(143, 28);
            this.cmbCliente.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(545, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Carrito";
            // 
            // lvCarrito
            // 
            this.lvCarrito.HideSelection = false;
            this.lvCarrito.Location = new System.Drawing.Point(550, 50);
            this.lvCarrito.Name = "lvCarrito";
            this.lvCarrito.Size = new System.Drawing.Size(174, 163);
            this.lvCarrito.TabIndex = 3;
            this.lvCarrito.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(550, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "Remover Item";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 10.75F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(550, 365);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 35);
            this.button2.TabIndex = 5;
            this.button2.Text = "Registrar venta";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(545, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.label4.Location = new System.Drawing.Point(594, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 37);
            this.label4.TabIndex = 10;
            this.label4.Text = "$0,00";
            // 
            // dgvProductosaRegistrar
            // 
            this.dgvProductosaRegistrar.AllowUserToDeleteRows = false;
            this.dgvProductosaRegistrar.BackgroundColor = System.Drawing.Color.White;
            this.dgvProductosaRegistrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductosaRegistrar.Location = new System.Drawing.Point(69, 157);
            this.dgvProductosaRegistrar.Name = "dgvProductosaRegistrar";
            this.dgvProductosaRegistrar.RowHeadersWidth = 62;
            this.dgvProductosaRegistrar.RowTemplate.Height = 28;
            this.dgvProductosaRegistrar.Size = new System.Drawing.Size(240, 150);
            this.dgvProductosaRegistrar.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.DarkCyan;
            this.label5.Location = new System.Drawing.Point(64, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Cantidad";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(185, 324);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown1.TabIndex = 13;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.button3.ForeColor = System.Drawing.Color.DarkCyan;
            this.button3.Location = new System.Drawing.Point(69, 365);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(240, 35);
            this.button3.TabIndex = 14;
            this.button3.Text = "Agregar al carrito";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerVenta
            // 
            this.dateTimePickerVenta.CalendarFont = new System.Drawing.Font("Century Gothic", 8F);
            this.dateTimePickerVenta.CalendarForeColor = System.Drawing.Color.Black;
            this.dateTimePickerVenta.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.dateTimePickerVenta.CalendarTrailingForeColor = System.Drawing.Color.DarkCyan;
            this.dateTimePickerVenta.Location = new System.Drawing.Point(69, 50);
            this.dateTimePickerVenta.Name = "dateTimePickerVenta";
            this.dateTimePickerVenta.Size = new System.Drawing.Size(240, 26);
            this.dateTimePickerVenta.TabIndex = 15;
            // 
            // lblMensajeVentas
            // 
            this.lblMensajeVentas.AutoSize = true;
            this.lblMensajeVentas.BackColor = System.Drawing.SystemColors.Control;
            this.lblMensajeVentas.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.lblMensajeVentas.ForeColor = System.Drawing.Color.Green;
            this.lblMensajeVentas.Location = new System.Drawing.Point(234, 97);
            this.lblMensajeVentas.Name = "lblMensajeVentas";
            this.lblMensajeVentas.Size = new System.Drawing.Size(57, 21);
            this.lblMensajeVentas.TabIndex = 16;
            this.lblMensajeVentas.Text = "label6";
            // 
            // lblMensajeCarrito
            // 
            this.lblMensajeCarrito.AutoSize = true;
            this.lblMensajeCarrito.BackColor = System.Drawing.SystemColors.Control;
            this.lblMensajeCarrito.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.lblMensajeCarrito.ForeColor = System.Drawing.Color.Green;
            this.lblMensajeCarrito.Location = new System.Drawing.Point(65, 403);
            this.lblMensajeCarrito.Name = "lblMensajeCarrito";
            this.lblMensajeCarrito.Size = new System.Drawing.Size(57, 21);
            this.lblMensajeCarrito.TabIndex = 17;
            this.lblMensajeCarrito.Text = "label6";
            // 
            // lblPrimeraCompra
            // 
            this.lblPrimeraCompra.AutoSize = true;
            this.lblPrimeraCompra.BackColor = System.Drawing.SystemColors.Control;
            this.lblPrimeraCompra.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.lblPrimeraCompra.ForeColor = System.Drawing.Color.Green;
            this.lblPrimeraCompra.Location = new System.Drawing.Point(234, 125);
            this.lblPrimeraCompra.Name = "lblPrimeraCompra";
            this.lblPrimeraCompra.Size = new System.Drawing.Size(57, 21);
            this.lblPrimeraCompra.TabIndex = 18;
            this.lblPrimeraCompra.Text = "label6";
            // 
            // FrmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPrimeraCompra);
            this.Controls.Add(this.lblMensajeCarrito);
            this.Controls.Add(this.lblMensajeVentas);
            this.Controls.Add(this.dateTimePickerVenta);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvProductosaRegistrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lvCarrito);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.label1);
            this.Name = "FrmVenta";
            this.Text = " Registrar Venta";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosaRegistrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvCarrito;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvProductosaRegistrar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker dateTimePickerVenta;
        private System.Windows.Forms.Label lblMensajeVentas;
        private System.Windows.Forms.Label lblMensajeCarrito;
        private System.Windows.Forms.Label lblPrimeraCompra;
    }
}