﻿using C_Logica;
using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentaciòn
{
	public partial class frm_encabezado_ordenes : Form
	{
		#region Instancias 
		cl_encabezado_ordenes logicaEncabezadoOrdenes = new cl_encabezado_ordenes();
		cd_encabezado_ordenes datosEncabezadoOrdenes = new cd_encabezado_ordenes();
		cl_MtdFechas cl_MtdFechas = new cl_MtdFechas();
		#endregion
		public frm_encabezado_ordenes()
		{
			InitializeComponent();
		}

		private void frm_encabezado_ordenes_Load(object sender, EventArgs e)
		{
			style();
			lblFecha.Text = cl_MtdFechas.MtdFecha().ToString();
			MtdConsultarEncabezadoOrdenes();
			MtdMostrarListaEmpleados();
			MtdMostrarListaClientes();
			MtdMostrarListaMesas();
			MtdMostrarOrdenesEncabezado();	

		}
		#region Mtdstyle
		public void style()
		{
			this.ControlBox = false; // Oculta los botones de la barra de título
			this.FormBorderStyle = FormBorderStyle.None; // Quita los bordes
		}
		#endregion

		#region MtdConsultarEncabezadoOrdenes
		public void MtdConsultarEncabezadoOrdenes()
		{
			
			DataTable dtpOrdenes = datosEncabezadoOrdenes.MtdConsultarEncabezadoOrdenes();
			dgvEncabezadoOrdenes.DataSource = dtpOrdenes;
		}
		#endregion

		#region MtdMostrarListaEmpleados
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
		#endregion

		#region MtdMostrarListaClientes
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
		#endregion

		#region MtdMostrarListaMesas 
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
		#endregion

		#region MtdMostrarOrdenesEncabezado
		private void MtdMostrarOrdenesEncabezado()
		{


			var ListaOrdenEncabezado = datosEncabezadoOrdenes.MtdListaOrdenEncabezado();

			foreach (var OrdenEncabezado in ListaOrdenEncabezado)
			{
				cbox_CodigoOrdenEnc.Items.Add(OrdenEncabezado);
			}

			cbox_CodigoOrdenEnc.DisplayMember = "Text";
			cbox_CodigoOrdenEnc.ValueMember = "Value";
		}
		#endregion.

		#region MtdLimpiarCampos

		public void MtdLimpiarCampos()
		{
			cbox_CodigoOrdenEnc.Text = "";
			cbox_CodigoCliente.Text = "";
			cbox_CodigoMesa.Text = "";
			cbox_CodigoEmpleado.Text = "";
			DtpFechaOrden.Value = DateTime.Now;
			lbl_MontoTotal.Text = "0.00";
			cbox_estado.Text = "";
		}
		#endregion

		#region Logica cbox_CodigoOrdenEnc
		private void cbox_CodigoOrdenEnc_SelectedIndexChanged(object sender, EventArgs e)
		{


			lbl_MontoTotal.Text = logicaEncabezadoOrdenes.MtdTotalOrd(cbox_CodigoOrdenEnc.Text).ToString();
		}
		#endregion

		#region btnGuardar
		private void btnGuardar_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(cbox_CodigoOrdenEnc.Text) || string.IsNullOrWhiteSpace(cbox_CodigoCliente.Text) || string.IsNullOrWhiteSpace(cbox_CodigoMesa.Text) || string.IsNullOrWhiteSpace(cbox_CodigoEmpleado.Text) || string.IsNullOrWhiteSpace(lbl_MontoTotal.Text) || string.IsNullOrWhiteSpace(cbox_estado.Text))
			{
				MessageBox.Show("Complete todos los datos antes de guardar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			try
			{

				int codigoCliente = int.Parse(cbox_CodigoCliente.Text.Split('-')[0].Trim());
				int codigoMesa = int.Parse(cbox_CodigoMesa.Text.Split('-')[0].Trim());
				int codigoEmpleado = int.Parse(cbox_CodigoEmpleado.Text.Split('-')[0].Trim());
				DateTime fechaOrden = DtpFechaOrden.Value;
				decimal montoTotalOrden = decimal.Parse(lbl_MontoTotal.Text);
				string estado = cbox_estado.Text;
				string usuarioSistema = Mis_Variables.UsuarioLogueado;
				DateTime fechaSistema = cl_MtdFechas.MtdFecha();


				datosEncabezadoOrdenes.MtdInsertarOrdenEncabezado(codigoCliente, codigoMesa, codigoEmpleado, fechaOrden, montoTotalOrden, estado, usuarioSistema, fechaSistema);

				MessageBox.Show("Orden guardada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

				MtdLimpiarCampos();
				MtdConsultarEncabezadoOrdenes();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Ocurrió un error al guardar la orden: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		#endregion

		#region dgvEncabezadoOrdenes_CellClick

		private void dgvEncabezadoOrdenes_CellClick(object sender, DataGridViewCellEventArgs e)
		{

			var filaSeleccionada = dgvEncabezadoOrdenes.SelectedRows[0];

			if (filaSeleccionada.Index == dgvEncabezadoOrdenes.RowCount - 1)
			{
				MessageBox.Show("Seleccione una fila con datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{

				cbox_CodigoOrdenEnc.Text = dgvEncabezadoOrdenes.SelectedCells[0].Value.ToString();

				int CodigoClente = (int)dgvEncabezadoOrdenes.SelectedCells[1].Value;
				cbox_CodigoCliente.Text = datosEncabezadoOrdenes.MtdListaClientesDgv(CodigoClente);

				int CodigoMesa = (int)dgvEncabezadoOrdenes.SelectedCells[2].Value;
				cbox_CodigoMesa.Text = datosEncabezadoOrdenes.MtdListaMesasDgv(CodigoMesa);

				int CodigoEmpleado = (int)dgvEncabezadoOrdenes.SelectedCells[3].Value;
				cbox_CodigoEmpleado.Text = datosEncabezadoOrdenes.MtdListaEmpleadosDgv(CodigoEmpleado);



				DtpFechaOrden.Text = dgvEncabezadoOrdenes.SelectedCells[4].Value.ToString();
				lbl_MontoTotal.Text = dgvEncabezadoOrdenes.SelectedCells[5].Value.ToString();
				cbox_estado.Text = dgvEncabezadoOrdenes.SelectedCells[6].Value.ToString();
			}
		}
		#endregion

		#region btnEditar
		private void btnEditar_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(cbox_CodigoCliente.Text) || string.IsNullOrWhiteSpace(cbox_CodigoMesa.Text) || string.IsNullOrWhiteSpace(cbox_CodigoEmpleado.Text) || string.IsNullOrWhiteSpace(lbl_MontoTotal.Text))
			{
				MessageBox.Show("Complete todos los datos antes de editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			try
			{
				int codigoOrdenEncabezado = int.Parse(cbox_CodigoOrdenEnc.Text);
				int codigoCliente = int.Parse(cbox_CodigoCliente.Text.Split('-')[0].Trim());
				int codigoMesa = int.Parse(cbox_CodigoMesa.Text.Split('-')[0].Trim());
				int codigoEmpleado = int.Parse(cbox_CodigoEmpleado.Text.Split('-')[0].Trim());
				DateTime fechaOrden = DtpFechaOrden.Value;
				decimal montoTotalOrden = decimal.Parse(lbl_MontoTotal.Text);
				string estado = cbox_estado.Text;
				string usuarioSistema = Mis_Variables.UsuarioLogueado;
				DateTime fechaSistema = cl_MtdFechas.MtdFecha();

				datosEncabezadoOrdenes.MtdEditarOrdenEncabezado(codigoOrdenEncabezado, codigoCliente, codigoMesa, codigoEmpleado, fechaOrden, montoTotalOrden, estado, usuarioSistema, fechaSistema);

				MessageBox.Show("Orden actualizada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
				MtdLimpiarCampos();
				MtdConsultarEncabezadoOrdenes();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Ocurrió un error al actualizar la orden: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		#endregion

		#region btnCancelar
		private void btnCancelar_Click(object sender, EventArgs e)
		{
			MtdLimpiarCampos();
		}
		#endregion

		#region btnSalir
		private void btnSalir_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		#endregion

		#region btnEliminar
		private void btnEliminar_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(cbox_CodigoOrdenEnc.Text))
			{
				MessageBox.Show("Ingrese el código de la orden que desea eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			try
			{
				int codigoOrdenEncabezado = int.Parse(cbox_CodigoOrdenEnc.Text);

				DialogResult confirmacion = MessageBox.Show("¿Está seguro que desea eliminar esta orden? Esta acción no se puede deshacer.", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

				if (confirmacion == DialogResult.Yes)
				{
					datosEncabezadoOrdenes.MtdEliminarOrdenEncabezado(codigoOrdenEncabezado);

					MessageBox.Show("Orden eliminada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
					MtdLimpiarCampos();
					MtdConsultarEncabezadoOrdenes();
				}
			}
			catch (FormatException)
			{

				MessageBox.Show("El código de la orden debe ser un número válido.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			catch (SqlException ex)
			{

				MessageBox.Show("Ocurrió un error al eliminar la orden en la base de datos: " + ex.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			catch (Exception ex)
			{

				MessageBox.Show("Ocurrió un error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}

}

#endregion











