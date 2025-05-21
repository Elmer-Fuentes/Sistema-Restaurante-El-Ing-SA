using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace C_Logica
{
	public class cl_empleados
	{

		public decimal MtdSalarioEmpleado(string Cargo)
		{
			decimal salario = 0.00m;

			if (Cargo == "Gerente")
			{
				salario = 25000.00m;
			}
			else if (Cargo == "Cocinero")
			{
				salario = 15000.00m;
			}
			else if (Cargo == "Mesero")
			{
				salario = 6000.00m;
			}
			else if (Cargo == "Cajero")
			{
				salario = 7000.00m;
			}
			else if (Cargo == "Bodeguero")
			{
				salario = 7500.00m;
			}

			return salario;
		}
		public DateTime MtdFechaHoy()
		{
			return DateTime.Now;
		}


	}
}
