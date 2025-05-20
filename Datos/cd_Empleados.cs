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



	}
}
