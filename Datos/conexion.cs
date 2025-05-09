using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_datos
{
    public abstract class Conexion
    {
        // Objeto SqlConnection usado para establecer la conexión
        private readonly string Conexiondatabase;

        //inicializa la cadena de conexión
        public Conexion()
        {
            Conexiondatabase = "Data Source=UNI-1000454\\MSSQLSERVERR;Initial Catalog=Proyecto_Restaurante;Integrated Security=True;Encrypt=False";
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(Conexiondatabase);
        }
    }
}