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
		public DataTable MtdConsultarRentas()
		{
			string QueryConsultarpagoplanillas = "Select * from tbl_pago_planillas;";
			using (SqlConnection connection = GetConnection())
			{
                SqlDataAdapter sqlAdap = new SqlDataAdapter(QueryConsultarpagoplanillas, connection);
                DataTable dtpagoplanillas = new DataTable();
				sqlAdap.Fill(dtpagoplanillas);
				return dtpagoplanillas;
			}
		}
	}
}

