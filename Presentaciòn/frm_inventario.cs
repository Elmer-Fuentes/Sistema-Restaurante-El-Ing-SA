using C_Logica;
using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentaciòn
{
    public partial class frm_inventario : Form
    {
        private Cd_Inventario cd_inventario = new Cd_Inventario();
        private cl_MtdFechas fecha = new cl_MtdFechas();
        private CL_Inventario cl_inventario = new CL_Inventario();

        public frm_inventario()
        {
            InitializeComponent();
            style();
            MtdMostrardatos();
            MtdMostrarmenus();
            Mtdmostrarcategoria();

            ToolTip mensaje = new ToolTip();
            mensaje.SetToolTip(btnEliminar, "Eliminar");
            mensaje.SetToolTip(btnSalir, "Cerrar Ventana");
            mensaje.SetToolTip(btn_buscar, "Buscar");
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

        private void MtdMostrarmenus()
        {
            var lista = cd_inventario.MtdRetornarMenus();
            foreach (var items in lista)
            {
                cbox_codigomenu.Items.Add(items);
            }
            cbox_codigomenu.DisplayMember = "Text";
            cbox_codigomenu.ValueMember = "Value";
        }

        private void MtdBorrarcampos()
        {
            nud_Cantidad.Text = "";
            txt_codigoInventario.Text = "";
            cbox_categorias.Text = "";
            cbox_codigomenu.Text = "";
            dtm_fechaentrada.Text = DateTime.Today.ToString("d");
            dtm_fechavencimiento.Text = DateTime.Today.ToString("d");
        }

        private void Mtdmostrarcategoria()
        {
            var lista = cd_inventario.Mtdcategoria();
            foreach (var items in lista)
            {
                cbox_categorias.Items.Add(items);
            }
            cbox_categorias.ValueMember = "Value";
            cbox_categorias.DisplayMember = "Text";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MtdBorrarcampos();
            MtddevolvercolorBlanco();
        }

        #region cambiar color a rojo si se intenta agregar con campos en blanco

        private void Mtdverificarentrada()
        {
            if (string.IsNullOrWhiteSpace(nud_Cantidad.Text) || nud_Cantidad.Value == 0)
            {
                nud_Cantidad.BackColor = Color.LightCoral;
            }

            if (string.IsNullOrWhiteSpace(cbox_categorias.Text))
            {
                cbox_categorias.BackColor = Color.LightCoral;
            }

            if (string.IsNullOrWhiteSpace(cbox_codigomenu.Text))
            {
                cbox_codigomenu.BackColor = Color.LightCoral;
            }
        }

        private void MtddevolvercolorBlanco()
        {
            nud_Cantidad.BackColor = Color.White;
            cbox_categorias.BackColor = Color.White;
            cbox_codigomenu.BackColor = Color.White;
        }

        #endregion cambiar color a rojo si se intenta agregar con campos en blanco

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int codigo_menu;
            string categoria;
            int cantidad;
            //se le da formato de fecha corta
            string fechaentrada = dtm_fechaentrada.Value.ToString("d");
            string fechavencimiento = dtm_fechavencimiento.Value.ToString("d");
            int dias_vigencia;
            string usuario_sistema;
            string Fecha = fecha.MtdFecha().ToString("d");
            Mtdverificarentrada();
            //para realizar una comparacion y evitar que en fecha de entrada se ingrese una fecha mayor a la de el dia actual
            DateTime f = dtm_fechaentrada.Value;
            if (!string.IsNullOrWhiteSpace(cbox_categorias.Text) && !string.IsNullOrWhiteSpace(nud_Cantidad.Text) && !string.IsNullOrWhiteSpace(cbox_codigomenu.Text))
            {
                if (f < fecha.MtdFecha())
                {
                    try
                    {
                        categoria = cbox_categorias.Text;
                        //para obtener solo el numero
                        codigo_menu = int.Parse(cbox_codigomenu.Text.Split('-')[0].Trim());
                        cantidad = int.Parse(nud_Cantidad.Text);
                        DateTime fecha_entrada = DateTime.Parse(fechaentrada);
                        DateTime fecha_vencimiento = DateTime.Parse(fechavencimiento);
                        dias_vigencia = cl_inventario.MtdDiasVigencia(fecha_entrada, fecha_vencimiento);
                        usuario_sistema = Mis_Variables.UsuarioLogueado.ToString();
                        DateTime fecha_sistema = DateTime.Parse(Fecha);

                        if (dias_vigencia <= 0)
                        {
                            DialogResult r = MessageBox.Show("El producto ya esta vencido, Seguro que decea agregarlo a el inventario", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (r == DialogResult.No)
                            {
                                MtdBorrarcampos();
                            }
                            else
                            {
                                cd_inventario.MtdIngresarInventaio(codigo_menu, categoria, cantidad, fecha_entrada, fecha_vencimiento, dias_vigencia, usuario_sistema, fecha_sistema);
                                Mtdverificarentrada();
                                MtdMostrardatos();
                                MessageBox.Show("Se a registrado en el inventario exitosamente", "Sistema Restaurante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                MtdBorrarcampos();
                                MtddevolvercolorBlanco();
                            }
                        }
                        else
                        {
                            cd_inventario.MtdIngresarInventaio(codigo_menu, categoria, cantidad, fecha_entrada, fecha_vencimiento, dias_vigencia, usuario_sistema, fecha_sistema);
                            Mtdverificarentrada();
                            MtdMostrardatos();
                            MessageBox.Show("Se a registrado en el inventario exitosamente", "Sistema Restaurante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MtdBorrarcampos();
                            MtddevolvercolorBlanco();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("A ocurrido un error" + ex, "Sistema Restaurante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (f > fecha.MtdFecha())
                {
                    MessageBox.Show("La fecha de entrada no puede ser mayor a la fecha actual", "Sistema Restaurante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dtm_fechaentrada.Value = fecha.MtdFecha();
                }
            }
            else
            {
                MessageBox.Show("Debe de llenar los campos marcados en rojo", "Sistema Restaurante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDatosPlanilla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_codigoInventario.Text = dgvDatosPlanilla.SelectedCells[0].Value.ToString();
            cbox_categorias.Text = dgvDatosPlanilla.SelectedCells[2].Value.ToString();
            cbox_codigomenu.Text = dgvDatosPlanilla.SelectedCells[1].Value.ToString();
            nud_Cantidad.Text = dgvDatosPlanilla.SelectedCells[3].Value.ToString();
            dtm_fechaentrada.Text = dgvDatosPlanilla.SelectedCells[4].Value.ToString();
            dtm_fechavencimiento.Text = dgvDatosPlanilla.SelectedCells[5].Value.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_codigoInventario.Text))
            {
                int codigo_inventario = int.Parse(txt_codigoInventario.Text);
                int codigo_menu;
                string categoria;
                int cantidad;
                //se le da formato de fecha corta
                string fechaentrada = dtm_fechaentrada.Value.ToString("d");
                string fechavencimiento = dtm_fechavencimiento.Value.ToString("d");
                int dias_vigencia;
                string usuario_sistema;
                string Fecha = fecha.MtdFecha().ToString("d");
                if (!string.IsNullOrWhiteSpace(cbox_codigomenu.Text) && !string.IsNullOrWhiteSpace(cbox_categorias.Text) && !string.IsNullOrWhiteSpace(nud_Cantidad.Text))
                {
                    categoria = cbox_categorias.Text;
                    //para obtener solo el numero
                    codigo_menu = int.Parse(cbox_codigomenu.Text.Split('-')[0].Trim());
                    cantidad = int.Parse(nud_Cantidad.Text);
                    DateTime fecha_entrada = DateTime.Parse(fechaentrada);
                    DateTime fecha_vencimiento = DateTime.Parse(fechavencimiento);
                    dias_vigencia = cl_inventario.MtdDiasVigencia(fecha_entrada, fecha_vencimiento);
                    usuario_sistema = Mis_Variables.UsuarioLogueado.ToString();
                    DateTime fecha_sistema = DateTime.Parse(Fecha);
                    if (fecha_entrada <= fecha_sistema)
                    {
                        try
                        {
                            DialogResult r;
                            if (dias_vigencia <= 0)
                            {
                                r = MessageBox.Show("El producto ya esta vencido, esta seguro de ingresar el cambio?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (r == DialogResult.No)
                                {
                                    MtdBorrarcampos();
                                }
                                else if (r == DialogResult.Yes)
                                {
                                    Mtdverificarentrada();
                                    cd_inventario.Mtdeditar(codigo_inventario, codigo_menu, categoria, cantidad, fecha_entrada, fecha_vencimiento, dias_vigencia, usuario_sistema, fecha_sistema);
                                    MtdMostrardatos();
                                    MessageBox.Show("Se a modificado el inventario exitosamente", "Sistema Restaurante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    MtdBorrarcampos();
                                    MtddevolvercolorBlanco();
                                }
                            }
                            else
                            {
                                Mtdverificarentrada();
                                cd_inventario.Mtdeditar(codigo_inventario, codigo_menu, categoria, cantidad, fecha_entrada, fecha_vencimiento, dias_vigencia, usuario_sistema, fecha_sistema);
                                MtdMostrardatos();
                                MessageBox.Show("Se a modificado el inventario exitosamente", "Sistema Restaurante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                MtdBorrarcampos();
                                MtddevolvercolorBlanco();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("A ocurrido un error" + ex, "Sistema Restaurante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("La fecha de entrada no puede ser mayor a la fecha actual", "Sistema Restaurante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dtm_fechaentrada.Value = fecha.MtdFecha();
                    }
                }
                else
                {
                    Mtdverificarentrada();
                    MessageBox.Show("Debe de ingresar datos en los campos marcados de rojo", "Sistema Restaurante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila", "Sistema Restaurante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_codigoInventario.Text))
            {
                int codigo = int.Parse(txt_codigoInventario.Text);
                try
                {
                    DialogResult r = MessageBox.Show($"Seguro que desea eliminar el registro con codigo: {codigo} de la base de datos", "Sistema Restaurante", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                    {
                        cd_inventario.MtdEliminar(codigo);
                        MtdMostrardatos();
                        MtdBorrarcampos();
                        MtddevolvercolorBlanco();
                        MessageBox.Show("Se a eliminado de la base de datos satisfactoriamente", "Sistema Restaurante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex, "Sistema Restaurante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila", "Sistema Restaurante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
        }

        private bool Mtdmostrarbusqueda()
        {
            bool r;
            DataTable dt = new DataTable();
            string f = dtp_buscarporfechaentrada.Value.ToString("d");
            string f2 = dtp_fechafin.Value.ToString("d");
            DateTime fecha = DateTime.Parse(f);
            DateTime fechafin = DateTime.Parse(f2);
            dt = cd_inventario.MtdBuscarporFentrada(fecha, fechafin);
            dgv_buscarclientes.DataSource = dt;
            if (dt.Rows.Count > 0)
            {
                r = true;
                dgv_buscarclientes.Visible = true;
                pb_foto.Visible = false;
                lbl_realizabusqueda.Visible = false;
            }
            else
            {
                r = false;
                dgv_buscarclientes.Visible = false;
                pb_foto.Visible = true;
                lbl_realizabusqueda.Visible = true;
            }
            return r;
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            bool r = Mtdmostrarbusqueda();
            if (r == false)
            {
                MessageBox.Show("No se encontraron coinsidencias en la base de datos", "Sistema Restaurante", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgv_buscarclientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_codigoInventario.Text = dgv_buscarclientes.SelectedCells[0].Value.ToString();
            cbox_categorias.Text = dgv_buscarclientes.SelectedCells[2].Value.ToString();
            cbox_codigomenu.Text = dgv_buscarclientes.SelectedCells[1].Value.ToString();
            nud_Cantidad.Text = dgv_buscarclientes.SelectedCells[3].Value.ToString();
            dtm_fechaentrada.Text = dgv_buscarclientes.SelectedCells[4].Value.ToString();
            dtm_fechavencimiento.Text = dgv_buscarclientes.SelectedCells[5].Value.ToString();
            tabControl1.SelectedIndex = 0;
        }

        private void cbox_codigomenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbox_codigomenu.Text))
            {
                cbox_codigomenu.BackColor = Color.LightCoral;
            }
            else if (!string.IsNullOrWhiteSpace(cbox_codigomenu.Text))
            {
                cbox_codigomenu.BackColor = Color.White;
            }
        }

        private void cbox_categorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbox_categorias.Text))
            {
                cbox_categorias.BackColor = Color.LightCoral;
            }
            else if (!string.IsNullOrWhiteSpace(cbox_categorias.Text))
            {
                cbox_categorias.BackColor = Color.White;
            }
        }

        private void nud_Cantidad_ValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nud_Cantidad.Text) || nud_Cantidad.Value == 0)
            {
                nud_Cantidad.BackColor = Color.LightCoral;
            }
            else if (!string.IsNullOrWhiteSpace(nud_Cantidad.Text) || nud_Cantidad.Value != 0)
            {
                nud_Cantidad.BackColor = Color.White;
            }
        }

        private void dtp_fechafin_ValueChanged(object sender, EventArgs e)
        {
            if (dtp_buscarporfechaentrada.Value > dtp_fechafin.Value)
            {
                MessageBox.Show("La fecha inicial no puede ser mayor a la fecha final", "Sistema Restaurante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                string f = fecha.MtdFecha().ToString("d"); //para darle formato de fecha corta, y que la hora no afecte
                dtp_fechafin.Value = DateTime.Parse(f);
                dtp_buscarporfechaentrada.Value = DateTime.Parse(f);
            }
        }

        private void dtp_buscarporfechaentrada_ValueChanged(object sender, EventArgs e)
        {
            if (dtp_buscarporfechaentrada.Value > dtp_fechafin.Value)
            {
                MessageBox.Show("La fecha inicial no puede ser mayor a la fecha final", "Sistema Restaurante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                string f = fecha.MtdFecha().ToString("d"); //para darle formato de fecha corta, y que la hora no afecte
                dtp_buscarporfechaentrada.Value = DateTime.Parse(f);
                dtp_fechafin.Value = DateTime.Parse(f);
            }
        }
    }
}