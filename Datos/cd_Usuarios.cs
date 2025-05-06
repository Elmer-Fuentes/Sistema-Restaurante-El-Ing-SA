using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_datos
{
    public class cd_Usuarios
    {
        #region = "instancias de la clase conexion";
        private conexion connex = new conexion();
        #endregion

        #region = "Metodo para vista del select o mostra en el dgv";
        public DataTable MtdViewUsuarios()
        {
            string query = "select * from usuario";
            SqlDataAdapter retornar = new SqlDataAdapter(query, connex.MtdAbrirconexion());
            DataTable datosUsuarios = new DataTable();
            retornar.Fill(datosUsuarios);
            try //se opto por try para retornarlos datos 
            {
                return datosUsuarios;
            }
            finally //garantiza que se ejecute el cierre de la conexión
            //esto por un error de accesibilidad que daba como alerta
            {
                connex.MtdCerrarconexion();
            }
        }
        #endregion

        #region = "Metodo para agregar un nuevo usuario";
        public void MtdInsUsuarios(int codigo_empleado, string nombre_empleado, string nombre_usuario, string contrasena, string rol, string estado, string usuario_sistema, DateTime fecha_sistema)
        {
            string query = "insert into tbl_usuarios (codigo_empleado,nombre_usuario,contrasena,rol,estado,usuario_sistema,FechaSistema) Values(@codigo_empleado,@nombre_usuario,@contrasena,@rol,@estado,@usuario_sistema,@FechaSistema)";
            SqlCommand ins_Usuario = new SqlCommand(query, connex.MtdAbrirconexion());
            ins_Usuario.Parameters.AddWithValue("@codigo_empleado", codigo_empleado);
            ins_Usuario.Parameters.AddWithValue("@nombre_empleado", nombre_empleado);
            ins_Usuario.Parameters.AddWithValue("@nombre_usuario", nombre_usuario);
            ins_Usuario.Parameters.AddWithValue("@contrasena", contrasena);
            ins_Usuario.Parameters.AddWithValue("@rol", rol);
            ins_Usuario.Parameters.AddWithValue("@estado", estado);
            ins_Usuario.Parameters.AddWithValue("@usuario_sistema", usuario_sistema);
            ins_Usuario.Parameters.AddWithValue("@FechaSistema", fecha_sistema);
            ins_Usuario.ExecuteNonQuery();
            connex.MtdCerrarconexion();
        }
        #endregion


    }
}
