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
    public partial class frm_pago_ordens : Form
    {
        public frm_pago_ordens()
        {
            InitializeComponent();
        }
        #region = "Instancia de las clases";
        Cd_pago_ordenes objPO = new Cd_pago_ordenes();
        cl_MtdFechas cl_fechas = new cl_MtdFechas();
        #endregion

        private void frm_pago_ordens_Load(object sender, EventArgs e)
        {
            MostrarDatos();
            lblFecha.Text = cl_fechas.MtdFecha().ToString("dd/MM/yyyy");
        }

        #region = "Btn_salir";
        private void btnSalir_frm_usuarios_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion;

        #region = "Mostar data en dvg";
        private void MostrarDatos()
        {
         DataTable dt = objPO.MtdConsultarPagoOrden();
            dgvPagoOrdenes.DataSource = dt;
        }

        #endregion

        #region = "Retornar datos dgv a objetos, txt, label, cbx";
        private void dgvPagoOrdenes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_codigo_pago_orden.Text = dgvPagoOrdenes.CurrentRow.Cells[0].Value.ToString();
            cbx_Orden_encabezados.Text= dgvPagoOrdenes.CurrentRow.Cells[1].Value.ToString();
            cbx_monto_orden.Text = dgvPagoOrdenes.CurrentRow.Cells[2].Value.ToString();
            txt_propina.Text = dgvPagoOrdenes.CurrentRow.Cells[3].Value.ToString();
            txt_impuesto.Text = dgvPagoOrdenes.CurrentRow.Cells[4].Value.ToString();
            txt_descuento.Text = dgvPagoOrdenes.CurrentRow.Cells[5].Value.ToString();
            txt_total.Text = dgvPagoOrdenes.CurrentRow.Cells[6].Value.ToString();
            cbx_mtd_pago.Text = dgvPagoOrdenes.CurrentRow.Cells[7].Value.ToString();
            cbx_estado.Text =dgvPagoOrdenes.CurrentRow.Cells[8].Value.ToString();
            dtp_calendario.Text= dgvPagoOrdenes.CurrentRow.Cells[9].Value.ToString();

        }

        #endregion

        #region = "Limpiar datos";
        private void LimpiarDatos()
        {
            txt_codigo_pago_orden.Text = "";
            cbx_Orden_encabezados.Text = "";
            cbx_monto_orden.Text = "";
            txt_propina.Text = "";
            txt_impuesto.Text = "";
            txt_descuento.Text = "";
            txt_total.Text = "";
            cbx_mtd_pago.Text = "";
            cbx_estado.Text = "";
            dtp_calendario.Text = "";

        }
        #endregion

        #region="btn guardar - insertar ";
        private void btnGuardar_Click(object sender, EventArgs e)
        {

            int codigo_Orden_encabezado = int.Parse(cbx_Orden_encabezados.Text);
            double monto_orden = Convert.ToDouble(cbx_monto_orden.Text);
            double propina = double.Parse(txt_propina.Text);
            double impuesto= double.Parse(txt_propina.Text);
            double descuento = double.Parse(txt_descuento.Text);
            double pago_total = double.Parse(txt_total.Text);
            string mtd_pago = cbx_mtd_pago.Text;
            string estado = cbx_estado.Text;
            DateTime fechapago = dtp_calendario.Value;
            string usuario_sistema = Mis_Variables.UsuarioLogueado;
            DateTime fecha_sistemanombre = cl_fechas.MtdFecha();
            try
            {
                objPO.MtdInsPagoOrden(codigo_Orden_encabezado,monto_orden,propina,impuesto,descuento,pago_total,mtd_pago,estado, fechapago, usuario_sistema, fecha_sistemanombre);
                MessageBox.Show("Usuario creado correctamente", "Estado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MostrarDatos();
                LimpiarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex, "A ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #endregion
        }
        #region = "btn cancelar";
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
        }
        #endregion

        #region = "btn_update";
        private void btnEditar_Click(object sender, EventArgs e)
        {
            int codigo_pago = int.Parse(txt_codigo_pago_orden.Text);
            int codigo_Orden_encabezado = int.Parse(cbx_Orden_encabezados.Text);
            double monto_orden = Convert.ToDouble(cbx_monto_orden.Text);
            double propina = double.Parse(txt_propina.Text);
            double impuesto = double.Parse(txt_propina.Text);
            double descuento = double.Parse(txt_descuento.Text);
            double pago_total = double.Parse(txt_total.Text);
            string mtd_pago = cbx_mtd_pago.Text;
            string estado = cbx_estado.Text;
            DateTime fechapago = dtp_calendario.Value;
            string usuario_sistema = Mis_Variables.UsuarioLogueado;
            DateTime fecha_sistemanombre = cl_fechas.MtdFecha();
            try
            {
                objPO.MtdUpdPagoOrden(codigo_pago,codigo_Orden_encabezado, monto_orden, propina, impuesto, descuento, pago_total, mtd_pago, estado, fechapago, usuario_sistema, fecha_sistemanombre);
                MessageBox.Show("Usuario actulizado correctamente", "Estado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MostrarDatos();
                LimpiarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex, "A ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
        #endregion

        private void btnEliminar_usuario_Click(object sender, EventArgs e)
        {

            int codigo_pago = int.Parse(txt_codigo_pago_orden.Text);
            
            try
            {
                objPO.MtdDelPagoOrden(codigo_pago);
                MessageBox.Show("Usuario eliminado correctamente", "Estado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MostrarDatos();
                LimpiarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex, "A ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
