using C_Logica;
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
    public partial class frm_mesas : Form
    {
        public frm_mesas()
        {
            InitializeComponent();
        }

        private void frm_mesas_Load(object sender, EventArgs e)
        {
        }

        public void Style()
        {
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.None;
        }
    }
}