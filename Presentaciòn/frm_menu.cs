using C_Logica;
using capa_datos;
using Datos;
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
    public partial class frm_menu : Form
    {
        public frm_menu()
        {
            InitializeComponent();
        }

        #region = "instancias de la clase Cd_Menu de la capa datos";
        cd_Menus cd_menu = new cd_Menus();
        cl_MtdFechas cl_fecha = new cl_MtdFechas();
        #endregion
        private void frm_menu_Load(object sender, EventArgs e)
        {
            Mtdmostrardatos();
            

        }
        #region = "Metodo para vista del select o mostra en el dgv";
        private void Mtdmostrardatos()
        {
            DataTable dtUsuarios = cd_menu.MtdViewMenu();
            dgvMenus.DataSource = dtUsuarios;
        }
        #endregion
    }
}
