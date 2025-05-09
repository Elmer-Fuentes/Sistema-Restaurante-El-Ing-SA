using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_datos
{
    public abstract class conexion
    {
        // Objeto SqlConnection usado para establecer la conexión
        private readonly string Conexiondatabase;

        //inicializa la cadena de conexión
        public conexion()
        {
            Conexiondatabase = "Server=tcp:sources.database.windows.net,1433;Initial Catalog=Proyecto_Restaurante;Persist Security Info=False;User ID=Administrador;Password=Sources01081997;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(Conexiondatabase);
        }
    }
}