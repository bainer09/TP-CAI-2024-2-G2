using Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Persistencia;
using Datos;

namespace Presentacion
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.strpVentasMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.strpNuevaVenta = new System.Windows.Forms.ToolStripMenuItem();
            this.strpDevolucionVenta = new System.Windows.Forms.ToolStripMenuItem();
            this.strpClientesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.strpProductosMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.strpProveedoresMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.strpReportesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.strpUsuariosMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.strpAltaUsuariosMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.strpBajaUsuariosMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblStockCritico = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkCyan;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.strpVentasMenu,
            this.strpClientesMenu,
            this.strpProductosMenu,
            this.strpProveedoresMenu,
            this.strpReportesMenu,
            this.strpUsuariosMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip1.Size = new System.Drawing.Size(1119, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // strpVentasMenu
            // 
            this.strpVentasMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.strpNuevaVenta,
            this.strpDevolucionVenta});
            this.strpVentasMenu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strpVentasMenu.ForeColor = System.Drawing.Color.White;
            this.strpVentasMenu.Name = "strpVentasMenu";
            this.strpVentasMenu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.strpVentasMenu.Size = new System.Drawing.Size(115, 32);
            this.strpVentasMenu.Text = "VENTAS";
            // 
            // strpNuevaVenta
            // 
            this.strpNuevaVenta.Name = "strpNuevaVenta";
            this.strpNuevaVenta.Size = new System.Drawing.Size(276, 36);
            this.strpNuevaVenta.Text = "NUEVA VENTA";
            this.strpNuevaVenta.Click += new System.EventHandler(this.strpNuevaVenta_Click);
            // 
            // strpDevolucionVenta
            // 
            this.strpDevolucionVenta.Name = "strpDevolucionVenta";
            this.strpDevolucionVenta.Size = new System.Drawing.Size(276, 36);
            this.strpDevolucionVenta.Text = "DEVOLUCION";
            this.strpDevolucionVenta.Click += new System.EventHandler(this.strpDevolucionVenta_Click);
            // 
            // strpClientesMenu
            // 
            this.strpClientesMenu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strpClientesMenu.ForeColor = System.Drawing.Color.White;
            this.strpClientesMenu.Name = "strpClientesMenu";
            this.strpClientesMenu.Size = new System.Drawing.Size(129, 32);
            this.strpClientesMenu.Text = "CLIENTES";
            this.strpClientesMenu.Click += new System.EventHandler(this.strpClientesMenu_Click);
            // 
            // strpProductosMenu
            // 
            this.strpProductosMenu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strpProductosMenu.ForeColor = System.Drawing.Color.White;
            this.strpProductosMenu.Name = "strpProductosMenu";
            this.strpProductosMenu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.strpProductosMenu.Size = new System.Drawing.Size(168, 32);
            this.strpProductosMenu.Text = "PRODUCTOS";
            this.strpProductosMenu.Click += new System.EventHandler(this.strpProductosMenu_Click);
            // 
            // strpProveedoresMenu
            // 
            this.strpProveedoresMenu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strpProveedoresMenu.ForeColor = System.Drawing.Color.White;
            this.strpProveedoresMenu.Name = "strpProveedoresMenu";
            this.strpProveedoresMenu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.strpProveedoresMenu.Size = new System.Drawing.Size(191, 32);
            this.strpProveedoresMenu.Text = "PROVEEDORES";
            this.strpProveedoresMenu.Click += new System.EventHandler(this.strpProveedoresMenu_Click);
            // 
            // strpReportesMenu
            // 
            this.strpReportesMenu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strpReportesMenu.ForeColor = System.Drawing.Color.White;
            this.strpReportesMenu.Name = "strpReportesMenu";
            this.strpReportesMenu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.strpReportesMenu.Size = new System.Drawing.Size(135, 32);
            this.strpReportesMenu.Text = "REPORTES";
            this.strpReportesMenu.Click += new System.EventHandler(this.strpReportesMenu_Click);
            // 
            // strpUsuariosMenu
            // 
            this.strpUsuariosMenu.BackColor = System.Drawing.Color.Transparent;
            this.strpUsuariosMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.strpAltaUsuariosMenu,
            this.strpBajaUsuariosMenu});
            this.strpUsuariosMenu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strpUsuariosMenu.ForeColor = System.Drawing.Color.White;
            this.strpUsuariosMenu.Name = "strpUsuariosMenu";
            this.strpUsuariosMenu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.strpUsuariosMenu.Size = new System.Drawing.Size(141, 32);
            this.strpUsuariosMenu.Text = "USUARIOS";
            // 
            // strpAltaUsuariosMenu
            // 
            this.strpAltaUsuariosMenu.Name = "strpAltaUsuariosMenu";
            this.strpAltaUsuariosMenu.Size = new System.Drawing.Size(315, 36);
            this.strpAltaUsuariosMenu.Text = "ALTA";
            this.strpAltaUsuariosMenu.Click += new System.EventHandler(this.strpAltaUsuariosMenu_Click);
            // 
            // strpBajaUsuariosMenu
            // 
            this.strpBajaUsuariosMenu.Name = "strpBajaUsuariosMenu";
            this.strpBajaUsuariosMenu.Size = new System.Drawing.Size(315, 36);
            this.strpBajaUsuariosMenu.Text = "BAJA-REACTIVAR";
            this.strpBajaUsuariosMenu.Click += new System.EventHandler(this.strpBajaUsuariosMenu_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(967, -5);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(156, 46);
            this.btnLogOut.TabIndex = 1;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.BackColor = System.Drawing.Color.Transparent;
            this.lblBienvenido.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold);
            this.lblBienvenido.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblBienvenido.Location = new System.Drawing.Point(116, 248);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(1102, 70);
            this.lblBienvenido.TabIndex = 2;
            this.lblBienvenido.Text = "Sistema de Gestión ElectroHogar S.A.";
            this.lblBienvenido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.Image = global::TemplateTPIntegrador.Properties.Resources.LogoElectroHogar2;
            this.pictureBox3.Location = new System.Drawing.Point(979, 190);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(128, 128);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // lblStockCritico
            // 
            this.lblStockCritico.AutoSize = true;
            this.lblStockCritico.BackColor = System.Drawing.Color.Transparent;
            this.lblStockCritico.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockCritico.ForeColor = System.Drawing.Color.Red;
            this.lblStockCritico.Location = new System.Drawing.Point(259, 346);
            this.lblStockCritico.Name = "lblStockCritico";
            this.lblStockCritico.Size = new System.Drawing.Size(0, 30);
            this.lblStockCritico.TabIndex = 5;
            this.lblStockCritico.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(1119, 521);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.lblStockCritico);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lblBienvenido);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem strpUsuariosMenu;
        private ToolStripMenuItem strpProductosMenu;
        private ToolStripMenuItem strpVentasMenu;
        private ToolStripMenuItem strpProveedoresMenu;
        private ToolStripMenuItem strpReportesMenu;
        private ToolStripMenuItem strpAltaUsuariosMenu;
        private ToolStripMenuItem strpBajaUsuariosMenu;
        private ToolStripMenuItem vENTASToolStripMenuItem;
        private ToolStripMenuItem strpClientesMenu;
        private Button btnLogOut;
        private Label lblBienvenido;
        private ToolStripMenuItem strpNuevaVenta;
        private ToolStripMenuItem strpDevolucionVenta;
        private PictureBox pictureBox3;
        private Label lblStockCritico;
    }
}
