using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Collections;

namespace HHS.Tests
{
    [TestClass]
    public class ProductBacklogHelperTest
    {
        [TestMethod]
        public void TestCombine()
        {
    

            var items = new List<List<string>>
            {
                new List<string>
                {
                    "a", "b", "c"
                },
                new List<string>
                {
                    "a", "b", "c"
                },
                new List<string>
                {
                    "c", "b", "a"
                },
  
            };

            List<string> result = ProductBacklogHelper.Combine(items);
            Assert.AreEqual("a", result[0]);
            Assert.AreEqual("b", result[1]);
            Assert.AreEqual("c", result[2]);
        }
    }
}
