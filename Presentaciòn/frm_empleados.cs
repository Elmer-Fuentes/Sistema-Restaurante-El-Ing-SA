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
using capa_datos;
using Entidades;


namespace Presentaciòn
{

	public partial class frm_empleados : Form
	{
		#region Instancias 
		cd_Empleados datosEmpleados = new cd_Empleados();
		cl_empleados logicaEmpleados = new cl_empleados();
		cl_MtdFechas cl_MtdFechas = new cl_MtdFechas();
		#endregion
		public frm_empleados()
		{
			InitializeComponent();
		}

		private void frm_empleados_Load(object sender, EventArgs e)
		{
			style();
			MtdConsultarEmpleados();
			lblFecha.Text = cl_MtdFechas.MtdFecha().ToString();
		}
		#region MtdConsultarEmpleados()
		public void MtdConsultarEmpleados()
		{
		

			DataTable dtEmpleados = datosEmpleados.MtdConsultarEmpleados();
			dgvEmpleados.DataSource = dtEmpleados;
		}
		#endregion

		#region Mdtstyle
		public void style()
		{
			this.ControlBox = false; // Oculta los botones de la barra de título
			this.FormBorderStyle = FormBorderStyle.None; // Quita los bordes
		}
		#endregion

		#region  Logicacboxcargo
		private void cboxcargo_SelectedIndexChanged(object sender, EventArgs e)
		{
			lbl_salario.Text = logicaEmpleados.MtdSalarioEmpleado(cboxcargo.Text).ToString();
		}
		#endregion

		#region MtdLimpiarCampos
		public void MtdLimpiarCampos()
		{
			txt_codigo_empleado.Text = "";
			txt_Nombre.Text = "";
			cboxcargo.Text = "";
			lbl_salario.Text = "0.00";
			DtpFechaContratacion.Value = DateTime.Now;
			cbox_estado.Text = "";
		}
		#endregion

		#region btnGuardar
		private void btnGuardar_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txt_Nombre.Text) || string.IsNullOrEmpty(cboxcargo.Text) || string.IsNullOrEmpty(lbl_salario.Text) || string.IsNullOrEmpty(cbox_estado.Text))
			{
				MessageBox.Show("Complete todos los datos antes de guardar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			else
			{
				try
				{


					string nombre = txt_Nombre.Text;
					string cargo = cboxcargo.Text;
					decimal salario = decimal.Parse(lbl_salario.Text);
					DateTime fechaContratacion = DtpFechaContratacion.Value;
					string estado = cbox_estado.Text;
					DateTime fecha_sistema = cl_MtdFechas.MtdFecha();
					string usuario_sistema = Mis_Variables.UsuarioLogueado;


					datosEmpleados.MtdInsEmpleado(nombre, cargo, salario, fechaContratacion, estado, usuario_sistema, fecha_sistema);



					MessageBox.Show("Empleado agregado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);


					MtdConsultarEmpleados();
					MtdLimpiarCampos();
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
		#endregion

		#region dgvEmpleados_CellClick
		private void dgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			var FilaSeleccionada = dgvEmpleados.SelectedRows[0];


			if (FilaSeleccionada.Index == dgvEmpleados.Rows.Count - 1)
			{
				MessageBox.Show("Seleccione una fila con datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				txt_codigo_empleado.Text = dgvEmpleados.SelectedCells[0].Value.ToString();
				txt_Nombre.Text = dgvEmpleados.SelectedCells[1].Value.ToString();
				cboxcargo.Text = dgvEmpleados.SelectedCells[2].Value.ToString();
				lbl_salario.Text = dgvEmpleados.SelectedCells[3].Value.ToString();
				DtpFechaContratacion.Text = dgvEmpleados.SelectedCells[4].Value.ToString();
				cbox_estado.Text = dgvEmpleados.SelectedCells[5].Value.ToString();
			}

		}
		#endregion

		#region btnEditar
		private void btnEditar_Click(object sender, EventArgs e)

		{
			if (string.IsNullOrEmpty(txt_codigo_empleado.Text) || string.IsNullOrEmpty(txt_Nombre.Text) || string.IsNullOrEmpty(cboxcargo.Text) || string.IsNullOrEmpty(lbl_salario.Text) || string.IsNullOrEmpty(cbox_estado.Text))
			{
				MessageBox.Show("Favor completar todos los campos del formulario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				try
				{
					int codigoEmpleado = int.Parse(txt_codigo_empleado.Text);
					string nombre = txt_Nombre.Text;
					string cargo = cboxcargo.Text;
					decimal salario = decimal.Parse(lbl_salario.Text);
					DateTime fechaContratacion = DtpFechaContratacion.Value;
					string estado = cbox_estado.Text;
					DateTime fecha_sistema = cl_MtdFechas.MtdFecha();
					string usuario_sistema = Mis_Variables.UsuarioLogueado;

					datosEmpleados.MtdEditarEmpleado(codigoEmpleado, nombre, cargo, salario, fechaContratacion, estado, usuario_sistema, fecha_sistema);

					MessageBox.Show("Empleado editado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);

					MtdConsultarEmpleados();
					MtdLimpiarCampos();
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error al editar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
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
			if (string.IsNullOrEmpty(txt_codigo_empleado.Text))
			{
				MessageBox.Show("Seleccione un empleado para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				try
				{
					int codigoEmpleado = int.Parse(txt_codigo_empleado.Text);

					datosEmpleados.MtdEliminarEmpleado(codigoEmpleado);

					MessageBox.Show("Empleado eliminado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);

					MtdConsultarEmpleados();
					MtdLimpiarCampos();
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
	}
}

#endregion




		

		
