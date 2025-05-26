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
        cl_pago_ordenes logicapagoordenes = new cl_pago_ordenes();
        #endregion

        private void frm_pago_ordens_Load(object sender, EventArgs e)
        {
            MostrarDatos();
            lblFecha.Text = cl_fechas.MtdFecha().ToString("dd/MM/yyyy");
            MtdMostrarListaEncabezados();

		}

		#region MtdMostrarListaEncabezados
		private void MtdMostrarListaEncabezados()
		{


			var ListaEncabezados = objPO.MtdListaEncabezados();

			foreach (var Encabezados in ListaEncabezados)
			{
				cbx_Orden_encabezados.Items.Add(Encabezados);
			}

			cbx_Orden_encabezados.DisplayMember = "Text";
			cbx_Orden_encabezados.ValueMember = "Value";
		}
		#endregion

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



			var filaSeleccionada = dgvPagoOrdenes.SelectedRows[0];

			if (filaSeleccionada.Index == dgvPagoOrdenes.RowCount - 1)
			{
				MessageBox.Show("Seleccione una fila con datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				txt_codigo_pago_orden.Text = dgvPagoOrdenes.SelectedCells[0].Value.ToString();
				cbx_Orden_encabezados.Text = dgvPagoOrdenes.SelectedCells[1].Value.ToString();
				lbl_MontoOrden.Text = dgvPagoOrdenes.SelectedCells[2].Value.ToString();
				lbl_Propina.Text = dgvPagoOrdenes.SelectedCells[3].Value.ToString();
				lbl_Impuesto.Text = dgvPagoOrdenes.SelectedCells[4].Value.ToString();
				lbl_Descuento.Text = dgvPagoOrdenes.SelectedCells[5].Value.ToString();
				lbl_TotalPago.Text = dgvPagoOrdenes.SelectedCells[6].Value.ToString();
				cbx_mtd_pago.Text = dgvPagoOrdenes.SelectedCells[7].Value.ToString();
				cbx_estado.Text = dgvPagoOrdenes.SelectedCells[8].Value.ToString();
				DtpFechaPago.Text = dgvPagoOrdenes.SelectedCells[9].Value.ToString();
			}

		}

        #endregion

        #region = "Limpiar datos";
        private void LimpiarDatos()
        {
            txt_codigo_pago_orden.Text = "";
            cbx_Orden_encabezados.Text = "";
			lbl_MontoOrden.Text = "0.00";
			lbl_Propina.Text = "0.00";
			lbl_Impuesto.Text = "0.00";
			lbl_Descuento.Text = "0.00";
			lbl_TotalPago.Text = "0.00";
            cbx_mtd_pago.Text = "";
            cbx_estado.Text = "";
			DtpFechaPago.Text = "";

        }
        #endregion

        #region="btn guardar - insertar ";
        private void btnGuardar_Click(object sender, EventArgs e)
        {

			if (string.IsNullOrWhiteSpace(cbx_Orden_encabezados.Text) ||string.IsNullOrWhiteSpace(lbl_MontoOrden.Text) ||string.IsNullOrWhiteSpace(lbl_Propina.Text) ||string.IsNullOrWhiteSpace(lbl_Impuesto.Text) ||string.IsNullOrWhiteSpace(lbl_Descuento.Text) ||string.IsNullOrWhiteSpace(lbl_TotalPago.Text) ||string.IsNullOrWhiteSpace(cbx_mtd_pago.Text) ||string.IsNullOrWhiteSpace(cbx_estado.Text))
			{
				MessageBox.Show("Complete todos los datos antes de guardar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			try
			{
				int codigo_orden_enc = int.Parse(cbx_Orden_encabezados.Text);
				double monto_orden = Convert.ToDouble(lbl_MontoOrden.Text);
				double propina = double.Parse(lbl_Propina.Text);
				double impuesto = double.Parse(lbl_Impuesto.Text);
				double descuento = double.Parse(lbl_Descuento.Text);
				double total_pago = double.Parse(lbl_TotalPago.Text);
				string metodo_pago = cbx_mtd_pago.Text;
				string estado = cbx_estado.Text;
				DateTime fecha_pago = DtpFechaPago.Value;
				string usuario_sistema = Mis_Variables.UsuarioLogueado;
				DateTime fecha_sistema = cl_fechas.MtdFecha();

				objPO.MtdInsPagoOrden(codigo_orden_enc, monto_orden, propina, impuesto, descuento,total_pago,metodo_pago, estado, fecha_pago,usuario_sistema, fecha_sistema);

				MessageBox.Show("Orden guardada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

				LimpiarDatos();
				MostrarDatos();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Ocurrió un error al guardar la orden: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		#endregion

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
            double monto_orden = Convert.ToDouble(lbl_MontoOrden.Text);
            double propina = double.Parse(lbl_Propina.Text);
            double impuesto = double.Parse(lbl_Impuesto.Text);
            double descuento = double.Parse(lbl_Descuento.Text);
            double pago_total = double.Parse(lbl_TotalPago.Text);
            string mtd_pago = cbx_mtd_pago.Text;
            string estado = cbx_estado.Text;
            DateTime fechapago = DtpFechaPago.Value;
            string usuario_sistema = Mis_Variables.UsuarioLogueado;
            DateTime fecha_sistemanombre = cl_fechas.MtdFecha();
            try
            {
                objPO.MtdUpdPagoOrden(codigo_pago,codigo_Orden_encabezado, monto_orden, propina, impuesto, descuento, pago_total, mtd_pago, estado, fechapago, usuario_sistema, fecha_sistemanombre);
                MessageBox.Show("Pago actulizado correctamente", "Estado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MostrarDatos();
                LimpiarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex, "A ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
        #endregion

        #region = "btn Eliminar";
        private void btnEliminar_usuario_Click(object sender, EventArgs e)
        {

            int codigo_pago = int.Parse(txt_codigo_pago_orden.Text);
            
            try
            {
                objPO.MtdDelPagoOrden(codigo_pago);
                MessageBox.Show("Pago eliminado correctamente", "Estado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MostrarDatos();
                LimpiarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex, "A ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
		#endregion

		#region Logica cbx_Orden_encabezados
		private void cbx_Orden_encabezados_SelectedIndexChanged(object sender, EventArgs e)
		{
			string codigoEncabezadoEnc = cbx_Orden_encabezados.Text;
			decimal Descuento = 0;

			decimal montoOrden = logicapagoordenes.MtdMontoOrden(codigoEncabezadoEnc);

			Descuento = logicapagoordenes.MtdDescuentoOrden(montoOrden, Descuento);

			
			lbl_MontoOrden.Text = montoOrden.ToString();
			lbl_Propina.Text = logicapagoordenes.MtdPropinaOrden(codigoEncabezadoEnc).ToString();
			lbl_Impuesto.Text = logicapagoordenes.MtdImpuestoOrden(montoOrden).ToString();
			lbl_Descuento.Text = Descuento.ToString();
			lbl_TotalPago.Text = logicapagoordenes.MtdTotalPago(montoOrden, codigoEncabezadoEnc, Descuento).ToString();
		}
	}
}
#endregion