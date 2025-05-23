using capa_datos;
using Microsoft.ReportingServices.Diagnostics.Internal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Cd_Inventario : Conexion
    {
        public List<dynamic> MtdRetornarMenus()
        {
            List<dynamic> Lista = new List<dynamic>();
            string Query = "select codigo_menu, nombre from tbl_menus";

            using (SqlConnection Connection = GetConnection())
            {
                Connection.Open();
                using (SqlCommand cmd = new SqlCommand(Query, Connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Lista.Add(new
                            {
                                value = reader["codigo_menu"],
                                text = $"{reader["codigo_menu"]} - {reader["nombre"]}"
                            }

                            );
                        }
                    }
                }

                return Lista;
            }
        }

        public DataTable MtdRetornarDatos()
        {
            string query = "select codigo_inventario as 'Codigo Inventario',\r\ncodigo_menu as 'Codigo Menu',\r\ncategoria as 'Categoria',\r\ncantidad as 'Cantidad',\r\nfecha_entrada as 'Fecha de entrada',\r\nfecha_vencimiento as 'Fecha de Vencimiento',\r\ndias_vigencia as 'Dias de Vigencia',\r\nusuario_sistema as 'Usuario Sstema',\r\nfecha_sistema as 'Fecha Sistema'\r\nfrom tbl_inventarios";
            DataTable datos = new DataTable();
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    adapter.Fill(datos);
                }
            }
            return datos;
        }

        public void MtdIngresarInventaio(int codigo_menu, string categoria, int cantidad, DateTime fecha_entrada, DateTime fecha_vencimiento, int dias_vigencia, string usuario_sistema, DateTime fecha_sistema)
        {
            string query = "insert  into tbl_inventarios (codigo_menu, categoria, cantidad, fecha_entrada, fecha_vencimiento, dias_vigencia, usuario_sistema, fecha_sistema)\r\nvalues(@codigo_menu, @categoria, @cantidad, @fecha_entrada, @fecha_vencimiento, @dias_vigencia, @usuario_sistema, @fecha_sistema)";
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand agregar = new SqlCommand(query, connection))
                {
                    agregar.Parameters.AddWithValue("@codigo_menu", codigo_menu);
                    agregar.Parameters.AddWithValue("@categoria", categoria);
                    agregar.Parameters.AddWithValue("@cantidad", cantidad);
                    agregar.Parameters.AddWithValue("@fecha_entrada", fecha_entrada);
                    agregar.Parameters.AddWithValue("@fecha_vencimiento", fecha_vencimiento);
                    agregar.Parameters.AddWithValue("@dias_vigencia", dias_vigencia);
                    agregar.Parameters.AddWithValue("@fecha_sistema", fecha_sistema);
                    agregar.Parameters.AddWithValue("@usuario_sistema", usuario_sistema);
                    agregar.ExecuteNonQuery();
                }
            }
        }
    }
}