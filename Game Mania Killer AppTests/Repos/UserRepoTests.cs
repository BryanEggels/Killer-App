using Microsoft.VisualStudio.TestTools.UnitTesting;
using Game_Mania_Killer_App.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_Mania_Killer_App.Models;
using Game_Mania_Killer_App.Context;

namespace Game_Mania_Killer_App.Repos.Tests
{
    [TestClass()]
    public class UserRepoTests
    {
        [TestMethod()]
        public void UserRepoTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetAllTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void LoginTest()
        {
            Klant k = new Klant
            {
                Gebruikersnaam = "admin",
                Wachtwoord = "admin",
                ID = 1
            };
            UserRepo repo = new UserRepo(new UserSQLContext());

            User user = repo.Login(k.Gebruikersnaam, k.Wachtwoord);
            Assert.AreEqual("Bryan", user.Voornaam);

        }

        [TestMethod()]
        public void AddTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetByIDTest()
        {
            Assert.Fail();
        }
    }
}