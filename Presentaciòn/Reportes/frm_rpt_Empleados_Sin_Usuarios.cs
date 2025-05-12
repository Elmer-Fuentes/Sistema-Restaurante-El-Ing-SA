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
    public partial class frm_rpt_Empleados_Sin_Usuarios : Form
    {
        public frm_rpt_Empleados_Sin_Usuarios()
        {
            InitializeComponent();
        }

        private void frm_rpt_Empleados_Sin_Usuarios_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
