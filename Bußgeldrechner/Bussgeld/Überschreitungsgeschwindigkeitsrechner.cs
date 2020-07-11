using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bußgeldrechner.Bussgeld
{
    class Überschreitungsgeschwindigkeitsrechner
    {
        public double gefahren { get; set; }

        public double erlaubt { get; set; }

        public double Rechnerzuschnell(double gefahren, double erlaubt)
        {
            double num = gefahren - erlaubt;
            return gefahren <= 100.0 ? num - 3.0 : num - num / 100.0 * 3.0;
        }
    }
}
