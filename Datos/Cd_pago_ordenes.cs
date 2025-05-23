using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capa_datos;

namespace Datos
{
    public class Cd_pago_ordenes : Conexion
    {
        #region = "Metodo para vista del select o mostrar en el dgv";
        public DataTable MtdConsultarPagoOrden()
        {
            string query = "select * from tbl_pago_ordenes";
            using (SqlConnection connection = GetConnection())
            {
                SqlDataAdapter retornar = new SqlDataAdapter(query, connection);
                DataTable datospagoplanillas = new DataTable();
                retornar.Fill(datospagoplanillas);
                return datospagoplanillas;
            }
        }
        #endregion
    }
}
