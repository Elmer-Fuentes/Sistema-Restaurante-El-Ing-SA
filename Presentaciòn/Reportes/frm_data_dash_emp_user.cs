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
    public partial class frm_data_dash_emp_user : Form
    {
        public frm_data_dash_emp_user()
        {
            InitializeComponent();
        }

        private void frm_data_dash_emp_user_Load(object sender, EventArgs e)
        {
            this.ups_Data_Dash_Emp_userTableAdapter.Fill(this.dS_Reportes.Ups_Data_Dash_Emp_user, txt_dash_emp_user.Text);
            this.reportViewer1.RefreshReport();
        }
    }
}
