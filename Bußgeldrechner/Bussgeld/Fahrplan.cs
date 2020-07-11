using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bußgeldrechner.Bussgeld
{
    class Fahrplan
    {

        public double gefahren { get; set; }

        public double erlaubt { get; set; }

        public bool innerorts { get; set; }

        public bool probezeit { get; set; }

        public string Main(double gefahren, double erlaubt, bool innerorts, bool probezeit)
        {
            if (gefahren == 0.0)
                return "Fehler: Keine Eingabe der gefahrenen Geschwindigkeit.";
            if (erlaubt == 0.0)
                return "Fehler: Keine Eingabe der erlaubten Geschwindigkeit.";
            double zuschnell = new Überschreitungsgeschwindigkeitsrechner()
            {
                gefahren = gefahren,
                erlaubt = erlaubt
            }.Rechnerzuschnell(gefahren, erlaubt);
            ÜberschreitungsbereichRechner überschreitungsbereichRechner = new ÜberschreitungsbereichRechner();
            überschreitungsbereichRechner.zuschnell = zuschnell;
            überschreitungsbereichRechner.Innerorts = innerorts;
            string str1 = überschreitungsbereichRechner.Innerortsumwandlung(innerorts);
            string str2 = überschreitungsbereichRechner.BereichRechner(zuschnell);
            if (str2.Equals("0"))
                return "Nach Abzug der Toleranz liegt keine Geschwindigkeitsüberschreitung vor.";
            string Zuweisung = str2 + str1;
            Strafzuordner strafzuordner = new Strafzuordner();
            strafzuordner.Zuweisung = Zuweisung;
            strafzuordner.zuschnell = zuschnell;
            strafzuordner.probezeit = probezeit;
            return strafzuordner.Bußgeldzuweisung(Zuweisung) + strafzuordner.ProbezeitStrafe(zuschnell, probezeit);
        }

    }
}
