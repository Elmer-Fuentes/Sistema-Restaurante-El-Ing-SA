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
using C_Logica;
using System.Diagnostics.Eventing.Reader;
using Entidades;

namespace Presentaciòn
{
    public partial class frm_clientes : Form
    {
        private cd_clientes cd_clin = new cd_clientes();
        private cl_MtdFechas cl_clin = new cl_MtdFechas();

        public frm_clientes()
        {
            InitializeComponent();
        }

        private void frm_clientes_Load(object sender, EventArgs e)
        {
            style();
            Mtdmostrardatos();
            ToolTip mensaje = new ToolTip();
            mensaje.SetToolTip(btnSalir, "Salir");
            mensaje.SetToolTip(btnEliminar, "Eliminar");
            lblFecha.Text = cl_clin.MtdFecha().ToString("d");
            tabPage1.Text = "Agregar Cliente";
            tabPage2.Text = "Buscar Cliente";
        }

        public void style()
        {
            this.ControlBox = false; // Oculta los botones de la barra de título
            this.FormBorderStyle = FormBorderStyle.None; // Quita los bordes
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
        }

        private void Mtdmostrardatos()
        {
            cd_clientes cd_clin = new cd_clientes();
            DataTable dt = cd_clin.MtdDevolverdatos();
            dgvDatosPlanilla.DataSource = dt;
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            int codigo = int.Parse(txt_codigoCliente.Text);
            string fecha = cl_clin.MtdFecha().ToString("d");
            string nombre = txt_nombre.Text;
            string nit = txt_nit.Text;
            string telefono = txt_telefono.Text;
            string categoria = txt_categoria.Text;
            string estado = txt_estado.Text;
            string usuario_sistema = Mis_Variables.UsuarioLogueado;
            DateTime fecha_sistemanombre = DateTime.Parse(fecha);
            if (txt_categoria.Text == "" || txt_nombre.Text == "" || txt_nit.Text == "" || txt_telefono.Text == "" || txt_estado.Text == "")

            {
                MessageBox.Show("Debes de ingresar datos en todos los campos", "Sistema Hotel", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Mtdvalidarentrada();
            }
            else
            {
                try
                {
                    cd_clin.MtdEditardatos(codigo, nombre, nit, telefono, categoria, estado, usuario_sistema, fecha_sistemanombre);
                    MessageBox.Show("Datos agregados correctamente a la base de datos", "Proceso realizado correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Mtdmostrardatos();
                    MtdBorrardatos();
                    Mtdvalidarentrada();
                    MtddevolvercoloresO();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex, "A ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            string fecha = cl_clin.MtdFecha().ToString("d");
            string nombre = txt_nombre.Text;
            string nit = txt_nit.Text;
            string telefono = txt_telefono.Text;
            string categoria = txt_categoria.Text;
            string estado = txt_estado.Text;
            string usuario_sistema = Mis_Variables.UsuarioLogueado;
            DateTime fecha_sistemanombre = DateTime.Parse(fecha);

            if (txt_categoria.Text == "" || txt_nombre.Text == "" || txt_nit.Text == "" || txt_telefono.Text == "" || txt_estado.Text == "")

            {
                Mtdvalidarentrada();
                MessageBox.Show("Faltan datos en los campos marcados en rojo", "Sistema Hotel", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                try
                {
                    cd_clin.MtdAgregardatos(nombre, nit, telefono, categoria, estado, usuario_sistema, fecha_sistemanombre);
                    MessageBox.Show("Datos agregados correctamente a la base de datos", "Proceso realizado correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Mtdmostrardatos();
                    MtdBorrardatos();
                    Mtdvalidarentrada();
                    MtddevolvercoloresO();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex, "A ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #region metodoValidar

        public void Mtdvalidarentrada()
        {
            if (txt_categoria.Text == "")
            {
                txt_categoria.BackColor = Color.LightCoral;
            }
            else if (txt_categoria.Text != "")
            {
                txt_categoria.BackColor = Color.White;
            }
            if (txt_nombre.Text == "")
            {
                txt_nombre.BackColor = Color.LightCoral;
            }
            else if (txt_nombre.Text != "")
            {
                txt_nombre.BackColor = Color.White;
            }
            if (txt_nit.Text == "")
            {
                txt_nit.BackColor = Color.LightCoral;
            }
            else if (txt_nit.Text != "")
            {
                txt_nit.BackColor = Color.White;
            }
            if (txt_telefono.Text == "")
            {
                txt_telefono.BackColor = Color.LightCoral;
            }
            else if (txt_telefono.Text != "")
            {
                txt_telefono.BackColor = Color.White;
            }
            if (txt_estado.Text == "")
            {
                txt_estado.BackColor = Color.LightCoral;
            }
            else if (txt_estado.Text != "")
            {
                txt_estado.BackColor = Color.White;
            }
            if (txt_nombre.Text == "" && txt_nit.Text == "" && txt_telefono.Text == "" && txt_categoria.Text == "" && txt_estado.Text == "")
            {
                txt_nombre.BackColor = Color.LightCoral;
                txt_nit.BackColor = Color.LightCoral;
                txt_telefono.BackColor = Color.LightCoral;
                txt_categoria.BackColor = Color.LightCoral;
                txt_estado.BackColor = Color.LightCoral;
            }
            else if (txt_nombre.Text != "" && txt_nit.Text != "" && txt_telefono.Text != "" && txt_categoria.Text != "" && txt_estado.Text != "")
            {
                txt_nombre.BackColor = Color.White;
                txt_nit.BackColor = Color.White;
                txt_telefono.BackColor = Color.White;
                txt_categoria.BackColor = Color.White;
                txt_estado.BackColor = Color.White;
            }
        }

        #endregion metodoValidar

        public void MtddevolvercoloresO()
        {
            txt_nombre.BackColor = Color.White;
            txt_nit.BackColor = Color.White;
            txt_telefono.BackColor = Color.White;
            txt_categoria.BackColor = Color.White;
            txt_estado.BackColor = Color.White;
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

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            MtdBorrardatos();
        }

        private void dgvDatosPlanilla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(txt_codigoCliente.Text);
            try
            {
                DialogResult r = MessageBox.Show("Esta seguro que decea eliminar el registro de la base de datos?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (r == DialogResult.OK)
                {
                    cd_clin.MtdEliminar(codigo);
                    MessageBox.Show("Datos eliminado satisfactoriamente de la base de datos", "Proceso realizado correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Mtdmostrardatos();
                    MtdBorrardatos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "A ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt_nit_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt_telefono_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt_categoria_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt_estado_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void txt_codigoCliente_TextChanged(object sender, EventArgs e)
        {
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (txt_buscarclientes.Text != "" && txt_buscarclientes.Text != " ")
            {
                lst_historial.Items.Add(txt_buscarclientes.Text);
                txt_buscarclientes.Clear();
                lst_historial.Focus();
            }
            try
            {
                Mtdmostrarbusquedaclientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "A ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lst_historial_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_buscarclientes.Text = lst_historial.SelectedItem.ToString();
        }

        public void Mtdmostrarbusquedaclientes()
        {
            string nombre = txt_buscarclientes.Text;
            DataTable dt = cd_clin.MtdBuscarclientes(nombre);
            dgv_buscarclientes.DataSource = dt;
        }
    }
}