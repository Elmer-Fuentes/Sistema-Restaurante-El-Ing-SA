namespace Presentaciòn.Reportes
{
    partial class frm_Report_mesas
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
            this.uspmesasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usp_mesasTableAdapter = new Presentaciòn.Reportes.DS_ReportesTableAdapters.Usp_mesasTableAdapter();
            this.txt_p1_mesas = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Reportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspmesasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dS_Mesas";
            reportDataSource1.Value = this.uspmesasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Presentaciòn.Reportes.Report_frm_mesas.rdlc";
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
            // uspmesasBindingSource
            // 
            this.uspmesasBindingSource.DataMember = "Usp_mesas";
            this.uspmesasBindingSource.DataSource = this.dS_Reportes;
            // 
            // usp_mesasTableAdapter
            // 
            this.usp_mesasTableAdapter.ClearBeforeFill = true;
            // 
            // txt_p1_mesas
            // 
            this.txt_p1_mesas.Location = new System.Drawing.Point(243, 84);
            this.txt_p1_mesas.Name = "txt_p1_mesas";
            this.txt_p1_mesas.Size = new System.Drawing.Size(186, 20);
            this.txt_p1_mesas.TabIndex = 2;
            this.txt_p1_mesas.Visible = false;
            // 
            // frm_Report_mesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 450);
            this.Controls.Add(this.txt_p1_mesas);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_Report_mesas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Report_mesas";
            this.Load += new System.EventHandler(this.frm_Report_mesas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS_Reportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspmesasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource uspmesasBindingSource;
        private DS_Reportes dS_Reportes;
        private DS_ReportesTableAdapters.Usp_mesasTableAdapter usp_mesasTableAdapter;
        public System.Windows.Forms.TextBox txt_p1_mesas;
    }
}