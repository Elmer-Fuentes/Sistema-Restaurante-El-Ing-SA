using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capa_datos;

namespace Presentaciòn
{
    public partial class frm_usuarios : Form
    {
        public frm_usuarios()
        {
            InitializeComponent();
        }
        #region = "instancias de la clase Cd_Usuario de la capa datos";
        cd_Usuarios cd_usuarios = new cd_Usuarios();
        #endregion


        #region = "Metodo para vista del select o mostra en el dgv";
        private void Mtdmostrardatos()
        {
            DataTable dtUsuarios = cd_usuarios.MtdViewUsuarios();
            dgvUsuarios.DataSource = dtUsuarios;
        }
        #endregion


        private void frm_usuarios_Load(object sender, EventArgs e)
        {
            Mtdmostrardatos();
        }


        #region = "Seleccion de celdas en data dgv retornar a txt,cbc, label,etc";
        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_codigo_empleado.Text = dgvUsuarios.SelectedCells[1].Value.ToString();
            txt_nombre_empleado.Text = dgvUsuarios.SelectedCells[2].Value.ToString();
            txt_asignar_nombre_usuario.Text = dgvUsuarios.SelectedCells[3].Value.ToString();
            txt_contrasena.Text = dgvUsuarios.SelectedCells[4].Value.ToString();
            cbx_rol.Text = dgvUsuarios.SelectedCells[5].Value.ToString();
            cbx_estado.Text = dgvUsuarios.SelectedCells[6].Value.ToString();

        }
        #endregion


    }
}
