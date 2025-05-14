namespace Presentaciòn.Reportes
{
    partial class frm_Reporte_Empleado
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
            this.uspselempleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usp_sel_empleadosTableAdapter = new Presentaciòn.Reportes.DS_ReportesTableAdapters.Usp_sel_empleadosTableAdapter();
            this.txt_p_Empleados = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Reportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspselempleadosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dS_Empleados";
            reportDataSource1.Value = this.uspselempleadosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Presentaciòn.Reportes.Report_Empleados.rdlc";
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
            // uspselempleadosBindingSource
            // 
            this.uspselempleadosBindingSource.DataMember = "Usp_sel_empleados";
            this.uspselempleadosBindingSource.DataSource = this.dS_Reportes;
            // 
            // usp_sel_empleadosTableAdapter
            // 
            this.usp_sel_empleadosTableAdapter.ClearBeforeFill = true;
            // 
            // txt_p_Empleados
            // 
            this.txt_p_Empleados.Location = new System.Drawing.Point(290, 133);
            this.txt_p_Empleados.Name = "txt_p_Empleados";
            this.txt_p_Empleados.Size = new System.Drawing.Size(174, 20);
            this.txt_p_Empleados.TabIndex = 1;
            this.txt_p_Empleados.Visible = false;
            // 
            // frm_Reporte_Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 450);
            this.Controls.Add(this.txt_p_Empleados);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_Reporte_Empleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Reporte_Empleado";
            this.Load += new System.EventHandler(this.frm_Reporte_Empleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS_Reportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspselempleadosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource uspselempleadosBindingSource;
        private DS_Reportes dS_Reportes;
        private DS_ReportesTableAdapters.Usp_sel_empleadosTableAdapter usp_sel_empleadosTableAdapter;
        public System.Windows.Forms.TextBox txt_p_Empleados;
    }
}