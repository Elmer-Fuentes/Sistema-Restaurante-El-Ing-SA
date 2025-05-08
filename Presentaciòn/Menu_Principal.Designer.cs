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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_usuario_logo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_rol_usuario = new System.Windows.Forms.Label();
            this.DataAnalitycsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.salirDelSistemaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_hora_so = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_fecha_so = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl_rol_usuario);
            this.panel1.Controls.Add(this.lbl_usuario_logo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(861, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 525);
            this.panel1.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbl_hora_so);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lbl_fecha_so);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(0, 253);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 272);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentaciòn.Properties.Resources.restaurantes;
            this.pictureBox1.Location = new System.Drawing.Point(16, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label4.Location = new System.Drawing.Point(13, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "Sistema Restaurantes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label5.Location = new System.Drawing.Point(13, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 15);
            this.label5.TabIndex = 26;
            this.label5.Text = "Version 1,0";
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
            // DataAnalitycsToolStripMenuItem
            // 
            this.DataAnalitycsToolStripMenuItem.Name = "DataAnalitycsToolStripMenuItem";
            this.DataAnalitycsToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.DataAnalitycsToolStripMenuItem.Text = "Data Analitycs";
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formulariosToolStripMenuItem,
            this.salirDelSistemaToolStripMenuItem,
            this.operacionesToolStripMenuItem,
            this.salirDelSistemaToolStripMenuItem1,
            this.DataAnalitycsToolStripMenuItem,
            this.salirDelSistemaToolStripMenuItem2});
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
            this.Clinetes_menuToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.Clinetes_menuToolStripMenuItem.Text = "Clientes";
            this.Clinetes_menuToolStripMenuItem.Click += new System.EventHandler(this.Clinetes_menuToolStripMenuItem_Click);
            // 
            // detalleDeOrdenesToolStripMenuItem
            // 
            this.detalleDeOrdenesToolStripMenuItem.Name = "detalleDeOrdenesToolStripMenuItem";
            this.detalleDeOrdenesToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.detalleDeOrdenesToolStripMenuItem.Text = "Menu";
            // 
            // inventariosToolStripMenuItem
            // 
            this.inventariosToolStripMenuItem.Name = "inventariosToolStripMenuItem";
            this.inventariosToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.inventariosToolStripMenuItem.Text = "Inventarios";
            // 
            // inventariosToolStripMenuItem1
            // 
            this.inventariosToolStripMenuItem1.Name = "inventariosToolStripMenuItem1";
            this.inventariosToolStripMenuItem1.Size = new System.Drawing.Size(132, 22);
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
            // salirDelSistemaToolStripMenuItem2
            // 
            this.salirDelSistemaToolStripMenuItem2.Name = "salirDelSistemaToolStripMenuItem2";
            this.salirDelSistemaToolStripMenuItem2.Size = new System.Drawing.Size(105, 22);
            this.salirDelSistemaToolStripMenuItem2.Text = "Salir Del Sistema";
            this.salirDelSistemaToolStripMenuItem2.Click += new System.EventHandler(this.salirDelSistemaToolStripMenuItem2_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 41;
            this.label3.Text = "Hora:";
            // 
            // lbl_hora_so
            // 
            this.lbl_hora_so.AutoSize = true;
            this.lbl_hora_so.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hora_so.Location = new System.Drawing.Point(12, 83);
            this.lbl_hora_so.Name = "lbl_hora_so";
            this.lbl_hora_so.Size = new System.Drawing.Size(59, 25);
            this.lbl_hora_so.TabIndex = 38;
            this.lbl_hora_so.Text = "hora";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 15);
            this.label6.TabIndex = 40;
            this.label6.Text = "Fecha:";
            // 
            // lbl_fecha_so
            // 
            this.lbl_fecha_so.AutoSize = true;
            this.lbl_fecha_so.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_so.Location = new System.Drawing.Point(12, 46);
            this.lbl_fecha_so.Name = "lbl_fecha_so";
            this.lbl_fecha_so.Size = new System.Drawing.Size(33, 12);
            this.lbl_fecha_so.TabIndex = 37;
            this.lbl_fecha_so.Text = "fecha";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1, 1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 15);
            this.label7.TabIndex = 39;
            this.label7.Text = "Fecha y Hora del Sistema";
            // 
            // Menu_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem DataAnalitycsToolStripMenuItem;
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem salirDelSistemaToolStripMenuItem2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_hora_so;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_fecha_so;
        private System.Windows.Forms.Label label7;
    }
}