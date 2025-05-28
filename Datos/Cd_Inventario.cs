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
            string query = "select Codigo_Inventario,Codigo_Menu,Categoria,Cantidad,Fecha_entrada,Fecha_vencimiento,Dias_vigencia,Usuario_sistema,Fecha_sistema,datediff(DAY,fecha_entrada,DateAdd(hour,-6,Getdate())) as DiasTranscurridos from tbl_inventarios";
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

        public void Mtdeditar(int codigo_inventario, int codigo_menu, string categoria, int cantidad, DateTime fecha_entrada, DateTime fecha_vencimiento, int dias_vigencia, string usuario_sistema, DateTime fecha_sistema)
        {
            string query = "update tbl_inventarios set codigo_menu = @codigo_menu, categoria = @categoria, cantidad = @cantidad, fecha_entrada = @fecha_entrada, fecha_vencimiento = @fecha_vencimiento, dias_vigencia = @dias_vigencia, usuario_sistema = @usuario_sistema, fecha_sistema = @fecha_sistema where codigo_inventario = @codigo_inventario";
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand editar = new SqlCommand(query, connection))
                {
                    editar.Parameters.AddWithValue("@codigo_inventario", codigo_inventario);
                    editar.Parameters.AddWithValue("@codigo_menu", codigo_menu);
                    editar.Parameters.AddWithValue("@categoria", categoria);
                    editar.Parameters.AddWithValue("@cantidad", cantidad);
                    editar.Parameters.AddWithValue("@fecha_entrada", fecha_entrada);
                    editar.Parameters.AddWithValue("@fecha_vencimiento", fecha_vencimiento);
                    editar.Parameters.AddWithValue("@dias_vigencia", dias_vigencia);
                    editar.Parameters.AddWithValue("@fecha_sistema", fecha_sistema);
                    editar.Parameters.AddWithValue("@usuario_sistema", usuario_sistema);
                    editar.ExecuteNonQuery();
                }
            }
        }

        public void MtdEliminardatos(int codigo_inventario)
        {
            string query = "delete from tbl_inventarios where codigo_inventario = @codigo_inventario ";
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand eliminar = new SqlCommand(query, connection))
                {
                    eliminar.Parameters.AddWithValue("@codigo_inventario", codigo_inventario);
                    eliminar.ExecuteNonQuery();
                }
            }
        }

        public List<dynamic> Mtdcategoria()
        {
            string query = "select categoria from tbl_clientes ";
            List<dynamic> lista = new List<dynamic>();
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new
                            {
                                value = reader["categoria"],
                                text = $"{reader["categoria"]} "
                            }

                             );
                        }
                    }
                }
            }
            return lista;
        }

        public void MtdEliminar(int codigo_inventario)
        {
            string query = "delete from tbl_inventarios where codigo_inventario = @codigo_inventario";
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand eliminar = new SqlCommand(query, connection))
                {
                    eliminar.Parameters.AddWithValue("@codigo_inventario", codigo_inventario);
                    eliminar.ExecuteNonQuery();
                }
            }
        }

        public DataTable MtdBuscarporFentrada(DateTime fecha_entrada)
        {
            DataTable dt = new DataTable();
            string query = "select codigo_inventario as 'Codigo Inventario',\r\ncodigo_menu as 'Codigo Menu',\r\ncategoria as 'Categoria',\r\ncantidad as 'Cantidad',\r\nfecha_entrada as 'Fecha Entrada', \r\nfecha_vencimiento as 'Fecha Vencimiento',\r\ndias_vigencia as 'Dias de Vigencia',\r\nusuario_sistema as 'Usuario Sistema',\r\nfecha_sistema as 'Fecha del Sistema'\r\nfrom tbl_inventarios where fecha_entrada = @fecha_entrada";
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand buscar = new SqlCommand(query, connection))
                {
                    buscar.Parameters.AddWithValue("@fecha_entrada", fecha_entrada);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(buscar))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;
        }
    }
}