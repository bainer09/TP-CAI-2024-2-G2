namespace TemplateTPIntegrador
{
    partial class DevolverVenta
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
            System.Windows.Forms.Button btnDevolverProducto;
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvProductoscompradosporCliente = new System.Windows.Forms.DataGridView();
            btnDevolverProducto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductoscompradosporCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.label1.Location = new System.Drawing.Point(303, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione el cliente";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(296, 95);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(242, 28);
            this.comboBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.label2.Location = new System.Drawing.Point(229, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(385, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Seleccione el producto a devolver";
            // 
            // dgvProductoscompradosporCliente
            // 
            this.dgvProductoscompradosporCliente.BackgroundColor = System.Drawing.Color.White;
            this.dgvProductoscompradosporCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductoscompradosporCliente.Location = new System.Drawing.Point(234, 191);
            this.dgvProductoscompradosporCliente.Name = "dgvProductoscompradosporCliente";
            this.dgvProductoscompradosporCliente.RowHeadersWidth = 62;
            this.dgvProductoscompradosporCliente.RowTemplate.Height = 28;
            this.dgvProductoscompradosporCliente.Size = new System.Drawing.Size(380, 150);
            this.dgvProductoscompradosporCliente.TabIndex = 3;
            // 
            // btnDevolverProducto
            // 
            btnDevolverProducto.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            btnDevolverProducto.ForeColor = System.Drawing.Color.DarkCyan;
            btnDevolverProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnDevolverProducto.Location = new System.Drawing.Point(296, 374);
            btnDevolverProducto.Name = "btnDevolverProducto";
            btnDevolverProducto.Size = new System.Drawing.Size(242, 50);
            btnDevolverProducto.TabIndex = 4;
            btnDevolverProducto.Text = "Devolver Producto";
            btnDevolverProducto.UseVisualStyleBackColor = true;
            // 
            // DevolverVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(btnDevolverProducto);
            this.Controls.Add(this.dgvProductoscompradosporCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "DevolverVenta";
            this.Text = "Devolver Producto";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductoscompradosporCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvProductoscompradosporCliente;
    }
}