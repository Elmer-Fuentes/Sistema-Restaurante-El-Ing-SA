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
    public class cd_Menus
    {
        #region = "instancias de la clase conexion";
        private conexion connex = new conexion();
        #endregion

        #region = "Metodo para vista del select o mostra en el dgv";
        public DataTable MtdViewMenu()
        {
            string query = "Select * from tbl_menus";
            SqlDataAdapter retornar = new SqlDataAdapter(query, connex.MtdAbrirconexion());
            DataTable datosMenus = new DataTable();
            retornar.Fill(datosMenus);
            try //se opto por try para retornarlos datos 
            {
                return datosMenus;
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
