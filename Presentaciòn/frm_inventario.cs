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
    }
}