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
    public class cd_clientes
    {
        private Conexion connex = new Conexion();

        public DataTable MtdDevolverdatos()
        {
            string query = "select * from tbl_clientes";
            SqlDataAdapter retornar = new SqlDataAdapter(query, connex.MtdAbrirconexion());
            DataTable datos = new DataTable();
            retornar.Fill(datos);
            return datos;
            connex.MtdCerrarconexion();
        }

        public void MtdAgregardatos(string nombre, string nit, string telefono, string categoria, string estado, string usuario_sistema, DateTime fecha_sistema)
        {
            string query = "insert into tbl_clientes(nombre, nit, telefono, categoria, estado, usuario_sistema, fecha_sistema) values (@nombre, @nit, @telefono, @categoria, @estado, @usuario_sistema, @fecha_sistema)";
            SqlCommand Agregar = new SqlCommand(query, connex.MtdAbrirconexion());
            Agregar.Parameters.AddWithValue("@nombre", nombre);
            Agregar.Parameters.AddWithValue("@nit", nit);
            Agregar.Parameters.AddWithValue("@telefono", telefono);
            Agregar.Parameters.AddWithValue("@categoria", categoria);
            Agregar.Parameters.AddWithValue("@estado", estado);
            Agregar.Parameters.AddWithValue("@usuario_sistema", usuario_sistema);
            Agregar.Parameters.AddWithValue("@fecha_sistema", fecha_sistema);
            Agregar.ExecuteNonQuery();
            connex.MtdCerrarconexion();
        }

        public void MtdEditardatos(int codigo_cliente, string nombre, string nit, string telefono, string categoria, string estado, string usuario_sistema, DateTime fecha_sistema)
        {
            string query = "update tbl_clientes set nombre = @nombre, nit = @nit, telefono = @telefono, categoria = @categoria, estado = @estado, usuario_sistema = @usuario_sistema, fecha_sistema = @fecha_sistema where codigo_cliente = @codigo_cliente";
            SqlCommand editar = new SqlCommand(query, connex.MtdAbrirconexion());
            editar.Parameters.AddWithValue("@codigo_cliente", codigo_cliente);
            editar.Parameters.AddWithValue("@nombre", nombre);
            editar.Parameters.AddWithValue("@nit", nit);
            editar.Parameters.AddWithValue("@telefono", telefono);
            editar.Parameters.AddWithValue("@categoria", categoria);
            editar.Parameters.AddWithValue("@estado", estado);
            editar.Parameters.AddWithValue("@usuario_sistema", usuario_sistema);
            editar.Parameters.AddWithValue("@fecha_sistema", fecha_sistema);
            editar.ExecuteNonQuery();
            connex.MtdCerrarconexion();
        }

        public void MtdEliminar(int codigo_cliente)
        {
            string query = "delete from tbl_clientes where codigo_cliente = @codigo_cliente";
            SqlCommand eliminar = new SqlCommand(query, connex.MtdAbrirconexion());
            eliminar.Parameters.AddWithValue("@codigo_cliente", codigo_cliente);
            eliminar.ExecuteNonQuery();
            connex.MtdCerrarconexion();
        }

        public DataTable MtdBuscarclientes(string nombre)
        {
            string query = "select * from tbl_clientes where nombre = @nombre";
            SqlDataAdapter buscar = new SqlDataAdapter(query, connex.MtdAbrirconexion());
            DataTable busqueda = new DataTable();
            buscar.SelectCommand.Parameters.AddWithValue("@nombre", nombre);
            buscar.Fill(busqueda);
            return busqueda;
            connex.MtdCerrarconexion();
        }
    }
}