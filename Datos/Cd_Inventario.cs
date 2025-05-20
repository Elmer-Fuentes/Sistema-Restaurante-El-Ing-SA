using capa_datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Cd_Inventario : Conexion
    {
        public DataTable MtdRetornarDatos()
        {
            string query = "select codigo_inventario as 'Codigo Inventario',\r\ncodigo_menu as 'Codigo Menu',\r\ncategoria as 'Categoria',\r\ncantidad as 'Cantidad',\r\nfecha_entrada as 'Fecha de entrada',\r\nfecha_vencimiento as 'Fecha de Vencimiento',\r\ndias_vigencia as 'Dias de Vigencia',\r\nusuario_sistema as 'Usuario Sstema',\r\nfecha_sistema as 'Fecha Sistema'\r\nfrom tbl_inventarios";
            DataTable datos = new DataTable();
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    adapter.Fill(datos);
                }
            }
            return datos;
        }
    }
}