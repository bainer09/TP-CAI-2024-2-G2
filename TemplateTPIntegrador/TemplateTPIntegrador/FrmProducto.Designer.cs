using System.Drawing;

namespace TemplateTPIntegrador
{
    partial class FrmProducto
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
            this.components = new System.ComponentModel.Container();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.lblPrecioProducto = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.numericUpDownStock = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.proveedoresNegocioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.lblalertaProductos = new System.Windows.Forms.Label();
            this.chkAudio = new System.Windows.Forms.CheckBox();
            this.chkCelulares = new System.Windows.Forms.CheckBox();
            this.chkElectroHogar = new System.Windows.Forms.CheckBox();
            this.chkInformatica = new System.Windows.Forms.CheckBox();
            this.chkSmartTV = new System.Windows.Forms.CheckBox();
            this.btnVolveraMenu = new System.Windows.Forms.Button();
            this.ventaNegocioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvProdProveedor = new System.Windows.Forms.DataGridView();
            this.dgvProductosenStock = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresNegocioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaNegocioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosenStock)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(75, 98);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(199, 32);
            this.txtNombre.TabIndex = 1;
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.lblNombreProducto.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblNombreProducto.Location = new System.Drawing.Point(76, 72);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(89, 23);
            this.lblNombreProducto.TabIndex = 2;
            this.lblNombreProducto.Text = "Nombre";
            // 
            // lblPrecioProducto
            // 
            this.lblPrecioProducto.AutoSize = true;
            this.lblPrecioProducto.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.lblPrecioProducto.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblPrecioProducto.Location = new System.Drawing.Point(290, 72);
            this.lblPrecioProducto.Name = "lblPrecioProducto";
            this.lblPrecioProducto.Size = new System.Drawing.Size(71, 23);
            this.lblPrecioProducto.TabIndex = 4;
            this.lblPrecioProducto.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.ForeColor = System.Drawing.Color.Black;
            this.txtPrecio.Location = new System.Drawing.Point(294, 98);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(199, 32);
            this.txtPrecio.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(71, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Categoria";
            // 
            // label3
            // 
            this.label3.AllowDrop = true;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(522, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Seleccione el proveedor";
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.BackColor = System.Drawing.Color.DarkCyan;
            this.btnAgregarProducto.Font = new System.Drawing.Font("Century Gothic", 10.75F, System.Drawing.FontStyle.Bold);
            this.btnAgregarProducto.ForeColor = System.Drawing.Color.White;
            this.btnAgregarProducto.Location = new System.Drawing.Point(117, 413);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(288, 59);
            this.btnAgregarProducto.TabIndex = 18;
            this.btnAgregarProducto.Text = "Agregar";
            this.btnAgregarProducto.UseVisualStyleBackColor = false;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // numericUpDownStock
            // 
            this.numericUpDownStock.Location = new System.Drawing.Point(75, 341);
            this.numericUpDownStock.Name = "numericUpDownStock";
            this.numericUpDownStock.Size = new System.Drawing.Size(199, 32);
            this.numericUpDownStock.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.DarkCyan;
            this.label4.Location = new System.Drawing.Point(71, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 23);
            this.label4.TabIndex = 19;
            this.label4.Text = "Stock";
            // 
            // proveedoresNegocioBindingSource
            // 
            this.proveedoresNegocioBindingSource.DataSource = typeof(Negocio.ProveedoresNegocio);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(117, 478);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(288, 63);
            this.button1.TabIndex = 22;
            this.button1.Text = "Limpiar seleccion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnLimpiarSeleccion_Click);
            // 
            // lblalertaProductos
            // 
            this.lblalertaProductos.AutoSize = true;
            this.lblalertaProductos.ForeColor = System.Drawing.Color.Red;
            this.lblalertaProductos.Location = new System.Drawing.Point(173, 580);
            this.lblalertaProductos.Name = "lblalertaProductos";
            this.lblalertaProductos.Size = new System.Drawing.Size(174, 23);
            this.lblalertaProductos.TabIndex = 28;
            this.lblalertaProductos.Text = "Alerta Productos";
            this.lblalertaProductos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblalertaProductos.Visible = false;
            // 
            // chkAudio
            // 
            this.chkAudio.AutoSize = true;
            this.chkAudio.Location = new System.Drawing.Point(75, 198);
            this.chkAudio.Name = "chkAudio";
            this.chkAudio.Size = new System.Drawing.Size(93, 27);
            this.chkAudio.TabIndex = 29;
            this.chkAudio.Text = "Audio";
            this.chkAudio.UseVisualStyleBackColor = true;
            // 
            // chkCelulares
            // 
            this.chkCelulares.AutoSize = true;
            this.chkCelulares.Location = new System.Drawing.Point(75, 231);
            this.chkCelulares.Name = "chkCelulares";
            this.chkCelulares.Size = new System.Drawing.Size(128, 27);
            this.chkCelulares.TabIndex = 30;
            this.chkCelulares.Text = "Celulares";
            this.chkCelulares.UseVisualStyleBackColor = true;
            // 
            // chkElectroHogar
            // 
            this.chkElectroHogar.AutoSize = true;
            this.chkElectroHogar.Location = new System.Drawing.Point(75, 264);
            this.chkElectroHogar.Name = "chkElectroHogar";
            this.chkElectroHogar.Size = new System.Drawing.Size(170, 27);
            this.chkElectroHogar.TabIndex = 31;
            this.chkElectroHogar.Text = "Electro Hogar";
            this.chkElectroHogar.UseVisualStyleBackColor = true;
            // 
            // chkInformatica
            // 
            this.chkInformatica.AutoSize = true;
            this.chkInformatica.Location = new System.Drawing.Point(294, 198);
            this.chkInformatica.Name = "chkInformatica";
            this.chkInformatica.Size = new System.Drawing.Size(148, 27);
            this.chkInformatica.TabIndex = 32;
            this.chkInformatica.Text = "Informática";
            this.chkInformatica.UseVisualStyleBackColor = true;
            // 
            // chkSmartTV
            // 
            this.chkSmartTV.AutoSize = true;
            this.chkSmartTV.Location = new System.Drawing.Point(294, 231);
            this.chkSmartTV.Name = "chkSmartTV";
            this.chkSmartTV.Size = new System.Drawing.Size(121, 27);
            this.chkSmartTV.TabIndex = 33;
            this.chkSmartTV.Text = "Smart TV";
            this.chkSmartTV.UseVisualStyleBackColor = true;
            // 
            // btnVolveraMenu
            // 
            this.btnVolveraMenu.BackColor = System.Drawing.SystemColors.Control;
            this.btnVolveraMenu.Font = new System.Drawing.Font("Century Gothic", 10.75F, System.Drawing.FontStyle.Bold);
            this.btnVolveraMenu.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnVolveraMenu.Location = new System.Drawing.Point(1395, 33);
            this.btnVolveraMenu.Name = "btnVolveraMenu";
            this.btnVolveraMenu.Size = new System.Drawing.Size(160, 76);
            this.btnVolveraMenu.TabIndex = 34;
            this.btnVolveraMenu.Text = "Volver al Menu";
            this.btnVolveraMenu.UseVisualStyleBackColor = false;
            this.btnVolveraMenu.Click += new System.EventHandler(this.btnVolverMenu_Click);
            // 
            // ventaNegocioBindingSource
            // 
            this.ventaNegocioBindingSource.DataSource = typeof(Negocio.VentaNegocio);
            // 
            // dgvProdProveedor
            // 
            this.dgvProdProveedor.AllowUserToAddRows = false;
            this.dgvProdProveedor.AllowUserToDeleteRows = false;
            this.dgvProdProveedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProdProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdProveedor.Location = new System.Drawing.Point(526, 98);
            this.dgvProdProveedor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvProdProveedor.Name = "dgvProdProveedor";
            this.dgvProdProveedor.ReadOnly = true;
            this.dgvProdProveedor.RowHeadersWidth = 62;
            this.dgvProdProveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdProveedor.Size = new System.Drawing.Size(819, 193);
            this.dgvProdProveedor.TabIndex = 35;
            // 
            // dgvProductosenStock
            // 
            this.dgvProductosenStock.AllowUserToAddRows = false;
            this.dgvProductosenStock.AllowUserToDeleteRows = false;
            this.dgvProductosenStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductosenStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductosenStock.Location = new System.Drawing.Point(526, 348);
            this.dgvProductosenStock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvProductosenStock.Name = "dgvProductosenStock";
            this.dgvProductosenStock.ReadOnly = true;
            this.dgvProductosenStock.RowHeadersWidth = 62;
            this.dgvProductosenStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductosenStock.Size = new System.Drawing.Size(819, 193);
            this.dgvProductosenStock.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(522, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 23);
            this.label1.TabIndex = 36;
            this.label1.Text = "Productos en Stock";
            // 
            // FrmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1593, 640);
            this.Controls.Add(this.dgvProductosenStock);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvProdProveedor);
            this.Controls.Add(this.btnVolveraMenu);
            this.Controls.Add(this.chkSmartTV);
            this.Controls.Add(this.chkInformatica);
            this.Controls.Add(this.chkElectroHogar);
            this.Controls.Add(this.chkCelulares);
            this.Controls.Add(this.chkAudio);
            this.Controls.Add(this.lblalertaProductos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDownStock);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPrecioProducto);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblNombreProducto);
            this.Controls.Add(this.txtNombre);
            this.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.ForeColor = System.Drawing.Color.DarkCyan;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmProducto";
            this.Text = "Registrar Producto";
            this.Load += new System.EventHandler(this.FrmProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresNegocioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaNegocioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosenStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

            #endregion
            private System.Windows.Forms.TextBox txtNombre;
            private System.Windows.Forms.Label lblNombreProducto;
            private System.Windows.Forms.Label lblPrecioProducto;
            private System.Windows.Forms.TextBox txtPrecio;
            private System.Windows.Forms.Label label2;
            private System.Windows.Forms.Label label3;
            private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.NumericUpDown numericUpDownStock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblalertaProductos;
        private System.Windows.Forms.CheckBox chkAudio;
        private System.Windows.Forms.CheckBox chkCelulares;
        private System.Windows.Forms.CheckBox chkElectroHogar;
        private System.Windows.Forms.CheckBox chkInformatica;
        private System.Windows.Forms.CheckBox chkSmartTV;
        private System.Windows.Forms.Button btnVolveraMenu;
        private System.Windows.Forms.BindingSource proveedoresNegocioBindingSource;
        private System.Windows.Forms.BindingSource ventaNegocioBindingSource;
        private System.Windows.Forms.DataGridView dgvProdProveedor;
        private System.Windows.Forms.DataGridView dgvProductosenStock;
        private System.Windows.Forms.Label label1;
    }
    }