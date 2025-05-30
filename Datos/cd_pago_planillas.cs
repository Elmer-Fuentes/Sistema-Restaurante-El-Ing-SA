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
		#region MtdConsultarPagoPlanillas
		public DataTable MtdConsultarPagoPlanillas()
		{
			string query = "SELECT codigo_pago_planilla AS 'Código Pago Planilla', codigo_empleado AS 'Código de Empleado', fecha_pago AS 'Fecha de Pago', salario AS 'Salario', bono AS 'Bono', horas_extras AS 'Horas Extras', monto_total AS 'Monto Total', estado AS 'Estado', usuario_sistema AS 'Usuario Sistema', fecha_sistema AS 'Fecha del Sistema' FROM tbl_pago_planillas;";
			using (SqlConnection connection = GetConnection())
			{
				SqlDataAdapter retornar = new SqlDataAdapter(query, connection);
				DataTable datospagoplanillas = new DataTable();
				retornar.Fill(datospagoplanillas);
				return datospagoplanillas;
			}
		}
		#endregion

		#region MtdListaEmpleados

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

		#region MtdListaEmpleadosDgv
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
		#endregion

		#region MtdInsPagoPlanillas

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
		#endregion

		#region MtdEditarPagoPlanillas
		public void MtdEditarPagoPlanillas(int codigo_pago_planilla, int codigo_empleado, DateTime fecha_pago, decimal salario, decimal bono, int horas_extras, decimal monto_total, string estado, string usuario_sistema, DateTime fecha_sistema)
		{
			string query = @"UPDATE tbl_pago_planillas  SET codigo_empleado = @codigo_empleado, fecha_pago = @fecha_pago, salario = @salario, bono = @bono, horas_extras = @horas_extras, monto_total = @monto_total, estado = @estado, usuario_sistema = @usuario_sistema, fecha_sistema = @fecha_sistema WHERE codigo_pago_planilla = @codigo_pago_planilla";

			using (SqlConnection connection = GetConnection())
			{
				connection.Open();
				using (SqlCommand cmd = new SqlCommand(query, connection))
				{
					cmd.Parameters.AddWithValue("@codigo_pago_planilla", codigo_pago_planilla);
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
		#endregion

		#region MtdEliminarPagoPlanilla
		public void MtdEliminarPagoPlanilla(int codigo_pago_planilla)
		{
			string query = "DELETE FROM tbl_pago_planillas WHERE codigo_pago_planilla = @codigo_pago_planilla";

			using (SqlConnection connection = GetConnection())
			{
				connection.Open();
				using (SqlCommand cmd = new SqlCommand(query, connection))
				{
					cmd.Parameters.AddWithValue("@codigo_pago_planilla", codigo_pago_planilla);
					cmd.ExecuteNonQuery();
				}
			}
		}
	}
		}
#endregion






















