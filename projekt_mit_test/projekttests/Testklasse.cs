using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using projekt_mit_test;

namespace projekttests
{
    [TestFixture]
    public class Testklasse
    {
        [Test, Category("Akzeptanztest")]

        public void Zahlen_zwischen_obergrenze_und_untergrenze()
        {
            var ergebnis = Hauptklasse.Start_Zahlen_testen(3, 10);
            Assert.AreEqual(new[]{ 3, 4, 5, 6, 7, 8, 9, 10 }, ergebnis.ToArray());


        }

        [Test, Category("Gerüsttest")]

        public void Anzahl_Zahlen()
        {
            var ergebnis = Hauptklasse.Zahlen_testen(0, 45);
            Assert.AreEqual(46, ergebnis.Count());
           

        }

    }
}
