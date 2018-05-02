using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_mit_test
{
    public class Hauptklasse
    {
        public static List<int> Start_Zahlen_testen (int untergrenze, int obergrenze)
        {
            var zahlen = Zahlen_testen(untergrenze, obergrenze);
            return zahlen;
        }

        internal static List<int> Zahlen_testen (int untergrenze, int obergrenze)
        {
            var zahlen = new List<int>();
            for (int z = untergrenze; z <= obergrenze; z++)
            {
                zahlen.Add(z);
            }
            return zahlen;
        }
    }
}
