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
                double precio = Convert.ToDouble(cbx_precioMenu_unitario.Text);

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
    }
}
