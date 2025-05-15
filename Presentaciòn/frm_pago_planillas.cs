using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C_Logica;
using Datos;

namespace Presentaciòn
{
	public partial class frm_pago_planillas : Form
	{

		cl_pago_planillas logicaPlanillas = new cl_pago_planillas(); 
		cd_pago_planillas datosPlanillas = new cd_pago_planillas(); 
		public frm_pago_planillas()
		{
			InitializeComponent();
		}

		private void frm_pago_planillas_Load(object sender, EventArgs e)
		{
			style();

			MtdConsultarPagoPlanillas();

			lblFecha.Text = logicaPlanillas.MtdFechaHoy().ToString();
		
			MtdMostrarListaEmpleados();
			MtdConsultarPagoPlanillas();




		}
		public void MtdConsultarPagoPlanillas()
		{
			cd_pago_planillas CD_Pago_planillas = new cd_pago_planillas();

			DataTable dtpagoplanillas = CD_Pago_planillas.MtdConsultarPagoPlanillas();
			dgvPagoPlanillas.DataSource = dtpagoplanillas;
		}
		public void style()
		{
			this.ControlBox = false; // Oculta los botones de la barra de título
			this.FormBorderStyle = FormBorderStyle.None; // Quita los bordes
		}
		private void MtdMostrarListaEmpleados()
		{
			

			var ListaEmpleados = datosPlanillas.MtdListaEmpleados();

			foreach (var empleados in ListaEmpleados)
			{
				cbox_codigoempleado.Items.Add(empleados);
			}

			cbox_codigoempleado.DisplayMember = "Text";
			cbox_codigoempleado.ValueMember = "Value";
		}

		private void cbox_codigoempleado_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(cbox_codigoempleado.Text))
			{
				MessageBox.Show("Seleccione un Empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				int codigoEmpleado;
				DateTime fecha_pago;

				if (int.TryParse(cbox_codigoempleado.Text, out codigoEmpleado) && DateTime.TryParse(DtpFechaPago.Text, out fecha_pago))
				{
					lbl_salario.Text = datosPlanillas.MtdSalarioPlanilla(codigoEmpleado, fecha_pago).ToString("c");
				}
				else
				{
					MessageBox.Show("El código de empleado o la fecha de pago no son válidos.");
				}
			}
		}
	}
}



