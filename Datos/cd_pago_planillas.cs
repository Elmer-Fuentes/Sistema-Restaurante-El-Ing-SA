using capa_datos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
	public class cd_pago_planillas
	{
		private Conexion connex = new Conexion();
		public DataTable MtdConsultarRentas()

		{
			string QueryConsultarpagoplanillas = "Select * from tbl_pago_planillas;";
			SqlDataAdapter sqlAdap = new SqlDataAdapter(QueryConsultarpagoplanillas, connex.MtdAbrirconexion());
			DataTable dtpagoplanillas = new DataTable();
			sqlAdap.Fill(dtpagoplanillas);
			return dtpagoplanillas;
			connex.MtdCerrarconexion();



		}
	}
}

