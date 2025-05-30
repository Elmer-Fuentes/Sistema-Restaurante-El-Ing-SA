namespace Presentaciòn.Reportes
{
    partial class frm_Report_Encabezado_Ordenes
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
            this.uspEncabezadoordenesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usp_Encabezado_ordenesTableAdapter = new Presentaciòn.Reportes.DS_ReportesTableAdapters.Usp_Encabezado_ordenesTableAdapter();
            this.txt_p_encabezado_ordenes = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Reportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspEncabezadoordenesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.DocumentMapWidth = 63;
            reportDataSource1.Name = "dS_Encabezado_ordenes";
            reportDataSource1.Value = this.uspEncabezadoordenesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Presentaciòn.Reportes.Report_frm_encabezado_ordenes.rdlc";
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
            // uspEncabezadoordenesBindingSource
            // 
            this.uspEncabezadoordenesBindingSource.DataMember = "Usp_Encabezado_ordenes";
            this.uspEncabezadoordenesBindingSource.DataSource = this.dS_Reportes;
            // 
            // usp_Encabezado_ordenesTableAdapter
            // 
            this.usp_Encabezado_ordenesTableAdapter.ClearBeforeFill = true;
            // 
            // txt_p_encabezado_ordenes
            // 
            this.txt_p_encabezado_ordenes.Location = new System.Drawing.Point(139, 67);
            this.txt_p_encabezado_ordenes.Name = "txt_p_encabezado_ordenes";
            this.txt_p_encabezado_ordenes.Size = new System.Drawing.Size(159, 20);
            this.txt_p_encabezado_ordenes.TabIndex = 4;
            this.txt_p_encabezado_ordenes.Visible = false;
            // 
            // frm_Report_Encabezado_Ordenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 450);
            this.Controls.Add(this.txt_p_encabezado_ordenes);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_Report_Encabezado_Ordenes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Report_Encabezado_Ordenes";
            this.Load += new System.EventHandler(this.frm_Report_Encabezado_Ordenes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS_Reportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspEncabezadoordenesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource uspEncabezadoordenesBindingSource;
        private DS_Reportes dS_Reportes;
        private DS_ReportesTableAdapters.Usp_Encabezado_ordenesTableAdapter usp_Encabezado_ordenesTableAdapter;
        public System.Windows.Forms.TextBox txt_p_encabezado_ordenes;
    }
}