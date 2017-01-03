using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Game_Mania_Killer_App.Models;
using Game_Mania_Killer_App.Repos;
using Game_Mania_Killer_App.Context;

namespace Game_Mania_Killer_App.Controllers
{
    public class BestellingController : Controller
    {
        // GET: Bestelling

        [HttpGet]
        public ActionResult add(int artikel)
        {
            ArtikelRepo artrepo = new ArtikelRepo(new ArtikelSQLContext());
            Artikel art = artrepo.Get(artikel);
            if (this.Session["bestelling"] == null)
            {
                this.Session["bestelling"] = new Bestelling();
            }
            Bestelling b = (Bestelling)this.Session["bestelling"];
            bool artikel_bestaat = false;
            foreach (Artikel a in b.Artikelen)
            {
                if(a.Artikelnummer == art.Artikelnummer)
                {
                    a.Aantal++;
                    artikel_bestaat = true;
                }
            }
            if(!artikel_bestaat)
            {
                b.Artikelen.Add(art);
            }
            
            this.Session["bestelling"] = b;

            return RedirectToAction("Huidig", "Bestelling");
        }
        public ActionResult Huidig()
        {
            return View();
        }
        public ActionResult Betalen()
        {
            
            Bestelling b = (Bestelling)this.Session["bestelling"];
            if (Session["User"] != null)
            {
                b.klant = (User)Session["User"];
                if (new BestellingRepo(new BestellingSQLContext()).Add(b))
                {
                    Session["bestelling"] = new Bestelling();
                }
                else
                {
                    return Content("<script language='javascript' type='text/javascript'>alert('Er is iets misgegaan, probeer het opnieuw');</script>");
                }
            }         
            return View();
        }
    }
}