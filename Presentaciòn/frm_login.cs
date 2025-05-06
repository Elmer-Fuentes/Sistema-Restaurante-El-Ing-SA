using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Seguridad;

namespace Presentaciòn
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }
        C_seguridad c_seguridad = new C_seguridad();
        // Propiedad interna estática para almacenar el nombre de usuario logueado
        internal static string UsuarioLogueado { get; private set; }
        internal static string rolusuario { get; private set; }

        #region = "Btn Ingresar y llamar al form principal"
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string tipoUsuario = c_seguridad.VerificarLogin(txt_usuario.Text, txt_contrasena.Text);

            if (!string.IsNullOrEmpty(tipoUsuario))
            {
                MessageBox.Show($"Bienvenido (a) {txt_usuario.Text}, has iniciado sesión como {tipoUsuario}");
                UsuarioLogueado = txt_usuario.Text; // Almacena el nombre de usuario logueado
                rolusuario = tipoUsuario; // Almacena el rol de usuario logueado
               // Menu_Principal menu = new Menu_Principal();
                this.Hide();
               // menu.Show();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña Incorrecta");
            }
            #endregion
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
