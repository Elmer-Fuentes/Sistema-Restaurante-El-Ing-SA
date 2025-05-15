using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capa_datos;

namespace C_Logica
{
	public class cl_pago_planillas : Conexion
	{
		#region = "Metodos necesarios para frm_pago_planillas";
		public decimal MtdSalarioBono(decimal salario)
		{
			decimal bono = salario * 0.10m;
			return bono;
		}

		public decimal MtdMontoTotal(decimal salario, decimal bono, int horasExtras)
		{
			decimal montoHoras = horasExtras * 15;
			decimal montoTotal = salario + bono + montoHoras;
			return montoTotal;
		}
		public DateTime MtdFechaHoy()
		{
			return DateTime.Now;
		}
	}
}
#endregion

