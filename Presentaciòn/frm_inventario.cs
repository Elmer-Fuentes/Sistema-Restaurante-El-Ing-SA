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
            txt_Cantidad.Text = "";
            txt_codigoInventario.Text = "";
            txt_Categoria.Text = "";
            cbox_codigomenu.Text = "";
            dtm_fechaentrada.Text = DateTime.Today.ToString("d");
            dtm_fechavencimiento.Text = DateTime.Today.ToString("d");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MtdBorrarcampos();
        }

        #region cambiar color a rojo si se intenta agregar con campos en blanco

        private void Mtdverificarentrada()
        {
            if (string.IsNullOrWhiteSpace(txt_Cantidad.Text))
            {
                txt_Cantidad.BackColor = Color.Red;
            }
            else if (!string.IsNullOrWhiteSpace(txt_Cantidad.Text))
            {
                txt_Cantidad.BackColor = Color.White;
            }
            if (string.IsNullOrWhiteSpace(txt_Categoria.Text))
            {
                txt_Categoria.BackColor = Color.Red;
            }
            else if (!string.IsNullOrWhiteSpace(txt_Categoria.Text))
            {
                txt_Categoria.BackColor = Color.White;
            }
            if (string.IsNullOrWhiteSpace(cbox_codigomenu.Text))
            {
                cbox_codigomenu.BackColor = Color.Red;
            }
            else if (!string.IsNullOrWhiteSpace(cbox_codigomenu.Text))
            {
                cbox_codigomenu.BackColor = Color.White;
            }
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
            if (!string.IsNullOrWhiteSpace(txt_Categoria.Text) && !string.IsNullOrWhiteSpace(txt_Cantidad.Text) && !string.IsNullOrWhiteSpace(cbox_codigomenu.Text))
            {
                if (f < fecha.MtdFecha())
                {
                    try
                    {
                        categoria = txt_Categoria.Text;
                        //para obtener solo el numero
                        codigo_menu = int.Parse(cbox_codigomenu.Text.Split('-')[0].Trim());
                        cantidad = int.Parse(txt_Cantidad.Text);
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
                            }
                        }
                        else
                        {
                            cd_inventario.MtdIngresarInventaio(codigo_menu, categoria, cantidad, fecha_entrada, fecha_vencimiento, dias_vigencia, usuario_sistema, fecha_sistema);
                            Mtdverificarentrada();
                            MtdMostrardatos();
                            MessageBox.Show("Se a registrado en el inventario exitosamente", "Sistema Restaurante", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    MtdBorrarcampos();
                }
            }
            else
            {
                MessageBox.Show("Debe de llenar los campos marcados en rojo", "Sistema Restaurante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}