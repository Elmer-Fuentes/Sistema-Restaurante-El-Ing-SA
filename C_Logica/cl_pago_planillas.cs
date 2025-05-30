using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capa_datos;
using Datos;

namespace C_Logica
{
	public class cl_pago_planillas : Conexion
	{
		#region MtdSalarioPlanilla

		public decimal MtdSalarioPlanilla(string codigo_empleado)
		{
			decimal salario = 0;

			string[] partes = codigo_empleado.Split('-');
			if (partes.Length > 0 && decimal.TryParse(partes[0].Trim(), out decimal codigoNumerico))
			{
				using (SqlConnection conn = GetConnection())
				{
					string query = "SELECT salario FROM tbl_empleados WHERE codigo_empleado = @codigo_empleado";
					using (SqlCommand cmd = new SqlCommand(query, conn))
					{
						cmd.Parameters.AddWithValue("@codigo_empleado", codigoNumerico);
						conn.Open();
						object resultado = cmd.ExecuteScalar();
						if (resultado != null && resultado != DBNull.Value)
						{
							salario = Convert.ToDecimal(resultado);
						}
					}
				}
			}
			else
			{
				MessageBox.Show("El código de empleado no tiene el formato Correcto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return salario;
		}
		#endregion

		#region MtdSalarioBono
		public decimal MtdSalarioBono(string codigo_empleado)
		{
			

			decimal  salario = MtdSalarioPlanilla(codigo_empleado);

			decimal bono = salario * 0.10m;

			return bono;
		}

		#endregion

		#region MtdMontoTotal
		public decimal MtdMontoTotal(decimal salario, decimal bono, int horasExtras)
		{
			decimal montoHoras = horasExtras * 15;
			decimal montoTotal = salario + bono + montoHoras;
			return montoTotal;
		}


	}

}

#endregion

