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
        }
        C_seguridad c_seguridad = new C_seguridad();
            

   


        //public void Limpiardatos() 
        //{
        //    txt_usuario.Text = "";
        //    txt_contrasena.Text = "";
        //}
        
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
                        Menu_Principal mainMenu = new Menu_Principal();
                        Mis_Variables.UsuarioLogueado = txt_usuario.Text;
                        mainMenu.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect username or password entered. \n Please try again.");
                        txt_usuario.Text = "Usarios";
                        txt_contrasena.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Porfavor Ingresa un Usuario");
                }
            }
            else
            {
                MessageBox.Show("Porfavor Ingresa una Contraseña");
            }
        }
    }
}
