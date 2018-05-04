using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_mit_test
{
    public class Hauptklasse
    {
        internal static int rechnen_und_ausgabe(int x, int y)
        {
                int result = 0;
                result = Logik_Klasse.Mul(x, y);
                return result;    
        }
    }
}
