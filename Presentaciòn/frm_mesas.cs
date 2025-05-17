using C_Logica;
using Datos;
using Entidades;
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string fecha;
            int numero_mesa;
            int cantidad_sillas;
            string ubicacion;
            string tipo_mesa;
            string estado;
            string usuario_sistema;
            DateTime FechaSistema;
            if (txt_NumeroMesa.Text != "" && txt_CantidadSillas.Text != "") // si los texbox tienen datos las variables tomaran los datos ingresados
            {
                fecha = cl_fechas.MtdFecha().ToString("d"); // para que se guarde con formato de fecha corta
                numero_mesa = int.Parse(txt_NumeroMesa.Text);
                cantidad_sillas = int.Parse(txt_CantidadSillas.Text);
                ubicacion = txt_Ubicacion.Text;
                tipo_mesa = cbox_tipomesa.Text;
                estado = txt_estado.Text;
                usuario_sistema = Mis_Variables.UsuarioLogueado;
                FechaSistema = DateTime.Parse(fecha);
            }
            else // si no tomaran valor 0 para evitar errores
            {
                fecha = cl_fechas.MtdFecha().ToString("d"); // para que se guarde con formato de fecha corta
                numero_mesa = 0;
                cantidad_sillas = 0;
                ubicacion = txt_Ubicacion.Text;
                tipo_mesa = cbox_tipomesa.Text;
                estado = txt_estado.Text;
                usuario_sistema = Mis_Variables.UsuarioLogueado;
                FechaSistema = DateTime.Parse(fecha);
            }

            if (!string.IsNullOrWhiteSpace(txt_NumeroMesa.Text) && !string.IsNullOrWhiteSpace(txt_CantidadSillas.Text) && !string.IsNullOrWhiteSpace(txt_Ubicacion.Text) && !string.IsNullOrWhiteSpace(txt_estado.Text) && !string.IsNullOrWhiteSpace(cbox_tipomesa.Text))
            {
                MtdRevisarcamposllenados();

                try
                {
                    cd_Mesas.MtdAgregardatos(numero_mesa, cantidad_sillas, ubicacion, tipo_mesa, estado, usuario_sistema, FechaSistema);
                    MtdRevisarcamposllenados();
                    MtdMostrardatos();
                    MtdLimpiarcampos();
                    MessageBox.Show("Se a registrado correctamente en la base de datos", "Sistema Restaurante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_NumeroMesa.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex, "Sistema Restaurante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else // si los campos de entrada estan en blanco o solo tienen espacios en blanco se pondran en rojo
            {
                MtdRevisarcamposllenados();
                MessageBox.Show("Faltan datos en los campos marcados en rojo", "Sistema Restaurante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        #region cambiar a color rojo los campos que no tengan datos al dar click en el boton agregar

        private void MtdRevisarcamposllenados()
        {
            if (txt_NumeroMesa.Text == "" || txt_NumeroMesa.Text.Contains(" "))
            {
                txt_NumeroMesa.BackColor = Color.Coral;
            }
            else if (txt_NumeroMesa.Text != "" || !txt_NumeroMesa.Text.Contains(" "))
            {
                txt_NumeroMesa.BackColor = Color.White;
            }
            if (txt_CantidadSillas.Text == "" || txt_CantidadSillas.Text.Contains(" "))
            {
                txt_CantidadSillas.BackColor = Color.Coral;
            }
            else if (txt_CantidadSillas.Text != "" || !txt_CantidadSillas.Text.Contains(" "))
            {
                txt_CantidadSillas.BackColor = Color.White;
            }
            if (txt_Ubicacion.Text == "" || txt_Ubicacion.Text.Trim().Length == 0)
            {
                txt_Ubicacion.BackColor = Color.Coral;
            }
            else if (txt_Ubicacion.Text != "" || txt_Ubicacion.Text.Trim().Length != 0)
            {
                txt_Ubicacion.BackColor = Color.White;
            }
            if (cbox_tipomesa.Text == "" || cbox_tipomesa.Text.Contains(" "))
            {
                cbox_tipomesa.BackColor = Color.Coral;
            }
            else if (cbox_tipomesa.Text != "" || !cbox_tipomesa.Text.Contains(" "))
            {
                cbox_tipomesa.BackColor = Color.White;
            }
            if (txt_estado.Text == "" || txt_estado.Text.Contains(" "))
            {
                txt_estado.BackColor = Color.Coral;
            }
            else if (txt_estado.Text != "" || !txt_estado.Text.Contains(" "))
            {
                txt_estado.BackColor = Color.White;
            }
        }

        #endregion cambiar a color rojo los campos que no tengan datos al dar click en el boton agregar

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int codigo;
            string fecha;
            int numero_mesa;
            int cantidad_sillas;
            string ubicacion;
            string tipo_mesa;
            string estado;
            string usuario_sistema;
            DateTime FechaSistema;
            if (txt_NumeroMesa.Text != "" && txt_CantidadSillas.Text != "") // si los texbox tienen datos las variables tomaran los datos ingresados
            {
                codigo = int.Parse(txt_codigoMesa.Text);
                fecha = cl_fechas.MtdFecha().ToString("d"); // para que se guarde con formato de fecha corta
                numero_mesa = int.Parse(txt_NumeroMesa.Text);
                cantidad_sillas = int.Parse(txt_CantidadSillas.Text);
                ubicacion = txt_Ubicacion.Text;
                tipo_mesa = cbox_tipomesa.Text;
                estado = txt_estado.Text;
                usuario_sistema = Mis_Variables.UsuarioLogueado;
                FechaSistema = DateTime.Parse(fecha);
            }
            else // si no tomaran valor 0 para evitar errores
            {
                codigo = int.Parse(txt_codigoMesa.Text);
                fecha = cl_fechas.MtdFecha().ToString("d"); // para que se guarde con formato de fecha corta
                numero_mesa = 0;
                cantidad_sillas = 0;
                ubicacion = txt_Ubicacion.Text;
                tipo_mesa = cbox_tipomesa.Text;
                estado = txt_estado.Text;
                usuario_sistema = Mis_Variables.UsuarioLogueado;
                FechaSistema = DateTime.Parse(fecha);
            }
            if (!string.IsNullOrWhiteSpace(txt_NumeroMesa.Text) && !string.IsNullOrWhiteSpace(txt_CantidadSillas.Text) && !string.IsNullOrWhiteSpace(txt_Ubicacion.Text) && !string.IsNullOrWhiteSpace(txt_estado.Text) && !string.IsNullOrWhiteSpace(cbox_tipomesa.Text))
            {
                MtdRevisarcamposllenados();

                try
                {
                    cd_Mesas.MtdEditar(codigo, numero_mesa, cantidad_sillas, ubicacion, tipo_mesa, estado, usuario_sistema, FechaSistema);
                    MtdRevisarcamposllenados();
                    MtdMostrardatos();
                    MessageBox.Show("Se a registrado correctamente en la base de datos", "Sistema Restaurante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex, "Sistema Restaurante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else // si los campos de entrada estan en blanco o solo tienen espacios en blanco se pondran en rojo
            {
                MtdRevisarcamposllenados();
                MessageBox.Show("Faltan datos en los campos marcados en rojo", "Sistema Restaurante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MtdLimpiarcampos();
        }

        private void MtdLimpiarcampos()
        {
            txt_NumeroMesa.Text = "";
            txt_CantidadSillas.Text = "";
            txt_codigoMesa.Text = "";
            txt_Ubicacion.Text = "";
            txt_estado.Text = "";
            cbox_tipomesa.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(txt_codigoMesa.Text);
            try
            {
                DialogResult r = MessageBox.Show("Esta seguro que de eliminar el registro", "Sistema Restaurante", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (r == DialogResult.Yes)
                {
                    cd_Mesas.MtdEliminarRegistro(codigo);
                    MtdMostrardatos();
                    MtdLimpiarcampos();
                    MessageBox.Show("Se elimino correctamente de la base de datos", "Sistema Restaurante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_NumeroMesa.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccione el registro que decea eliminar " + ex, "Sistema Restaurante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txt_buscarMesas_TextChanged(object sender, EventArgs e)
        {
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string busqueda = cbox_buscarMesas.Text;
            if (!string.IsNullOrWhiteSpace(cbox_buscarMesas.Text))
            {
                lst_historial.Items.Add(cbox_buscarMesas.Text);
                MtdMostrarbusqueda(busqueda);
                cbox_buscarMesas.Text = "";
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            MtdMostrarbusqueda("");
        }

        private void MtdMostrarbusqueda(string busqueda)
        {
            DataTable dt = cd_Mesas.MtdBuscador(busqueda);
            dgv_buscarMesas.DataSource = dt;
        }

        private void lst_historial_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbox_buscarMesas.Text = lst_historial.SelectedItem.ToString();
        }

        private void dgv_buscarMesas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_codigoMesa.Text = dgv_buscarMesas.SelectedCells[0].Value.ToString();
            txt_NumeroMesa.Text = dgv_buscarMesas.SelectedCells[1].Value.ToString();
            txt_CantidadSillas.Text = dgv_buscarMesas.SelectedCells[2].Value.ToString();
            txt_Ubicacion.Text = dgv_buscarMesas.SelectedCells[3].Value.ToString();
            txt_estado.Text = dgv_buscarMesas.SelectedCells[4].Value.ToString();
            cbox_tipomesa.Text = dgv_buscarMesas.SelectedCells[5].Value.ToString();
            tabControl1.SelectedIndex = 0;
        }

        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = cd_Mesas.MtdRetornardatos();
            dgv_buscarMesas.DataSource = dt;
        }
    }
}