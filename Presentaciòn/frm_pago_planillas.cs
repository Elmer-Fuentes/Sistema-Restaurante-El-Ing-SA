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

		private void btnEditar_Click(object sender, EventArgs e)
		{

		}

		private void btnGuardar_Click(object sender, EventArgs e)
		{

		}

		private void lbl_salario_Click(object sender, EventArgs e)
		{
			
		}

		private void cbox_codigoempleado_SelectedIndexChanged_1(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(cbox_codigoempleado.Text))
			{
				MessageBox.Show("Seleccione una descripcion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				lbl_salario.Text = datosPlanillas.MtdSalarioPlanilla(cbox_codigoempleado.Text).ToString("c");

			}
			lbl_bono.Text = logicaPlanillas.MtdSalarioBono(cbox_codigoempleado.Text).ToString("c");

		}
			
		

		private void txtHorasExtras_TextChanged(object sender, EventArgs e)
		{

		}

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

				decimal salario = datosPlanillas.MtdSalarioPlanilla(cbox_codigoempleado.Text);
				decimal bono = logicaPlanillas.MtdSalarioBono(cbox_codigoempleado.Text);

				decimal montoTotal = logicaPlanillas.MtdMontoTotal(salario, bono, horasExtras);

				lbl_montototal.Text = "Q" + montoTotal.ToString("N2");
			}

		}
		public void  MtdLimpiarCampos()
		{
			cbox_codigoempleado.Text = "";
			DtpFechaPago.Value = DateTime.Now;   
			lbl_salario.Text = "";          
			lbl_bono.Text = "";              
			txtHorasExtras.Text = "";          
			lbl_montototal.Text = "";         
		}


		private void btnGuardar_Click_1(object sender, EventArgs e)
		{
			try
			{
				int codigo_empleado = int.Parse(cbox_codigoempleado.Text);
				DateTime fecha_pago = DtpFechaPago.Value;  
				decimal salario = decimal.Parse(lbl_salario.Text);
				decimal bono = decimal.Parse(lbl_bono.Text);
				int horas_extras = int.Parse(txtHorasExtras.Text);
				decimal monto_total = decimal.Parse(lbl_montototal.Text.Replace("Q", "").Trim()); // Si lo muestras con Q
				string estado = cbox_estado.Text;
				string usuario_sistema = Mis_Variables.UsuarioLogueado;
				DateTime fecha_sistema = logicaPlanillas.MtdFechaHoy();

				datosPlanillas.MtdInsPagoPlanillas(codigo_empleado, fecha_pago, salario, bono, horas_extras, monto_total, estado, usuario_sistema, fecha_sistema);

				MessageBox.Show("Pago registrado correctamente", "Estado", MessageBoxButtons.OK, MessageBoxIcon.Information);

				MtdConsultarPagoPlanillas();  
				MtdLimpiarCampos();     
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message, "Ha ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	

		private void btnSalir_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnCancelar_Click_1(object sender, EventArgs e)
		{
			MtdLimpiarCampos(); 
		}
	}
}




