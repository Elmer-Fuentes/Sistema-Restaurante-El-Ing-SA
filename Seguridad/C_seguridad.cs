using capa_datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seguridad
{
    public class C_seguridad
    {
        #region = "instancias de la clase conexion";
        private conexion connex = new conexion();
        private cd_Login cd_user_login = new cd_Login();
        #endregion

        #region = "Validación login";
        public string VerificarLogin(string usuario, string contrasena)
        {
            DataTable resultado = cd_user_login.MtdLogin(usuario, contrasena);
            if (resultado.Rows.Count > 0)
            {
                return resultado.Rows[0]["Rol"].ToString();
            }
            else
            {
                return null;
            }
        }
        #endregion

    }
}
