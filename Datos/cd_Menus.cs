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
        #region = "Metodo para agregar un Menu";
        public void MtdInsMenu(string nombre, string ingredientes, string categoria, double precio, string estado, string usuario_sistema, DateTime fecha_sistema)
        {
            string query = "insert into tbl_menus (nombre,ingredientes,categoria,precio,estado,usuario_sistema,fecha_sistema) values (@nombre,@ingredientes,@categoria,@precio,@estado,@usuario_sistema,@fecha_sistema)";
            SqlCommand ins_Usuario = new SqlCommand(query, connex.MtdAbrirconexion());
             //    ins_Usuario.Parameters.AddWithValue("@codigo_empleado", codigo_empleado);
            ins_Usuario.Parameters.AddWithValue("@nombre", nombre);
            ins_Usuario.Parameters.AddWithValue("@ingredientes", ingredientes);
            ins_Usuario.Parameters.AddWithValue("@categoria", categoria);
            ins_Usuario.Parameters.AddWithValue("@precio", precio);
            ins_Usuario.Parameters.AddWithValue("@estado", estado);
            ins_Usuario.Parameters.AddWithValue("@usuario_sistema", usuario_sistema);
            ins_Usuario.Parameters.AddWithValue("@fecha_sistema", fecha_sistema);
            ins_Usuario.ExecuteNonQuery();
            connex.MtdCerrarconexion();
        }
        #endregion

        #region = "Metodo para editar un Menu";
        public void MtdUpdMenu(int codigo,string nombre, string ingredientes, string categoria, double precio, string estado, string usuario_sistema, DateTime fecha_sistema)
        {
            string query = "update tbl_menus set nombre=@nombre,ingredientes=@ingredientes,categoria=@categoria,precio=@precio,estado=@estado,usuario_sistema=@usuario_sistema,fecha_sistema=@fecha_sistema where codigo_menu = @codigo_menu";
            SqlCommand ins_Usuario = new SqlCommand(query, connex.MtdAbrirconexion());
            ins_Usuario.Parameters.AddWithValue("codigo_menu", codigo);
            ins_Usuario.Parameters.AddWithValue("@nombre", nombre);
            ins_Usuario.Parameters.AddWithValue("@ingredientes", ingredientes);
            ins_Usuario.Parameters.AddWithValue("@categoria", categoria);
            ins_Usuario.Parameters.AddWithValue("@precio", precio);
            ins_Usuario.Parameters.AddWithValue("@estado", estado);
            ins_Usuario.Parameters.AddWithValue("@usuario_sistema", usuario_sistema);
            ins_Usuario.Parameters.AddWithValue("@fecha_sistema", fecha_sistema);
            ins_Usuario.ExecuteNonQuery();
            connex.MtdCerrarconexion();
        }
        #endregion
    }
}
