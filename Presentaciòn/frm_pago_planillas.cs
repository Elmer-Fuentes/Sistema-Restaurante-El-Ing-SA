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
using C_Logica;
using Datos;
using Entidades;

namespace Presentaciòn
{
	public partial class frm_pago_planillas : Form
	{
		#region Instancias 
		cl_pago_planillas logicaPlanillas = new cl_pago_planillas(); 
		cd_pago_planillas datosPlanillas = new cd_pago_planillas();
		cl_MtdFechas cl_MtdFechas = new cl_MtdFechas();
		#endregion
		public frm_pago_planillas()
		{
			InitializeComponent();
		}

		private void frm_pago_planillas_Load(object sender, EventArgs e)
		{
			style();

			MtdConsultarPagoPlanillas();

			lblFecha.Text = cl_MtdFechas.MtdFecha().ToString();
		
			MtdMostrarListaEmpleados();
			MtdConsultarPagoPlanillas();
		
		}
		#region MtdConsultarPagoPlanillas
		public void MtdConsultarPagoPlanillas()
		{
			

			DataTable dtpagoplanillas = datosPlanillas.MtdConsultarPagoPlanillas();
			dgvPagoPlanillas.DataSource = dtpagoplanillas;
		}
		#endregion

		#region Mtdstyle
		public void style()
		{
			this.ControlBox = false; // Oculta los botones de la barra de título
			this.FormBorderStyle = FormBorderStyle.None; // Quita los bordes
		}
		#endregion

		#region MtdMostrarListaEmpleados
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
		#endregion

		#region Logica cbox_codigoempleado
		private void cbox_codigoempleado_SelectedIndexChanged_1(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(cbox_codigoempleado.Text))
			{
				MessageBox.Show("Seleccione una descripcion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				lbl_salario.Text = logicaPlanillas.MtdSalarioPlanilla(cbox_codigoempleado.Text).ToString("F2");
			}
				lbl_bono.Text = logicaPlanillas.MtdSalarioBono(cbox_codigoempleado.Text).ToString("F2");
			}


		#endregion

		#region Logica txtHorasExtras
		private void textBox1_TextChanged(object sender, EventArgs e)
		{


			if (cbox_codigoempleado.Text == "" || string.IsNullOrWhiteSpace(txtHorasExtras.Text))
			{
				lbl_montototal.Text = "";
			}
			else
			{
				int horasExtras;
				if (!int.TryParse(txtHorasExtras.Text, out horasExtras))
				{
					MessageBox.Show("Por favor, ingresa un número válido de horas extras.");
					txtHorasExtras.Focus();
					return;
				}

				decimal salario = logicaPlanillas.MtdSalarioPlanilla(cbox_codigoempleado.Text);
				decimal bono = logicaPlanillas.MtdSalarioBono(cbox_codigoempleado.Text);

				decimal montoTotal = logicaPlanillas.MtdMontoTotal(salario, bono, horasExtras);

				lbl_montototal.Text =  montoTotal.ToString();
			}

		}
		#endregion

		#region MtdLimpiarCampos
		public void  MtdLimpiarCampos()
		{
			txt_codigo_pago_planilla.Text = "";
			cbox_codigoempleado.Text = "";
			DtpFechaPago.Value = DateTime.Now;   
			lbl_salario.Text = "0.00";          
			lbl_bono.Text = "0.00";              
			txtHorasExtras.Text = "0";          
			lbl_montototal.Text = "0.00";
			cbox_estado.Text = "";
		}
		#endregion

		#region btnGuardar

