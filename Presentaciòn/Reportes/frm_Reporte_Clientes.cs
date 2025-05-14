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
    public partial class frm_Reporte_Clientes : Form
    {
        public frm_Reporte_Clientes()
        {
            InitializeComponent();
        }

        private void frm_Reporte_Clientes_Load(object sender, EventArgs e)
        {
            this.uSP_BusClienteTableAdapter.Fill(this.dS_Reportes.USP_BusCliente, txt_p2_clientes.Text);
            this.reportViewer1.RefreshReport();

        }
    }
}
