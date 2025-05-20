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


namespace Presentaciòn
{

	public partial class frm_empleados : Form
	{
		cd_Empleados datosEmpleados = new cd_Empleados();
		cl_empleados logicaEmpleados = new cl_empleados();
		
		public frm_empleados()
		{
			InitializeComponent();
		}

		private void frm_empleados_Load(object sender, EventArgs e)
		{
			style();
			MtdConsultarEmpleados();
		}
		public void MtdConsultarEmpleados()
		{
		

			DataTable dtEmpleados = datosEmpleados.MtdConsultarEmpleados();
			dgvEmpleados.DataSource = dtEmpleados;
		}

		public void style()
		{
			this.ControlBox = false; // Oculta los botones de la barra de título
			this.FormBorderStyle = FormBorderStyle.None; // Quita los bordes
		}

	}
}
