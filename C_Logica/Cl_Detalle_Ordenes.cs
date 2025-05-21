using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Logica
{
    public class Cl_Detalle_Ordenes
    {

        public string Mtd_Total_detalle_ordenes(double cantidad, double precio)
        {
            double total = cantidad * precio;

            return total.ToString();
        }


    }
}
