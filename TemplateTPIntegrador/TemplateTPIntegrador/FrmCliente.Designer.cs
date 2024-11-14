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
            this.Registrarusuarioboton = new System.Windows.Forms.Button();
            this.eticliente = new System.Windows.Forms.Label();
            this.etiDireccion = new System.Windows.Forms.Label();
            this.Etitelefono = new System.Windows.Forms.Label();
            this.etiEmail = new System.Windows.Forms.Label();
            this.textnombrecliente = new System.Windows.Forms.TextBox();
            this.texdireccioncliente = new System.Windows.Forms.TextBox();
            this.textelcliente = new System.Windows.Forms.TextBox();
            this.texemailcliente = new System.Windows.Forms.TextBox();
            this.Textapellido = new System.Windows.Forms.TextBox();
            this.etiapellido = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.texDNI = new System.Windows.Forms.TextBox();
            this.Botonmodificarcliente = new System.Windows.Forms.Button();
            this.botondardebajacliente = new System.Windows.Forms.Button();
            this.listaclientes = new System.Windows.Forms.DataGridView();
            this.Clientes = new System.Windows.Forms.Label();
            this.panelcyan = new System.Windows.Forms.Panel();
            this.Volverainicioboton = new System.Windows.Forms.Button();
            this.LogoElectroHogar = new System.Windows.Forms.PictureBox();
            this.electrohogarlbl = new System.Windows.Forms.Label();
            this.fechanaccampo = new System.Windows.Forms.DateTimePicker();
            this.alertacliente = new System.Windows.Forms.Label();
            this.Reactivarboton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listaclientes)).BeginInit();
            this.panelcyan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoElectroHogar)).BeginInit();
            this.SuspendLayout();
            // 
            // Registrarusuarioboton
            // 
            this.Registrarusuarioboton.BackColor = System.Drawing.Color.DarkCyan;
            this.Registrarusuarioboton.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registrarusuarioboton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Registrarusuarioboton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Registrarusuarioboton.Location = new System.Drawing.Point(801, 959);
            this.Registrarusuarioboton.Name = "Registrarusuarioboton";
            this.Registrarusuarioboton.Size = new System.Drawing.Size(267, 116);
            this.Registrarusuarioboton.TabIndex = 9;
            this.Registrarusuarioboton.Text = "Registrar cliente";
            this.Registrarusuarioboton.UseVisualStyleBackColor = false;
            this.Registrarusuarioboton.Click += new System.EventHandler(this.Registrarusuarioboton_Click);
            // 
            // eticliente
            // 
            this.eticliente.AutoSize = true;
            this.eticliente.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eticliente.Location = new System.Drawing.Point(79, 341);
            this.eticliente.Name = "eticliente";
            this.eticliente.Size = new System.Drawing.Size(73, 21);
            this.eticliente.TabIndex = 10;
            this.eticliente.Text = "Nombre";
            // 
            // etiDireccion
            // 
            this.etiDireccion.AutoSize = true;
            this.etiDireccion.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiDireccion.Location = new System.Drawing.Point(79, 636);
            this.etiDireccion.Name = "etiDireccion";
            this.etiDireccion.Size = new System.Drawing.Size(83, 21);
            this.etiDireccion.TabIndex = 11;
            this.etiDireccion.Text = "Direccion";
            // 
            // Etitelefono
            // 
            this.Etitelefono.AutoSize = true;
            this.Etitelefono.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Etitelefono.Location = new System.Drawing.Point(79, 716);
            this.Etitelefono.Name = "Etitelefono";
            this.Etitelefono.Size = new System.Drawing.Size(76, 21);
            this.Etitelefono.TabIndex = 12;
            this.Etitelefono.Text = "Telefono";
            // 
            // etiEmail
            // 
            this.etiEmail.AutoSize = true;
            this.etiEmail.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiEmail.Location = new System.Drawing.Point(79, 791);
            this.etiEmail.Name = "etiEmail";
            this.etiEmail.Size = new System.Drawing.Size(51, 21);
            this.etiEmail.TabIndex = 13;
            this.etiEmail.Text = "Email";
            // 
            // textnombrecliente
            // 
            this.textnombrecliente.Location = new System.Drawing.Point(330, 332);
            this.textnombrecliente.Name = "textnombrecliente";
            this.textnombrecliente.Size = new System.Drawing.Size(358, 27);
            this.textnombrecliente.TabIndex = 16;
            // 
            // texdireccioncliente
            // 
            this.texdireccioncliente.Location = new System.Drawing.Point(330, 636);
            this.texdireccioncliente.Name = "texdireccioncliente";
            this.texdireccioncliente.Size = new System.Drawing.Size(358, 27);
            this.texdireccioncliente.TabIndex = 17;
            // 
            // textelcliente
            // 
            this.textelcliente.Location = new System.Drawing.Point(330, 720);
            this.textelcliente.Name = "textelcliente";
            this.textelcliente.Size = new System.Drawing.Size(358, 27);
            this.textelcliente.TabIndex = 18;
            // 
            // texemailcliente
            // 
            this.texemailcliente.Location = new System.Drawing.Point(330, 791);
            this.texemailcliente.Name = "texemailcliente";
            this.texemailcliente.Size = new System.Drawing.Size(358, 27);
            this.texemailcliente.TabIndex = 19;
            // 
            // Textapellido
            // 
            this.Textapellido.Location = new System.Drawing.Point(330, 405);
            this.Textapellido.Name = "Textapellido";
            this.Textapellido.Size = new System.Drawing.Size(358, 27);
            this.Textapellido.TabIndex = 21;
            // 
            // etiapellido
            // 
            this.etiapellido.AutoSize = true;
            this.etiapellido.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiapellido.Location = new System.Drawing.Point(79, 411);
            this.etiapellido.Name = "etiapellido";
            this.etiapellido.Size = new System.Drawing.Size(74, 21);
            this.etiapellido.TabIndex = 20;
            this.etiapellido.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 489);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 21);
            this.label1.TabIndex = 22;
            this.label1.Text = "Fecha de nacimiento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 561);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 21);
            this.label2.TabIndex = 23;
            this.label2.Text = "DNI";
            // 
            // texDNI
            // 
            this.texDNI.Location = new System.Drawing.Point(330, 561);
            this.texDNI.Name = "texDNI";
            this.texDNI.Size = new System.Drawing.Size(358, 27);
            this.texDNI.TabIndex = 24;
            // 
            // Botonmodificarcliente
            // 
            this.Botonmodificarcliente.BackColor = System.Drawing.Color.DarkCyan;
            this.Botonmodificarcliente.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Botonmodificarcliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Botonmodificarcliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Botonmodificarcliente.Location = new System.Drawing.Point(1176, 959);
            this.Botonmodificarcliente.Name = "Botonmodificarcliente";
            this.Botonmodificarcliente.Size = new System.Drawing.Size(267, 116);
            this.Botonmodificarcliente.TabIndex = 25;
            this.Botonmodificarcliente.Text = "Modificar datos";
            this.Botonmodificarcliente.UseVisualStyleBackColor = false;
            this.Botonmodificarcliente.Click += new System.EventHandler(this.Botonmodificarcliente_Click);
            // 
            // botondardebajacliente
            // 
            this.botondardebajacliente.BackColor = System.Drawing.Color.Red;
            this.botondardebajacliente.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botondardebajacliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.botondardebajacliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botondardebajacliente.Location = new System.Drawing.Point(1511, 959);
            this.botondardebajacliente.Name = "botondardebajacliente";
            this.botondardebajacliente.Size = new System.Drawing.Size(267, 116);
            this.botondardebajacliente.TabIndex = 26;
            this.botondardebajacliente.Text = "Dar de baja";
            this.botondardebajacliente.UseVisualStyleBackColor = false;
            this.botondardebajacliente.Click += new System.EventHandler(this.botondardebajacliente_Click);
            // 
            // listaclientes
            // 
            this.listaclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaclientes.Location = new System.Drawing.Point(757, 311);
            this.listaclientes.Name = "listaclientes";
            this.listaclientes.RowHeadersWidth = 62;
            this.listaclientes.RowTemplate.Height = 28;
            this.listaclientes.Size = new System.Drawing.Size(1120, 583);
            this.listaclientes.TabIndex = 27;
            // 
            // Clientes
            // 
            this.Clientes.AutoSize = true;
            this.Clientes.Font = new System.Drawing.Font("Century Gothic", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clientes.Location = new System.Drawing.Point(647, 230);
            this.Clientes.Name = "Clientes";
            this.Clientes.Size = new System.Drawing.Size(246, 66);
            this.Clientes.TabIndex = 28;
            this.Clientes.Text = "Clientes";
            // 
            // panelcyan
            // 
            this.panelcyan.BackColor = System.Drawing.Color.DarkCyan;
            this.panelcyan.Controls.Add(this.Volverainicioboton);
            this.panelcyan.Controls.Add(this.LogoElectroHogar);
            this.panelcyan.Controls.Add(this.electrohogarlbl);
            this.panelcyan.Location = new System.Drawing.Point(0, 0);
            this.panelcyan.Name = "panelcyan";
            this.panelcyan.Size = new System.Drawing.Size(3259, 218);
            this.panelcyan.TabIndex = 29;
            // 
            // Volverainicioboton
            // 
            this.Volverainicioboton.BackColor = System.Drawing.Color.SlateGray;
            this.Volverainicioboton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Volverainicioboton.ForeColor = System.Drawing.Color.White;
            this.Volverainicioboton.Location = new System.Drawing.Point(1776, 42);
            this.Volverainicioboton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Volverainicioboton.Name = "Volverainicioboton";
            this.Volverainicioboton.Size = new System.Drawing.Size(147, 123);
            this.Volverainicioboton.TabIndex = 32;
            this.Volverainicioboton.Text = "Volver a inicio";
            this.Volverainicioboton.UseVisualStyleBackColor = false;
            this.Volverainicioboton.Click += new System.EventHandler(this.Volverainicioboton_Click);
            // 
            // LogoElectroHogar
            // 
            this.LogoElectroHogar.Image = global::TemplateTPIntegrador.Properties.Resources.LogoElectroHogar;
            this.LogoElectroHogar.Location = new System.Drawing.Point(54, 14);
            this.LogoElectroHogar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LogoElectroHogar.Name = "LogoElectroHogar";
            this.LogoElectroHogar.Size = new System.Drawing.Size(132, 138);
            this.LogoElectroHogar.TabIndex = 13;
            this.LogoElectroHogar.TabStop = false;
            // 
            // electrohogarlbl
            // 
            this.electrohogarlbl.AutoSize = true;
            this.electrohogarlbl.BackColor = System.Drawing.Color.Transparent;
            this.electrohogarlbl.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.electrohogarlbl.ForeColor = System.Drawing.Color.White;
            this.electrohogarlbl.Location = new System.Drawing.Point(234, 113);
            this.electrohogarlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.electrohogarlbl.Name = "electrohogarlbl";
            this.electrohogarlbl.Size = new System.Drawing.Size(286, 39);
            this.electrohogarlbl.TabIndex = 12;
            this.electrohogarlbl.Text = "ElectroHogar S.A.";
            // 
            // fechanaccampo
            // 
            this.fechanaccampo.Location = new System.Drawing.Point(330, 489);
            this.fechanaccampo.Name = "fechanaccampo";
            this.fechanaccampo.Size = new System.Drawing.Size(358, 27);
            this.fechanaccampo.TabIndex = 30;
            // 
            // alertacliente
            // 
            this.alertacliente.AutoSize = true;
            this.alertacliente.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alertacliente.Location = new System.Drawing.Point(1060, 1080);
            this.alertacliente.Name = "alertacliente";
            this.alertacliente.Size = new System.Drawing.Size(59, 21);
            this.alertacliente.TabIndex = 31;
            this.alertacliente.Text = "Alerta";
            this.alertacliente.Visible = false;
            // 
            // Reactivarboton
            // 
            this.Reactivarboton.BackColor = System.Drawing.Color.DarkCyan;
            this.Reactivarboton.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reactivarboton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Reactivarboton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Reactivarboton.Location = new System.Drawing.Point(439, 959);
            this.Reactivarboton.Name = "Reactivarboton";
            this.Reactivarboton.Size = new System.Drawing.Size(267, 116);
            this.Reactivarboton.TabIndex = 32;
            this.Reactivarboton.Text = "Reactivar usuario";
            this.Reactivarboton.UseVisualStyleBackColor = false;
            this.Reactivarboton.Click += new System.EventHandler(this.Reactivarboton_Click);
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1973, 1163);
            this.Controls.Add(this.Reactivarboton);
            this.Controls.Add(this.alertacliente);
            this.Controls.Add(this.fechanaccampo);
            this.Controls.Add(this.panelcyan);
            this.Controls.Add(this.Clientes);
            this.Controls.Add(this.listaclientes);
            this.Controls.Add(this.botondardebajacliente);
            this.Controls.Add(this.Botonmodificarcliente);
            this.Controls.Add(this.texDNI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Textapellido);
            this.Controls.Add(this.etiapellido);
            this.Controls.Add(this.texemailcliente);
            this.Controls.Add(this.textelcliente);
            this.Controls.Add(this.texdireccioncliente);
            this.Controls.Add(this.textnombrecliente);
            this.Controls.Add(this.etiEmail);
            this.Controls.Add(this.Etitelefono);
            this.Controls.Add(this.etiDireccion);
            this.Controls.Add(this.eticliente);
            this.Controls.Add(this.Registrarusuarioboton);
            this.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmCliente";
            this.Text = "Registrar clientes";
            ((System.ComponentModel.ISupportInitialize)(this.listaclientes)).EndInit();
            this.panelcyan.ResumeLayout(false);
            this.panelcyan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoElectroHogar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Registrarusuarioboton;
        private System.Windows.Forms.Label eticliente;
        private System.Windows.Forms.Label etiDireccion;
        private System.Windows.Forms.Label Etitelefono;
        private System.Windows.Forms.Label etiEmail;
        private System.Windows.Forms.TextBox textnombrecliente;
        private System.Windows.Forms.TextBox texdireccioncliente;
        private System.Windows.Forms.TextBox textelcliente;
        private System.Windows.Forms.TextBox texemailcliente;
        private System.Windows.Forms.TextBox Textapellido;
        private System.Windows.Forms.Label etiapellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox texDNI;
        private System.Windows.Forms.Button Botonmodificarcliente;
        private System.Windows.Forms.Button botondardebajacliente;
        private System.Windows.Forms.DataGridView listaclientes;
        private System.Windows.Forms.Label Clientes;
        private System.Windows.Forms.Panel panelcyan;
        private System.Windows.Forms.Label electrohogarlbl;
        private System.Windows.Forms.PictureBox LogoElectroHogar;
        private System.Windows.Forms.DateTimePicker fechanaccampo;
        private System.Windows.Forms.Label alertacliente;
        private System.Windows.Forms.Button Volverainicioboton;
        private System.Windows.Forms.Button Reactivarboton;
    }
}