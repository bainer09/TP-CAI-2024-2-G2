﻿using System.Drawing;
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
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.dateTimeFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.cbPerfiles = new System.Windows.Forms.ComboBox();
            this.lblAltaUsuarios = new System.Windows.Forms.Label();
            this.lblAlertaAltaUsuario = new System.Windows.Forms.Label();
            this.lblAlertaNombre = new System.Windows.Forms.Label();
            this.lblAlertaApellido = new System.Windows.Forms.Label();
            this.lblAlertaDni = new System.Windows.Forms.Label();
            this.lblAlertaDireccion = new System.Windows.Forms.Label();
            this.lblAlertaTelefono = new System.Windows.Forms.Label();
            this.lblAlertaEmail = new System.Windows.Forms.Label();
            this.lblAlertaFecha = new System.Windows.Forms.Label();
            this.lblAlertaUsuario = new System.Windows.Forms.Label();
            this.lblAlertaPerfil = new System.Windows.Forms.Label();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.btnVolverInicio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblNombre.Location = new System.Drawing.Point(63, 91);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(102, 23);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre/s";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.BackColor = System.Drawing.Color.Transparent;
            this.lblApellido.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblApellido.Location = new System.Drawing.Point(580, 89);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(106, 23);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido/s";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.BackColor = System.Drawing.Color.Transparent;
            this.lblDireccion.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblDireccion.Location = new System.Drawing.Point(63, 165);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(98, 23);
            this.lblDireccion.TabIndex = 2;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefono.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblTelefono.Location = new System.Drawing.Point(580, 165);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(87, 23);
            this.lblTelefono.TabIndex = 3;
            this.lblTelefono.Text = "Teléfono";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblEmail.Location = new System.Drawing.Point(1069, 164);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(61, 23);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblUsuario.Location = new System.Drawing.Point(580, 237);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(78, 23);
            this.lblUsuario.TabIndex = 5;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.BackColor = System.Drawing.Color.Transparent;
            this.lblDNI.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblDNI.Location = new System.Drawing.Point(1069, 91);
            this.lblDNI.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(42, 23);
            this.lblDNI.TabIndex = 6;
            this.lblDNI.Text = "DNI";
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.BackColor = System.Drawing.Color.Transparent;
            this.lblPerfil.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerfil.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblPerfil.Location = new System.Drawing.Point(1069, 237);
            this.lblPerfil.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(54, 23);
            this.lblPerfil.TabIndex = 8;
            this.lblPerfil.Text = "Perfil";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(223, 91);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(253, 31);
            this.txtNombre.TabIndex = 10;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(740, 89);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(253, 31);
            this.txtApellido.TabIndex = 11;
            this.txtApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(223, 164);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(253, 31);
            this.txtDireccion.TabIndex = 13;
            this.txtDireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDNI
            // 
            this.txtDNI.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNI.Location = new System.Drawing.Point(1171, 91);
            this.txtDNI.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(253, 31);
            this.txtDNI.TabIndex = 12;
            this.txtDNI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(1171, 165);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(253, 31);
            this.txtEmail.TabIndex = 15;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(740, 167);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(253, 31);
            this.txtTelefono.TabIndex = 14;
            this.txtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(740, 236);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(253, 31);
            this.txtUsuario.TabIndex = 16;
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAltaUsuario
            // 
            this.btnAltaUsuario.BackColor = System.Drawing.Color.DarkCyan;
            this.btnAltaUsuario.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltaUsuario.ForeColor = System.Drawing.Color.White;
            this.btnAltaUsuario.Location = new System.Drawing.Point(662, 359);
            this.btnAltaUsuario.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAltaUsuario.Name = "btnAltaUsuario";
            this.btnAltaUsuario.Size = new System.Drawing.Size(319, 86);
            this.btnAltaUsuario.TabIndex = 18;
            this.btnAltaUsuario.Text = "DAR ALTA";
            this.btnAltaUsuario.UseVisualStyleBackColor = false;
            this.btnAltaUsuario.Click += new System.EventHandler(this.btnAltaUsuario_Click);
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNacimiento.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(59, 238);
            this.lblFechaNacimiento.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(116, 23);
            this.lblFechaNacimiento.TabIndex = 21;
            this.lblFechaNacimiento.Text = "Fecha Nac.";
            // 
            // dateTimeFechaNacimiento
            // 
            this.dateTimeFechaNacimiento.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFechaNacimiento.Location = new System.Drawing.Point(223, 232);
            this.dateTimeFechaNacimiento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimeFechaNacimiento.Name = "dateTimeFechaNacimiento";
            this.dateTimeFechaNacimiento.Size = new System.Drawing.Size(253, 31);
            this.dateTimeFechaNacimiento.TabIndex = 23;
            // 
            // cbPerfiles
            // 
            this.cbPerfiles.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPerfiles.FormattingEnabled = true;
            this.cbPerfiles.Location = new System.Drawing.Point(1171, 231);
            this.cbPerfiles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbPerfiles.Name = "cbPerfiles";
            this.cbPerfiles.Size = new System.Drawing.Size(255, 30);
            this.cbPerfiles.TabIndex = 24;
            // 
            // lblAltaUsuarios
            // 
            this.lblAltaUsuarios.AutoSize = true;
            this.lblAltaUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.lblAltaUsuarios.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltaUsuarios.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblAltaUsuarios.Location = new System.Drawing.Point(701, 24);
            this.lblAltaUsuarios.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAltaUsuarios.Name = "lblAltaUsuarios";
            this.lblAltaUsuarios.Size = new System.Drawing.Size(257, 32);
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
            this.lblAlertaAltaUsuario.Location = new System.Drawing.Point(736, 449);
            this.lblAlertaAltaUsuario.Name = "lblAlertaAltaUsuario";
            this.lblAlertaAltaUsuario.Size = new System.Drawing.Size(188, 22);
            this.lblAlertaAltaUsuario.TabIndex = 50;
            this.lblAlertaAltaUsuario.Text = "lblAlertaAltaUsuario";
            // 
            // lblAlertaNombre
            // 
            this.lblAlertaNombre.AutoSize = true;
            this.lblAlertaNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblAlertaNombre.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlertaNombre.ForeColor = System.Drawing.Color.Red;
            this.lblAlertaNombre.Location = new System.Drawing.Point(219, 126);
            this.lblAlertaNombre.Name = "lblAlertaNombre";
            this.lblAlertaNombre.Size = new System.Drawing.Size(159, 22);
            this.lblAlertaNombre.TabIndex = 51;
            this.lblAlertaNombre.Text = "lblAlertaNombre";
            // 
            // lblAlertaApellido
            // 
            this.lblAlertaApellido.AutoSize = true;
            this.lblAlertaApellido.BackColor = System.Drawing.Color.Transparent;
            this.lblAlertaApellido.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlertaApellido.ForeColor = System.Drawing.Color.Red;
            this.lblAlertaApellido.Location = new System.Drawing.Point(736, 126);
            this.lblAlertaApellido.Name = "lblAlertaApellido";
            this.lblAlertaApellido.Size = new System.Drawing.Size(159, 22);
            this.lblAlertaApellido.TabIndex = 52;
            this.lblAlertaApellido.Text = "lblAlertaApellido";
            // 
            // lblAlertaDni
            // 
            this.lblAlertaDni.AutoSize = true;
            this.lblAlertaDni.BackColor = System.Drawing.Color.Transparent;
            this.lblAlertaDni.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlertaDni.ForeColor = System.Drawing.Color.Red;
            this.lblAlertaDni.Location = new System.Drawing.Point(1167, 126);
            this.lblAlertaDni.Name = "lblAlertaDni";
            this.lblAlertaDni.Size = new System.Drawing.Size(114, 22);
            this.lblAlertaDni.TabIndex = 53;
            this.lblAlertaDni.Text = "lblAlertaDni";
            // 
            // lblAlertaDireccion
            // 
            this.lblAlertaDireccion.AutoSize = true;
            this.lblAlertaDireccion.BackColor = System.Drawing.Color.Transparent;
            this.lblAlertaDireccion.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlertaDireccion.ForeColor = System.Drawing.Color.Red;
            this.lblAlertaDireccion.Location = new System.Drawing.Point(219, 199);
            this.lblAlertaDireccion.Name = "lblAlertaDireccion";
            this.lblAlertaDireccion.Size = new System.Drawing.Size(171, 22);
            this.lblAlertaDireccion.TabIndex = 54;
            this.lblAlertaDireccion.Text = "lblAlertaDireccion";
            // 
            // lblAlertaTelefono
            // 
            this.lblAlertaTelefono.AutoSize = true;
            this.lblAlertaTelefono.BackColor = System.Drawing.Color.Transparent;
            this.lblAlertaTelefono.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlertaTelefono.ForeColor = System.Drawing.Color.Red;
            this.lblAlertaTelefono.Location = new System.Drawing.Point(736, 199);
            this.lblAlertaTelefono.Name = "lblAlertaTelefono";
            this.lblAlertaTelefono.Size = new System.Drawing.Size(162, 22);
            this.lblAlertaTelefono.TabIndex = 55;
            this.lblAlertaTelefono.Text = "lblAlertaTelefono";
            // 
            // lblAlertaEmail
            // 
            this.lblAlertaEmail.AutoSize = true;
            this.lblAlertaEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblAlertaEmail.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlertaEmail.ForeColor = System.Drawing.Color.Red;
            this.lblAlertaEmail.Location = new System.Drawing.Point(1167, 199);
            this.lblAlertaEmail.Name = "lblAlertaEmail";
            this.lblAlertaEmail.Size = new System.Drawing.Size(131, 22);
            this.lblAlertaEmail.TabIndex = 56;
            this.lblAlertaEmail.Text = "lblAlertaEmail";
            // 
            // lblAlertaFecha
            // 
            this.lblAlertaFecha.AutoSize = true;
            this.lblAlertaFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblAlertaFecha.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlertaFecha.ForeColor = System.Drawing.Color.Red;
            this.lblAlertaFecha.Location = new System.Drawing.Point(219, 267);
            this.lblAlertaFecha.Name = "lblAlertaFecha";
            this.lblAlertaFecha.Size = new System.Drawing.Size(143, 22);
            this.lblAlertaFecha.TabIndex = 57;
            this.lblAlertaFecha.Text = "lblAlertaFecha";
            // 
            // lblAlertaUsuario
            // 
            this.lblAlertaUsuario.AutoSize = true;
            this.lblAlertaUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblAlertaUsuario.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlertaUsuario.ForeColor = System.Drawing.Color.Red;
            this.lblAlertaUsuario.Location = new System.Drawing.Point(736, 267);
            this.lblAlertaUsuario.Name = "lblAlertaUsuario";
            this.lblAlertaUsuario.Size = new System.Drawing.Size(150, 22);
            this.lblAlertaUsuario.TabIndex = 58;
            this.lblAlertaUsuario.Text = "lblAlertaUsuario";
            // 
            // lblAlertaPerfil
            // 
            this.lblAlertaPerfil.AutoSize = true;
            this.lblAlertaPerfil.BackColor = System.Drawing.Color.Transparent;
            this.lblAlertaPerfil.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlertaPerfil.ForeColor = System.Drawing.Color.Red;
            this.lblAlertaPerfil.Location = new System.Drawing.Point(1167, 265);
            this.lblAlertaPerfil.Name = "lblAlertaPerfil";
            this.lblAlertaPerfil.Size = new System.Drawing.Size(126, 22);
            this.lblAlertaPerfil.TabIndex = 59;
            this.lblAlertaPerfil.Text = "lblAlertaPerfil";
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.BackColor = System.Drawing.Color.White;
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCampos.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiarCampos.Location = new System.Drawing.Point(707, 475);
            this.btnLimpiarCampos.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(233, 30);
            this.btnLimpiarCampos.TabIndex = 60;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = false;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // btnVolverInicio
            // 
            this.btnVolverInicio.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVolverInicio.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverInicio.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnVolverInicio.Location = new System.Drawing.Point(1260, 500);
            this.btnVolverInicio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVolverInicio.Name = "btnVolverInicio";
            this.btnVolverInicio.Size = new System.Drawing.Size(267, 51);
            this.btnVolverInicio.TabIndex = 20;
            this.btnVolverInicio.Text = "MENU PRINCIPAL";
            this.btnVolverInicio.UseVisualStyleBackColor = false;
            this.btnVolverInicio.Click += new System.EventHandler(this.btnVolverInicio_Click);
            // 
            // FrmAltaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1535, 564);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.lblAlertaPerfil);
            this.Controls.Add(this.lblAlertaUsuario);
            this.Controls.Add(this.lblAlertaFecha);
            this.Controls.Add(this.lblAlertaEmail);
            this.Controls.Add(this.lblAlertaTelefono);
            this.Controls.Add(this.lblAlertaDireccion);
            this.Controls.Add(this.lblAlertaDni);
            this.Controls.Add(this.lblAlertaApellido);
            this.Controls.Add(this.lblAlertaNombre);
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
        private Label lblFechaNacimiento;
        private DateTimePicker dateTimeFechaNacimiento;
        private ComboBox cbPerfiles;
        private Label lblAltaUsuarios;
        private Label lblAlertaAltaUsuario;
        private Label lblAlertaNombre;
        private Label lblAlertaApellido;
        private Label lblAlertaDni;
        private Label lblAlertaDireccion;
        private Label lblAlertaTelefono;
        private Label lblAlertaEmail;
        private Label lblAlertaFecha;
        private Label lblAlertaUsuario;
        private Label lblAlertaPerfil;
        private Button btnLimpiarCampos;
        private Button btnVolverInicio;
    }
}