using capa_datos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Logica
{
	public class cl_encabezado_ordenes: Conexion
	{

		#region MtdTotalOrd
		public decimal MtdTotalOrd(string codigo_orden_enc)
		{
			decimal salario = 0;

			string[] partes = codigo_orden_enc .Split(',');
			if (partes.Length > 0 && decimal.TryParse(partes[0].Trim(), out decimal codigoNumerico))
			{
				using (SqlConnection conn = GetConnection())
				{
					string query = "SELECT precio_total FROM tbl_detalles_ordenes WHERE codigo_orden_enc = @codigo_orden_enc";
					using (SqlCommand cmd = new SqlCommand(query, conn))
					{
						cmd.Parameters.AddWithValue("@codigo_orden_enc", codigoNumerico);
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
				MessageBox.Show("El código de Orden Enc  no tiene el formato Correcto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return salario;
		}

	}

}
#endregion

