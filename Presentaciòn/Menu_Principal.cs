using Entidades;
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
    public partial class Menu_Principal : Form
    {
        public Menu_Principal()
        {
            InitializeComponent();
        }
        #region = "instancias de todos los formularios";
        private frm_usuarios frm_Usuario = null; //instancia del formulario hijo
        private frm_clientes frm_Clientes = null; //instancia del formulario hijo
        private frm_menu frm_Menu = null; //instancia del formulario hijo
		private frm_pago_planillas frm_Pago_Planillas = null; //instancia del formulario hijo
		private Dashboard_Empleados_Usuarios frm_Das_empleados = null; //instancia del formulario hijo
		#endregion

		#region = "Load";
		private void Menu_Principal_Load(object sender, EventArgs e)
        {
            lbl_usuario_logo.Text = Mis_Variables.UsuarioLogueado; //muestra el nombre del usuario en el label
            lbl_rol_usuario.Text = Mis_Variables.rolusuario; //muestra el rol del usuario en el label
            
        }
        #endregion

        #region = "Instancia de form en Usuaios"
        private void Usuarios_FormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frm_Usuario == null || frm_Usuario.IsDisposed)   //form cerrado o nUll
            {
                frm_Usuario = new frm_usuarios(); // Crea una nueva instancia solo cuando es necesario
                frm_Usuario.MdiParent = this; //asigna el formulario hijo al padre
                frm_Usuario.Show();
            }
            else
            {
                frm_Usuario.Focus(); // frm abierto, lo pone al frente
            }

        }
        #endregion

        #region = "Instancia de form en clientes"
        private void Clinetes_menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frm_Clientes == null || frm_Clientes.IsDisposed)   //form cerrado o nUll
            {
                frm_Clientes = new frm_clientes(); // Crea una nueva instancia solo cuando es necesario
                frm_Clientes.MdiParent = this; //asigna el formulario hijo al padre
                frm_Clientes.Show();
            }
            else
            {
                frm_Clientes.Focus(); // frm abierto, lo pone al frente
            }
        }
        #endregion


        #region = #"Boton Salir del sistema";
        private void salirDelSistemaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saliendo del sistema...");
            Application.Exit();
        }



        #endregion

        #region = "Boton Analisis de datos";
        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_fecha_so.Text = DateTime.Now.ToLongDateString(); //muestra la fecha en el label
            lbl_hora_so.Text = DateTime.Now.ToLongTimeString(); //muestra la hora en el label
        }

        private void detalleDeOrdenesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (frm_Menu == null || frm_Menu.IsDisposed)   //form cerrado o nUll
            {
                frm_Menu = new frm_menu(); // Crea una nueva instancia solo cuando es necesario
                frm_Menu.MdiParent = this; //asigna el formulario hijo al padre
                frm_Menu.Show();
            }
            else
            {
                frm_Menu.Focus(); // frm abierto, lo pone al frente
            }

        }

		private void mesasToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (frm_Pago_Planillas == null || frm_Pago_Planillas.IsDisposed)   //form cerrado o nUll
			{
				frm_Pago_Planillas = new frm_pago_planillas(); // Crea una nueva instancia solo cuando es necesario
				frm_Pago_Planillas.MdiParent = this; //asigna el formulario hijo al padre
				frm_Pago_Planillas.Show();
			}
			else
			{
				frm_Pago_Planillas.Focus(); // frm abierto, lo pone al frente
			}

		}

        private void dashboardEmpleadosUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frm_Das_empleados == null || frm_Das_empleados.IsDisposed)   //form cerrado o nUll
            {
                frm_Das_empleados = new Dashboard_Empleados_Usuarios(); // Crea una nueva instancia solo cuando es necesario
                frm_Das_empleados.MdiParent = this; //asigna el formulario hijo al padre
                frm_Das_empleados.Show();
            }
            else
            {
                frm_Das_empleados.Focus(); // frm abierto, lo pone al frente
            }
        }
    }
	}

