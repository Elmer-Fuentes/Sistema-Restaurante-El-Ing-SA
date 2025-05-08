using C_Logica;
using Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;

namespace Presentaciòn
{
	public partial class frm_pago_planillas : Form
	{

		cl_pago_planillas c_logica = new cl_pago_planillas();
		cd_pago_planillas cdplanillas = new cd_pago_planillas();
		cd_pago_planillas cl_planillas = new cd_pago_planillas();
		public frm_pago_planillas()
		{
			InitializeComponent();
		}

		private void frm_pago_planillas_Load(object sender, EventArgs e)
		{
			style();

			MtdConsultarRentas();
		}
		public void MtdConsultarRentas()
		{
			cd_pago_planillas CD_Pago_planillas = new cd_pago_planillas();

			DataTable dtpagoplanillas = CD_Pago_planillas.MtdConsultarRentas();
			dgvPagoPlanillas.DataSource = dtpagoplanillas;
		}
		public void style()
		{
			this.ControlBox = false; // Oculta los botones de la barra de título
			this.FormBorderStyle = FormBorderStyle.None; // Quita los bordes
		}


	}
}

