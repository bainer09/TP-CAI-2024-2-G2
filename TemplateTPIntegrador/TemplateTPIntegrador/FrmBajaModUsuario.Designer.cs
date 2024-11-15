namespace TemplateTPIntegrador
{
    partial class FrmBajaModUsuario
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
            this.Botondardebaja = new System.Windows.Forms.Button();
            this.listausuarios = new System.Windows.Forms.DataGridView();
            this.Listadeusuarios = new System.Windows.Forms.Label();
            this.Iddeusuariotexto = new System.Windows.Forms.TextBox();
            this.IngreseID = new System.Windows.Forms.Label();
            this.Buscarusuarioboton = new System.Windows.Forms.Button();
            this.Alertabotones = new System.Windows.Forms.Label();
            this.btnVolverInicio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listausuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // Botondardebaja
            // 
            this.Botondardebaja.BackColor = System.Drawing.Color.DarkRed;
            this.Botondardebaja.CausesValidation = false;
            this.Botondardebaja.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Botondardebaja.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Botondardebaja.Location = new System.Drawing.Point(505, 599);
            this.Botondardebaja.Margin = new System.Windows.Forms.Padding(2);
            this.Botondardebaja.Name = "Botondardebaja";
            this.Botondardebaja.Size = new System.Drawing.Size(122, 62);
            this.Botondardebaja.TabIndex = 0;
            this.Botondardebaja.Text = "Dar de baja";
            this.Botondardebaja.UseVisualStyleBackColor = false;
            this.Botondardebaja.Click += new System.EventHandler(this.Botondardebaja_Click);
            // 
            // listausuarios
            // 
            this.listausuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listausuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listausuarios.Location = new System.Drawing.Point(178, 156);
            this.listausuarios.Margin = new System.Windows.Forms.Padding(2);
            this.listausuarios.Name = "listausuarios";
            this.listausuarios.RowHeadersWidth = 62;
            this.listausuarios.RowTemplate.Height = 28;
            this.listausuarios.Size = new System.Drawing.Size(769, 439);
            this.listausuarios.TabIndex = 2;
            this.listausuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listausuarios_CellContentClick);
            // 
            // Listadeusuarios
            // 
            this.Listadeusuarios.AutoSize = true;
            this.Listadeusuarios.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Listadeusuarios.ForeColor = System.Drawing.Color.DarkCyan;
            this.Listadeusuarios.Location = new System.Drawing.Point(445, 122);
            this.Listadeusuarios.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Listadeusuarios.Name = "Listadeusuarios";
            this.Listadeusuarios.Size = new System.Drawing.Size(227, 32);
            this.Listadeusuarios.TabIndex = 3;
            this.Listadeusuarios.Text = "Lista de usuarios";
            // 
            // Iddeusuariotexto
            // 
            this.Iddeusuariotexto.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Iddeusuariotexto.Location = new System.Drawing.Point(420, 47);
            this.Iddeusuariotexto.Margin = new System.Windows.Forms.Padding(2);
            this.Iddeusuariotexto.Name = "Iddeusuariotexto";
            this.Iddeusuariotexto.Size = new System.Drawing.Size(293, 24);
            this.Iddeusuariotexto.TabIndex = 4;
            // 
            // IngreseID
            // 
            this.IngreseID.AutoSize = true;
            this.IngreseID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngreseID.ForeColor = System.Drawing.Color.DarkCyan;
            this.IngreseID.Location = new System.Drawing.Point(490, 18);
            this.IngreseID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IngreseID.Name = "IngreseID";
            this.IngreseID.Size = new System.Drawing.Size(145, 16);
            this.IngreseID.TabIndex = 6;
            this.IngreseID.Text = "Ingrese ID de usuario";
            // 
            // Buscarusuarioboton
            // 
            this.Buscarusuarioboton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Buscarusuarioboton.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscarusuarioboton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Buscarusuarioboton.Location = new System.Drawing.Point(505, 73);
            this.Buscarusuarioboton.Margin = new System.Windows.Forms.Padding(2);
            this.Buscarusuarioboton.Name = "Buscarusuarioboton";
            this.Buscarusuarioboton.Size = new System.Drawing.Size(122, 47);
            this.Buscarusuarioboton.TabIndex = 8;
            this.Buscarusuarioboton.Text = "Buscar Usuario";
            this.Buscarusuarioboton.UseVisualStyleBackColor = false;
            this.Buscarusuarioboton.Click += new System.EventHandler(this.Buscarusuarioboton_Click);
            // 
            // Alertabotones
            // 
            this.Alertabotones.AutoSize = true;
            this.Alertabotones.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Alertabotones.Location = new System.Drawing.Point(504, 663);
            this.Alertabotones.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Alertabotones.Name = "Alertabotones";
            this.Alertabotones.Size = new System.Drawing.Size(46, 17);
            this.Alertabotones.TabIndex = 12;
            this.Alertabotones.Text = "Alerta";
            this.Alertabotones.Visible = false;
            // 
            // btnVolverInicio
            // 
            this.btnVolverInicio.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVolverInicio.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverInicio.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnVolverInicio.Location = new System.Drawing.Point(941, 636);
            this.btnVolverInicio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVolverInicio.Name = "btnVolverInicio";
            this.btnVolverInicio.Size = new System.Drawing.Size(267, 51);
            this.btnVolverInicio.TabIndex = 21;
            this.btnVolverInicio.Text = "MENU PRINCIPAL";
            this.btnVolverInicio.UseVisualStyleBackColor = false;
            this.btnVolverInicio.Click += new System.EventHandler(this.btnVolverInicio_Click);
            // 
            // FrmBajaModUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 690);
            this.Controls.Add(this.btnVolverInicio);
            this.Controls.Add(this.Alertabotones);
            this.Controls.Add(this.Buscarusuarioboton);
            this.Controls.Add(this.IngreseID);
            this.Controls.Add(this.Iddeusuariotexto);
            this.Controls.Add(this.Listadeusuarios);
            this.Controls.Add(this.listausuarios);
            this.Controls.Add(this.Botondardebaja);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmBajaModUsuario";
            this.Text = "Baja de usuarios";
            this.Load += new System.EventHandler(this.Modulobajausuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listausuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Botondardebaja;
        private System.Windows.Forms.DataGridView listausuarios;
        private System.Windows.Forms.Label Listadeusuarios;
        private System.Windows.Forms.TextBox Iddeusuariotexto;
        private System.Windows.Forms.Label IngreseID;
        private System.Windows.Forms.Button Buscarusuarioboton;
        private System.Windows.Forms.Label Alertabotones;
        private System.Windows.Forms.Button btnVolverInicio;
    }
}