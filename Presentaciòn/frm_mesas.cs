using C_Logica;
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
    public partial class frm_mesas : Form
    {
        private cl_MtdFechas cl_fechas = new cl_MtdFechas();
        private cd_mesas cd_Mesas = new cd_mesas();

        public frm_mesas()
        {
            InitializeComponent();
        }

        private void frm_mesas_Load(object sender, EventArgs e)
        {
            Style();
            lblFecha.Text = cl_fechas.MtdFecha().ToString("d");
            MtdMostrardatos();
            tabPage1.Text = "Mesas";
            tabPage2.Text = "Buscar Mesas";
            ToolTip mensaje = new ToolTip();
            mensaje.SetToolTip(btnSalir, "Salir...");
            mensaje.SetToolTip(btnEliminar, "Eliminar");
            mensaje.SetToolTip(lblFecha, "Fecha Actual");
        }

        private void MtdMostrardatos()
        {
            DataTable dt = cd_Mesas.MtdRetornardatos();
            dgv_Mesas.DataSource = dt;
        }

        private void Style()
        {
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void dgv_Mesas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_codigoMesa.Text = dgv_Mesas.SelectedCells[0].Value.ToString();
            txt_NumeroMesa.Text = dgv_Mesas.SelectedCells[1].Value.ToString();
            txt_CantidadSillas.Text = dgv_Mesas.SelectedCells[2].Value.ToString();
            txt_Ubicacion.Text = dgv_Mesas.SelectedCells[3].Value.ToString();
            cbox_tipomesa.Text = dgv_Mesas.SelectedCells[4].Value.ToString();
            txt_estado.Text = dgv_Mesas.SelectedCells[5].Value.ToString();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}