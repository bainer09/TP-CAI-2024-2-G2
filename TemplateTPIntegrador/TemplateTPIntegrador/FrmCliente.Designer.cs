namespace TemplateTPIntegrador
{
    partial class FrmCliente
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
            this.eticliente = new System.Windows.Forms.Label();
            this.etiDireccion = new System.Windows.Forms.Label();
            this.Etitelefono = new System.Windows.Forms.Label();
            this.etiEmail = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtDireccionCliente = new System.Windows.Forms.TextBox();
            this.txtTelCliente = new System.Windows.Forms.TextBox();
            this.txtEmailCliente = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.etiapellido = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.btnModificarCliente = new System.Windows.Forms.Button();
            this.btnDarBajaCliente = new System.Windows.Forms.Button();
            this.listaclientes = new System.Windows.Forms.DataGridView();
            this.Clientes = new System.Windows.Forms.Label();
            this.btnVolverInicio = new System.Windows.Forms.Button();
            this.fechanaccampo = new System.Windows.Forms.DateTimePicker();
            this.btnReactivarCliente = new System.Windows.Forms.Button();
            this.btnAltaCliente = new System.Windows.Forms.Button();
            this.lblAlertaClientes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listaclientes)).BeginInit();
            this.SuspendLayout();
            // 
            // eticliente
            // 
            this.eticliente.AutoSize = true;
            this.eticliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eticliente.ForeColor = System.Drawing.Color.DarkCyan;
            this.eticliente.Location = new System.Drawing.Point(66, 103);
            this.eticliente.Name = "eticliente";
            this.eticliente.Size = new System.Drawing.Size(59, 16);
            this.eticliente.TabIndex = 10;
            this.eticliente.Text = "Nombre";
            // 
            // etiDireccion
            // 
            this.etiDireccion.AutoSize = true;
            this.etiDireccion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiDireccion.ForeColor = System.Drawing.Color.DarkCyan;
            this.etiDireccion.Location = new System.Drawing.Point(66, 279);
            this.etiDireccion.Name = "etiDireccion";
            this.etiDireccion.Size = new System.Drawing.Size(69, 16);
            this.etiDireccion.TabIndex = 11;
            this.etiDireccion.Text = "Direccion";
            // 
            // Etitelefono
            // 
            this.Etitelefono.AutoSize = true;
            this.Etitelefono.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Etitelefono.ForeColor = System.Drawing.Color.DarkCyan;
            this.Etitelefono.Location = new System.Drawing.Point(66, 322);
            this.Etitelefono.Name = "Etitelefono";
            this.Etitelefono.Size = new System.Drawing.Size(61, 16);
            this.Etitelefono.TabIndex = 12;
            this.Etitelefono.Text = "Telefono";
            // 
            // etiEmail
            // 
            this.etiEmail.AutoSize = true;
            this.etiEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiEmail.ForeColor = System.Drawing.Color.DarkCyan;
            this.etiEmail.Location = new System.Drawing.Point(66, 376);
            this.etiEmail.Name = "etiEmail";
            this.etiEmail.Size = new System.Drawing.Size(43, 16);
            this.etiEmail.TabIndex = 13;
            this.etiEmail.Text = "Email";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(260, 90);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(358, 21);
            this.txtNombreCliente.TabIndex = 16;
            // 
            // txtDireccionCliente
            // 
            this.txtDireccionCliente.Location = new System.Drawing.Point(260, 275);
            this.txtDireccionCliente.Name = "txtDireccionCliente";
            this.txtDireccionCliente.Size = new System.Drawing.Size(358, 21);
            this.txtDireccionCliente.TabIndex = 17;
            // 
            // txtTelCliente
            // 
            this.txtTelCliente.Location = new System.Drawing.Point(260, 322);
            this.txtTelCliente.Name = "txtTelCliente";
            this.txtTelCliente.Size = new System.Drawing.Size(358, 21);
            this.txtTelCliente.TabIndex = 18;
            // 
            // txtEmailCliente
            // 
            this.txtEmailCliente.Location = new System.Drawing.Point(260, 372);
            this.txtEmailCliente.Name = "txtEmailCliente";
            this.txtEmailCliente.Size = new System.Drawing.Size(358, 21);
            this.txtEmailCliente.TabIndex = 19;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(260, 138);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(358, 21);
            this.txtApellido.TabIndex = 21;
            // 
            // etiapellido
            // 
            this.etiapellido.AutoSize = true;
            this.etiapellido.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiapellido.ForeColor = System.Drawing.Color.DarkCyan;
            this.etiapellido.Location = new System.Drawing.Point(66, 148);
            this.etiapellido.Name = "etiapellido";
            this.etiapellido.Size = new System.Drawing.Size(63, 16);
            this.etiapellido.TabIndex = 20;
            this.etiapellido.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(66, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Fecha de nacimiento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(66, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "DNI";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(260, 228);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(358, 21);
            this.txtDNI.TabIndex = 24;
            // 
            // btnModificarCliente
            // 
            this.btnModificarCliente.BackColor = System.Drawing.Color.DarkCyan;
            this.btnModificarCliente.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModificarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarCliente.Location = new System.Drawing.Point(937, 434);
            this.btnModificarCliente.Name = "btnModificarCliente";
            this.btnModificarCliente.Size = new System.Drawing.Size(188, 49);
            this.btnModificarCliente.TabIndex = 25;
            this.btnModificarCliente.Text = "Modificar datos";
            this.btnModificarCliente.UseVisualStyleBackColor = false;
            this.btnModificarCliente.Click += new System.EventHandler(this.btnModificarCliente_Click);
            // 
            // btnDarBajaCliente
            // 
            this.btnDarBajaCliente.BackColor = System.Drawing.Color.Red;
            this.btnDarBajaCliente.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDarBajaCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDarBajaCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDarBajaCliente.Location = new System.Drawing.Point(1365, 434);
            this.btnDarBajaCliente.Name = "btnDarBajaCliente";
            this.btnDarBajaCliente.Size = new System.Drawing.Size(188, 49);
            this.btnDarBajaCliente.TabIndex = 26;
            this.btnDarBajaCliente.Text = "Dar de baja";
            this.btnDarBajaCliente.UseVisualStyleBackColor = false;
            this.btnDarBajaCliente.Click += new System.EventHandler(this.btnDarBajaCliente_Click);
            // 
            // listaclientes
            // 
            this.listaclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaclientes.Location = new System.Drawing.Point(714, 90);
            this.listaclientes.Name = "listaclientes";
            this.listaclientes.RowHeadersWidth = 62;
            this.listaclientes.RowTemplate.Height = 28;
            this.listaclientes.Size = new System.Drawing.Size(841, 338);
            this.listaclientes.TabIndex = 27;
            // 
            // Clientes
            // 
            this.Clientes.AutoSize = true;
            this.Clientes.Font = new System.Drawing.Font("Century Gothic", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clientes.ForeColor = System.Drawing.Color.DarkCyan;
            this.Clientes.Location = new System.Drawing.Point(634, 12);
            this.Clientes.Name = "Clientes";
            this.Clientes.Size = new System.Drawing.Size(166, 44);
            this.Clientes.TabIndex = 28;
            this.Clientes.Text = "Clientes";
            // 
            // btnVolverInicio
            // 
            this.btnVolverInicio.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVolverInicio.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverInicio.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnVolverInicio.Location = new System.Drawing.Point(1403, 516);
            this.btnVolverInicio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVolverInicio.Name = "btnVolverInicio";
            this.btnVolverInicio.Size = new System.Drawing.Size(267, 51);
            this.btnVolverInicio.TabIndex = 20;
            this.btnVolverInicio.Text = "MENU PRINCIPAL";
            this.btnVolverInicio.UseVisualStyleBackColor = false;
            this.btnVolverInicio.Click += new System.EventHandler(this.btnVolverInicio_Click);
            // 
            // fechanaccampo
            // 
            this.fechanaccampo.Location = new System.Drawing.Point(260, 184);
            this.fechanaccampo.Name = "fechanaccampo";
            this.fechanaccampo.Size = new System.Drawing.Size(358, 21);
            this.fechanaccampo.TabIndex = 30;
            // 
            // btnReactivarCliente
            // 
            this.btnReactivarCliente.BackColor = System.Drawing.Color.DarkCyan;
            this.btnReactivarCliente.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReactivarCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReactivarCliente.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReactivarCliente.Location = new System.Drawing.Point(1151, 434);
            this.btnReactivarCliente.Name = "btnReactivarCliente";
            this.btnReactivarCliente.Size = new System.Drawing.Size(188, 49);
            this.btnReactivarCliente.TabIndex = 32;
            this.btnReactivarCliente.Text = "Reactivar usuario";
            this.btnReactivarCliente.UseVisualStyleBackColor = false;
            this.btnReactivarCliente.Click += new System.EventHandler(this.btnReactivarCliente_Click);
            // 
            // btnAltaCliente
            // 
            this.btnAltaCliente.BackColor = System.Drawing.Color.DarkCyan;
            this.btnAltaCliente.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltaCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAltaCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAltaCliente.Location = new System.Drawing.Point(712, 434);
            this.btnAltaCliente.Name = "btnAltaCliente";
            this.btnAltaCliente.Size = new System.Drawing.Size(188, 49);
            this.btnAltaCliente.TabIndex = 33;
            this.btnAltaCliente.Text = "Alta Cliente";
            this.btnAltaCliente.UseVisualStyleBackColor = false;
            this.btnAltaCliente.Click += new System.EventHandler(this.btnAltaCliente_Click_1);
            // 
            // lblAlertaClientes
            // 
            this.lblAlertaClientes.AutoSize = true;
            this.lblAlertaClientes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlertaClientes.Location = new System.Drawing.Point(57, 466);
            this.lblAlertaClientes.Name = "lblAlertaClientes";
            this.lblAlertaClientes.Size = new System.Drawing.Size(55, 19);
            this.lblAlertaClientes.TabIndex = 34;
            this.lblAlertaClientes.Text = "Alerta";
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1682, 580);
            this.Controls.Add(this.lblAlertaClientes);
            this.Controls.Add(this.btnAltaCliente);
            this.Controls.Add(this.btnVolverInicio);
            this.Controls.Add(this.btnReactivarCliente);
            this.Controls.Add(this.fechanaccampo);
            this.Controls.Add(this.Clientes);
            this.Controls.Add(this.listaclientes);
            this.Controls.Add(this.btnDarBajaCliente);
            this.Controls.Add(this.btnModificarCliente);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.etiapellido);
            this.Controls.Add(this.txtEmailCliente);
            this.Controls.Add(this.txtTelCliente);
            this.Controls.Add(this.txtDireccionCliente);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.etiEmail);
            this.Controls.Add(this.Etitelefono);
            this.Controls.Add(this.etiDireccion);
            this.Controls.Add(this.eticliente);
            this.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmCliente";
            this.Text = "Registrar clientes";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaclientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label eticliente;
        private System.Windows.Forms.Label etiDireccion;
        private System.Windows.Forms.Label Etitelefono;
        private System.Windows.Forms.Label etiEmail;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtDireccionCliente;
        private System.Windows.Forms.TextBox txtTelCliente;
        private System.Windows.Forms.TextBox txtEmailCliente;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label etiapellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Button btnModificarCliente;
        private System.Windows.Forms.Button btnDarBajaCliente;
        private System.Windows.Forms.DataGridView listaclientes;
        private System.Windows.Forms.Label Clientes;
        private System.Windows.Forms.DateTimePicker fechanaccampo;
        private System.Windows.Forms.Button btnVolverInicio;
        private System.Windows.Forms.Button btnReactivarCliente;
        private System.Windows.Forms.Button btnAltaCliente;
        private System.Windows.Forms.Label lblAlertaClientes;
    }
}