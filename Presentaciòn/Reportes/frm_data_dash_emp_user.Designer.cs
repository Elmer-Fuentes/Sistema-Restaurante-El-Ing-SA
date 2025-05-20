namespace Presentaciòn.Reportes
{
    partial class frm_data_dash_emp_user
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
            this.upsDataDashEmpuserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Reportes = new Presentaciòn.Reportes.DS_Reportes();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ups_Data_Dash_Emp_userTableAdapter = new Presentaciòn.Reportes.DS_ReportesTableAdapters.Ups_Data_Dash_Emp_userTableAdapter();
            this.txt_dash_emp_user = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.upsDataDashEmpuserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Reportes)).BeginInit();
            this.SuspendLayout();
            // 
            // upsDataDashEmpuserBindingSource
            // 
            this.upsDataDashEmpuserBindingSource.DataMember = "Ups_Data_Dash_Emp_user";
            this.upsDataDashEmpuserBindingSource.DataSource = this.dS_Reportes;
            // 
            // dS_Reportes
            // 
            this.dS_Reportes.DataSetName = "DS_Reportes";
            this.dS_Reportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DS_Reporte_Dash_Emp_Use";
            reportDataSource1.Value = this.upsDataDashEmpuserBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Presentaciòn.Reportes.Report_Data_dash_Emp_user.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(884, 411);
            this.reportViewer1.TabIndex = 0;
            // 
            // ups_Data_Dash_Emp_userTableAdapter
            // 
            this.ups_Data_Dash_Emp_userTableAdapter.ClearBeforeFill = true;
            // 
            // txt_dash_emp_user
            // 
            this.txt_dash_emp_user.Location = new System.Drawing.Point(43, 29);
            this.txt_dash_emp_user.Name = "txt_dash_emp_user";
            this.txt_dash_emp_user.Size = new System.Drawing.Size(152, 20);
            this.txt_dash_emp_user.TabIndex = 1;
            this.txt_dash_emp_user.Visible = false;
            // 
            // frm_data_dash_emp_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(884, 411);
            this.Controls.Add(this.txt_dash_emp_user);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_data_dash_emp_user";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Analisis Empleados Con Usuarios";
            this.Load += new System.EventHandler(this.frm_data_dash_emp_user_Load);
            ((System.ComponentModel.ISupportInitialize)(this.upsDataDashEmpuserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Reportes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource upsDataDashEmpuserBindingSource;
        private DS_Reportes dS_Reportes;
        private DS_ReportesTableAdapters.Ups_Data_Dash_Emp_userTableAdapter ups_Data_Dash_Emp_userTableAdapter;
        public System.Windows.Forms.TextBox txt_dash_emp_user;
    }
}