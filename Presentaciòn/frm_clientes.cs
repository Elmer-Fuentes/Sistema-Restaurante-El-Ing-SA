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
    public partial class frm_clientes : Form
    {
        public frm_clientes()
        {
            InitializeComponent();
        }

        private void frm_clientes_Load(object sender, EventArgs e)
        {
            style();
        }

        public void style()
        {
            this.ControlBox = false; // Oculta los botones de la barra de título
            this.FormBorderStyle = FormBorderStyle.None; // Quita los bordes
        }

        public void MtdBorrardatos()
        {
            txt_codigoCliente.Text = "";
            txt_nombre.Text = "";
            txt_nit.Text = "";
            txt_telefono.Text = "";
            txt_categoria.Text = "";
            txt_estado.Text = "";
        }

        private void dgvDatosPlanilla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_codigoCliente.Text = dgvDatosPlanilla.SelectedCells[0].Value.ToString();
            txt_nit.Text = dgvDatosPlanilla.SelectedCells[2].Value.ToString();
            txt_nombre.Text = dgvDatosPlanilla.SelectedCells[1].Value.ToString();
            txt_telefono.Text = dgvDatosPlanilla.SelectedCells[3].Value.ToString();
            txt_categoria.Text = dgvDatosPlanilla.SelectedCells[4].Value.ToString();
            txt_estado.Text = dgvDatosPlanilla.SelectedCells[5].Value.ToString();
        }
    }
}