using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace capa_datos
{
    public class cd_Login
    {
        #region = "instancias de la clase conexion";
        private conexion connex = new conexion();
        #endregion

        #region ="MEtodo Login"
        public DataTable MtdLogin(string usuario, string contrasena)
        {
            string query = "SELECT nombre_usuario, rol FROM tbl_usuarios WHERE nombre_usuario COLLATE Latin1_General_CS_AS = @usuario AND contrasena COLLATE Latin1_General_CS_AS = @contrasena";
            DataTable resultado = new DataTable();
            using (SqlConnection conexion = connex.MtdAbrirconexion())
            using (SqlCommand cmd = new SqlCommand(query, conexion))
            {
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@contrasena", contrasena);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(resultado);
            }
            try { 
            return resultado;
            }
            finally
            {
                connex.MtdCerrarconexion();
            }
        }
        #endregion



    }
}
