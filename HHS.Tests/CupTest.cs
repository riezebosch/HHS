using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HHS.Tests
{
    [TestClass]
    public class CupTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var c = new Cup<int>();
            c.Beverage = 3;
        }

        class Thee
        {
            public bool Sugar { get; set; }
            public Flavour Flavour { get; set; }
        }

        [TestMethod]
        public void TestCupWithThee()
        {
            var c = new Cup<Thee>();
            c.Beverage = new Thee
            {
                Sugar = false,
                Flavour = Flavour.EarlGrey
            };
        }
    }
}
