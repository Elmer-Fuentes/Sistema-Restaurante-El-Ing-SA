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
            }
            else
            {
                this.pnl_Menu.Visible = false;
            }
            sub_pnl_opeccion();
        }

        private void salirDelSistemaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
