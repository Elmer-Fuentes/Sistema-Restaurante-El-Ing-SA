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
    public class Cd_pago_ordenes : Conexion
    {
        #region = "Metodo para vista del select o mostrar en el dgv";
        public DataTable MtdConsultarPagoOrden()
        {
			string query = @"SELECT codigo_pago AS 'Código Pago', codigo_orden_enc AS 'Código Orden Enc', monto_orden AS 'Monto Orden',propina AS 'Propina', impuesto AS 'Impuesto', descuento AS 'Descuento',total_pago AS 'Total Pago',metodo_pago AS 'Método Pago',estado AS 'Estado',fecha_pago AS 'Fecha Pago',usuario_sistema AS 'Usuario Sistema',fecha_sistema AS 'Fecha Sistema'FROM tbl_pago_ordenes";

			using (SqlConnection connection = GetConnection())
			{
				SqlDataAdapter retornar = new SqlDataAdapter(query, connection);
				DataTable datospagoordenes = new DataTable();
				retornar.Fill(datospagoordenes);
				return datospagoordenes;
			}
        }
		#endregion

		#region Metodo para Mostrar Lista
		public List<dynamic> MtdListaEncabezados()
		{
			string QueryListaEncabezados = "SELECT codigo_orden_enc FROM tbl_encabezado_ordenes";
            List<dynamic> ListaEncabezados = new List<dynamic>();
			using (SqlConnection connection = GetConnection())
			{
				connection.Open();
				using (SqlCommand cmd = new SqlCommand(QueryListaEncabezados, connection))
				{
					using (SqlDataReader reader = cmd.ExecuteReader())
					{
						while (reader.Read())
						{
							ListaEncabezados.Add(new
                            {
                                Value = reader["codigo_orden_enc"],
                                Text = $"{reader["codigo_orden_enc"]}"
                            });
						}
					}
				}
			}

			return ListaEncabezados;
		}

		

		public string MtdListaEncabezadosDgv(int codigo_orden_enc)
		{
			string resultado = string.Empty;
			string QueryListaEncabezados = "SELECT codigo_orden_enc FROM tbl_encabezado_ordenes WHERE codigo_orden_enc = @codigo_orden_enc";

			using (SqlConnection connection = GetConnection())
			{
				connection.Open();
				using (SqlCommand cmd = new SqlCommand(QueryListaEncabezados, connection))
				{
					cmd.Parameters.AddWithValue("@codigo_orden_enc", codigo_orden_enc);
					using (SqlDataReader reader = cmd.ExecuteReader())
					{
						if (reader.Read())
						{
							string codigo = reader["codigo_orden_enc"].ToString();
							resultado = $"{codigo}";
						}
					}
				}
			}

			return resultado;
		}
#endregion

		#region = "Met_Insert_pago_ordeb";
		public void MtdInsPagoOrden(int codigo_orden_enc, double monto_orden, double propina, double impuesto, double descuento, double total_pago, string metodo_pago, string estado, DateTime fecha_pago, string usuario_sistema, DateTime fecha_sistema)
        {
            string query = "Insert into tbl_pago_ordenes (codigo_orden_enc,monto_orden,propina,impuesto,descuento,total_pago,metodo_pago,estado,fecha_pago,usuario_sistema,fecha_sistema) values (@codigo_orden_enc,@monto_orden,@propina,@impuesto,@descuento,@total_pago,@metodo_pago,@estado,@fecha_pago,@usuario_sistema,@fecha_sistema)";

            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@codigo_orden_enc", codigo_orden_enc);
                    cmd.Parameters.AddWithValue("@monto_orden", monto_orden);
                    cmd.Parameters.AddWithValue("@propina", propina);
                    cmd.Parameters.AddWithValue("@impuesto", impuesto);
                    cmd.Parameters.AddWithValue("@descuento", descuento);
                    cmd.Parameters.AddWithValue("@total_pago", total_pago);
                    cmd.Parameters.AddWithValue("@metodo_pago", metodo_pago);
                    cmd.Parameters.AddWithValue("@estado", estado);
                    cmd.Parameters.AddWithValue("@fecha_pago", fecha_pago);
                    cmd.Parameters.AddWithValue("@usuario_sistema", usuario_sistema);
                    cmd.Parameters.AddWithValue("@fecha_sistema", fecha_sistema);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        #endregion
        
        #region = "Met_Actualizar_pago_ordeb";
        public void MtdUpdPagoOrden(int codigo_pago,int codigo_orden_enc, double monto_orden, double propina, double impuesto, double descuento, double total_pago, string metodo_pago, string estado, DateTime fecha_pago, string usuario_sistema, DateTime fecha_sistema)
        {
            string query = "update tbl_pago_ordenes set codigo_orden_enc = @codigo_orden_enc, monto_orden = @monto_orden, propina = @propina, impuesto = @impuesto, descuento = @descuento, total_pago = @total_pago, metodo_pago = @metodo_pago, estado = @estado, fecha_pago = @fecha_pago, usuario_sistema = @usuario_sistema, fecha_sistema = @fecha_sistema WHERE codigo_pago = @codigo_pago";

            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@codigo_pago", codigo_pago);
                    cmd.Parameters.AddWithValue("@codigo_orden_enc", codigo_orden_enc);
                    cmd.Parameters.AddWithValue("@monto_orden", monto_orden);
                    cmd.Parameters.AddWithValue("@propina", propina);
                    cmd.Parameters.AddWithValue("@impuesto", impuesto);
                    cmd.Parameters.AddWithValue("@descuento", descuento);
                    cmd.Parameters.AddWithValue("@total_pago", total_pago);
                    cmd.Parameters.AddWithValue("@metodo_pago", metodo_pago);
                    cmd.Parameters.AddWithValue("@estado", estado);
                    cmd.Parameters.AddWithValue("@fecha_pago", fecha_pago);
                    cmd.Parameters.AddWithValue("@usuario_sistema", usuario_sistema);
                    cmd.Parameters.AddWithValue("@fecha_sistema", fecha_sistema);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        #endregion



        #region = "Met_Actualizar_pago_ordeb";
        public void MtdDelPagoOrden(int codigo_pago)
        {
            string query = "Delete tbl_pago_ordenes WHERE codigo_pago = @codigo_pago";

            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@codigo_pago", codigo_pago);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        #endregion
    }
}
