using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_mit_test
{
    public class Logik_Klasse
    {
        internal static int Mul(int x, int y)
        {
            var anzahl = AnzahlMöglicheTeilungen(x);
            var zahlenX = ZahlenErmitteln(x, anzahl, ZahlHalbieren);
            var zahlenY = ZahlenErmitteln(y, anzahl, ZahlVerdoppeln);
            var zahlen = WerteVergleichen(zahlenX, zahlenY);
            return ZahlenAddieren(zahlen);
        }

        internal static int AnzahlMöglicheTeilungen(int x)
        {
            int i = 0;
            for(i = 0; x >= 1; i++)
            {
                x = x / 2;
            }


            //return Convert.ToInt16(Math.Log(Convert.ToDouble(x)) / Math.Log(2.0));
            return i;
        }

        internal static IEnumerable<int> ZahlenErmitteln(int wert, int anzahl, Func<int, int> NeuerWert)
        {
            IList<int> liste = new List<int>();
            int i = 0;
            while (i < anzahl)
            {
                liste.Add(wert);
                wert = NeuerWert(wert);
                i++;
            }
            return liste;
        }

        internal static int ZahlHalbieren(int wert)
        {
            return wert / 2;
        }

        internal static int ZahlVerdoppeln(int wert)
        {
            return wert * 2;
        }

        internal static IEnumerable<int> WerteVergleichen(IEnumerable<int> x, IEnumerable<int> y)
        {
            List<int> liste = new List<int>();
            for (int i = 0; i < x.Count(); i++)
            {
                if (x.ElementAt(i) % 2 != 0)
                {
                    liste.Add(y.ElementAt(i));
                }
            }
            return liste;
        }

        internal static int ZahlenAddieren(IEnumerable<int> zahlen)
        {
            return zahlen.Sum();
        }
    }
}

