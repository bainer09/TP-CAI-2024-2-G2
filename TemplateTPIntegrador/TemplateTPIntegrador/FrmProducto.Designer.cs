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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.lblPrecioProducto = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblStockActual = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.numericUpDownStock = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvProdProveedor = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.cbCategoriasdeProductos = new System.Windows.Forms.ComboBox();
            this.dgvProductoporCategoria = new System.Windows.Forms.DataGridView();
            this.lvProductoBaja = new System.Windows.Forms.ListView();
            this.lblalertaProductos = new System.Windows.Forms.Label();
            this.chkAudio = new System.Windows.Forms.CheckBox();
            this.chkCelulares = new System.Windows.Forms.CheckBox();
            this.chkElectroHogar = new System.Windows.Forms.CheckBox();
            this.chkInformatica = new System.Windows.Forms.CheckBox();
            this.chkSmartTV = new System.Windows.Forms.CheckBox();
            this.dgwProductoAMostrar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductoporCategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProductoAMostrar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(802, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(101, 58);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(160, 32);
            this.txtNombre.TabIndex = 1;
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.lblNombreProducto.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblNombreProducto.Location = new System.Drawing.Point(102, 32);
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
            this.lblPrecioProducto.Location = new System.Drawing.Point(316, 32);
            this.lblPrecioProducto.Name = "lblPrecioProducto";
            this.lblPrecioProducto.Size = new System.Drawing.Size(71, 23);
            this.lblPrecioProducto.TabIndex = 4;
            this.lblPrecioProducto.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.ForeColor = System.Drawing.Color.Black;
            this.txtPrecio.Location = new System.Drawing.Point(320, 58);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(160, 32);
            this.txtPrecio.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(97, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Categoria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(543, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Seleccione el proveedor";
            // 
            // lblStockActual
            // 
            this.lblStockActual.AutoSize = true;
            this.lblStockActual.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.lblStockActual.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblStockActual.Location = new System.Drawing.Point(872, 32);
            this.lblStockActual.Name = "lblStockActual";
            this.lblStockActual.Size = new System.Drawing.Size(134, 23);
            this.lblStockActual.TabIndex = 16;
            this.lblStockActual.Text = "Stock Actual";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.DarkCyan;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 10.75F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(876, 432);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(160, 59);
            this.btnAgregar.TabIndex = 18;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // numericUpDownStock
            // 
            this.numericUpDownStock.Location = new System.Drawing.Point(101, 301);
            this.numericUpDownStock.Name = "numericUpDownStock";
            this.numericUpDownStock.Size = new System.Drawing.Size(160, 32);
            this.numericUpDownStock.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.DarkCyan;
            this.label4.Location = new System.Drawing.Point(97, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 23);
            this.label4.TabIndex = 19;
            this.label4.Text = "Stock";
            // 
            // dgvProdProveedor
            // 
            this.dgvProdProveedor.BackgroundColor = System.Drawing.Color.White;
            this.dgvProdProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdProveedor.Location = new System.Drawing.Point(547, 58);
            this.dgvProdProveedor.Name = "dgvProdProveedor";
            this.dgvProdProveedor.RowHeadersWidth = 62;
            this.dgvProdProveedor.RowTemplate.Height = 28;
            this.dgvProdProveedor.Size = new System.Drawing.Size(249, 217);
            this.dgvProdProveedor.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(547, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(249, 35);
            this.button1.TabIndex = 22;
            this.button1.Text = "Limpiar seleccion";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cbCategoriasdeProductos
            // 
            this.cbCategoriasdeProductos.FormattingEnabled = true;
            this.cbCategoriasdeProductos.Location = new System.Drawing.Point(876, 58);
            this.cbCategoriasdeProductos.Name = "cbCategoriasdeProductos";
            this.cbCategoriasdeProductos.Size = new System.Drawing.Size(160, 31);
            this.cbCategoriasdeProductos.TabIndex = 23;
            // 
            // dgvProductoporCategoria
            // 
            this.dgvProductoporCategoria.BackgroundColor = System.Drawing.Color.White;
            this.dgvProductoporCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductoporCategoria.Location = new System.Drawing.Point(876, 95);
            this.dgvProductoporCategoria.Name = "dgvProductoporCategoria";
            this.dgvProductoporCategoria.RowHeadersWidth = 62;
            this.dgvProductoporCategoria.RowTemplate.Height = 28;
            this.dgvProductoporCategoria.Size = new System.Drawing.Size(160, 150);
            this.dgvProductoporCategoria.TabIndex = 24;
            // 
            // lvProductoBaja
            // 
            this.lvProductoBaja.HideSelection = false;
            this.lvProductoBaja.Location = new System.Drawing.Point(876, 264);
            this.lvProductoBaja.Name = "lvProductoBaja";
            this.lvProductoBaja.Size = new System.Drawing.Size(160, 79);
            this.lvProductoBaja.TabIndex = 25;
            this.lvProductoBaja.UseCompatibleStateImageBehavior = false;
            // 
            // lblalertaProductos
            // 
            this.lblalertaProductos.AutoSize = true;
            this.lblalertaProductos.ForeColor = System.Drawing.Color.Red;
            this.lblalertaProductos.Location = new System.Drawing.Point(565, 338);
            this.lblalertaProductos.Name = "lblalertaProductos";
            this.lblalertaProductos.Size = new System.Drawing.Size(174, 23);
            this.lblalertaProductos.TabIndex = 28;
            this.lblalertaProductos.Text = "Alerta Productos";
            // 
            // chkAudio
            // 
            this.chkAudio.AutoSize = true;
            this.chkAudio.Location = new System.Drawing.Point(101, 158);
            this.chkAudio.Name = "chkAudio";
            this.chkAudio.Size = new System.Drawing.Size(93, 27);
            this.chkAudio.TabIndex = 29;
            this.chkAudio.Text = "Audio";
            this.chkAudio.UseVisualStyleBackColor = true;
            // 
            // chkCelulares
            // 
            this.chkCelulares.AutoSize = true;
            this.chkCelulares.Location = new System.Drawing.Point(101, 191);
            this.chkCelulares.Name = "chkCelulares";
            this.chkCelulares.Size = new System.Drawing.Size(128, 27);
            this.chkCelulares.TabIndex = 30;
            this.chkCelulares.Text = "Celulares";
            this.chkCelulares.UseVisualStyleBackColor = true;
            // 
            // chkElectroHogar
            // 
            this.chkElectroHogar.AutoSize = true;
            this.chkElectroHogar.Location = new System.Drawing.Point(101, 224);
            this.chkElectroHogar.Name = "chkElectroHogar";
            this.chkElectroHogar.Size = new System.Drawing.Size(170, 27);
            this.chkElectroHogar.TabIndex = 31;
            this.chkElectroHogar.Text = "Electro Hogar";
            this.chkElectroHogar.UseVisualStyleBackColor = true;
            // 
            // chkInformatica
            // 
            this.chkInformatica.AutoSize = true;
            this.chkInformatica.Location = new System.Drawing.Point(320, 158);
            this.chkInformatica.Name = "chkInformatica";
            this.chkInformatica.Size = new System.Drawing.Size(148, 27);
            this.chkInformatica.TabIndex = 32;
            this.chkInformatica.Text = "Informática";
            this.chkInformatica.UseVisualStyleBackColor = true;
            // 
            // chkSmartTV
            // 
            this.chkSmartTV.AutoSize = true;
            this.chkSmartTV.Location = new System.Drawing.Point(320, 191);
            this.chkSmartTV.Name = "chkSmartTV";
            this.chkSmartTV.Size = new System.Drawing.Size(121, 27);
            this.chkSmartTV.TabIndex = 33;
            this.chkSmartTV.Text = "Smart TV";
            this.chkSmartTV.UseVisualStyleBackColor = true;
            // 
            // dgwProductoAMostrar
            // 
            this.dgwProductoAMostrar.BackgroundColor = System.Drawing.Color.White;
            this.dgwProductoAMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProductoAMostrar.Location = new System.Drawing.Point(876, 95);
            this.dgwProductoAMostrar.Name = "dgwProductoAMostrar";
            this.dgwProductoAMostrar.RowHeadersWidth = 62;
            this.dgwProductoAMostrar.RowTemplate.Height = 28;
            this.dgwProductoAMostrar.Size = new System.Drawing.Size(160, 150);
            this.dgwProductoAMostrar.TabIndex = 34;
            // 
            // FrmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1067, 518);
            this.Controls.Add(this.dgwProductoAMostrar);
            this.Controls.Add(this.chkSmartTV);
            this.Controls.Add(this.chkInformatica);
            this.Controls.Add(this.chkElectroHogar);
            this.Controls.Add(this.chkCelulares);
            this.Controls.Add(this.chkAudio);
            this.Controls.Add(this.lblalertaProductos);
            this.Controls.Add(this.lvProductoBaja);
            this.Controls.Add(this.dgvProductoporCategoria);
            this.Controls.Add(this.cbCategoriasdeProductos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvProdProveedor);
            this.Controls.Add(this.numericUpDownStock);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblStockActual);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPrecioProducto);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblNombreProducto);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.ForeColor = System.Drawing.Color.DarkCyan;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmProducto";
            this.Text = "Registrar Producto";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductoporCategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProductoAMostrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

            #endregion

            private System.Windows.Forms.Label label1;
            private System.Windows.Forms.TextBox txtNombre;
            private System.Windows.Forms.Label lblNombreProducto;
            private System.Windows.Forms.Label lblPrecioProducto;
            private System.Windows.Forms.TextBox txtPrecio;
            private System.Windows.Forms.Label label2;
            private System.Windows.Forms.Label label3;
            private System.Windows.Forms.Label lblStockActual;
            private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.NumericUpDown numericUpDownStock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvProdProveedor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbCategoriasdeProductos;
        private System.Windows.Forms.DataGridView dgvProductoporCategoria;
        private System.Windows.Forms.ListView lvProductoBaja;
        private System.Windows.Forms.Label lblalertaProductos;
        private System.Windows.Forms.CheckBox chkAudio;
        private System.Windows.Forms.CheckBox chkCelulares;
        private System.Windows.Forms.CheckBox chkElectroHogar;
        private System.Windows.Forms.CheckBox chkInformatica;
        private System.Windows.Forms.CheckBox chkSmartTV;
        private System.Windows.Forms.DataGridView dgwProductoAMostrar;
    }
    }