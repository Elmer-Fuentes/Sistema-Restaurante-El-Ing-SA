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
	public class cl_pago_ordenes: Conexion 
	{
		#region MtdMontoOrden

		public decimal MtdMontoOrden(string codigo_encabezado_enc)
		{
			decimal Monto = 0;

			string[] partes = codigo_encabezado_enc.Split('-');
			if (partes.Length > 0 && decimal.TryParse(partes[0].Trim(), out decimal codigoNumerico))
			{
				using (SqlConnection conn = GetConnection())
				{
					string query = "SELECT monto_total_orden FROM tbl_encabezado_ordenes WHERE codigo_orden_enc = @codigo_orden_enc";
					using (SqlCommand cmd = new SqlCommand(query, conn))
					{
						cmd.Parameters.AddWithValue("@codigo_orden_enc", codigoNumerico);
						conn.Open();
						object resultado = cmd.ExecuteScalar();
						if (resultado != null && resultado != DBNull.Value)
						{
							Monto = Convert.ToDecimal(resultado);
						}
					}
				}
			}
			else
			{
				MessageBox.Show("El código de empleado no tiene el formato Correcto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return Monto;
		}
		#endregion

		#region MtdPropinaOrden
		public decimal MtdPropinaOrden(string codigo_encabezado_enc)
		{
			decimal MontoOrden = MtdMontoOrden(codigo_encabezado_enc);
			return Math.Round(MontoOrden * 0.10m, 2);
		}
		#endregion

		#region MtdImpuestoOrden
		public decimal MtdImpuestoOrden(decimal MontoOrden)
		{
			return Math.Round(MontoOrden * 0.12m, 2);
		}
		#endregion

		#region MtdDescuentoOrden
		public decimal MtdDescuentoOrden(decimal MontoOrden, decimal Descuento)
		{
			if (MontoOrden > 0 && MontoOrden <= 100)
			{
				return Math.Round(MontoOrden * 0.02m,2);
			}
			else if (MontoOrden > 100 && MontoOrden <= 300)
			{
				return Math.Round(MontoOrden * 0.03m,2);
			}
			else if (MontoOrden > 300 && MontoOrden <= 500)
			{
				return Math.Round(MontoOrden * 0.04m,2); 
			}
			else if (MontoOrden > 500)
			{
				return Math.Round(MontoOrden * 0.05m,2);
			}
			else
			{
				return 0; 
			}
		}
		#endregion

		#region MtdTotalPago
		public decimal MtdTotalPago(decimal MontoOrden, string codigo_encabezado_enc, decimal Descuento)
		{
			decimal propina = MtdPropinaOrden(codigo_encabezado_enc);
			decimal impuesto = MtdImpuestoOrden(MontoOrden);
			decimal descuento = MtdDescuentoOrden(MontoOrden, Descuento);

			return MontoOrden + propina + impuesto - descuento;
		}
	}

}

#endregion


