using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Logica
{
    public class Cl_Menu
    {
        #region = "Precio Menu"
        public double MtdPrecioMenu(int posicion)
        {
            double precio = 0;
            switch (posicion)
            {
                case 0:
                    precio = 50;
                    break;
                case 1:
                    precio = 100;
                    break;

                case 2:
                    precio = 75;
                    break;
                case 3:
                    precio = 35;
                    break;
                case 4:
                    precio = 25;
                    break;
                default:
                    precio = 0;
                    break;
            }
            return precio;
        }
        #endregion
    }
}
