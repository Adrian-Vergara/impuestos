using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impuestos
{
    class TarifasMunicipios
    {
        public List<Predio> predioMunicipios { get; set; }
        
        public void CalcularTarifasMunicipios()
        {
            foreach (var predio in predioMunicipios)
            {
                predio.calcularTarifa();
                Console.WriteLine(predio.DPTO + " " + predio.TARIFA);
            }
            Console.Read();
        }
    }
}
