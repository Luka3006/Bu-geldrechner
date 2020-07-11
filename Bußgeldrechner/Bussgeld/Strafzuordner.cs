using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bußgeldrechner.Bussgeld
{
    class Strafzuordner
    {
        public string Zuweisung { get; set; }

        public double zuschnell { get; set; }

        public bool probezeit { get; set; }

        public string ProbezeitStrafe(double zuschnell, bool probezeit)
        {
            return zuschnell > 20.0 && probezeit ? " und Teilnahme an einem Aufbauseminar für Fahranfänger" : "";
        }

        public string Bußgeldzuweisung(string Zuweisung)
        {
            if (Zuweisung.Equals("10"))
                return "20€";
            if (Zuweisung.Equals("20"))
                return "40€";
            if (Zuweisung.Equals("30"))
                return "60€";
            if (Zuweisung.Equals("40"))
                return "70€, 1 Punkt in Flensburg ";
            if (Zuweisung.Equals("50"))
                return "80€, 1 Punkt in Flensburg, 1 Monat Fahrverbot";
            if (Zuweisung.Equals("60"))
                return "120€, 1 Punkt in Flensburg, 1 Monat Fahrverbot";
            if (Zuweisung.Equals("70"))
                return "160€, 2 Punkte in Flensburg, 1 Monat Fahrverbot";
            if (Zuweisung.Equals("80"))
                return "240€, 2 Punkte in Flensburg, 1 Monat Fahrverbot";
            if (Zuweisung.Equals("90"))
                return "440€, 2 Punkte in Flensburg, 2 Monate Fahrverbot";
            if (Zuweisung.Equals("100"))
                return "600€, 2 Punkte in Flensburg, 3 Monate Fahrverbot";
            if (Zuweisung.Equals("11"))
                return "30€";
            if (Zuweisung.Equals("21"))
                return "50€";
            if (Zuweisung.Equals("31"))
                return "70€";
            if (Zuweisung.Equals("41"))
                return "80€, 1 Punkt in Flensburg, 1 Monat Fahrverbot";
            if (Zuweisung.Equals("51"))
                return "100€, 1 Punkt in Flensburg, 1 Monat Fahrverbot";
            if (Zuweisung.Equals("61"))
                return "160€, 2 Punkte in Flensburg, 1 Monat Fahrverbot";
            if (Zuweisung.Equals("71"))
                return "200€, 2 Punkte in Flensburg, 1 Monat Fahrverbot";
            if (Zuweisung.Equals("81"))
                return "280€, 2 Punkte in Flensburg, 2 Monate Fahrverbot";
            if (Zuweisung.Equals("91"))
                return "480€, 2 Punkte in Flensburg, 3 Monate Fahrverbot";
            return Zuweisung.Equals("101") ? "680€, 2 Punkte in Flensburg, 3 Monate Fahrverbot" : "Nach Abzug der Toleranz liegt keine Geschwindigkeitsüberschreitung vor";
        }
    }
}
