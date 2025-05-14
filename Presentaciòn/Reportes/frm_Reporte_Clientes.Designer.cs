namespace Presentaciòn.Reportes
{
    partial class frm_Reporte_Clientes
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.uSPBusClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Reportes = new Presentaciòn.Reportes.DS_Reportes();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.uSP_BusClienteTableAdapter = new Presentaciòn.Reportes.DS_ReportesTableAdapters.USP_BusClienteTableAdapter();
            this.txt_p2_clientes = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.uSPBusClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Reportes)).BeginInit();
            this.SuspendLayout();
            // 
            // uSPBusClienteBindingSource
            // 
            this.uSPBusClienteBindingSource.DataMember = "USP_BusCliente";
            this.uSPBusClienteBindingSource.DataSource = this.dS_Reportes;
            // 
            // dS_Reportes
            // 
            this.dS_Reportes.DataSetName = "DS_Reportes";
            this.dS_Reportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DS_Bus_Clientes";
            reportDataSource3.Value = this.uSPBusClienteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Presentaciòn.Reportes.Report_Bus_Clientes.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1032, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // uSP_BusClienteTableAdapter
            // 
            this.uSP_BusClienteTableAdapter.ClearBeforeFill = true;
            // 
            // txt_p2_clientes
            // 
            this.txt_p2_clientes.Location = new System.Drawing.Point(66, 46);
            this.txt_p2_clientes.Name = "txt_p2_clientes";
            this.txt_p2_clientes.Size = new System.Drawing.Size(186, 20);
            this.txt_p2_clientes.TabIndex = 1;
            this.txt_p2_clientes.Visible = false;
            // 
            // frm_Reporte_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 450);
            this.Controls.Add(this.txt_p2_clientes);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_Reporte_Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Clientes";
            this.Load += new System.EventHandler(this.frm_Reporte_Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uSPBusClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Reportes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource uSPBusClienteBindingSource;
        private DS_Reportes dS_Reportes;
        private DS_ReportesTableAdapters.USP_BusClienteTableAdapter uSP_BusClienteTableAdapter;
        public System.Windows.Forms.TextBox txt_p2_clientes;
    }
}