		private void btnGuardar_Click_1(object sender, EventArgs e)
		{
			
			if (string.IsNullOrWhiteSpace(cbox_codigoempleado.Text) ||string.IsNullOrWhiteSpace(lbl_salario.Text) ||string.IsNullOrWhiteSpace(lbl_bono.Text) ||string.IsNullOrWhiteSpace(lbl_montototal.Text))
			{
				MessageBox.Show("Complete todos los datos antes de guardar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			try
			{
				int codigoEmpleado = int.Parse(cbox_codigoempleado.Text.Split('-')[0].Trim());
				DateTime fechaPago = DtpFechaPago.Value;
				decimal salario = decimal.Parse(lbl_salario.Text);
				decimal bono = decimal.Parse(lbl_bono.Text);
				int horasExtras = int.Parse(txtHorasExtras.Text);
				decimal montoTotal = decimal.Parse(lbl_montototal.Text);
				string estado = cbox_estado.Text;
				string usuario_sistema = Mis_Variables.UsuarioLogueado;
				DateTime fechaSistema = cl_MtdFechas.MtdFecha();

				datosPlanillas.MtdInsPagoPlanillas(codigoEmpleado, fechaPago, salario, bono, horasExtras, montoTotal, estado, usuario_sistema, fechaSistema);

				MessageBox.Show("Pago guardado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
				MtdLimpiarCampos();
				MtdConsultarPagoPlanillas();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Ocurrió un error al guardar el pago: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				
			}

			
		}
		#endregion

		#region dgvPagoPlanillas_CellClick
		private void dgvPagoPlanillas_CellClick(object sender, DataGridViewCellEventArgs e)
		{

			{
				var filaSeleccionada = dgvPagoPlanillas.SelectedRows[0];


				if (filaSeleccionada.Index == dgvPagoPlanillas.RowCount - 1)
				{
					MessageBox.Show("Seleccione una fila con datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
				{

					txt_codigo_pago_planilla.Text = dgvPagoPlanillas.SelectedCells[0].Value.ToString();

					int CodigoEmpleado = (int)dgvPagoPlanillas.SelectedCells[1].Value;
					cbox_codigoempleado.Text = datosPlanillas.MtdListaEmpleadosDgv(CodigoEmpleado);



					DtpFechaPago.Text = dgvPagoPlanillas.SelectedCells[2].Value.ToString();
					lbl_salario.Text = dgvPagoPlanillas.SelectedCells[3].Value.ToString();
					lbl_bono.Text = dgvPagoPlanillas.SelectedCells[4].Value.ToString();
					txtHorasExtras.Text = dgvPagoPlanillas.SelectedCells[5].Value.ToString();
					lbl_montototal.Text = dgvPagoPlanillas.SelectedCells[6].Value.ToString();
					cbox_estado.Text = dgvPagoPlanillas.SelectedCells[7].Value.ToString();

				}

			}
		}

		#endregion

		#region btnEditar
		private void btnEditar_Click_1(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(cbox_codigoempleado.Text) || string.IsNullOrWhiteSpace(lbl_salario.Text) || string.IsNullOrWhiteSpace(lbl_bono.Text) || string.IsNullOrWhiteSpace(lbl_montototal.Text))
			{
				MessageBox.Show("Complete todos los datos antes de editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			try
			{
				int codigo_pago_planilla = int.Parse(txt_codigo_pago_planilla.Text);
				int codigoEmpleado = int.Parse(cbox_codigoempleado.Text.Split('-')[0].Trim());
				DateTime fechaPago = DtpFechaPago.Value;
				decimal salario = decimal.Parse(lbl_salario.Text);
				decimal bono = decimal.Parse(lbl_bono.Text);
				int horasExtras = int.Parse(txtHorasExtras.Text);
				decimal montoTotal = decimal.Parse(lbl_montototal.Text);
				string estado = cbox_estado.Text;
				string usuario_sistema = Mis_Variables.UsuarioLogueado;
				DateTime fechaSistema = cl_MtdFechas.MtdFecha();

				datosPlanillas.MtdEditarPagoPlanillas(codigo_pago_planilla, codigoEmpleado, fechaPago, salario, bono, horasExtras, montoTotal, estado, usuario_sistema, fechaSistema);

				MessageBox.Show("Pago actualizado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
				MtdLimpiarCampos();
				MtdConsultarPagoPlanillas();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Ocurrió un error al actualizar el pago: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		#endregion

		#region btnCancelar
		private void btnCancelar_Click_1(object sender, EventArgs e)
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
			if (string.IsNullOrWhiteSpace(txt_codigo_pago_planilla.Text))
			{
				MessageBox.Show("Seleccione el código de la planilla que desea eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			try
			{
				int codigo_pago_planilla = int.Parse(txt_codigo_pago_planilla.Text);

				
				DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar este pago?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (resultado == DialogResult.Yes)
				{
					datosPlanillas.MtdEliminarPagoPlanilla(codigo_pago_planilla);

					MessageBox.Show("Pago eliminado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
					MtdLimpiarCampos();
					MtdConsultarPagoPlanillas();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Ocurrió un error al eliminar el pago: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		#endregion

		#region .

		private void btnEditar_Click(object sender, EventArgs e)
{
}





private void cbox_codigoempleado_SelectedIndexChanged(object sender, EventArgs e)
{




}

private void btnEliminar_usuario_Click(object sender, EventArgs e)
{

}

private void dgvUsuarios_Click(object sender, EventArgs e)
{

}

private void btnSalir_frm_usuarios_Click(object sender, EventArgs e)
{

}

private void btnCancelar_Click(object sender, EventArgs e)
{

}


private void btnGuardar_Click(object sender, EventArgs e)
{

}

private void lbl_salario_Click(object sender, EventArgs e)
{

}

private void txtHorasExtras_TextChanged(object sender, EventArgs e)
{

}



	}
}
#endregion




