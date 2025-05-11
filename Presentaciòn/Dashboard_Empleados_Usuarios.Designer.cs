namespace Presentaciòn
{
    partial class Dashboard_Empleados_Usuarios
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
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.btnSalir_frm_usuarios = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.SuspendLayout();
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Location = new System.Drawing.Point(0, 35);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(1034, 562);
            this.webView21.TabIndex = 0;
            this.webView21.ZoomFactor = 1D;
            // 
            // btnSalir_frm_usuarios
            // 
            this.btnSalir_frm_usuarios.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.btnSalir_frm_usuarios.IconColor = System.Drawing.Color.Black;
            this.btnSalir_frm_usuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalir_frm_usuarios.IconSize = 25;
            this.btnSalir_frm_usuarios.Location = new System.Drawing.Point(904, 1);
            this.btnSalir_frm_usuarios.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir_frm_usuarios.Name = "btnSalir_frm_usuarios";
            this.btnSalir_frm_usuarios.Size = new System.Drawing.Size(129, 31);
            this.btnSalir_frm_usuarios.TabIndex = 61;
            this.btnSalir_frm_usuarios.Text = "Salir";
            this.btnSalir_frm_usuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir_frm_usuarios.UseVisualStyleBackColor = true;
            this.btnSalir_frm_usuarios.Click += new System.EventHandler(this.btnSalir_frm_usuarios_Click);
            // 
            // Dashboard_Empleados_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 598);
            this.Controls.Add(this.btnSalir_frm_usuarios);
            this.Controls.Add(this.webView21);
            this.Name = "Dashboard_Empleados_Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard_Empleados_Usuarios";
            this.Load += new System.EventHandler(this.Dashboard_Empleados_Usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private FontAwesome.Sharp.IconButton btnSalir_frm_usuarios;
    }
}