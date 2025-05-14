namespace Presentaciòn.Reportes
{
    partial class frm_Reporte_Empleados_Sin_Usuarios
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
            this.txt_p1 = new System.Windows.Forms.TextBox();
            this.uSPBusEmpleadoSinUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Reportes = new Presentaciòn.Reportes.DS_Reportes();
            this.uSP_BusEmpleadoSin_UsuarioTableAdapter = new Presentaciòn.Reportes.DS_ReportesTableAdapters.USP_BusEmpleadoSin_UsuarioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.uSPBusEmpleadoSinUsuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Reportes)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DS_EmpleadosSinUsuarios";
            reportDataSource1.Value = this.uSPBusEmpleadoSinUsuarioBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Presentaciòn.Reportes.Report_Empleados_sin_Usuarios.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1032, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // txt_p1
            // 
            this.txt_p1.Location = new System.Drawing.Point(70, 37);
            this.txt_p1.Name = "txt_p1";
            this.txt_p1.Size = new System.Drawing.Size(147, 20);
            this.txt_p1.TabIndex = 1;
            this.txt_p1.Visible = false;
            // 
            // uSPBusEmpleadoSinUsuarioBindingSource
            // 
            this.uSPBusEmpleadoSinUsuarioBindingSource.DataMember = "USP_BusEmpleadoSin_Usuario";
            this.uSPBusEmpleadoSinUsuarioBindingSource.DataSource = this.dS_Reportes;
            // 
            // dS_Reportes
            // 
            this.dS_Reportes.DataSetName = "DS_Reportes";
            this.dS_Reportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSP_BusEmpleadoSin_UsuarioTableAdapter
            // 
            this.uSP_BusEmpleadoSin_UsuarioTableAdapter.ClearBeforeFill = true;
            // 
            // frm_Reporte_Empleados_Sin_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 450);
            this.Controls.Add(this.txt_p1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_Reporte_Empleados_Sin_Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Reporte_Empleados_Sin_Usuarios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Reporte_Empleados_Sin_Usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uSPBusEmpleadoSinUsuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Reportes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource uSPBusEmpleadoSinUsuarioBindingSource;
        private DS_Reportes dS_Reportes;
        private DS_ReportesTableAdapters.USP_BusEmpleadoSin_UsuarioTableAdapter uSP_BusEmpleadoSin_UsuarioTableAdapter;
        public System.Windows.Forms.TextBox txt_p1;
    }
}