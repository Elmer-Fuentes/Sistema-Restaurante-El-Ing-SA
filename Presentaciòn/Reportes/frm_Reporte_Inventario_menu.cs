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
    public partial class frm_Reporte_Inventario_menu : Form
    {
        public frm_Reporte_Inventario_menu()
        {
            InitializeComponent();
        }

        private void frm_Reporte_Inventario_menu_Load(object sender, EventArgs e)
        {
            this.uSP_Inventario_MenuTableAdapter.Fill(this.dS_Reportes.USP_Inventario_Menu,txt_p_nombre_inventario_men.Text);
            this.reportViewer1.RefreshReport();

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
