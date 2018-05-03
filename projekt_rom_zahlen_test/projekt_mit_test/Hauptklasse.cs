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
            string wert_gueltig = "Der Wert ist nicht gültig, er muss zwischen 1 und 3000 liegen.";

            if ((wert < 1) || (wert > 3000)) { return wert_gueltig; }
            else
            {
                wert_gueltig = "";
                return wert_gueltig;
            }
        }





        internal static string dez_zu_rom(int wert)
        {
            String[] roemisch = new String[] { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            int[] dezimal = new int[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };

            int dezimalZahl = wert;
            string roemischer_wert = "";

            for (int i = 0; i < dezimal.Length; i++)
                while (dezimalZahl >= dezimal[i])
                {
                    roemischer_wert += roemisch[i];
                    dezimalZahl -= dezimal[i];
                }
            return roemischer_wert;
        }





        internal static string ausgabe(int romzahl)
        {
            string result = "Error";
            {
                result = (dez_zu_rom(romzahl));
                return result;
            }
        }
    }
}
