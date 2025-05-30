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
    public partial class frm_Report_mesas : Form
    {
        public frm_Report_mesas()
        {
            InitializeComponent();
        }

        private void frm_Report_mesas_Load(object sender, EventArgs e)
        {
            this.usp_mesasTableAdapter.Fill(this.dS_Reportes.Usp_mesas, txt_p1_mesas.Text);
            this.reportViewer1.RefreshReport();
        }
    }
}
