using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace HHS.Tests
{
    delegate void MyDelegate(string input);

    delegate void MyDelegate<T>(T input);
    delegate void MyDelegate<T1, T2>(T1 t1, T2 t2);

    [TestClass]
    public class LinqDemo
    {
        [TestMethod]
        public void TestMethod1()
        {
            Execute(new MyDelegate(Console.WriteLine));
            //Execute(Console.WriteLine);
        }

        private static void Execute(MyDelegate methode)
        {
            methode("hoi");
        }
        [TestMethod]
        public void TestDelegateWithGenerics()
        {
            Execute(new MyDelegate<int>(Console.WriteLine));
        }

        private static void Execute(MyDelegate<int> methode)
        {
            methode(3);
        }

        [TestMethod]
        public void TestWithActionAndFuncs()
        {

        }

        private static void Execute(Action<int> methode)
        {
            methode(3);
        }

        [TestMethod]
        public void TestFilteringAListWithDelegates()
        {
            int[] items = { 1, 2, 3, 5, 8, 13, 41 };
            int[] result = Filter(items, IsEqual);

            Assert.AreEqual(2, result[0]);
            Assert.AreEqual(8, result[1]);
        }

        private int[] Filter(int[] items, Func<int, bool> methode)
        {
            var result = new List<int>();
            foreach (var item in items)
            {
                if (methode(item))
                {
                    result.Add(item);
                }
            }

            return result.ToArray();
        }

        private bool IsEqual(int item)
        {
            return item % 2 == 0;
        }

        private bool IsDividableByThree(int item)
        {
            return item % 3 == 0;
        }

        [TestMethod]
        public void TestFilteringWithLambdas()
        {
            int[] items = { 1, 2, 3, 5, 8, 13, 41 };
            int[] result = Filter(items, i => i % 2 == 0);

            Filter(items, (int i) => i % 2 == 0);
            Filter(items, (int i) => { return i % 2 == 0; });

            Assert.AreEqual(2, result[0]);
            Assert.AreEqual(8, result[1]);
        }

        [TestMethod]
        public void ExtensMethodsDemo()
        {
            var result = StringHelper.RemoveAllVowels("input");
            Assert.AreEqual("npt", result);

            var result2 = "input".RemoveAllVowels();
            Assert.AreEqual("npt", result2);

        }

        [TestMethod]
        public void TestFilterWithLinq()
        {
            int[] items = { 1, 2, 3, 5, 8, 13, 41 };
            int[] result1 = Enumerable.Where(items, i => i % 2 == 0).ToArray();
            int[] result2 = items.Where(i => i % 2 == 0).ToArray();

            Assert.AreEqual(2, result2[0]);
            Assert.AreEqual(8, result2[1]);


        }

        class Person
        {
            public DateTime BirthDate { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        [TestMethod]
        public void TestOrderingWithLinq()
        {
            var persons = new List<Person>
            {
                new Person 
                {
                    BirthDate = new DateTime(1982, 04, 05),
                    FirstName = "Manuel",
                    LastName = "Riezebosch"

                },
                new Person
                {
                    BirthDate = new DateTime(1983, 04, 18),
                    FirstName = "Little",
                    LastName = "Brother"
                }
            };

            persons.OrderBy(p => p.BirthDate);

        }

        [TestMethod]
        public void LinqOefening()
        {
            // selecteer plaatsnamen korter dan 8 karakters
            // gesorteerd op lengte
            // bij gelijke lengte gesorteerd op alfabet.

            var plaatsnamen = new List<string>
            { 
                "Amsterdam", "Arnhem", "Amersfoort",
                "Assen", "Amstelveen", "Alphen"
            };
        }
    }
}
