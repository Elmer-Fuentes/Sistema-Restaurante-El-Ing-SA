namespace Presentaciòn
{
    partial class Menu_Principal
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
            this.lbl_usuario_logo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_rol_usuario = new System.Windows.Forms.Label();
            this.reporteriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.formulariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Usuarios_FormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mesasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirDelSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Clinetes_menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detalleDeOrdenesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventariosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.operacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encabezadoDeÓrdenesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detallesDeÓrdenesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagoDeÓrdenesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirDelSistemaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bienvenido:";
            // 
            // lbl_usuario_logo
            // 
            this.lbl_usuario_logo.AutoSize = true;
            this.lbl_usuario_logo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuario_logo.Location = new System.Drawing.Point(13, 52);
            this.lbl_usuario_logo.Name = "lbl_usuario_logo";
            this.lbl_usuario_logo.Size = new System.Drawing.Size(54, 16);
            this.lbl_usuario_logo.TabIndex = 0;
            this.lbl_usuario_logo.Text = "Usuario";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl_rol_usuario);
            this.panel1.Controls.Add(this.lbl_usuario_logo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(861, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 525);
            this.panel1.TabIndex = 4;
            // 
            // lbl_rol_usuario
            // 
            this.lbl_rol_usuario.AutoSize = true;
            this.lbl_rol_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rol_usuario.Location = new System.Drawing.Point(13, 73);
            this.lbl_rol_usuario.Name = "lbl_rol_usuario";
            this.lbl_rol_usuario.Size = new System.Drawing.Size(96, 16);
            this.lbl_rol_usuario.TabIndex = 1;
            this.lbl_rol_usuario.Text = "lbl_Rol_usuaio";
            // 
            // reporteriaToolStripMenuItem
            // 
            this.reporteriaToolStripMenuItem.Name = "reporteriaToolStripMenuItem";
            this.reporteriaToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.reporteriaToolStripMenuItem.Text = "Salir del Sistema";
            this.reporteriaToolStripMenuItem.Click += new System.EventHandler(this.reporteriaToolStripMenuItem_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formulariosToolStripMenuItem,
            this.salirDelSistemaToolStripMenuItem,
            this.operacionesToolStripMenuItem,
            this.salirDelSistemaToolStripMenuItem1,
            this.reporteriaToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip.Size = new System.Drawing.Size(1034, 24);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "MenuStrip";
            // 
            // formulariosToolStripMenuItem
            // 
            this.formulariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Usuarios_FormToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.mesasToolStripMenuItem});
            this.formulariosToolStripMenuItem.Name = "formulariosToolStripMenuItem";
            this.formulariosToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.formulariosToolStripMenuItem.Text = "Administración";
            // 
            // Usuarios_FormToolStripMenuItem
            // 
            this.Usuarios_FormToolStripMenuItem.Name = "Usuarios_FormToolStripMenuItem";
            this.Usuarios_FormToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.Usuarios_FormToolStripMenuItem.Text = "Usuarios";
            this.Usuarios_FormToolStripMenuItem.Click += new System.EventHandler(this.Usuarios_FormToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.usuariosToolStripMenuItem.Text = "Empleados";
            // 
            // mesasToolStripMenuItem
            // 
            this.mesasToolStripMenuItem.Name = "mesasToolStripMenuItem";
            this.mesasToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.mesasToolStripMenuItem.Text = "Planillas";
            // 
            // salirDelSistemaToolStripMenuItem
            // 
            this.salirDelSistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Clinetes_menuToolStripMenuItem,
            this.detalleDeOrdenesToolStripMenuItem,
            this.inventariosToolStripMenuItem,
            this.inventariosToolStripMenuItem1});
            this.salirDelSistemaToolStripMenuItem.Name = "salirDelSistemaToolStripMenuItem";
            this.salirDelSistemaToolStripMenuItem.Size = new System.Drawing.Size(72, 22);
            this.salirDelSistemaToolStripMenuItem.Text = "Catálogos";
            // 
            // Clinetes_menuToolStripMenuItem
            // 
            this.Clinetes_menuToolStripMenuItem.Name = "Clinetes_menuToolStripMenuItem";
            this.Clinetes_menuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.Clinetes_menuToolStripMenuItem.Text = "Clientes";
            this.Clinetes_menuToolStripMenuItem.Click += new System.EventHandler(this.Clinetes_menuToolStripMenuItem_Click);
            // 
            // detalleDeOrdenesToolStripMenuItem
            // 
            this.detalleDeOrdenesToolStripMenuItem.Name = "detalleDeOrdenesToolStripMenuItem";
            this.detalleDeOrdenesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.detalleDeOrdenesToolStripMenuItem.Text = "Menu";
            // 
            // inventariosToolStripMenuItem
            // 
            this.inventariosToolStripMenuItem.Name = "inventariosToolStripMenuItem";
            this.inventariosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.inventariosToolStripMenuItem.Text = "Inventarios";
            // 
            // inventariosToolStripMenuItem1
            // 
            this.inventariosToolStripMenuItem1.Name = "inventariosToolStripMenuItem1";
            this.inventariosToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.inventariosToolStripMenuItem1.Text = "Mesas";
            // 
            // operacionesToolStripMenuItem
            // 
            this.operacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.encabezadoDeÓrdenesToolStripMenuItem,
            this.detallesDeÓrdenesToolStripMenuItem,
            this.pagoDeÓrdenesToolStripMenuItem});
            this.operacionesToolStripMenuItem.Name = "operacionesToolStripMenuItem";
            this.operacionesToolStripMenuItem.Size = new System.Drawing.Size(85, 22);
            this.operacionesToolStripMenuItem.Text = "Operaciones";
            // 
            // encabezadoDeÓrdenesToolStripMenuItem
            // 
            this.encabezadoDeÓrdenesToolStripMenuItem.Name = "encabezadoDeÓrdenesToolStripMenuItem";
            this.encabezadoDeÓrdenesToolStripMenuItem.Size = new System.Drawing.Size(200, 34);
            this.encabezadoDeÓrdenesToolStripMenuItem.Text = "Encabezado de Órdenes";
            // 
            // detallesDeÓrdenesToolStripMenuItem
            // 
            this.detallesDeÓrdenesToolStripMenuItem.Name = "detallesDeÓrdenesToolStripMenuItem";
            this.detallesDeÓrdenesToolStripMenuItem.Size = new System.Drawing.Size(200, 34);
            this.detallesDeÓrdenesToolStripMenuItem.Text = "Detalles de Órdenes\n";
            // 
            // pagoDeÓrdenesToolStripMenuItem
            // 
            this.pagoDeÓrdenesToolStripMenuItem.Name = "pagoDeÓrdenesToolStripMenuItem";
            this.pagoDeÓrdenesToolStripMenuItem.Size = new System.Drawing.Size(200, 34);
            this.pagoDeÓrdenesToolStripMenuItem.Text = "Pago de Órdenes\n";
            // 
            // salirDelSistemaToolStripMenuItem1
            // 
            this.salirDelSistemaToolStripMenuItem1.Name = "salirDelSistemaToolStripMenuItem1";
            this.salirDelSistemaToolStripMenuItem1.Size = new System.Drawing.Size(65, 22);
            this.salirDelSistemaToolStripMenuItem1.Text = "Reportes";
            // 
            // Menu_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 549);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.Name = "Menu_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu_Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Menu_Principal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_usuario_logo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_rol_usuario;
        private System.Windows.Forms.ToolStripMenuItem reporteriaToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem formulariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Usuarios_FormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mesasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirDelSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Clinetes_menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detalleDeOrdenesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventariosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem operacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encabezadoDeÓrdenesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detallesDeÓrdenesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagoDeÓrdenesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirDelSistemaToolStripMenuItem1;
    }
}