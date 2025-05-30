namespace Presentaciòn.Reportes
{
    partial class Form_Report_detalles_ordenes
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
            this.uspdetallesordenesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usp_detalles_ordenesTableAdapter = new Presentaciòn.Reportes.DS_ReportesTableAdapters.Usp_detalles_ordenesTableAdapter();
            this.txt_p_detalles_ordenes = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Reportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspdetallesordenesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dS_Detalles_Ordenes";
            reportDataSource1.Value = this.uspdetallesordenesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Presentaciòn.Reportes.Report_frm_detalles_ordenes.rdlc";
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
            // uspdetallesordenesBindingSource
            // 
            this.uspdetallesordenesBindingSource.DataMember = "Usp_detalles_ordenes";
            this.uspdetallesordenesBindingSource.DataSource = this.dS_Reportes;
            // 
            // usp_detalles_ordenesTableAdapter
            // 
            this.usp_detalles_ordenesTableAdapter.ClearBeforeFill = true;
            // 
            // txt_p_detalles_ordenes
            // 
            this.txt_p_detalles_ordenes.Location = new System.Drawing.Point(127, 99);
            this.txt_p_detalles_ordenes.Name = "txt_p_detalles_ordenes";
            this.txt_p_detalles_ordenes.Size = new System.Drawing.Size(220, 20);
            this.txt_p_detalles_ordenes.TabIndex = 1;
            this.txt_p_detalles_ordenes.Visible = false;
            // 
            // Form_Report_detalles_ordenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 450);
            this.Controls.Add(this.txt_p_detalles_ordenes);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form_Report_detalles_ordenes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Report_detalles_ordenes";
            this.Load += new System.EventHandler(this.Form_Report_detalles_ordenes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS_Reportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspdetallesordenesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource uspdetallesordenesBindingSource;
        private DS_Reportes dS_Reportes;
        private DS_ReportesTableAdapters.Usp_detalles_ordenesTableAdapter usp_detalles_ordenesTableAdapter;
        public System.Windows.Forms.TextBox txt_p_detalles_ordenes;
    }
}