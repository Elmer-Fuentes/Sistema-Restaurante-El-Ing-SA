using capa_datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datos
{
    public class cd_mesas : Conexion
    {
        public DataTable MtdRetornardatos()
        {
            DataTable datos = new DataTable();
            string query = "Select codigo_mesa as 'Codigo Mesa',\r\nnumero_mesa as 'Numero de Mesa',\r\ncantidad_sillas as 'Cantidad de Sillas',\r\nubicacion as 'Ubicacion',\r\ntipo_mesa as 'Tipo de mesa',\r\nestado as 'Estado',\r\nusuario_sistema as 'Usuario Sistema',\r\nFechaSistema as 'Fecha de el Sistema'\r\nfrom tbl_mesas";
            using (SqlConnection connection = GetConnection())
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(datos);
            }

            return datos;
        }

        public void MtdAgregardatos(int numero_mesa, int cantidad_sillas, string ubicacion, string tipo_mesa, string estado, string usuario_sistema, DateTime FechaSistema)
        {
            string query = "insert into tbl_mesas( numero_mesa, cantidad_sillas, ubicacion, tipo_mesa, estado, usuario_sistema, FechaSistema ) values ( @numero_mesa, @cantidad_sillas, @ubicacion, @tipo_mesa, @estado, @usuario_sistema, @FechaSistema)";
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand agregar = new SqlCommand(query, connection))
                {
                    agregar.Parameters.AddWithValue("@numero_mesa", numero_mesa);
                    agregar.Parameters.AddWithValue("@cantidad_sillas", cantidad_sillas);
                    agregar.Parameters.AddWithValue("@ubicacion", ubicacion);
                    agregar.Parameters.AddWithValue("@tipo_mesa", tipo_mesa);
                    agregar.Parameters.AddWithValue("@estado", estado);
                    agregar.Parameters.AddWithValue("@usuario_sistema", usuario_sistema);
                    agregar.Parameters.AddWithValue("@FechaSistema", FechaSistema);
                    agregar.ExecuteNonQuery();
                }
            }
        }

        public void MtdEditar(int codigo_mesa, int numero_mesa, int cantidad_sillas, string ubicacion, string tipo_mesa, string estado, string usuario_sistema, DateTime FechaSistema)
        {
            string query = "update  tbl_mesas set  numero_mesa = @numero_mesa, cantidad_sillas = @cantidad_sillas, ubicacion = @ubicacion, tipo_mesa = @tipo_mesa, estado = @estado, usuario_sistema = @usuario_sistema, FechaSistema = @FechaSistema where codigo_mesa = @codigo_mesa";
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand editar = new SqlCommand(query, connection))
                {
                    editar.Parameters.AddWithValue("@codigo_mesa", codigo_mesa);
                    editar.Parameters.AddWithValue("@numero_mesa", numero_mesa);
                    editar.Parameters.AddWithValue("@cantidad_sillas", cantidad_sillas);
                    editar.Parameters.AddWithValue("@ubicacion", ubicacion);
                    editar.Parameters.AddWithValue("@tipo_mesa", tipo_mesa);
                    editar.Parameters.AddWithValue("@estado", estado);
                    editar.Parameters.AddWithValue("@usuario_sistema", usuario_sistema);
                    editar.Parameters.AddWithValue("@FechaSistema", FechaSistema);
                    editar.ExecuteNonQuery();
                }
            }
        }

        public void MtdEliminarRegistro(int codigo_mesa)
        {
            string query = "delete from tbl_mesas where codigo_mesa = @codigo_mesa";
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand eliminar = new SqlCommand(query, connection))
                {
                    eliminar.Parameters.AddWithValue("@codigo_mesa", codigo_mesa);
                    eliminar.ExecuteNonQuery();
                }
            }
        }

        public DataTable MtdBuscador(string tipo_mesa)
        {
            DataTable datos = new DataTable();
            string query = "select codigo_mesa as 'Codigo Mesa',numero_mesa as 'Numero de Mesa',cantidad_sillas as 'Cantidad de Sillas',ubicacion as 'Ubicacion', tipo_mesa as 'Tipo de Mesa',estado as 'Estado',usuario_sistema as 'Usuario de el Sistema',FechaSistema as 'Fecha' from tbl_mesas where lower(tipo_mesa) like '%' +@tipo_mesa +'%'";
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand buscar = new SqlCommand(query, connection))
                {
                    buscar.Parameters.AddWithValue("@tipo_mesa", "%" + tipo_mesa + "%");
                    using (SqlDataAdapter adapter = new SqlDataAdapter(buscar))
                    {
                        adapter.Fill(datos);
                    }
                }
            }
            return datos;
        }
    }
}