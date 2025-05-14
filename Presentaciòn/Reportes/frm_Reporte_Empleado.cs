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
    public partial class frm_Reporte_Empleado : Form
    {
        public frm_Reporte_Empleado()
        {
            InitializeComponent();
        }

        private void frm_Reporte_Empleado_Load(object sender, EventArgs e)
        {
            this.usp_sel_empleadosTableAdapter.Fill(this.dS_Reportes.Usp_sel_empleados, txt_p_Empleados.Text);
            this.reportViewer1.RefreshReport();
        }
    }
}
