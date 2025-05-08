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
        #endregion

        #region = "Load";
        private void Menu_Principal_Load(object sender, EventArgs e)
        {
            lbl_usuario_logo.Text = frm_login.UsuarioLogueado; //muestra el nombre del usuario en el label
            lbl_rol_usuario.Text = frm_login.rolusuario; //muestra el rol del usuario en el label
            
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
    }
}
