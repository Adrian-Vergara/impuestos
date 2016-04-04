using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impuestos
{
    class PredioLaPaz : Predio
    {
        public override void calcularTarifa()
        {
            /*LOGICA TARIFA*/
            TARIFA = "Tarifa la Paz";
        }
    }
}
