using capa_datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
	public class cd_encabezado_ordenes : Conexion
	{
		#region = "Metodo para vista del select o mostrar en el dgv";
		public DataTable MtdConsultarEncabezadoOrdenes()
		{
			string query = "SELECT codigo_orden_enc AS 'Código Orden Enc', codigo_cliente AS 'Código de Cliente', codigo_mesa AS 'Código Mesa', codigo_empleado AS 'Código Empleado', fecha_orden AS 'Fecha Órden', monto_total_orden AS 'Monto Total Orden', estado AS 'Estado', usuario_sistema AS 'Usuario Sistema', fecha_sistema AS 'Fecha del Sistema' FROM tbl_encabezado_ordenes;";
			using (SqlConnection connection = GetConnection())
			{
				SqlDataAdapter retornar = new SqlDataAdapter(query, connection);
				DataTable datosOrdenes = new DataTable();
				retornar.Fill(datosOrdenes);
				return datosOrdenes;
			}
		}
		#endregion

		#region  ListaEmpleados
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

		#region ListaClientes
		public List<dynamic> MtdListaClientes()
		{
			string QueryListaClientes = "SELECT codigo_cliente, Nombre FROM tbl_clientes";
			List<dynamic> ListaClientes = new List<dynamic>();

			using (SqlConnection connection = GetConnection())
			{
				connection.Open();
				using (SqlCommand cmd = new SqlCommand(QueryListaClientes, connection))
				{
					using (SqlDataReader reader = cmd.ExecuteReader())
					{
						while (reader.Read())
						{
							ListaClientes.Add(new
							{
								Value = reader["codigo_cliente"],
								Text = $"{reader["codigo_cliente"]} - {reader["Nombre"]}"
							});
						}
					}
				}
			}

			return ListaClientes;
		}



		public string MtdListaClientesDgv(int codigo_cliente)
		{
			string resultado = string.Empty;
			string QueryListaClientes = "SELECT codigo_cliente, Nombre FROM tbl_clientes WHERE codigo_cliente = @codigo_cliente";

			using (SqlConnection connection = GetConnection())
			{
				connection.Open();
				using (SqlCommand cmd = new SqlCommand(QueryListaClientes, connection))
				{
					cmd.Parameters.AddWithValue("@codigo_cliente", codigo_cliente);
					using (SqlDataReader reader = cmd.ExecuteReader())
					{
						if (reader.Read())
						{
							string codigo = reader["codigo_cliente"].ToString();
							string nombre = reader["Nombre"].ToString();
							resultado = $"{codigo} - {nombre}";
						}
					}
				}
			}

			return resultado;
		}
		#endregion

		#region ListaMesas
		public List<dynamic> MtdListaMesas()
		{
			string QueryListaMesas = "SELECT codigo_mesa, numero_mesa FROM tbl_mesas";
			List<dynamic> ListaMesas = new List<dynamic>();

			using (SqlConnection connection = GetConnection())
			{
				connection.Open();
				using (SqlCommand cmd = new SqlCommand(QueryListaMesas, connection))
				{
					using (SqlDataReader reader = cmd.ExecuteReader())
					{
						while (reader.Read())
						{
							ListaMesas.Add(new
							{
								Value = reader["codigo_mesa"],
								Text = $"{reader["codigo_mesa"]} - {reader["numero_mesa"]}"
							});
						}
					}
				}
			}

			return ListaMesas;
		}



		public string MtdListaMesasDgv(int codigo_mesa)
		{
			string resultado = string.Empty;
			string QueryListaClientes = "SELECT codigo_mesa, numero_mesa FROM tbl_mesas WHERE codigo_mesa = @codigo_mesa";

			using (SqlConnection connection = GetConnection())
			{
				connection.Open();
				using (SqlCommand cmd = new SqlCommand(QueryListaClientes, connection))
				{
					cmd.Parameters.AddWithValue("@codigo_mesa", codigo_mesa);
					using (SqlDataReader reader = cmd.ExecuteReader())
					{
						if (reader.Read())
						{
							string codigo = reader["codigo_mesa"].ToString();
							string numero = reader["numero_mesa"].ToString();
							resultado = $"{codigo} - {numero}";
						}
					}
				}
			}

			return resultado;
		}
		#endregion

	}
}
