using C_Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Entidades;

namespace Presentaciòn
{
    public partial class frm_detalle_ordenes : Form
    {
        public frm_detalle_ordenes()
        {
            InitializeComponent();
        }
        #region = "Instancia de Clases"
        cd_detalle_ordenes obj = new cd_detalle_ordenes();
        Cl_Detalle_Ordenes objdetalle_ord = new Cl_Detalle_Ordenes();
        cl_MtdFechas cl_fechas = new cl_MtdFechas();
        #endregion

        private void frm_detalle_ordenes_Load(object sender, EventArgs e)
        {
            mostrar_detalle_ordenes_dgv();
            MtdMostrarListaEncabezados_Ordenes();
            Mtd_Mostrar_ListaCodigoMenu();
            MostrarPrecioMenu();
            total_form_detalle_ordenes();
            Fechas();
        }
        #region = "Cargar el sel a dgv";
        public void mostrar_detalle_ordenes_dgv()
        {
            cd_detalle_ordenes obj = new cd_detalle_ordenes();
            dgvdetalleOrdenes.DataSource = obj.MtdConsultarDetalle_Ordenes();
        }
        #endregion

        #region = "Mostar en combobox codigo_orden_pago";
        private void MtdMostrarListaEncabezados_Ordenes()
        {
            var ListaEncabezados_Ordenes = obj.MtdListaEncabezados_Ordenes();

            foreach (var codigo in ListaEncabezados_Ordenes)
            {
                cbx_Orden_encabezados.Items.Add(codigo);
            }

            cbx_Orden_encabezados.DisplayMember = "Text"; //muestra la cadena creada de cd
            cbx_Orden_encabezados.ValueMember = "Value"; // muestra el value que actua como llame primaria en este caso codigo es necesario para evitar separar la cadena ok

        }
        #endregion

        #region = "Mostrar el codigo de menu en cbx form detalle ordenes"; 
        private void Mtd_Mostrar_ListaCodigoMenu()
        {
            var listaMenu = obj.MtdListaMenu();

            cbx_codigo_menu.DisplayMember = "Text"; //muestra en el cbx la cadena creada de cd
            cbx_codigo_menu.ValueMember = "Value"; // actua como llave primaria se pasa a cd el code sin necesidad de separar la cadena
            cbx_codigo_menu.DataSource = listaMenu;  //obtener en cbx_codigo_menu el valor de la listaMenu
            cbx_codigo_menu.SelectedIndex = -1; // Para que no seleccione automáticamente el primer elemento
        }
        #endregion

        #region = "Mostrar el precio del menu en el cbx por medio del Codigo";
        private void MostrarPrecioMenu()
        {
            if (cbx_codigo_menu.SelectedValue != null)
            {
                int codigoMenuSeleccionado = Convert.ToInt32(cbx_codigo_menu.SelectedValue);
                string precioMenu = obj.MtdListaMenuPrecio(codigoMenuSeleccionado);

                cbx_precioMenu_unitario.Text = precioMenu;
            }
            else
            {
                cbx_precioMenu_unitario.Text = string.Empty;
            }
        }
        #endregion

        #region = "Disparar el metodo precio al cambiar el codigo de menu";
        private void cbx_codigo_menu_SelectedIndexChanged(object sender, EventArgs e)
        {

            MostrarPrecioMenu();
            total_form_detalle_ordenes();

        }
        #endregion

        #region = "Total Precio detalle ordenes";
        private void total_form_detalle_ordenes()
        {

            if (txt_cantidad.Text == string.Empty)
            {
                txt_cantidad.Text = "";
            }
            else
            {
                double cantidad = Convert.ToDouble(txt_cantidad.Text);
                double precio;
                if (!double.TryParse(cbx_precioMenu_unitario.Text, out precio))
                {
                    precio = 0.0;  // pasar 0 si no es valido el precio

                }
                string total = objdetalle_ord.Mtd_Total_detalle_ordenes(cantidad, precio);
                txt_precio_total.Text = total.ToString();
            }
        }
        #endregion

        #region = "evento textchange en txt cantidad"
        private void txt_cantidad_TextChanged(object sender, EventArgs e)
        {
            if (txt_cantidad.Text == null || string.IsNullOrEmpty(txt_cantidad.Text))
            {
                txt_cantidad.Text = "0";
            }
            else
            {
                total_form_detalle_ordenes();
            }
        }
        #endregion

