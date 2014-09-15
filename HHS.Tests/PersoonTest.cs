using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HHS;

namespace HHS.Tests
{
    [TestClass]
    public class PersoonTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var p = new Persoon();
            p.MyAutoImplementedProperty = 3;

            Console.WriteLine(p.MyAutoImplementedProperty);
        }

        [TestMethod]
        public void ShowMeSomeReflectionBaby()
        {
            var p = new Persoon();
            p.setGeboorteDatum(new DateTime(1982, 04, 05));

            //var geheim = p.getGeboorteDatum();

            Type t1 = typeof(Persoon);
            Type t2 = p.GetType();

            Assert.AreEqual(t1, t2);

            var field = t1.GetField("_geboorteDatum", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            Assert.IsNotNull(field);

            var value = field.GetValue(p);
            Console.WriteLine(value);
        }
    }
}
