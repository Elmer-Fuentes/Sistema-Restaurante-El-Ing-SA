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
using Entidades;
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
        #endregion

        #region = "Seleccion de celdas en data dgv retornar a txt,cbc, label,etc";
        private void dgvUsuarios_Click(object sender, EventArgs e)
        {
			var FilaSeleccionada = dgvUsuarios.SelectedRows[0];


			if (FilaSeleccionada.Index == dgvUsuarios.Rows.Count - 1)
			{
				MessageBox.Show("Seleccione una fila con datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else


			txt_codigo_empleado.Text = dgvUsuarios.SelectedCells[1].Value.ToString();
            txt_nombre_empleado.Text = dgvUsuarios.SelectedCells[2].Value.ToString();
            txt_asignar_nombre_usuario.Text = dgvUsuarios.SelectedCells[3].Value.ToString();
            txt_contrasena.Text = dgvUsuarios.SelectedCells[4].Value.ToString();
            cbx_rol.Text = dgvUsuarios.SelectedCells[5].Value.ToString();
            cbx_estado.Text = dgvUsuarios.SelectedCells[6].Value.ToString();
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

        #region = "Boton agregar";
        private void btnGuardar_Click(object sender, EventArgs e)
        {


			if (string.IsNullOrEmpty(txt_codigo_empleado.Text) || string.IsNullOrEmpty(txt_nombre_empleado.Text) || string.IsNullOrEmpty(txt_asignar_nombre_usuario.Text) || string.IsNullOrEmpty(txt_contrasena.Text)|| string.IsNullOrEmpty(cbx_rol.Text) || string.IsNullOrEmpty(cbx_estado.Text))
			{
				MessageBox.Show("Complete todos los datos antes de guardar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			else

				try
				{


				int codigo_empleado = int.Parse(txt_codigo_empleado.Text);
                string nombre_empleado = txt_nombre_empleado.Text;
                string nombre_usuario = txt_asignar_nombre_usuario.Text;
                string contrasena = txt_contrasena.Text;
                string rol = cbx_rol.Text;
                string estado = cbx_estado.Text;
                string usuario_sistema = Mis_Variables.UsuarioLogueado;
                DateTime fecha_sistemanombre = cl_fecha.MtdFecha();
                
                    cd_usuarios.MtdInsUsuarios(codigo_empleado, nombre_empleado, nombre_usuario, contrasena, rol, estado, usuario_sistema, fecha_sistemanombre);
                    MessageBox.Show("Usuario creado correctamente", "Estado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Mtdmostrardatos();
                    Limpiardatos();
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
                //string nombre_empleado = txt_nombre_empleado.Text;
                string nombre_usuario = txt_asignar_nombre_usuario.Text;
                string contrasena = txt_contrasena.Text;
                string rol = cbx_rol.Text;
                string estado = cbx_estado.Text;
                string usuario_sistema = Mis_Variables.UsuarioLogueado;
                DateTime fecha_sistemanombre = cl_fecha.MtdFecha();
                try
                {
                    cd_usuarios.MtdUpdateUsuarios(codigo_uid, codigo_empleado, nombre_usuario, contrasena, rol, estado, usuario_sistema, fecha_sistemanombre);
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

        #region = "Boton Salir";
        private void btnSalir_frm_usuarios_Click(object sender, EventArgs e)
        {
                Close();
        }
        #endregion

        #region = "Boton Cancelar";
        private void btnCancelar_Click(object sender, EventArgs e)
        {
                Limpiardatos();
        }

        #endregion






        #region = "Cambiar de tabpage cargar todos los registros empleados sin usuarios"
        private void tabControl_Usuarios_SelectedIndexChanged(object sender, EventArgs e)
        {

            MostrarEmpleadossinUsuario("%"); //comodin
        }
        #endregion

        #region = MtdBuscarEmpleadosSinUsuario Ok  ";
        private void MostrarEmpleadossinUsuario(string filtro) //recibe y pasa el parametro al proc a c_datos_usuarios  
        {
            DataTable obj = cd_usuarios.MtdBuscarUsuariosPorNombre(filtro);
            dvg_empleados_sin_Usuarios.DataSource = obj;

        }
        #endregion

        #region ="Boton_Buscar_empleados_sin registro";
        private void btn_Bus_emple_sin_name_Click(object sender, EventArgs e)
        {
            MostrarEmpleadossinUsuario(txt_buscar_empleado.Text);
        }
        #endregion

        #region = "Boton cancelar buscar empleados sin usuario";
        private void btn_cancelarBus_Usuario_Click(object sender, EventArgs e)
        {
            MostrarEmpleadossinUsuario("%"); //comodin
        }
        #endregion

        private void dvg_empleados_sin_Usuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Limpiardatos();
            txt_codigo_empleado.Text = dvg_empleados_sin_Usuarios.SelectedCells[0].Value.ToString();
            txt_nombre_empleado.Text = dvg_empleados_sin_Usuarios.SelectedCells[1].Value.ToString();
            tabControl_Usuarios.SelectedIndex = 0; // Cambia a la pestaña de usuarios
            txt_buscar_empleado.Text = "";
            txt_asignar_nombre_usuario.Focus();
        }

        private void btn_Reporte_Click(object sender, EventArgs e)
        {
            Reportes.frm_Reporte_Empleados_Sin_Usuarios obj = new Reportes.frm_Reporte_Empleados_Sin_Usuarios();
            obj.txt_p1.Text = txt_buscar_empleado.Text;
            obj.ShowDialog();
        }

		private void tabPage1_Click(object sender, EventArgs e)
		{

		}

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
