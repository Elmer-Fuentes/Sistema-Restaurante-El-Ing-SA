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
using System.Security.Permissions;

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
            mensaje.SetToolTip(btn_buscar, "Buscar");
            mensaje.SetToolTip(lblFecha, "Fecha de el Sistema");
            lblFecha.Text = cl_clin.MtdFecha().ToString("d");
            tabPage1.Text = "Agregar Cliente";
            tabPage2.Text = "Buscar Cliente";
        }

        public void style()
        {
            this.ControlBox = false; // Oculta los botones de la barra de título
            this.FormBorderStyle = FormBorderStyle.None; // Quita los bordes
            btnCancelar.FlatStyle = FlatStyle.Flat; //quita los bordes a los botones
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
            cbox_categoria.Text = "";
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
            string categoria = cbox_categoria.Text;
            string estado = txt_estado.Text;
            string usuario_sistema = Mis_Variables.UsuarioLogueado;
            DateTime fecha_sistemanombre = DateTime.Parse(fecha);
            if (!string.IsNullOrWhiteSpace(txt_codigoCliente.Text) && !string.IsNullOrWhiteSpace(txt_nombre.Text) && !string.IsNullOrWhiteSpace(txt_nit.Text) && !string.IsNullOrWhiteSpace(txt_telefono.Text) && !string.IsNullOrWhiteSpace(cbox_categoria.Text) && !string.IsNullOrWhiteSpace(txt_estado.Text))

            {
                try
                {
                    cd_clin.MtdEditardatos(codigo, nombre, nit, telefono, categoria, estado, usuario_sistema, fecha_sistemanombre);
                    MessageBox.Show("Datos agregados correctamente a la base de datos", "Proceso realizado correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Mtdmostrardatos();
                    Mtdvalidarentrada();
                    MtdBorrardatos();
                    MtddevolvercolorBlanco();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex, "A ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                Mtdvalidarentrada();
                MessageBox.Show("Debes de ingresar datos en todos los campos", "Sistema Hotel", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            string fecha = cl_clin.MtdFecha().ToString("d");
            string nombre = txt_nombre.Text;
            string nit = txt_nit.Text;
            string telefono = txt_telefono.Text;
            string categoria = cbox_categoria.Text;
            string estado = txt_estado.Text;
            string usuario_sistema = Mis_Variables.UsuarioLogueado;
            DateTime fecha_sistemanombre = DateTime.Parse(fecha);

            if (!string.IsNullOrWhiteSpace(txt_nombre.Text) && !string.IsNullOrWhiteSpace(txt_nit.Text) && !string.IsNullOrWhiteSpace(txt_telefono.Text) && !string.IsNullOrWhiteSpace(cbox_categoria.Text) && !string.IsNullOrWhiteSpace(txt_estado.Text))

            {
                try
                {
                    cd_clin.MtdAgregardatos(nombre, nit, telefono, categoria, estado, usuario_sistema, fecha_sistemanombre);
                    MessageBox.Show("Datos agregados correctamente a la base de datos", "Proceso realizado correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Mtdmostrardatos();
                    Mtdvalidarentrada();
                    MtdBorrardatos();
                    MtddevolvercolorBlanco();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex, "A ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                Mtdvalidarentrada();
                MessageBox.Show("Debe de ingresar datos en los campos marcados en rojo", "Sistema Hotel", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        #region metodoValidar

        private void Mtdvalidarentrada()
        {
            if (string.IsNullOrWhiteSpace(txt_nombre.Text))
            {
                txt_nombre.BackColor = Color.LightCoral;
            }

            if (string.IsNullOrWhiteSpace(txt_nit.Text))
            {
                txt_nit.BackColor = Color.LightCoral;
            }

            if (string.IsNullOrWhiteSpace(txt_telefono.Text))
            {
                txt_telefono.BackColor = Color.LightCoral;
            }

            if (string.IsNullOrWhiteSpace(cbox_categoria.Text))
            {
                cbox_categoria.BackColor = Color.LightCoral;
            }

            if (string.IsNullOrWhiteSpace(txt_estado.Text))
            {
                txt_estado.BackColor = Color.LightCoral;
            }
        }

        private void MtddevolvercolorBlanco()
        {
            txt_nombre.BackColor = Color.White;
            txt_nit.BackColor = Color.White;
            txt_telefono.BackColor = Color.White;
        }

        #endregion metodoValidar

        private void dgvDatosPlanilla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_codigoCliente.Text = dgvDatosPlanilla.SelectedCells[0].Value.ToString();
                txt_nit.Text = dgvDatosPlanilla.SelectedCells[2].Value.ToString();
                txt_nombre.Text = dgvDatosPlanilla.SelectedCells[1].Value.ToString();
                txt_telefono.Text = dgvDatosPlanilla.SelectedCells[3].Value.ToString();
                cbox_categoria.Text = dgvDatosPlanilla.SelectedCells[4].Value.ToString();
                txt_estado.Text = dgvDatosPlanilla.SelectedCells[5].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione una fila", "Sistema Restaurante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            MtdBorrardatos();
            MtddevolvercolorBlanco();
        }

        private void dgvDatosPlanilla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = int.Parse(txt_codigoCliente.Text);
                DialogResult r = MessageBox.Show("Esta seguro que decea eliminar el registro de la base de datos?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (r == DialogResult.OK)
                {
                    cd_clin.MtdEliminar(codigo);
                    MessageBox.Show("Datos eliminado satisfactoriamente de la base de datos", "Proceso realizado correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Mtdmostrardatos();
                    MtdBorrardatos();
                    MtddevolvercolorBlanco();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Selecciona una fila con datos ", "Sistema Restaurante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_nombre.Text))
            {
                txt_nombre.BackColor = Color.White;
            }
            else if (string.IsNullOrWhiteSpace(txt_nombre.Text))
            {
                txt_nombre.BackColor = Color.LightCoral;
            }
        }

        private void txt_nit_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_nit.Text))
            {
                txt_nit.BackColor = Color.White;
            }
            else if (string.IsNullOrWhiteSpace(txt_nit.Text))
            {
                txt_nit.BackColor = Color.LightCoral;
            }
        }

        private void txt_telefono_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_telefono.Text))
            {
                txt_telefono.BackColor = Color.White;
            }
            else if (string.IsNullOrWhiteSpace(txt_telefono.Text))
            {
                txt_telefono.BackColor = Color.LightCoral;
            }
        }

        private void txt_categoria_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt_estado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_estado.Text))
            {
                txt_estado.BackColor = Color.White;
            }
            else if (string.IsNullOrWhiteSpace(txt_estado.Text))
            {
                txt_estado.BackColor = Color.LightCoral;
            }
        }

        private void txt_codigoCliente_TextChanged(object sender, EventArgs e)
        {
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (txt_buscarclientes.Text != "" && !txt_buscarclientes.Text.Contains(" ") && MtdVerificarRetornodedatos() == true)
            {
                lst_historial.Items.Add(txt_buscarclientes.Text);
                txt_buscarclientes.BackColor = Color.White;
                try
                {
                    Mtdmostrarbusquedaclientes(txt_buscarclientes.Text);
                    txt_buscarclientes.Text = "";
                    txt_buscarclientes.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex, "A ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (txt_buscarclientes.Text == "" || txt_buscarclientes.Text.Contains(" "))
            {
                txt_buscarclientes.BackColor = Color.Coral;
                MessageBox.Show("No se puede hacer una busqueda en blanco", "Sistema Restaurante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_buscarclientes.Text = "";
                txt_buscarclientes.Focus();
            }
            else
            {
                MessageBox.Show("No se a encontrado ningun registro con ese nombre", "Sistema Restaurante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lst_historial.Items.Add(txt_buscarclientes.Text);
                txt_buscarclientes.Text = "";
                txt_buscarclientes.Focus();
            }
            lst_historial.Visible = false;
        }

        private void lst_historial_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_buscarclientes.Text = lst_historial.SelectedItem.ToString();
        }

        public void Mtdmostrarbusquedaclientes(string nombre)
        {
            DataTable dt = cd_clin.MtdBuscarclientes(nombre);

            dgv_buscarclientes.DataSource = dt;
        }

        public bool MtdVerificarRetornodedatos()
        {
            DataTable dt = cd_clin.MtdBuscarclientes(txt_buscarclientes.Text);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Mtdmostrarbusquedaclientes("%");
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
        }

        private void dgv_buscarclientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_codigoCliente.Text = dgv_buscarclientes.SelectedCells[0].Value.ToString();
                txt_nit.Text = dgv_buscarclientes.SelectedCells[2].Value.ToString();
                txt_nombre.Text = dgv_buscarclientes.SelectedCells[1].Value.ToString();
                txt_telefono.Text = dgv_buscarclientes.SelectedCells[3].Value.ToString();
                cbox_categoria.Text = dgv_buscarclientes.SelectedCells[4].Value.ToString();
                txt_estado.Text = dgv_buscarclientes.SelectedCells[5].Value.ToString();
                tabControl1.SelectedIndex = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione una fila", "Sistema Restaurante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lst_historial_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (lst_historial.SelectedItem != null)
                {
                    txt_buscarclientes.Text = lst_historial.SelectedItem.ToString();
                }
                else
                {
                    MessageBox.Show("Seleccione una opcion", "Sistema Restaurante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione una opcion", "Sistema Restaurante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            txt_buscarclientes.Focus();
        }

        private void txt_buscarclientes_TextChanged(object sender, EventArgs e)
        {
            lst_historial.Visible = true;
        }

        private void txt_buscarclientes_Click(object sender, EventArgs e)
        {
            lst_historial.Visible = true;
        }

        private void txt_buscarclientes_TextChanged_1(object sender, EventArgs e)
        {
            lst_historial.Visible = true;
        }

        private void cbox_categoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cbox_categoria.Text))
            {
                cbox_categoria.BackColor = Color.White;
            }
            else if (string.IsNullOrWhiteSpace(cbox_categoria.Text))
            {
                cbox_categoria.BackColor = Color.LightCoral;
            }
        }
    }
}