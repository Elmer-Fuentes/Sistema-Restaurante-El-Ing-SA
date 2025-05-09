using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_datos
{
    public class cd_Usuarios : Conexion
    {

        #region = "Metodo para vista del select o mostra en el dgv";
        public DataTable MtdViewUsuarios()
        {
            string query = "select * from usuario";
            using (SqlConnection connection = GetConnection())
            {
                SqlDataAdapter retornar = new SqlDataAdapter(query, connection);
                DataTable datosUsuarios = new DataTable();
                retornar.Fill(datosUsuarios);
                return datosUsuarios;
            }
        }
        #endregion

        #region = "Metodo para agregar un nuevo usuario";
        public void MtdInsUsuarios(int codigo_empleado, string nombre_empleado, string nombre_usuario, string contrasena, string rol, string estado, string usuario_sistema, DateTime fecha_sistema)
        {
            string query = "insert into tbl_usuarios (codigo_empleado,nombre_usuario,contrasena,rol,estado,usuario_sistema,FechaSistema) Values(@codigo_empleado,@nombre_usuario,@contrasena,@rol,@estado,@usuario_sistema,@FechaSistema)";
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand ins_Usuario = new SqlCommand(query, connection))
                {
                    ins_Usuario.Parameters.AddWithValue("@codigo_empleado", codigo_empleado);
                    ins_Usuario.Parameters.AddWithValue("@nombre_empleado", nombre_empleado);
                    ins_Usuario.Parameters.AddWithValue("@nombre_usuario", nombre_usuario);
                    ins_Usuario.Parameters.AddWithValue("@contrasena", contrasena);
                    ins_Usuario.Parameters.AddWithValue("@rol", rol);
                    ins_Usuario.Parameters.AddWithValue("@estado", estado);
                    ins_Usuario.Parameters.AddWithValue("@usuario_sistema", usuario_sistema);
                    ins_Usuario.Parameters.AddWithValue("@FechaSistema", fecha_sistema);
                    ins_Usuario.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region = "Metodo para editar un usuario";
        public void MtdUpdateUsuarios(int codigo_UID, int codigo_empleado, string nombre_usuario, string contrasena, string rol, string estado, string usuario_sistema, DateTime fechasistema)
        {
            string query = "update tbl_usuarios set codigo_empleado=@codigo_empleado,nombre_usuario=@nombre_usuario,contrasena=@contrasena,rol=@rol,estado=@estado,usuario_sistema=@usuario_sistema, fechasistema=@fechasistema	where codigo_usuario = @codigo_usuario";
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand ins_Usuario = new SqlCommand(query, connection))
                {
                    ins_Usuario.Parameters.AddWithValue("@codigo_usuario", codigo_UID);
                    ins_Usuario.Parameters.AddWithValue("@codigo_empleado", codigo_empleado);
                    ins_Usuario.Parameters.AddWithValue("@nombre_usuario", nombre_usuario);
                    ins_Usuario.Parameters.AddWithValue("@contrasena", contrasena);
                    ins_Usuario.Parameters.AddWithValue("@rol", rol);
                    ins_Usuario.Parameters.AddWithValue("@estado", estado);
                    ins_Usuario.Parameters.AddWithValue("@usuario_sistema", usuario_sistema);
                    ins_Usuario.Parameters.AddWithValue("@FechaSistema", fechasistema);
                    ins_Usuario.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region = "Metodo Eliminar usuario";
        public void MtdDeleteUsuarios(int codigo_UID)
        {
            string query = "DELETE FROM tbl_usuarios WHERE codigo_usuario = @codigo_usuario";
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand ins_Usuario = new SqlCommand(query, connection))
                {
                    ins_Usuario.Parameters.AddWithValue("@codigo_usuario", codigo_UID);
                    ins_Usuario.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region = "storedet procedure"
        public DataTable MtdBuscarUsuariosPorNombre(string nombre)
        {
            string query = "USP_BusEmpleadoSin_Usuario";
            DataTable datosUsuarios = new DataTable();

            using (SqlConnection connection = GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandType = CommandType.StoredProcedure; // Indica que es un procedimiento almacenado
                    command.Parameters.AddWithValue("@Empleado_nombre", nombre); // Agrega el parámetro al comando

                    connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(datosUsuarios);
                    }
                }
            }
            return datosUsuarios;
        }
        #endregion

    }
}
