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
            [Test, Category("Akzeptanztest")]
            public void Test_zahl()
            {
                var ergebnis = Hauptklasse.dez_zu_rom(2017);
                Assert.AreEqual("MMXVII", ergebnis);
            }
            [Test, Category("Gerüsttest")]
            public void Test_Ausgabe()
            {
                var ergebnis = Hauptklasse.ausgabe(99);
                Assert.AreEqual("XCIX", ergebnis);
            }
        }  
}
