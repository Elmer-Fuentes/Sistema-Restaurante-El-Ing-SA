using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capa_datos;


namespace Datos
{
	public class cd_Empleados : Conexion
	{
		public DataTable MtdConsultarEmpleados()
		{
			string query = "SELECT codigo_empleado AS 'Código De Empleados', nombre AS 'Nombre', cargo AS 'Cargo', salario AS 'Salario', fecha_contratacion AS 'Fecha Contratacion', estado AS 'Estado',usuario_sistema AS 'Usuario Sistema', fecha_sistema AS 'Fecha del Sistema' FROM tbl_empleados;";
			using (SqlConnection connection = GetConnection())
			{
				SqlDataAdapter retornar = new SqlDataAdapter(query, connection);
				DataTable datosEmpleados = new DataTable();
				retornar.Fill(datosEmpleados);
				return datosEmpleados;
			}
		}
		public void MtdInsEmpleado(string nombre, string cargo, decimal salario, DateTime fecha_contratacion, string estado,string usuario_sistema, DateTime fecha_sistema)
		{
			string query = "INSERT INTO tbl_empleados (nombre, cargo, salario, fecha_contratacion, estado, usuario_sistema, fecha_sistema ) " + "VALUES (@nombre, @cargo, @salario, @fecha_contratacion, @estado,@usuario_sistema,@fecha_sistema)";

			using (SqlConnection connection = GetConnection())
			{
				connection.Open();
				using (SqlCommand Ins = new SqlCommand(query, connection))
				{
					
					Ins.Parameters.AddWithValue("@nombre", nombre);
					Ins.Parameters.AddWithValue("@cargo", cargo);
					Ins.Parameters.AddWithValue("@salario", salario);
					Ins.Parameters.AddWithValue("@fecha_contratacion", fecha_contratacion);
					Ins.Parameters.AddWithValue("@estado", estado);
					Ins.Parameters.AddWithValue("@usuario_sistema", usuario_sistema);
					Ins.Parameters.AddWithValue("@fecha_sistema", fecha_sistema);
					Ins.ExecuteNonQuery();
					
				}
			}
		}

		public void MtdEditarEmpleado(int codigo_empleado, string nombre, string cargo, decimal salario, DateTime fecha_contratacion, string estado, string usuario_sistema, DateTime fecha_sistema)
		{
			string query = "UPDATE tbl_empleados SET nombre = @nombre, cargo = @cargo, salario = @salario, fecha_contratacion = @fecha_contratacion, estado = @estado, usuario_sistema = @usuario_sistema, fecha_sistema = @fecha_sistema WHERE codigo_empleado = @codigo_empleado";

			using (SqlConnection connection = GetConnection())
			{
				connection.Open();
				using (SqlCommand cmd = new SqlCommand(query, connection))
				{
					cmd.Parameters.AddWithValue("@codigo_empleado", codigo_empleado);
					cmd.Parameters.AddWithValue("@nombre", nombre);
					cmd.Parameters.AddWithValue("@cargo", cargo);
					cmd.Parameters.AddWithValue("@salario", salario);
					cmd.Parameters.AddWithValue("@fecha_contratacion", fecha_contratacion);
					cmd.Parameters.AddWithValue("@estado", estado);
					cmd.Parameters.AddWithValue("@usuario_sistema", usuario_sistema);
					cmd.Parameters.AddWithValue("@fecha_sistema", fecha_sistema);

					cmd.ExecuteNonQuery();
				}
			}
		}
		public void MtdEliminarEmpleado(int codigo_empleado)
		{
			string query = "DELETE FROM tbl_empleados WHERE codigo_empleado = @codigo_empleado";

			using (SqlConnection connection = GetConnection())
			{
				connection.Open();
				using (SqlCommand cmd = new SqlCommand(query, connection))
				{
					cmd.Parameters.AddWithValue("@codigo_empleado", codigo_empleado);
					cmd.ExecuteNonQuery();
				}
			}
		}


	}
		



	}

