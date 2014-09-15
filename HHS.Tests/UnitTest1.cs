using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HHS.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var geboortedatum = new DateTime(1982, 04, 05);

            int leeftijd = Class1.Bereken(geboortedatum);

            Assert.AreEqual(32, leeftijd);
        }

        [TestMethod]
        public void TestEenAndereLeeftijd()
        {
            var geboortedatum = new DateTime(1983, 04, 18);

            int leeftijd = Class1.Bereken(geboortedatum);

            Assert.AreEqual(31, leeftijd);
        }

        [TestMethod]
        public void TestIemandJarigInHuidigeMaandMaarDagIsNogNietVerstreken()
        {
            var geboortedatum = new DateTime(1983, 9, 18);

            int leeftijd = Class1.Bereken(geboortedatum);

            Assert.AreEqual(30, leeftijd);
        }

        [TestMethod]
        public void TestDatumNogNietVerstreken()
        {
               var geboortedatum = new DateTime(1983, 10, 18);

            int leeftijd = Class1.Bereken(geboortedatum);

            Assert.AreEqual(30, leeftijd);
        }

        [TestMethod]
        public void TestVandaagJarig()
        {
               var geboortedatum = new DateTime(1983, 09, 15);

            int leeftijd = Class1.Bereken(geboortedatum);

            Assert.AreEqual(31, leeftijd);
        }

        
    }
}
