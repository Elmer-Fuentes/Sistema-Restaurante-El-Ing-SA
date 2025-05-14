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
    public partial class frm_Reporte_Usuarios : Form
    {
        public frm_Reporte_Usuarios()
        {
            InitializeComponent();
        }

        private void frm_Reporte_Usuarios_Load(object sender, EventArgs e)
        {
            this.ups_usuariosTableAdapter.Fill(this.dS_Reportes.Ups_usuarios, txt_p_usuario.Text);
            this.reportViewer1.RefreshReport();
        }
    }
}
