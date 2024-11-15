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
            this.btnRemoverItem = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dgvProductosaRegistrar = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownCantidad = new System.Windows.Forms.NumericUpDown();
            this.button3 = new System.Windows.Forms.Button();
            this.dateTimePickerVenta = new System.Windows.Forms.DateTimePicker();
            this.lblClienteNuevo = new System.Windows.Forms.Label();
            this.lblMensajes = new System.Windows.Forms.Label();
            this.lblPrimeraCompra = new System.Windows.Forms.Label();
            this.btnVolveraMenu = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblAlertadecuentoCatElectroHogar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosaRegistrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidad)).BeginInit();
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
            this.label2.Location = new System.Drawing.Point(371, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Carrito";
            // 
            // lvCarrito
            // 
            this.lvCarrito.HideSelection = false;
            this.lvCarrito.Location = new System.Drawing.Point(376, 123);
            this.lvCarrito.Name = "lvCarrito";
            this.lvCarrito.Size = new System.Drawing.Size(174, 163);
            this.lvCarrito.TabIndex = 3;
            this.lvCarrito.UseCompatibleStateImageBehavior = false;
            // 
            // btnRemoverItem
            // 
            this.btnRemoverItem.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnRemoverItem.ForeColor = System.Drawing.Color.Red;
            this.btnRemoverItem.Location = new System.Drawing.Point(376, 292);
            this.btnRemoverItem.Name = "btnRemoverItem";
            this.btnRemoverItem.Size = new System.Drawing.Size(174, 35);
            this.btnRemoverItem.TabIndex = 4;
            this.btnRemoverItem.Text = "Remover Item";
            this.btnRemoverItem.UseVisualStyleBackColor = true;
            this.btnRemoverItem.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 10.75F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(605, 263);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 38);
            this.button2.TabIndex = 5;
            this.button2.Text = "Registrar venta";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(649, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 38);
            this.label3.TabIndex = 6;
            this.label3.Text = "Total";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(649, 201);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(93, 37);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "$0,00";
            // 
            // dgvProductosaRegistrar
            // 
            this.dgvProductosaRegistrar.AllowUserToDeleteRows = false;
            this.dgvProductosaRegistrar.BackgroundColor = System.Drawing.Color.White;
            this.dgvProductosaRegistrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductosaRegistrar.Location = new System.Drawing.Point(68, 157);
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
            // numericUpDownCantidad
            // 
            this.numericUpDownCantidad.Location = new System.Drawing.Point(185, 324);
            this.numericUpDownCantidad.Name = "numericUpDownCantidad";
            this.numericUpDownCantidad.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownCantidad.TabIndex = 13;
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
            this.button3.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dateTimePickerVenta
            // 
            this.dateTimePickerVenta.CalendarFont = new System.Drawing.Font("Century Gothic", 8F);
            this.dateTimePickerVenta.CalendarForeColor = System.Drawing.Color.Black;
            this.dateTimePickerVenta.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.dateTimePickerVenta.CalendarTrailingForeColor = System.Drawing.Color.DarkCyan;
            this.dateTimePickerVenta.Location = new System.Drawing.Point(68, 22);
            this.dateTimePickerVenta.Name = "dateTimePickerVenta";
            this.dateTimePickerVenta.Size = new System.Drawing.Size(318, 26);
            this.dateTimePickerVenta.TabIndex = 15;
            // 
            // lblClienteNuevo
            // 
            this.lblClienteNuevo.AutoSize = true;
            this.lblClienteNuevo.BackColor = System.Drawing.SystemColors.Control;
            this.lblClienteNuevo.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.lblClienteNuevo.ForeColor = System.Drawing.Color.Green;
            this.lblClienteNuevo.Location = new System.Drawing.Point(234, 97);
            this.lblClienteNuevo.Name = "lblClienteNuevo";
            this.lblClienteNuevo.Size = new System.Drawing.Size(57, 21);
            this.lblClienteNuevo.TabIndex = 16;
            this.lblClienteNuevo.Text = "label6";
            // 
            // lblMensajes
            // 
            this.lblMensajes.AutoSize = true;
            this.lblMensajes.BackColor = System.Drawing.SystemColors.Control;
            this.lblMensajes.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.lblMensajes.ForeColor = System.Drawing.Color.Green;
            this.lblMensajes.Location = new System.Drawing.Point(342, 373);
            this.lblMensajes.Name = "lblMensajes";
            this.lblMensajes.Size = new System.Drawing.Size(57, 21);
            this.lblMensajes.TabIndex = 17;
            this.lblMensajes.Text = "label6";
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
            // btnVolveraMenu
            // 
            this.btnVolveraMenu.BackColor = System.Drawing.SystemColors.Control;
            this.btnVolveraMenu.Font = new System.Drawing.Font("Century Gothic", 10.75F, System.Drawing.FontStyle.Bold);
            this.btnVolveraMenu.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnVolveraMenu.Location = new System.Drawing.Point(612, 22);
            this.btnVolveraMenu.Name = "btnVolveraMenu";
            this.btnVolveraMenu.Size = new System.Drawing.Size(160, 76);
            this.btnVolveraMenu.TabIndex = 35;
            this.btnVolveraMenu.Text = "Volver al Menu";
            this.btnVolveraMenu.UseVisualStyleBackColor = false;
            this.btnVolveraMenu.Click += new System.EventHandler(this.btnVolverMenu_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 36;
            this.label6.Text = "label6";
            // 
            // lblAlertadecuentoCatElectroHogar
            // 
            this.lblAlertadecuentoCatElectroHogar.AutoSize = true;
            this.lblAlertadecuentoCatElectroHogar.BackColor = System.Drawing.SystemColors.Control;
            this.lblAlertadecuentoCatElectroHogar.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.lblAlertadecuentoCatElectroHogar.ForeColor = System.Drawing.Color.Green;
            this.lblAlertadecuentoCatElectroHogar.Location = new System.Drawing.Point(493, 365);
            this.lblAlertadecuentoCatElectroHogar.Name = "lblAlertadecuentoCatElectroHogar";
            this.lblAlertadecuentoCatElectroHogar.Size = new System.Drawing.Size(57, 21);
            this.lblAlertadecuentoCatElectroHogar.TabIndex = 37;
            this.lblAlertadecuentoCatElectroHogar.Text = "label6";
            // 
            // FrmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAlertadecuentoCatElectroHogar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnVolveraMenu);
            this.Controls.Add(this.lblPrimeraCompra);
            this.Controls.Add(this.lblMensajes);
            this.Controls.Add(this.lblClienteNuevo);
            this.Controls.Add(this.dateTimePickerVenta);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.numericUpDownCantidad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvProductosaRegistrar);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnRemoverItem);
            this.Controls.Add(this.lvCarrito);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.label1);
            this.Name = "FrmVenta";
            this.Text = " Registrar Venta";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosaRegistrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvCarrito;
        private System.Windows.Forms.Button btnRemoverItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView dgvProductosaRegistrar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownCantidad;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker dateTimePickerVenta;
        private System.Windows.Forms.Label lblClienteNuevo;
        private System.Windows.Forms.Label lblMensajes;
        private System.Windows.Forms.Label lblPrimeraCompra;
        private System.Windows.Forms.Button btnVolveraMenu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblAlertadecuentoCatElectroHogar;
    }
}