using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impuestos
{
    class PredioValledupar : Predio
    {
        public override void calcularTarifa()
        {
            /*LOGICA DE TARIFA*/
            TARIFA = "Tarifa Valledupar";
        }
    }
}
