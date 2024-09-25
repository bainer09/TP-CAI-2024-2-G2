namespace TemplateTPIntegrador
{
    partial class Modulobajausuario
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
            this.Botonreactivarusuario = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Listadeusuarios = new System.Windows.Forms.Label();
            this.Iddeusuariotexto = new System.Windows.Forms.TextBox();
            this.Iddenombretexto = new System.Windows.Forms.TextBox();
            this.IngreseID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Buscarusuarioboton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Botondardebaja
            // 
            this.Botondardebaja.BackColor = System.Drawing.Color.OrangeRed;
            this.Botondardebaja.CausesValidation = false;
            this.Botondardebaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Botondardebaja.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Botondardebaja.Location = new System.Drawing.Point(617, 682);
            this.Botondardebaja.Name = "Botondardebaja";
            this.Botondardebaja.Size = new System.Drawing.Size(116, 75);
            this.Botondardebaja.TabIndex = 0;
            this.Botondardebaja.Text = "Dar de baja";
            this.Botondardebaja.UseVisualStyleBackColor = false;
            this.Botondardebaja.Click += new System.EventHandler(this.button1_Click);
            // 
            // Botonreactivarusuario
            // 
            this.Botonreactivarusuario.BackColor = System.Drawing.Color.LimeGreen;
            this.Botonreactivarusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Botonreactivarusuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Botonreactivarusuario.Location = new System.Drawing.Point(997, 682);
            this.Botonreactivarusuario.Name = "Botonreactivarusuario";
            this.Botonreactivarusuario.Size = new System.Drawing.Size(116, 75);
            this.Botonreactivarusuario.TabIndex = 1;
            this.Botonreactivarusuario.Text = "Reactivar usuario";
            this.Botonreactivarusuario.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(447, 283);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(778, 355);
            this.dataGridView1.TabIndex = 2;
            // 
            // Listadeusuarios
            // 
            this.Listadeusuarios.AutoSize = true;
            this.Listadeusuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Listadeusuarios.Location = new System.Drawing.Point(692, 224);
            this.Listadeusuarios.Name = "Listadeusuarios";
            this.Listadeusuarios.Size = new System.Drawing.Size(246, 32);
            this.Listadeusuarios.TabIndex = 3;
            this.Listadeusuarios.Text = "Lista de usuarios";
            this.Listadeusuarios.Click += new System.EventHandler(this.label1_Click);
            // 
            // Iddeusuariotexto
            // 
            this.Iddeusuariotexto.Location = new System.Drawing.Point(405, 63);
            this.Iddeusuariotexto.Name = "Iddeusuariotexto";
            this.Iddeusuariotexto.Size = new System.Drawing.Size(178, 26);
            this.Iddeusuariotexto.TabIndex = 4;
            // 
            // Iddenombretexto
            // 
            this.Iddenombretexto.Location = new System.Drawing.Point(978, 63);
            this.Iddenombretexto.Name = "Iddenombretexto";
            this.Iddenombretexto.Size = new System.Drawing.Size(292, 26);
            this.Iddenombretexto.TabIndex = 5;
            // 
            // IngreseID
            // 
            this.IngreseID.AutoSize = true;
            this.IngreseID.Location = new System.Drawing.Point(401, 22);
            this.IngreseID.Name = "IngreseID";
            this.IngreseID.Size = new System.Drawing.Size(162, 20);
            this.IngreseID.TabIndex = 6;
            this.IngreseID.Text = "Ingrese ID de usuario";
            this.IngreseID.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1026, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ingrese nombre de usuario";
            // 
            // Buscarusuarioboton
            // 
            this.Buscarusuarioboton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Buscarusuarioboton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscarusuarioboton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Buscarusuarioboton.Location = new System.Drawing.Point(718, 122);
            this.Buscarusuarioboton.Name = "Buscarusuarioboton";
            this.Buscarusuarioboton.Size = new System.Drawing.Size(148, 73);
            this.Buscarusuarioboton.TabIndex = 8;
            this.Buscarusuarioboton.Text = "Buscar Usuario";
            this.Buscarusuarioboton.UseVisualStyleBackColor = false;
            // 
            // Modulobajausuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1651, 769);
            this.Controls.Add(this.Buscarusuarioboton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IngreseID);
            this.Controls.Add(this.Iddenombretexto);
            this.Controls.Add(this.Iddeusuariotexto);
            this.Controls.Add(this.Listadeusuarios);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Botonreactivarusuario);
            this.Controls.Add(this.Botondardebaja);
            this.Name = "Modulobajausuario";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Modulobajausuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Botondardebaja;
        private System.Windows.Forms.Button Botonreactivarusuario;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Listadeusuarios;
        private System.Windows.Forms.TextBox Iddeusuariotexto;
        private System.Windows.Forms.TextBox Iddenombretexto;
        private System.Windows.Forms.Label IngreseID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Buscarusuarioboton;
    }
}