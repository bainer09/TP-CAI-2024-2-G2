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
            this.btnRegistrarVenta = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownCantidad = new System.Windows.Forms.NumericUpDown();
            this.button3 = new System.Windows.Forms.Button();
            this.lblClienteNuevo = new System.Windows.Forms.Label();
            this.lblMensajes = new System.Windows.Forms.Label();
            this.lblPrimeraCompra = new System.Windows.Forms.Label();
            this.btnVolveraMenu = new System.Windows.Forms.Button();
            this.lblAlertadescuentoCatElectroHogar = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(38, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente";
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(40, 98);
            this.cmbCliente.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(312, 21);
            this.cmbCliente.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(626, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Carrito";
            // 
            // lvCarrito
            // 
            this.lvCarrito.HideSelection = false;
            this.lvCarrito.Location = new System.Drawing.Point(629, 98);
            this.lvCarrito.Margin = new System.Windows.Forms.Padding(2);
            this.lvCarrito.Name = "lvCarrito";
            this.lvCarrito.Size = new System.Drawing.Size(446, 248);
            this.lvCarrito.TabIndex = 3;
            this.lvCarrito.UseCompatibleStateImageBehavior = false;
            // 
            // btnRemoverItem
            // 
            this.btnRemoverItem.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnRemoverItem.ForeColor = System.Drawing.Color.Red;
            this.btnRemoverItem.Location = new System.Drawing.Point(365, 395);
            this.btnRemoverItem.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoverItem.Name = "btnRemoverItem";
            this.btnRemoverItem.Size = new System.Drawing.Size(217, 34);
            this.btnRemoverItem.TabIndex = 4;
            this.btnRemoverItem.Text = "Remover Item";
            this.btnRemoverItem.UseVisualStyleBackColor = true;
            this.btnRemoverItem.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnRegistrarVenta
            // 
            this.btnRegistrarVenta.BackColor = System.Drawing.Color.Green;
            this.btnRegistrarVenta.Font = new System.Drawing.Font("Century Gothic", 10.75F, System.Drawing.FontStyle.Bold);
            this.btnRegistrarVenta.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarVenta.Location = new System.Drawing.Point(944, 366);
            this.btnRegistrarVenta.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistrarVenta.Name = "btnRegistrarVenta";
            this.btnRegistrarVenta.Size = new System.Drawing.Size(131, 53);
            this.btnRegistrarVenta.TabIndex = 5;
            this.btnRegistrarVenta.Text = "Registrar venta";
            this.btnRegistrarVenta.UseVisualStyleBackColor = false;
            this.btnRegistrarVenta.Click += new System.EventHandler(this.btnRegistrarVenta_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(772, 366);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(60, 23);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "$0,00";
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.BackgroundColor = System.Drawing.Color.White;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(41, 150);
            this.dgvProductos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersWidth = 62;
            this.dgvProductos.RowTemplate.Height = 28;
            this.dgvProductos.Size = new System.Drawing.Size(547, 193);
            this.dgvProductos.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.DarkCyan;
            this.label5.Location = new System.Drawing.Point(37, 363);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Cantidad";
            // 
            // numericUpDownCantidad
            // 
            this.numericUpDownCantidad.Location = new System.Drawing.Point(136, 363);
            this.numericUpDownCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownCantidad.Name = "numericUpDownCantidad";
            this.numericUpDownCantidad.Size = new System.Drawing.Size(112, 20);
            this.numericUpDownCantidad.TabIndex = 13;
            this.numericUpDownCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.button3.ForeColor = System.Drawing.Color.DarkCyan;
            this.button3.Location = new System.Drawing.Point(40, 396);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(217, 33);
            this.button3.TabIndex = 14;
            this.button3.Text = "Agregar al carrito";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblClienteNuevo
            // 
            this.lblClienteNuevo.AutoSize = true;
            this.lblClienteNuevo.BackColor = System.Drawing.SystemColors.Control;
            this.lblClienteNuevo.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.lblClienteNuevo.ForeColor = System.Drawing.Color.Green;
            this.lblClienteNuevo.Location = new System.Drawing.Point(1108, 200);
            this.lblClienteNuevo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClienteNuevo.Name = "lblClienteNuevo";
            this.lblClienteNuevo.Size = new System.Drawing.Size(94, 16);
            this.lblClienteNuevo.TabIndex = 16;
            this.lblClienteNuevo.Text = "lblClienteNuevo";
            this.lblClienteNuevo.Visible = false;
            // 
            // lblMensajes
            // 
            this.lblMensajes.AutoSize = true;
            this.lblMensajes.BackColor = System.Drawing.SystemColors.Control;
            this.lblMensajes.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.lblMensajes.ForeColor = System.Drawing.Color.Green;
            this.lblMensajes.Location = new System.Drawing.Point(1108, 150);
            this.lblMensajes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMensajes.Name = "lblMensajes";
            this.lblMensajes.Size = new System.Drawing.Size(69, 16);
            this.lblMensajes.TabIndex = 17;
            this.lblMensajes.Text = "lblMensajes";
            this.lblMensajes.Visible = false;
            // 
            // lblPrimeraCompra
            // 
            this.lblPrimeraCompra.AutoSize = true;
            this.lblPrimeraCompra.BackColor = System.Drawing.SystemColors.Control;
            this.lblPrimeraCompra.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.lblPrimeraCompra.ForeColor = System.Drawing.Color.Green;
            this.lblPrimeraCompra.Location = new System.Drawing.Point(1108, 226);
            this.lblPrimeraCompra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrimeraCompra.Name = "lblPrimeraCompra";
            this.lblPrimeraCompra.Size = new System.Drawing.Size(104, 16);
            this.lblPrimeraCompra.TabIndex = 18;
            this.lblPrimeraCompra.Text = "lblPrimeraCompra";
            this.lblPrimeraCompra.Visible = false;
            // 
            // btnVolveraMenu
            // 
            this.btnVolveraMenu.BackColor = System.Drawing.SystemColors.Control;
            this.btnVolveraMenu.Font = new System.Drawing.Font("Century Gothic", 10.75F, System.Drawing.FontStyle.Bold);
            this.btnVolveraMenu.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnVolveraMenu.Location = new System.Drawing.Point(1095, 523);
            this.btnVolveraMenu.Margin = new System.Windows.Forms.Padding(2);
            this.btnVolveraMenu.Name = "btnVolveraMenu";
            this.btnVolveraMenu.Size = new System.Drawing.Size(117, 49);
            this.btnVolveraMenu.TabIndex = 35;
            this.btnVolveraMenu.Text = "Volver al Menu";
            this.btnVolveraMenu.UseVisualStyleBackColor = false;
            this.btnVolveraMenu.Click += new System.EventHandler(this.btnVolverMenu_Click);
            // 
            // lblAlertadescuentoCatElectroHogar
            // 
            this.lblAlertadescuentoCatElectroHogar.AutoSize = true;
            this.lblAlertadescuentoCatElectroHogar.BackColor = System.Drawing.SystemColors.Control;
            this.lblAlertadescuentoCatElectroHogar.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.lblAlertadescuentoCatElectroHogar.ForeColor = System.Drawing.Color.Green;
            this.lblAlertadescuentoCatElectroHogar.Location = new System.Drawing.Point(1108, 172);
            this.lblAlertadescuentoCatElectroHogar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAlertadescuentoCatElectroHogar.Name = "lblAlertadescuentoCatElectroHogar";
            this.lblAlertadescuentoCatElectroHogar.Size = new System.Drawing.Size(98, 16);
            this.lblAlertadescuentoCatElectroHogar.TabIndex = 37;
            this.lblAlertadescuentoCatElectroHogar.Text = "lbldescuentoCat";
            this.lblAlertadescuentoCatElectroHogar.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(38, 131);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 38;
            this.label3.Text = "Productos";
            // 
            // FrmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1250, 583);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblAlertadescuentoCatElectroHogar);
            this.Controls.Add(this.btnVolveraMenu);
            this.Controls.Add(this.lblPrimeraCompra);
            this.Controls.Add(this.lblMensajes);
            this.Controls.Add(this.lblClienteNuevo);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.numericUpDownCantidad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnRegistrarVenta);
            this.Controls.Add(this.btnRemoverItem);
            this.Controls.Add(this.lvCarrito);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmVenta";
            this.Text = " Registrar Venta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
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
        private System.Windows.Forms.Button btnRegistrarVenta;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownCantidad;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblClienteNuevo;
        private System.Windows.Forms.Label lblMensajes;
        private System.Windows.Forms.Label lblPrimeraCompra;
        private System.Windows.Forms.Button btnVolveraMenu;
        private System.Windows.Forms.Label lblAlertadescuentoCatElectroHogar;
        private System.Windows.Forms.Label label3;
    }
}