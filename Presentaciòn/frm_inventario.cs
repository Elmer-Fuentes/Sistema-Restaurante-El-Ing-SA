using Datos;
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
    public partial class frm_inventario : Form
    {
        private Cd_Inventario cd_inventario = new Cd_Inventario();

        public frm_inventario()
        {
            InitializeComponent();
            style();
            MtdMostrardatos();
        }

        private void style()
        {
            this.ControlBox = false; // quitar los botonesde minimizar salir etc...
            this.FormBorderStyle = FormBorderStyle.None; // quitar bordes de el formulario
            //quitar bordes de los botones que se agregaron al forms
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.FlatAppearance.BorderSize = 0;
        }

        private void MtdMostrardatos()
        {
            DataTable dt = cd_inventario.MtdRetornarDatos();
            dgvDatosPlanilla.DataSource = dt;
        }

        private void frm_inventario_Load(object sender, EventArgs e)
        {
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
        }
    }
}