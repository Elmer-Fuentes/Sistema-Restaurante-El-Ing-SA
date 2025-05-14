using capa_datos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Datos
{
	public class cd_pago_planillas : Conexion
	{
		#region = "Metodo para vista del select o mostrar en el dgv";
		public DataTable MtdConsultarPagoPlanillas()
		{
			string query = "select * from tbl_pago_planillas";
			using (SqlConnection connection = GetConnection())
			{
				SqlDataAdapter retornar = new SqlDataAdapter(query, connection);
				DataTable datospagoplanillas = new DataTable();
				retornar.Fill(datospagoplanillas);
				return datospagoplanillas;
			}
		}
		#endregion


		#region = "Metodo para Recuperar codigo empleado en frm_pago_planillas";
		public string MtdSalarioPlanilla(int codigoEmpleado)
		{
			string resultado = string.Empty;
			string query = "Select Salario FROM tbl_Empleados WHERE CodigoEmpleado = @CodigoEmpleado";

			using (SqlConnection connection = GetConnection())
			{
				connection.Open();
				using (SqlCommand cmd = new SqlCommand(query, connection))
				{
					cmd.Parameters.AddWithValue("@CodigoEmpleado", codigoEmpleado);
					SqlDataReader reader = cmd.ExecuteReader();

					if (reader.Read())
					{
						decimal salario = reader.GetDecimal(0);
						resultado = salario.ToString("F2");
					}

					reader.Close();
				}
			}

			return resultado;
		}
		#endregion


	}
}

