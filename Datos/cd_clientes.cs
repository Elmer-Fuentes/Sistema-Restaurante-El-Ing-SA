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
    public class cd_clientes : Conexion
    {
        public DataTable MtdDevolverdatos()
        {
            string query = "select codigo_cliente as'codigo de cliente',nombre as 'Nombre',nit as 'NIT',telefono as 'Telefono',categoria as 'Categoria',estado as 'Estado',usuario_sistema as 'Usuario Sistema',fecha_sistema as 'Fecha de el sistema'from tbl_clientes";
            using (SqlConnection connection = GetConnection())
            {
                SqlDataAdapter retornar = new SqlDataAdapter(query, connection);
                DataTable datos = new DataTable();
                retornar.Fill(datos);
                return datos;
            }
        }

        public void MtdAgregardatos(string nombre, string nit, string telefono, string categoria, string estado, string usuario_sistema, DateTime fecha_sistema)
        {
            string query = "insert into tbl_clientes(nombre, nit, telefono, categoria, estado, usuario_sistema, fecha_sistema) values (@nombre, @nit, @telefono, @categoria, @estado, @usuario_sistema, @fecha_sistema)";
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand Agregar = new SqlCommand(query, connection))
                {
                    Agregar.Parameters.AddWithValue("@nombre", nombre);
                    Agregar.Parameters.AddWithValue("@nit", nit);
                    Agregar.Parameters.AddWithValue("@telefono", telefono);
                    Agregar.Parameters.AddWithValue("@categoria", categoria);
                    Agregar.Parameters.AddWithValue("@estado", estado);
                    Agregar.Parameters.AddWithValue("@usuario_sistema", usuario_sistema);
                    Agregar.Parameters.AddWithValue("@fecha_sistema", fecha_sistema);
                    Agregar.ExecuteNonQuery();
                }
            }
        }

        public void MtdEditardatos(int codigo_cliente, string nombre, string nit, string telefono, string categoria, string estado, string usuario_sistema, DateTime fecha_sistema)
        {
            string query = "update tbl_clientes set nombre = @nombre, nit = @nit, telefono = @telefono, categoria = @categoria, estado = @estado, usuario_sistema = @usuario_sistema, fecha_sistema = @fecha_sistema where codigo_cliente = @codigo_cliente";
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand editar = new SqlCommand(query, connection))
                {
                    editar.Parameters.AddWithValue("@codigo_cliente", codigo_cliente);
                    editar.Parameters.AddWithValue("@nombre", nombre);
                    editar.Parameters.AddWithValue("@nit", nit);
                    editar.Parameters.AddWithValue("@telefono", telefono);
                    editar.Parameters.AddWithValue("@categoria", categoria);
                    editar.Parameters.AddWithValue("@estado", estado);
                    editar.Parameters.AddWithValue("@usuario_sistema", usuario_sistema);
                    editar.Parameters.AddWithValue("@fecha_sistema", fecha_sistema);
                    editar.ExecuteNonQuery();
                }
            }
        }

        public void MtdEliminar(int codigo_cliente)
        {
            string query = "delete from tbl_clientes where codigo_cliente = @codigo_cliente";
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand eliminar = new SqlCommand(query, connection))
                {
                    eliminar.Parameters.AddWithValue("@codigo_cliente", codigo_cliente);
                    eliminar.ExecuteNonQuery();
                }
            }
        }

        public DataTable MtdBuscarclientes(string nombre)
        {
            DataTable busqueda = new DataTable();

            string query = "select * from tbl_clientes where nombre like @nombre";
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand buscar = new SqlCommand(query, connection))
                {
                    buscar.Parameters.AddWithValue("@nombre", "%" + nombre + "%");
                    SqlDataAdapter datos = new SqlDataAdapter(buscar);
                    datos.Fill(busqueda);
                }
            }
            return busqueda;
        }
    }
}