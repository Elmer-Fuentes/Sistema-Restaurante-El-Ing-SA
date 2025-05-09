using capa_datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seguridad
{
    public class C_seguridad : Conexion //herencia clase Conexion
    {
        #region = "instancias de la clase conexion";
        private cd_Login cd_user_login = new cd_Login();
        #endregion

        #region = "Nuevo Login";
        public bool LoginUser(string usuario, string contrasena)
        {
            return cd_user_login.Login(usuario, contrasena);
        }

        #endregion

    }
}
