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
    public partial class frm_pago_ordens : Form
    {
        public frm_pago_ordens()
        {
            InitializeComponent();
        }
        #region = "Instancia de las clases";
        Cd_pago_ordenes objPO = new Cd_pago_ordenes();
        #endregion

        private void frm_pago_ordens_Load(object sender, EventArgs e)
        {
            MostrarDatos();
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
    }
}
