using capa_datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class cd_mesas : Conexion
    {
        public DataTable MtdRetornardatos()
        {
            DataTable datos = new DataTable();
            string query = "Select codigo_mesa as 'Codigo Mesa',\r\nnumero_mesa as 'Numero de Mesa',\r\ncantidad_sillas as 'Cantidad de Sillas',\r\nubicacion as 'Ubicacion',\r\ntipo_mesa as 'Tipo de mesa',\r\nestado as 'Estado',\r\nusuario_sistema as 'Usuario Sistema',\r\nFechaSistema as 'Fecha de el Sistema'\r\nfrom tbl_mesas";
            using (SqlConnection connection = GetConnection())
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(datos);
            }

            return datos;
        }
    }
}