        #region = "Devolver valores de dvg a txt, label,ect";
        private void dgvdetalleOrdenes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_codgo_orden_detalle.Text = dgvdetalleOrdenes.SelectedCells[0].Value.ToString();
            cbx_Orden_encabezados.Text = dgvdetalleOrdenes.SelectedCells[1].Value.ToString();
            cbx_codigo_menu.Text = dgvdetalleOrdenes.SelectedCells[2].Value.ToString();
            txt_cantidad.Text = dgvdetalleOrdenes.SelectedCells[3].Value.ToString();
            cbx_precioMenu_unitario.Text = dgvdetalleOrdenes.SelectedCells[4].Value.ToString();
            txt_precio_total.Text = dgvdetalleOrdenes.SelectedCells[5].Value.ToString();
        }
        #endregion

        #region = "Metodo Fechas";
        private void Fechas()
        {
            DateTime fecha = cl_fechas.MtdFecha();
            lblFecha.Text = fecha.ToString("dd/MM/yyyy");
        }

        #endregion

        #region = "btn salir";

        private void btnSalir_frm_usuarios_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region = "Mtd Limpiar";
        public void Limpiardatos()
        {
            txt_codgo_orden_detalle.Text = "";
            cbx_Orden_encabezados.Text = "";
            cbx_codigo_menu.Text = "";
            txt_cantidad.Text = "";
            cbx_precioMenu_unitario.Text = "";
            txt_precio_total.Text = "";

        }
        #endregion

        #region = "Btn Guardar";
        private void btnGuardar_Click(object sender, EventArgs e)
        {

            int codigo_Orden_encabezado = int.Parse(cbx_Orden_encabezados.Text);
            int codigo_Menu = Convert.ToInt32(cbx_codigo_menu.SelectedValue);
            int cantidad = int.Parse(txt_cantidad.Text);
            double precio_unitario = double.Parse(cbx_precioMenu_unitario.Text);
            double precio_total = double.Parse(txt_precio_total.Text);
            string usuario_sistema = Mis_Variables.UsuarioLogueado;
            DateTime fecha_sistemanombre = cl_fechas.MtdFecha();
            try
            {
                obj.MtdIns_detall_ordenes(codigo_Orden_encabezado, codigo_Menu, cantidad, precio_unitario, precio_total, usuario_sistema, fecha_sistemanombre);
                MessageBox.Show("Usuario creado correctamente", "Estado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mostrar_detalle_ordenes_dgv();
                Limpiardatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex, "A ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        #endregion

        #region = "btn cancelar";
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiardatos();
        }
        #endregion

        #region = "btn_update";
        private void btnEditar_Click(object sender, EventArgs e)
        {
            int codigo_Orden_detalle = int.Parse(txt_codgo_orden_detalle.Text);
            int codigo_Orden_encabezado = int.Parse(cbx_Orden_encabezados.Text);
            int codigo_Menu = Convert.ToInt32(cbx_codigo_menu.SelectedValue);
            int cantidad = int.Parse(txt_cantidad.Text);
            double precio_unitario = double.Parse(cbx_precioMenu_unitario.Text);
            double precio_total = double.Parse(txt_precio_total.Text);
            string usuario_sistema = Mis_Variables.UsuarioLogueado;
            DateTime fecha_sistemanombre = cl_fechas.MtdFecha();
            try
            {
                obj.Mtd_Update_detall_ordenes(codigo_Orden_detalle, codigo_Orden_encabezado, codigo_Menu, cantidad, precio_unitario, precio_total, usuario_sistema, fecha_sistemanombre);
                MessageBox.Show("Usuario Actualizado correctamente", "Estado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mostrar_detalle_ordenes_dgv();
                Limpiardatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex, "A ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region = "btn eliminar";
        private void btnEliminar_usuario_Click(object sender, EventArgs e)
        {
            int codigo_Orden_detalle = int.Parse(txt_codgo_orden_detalle.Text);

            try
            {
                obj.Mtd_Delete_detall_ordenes(codigo_Orden_detalle);
                MessageBox.Show("Registro Eliminado correctamente", "Estado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mostrar_detalle_ordenes_dgv();
                Limpiardatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex, "A ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

    }
}
