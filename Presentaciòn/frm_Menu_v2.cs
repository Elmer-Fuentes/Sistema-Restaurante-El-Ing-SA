using Entidades;
using Presentaciòn.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

        #region = "mtd load capturar usuario y roll"
        private void frm_Menu_v2_Load(object sender, EventArgs e)
        {
            sub_pnl_opeccion();

            lbl_usuario_logo.Text = Mis_Variables.UsuarioLogueado; //muestra el nombre del usuario en el label
            lbl_rol_usuario.Text = Mis_Variables.rolusuario; //muestra el rol del usuario en el label
        }
        #endregion

        #region = "Ocultar subpanel";
        private void sub_pnl_opeccion()
        {
            this.pnl_administracion.Visible = false;
            this.pnl_catalogos.Visible = false;
            this.pnl_operaciones.Visible = false;
        }
        #endregion

        #region = "Programación en Timer pie MTI v2"
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_fecha_so_v2.Text = DateTime.Now.ToLongDateString(); //muestra la fecha en el label
            lbl_hora_so_v2.Text = DateTime.Now.ToLongTimeString(); //muestra la hora en el label
        }
        #endregion

        #region = "Accion de los btn acceos principal en panel tipo dashbaord";
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
        #endregion

        #region = "btn ocultar- mostrar_asignar.icono panel menu MDI v2";
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
        #endregion

        #region = "Mtd para controlar Salir del sistema";
        //controlar btn principal del mdi cerrar    
        private void frm_Menu_v2_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        #endregion;

        #region = "bnt_salir MDI";
        private void iconMenuItemSalirSistema_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        #endregion

        #region = "Cambiar Inicio seción";
        private void iconMenuItem_CambioUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_login login = new frm_login();
            login.Show();
        }
        #endregion

        #region "Mis Variables Form Secundario (hijo)";

        private Form activeForm = null;

        #endregion

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

        #endregion;

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


        private void btn_det_ordenen_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_detalle_ordenes());
        }

        private void btn_pago_Orden_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_pago_ordens());
        }


        #endregion;

        private void lbl_usuario_logo_Click(object sender, EventArgs e)
        {

        }

        private void iconMenuItem1_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_Reporte_Inventario_menu());
        }

        private void iconMenuItem2_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_Reporte_Empleado());
        }

        private void Data_Dash_Usuarios_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_data_dash_emp_user());
        }

        private void sub_cliente_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_Reporte_Clientes());
        }

        private void sub_usuario_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_Reporte_Usuarios());
        }

        private void sub_pago_planilla_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_Reporte_Pago_Planilla());
        }

        private void sub_inventarios_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_Reporte_Inventario_menu());
        }

        private void sub_mesas_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_Report_mesas());
        }

        private void sub_enc_ordenes_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_Report_Encabezado_Ordenes());
        }

        private void sub_det_ordenes_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_Report_detalles_ordenes());
        }

        private void sub_pago_ordenes_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_Report_Pago_Ordenes());
        }

        private void dashboardEmpleadosUsuariosToolStripMenuIte_Click(object sender, EventArgs e)
        {
            openChildForm(new Dashboard_Empleados_Usuarios());
        }

        private void iconMenuItem_nosotros_Click(object sender, EventArgs e)
        {
          //  |llama a un proceso del SO    | define como iniciar proceso| especifica la Url|                                                                    indicaque se va autilizar powershell del SO para abrir el url en nav predeterminado
            System.Diagnostics.Process.Start( new ProcessStartInfo { FileName = "https://drive.google.com/uc?export=download&id=1jdsVtEYSW7hh8gOQI0W0esB0OXs5Uf6v", UseShellExecute = true });
                 
        }
    }
}
