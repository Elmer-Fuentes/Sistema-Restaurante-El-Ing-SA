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
using Logica;

namespace Presentaciòn
{
    public partial class frm_clientes : Form
    {
        private cd_clientes cd_clin = new cd_clientes();
        private cl_MtdFecha cl_clin = new cl_MtdFecha();

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

        private void Mtdmostrardatos()
        {
            cd_clientes cd_clin = new cd_clientes();
            DataTable dt = cd_clin.MtdDevolverdatos();
            dgvDatosPlanilla.DataSource = dt;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string fecha = cl_clin.MtdFecha().ToString("d");
            string nombre = txt_nombre.Text;
            string nit = txt_nit.Text;
            string telefono = txt_telefono.Text;
            string categoria = txt_categoria.Text;
            string estado = txt_estado.Text;
            string usuario_sistema = "dcruzg11";
            DateTime fecha_sistemanombre = DateTime.Parse(fecha);
            try
            {
                cd_clin.MtdAgregardatos(nombre, nit, telefono, categoria, estado, usuario_sistema, fecha_sistemanombre);
                MessageBox.Show("Datods agregados correctamente a la base de datos", "Proceso realizado correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Mtdmostrardatos();
                MtdBorrardatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex, "A ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}