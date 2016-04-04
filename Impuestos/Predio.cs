using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impuestos
{
    public abstract class Predio
    {
        public string DPTO { get; set; }
        public int NRO_PREDIO { get; set; }
        public int TIPO_REG { get; set; }
        public int NRO_ORDEN { get; set; }
        public int TOTAL_REG { get; set; }
        public int NOMBRE { get; set; }
        public int ESTADO_CIVIL { get; set; }
        public int TIP_DOC { get; set; }
        public int NRO_DOC { get; set; }
        public String DIRECCION { get; set; }
        public int COMUNA { get; set; }
        public int DEST_ECON { get; set; }
        public int AREA_TERR { get; set; }
        public int AREA_CONST { get; set; }
        public double AVALUO { get; set; }
        public int ESPACIOS { get; set; }
        public int VIGENCIA { get; set; }
        public string TARIFA { get; set; }

        public abstract void calcularTarifa();
    }
}
