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
using System.Windows.Forms;

namespace Presentaciòn
{
	public partial class frm_encabezado_ordenes : Form
	{
		cl_encabezado_ordenes logicaEncabezadoOrdenes = new cl_encabezado_ordenes();
		cd_encabezado_ordenes datosEncabezadoOrdenes = new cd_encabezado_ordenes();


		public frm_encabezado_ordenes()
		{
			InitializeComponent();
		}

		private void frm_encabezado_ordenes_Load(object sender, EventArgs e)
		{
			style();
			lblFecha.Text = logicaEncabezadoOrdenes.MtdFechaHoy().ToString();
			MtdConsultarEncabezadoOrdenes();
			MtdMostrarListaEmpleados();
			MtdMostrarListaClientes();
			MtdMostrarListaMesas();

		}
		public void style()
		{
			this.ControlBox = false; // Oculta los botones de la barra de título
			this.FormBorderStyle = FormBorderStyle.None; // Quita los bordes
		}
		public void MtdConsultarEncabezadoOrdenes()
		{
			
			DataTable dtpOrdenes = datosEncabezadoOrdenes.MtdConsultarEncabezadoOrdenes();
			dgvEncabezadoOrdenes.DataSource = dtpOrdenes;
		}

		private void MtdMostrarListaEmpleados()
		{


			var ListaEmpleados = datosEncabezadoOrdenes.MtdListaEmpleados();

			foreach (var empleados in ListaEmpleados)
			{
				cbox_CodigoEmpleado.Items.Add(empleados);
			}

			cbox_CodigoEmpleado.DisplayMember = "Text";
			cbox_CodigoEmpleado.ValueMember = "Value";
		}
		
		private void MtdMostrarListaClientes()
		{


			var ListaClientes = datosEncabezadoOrdenes.MtdListaClientes();

			foreach (var clientes in ListaClientes)
			{
				cbox_CodigoCliente.Items.Add(clientes);
			}

			cbox_CodigoCliente.DisplayMember = "Text";
			cbox_CodigoCliente.ValueMember = "Value";
		}
		private void MtdMostrarListaMesas()
		{


			var ListaMesas = datosEncabezadoOrdenes.MtdListaMesas();

			foreach (var Mesas in ListaMesas)
			{
				cbox_CodigoMesa.Items.Add(Mesas);
			}

			cbox_CodigoMesa.DisplayMember = "Text";
			cbox_CodigoMesa	.ValueMember = "Value";
		}

		private void btnSalir_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
