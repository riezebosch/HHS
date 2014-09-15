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
                },
                new List<string>
                {
                },
                new List<string>
                {
                },
                new List<string>
                {
                },
            };

            List<string> result = ProductBacklogHelper.Combine(items);
        }
    }
}
