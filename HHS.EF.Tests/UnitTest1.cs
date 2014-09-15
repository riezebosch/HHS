using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HHS.EF;
using System.Data.Entity;
using System.Linq;
using System.Collections.Generic;

namespace HHS.EF.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Database.SetInitializer<VoetbalContext>(new DropCreateDatabaseAlways<VoetbalContext>());

            var context = new VoetbalContext();
            context.Teams.Add(new Team
                {
                    Naam = "ADO Den Haag"
                });
        }

        [TestMethod]
        public void TestWithRelations()
        {
            Database.SetInitializer<VoetbalContext>(new DropCreateDatabaseAlways<VoetbalContext>());

            using(var context = new VoetbalContext())
            {
                context.Teams.Add(new Team
                    {
                        Naam = "Feyenoord",
                        Spelers = new List<Speler>
                        {
                            new Speler
                            {
                                Naam = "Kenneth Vermeer"
                            }
                        }
                    });

                context.SaveChanges();
            }
        }

        [TestMethod]
        public void TestDatabaseFirst()
        {
            var context = new Model1();
            context.Person.Where(p => p.FirstName.StartsWith("m")).Select(p => p.HireDate);
        }
    }
}
