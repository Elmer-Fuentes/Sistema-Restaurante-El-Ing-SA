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
            string query = "select * from tbl_pago_ordenes";
            using (SqlConnection connection = GetConnection())
            {
                SqlDataAdapter retornar = new SqlDataAdapter(query, connection);
                DataTable datospagoplanillas = new DataTable();
                retornar.Fill(datospagoplanillas);
                return datospagoplanillas;
            }
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

    }
}
