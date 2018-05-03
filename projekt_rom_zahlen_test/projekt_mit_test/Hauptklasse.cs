using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_mit_test
{
    public class Hauptklasse
    {

        internal static string werte_bereich(int wert)
        {
            string wert_gueltig = Logik_Klasse.werte_bereich_logik(wert);
            return wert_gueltig;
        }


        internal static string rechnen_und_ausgabe(int wert)
        {
            string result = "Error";
            {
                result = (Logik_Klasse.dez_zu_rom_logik_hauptfunktion(wert));
                return result;
            }
        }
    }
}
