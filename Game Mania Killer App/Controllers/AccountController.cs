using Game_Mania_Killer_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Game_Mania_Killer_App.Repos;
using Game_Mania_Killer_App.Context;

namespace Game_Mania_Killer_App.Controllers
{
    public class AccountController : Controller
    {
        // POST: Account
        [HttpPost]
        public ActionResult Login(string Gebruikersnaam, string Wachtwoord)
        {
            UserRepo repo = new UserRepo(new UserSQLContext());
            User gebruiker = repo.Login(Gebruikersnaam, Wachtwoord);
            if (gebruiker != null)
            {
                this.Session["User"] = gebruiker;
                gebruiker.Gebruikersnaam = Gebruikersnaam;
                return Redirect(Request.UrlReferrer.PathAndQuery);
            }
            return Redirect(Request.UrlReferrer.PathAndQuery);
        }
        public ActionResult Logout()
        {
            this.Session.Clear();
            return RedirectToAction("Index", "Home");
        }
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Postregister(string Gebruikersnaam, string Wachtwoord, string Email, string Voornaam, string Achternaam, 
            string Postcode, string Huisnummer, string straat, string Plaats)
        {
            KlantRepo repo = new KlantRepo(new KlantSQLContext());

            Adres a = new Adres
            {
                Huisnummer = Huisnummer,
                Postcode = Postcode,
                Straat = straat,
                Plaats = Plaats
            };
            Klant k = new Klant
            {
                Gebruikersnaam = Gebruikersnaam,
                Wachtwoord = Wachtwoord,
                E_mail = Email,
                Achternaam = Achternaam,
                Voornaam = Voornaam
                
            };
            k.Adres = a;           
            if (!repo.Add(k))
            {
                ViewBag.registratie = false;
                return RedirectToAction("Index", "Home");
            }
            ViewBag.registratie = true;


            return RedirectToAction("Index", "Home");
        }

    }
}