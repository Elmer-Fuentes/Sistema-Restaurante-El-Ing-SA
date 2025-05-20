using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentaciòn
{
    public partial class frm_inventario : Form
    {
        public frm_inventario()
        {
            InitializeComponent();
            style();
        }

        private void style()
        {
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.None;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.FlatAppearance.BorderSize = 0;
        }

        private void frm_inventario_Load(object sender, EventArgs e)
        {
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
        }
    }
}