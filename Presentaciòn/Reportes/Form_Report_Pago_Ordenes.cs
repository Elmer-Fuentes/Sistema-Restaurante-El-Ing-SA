using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentaciòn.Reportes
{
    public partial class Form_Report_Pago_Ordenes : Form
    {
        public Form_Report_Pago_Ordenes()
        {
            InitializeComponent();
        }

        private void Form_Report_Pago_Ordenes_Load(object sender, EventArgs e)
        {
            this.usp_pago_ordenesTableAdapter.Fill(this.dS_Reportes.Usp_pago_ordenes, txt_p_pago_ordenes.Text);
            this.reportViewer1.RefreshReport();
        }
    }
}
