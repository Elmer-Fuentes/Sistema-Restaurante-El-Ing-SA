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
    public partial class frm_Reporte_Pago_Planilla : Form
    {
        public frm_Reporte_Pago_Planilla()
        {
            InitializeComponent();
        }

        private void frm_Reporte_Pago_Planilla_Load(object sender, EventArgs e)
        {
            this.usp_Pago_PlanillaTableAdapter.Fill(this.dS_Reportes.Usp_Pago_Planilla, txt_p_pago_planilla.Text);
            this.reportViewer1.RefreshReport();
        }
    }
}
