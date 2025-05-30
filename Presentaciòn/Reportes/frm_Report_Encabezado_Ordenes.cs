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
    public partial class frm_Report_Encabezado_Ordenes : Form
    {
        public frm_Report_Encabezado_Ordenes()
        {
            InitializeComponent();
        }

        private void frm_Report_Encabezado_Ordenes_Load(object sender, EventArgs e)
        {
            this.usp_Encabezado_ordenesTableAdapter.Fill(this.dS_Reportes.Usp_Encabezado_ordenes,txt_p_encabezado_ordenes.Text);
            this.reportViewer1.RefreshReport();
        }
    }
}
