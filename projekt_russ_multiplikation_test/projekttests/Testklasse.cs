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
        public class russ_mult_test
        {

        [Test, Category("Test1_ergebnis")]

        public void Test_ergebnis()
        {
            var ergebnis = Hauptklasse.rechnen_und_ausgabe(70, 41);
            Assert.AreEqual(2870, ergebnis);
        }


        [Test, Category("Test2_halbieren")]

        public void Test_halbieren()
        {
            var ergebnis = Logik_Klasse.ZahlHalbieren(10);
            Assert.AreEqual(5, ergebnis);
        }

        [Test, Category("Test3_verdoppeln")]

        public void Test_verdoppeln()
        {
            var ergebnis = Logik_Klasse.ZahlVerdoppeln(10);
            Assert.AreEqual(20, ergebnis);
        }

        [Test, Category("Test4_anzahl_teilungen")]

        public void Test_teilungen()
        {
            var ergebnis = Logik_Klasse.AnzahlMöglicheTeilungen(10);
            Assert.AreEqual(4, ergebnis);
        }

       

        //------------------------

    }
    }
