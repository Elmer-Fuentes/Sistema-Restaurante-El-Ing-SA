﻿using capa_datos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class cd_Menus : Conexion
    {
  

        #region = "Metodo para vista del select o mostra en el dgv";
        public DataTable MtdViewMenu()
        {
            string query = "Select * from tbl_menus";
            using (SqlConnection connection = GetConnection())
            {
                SqlDataAdapter retornar = new SqlDataAdapter(query, connection);
                DataTable datosMenus = new DataTable();
                retornar.Fill(datosMenus);
                return datosMenus;
            }
        }
        #endregion

        #region = "Metodo para agregar un Menu";
        public void MtdInsMenu(string nombre, string ingredientes, string categoria, double precio, string estado, string usuario_sistema, DateTime fecha_sistema)
        {
            string query = "insert into tbl_menus (nombre,ingredientes,categoria,precio,estado,usuario_sistema,fecha_sistema) values (@nombre,@ingredientes,@categoria,@precio,@estado,@usuario_sistema,@fecha_sistema)";
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand ins_menu = new SqlCommand(query, connection))
                {
                    ins_menu.Parameters.AddWithValue("@nombre", nombre);
                    ins_menu.Parameters.AddWithValue("@ingredientes", ingredientes);
                    ins_menu.Parameters.AddWithValue("@categoria", categoria);
                    ins_menu.Parameters.AddWithValue("@precio", precio);
                    ins_menu.Parameters.AddWithValue("@estado", estado);
                    ins_menu.Parameters.AddWithValue("@usuario_sistema", usuario_sistema);
                    ins_menu.Parameters.AddWithValue("@fecha_sistema", fecha_sistema);
                    ins_menu.ExecuteNonQuery();

                }
            }
        }
        #endregion

        #region = "Metodo para editar un Menu";
        public void MtdUpdMenu(int codigo,string nombre, string ingredientes, string categoria, double precio, string estado, string usuario_sistema, DateTime fecha_sistema)
        {
            string query = "update tbl_menus set nombre=@nombre,ingredientes=@ingredientes,categoria=@categoria,precio=@precio,estado=@estado,usuario_sistema=@usuario_sistema,fecha_sistema=@fecha_sistema where codigo_menu = @codigo_menu";
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand upd_menu = new SqlCommand(query, connection))
                {
                    upd_menu.Parameters.AddWithValue("codigo_menu", codigo);
                    upd_menu.Parameters.AddWithValue("@nombre", nombre);
                    upd_menu.Parameters.AddWithValue("@ingredientes", ingredientes);
                    upd_menu.Parameters.AddWithValue("@categoria", categoria);
                    upd_menu.Parameters.AddWithValue("@precio", precio);
                    upd_menu.Parameters.AddWithValue("@estado", estado);
                    upd_menu.Parameters.AddWithValue("@usuario_sistema", usuario_sistema);
                    upd_menu.Parameters.AddWithValue("@fecha_sistema", fecha_sistema);
                    upd_menu.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region = "Metodo Eliminar usuario";
        public void MtdDeleteUsuarios(int codigo_UID)
        {
            string query = "delete from tbl_menus where codigo_menu=@codigo_menu";
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand del_menu = new SqlCommand(query, connection))
                {

                    del_menu.Parameters.AddWithValue("@codigo_menu", codigo_UID);
                    del_menu.ExecuteNonQuery();
                }
            }
        }
        #endregion


    }
}
