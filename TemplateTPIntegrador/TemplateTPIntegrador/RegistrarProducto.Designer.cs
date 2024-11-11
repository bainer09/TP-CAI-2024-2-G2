namespace TemplateTPIntegrador
{
    partial class RegistrarProducto
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.lblPrecioProducto = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCategorias = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblStockActual = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(465, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(101, 115);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 32);
            this.textBox1.TabIndex = 1;
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.ForeColor = System.Drawing.Color.Black;
            this.lblNombreProducto.Location = new System.Drawing.Point(97, 77);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(90, 23);
            this.lblNombreProducto.TabIndex = 2;
            this.lblNombreProducto.Text = "Nombre";
            // 
            // lblPrecioProducto
            // 
            this.lblPrecioProducto.AutoSize = true;
            this.lblPrecioProducto.ForeColor = System.Drawing.Color.Black;
            this.lblPrecioProducto.Location = new System.Drawing.Point(97, 176);
            this.lblPrecioProducto.Name = "lblPrecioProducto";
            this.lblPrecioProducto.Size = new System.Drawing.Size(70, 23);
            this.lblPrecioProducto.TabIndex = 4;
            this.lblPrecioProducto.Text = "Precio";
            // 
            // textBox2
            // 
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            this.textBox2.Location = new System.Drawing.Point(101, 214);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(160, 32);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(97, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Categoria";
            // 
            // cmbCategorias
            // 
            this.cmbCategorias.FormattingEnabled = true;
            this.cmbCategorias.Items.AddRange(new object[] {
            "Audio",
            "Celulares",
            "Electro Hogar",
            "Informatica",
            "Smart TV"});
            this.cmbCategorias.Location = new System.Drawing.Point(101, 319);
            this.cmbCategorias.Name = "cmbCategorias";
            this.cmbCategorias.Size = new System.Drawing.Size(160, 31);
            this.cmbCategorias.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(350, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Seleccione el proveedor";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(354, 115);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(249, 235);
            this.textBox3.TabIndex = 12;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.ForeColor = System.Drawing.Color.Black;
            this.lblCantidad.Location = new System.Drawing.Point(691, 77);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(104, 23);
            this.lblCantidad.TabIndex = 14;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblStockActual
            // 
            this.lblStockActual.AutoSize = true;
            this.lblStockActual.ForeColor = System.Drawing.Color.Black;
            this.lblStockActual.Location = new System.Drawing.Point(691, 176);
            this.lblStockActual.Name = "lblStockActual";
            this.lblStockActual.Size = new System.Drawing.Size(135, 23);
            this.lblStockActual.TabIndex = 16;
            this.lblStockActual.Text = "Stock Actual";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(695, 214);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(160, 32);
            this.textBox5.TabIndex = 15;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(695, 116);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(160, 32);
            this.numericUpDown1.TabIndex = 17;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(695, 291);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(160, 59);
            this.btnAgregar.TabIndex = 18;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // RegistrarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1067, 518);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lblStockActual);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbCategorias);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPrecioProducto);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblNombreProducto);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.ForeColor = System.Drawing.Color.DarkCyan;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "RegistrarProducto";
            this.Text = "Registrar Producto";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.Label lblPrecioProducto;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCategorias;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblStockActual;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnAgregar;
    }
}