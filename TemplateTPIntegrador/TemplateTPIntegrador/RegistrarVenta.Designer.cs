namespace TemplateTPIntegrador
{
    partial class RegistrarVenta
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvProductosaComprar = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosaComprar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.label1.Location = new System.Drawing.Point(64, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(69, 86);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(143, 28);
            this.comboBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.label2.Location = new System.Drawing.Point(545, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Carrito";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(550, 86);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(174, 113);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 8F);
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
            this.button2.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(550, 382);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 35);
            this.button2.TabIndex = 5;
            this.button2.Text = "Registrar venta";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.label3.Location = new System.Drawing.Point(545, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.label4.Location = new System.Drawing.Point(589, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 37);
            this.label4.TabIndex = 10;
            this.label4.Text = "$0,00";
            // 
            // dgvProductosaComprar
            // 
            this.dgvProductosaComprar.AllowUserToDeleteRows = false;
            this.dgvProductosaComprar.BackgroundColor = System.Drawing.Color.White;
            this.dgvProductosaComprar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductosaComprar.Location = new System.Drawing.Point(69, 142);
            this.dgvProductosaComprar.Name = "dgvProductosaComprar";
            this.dgvProductosaComprar.RowHeadersWidth = 62;
            this.dgvProductosaComprar.RowTemplate.Height = 28;
            this.dgvProductosaComprar.Size = new System.Drawing.Size(240, 150);
            this.dgvProductosaComprar.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.label5.Location = new System.Drawing.Point(64, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Cantidad";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(185, 313);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown1.TabIndex = 13;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.button3.ForeColor = System.Drawing.Color.DarkCyan;
            this.button3.Location = new System.Drawing.Point(69, 365);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(240, 35);
            this.button3.TabIndex = 14;
            this.button3.Text = "Agregar al carrito";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // RegistrarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvProductosaComprar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "RegistrarVenta";
            this.Text = " Registrar Venta";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosaComprar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvProductosaComprar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button3;
    }
}