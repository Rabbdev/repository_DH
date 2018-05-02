using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_mit_test
{
    public class Hauptklasse
    {
        internal static string dez_zu_rom(int wert)
        {
            if ((wert < 1) || (wert > 3000)) { return ""; }
           
            StringBuilder sb = new StringBuilder(15);

            while ( wert - 1000  >= 0 )   { sb.Append("M" );  wert -= 1000  ;}
            while ( wert - 900   >= 0 )   { sb.Append("CM");  wert -= 900   ;}
            while ( wert - 500   >= 0 )   { sb.Append("D" );  wert -= 500   ;}
            while ( wert - 400   >= 0 )   { sb.Append("CD");  wert -= 400   ;}
            while ( wert - 100   >= 0 )   { sb.Append("C" );  wert -= 100   ;}
            while ( wert - 90    >= 0 )   { sb.Append("XC");  wert -= 90    ;}
            while ( wert - 50    >= 0 )   { sb.Append("L" );  wert -= 50    ;}
            while ( wert - 40    >= 0 )   { sb.Append("XL");  wert -= 40    ;}
            while ( wert - 10    >= 0 )   { sb.Append("X" );  wert -= 10    ;}
            while ( wert - 9     >= 0 )   { sb.Append("IX");  wert -= 9     ;}
            while ( wert - 5     >= 0 )   { sb.Append("V" );  wert -= 5     ;}
            while ( wert - 4     >= 0 )   { sb.Append("IV");  wert -= 4     ;}
            while ( wert - 1     >= 0 )   { sb.Append("I" );  wert -= 1     ;}

            return sb.ToString();

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
