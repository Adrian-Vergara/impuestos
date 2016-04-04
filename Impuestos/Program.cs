using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impuestos
{
    class Program
    {
        static void Main(string[] args)
        {
            PredioValledupar valledupar1 = new PredioValledupar();
            PredioValledupar valledupar2 = new PredioValledupar();
            valledupar1.DPTO = "Valledupar";
            valledupar2.DPTO = "Valledupar";

            PredioLaPaz laPaz1 = new PredioLaPaz();
            PredioLaPaz laPaz2 = new PredioLaPaz();
            laPaz1.DPTO = "La Paz";
            laPaz2.DPTO = "La Paz";

            PredioAguachica aguachica1 = new PredioAguachica();
            PredioAguachica aguachica2 = new PredioAguachica();
            aguachica1.DPTO = "Aguachica";
            aguachica2.DPTO = "Aguachica";

            List<Predio> predios = new List<Predio>();
            TarifasMunicipios tarifas = new TarifasMunicipios();
            predios.Add(valledupar1);
            predios.Add(valledupar2);
            predios.Add(laPaz1);
            predios.Add(laPaz2);
            predios.Add(aguachica1);
            predios.Add(aguachica2);
            tarifas.predioMunicipios = predios;
            tarifas.CalcularTarifasMunicipios();

        }
    }
}
