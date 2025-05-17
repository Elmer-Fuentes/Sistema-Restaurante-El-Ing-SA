using Seguridad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Presentaciòn
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
            txt_contrasena.UseSystemPasswordChar = true;
        }

        private C_seguridad c_seguridad = new C_seguridad();

        public void Limpiardatos()
        {
            txt_usuario.Text = "";
            txt_contrasena.Text = "";
        }

        private void frm_login_Load(object sender, EventArgs e)
        {
            style();
        }

        public void style()
        {
            this.ControlBox = false; // Oculta los botones de la barra de título
            this.FormBorderStyle = FormBorderStyle.None; // Quita los bordes
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txt_usuario.Text != "Username")
            {
                if (txt_contrasena.Text != "Password")
                {
                    var validlogin = c_seguridad.LoginUser(txt_usuario.Text, txt_contrasena.Text);
                    if (validlogin == true)
                    {
                        frm_Menu_v2 mainMenu = new frm_Menu_v2();
                        Mis_Variables.UsuarioLogueado = txt_usuario.Text;
                        mainMenu.Show();
                        this.Hide();
                        Limpiardatos();
                    }
                    else
                    {
                        MessageBox.Show("Nombre de usuario o contraseña ingresados ​​incorrectos. \n Por favor, inténtelo de nuevo.");
                        txt_usuario.Text = "Usarios";
                        txt_contrasena.Focus();
                        Limpiardatos();
                    }
                }
                else
                {
                    MessageBox.Show("Por favor Ingresa un Usuario");
                }
            }
            else
            {
                MessageBox.Show("Ingresa una  Contraseña");
            }
        }

        #region = "Mostrar contraseña";

        private bool entrada = false;

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (entrada == true)
            {
                txt_contrasena.UseSystemPasswordChar = true;
            }
            else
            {
                txt_contrasena.UseSystemPasswordChar = false;
            }
            entrada = !entrada;
            txt_contrasena.Focus();
        }

        #endregion = "Mostrar contraseña";
    }
}