using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_datos
{
    public class conexion
    {
        // Objeto SqlConnection usado para establecer la conexión
        private readonly SqlConnection conexiondatabase;

        //inicializa la cadena de conexión
        public conexion()
        {
            string cadenaConexion = "Server=tcp:sources.database.windows.net,1433;Initial Catalog=Proyecto_Restaurante;Persist Security Info=False;User ID=Administrador;Password=Sources01081997;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            conexiondatabase = new SqlConnection(cadenaConexion);
        }

        public SqlConnection MtdConexion { get; set; }

        public SqlConnection MtdAbrirconexion()
        {
            if (conexiondatabase.State == ConnectionState.Closed)
            {
                conexiondatabase.Open();
            }
            return conexiondatabase;
        }

        public void MtdCerrarconexion()
        {
            if (conexiondatabase.State == ConnectionState.Open)
            {
                conexiondatabase.Close();
            }
        }
    }
}