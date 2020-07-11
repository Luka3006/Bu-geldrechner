using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bußgeldrechner.Bussgeld
{
    class ÜberschreitungsbereichRechner
    {
        public double zuschnell { get; set; }

        public bool Innerorts { get; set; }

        public string Innerortsumwandlung(bool Innerorts)
        {
            return Innerorts ? "1" : "0";
        }

        public string BereichRechner(double zuschnell)
        {
            if (zuschnell <= 10.0 && zuschnell >= 1.0)
                return "1";
            if (zuschnell <= 15.0 && zuschnell >= 11.0)
                return "2";
            if (zuschnell <= 20.0 && zuschnell >= 16.0)
                return "3";
            if (zuschnell <= 25.0 && zuschnell >= 21.0)
                return "4";
            if (zuschnell <= 30.0 && zuschnell >= 26.0)
                return "5";
            if (zuschnell <= 40.0 && zuschnell >= 31.0)
                return "6";
            if (zuschnell <= 50.0 && zuschnell >= 41.0)
                return "7";
            if (zuschnell <= 60.0 && zuschnell >= 51.0)
                return "8";
            if (zuschnell <= 70.0 && zuschnell >= 61.0)
                return "9";
            return zuschnell > 70.0 ? "10" : "0";
        }
    }
}
