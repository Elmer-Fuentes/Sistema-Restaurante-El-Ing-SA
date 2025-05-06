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


    }
}
