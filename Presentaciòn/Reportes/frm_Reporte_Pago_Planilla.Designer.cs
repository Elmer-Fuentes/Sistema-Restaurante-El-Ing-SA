namespace Presentaciòn.Reportes
{
    partial class frm_Reporte_Pago_Planilla
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dS_Reportes = new Presentaciòn.Reportes.DS_Reportes();
            this.uspPagoPlanillaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usp_Pago_PlanillaTableAdapter = new Presentaciòn.Reportes.DS_ReportesTableAdapters.Usp_Pago_PlanillaTableAdapter();
            this.txt_p_pago_planilla = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Reportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspPagoPlanillaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DS_uspPagoPlanilla";
            reportDataSource1.Value = this.uspPagoPlanillaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Presentaciòn.Reportes.Report_Pago_Planilla.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1032, 450);
            this.reportViewer1.TabIndex = 2;
            // 
            // dS_Reportes
            // 
            this.dS_Reportes.DataSetName = "DS_Reportes";
            this.dS_Reportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uspPagoPlanillaBindingSource
            // 
            this.uspPagoPlanillaBindingSource.DataMember = "Usp_Pago_Planilla";
            this.uspPagoPlanillaBindingSource.DataSource = this.dS_Reportes;
            // 
            // usp_Pago_PlanillaTableAdapter
            // 
            this.usp_Pago_PlanillaTableAdapter.ClearBeforeFill = true;
            // 
            // txt_p_pago_planilla
            // 
            this.txt_p_pago_planilla.Location = new System.Drawing.Point(168, 80);
            this.txt_p_pago_planilla.Name = "txt_p_pago_planilla";
            this.txt_p_pago_planilla.Size = new System.Drawing.Size(115, 20);
            this.txt_p_pago_planilla.TabIndex = 3;
            this.txt_p_pago_planilla.Visible = false;
            // 
            // frm_Reporte_Pago_Planilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 450);
            this.Controls.Add(this.txt_p_pago_planilla);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_Reporte_Pago_Planilla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Pago de Planilla";
            this.Load += new System.EventHandler(this.frm_Reporte_Pago_Planilla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS_Reportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspPagoPlanillaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource uspPagoPlanillaBindingSource;
        private DS_Reportes dS_Reportes;
        private DS_ReportesTableAdapters.Usp_Pago_PlanillaTableAdapter usp_Pago_PlanillaTableAdapter;
        public System.Windows.Forms.TextBox txt_p_pago_planilla;
    }
}