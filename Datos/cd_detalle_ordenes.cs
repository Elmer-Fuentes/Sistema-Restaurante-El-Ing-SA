using capa_datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Logica
{
    public class cd_detalle_ordenes : Conexion
    {
        #region = "Metodo para vista del select o mostrar en el dgv";
        public DataTable MtdConsultarDetalle_Ordenes()
        {
            string query = "select * from tbl_detalles_ordenes";
            using (SqlConnection connection = GetConnection())
            {
                SqlDataAdapter retornar = new SqlDataAdapter(query, connection);
                DataTable datosdetallOrdenes = new DataTable();
                retornar.Fill(datosdetallOrdenes);
                return datosdetallOrdenes;
            }
        }
        #endregion

        #region = "Metodo para obtener Codigo Encabezado Ordenes";

        public List<dynamic> MtdListaEncabezados_Ordenes()
        {
            string QueryListaEncabezados_Ordenes = "select codigo_orden_enc from tbl_encabezado_ordenes";
            List<dynamic> ListaEncabezados_Ordenes = new List<dynamic>();

            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(QueryListaEncabezados_Ordenes, connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ListaEncabezados_Ordenes.Add(new
                            {
                                Value = reader["codigo_orden_enc"],
                                Text = $"{reader["codigo_orden_enc"]}"
                            });
                        }
                    }
                }
            }

            return ListaEncabezados_Ordenes;
        }

        #endregion

        #region = "Metodo para obtener Codigo Menu";

        public List<dynamic> MtdListaMenu()
        {
            string QueryListaMenu = "select codigo_menu, nombre from tbl_menus";
            List<dynamic> ListaMenu = new List<dynamic>();

            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(QueryListaMenu, connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ListaMenu.Add(new
                            {
                                Value = reader["codigo_menu"],
                                Text = $"{reader["codigo_menu"]} - {reader["Nombre"]}"
                            });
                        }
                    }
                }
            }

            return ListaMenu;
        }
        #endregion

        #region = "Metodo para obtener Precio Menu";

        public string MtdListaMenuPrecio(int codigo_menu)
        {
            string res = string.Empty;
            string QueryMenu = "SELECT precio FROM tbl_menus WHERE codigo_menu = @codigo_menu";

            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(QueryMenu, connection))
                {
                    cmd.Parameters.AddWithValue("@codigo_menu", codigo_menu);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            res = Convert.ToString(reader["precio"]);
                        }
                    }
                }
            }

            return res;
        }
        #endregion

        #region = "Agregar data a tbl_detalles_ordenes";
        public void MtdIns_detall_ordenes(int codigo_orden_enc, int codigo_menu, int cantidad, double precio_unitario, double precio_total, string usuario_sistema, DateTime fecha_sistema)
        {
            string query = "insert into tbl_detalles_ordenes(codigo_orden_enc,codigo_menu,cantidad,precio_unitario,precio_total,usuario_sistema,fecha_sistema) values (@codigo_orden_enc,@codigo_menu,@cantidad,@precio_unitario,@precio_total,@usuario_sistema,@fecha_sistema)";
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand ins_Usuario = new SqlCommand(query, connection))
                {
                    ins_Usuario.Parameters.AddWithValue("@codigo_orden_enc", codigo_orden_enc);
                    ins_Usuario.Parameters.AddWithValue("@codigo_menu", codigo_menu);
                    ins_Usuario.Parameters.AddWithValue("@cantidad", cantidad);
                    ins_Usuario.Parameters.AddWithValue("@precio_unitario", precio_unitario);
                    ins_Usuario.Parameters.AddWithValue("@precio_total", precio_total);
                    ins_Usuario.Parameters.AddWithValue("@usuario_sistema", usuario_sistema);
                    ins_Usuario.Parameters.AddWithValue("@fecha_sistema", fecha_sistema);
                    ins_Usuario.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region = "Update data a tbl_detalles_ordenes";
        public void Mtd_Update_detall_ordenes(int codigo_orden_det, int codigo_orden_enc, int codigo_menu, int cantidad, double precio_unitario, double precio_total, string usuario_sistema, DateTime fecha_sistema)
        {
            string query = "Update tbl_detalles_ordenes set codigo_orden_enc = @codigo_orden_enc,codigo_menu = @codigo_menu,cantidad= @cantidad,precio_unitario= @precio_unitario,precio_total= @precio_total,usuario_sistema= @usuario_sistema,fecha_sistema=@fecha_sistema where codigo_orden_det = @codigo_orden_det";
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand update_Usuario = new SqlCommand(query, connection))
                {
                    update_Usuario.Parameters.AddWithValue("@codigo_orden_det", codigo_orden_det);
                    update_Usuario.Parameters.AddWithValue("@codigo_orden_enc", codigo_orden_enc);
                    update_Usuario.Parameters.AddWithValue("@codigo_menu", codigo_menu);
                    update_Usuario.Parameters.AddWithValue("@cantidad", cantidad);
                    update_Usuario.Parameters.AddWithValue("@precio_unitario", precio_unitario);
                    update_Usuario.Parameters.AddWithValue("@precio_total", precio_total);
                    update_Usuario.Parameters.AddWithValue("@usuario_sistema", usuario_sistema);
                    update_Usuario.Parameters.AddWithValue("@fecha_sistema", fecha_sistema);
                    update_Usuario.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region = "Delete data a tbl_detalles_ordenes";
        public void Mtd_Delete_detall_ordenes(int codigo_orden_det)
        {
            string query = "delete tbl_detalles_ordenes where codigo_orden_det = @codigo_orden_det";
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand update_Usuario = new SqlCommand(query, connection))
                {
                    update_Usuario.Parameters.AddWithValue("@codigo_orden_det", codigo_orden_det);
                    update_Usuario.ExecuteNonQuery();
                }
            }
        }
        #endregion




    }
}
