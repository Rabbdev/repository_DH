using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_mit_test
{
    public class Logik_Klasse
    {

        // ---------------------------   Hauptfunktion der Logik  --------------------------------------------------------------------

        internal static string dez_zu_rom_logik_hauptfunktion(int wert)
        {
            String[] roemisch = new String[] { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            int[] dezimal = new int[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };

            string roemischer_wert = for_berechnung(wert, dezimal, roemisch);

            return roemischer_wert;

        }
        //Ende der Hauptfunktion





         //--------------------------------- Unterfunktion ---------------------------------------------------------------------------


        internal static string for_berechnung(int wert, int[] dezimal, string[] roemisch)
        {
            string roemischer_wert = "";

            for (int i = 0; i < dezimal.Length; i++)
                while (wert >= dezimal[i])
                {
                    wert -= dezimal[i];
                    roemischer_wert += roemisch[i];
                }

            return roemischer_wert;

        }
        //Ende der Unterfunktion





        //----------------------------------- Nebenfunktion: Gültigkeit des Wertebereiches --------------------------------------------------

        internal static string werte_bereich_logik(int wert)
        {
            string wert_gueltig = "Der Wert ist nicht gültig, er muss zwischen 1 und 3000 liegen.";

            if ((wert < 1) || (wert > 3000)) { return wert_gueltig; }
            else
            {
                wert_gueltig = "";
                return wert_gueltig;
            }
        }
        //Ender der Nebenfunktion
    }
}
