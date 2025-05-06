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
using C_Logica;
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
        cl_MtdFechas cl_fecha = new cl_MtdFechas();
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
            style();
        }

        #region = "style";
        public void style()
        {
            this.ControlBox = false; // Oculta los botones de la barra de título
            this.FormBorderStyle = FormBorderStyle.None; // Quita los bordes
        }
        #endregion

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
        #region = "Boton agregar";
        private void btnGuardar_Click(object sender, EventArgs e)
        {

            int codigo_empleado = int.Parse(txt_codigo_empleado.Text);
            string nombre_empleado = txt_nombre_empleado.Text;
            string nombre_usuario = txt_asignar_nombre_usuario.Text;
            string contrasena = txt_contrasena.Text;
            string rol = cbx_rol.Text;
            string estado = cbx_estado.Text;
            string usuario_sistema = frm_login.UsuarioLogueado;
            DateTime fecha_sistemanombre = cl_fecha.MtdFecha();
            try
            {
                cd_usuarios.MtdInsUsuarios(codigo_empleado, nombre_empleado, nombre_usuario, contrasena, rol, estado, usuario_sistema, fecha_sistemanombre);
                MessageBox.Show("Usuario creado correctamente", "Estado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Mtdmostrardatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex, "A ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region = "Boton Editar Usuarios";
        private void btnEditar_Click(object sender, EventArgs e)
        {
            

                int codigo_uid = int.Parse(dgvUsuarios.SelectedCells[0].Value.ToString());
                int codigo_empleado = int.Parse(txt_codigo_empleado.Text);
                string nombre_empleado = txt_nombre_empleado.Text;
                // string nombre_usuario = txt_asignar_nombre_usuario.Text;
                string contrasena = txt_contrasena.Text;
                string rol = cbx_rol.Text;
                string estado = cbx_estado.Text;
                string usuario_sistema = frm_login.UsuarioLogueado;
                  DateTime fecha_sistemanombre = cl_fecha.MtdFecha();
                try
                {
                    cd_usuarios.MtdUpdateUsuarios(codigo_uid, codigo_empleado, nombre_empleado, contrasena, rol, estado, usuario_sistema, fecha_sistemanombre);
                    MessageBox.Show("Usuario Actualizado correctamente", "Estado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Mtdmostrardatos();
                    Limpiardatos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex, "A ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
        #endregion

        #region = "MtdEliminar usuarios";
        private void btnEliminar_usuario_Click(object sender, EventArgs e)
        {
           

                int codigo_uid = int.Parse(dgvUsuarios.SelectedCells[0].Value.ToString());

                try
                {
                    cd_usuarios.MtdDeleteUsuarios(codigo_uid);
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

        #region ="Metodo Limpiar - Cancelar";
        public void Limpiardatos()
        {
            txt_codigo_empleado.Text = "";
            txt_nombre_empleado.Text = "";
            txt_asignar_nombre_usuario.Text = "";
            txt_contrasena.Text = "";
            cbx_rol.Text = "";
            cbx_estado.Text = "";
        }
        #endregion

        #region = "Boton Cancelar";
        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            Limpiardatos();
        }

        #endregion

        #region = "Boton Salir";
        private void btnSalir_frm_usuarios_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
    }
}
