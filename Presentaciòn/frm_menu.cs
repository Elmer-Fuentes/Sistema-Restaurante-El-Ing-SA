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
        private cd_Menus cd_menu = new cd_Menus();
        private cl_MtdFechas cl_fecha = new cl_MtdFechas();
        #endregion = "instancias de la clase Cd_Menu de la capa datos";

        private void frm_menu_Load(object sender, EventArgs e)
        {
            lblFecha.Text = cl_fecha.MtdFecha().ToString("dd/MM/yyyy");
            Mtdmostrardatos();
            style();
        }

        #region = "style";

        public void style()
        {
            this.ControlBox = false; // Oculta los botones de la barra de título
            this.FormBorderStyle = FormBorderStyle.None; // Quita los bordes
        }

        #endregion = "style";

        #region = "Metodo para vista del select o mostra en el dgv";

        private void Mtdmostrardatos()
        {
            DataTable dtMENU = cd_menu.MtdViewMenu();
            dgvMenus.DataSource = dtMENU;
        }

        #endregion = "Metodo para vista del select o mostra en el dgv";

        #region = "Boton salir form menu";

        private void btnSalir_frm_usuarios_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion = "Boton salir form menu";

        #region = "Limpiar form menu"

        public void Limpiardatos()
        {
            txt_codigo_menu.Clear();
            txt_nombre_menu.Clear();
            txt_ingredientes.Clear();
            cbx_categoria.Text = "";
            txt_precio.Clear();
            cbx_estado.Text = "";
        }

        #endregion = "Limpiar form menu"

        #region = "Botono agregar menu"

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //int codigo_menu = int.Parse(txt_codigo_menu.Text);
            string nombre = txt_nombre_menu.Text;
            string ingredientes = txt_ingredientes.Text;
            string categoria = cbx_categoria.Text;
            double precio = double.Parse(txt_precio.Text);
            string estado = cbx_estado.Text;
            string usuario_sistema = frm_login.UsuarioLogueado;
            DateTime fecha_sistemanombre = cl_fecha.MtdFecha();
            try
            {
                cd_menu.MtdInsMenu(/*codigo_menu, */nombre, ingredientes, categoria, precio, estado, usuario_sistema, fecha_sistemanombre);
                MessageBox.Show("Usuario creado correctamente", "Estado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Mtdmostrardatos();
                Limpiardatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex, "A ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion = "Botono agregar menu"

        #region = "Boton editar menu";

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int codigo_menu = int.Parse(txt_codigo_menu.Text);
            string nombre = txt_nombre_menu.Text;
            string ingredientes = txt_ingredientes.Text;
            string categoria = cbx_categoria.Text;
            double precio = double.Parse(txt_precio.Text);
            string estado = cbx_estado.Text;
            string usuario_sistema = frm_login.UsuarioLogueado;
            DateTime fecha_sistemanombre = cl_fecha.MtdFecha();
            try
            {
                cd_menu.MtdUpdMenu(codigo_menu, nombre, ingredientes, categoria, precio, estado, usuario_sistema, fecha_sistemanombre);
                MessageBox.Show("Usuario actualizado correctamente", "Estado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Mtdmostrardatos();
                Limpiardatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex, "A ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion = "Boton editar menu";

        #region = "Retornar data a txt, label,cbx"

        private void dgvMenus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_codigo_menu.Text = dgvMenus.SelectedCells[0].Value.ToString();
            txt_nombre_menu.Text = dgvMenus.SelectedCells[1].Value.ToString();
            txt_ingredientes.Text = dgvMenus.SelectedCells[2].Value.ToString();
            cbx_categoria.Text = dgvMenus.SelectedCells[3].Value.ToString();
            txt_precio.Text = dgvMenus.SelectedCells[4].Value.ToString();
            cbx_estado.Text = dgvMenus.SelectedCells[5].Value.ToString();
        }

        #endregion = "Retornar data a txt, label,cbx"

        #region= "Limpiar-Cancelar form menu"

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiardatos();
        }

        #endregion

        #region = "Boton eliminar menu";

        private void btnEliminar_usuario_Click(object sender, EventArgs e)
        {
            int codigo_uid = int.Parse(dgvMenus.SelectedCells[0].Value.ToString());

            try
            {
                cd_menu.MtdDeleteUsuarios(codigo_uid);
                MessageBox.Show("Usuario Eliminado correctamente", "Estado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Mtdmostrardatos();
                Limpiardatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex, "A ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        private void txt_buscar_empleado_TextChanged(object sender, EventArgs e)
        {
        }
    }
}