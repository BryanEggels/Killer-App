using Microsoft.VisualStudio.TestTools.UnitTesting;
using Game_Mania_Killer_App.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_Mania_Killer_App.Models;

namespace Game_Mania_Killer_App.Context.Tests
{
    [TestClass()]
    public class BestellingSQLContextTests
    {
        [TestMethod()]
        public void AddTest()
        {
            BestellingSQLContext context = new BestellingSQLContext();
            Bestelling b = new Bestelling();
            b.Artikelen.Add(new Artikel { Artikelnummer = 1 });
            b.Artikelen.Add(new Artikel { Artikelnummer = 5 });
            b.Artikelen.Add(new Artikel { Artikelnummer = 9 });
            Klant k = new Klant { ID = 5 };
            b.klant = k;

            Assert.AreEqual(true, context.Add(b));
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
    }
}