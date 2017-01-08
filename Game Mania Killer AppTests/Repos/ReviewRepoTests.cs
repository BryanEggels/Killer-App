using Microsoft.VisualStudio.TestTools.UnitTesting;
using Game_Mania_Killer_App.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_Mania_Killer_App.Context;
using Game_Mania_Killer_App.Models;

namespace Game_Mania_Killer_App.Repos.Tests
{
    [TestClass()]
    public class ReviewRepoTests
    {
        [TestMethod()]
        public void ReviewRepoTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void AddTest()
        {
            Review r = new Review
            {
                Artikel = new Artikel
                {
                    Artikelnummer = 5
                },
                Comment = "gaaf!",
                Klant = new Klant
                {
                    ID = 1
                },
                Score = 5,
                Titel = "leuk spel"
            };
            ReviewRepo repo = new ReviewRepo(new ReviewSQLContext());
            Assert.AreEqual(true,repo.Add(r));

        }
        [TestMethod()]
        public void DeleteTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetAllTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetAllTest1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetAllTest2()
        {
            Assert.Fail();
        }
    }
}