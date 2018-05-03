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
        public class Rom_Zahl_test
        {
            [Test, Category("Umrechungstest")]
            public void Test_zahl()
            {
                var ergebnis = Hauptklasse.dez_zu_rom(2017);
                Assert.AreEqual("MMXVII", ergebnis);
            }
            [Test, Category("Ausgabetest")]
            public void Test_Ausgabe()
            {
                var ergebnis = Hauptklasse.ausgabe(99);
                Assert.AreEqual("XCIX", ergebnis);
            }

            [Test, Category("Test für ungültigen Zahlenwert")]
             public void Test_ungueltige_werte()
            {
                var gueltigkeit = Hauptklasse.werte_bereich(3001);
                Assert.AreEqual("Der Wert ist nicht gültig, er muss zwischen 1 und 3000 liegen.", gueltigkeit);
            }

            [Test, Category("Test für gültigen Zahlenwert")]
            public void Test_gueltige_werte()
            {
                var gueltigkeit = Hauptklasse.werte_bereich(300);
                Assert.AreEqual("", gueltigkeit);
            }


    }  
}
