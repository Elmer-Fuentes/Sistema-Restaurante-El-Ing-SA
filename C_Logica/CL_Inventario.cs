using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Logica
{
    public class CL_Inventario
    {
        public int MtdDiasVigencia(DateTime fechaentrada, DateTime fechavencimiento)
        {
            TimeSpan dias = fechavencimiento - fechaentrada;
            return dias.Days;
        }
    }
}