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
    public partial class Form_Report_detalles_ordenes : Form
    {
        public Form_Report_detalles_ordenes()
        {
            InitializeComponent();
        }

        private void Form_Report_detalles_ordenes_Load(object sender, EventArgs e)
        {
            this.usp_detalles_ordenesTableAdapter.Fill(this.dS_Reportes.Usp_detalles_ordenes, txt_p_detalles_ordenes.Text);
            this.reportViewer1.RefreshReport();
        }
    }
}
