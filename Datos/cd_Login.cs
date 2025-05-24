using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace capa_datos

{
    public class cd_Login : Conexion //herencia clase Conexion
    {
        #region = "Validación login V2";

        public bool Login(string usuario, string contrasena)
        {
            using (var connection = GetConnection())
            {
                    connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT codigo_usuario,codigo_empleado,nombre_usuario,contrasena,rol,estado,usuario_sistema,FechaSistema FROM tbl_usuarios WHERE nombre_usuario COLLATE Latin1_General_CS_AS = @usuario AND contrasena COLLATE Latin1_General_CS_AS = @contrasena";
                    command.Parameters.AddWithValue("@usuario", usuario);
                    command.Parameters.AddWithValue("@contrasena", contrasena);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Mis_Variables.rolusuario = reader.GetString(4);
                        }
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        #endregion = "Validación login V2";
    }
}