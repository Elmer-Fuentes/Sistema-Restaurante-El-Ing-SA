namespace Presentaciòn.Reportes
{
    partial class frm_Reporte_Usuarios
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dS_Reportes = new Presentaciòn.Reportes.DS_Reportes();
            this.upsusuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ups_usuariosTableAdapter = new Presentaciòn.Reportes.DS_ReportesTableAdapters.Ups_usuariosTableAdapter();
            this.txt_p_usuario = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Reportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upsusuariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dS_Usuarios";
            reportDataSource1.Value = this.upsusuariosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Presentaciòn.Reportes.Report_Usuarios.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1032, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // dS_Reportes
            // 
            this.dS_Reportes.DataSetName = "DS_Reportes";
            this.dS_Reportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // upsusuariosBindingSource
            // 
            this.upsusuariosBindingSource.DataMember = "Ups_usuarios";
            this.upsusuariosBindingSource.DataSource = this.dS_Reportes;
            // 
            // ups_usuariosTableAdapter
            // 
            this.ups_usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // txt_p_usuario
            // 
            this.txt_p_usuario.Location = new System.Drawing.Point(298, 31);
            this.txt_p_usuario.Name = "txt_p_usuario";
            this.txt_p_usuario.Size = new System.Drawing.Size(94, 20);
            this.txt_p_usuario.TabIndex = 1;
            this.txt_p_usuario.Visible = false;
            // 
            // frm_Reporte_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 450);
            this.Controls.Add(this.txt_p_usuario);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_Reporte_Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Reporte_Usuarios";
            this.Load += new System.EventHandler(this.frm_Reporte_Usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS_Reportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upsusuariosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource upsusuariosBindingSource;
        private DS_Reportes dS_Reportes;
        private DS_ReportesTableAdapters.Ups_usuariosTableAdapter ups_usuariosTableAdapter;
        public System.Windows.Forms.TextBox txt_p_usuario;
    }
}