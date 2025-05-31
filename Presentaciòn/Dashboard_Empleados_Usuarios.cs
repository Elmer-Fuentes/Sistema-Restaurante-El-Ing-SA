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
    public partial class Dashboard_Empleados_Usuarios : Form
    {
        public Dashboard_Empleados_Usuarios()
        {
            InitializeComponent();
        }
        string powerbi = "<iframe title=\"Rep_Empleados_Usuarios\" width=\"600\" height=\"373.5\" src=\"https://app.powerbi.com/view?r=eyJrIjoiNmJjYTc1NDQtYTMyZi00Y2ZlLWI3ZTctYzEyYzM2MTZjNzA0IiwidCI6IjVmNTNiNGNlLTYzZDQtNGVlOC04OGQyLTIyZjBiMmQ0YjI3YSIsImMiOjR9&pageName=7b5089140e00a0d3045b\" frameborder=\"0\" allowFullScreen=\"true\"></iframe>";


        private async void Dashboard_Empleados_Usuarios_Load(object sender, EventArgs e)
        {
            // Asegúrate de que el control WebView2 esté inicializado
            await webView21.EnsureCoreWebView2Async(null);
            // Ahora puedes navegar
            webView21.NavigateToString(powerbi);
            style();
        }

        #region = "style";
        public void style()
        {
            this.ControlBox = false; // Oculta los botones de la barra de título
            this.FormBorderStyle = FormBorderStyle.None; // Quita los bordes
        }
        #endregion

        private void btnSalir_frm_usuarios_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
