using Entidades;
using Presentaciòn.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace Presentaciòn
{
    public partial class frm_Menu_v2 : Form
    {
        public frm_Menu_v2()
        {
            InitializeComponent();
        }

        private void lbl_usuario_logo_Click(object sender, EventArgs e)
        {
        }

        private void sub_pnl_opeccion()
        {
            this.pnl_administracion.Visible = false;
            this.pnl_catalogos.Visible = false;
            this.pnl_operaciones.Visible = false;
        }

        private void frm_Menu_v2_Load(object sender, EventArgs e)
        {
            sub_pnl_opeccion();

            lbl_usuario_logo.Text = Mis_Variables.UsuarioLogueado; //muestra el nombre del usuario en el label
            lbl_rol_usuario.Text = Mis_Variables.rolusuario; //muestra el rol del usuario en el label
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_fecha_so_v2.Text = DateTime.Now.ToLongDateString(); //muestra la fecha en el label
            lbl_hora_so_v2.Text = DateTime.Now.ToLongTimeString(); //muestra la hora en el label
        }

        private void btn_administracion_Click(object sender, EventArgs e)
        {
            if (this.pnl_administracion.Visible == false)
            {
                this.pnl_administracion.Visible = true;
            }
            else
            {
                this.pnl_administracion.Visible = false;
            }
            this.pnl_catalogos.Visible = false;
            this.pnl_operaciones.Visible = false;
        }

        private void btn_catalogos_Click(object sender, EventArgs e)
        {
            if (this.pnl_catalogos.Visible == false)
            {
                this.pnl_catalogos.Visible = true;
            }
            else
            {
                this.pnl_catalogos.Visible = false;
            }
            this.pnl_administracion.Visible = false;
            this.pnl_operaciones.Visible = false;
        }

        private void btn_operaciones_Click(object sender, EventArgs e)
        {
            if (this.pnl_operaciones.Visible == false)
            {
                this.pnl_operaciones.Visible = true;
            }
            else
            {
                this.pnl_operaciones.Visible = false;
            }
            this.pnl_administracion.Visible = false;
            this.pnl_catalogos.Visible = false;
        }

        private void btn_ocultar_Menu_Click(object sender, EventArgs e)
        {
            if (this.pnl_Menu.Visible == false)
            {
                this.pnl_Menu.Visible = true;
                btn_ocultar_Menu.IconChar = FontAwesome.Sharp.IconChar.ReplyAll;
            }
            else
            {
                this.pnl_Menu.Visible = false;
                btn_ocultar_Menu.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            }
            sub_pnl_opeccion();
        }

        #region = "Mtd para controlar Salir del sistema y Cambiar Sección"
        #region = "Evento fromclosing desde propiedades para controlar el btn_cerrar del MDI";



        #endregion;
        private void salirDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        #region = "Cambiar Inicio seción";
                private void cerrarSeciónToolStripMenuItem_Click(object sender, EventArgs e)
                {
                    this.Hide();
                    frm_login login = new frm_login();
                    login.Show();
                }
                //controlar btn principal del mdi cerrar    
                private void frm_Menu_v2_FormClosing(object sender, FormClosingEventArgs e)
                {
                    System.Windows.Forms.Application.Exit();
                }
                #endregion

        #endregion




        #region "Mis Variables Form Secundario (hijo)";

        private Form activeForm = null;

        #endregion "Mis Variables Form Secundario (hijo)";

        #region "Mtd Abrir y Mostrar form";

        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false; //no ventana independiente mostrar en otro control
            childForm.FormBorderStyle = FormBorderStyle.None; //sin bordes
            childForm.Dock = DockStyle.Fill; // centro
            pnl_body.Controls.Add(childForm); //cargar el form hijo en el panel del cuerpo
            childForm.BringToFront(); //carga el form
            childForm.Show();// llama al form hijo
        }

        #endregion "Mtd Abrir y Mostrar form";

        #region = "Instancia de form hijos";

        private void btn_usuarios_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_usuarios());
        }

        private void btn_empleados_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_empleados());
        }

        private void btn_planillas_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_pago_planillas());
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_menu());
        }

        private void btn_clientes_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_clientes());
        }

        private void btn_inventarios_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_inventario());
        }

        private void btn_mesas_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_mesas());
        }

        private void btn_enca_orden_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_encabezado_ordenes());
        }

        private void inventariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_Reporte_Inventario_menu());
        }

        private void empleadosSinUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_Reporte_Inventario_menu());
        }

        private void dataDashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_data_dash_emp_user());
        }

        private void empleadosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_Reporte_Empleado());
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_Reporte_Clientes());
        }

        private void usuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_Reporte_Usuarios());
        }

        private void pagoPlanillaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_Reporte_Pago_Planilla());
        }


        private void dashboardEmpleadosUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new Dashboard_Empleados_Usuarios());
        }

        private void btn_det_ordenen_Click(object sender, EventArgs e)
        {
            openChildForm (new frm_detalle_ordenes());
        }
        #endregion;

        private void btn_pago_Orden_Click(object sender, EventArgs e)
        {
            openChildForm (new frm_pago_ordens());
        }

     
    }
}