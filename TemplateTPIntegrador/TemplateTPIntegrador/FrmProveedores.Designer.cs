namespace TemplateTPIntegrador
{
    partial class FrmProveedores
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
            this.dataGridProveedores = new System.Windows.Forms.DataGridView();
            this.groupBoxCategorias = new System.Windows.Forms.GroupBox();
            this.checkSmartTV = new System.Windows.Forms.CheckBox();
            this.checkInformatica = new System.Windows.Forms.CheckBox();
            this.checkElectroHogar = new System.Windows.Forms.CheckBox();
            this.checkCelulares = new System.Windows.Forms.CheckBox();
            this.checkAudio = new System.Windows.Forms.CheckBox();
            this.labelAltaProveedor = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtCuit = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAgregarProveedor = new System.Windows.Forms.Button();
            this.btnModificarProveedor = new System.Windows.Forms.Button();
            this.btnEliminarProveedor = new System.Windows.Forms.Button();
            this.btnReactivarProveedor = new System.Windows.Forms.Button();
            this.lblValidaciones = new System.Windows.Forms.Label();
            this.lblValidacionMail = new System.Windows.Forms.Label();
            this.lblValidacionCuit = new System.Windows.Forms.Label();
            this.lblValidacionCategoria = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProveedores)).BeginInit();
            this.groupBoxCategorias.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridProveedores
            // 
            this.dataGridProveedores.AllowUserToAddRows = false;
            this.dataGridProveedores.AllowUserToDeleteRows = false;
            this.dataGridProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProveedores.Location = new System.Drawing.Point(665, 69);
            this.dataGridProveedores.Name = "dataGridProveedores";
            this.dataGridProveedores.ReadOnly = true;
            this.dataGridProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridProveedores.Size = new System.Drawing.Size(672, 369);
            this.dataGridProveedores.TabIndex = 0;
            // 
            // groupBoxCategorias
            // 
            this.groupBoxCategorias.Controls.Add(this.checkSmartTV);
            this.groupBoxCategorias.Controls.Add(this.checkInformatica);
            this.groupBoxCategorias.Controls.Add(this.checkElectroHogar);
            this.groupBoxCategorias.Controls.Add(this.checkCelulares);
            this.groupBoxCategorias.Controls.Add(this.checkAudio);
            this.groupBoxCategorias.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCategorias.ForeColor = System.Drawing.Color.Black;
            this.groupBoxCategorias.Location = new System.Drawing.Point(445, 120);
            this.groupBoxCategorias.Name = "groupBoxCategorias";
            this.groupBoxCategorias.Size = new System.Drawing.Size(202, 143);
            this.groupBoxCategorias.TabIndex = 1;
            this.groupBoxCategorias.TabStop = false;
            this.groupBoxCategorias.Text = "Categorías";
            // 
            // checkSmartTV
            // 
            this.checkSmartTV.AutoSize = true;
            this.checkSmartTV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkSmartTV.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkSmartTV.ForeColor = System.Drawing.Color.DarkCyan;
            this.checkSmartTV.Location = new System.Drawing.Point(6, 112);
            this.checkSmartTV.Name = "checkSmartTV";
            this.checkSmartTV.Size = new System.Drawing.Size(85, 24);
            this.checkSmartTV.TabIndex = 4;
            this.checkSmartTV.Text = "Smart TV";
            this.checkSmartTV.UseVisualStyleBackColor = true;
            // 
            // checkInformatica
            // 
            this.checkInformatica.AutoSize = true;
            this.checkInformatica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkInformatica.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkInformatica.ForeColor = System.Drawing.Color.DarkCyan;
            this.checkInformatica.Location = new System.Drawing.Point(6, 89);
            this.checkInformatica.Name = "checkInformatica";
            this.checkInformatica.Size = new System.Drawing.Size(110, 24);
            this.checkInformatica.TabIndex = 3;
            this.checkInformatica.Text = "Informática";
            this.checkInformatica.UseVisualStyleBackColor = true;
            // 
            // checkElectroHogar
            // 
            this.checkElectroHogar.AutoSize = true;
            this.checkElectroHogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkElectroHogar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkElectroHogar.ForeColor = System.Drawing.Color.DarkCyan;
            this.checkElectroHogar.Location = new System.Drawing.Point(6, 66);
            this.checkElectroHogar.Name = "checkElectroHogar";
            this.checkElectroHogar.Size = new System.Drawing.Size(125, 24);
            this.checkElectroHogar.TabIndex = 2;
            this.checkElectroHogar.Text = "Electro Hogar";
            this.checkElectroHogar.UseVisualStyleBackColor = true;
            // 
            // checkCelulares
            // 
            this.checkCelulares.AutoSize = true;
            this.checkCelulares.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkCelulares.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkCelulares.ForeColor = System.Drawing.Color.DarkCyan;
            this.checkCelulares.Location = new System.Drawing.Point(6, 43);
            this.checkCelulares.Name = "checkCelulares";
            this.checkCelulares.Size = new System.Drawing.Size(93, 24);
            this.checkCelulares.TabIndex = 1;
            this.checkCelulares.Text = "Celulares";
            this.checkCelulares.UseVisualStyleBackColor = true;
            // 
            // checkAudio
            // 
            this.checkAudio.AutoSize = true;
            this.checkAudio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkAudio.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkAudio.ForeColor = System.Drawing.Color.DarkCyan;
            this.checkAudio.Location = new System.Drawing.Point(7, 20);
            this.checkAudio.Name = "checkAudio";
            this.checkAudio.Size = new System.Drawing.Size(68, 24);
            this.checkAudio.TabIndex = 0;
            this.checkAudio.Text = "Audio";
            this.checkAudio.UseVisualStyleBackColor = true;
            // 
            // labelAltaProveedor
            // 
            this.labelAltaProveedor.AutoSize = true;
            this.labelAltaProveedor.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAltaProveedor.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelAltaProveedor.Location = new System.Drawing.Point(19, 46);
            this.labelAltaProveedor.Name = "labelAltaProveedor";
            this.labelAltaProveedor.Size = new System.Drawing.Size(200, 22);
            this.labelAltaProveedor.TabIndex = 2;
            this.labelAltaProveedor.Text = "Datos del proveedor";
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(3, 6);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(297, 19);
            this.txtNombre.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Location = new System.Drawing.Point(112, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 30);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(19, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(19, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(19, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Mail";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txtApellido);
            this.panel2.Location = new System.Drawing.Point(112, 180);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(303, 30);
            this.panel2.TabIndex = 8;
            // 
            // txtApellido
            // 
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellido.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(3, 6);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(297, 19);
            this.txtApellido.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.txtMail);
            this.panel3.Location = new System.Drawing.Point(112, 240);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(303, 30);
            this.panel3.TabIndex = 9;
            // 
            // txtMail
            // 
            this.txtMail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMail.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMail.Location = new System.Drawing.Point(3, 6);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(297, 19);
            this.txtMail.TabIndex = 3;
            this.txtMail.TextChanged += new System.EventHandler(this.txtMail_TextChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.txtCuit);
            this.panel4.Location = new System.Drawing.Point(112, 300);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(303, 30);
            this.panel4.TabIndex = 10;
            // 
            // txtCuit
            // 
            this.txtCuit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCuit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuit.Location = new System.Drawing.Point(3, 6);
            this.txtCuit.Mask = "00-00000000-0";
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(297, 19);
            this.txtCuit.TabIndex = 18;
            this.txtCuit.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkCyan;
            this.label4.Location = new System.Drawing.Point(19, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "CUIT";
            // 
            // btnAgregarProveedor
            // 
            this.btnAgregarProveedor.BackColor = System.Drawing.Color.DarkCyan;
            this.btnAgregarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProveedor.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProveedor.ForeColor = System.Drawing.Color.White;
            this.btnAgregarProveedor.Location = new System.Drawing.Point(185, 381);
            this.btnAgregarProveedor.Name = "btnAgregarProveedor";
            this.btnAgregarProveedor.Size = new System.Drawing.Size(148, 35);
            this.btnAgregarProveedor.TabIndex = 12;
            this.btnAgregarProveedor.Text = "GUARDAR";
            this.btnAgregarProveedor.UseVisualStyleBackColor = false;
            this.btnAgregarProveedor.Click += new System.EventHandler(this.btnAgregarProveedor_Click);
            // 
            // btnModificarProveedor
            // 
            this.btnModificarProveedor.BackColor = System.Drawing.Color.DarkCyan;
            this.btnModificarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarProveedor.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarProveedor.ForeColor = System.Drawing.Color.White;
            this.btnModificarProveedor.Location = new System.Drawing.Point(693, 466);
            this.btnModificarProveedor.Name = "btnModificarProveedor";
            this.btnModificarProveedor.Size = new System.Drawing.Size(148, 35);
            this.btnModificarProveedor.TabIndex = 13;
            this.btnModificarProveedor.Text = "MODIFICAR";
            this.btnModificarProveedor.UseVisualStyleBackColor = false;
            this.btnModificarProveedor.Click += new System.EventHandler(this.btnModificarProveedor_Click);
            // 
            // btnEliminarProveedor
            // 
            this.btnEliminarProveedor.BackColor = System.Drawing.Color.DarkCyan;
            this.btnEliminarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarProveedor.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProveedor.ForeColor = System.Drawing.Color.White;
            this.btnEliminarProveedor.Location = new System.Drawing.Point(941, 466);
            this.btnEliminarProveedor.Name = "btnEliminarProveedor";
            this.btnEliminarProveedor.Size = new System.Drawing.Size(148, 35);
            this.btnEliminarProveedor.TabIndex = 14;
            this.btnEliminarProveedor.Text = "ELIMINAR";
            this.btnEliminarProveedor.UseVisualStyleBackColor = false;
            this.btnEliminarProveedor.Click += new System.EventHandler(this.btnEliminarProveedor_Click);
            // 
            // btnReactivarProveedor
            // 
            this.btnReactivarProveedor.BackColor = System.Drawing.Color.DarkCyan;
            this.btnReactivarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReactivarProveedor.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReactivarProveedor.ForeColor = System.Drawing.Color.White;
            this.btnReactivarProveedor.Location = new System.Drawing.Point(1189, 466);
            this.btnReactivarProveedor.Name = "btnReactivarProveedor";
            this.btnReactivarProveedor.Size = new System.Drawing.Size(148, 35);
            this.btnReactivarProveedor.TabIndex = 15;
            this.btnReactivarProveedor.Text = "REACTIVAR";
            this.btnReactivarProveedor.UseVisualStyleBackColor = false;
            this.btnReactivarProveedor.Click += new System.EventHandler(this.btnReactivarProveedor_Click);
            // 
            // lblValidaciones
            // 
            this.lblValidaciones.AutoSize = true;
            this.lblValidaciones.ForeColor = System.Drawing.Color.Red;
            this.lblValidaciones.Location = new System.Drawing.Point(115, 356);
            this.lblValidaciones.Name = "lblValidaciones";
            this.lblValidaciones.Size = new System.Drawing.Size(181, 13);
            this.lblValidaciones.TabIndex = 16;
            this.lblValidaciones.Text = "Por favor complete todos los campos";
            this.lblValidaciones.Visible = false;
            // 
            // lblValidacionMail
            // 
            this.lblValidacionMail.AutoSize = true;
            this.lblValidacionMail.ForeColor = System.Drawing.Color.Red;
            this.lblValidacionMail.Location = new System.Drawing.Point(115, 273);
            this.lblValidacionMail.Name = "lblValidacionMail";
            this.lblValidacionMail.Size = new System.Drawing.Size(145, 13);
            this.lblValidacionMail.TabIndex = 17;
            this.lblValidacionMail.Text = "El formato del mail es invalido";
            this.lblValidacionMail.Visible = false;
            // 
            // lblValidacionCuit
            // 
            this.lblValidacionCuit.AutoSize = true;
            this.lblValidacionCuit.ForeColor = System.Drawing.Color.Red;
            this.lblValidacionCuit.Location = new System.Drawing.Point(115, 333);
            this.lblValidacionCuit.Name = "lblValidacionCuit";
            this.lblValidacionCuit.Size = new System.Drawing.Size(148, 13);
            this.lblValidacionCuit.TabIndex = 18;
            this.lblValidacionCuit.Text = "El CUIT debe tener 11 dígitos";
            this.lblValidacionCuit.Visible = false;
            // 
            // lblValidacionCategoria
            // 
            this.lblValidacionCategoria.AutoSize = true;
            this.lblValidacionCategoria.ForeColor = System.Drawing.Color.Red;
            this.lblValidacionCategoria.Location = new System.Drawing.Point(442, 270);
            this.lblValidacionCategoria.Name = "lblValidacionCategoria";
            this.lblValidacionCategoria.Size = new System.Drawing.Size(205, 13);
            this.lblValidacionCategoria.TabIndex = 19;
            this.lblValidacionCategoria.Text = "Debe seleccionar al menos una categoría";
            this.lblValidacionCategoria.Visible = false;
            // 
            // FrmProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.lblValidacionCategoria);
            this.Controls.Add(this.lblValidacionCuit);
            this.Controls.Add(this.lblValidacionMail);
            this.Controls.Add(this.lblValidaciones);
            this.Controls.Add(this.btnReactivarProveedor);
            this.Controls.Add(this.btnEliminarProveedor);
            this.Controls.Add(this.btnModificarProveedor);
            this.Controls.Add(this.btnAgregarProveedor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelAltaProveedor);
            this.Controls.Add(this.groupBoxCategorias);
            this.Controls.Add(this.dataGridProveedores);
            this.Name = "FrmProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proveedores";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProveedores)).EndInit();
            this.groupBoxCategorias.ResumeLayout(false);
            this.groupBoxCategorias.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridProveedores;
        private System.Windows.Forms.GroupBox groupBoxCategorias;
        private System.Windows.Forms.CheckBox checkSmartTV;
        private System.Windows.Forms.CheckBox checkInformatica;
        private System.Windows.Forms.CheckBox checkElectroHogar;
        private System.Windows.Forms.CheckBox checkCelulares;
        private System.Windows.Forms.CheckBox checkAudio;
        private System.Windows.Forms.Label labelAltaProveedor;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAgregarProveedor;
        private System.Windows.Forms.Button btnModificarProveedor;
        private System.Windows.Forms.Button btnEliminarProveedor;
        private System.Windows.Forms.Button btnReactivarProveedor;
        private System.Windows.Forms.Label lblValidaciones;
        private System.Windows.Forms.Label lblValidacionMail;
        private System.Windows.Forms.MaskedTextBox txtCuit;
        private System.Windows.Forms.Label lblValidacionCuit;
        private System.Windows.Forms.Label lblValidacionCategoria;
    }
}