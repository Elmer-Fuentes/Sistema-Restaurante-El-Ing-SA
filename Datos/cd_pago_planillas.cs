using capa_datos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;


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

		public List<dynamic> MtdListaEmpleados()
		{
			string QueryListaEmpleados = "SELECT codigo_empleado, Nombre FROM tbl_empleados";
			List<dynamic> ListaEmpleados = new List<dynamic>();

			using (SqlConnection connection = GetConnection())
			{
				connection.Open();
				using (SqlCommand cmd = new SqlCommand(QueryListaEmpleados, connection))
				{
					using (SqlDataReader reader = cmd.ExecuteReader())
					{
						while (reader.Read())
						{
							ListaEmpleados.Add(new
							{
								Value = reader["codigo_empleado"],
								Text = $"{reader["codigo_empleado"]} - {reader["Nombre"]}"
							});
						}
					}
				}
			}

			return ListaEmpleados;
		}

		#endregion

		public string MtdListaEmpleadosDgv(int codigo_empleado)
		{
			string resultado = string.Empty;
			string QueryListaEmpleados = "SELECT codigo_empleado, Nombre FROM tbl_empleados WHERE codigo_empleado = @codigo_empleado";

			using (SqlConnection connection = GetConnection())
			{
				connection.Open();
				using (SqlCommand cmd = new SqlCommand(QueryListaEmpleados, connection))
				{
					cmd.Parameters.AddWithValue("@codigo_empleado", codigo_empleado);
					using (SqlDataReader reader = cmd.ExecuteReader())
					{
						if (reader.Read())
						{
							string codigo = reader["codigo_empleado"].ToString();
							string nombre = reader["Nombre"].ToString();
							resultado = $"{codigo} - {nombre}";
						}
					}
				}
			}

			return resultado;
		}


		public decimal MtdSalarioPlanilla(string codigo_empleado)
		{
			decimal salario = 0;

			
			string[] partes = codigo_empleado.Split('-');
			if (partes.Length > 0 && int.TryParse(partes[0].Trim(), out int codigoNumerico))
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


		public void MtdInsPagoPlanillas(int codigo_empleado, DateTime fecha_pago, decimal salario, decimal bono, int horas_extras, decimal monto_total, string estado, string usuario_sistema, DateTime fecha_sistema)
		{
			string query = @"INSERT INTO tbl_pago_planillas (codigo_empleado, fecha_pago, salario, bono, horas_extras, monto_total, estado, usuario_sistema, fecha_sistema)VALUES(@codigo_empleado, @fecha_pago, @salario, @bono, @horas_extras, @monto_total, @estado, @usuario_sistema, @fecha_sistema)";

			using (SqlConnection connection = GetConnection())
			{
				connection.Open();
				using (SqlCommand cmd = new SqlCommand(query, connection))
				{
					cmd.Parameters.AddWithValue("@codigo_empleado", codigo_empleado);
					cmd.Parameters.AddWithValue("@fecha_pago", fecha_pago);
					cmd.Parameters.AddWithValue("@salario", salario);
					cmd.Parameters.AddWithValue("@bono", bono);
					cmd.Parameters.AddWithValue("@horas_extras", horas_extras);
					cmd.Parameters.AddWithValue("@monto_total", monto_total);
					cmd.Parameters.AddWithValue("@estado", estado);
					cmd.Parameters.AddWithValue("@usuario_sistema", usuario_sistema);
					cmd.Parameters.AddWithValue("@fecha_sistema", fecha_sistema);

					cmd.ExecuteNonQuery();
				}
			}
		}
	}
}



















