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
    }
}
