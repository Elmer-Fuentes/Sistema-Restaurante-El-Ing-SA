using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capa_datos;

namespace C_Logica
{
	public class cl_pago_planillas
	{
		Conexion cn = new Conexion();
		decimal MtdSalarioPlanilla(int codigoEmpleado)
{
    decimal salario = 0;

			using (SqlConnection connex = cn.MtdAbrirconexion())
			{
        string query = "SELECT Salario FROM tbl_Empleados WHERE CodigoEmpleado = @CodigoEmpleado";
        SqlCommand cmd = new SqlCommand(query, connex);
        cmd.Parameters.AddWithValue("@CodigoEmpleado", codigoEmpleado);

        connex.Open();
        SqlDataReader reader = cmd.ExecuteReader();

        if (reader.Read())
        {
            salario = reader.GetDecimal(0);
        }

        reader.Close();
    }

    return salario;
}



		decimal MtdSalarioBono(decimal salario)
		{
			decimal bono = salario * 0.10m;
			return bono;
		}
		decimal MtdMontoTotal(decimal salario, decimal bono, int horasExtras)
		{
			decimal montoHoras = horasExtras * 15;
			decimal montoTotal = salario + bono + montoHoras;
			return montoTotal;
		}
		public DateTime MtdFecha()
		{
			return DateTime.Now;
		}
	}
}
	

