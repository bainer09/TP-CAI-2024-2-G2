using System.Drawing;
using System.Windows.Forms;

namespace Presentacion
{
    partial class FrmAltaUsuario
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.btnAltaUsuario = new System.Windows.Forms.Button();
            this.btnVolverInicio = new System.Windows.Forms.Button();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.dateTimeFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.cbPerfiles = new System.Windows.Forms.ComboBox();
            this.lblAltaUsuarios = new System.Windows.Forms.Label();
            this.lblAlertaAltaUsuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Black;
            this.lblNombre.Location = new System.Drawing.Point(59, 55);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(84, 22);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.BackColor = System.Drawing.Color.Transparent;
            this.lblApellido.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.Color.Black;
            this.lblApellido.Location = new System.Drawing.Point(59, 107);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(84, 22);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.BackColor = System.Drawing.Color.Transparent;
            this.lblDireccion.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.ForeColor = System.Drawing.Color.Black;
            this.lblDireccion.Location = new System.Drawing.Point(59, 218);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(96, 22);
            this.lblDireccion.TabIndex = 2;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefono.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.Color.Black;
            this.lblTelefono.Location = new System.Drawing.Point(59, 270);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(87, 22);
            this.lblTelefono.TabIndex = 3;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Location = new System.Drawing.Point(59, 323);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(58, 22);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "eMail";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.Black;
            this.lblUsuario.Location = new System.Drawing.Point(59, 443);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(75, 22);
            this.lblUsuario.TabIndex = 5;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.BackColor = System.Drawing.Color.Transparent;
            this.lblDNI.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.ForeColor = System.Drawing.Color.Black;
            this.lblDNI.Location = new System.Drawing.Point(59, 165);
            this.lblDNI.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(43, 22);
            this.lblDNI.TabIndex = 6;
            this.lblDNI.Text = "DNI";
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.BackColor = System.Drawing.Color.Transparent;
            this.lblPerfil.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerfil.ForeColor = System.Drawing.Color.Black;
            this.lblPerfil.Location = new System.Drawing.Point(59, 506);
            this.lblPerfil.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(51, 22);
            this.lblPerfil.TabIndex = 8;
            this.lblPerfil.Text = "Perfil";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(219, 55);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(253, 31);
            this.txtNombre.TabIndex = 10;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(219, 107);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(253, 31);
            this.txtApellido.TabIndex = 11;
            this.txtApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(219, 217);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(253, 31);
            this.txtDireccion.TabIndex = 13;
            this.txtDireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDNI
            // 
            this.txtDNI.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNI.Location = new System.Drawing.Point(219, 165);
            this.txtDNI.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(253, 31);
            this.txtDNI.TabIndex = 12;
            this.txtDNI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(219, 319);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(253, 31);
            this.txtEmail.TabIndex = 15;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(219, 270);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(253, 31);
            this.txtTelefono.TabIndex = 14;
            this.txtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(223, 441);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(253, 31);
            this.txtUsuario.TabIndex = 16;
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAltaUsuario
            // 
            this.btnAltaUsuario.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAltaUsuario.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltaUsuario.ForeColor = System.Drawing.Color.White;
            this.btnAltaUsuario.Location = new System.Drawing.Point(627, 212);
            this.btnAltaUsuario.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAltaUsuario.Name = "btnAltaUsuario";
            this.btnAltaUsuario.Size = new System.Drawing.Size(319, 86);
            this.btnAltaUsuario.TabIndex = 18;
            this.btnAltaUsuario.Text = "DAR DE ALTA";
            this.btnAltaUsuario.UseVisualStyleBackColor = false;
            // 
            // btnVolverInicio
            // 
            this.btnVolverInicio.BackColor = System.Drawing.SystemColors.Info;
            this.btnVolverInicio.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverInicio.Location = new System.Drawing.Point(721, 561);
            this.btnVolverInicio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVolverInicio.Name = "btnVolverInicio";
            this.btnVolverInicio.Size = new System.Drawing.Size(225, 51);
            this.btnVolverInicio.TabIndex = 20;
            this.btnVolverInicio.Text = "VOLVER MENU PRINCIPAL";
            this.btnVolverInicio.UseVisualStyleBackColor = false;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNacimiento.ForeColor = System.Drawing.Color.Black;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(59, 382);
            this.lblFechaNacimiento.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(117, 22);
            this.lblFechaNacimiento.TabIndex = 21;
            this.lblFechaNacimiento.Text = "Fecha Nac.";
            // 
            // dateTimeFechaNacimiento
            // 
            this.dateTimeFechaNacimiento.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFechaNacimiento.Location = new System.Drawing.Point(223, 376);
            this.dateTimeFechaNacimiento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimeFechaNacimiento.Name = "dateTimeFechaNacimiento";
            this.dateTimeFechaNacimiento.Size = new System.Drawing.Size(250, 31);
            this.dateTimeFechaNacimiento.TabIndex = 23;
            // 
            // cbPerfiles
            // 
            this.cbPerfiles.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPerfiles.FormattingEnabled = true;
            this.cbPerfiles.Location = new System.Drawing.Point(219, 498);
            this.cbPerfiles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbPerfiles.Name = "cbPerfiles";
            this.cbPerfiles.Size = new System.Drawing.Size(255, 30);
            this.cbPerfiles.TabIndex = 24;
            // 
            // lblAltaUsuarios
            // 
            this.lblAltaUsuarios.AutoSize = true;
            this.lblAltaUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.lblAltaUsuarios.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltaUsuarios.ForeColor = System.Drawing.Color.Black;
            this.lblAltaUsuarios.Location = new System.Drawing.Point(615, 22);
            this.lblAltaUsuarios.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAltaUsuarios.Name = "lblAltaUsuarios";
            this.lblAltaUsuarios.Size = new System.Drawing.Size(182, 22);
            this.lblAltaUsuarios.TabIndex = 49;
            this.lblAltaUsuarios.Text = "ALTA DE USUARIOS";
            this.lblAltaUsuarios.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAlertaAltaUsuario
            // 
            this.lblAlertaAltaUsuario.AutoSize = true;
            this.lblAlertaAltaUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblAlertaAltaUsuario.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlertaAltaUsuario.ForeColor = System.Drawing.Color.Green;
            this.lblAlertaAltaUsuario.Location = new System.Drawing.Point(627, 320);
            this.lblAlertaAltaUsuario.Name = "lblAlertaAltaUsuario";
            this.lblAlertaAltaUsuario.Size = new System.Drawing.Size(65, 22);
            this.lblAlertaAltaUsuario.TabIndex = 50;
            this.lblAlertaAltaUsuario.Text = "label1";
            // 
            // FrmAltaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1539, 636);
            this.Controls.Add(this.lblAlertaAltaUsuario);
            this.Controls.Add(this.lblAltaUsuarios);
            this.Controls.Add(this.cbPerfiles);
            this.Controls.Add(this.dateTimeFechaNacimiento);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.btnVolverInicio);
            this.Controls.Add(this.btnAltaUsuario);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblPerfil);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Font = new System.Drawing.Font("Ebrima", 10.2F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FrmAltaUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Usuario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNombre;
        private Label lblApellido;
        private Label lblDireccion;
        private Label lblTelefono;
        private Label lblEmail;
        private Label lblUsuario;
        private Label lblDNI;
        private Label lblPerfil;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDireccion;
        private TextBox txtDNI;
        private TextBox txtEmail;
        private TextBox txtTelefono;
        private TextBox txtUsuario;
        private Button btnAltaUsuario;
        private Button btnVolverInicio;
        private Label lblFechaNacimiento;
        private DateTimePicker dateTimeFechaNacimiento;
        private ComboBox cbPerfiles;
        private Label lblAltaUsuarios;
        private Label lblAlertaAltaUsuario;
    }
}