using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Game_Mania_Killer_App.Repos;
using Game_Mania_Killer_App.Context;
using Game_Mania_Killer_App.Models;

namespace Game_Mania_Killer_App.Controllers
{
    public class GamesController : Controller
    {
        // GET: Games
        public ActionResult Xbox(string artikel)
        {
            ArtikelRepo arepo = new ArtikelRepo(new ArtikelSQLContext());
            if (artikel == null)
            {
                
                ViewBag.artikelen = arepo.GetAll(new Categorie { ID = 1});
                return View();
            }   
            ViewBag.artikel = arepo.Get(Convert.ToInt32(artikel));
            return View();
            
        }
        public ActionResult Playstation(string artikel)
        {
            ArtikelRepo arepo = new ArtikelRepo(new ArtikelSQLContext());
            if (artikel == null)
            {

                ViewBag.artikelen = arepo.GetAll(new Categorie { ID = 6 });
                return View();
            }
            ViewBag.artikel = arepo.Get(Convert.ToInt32(artikel));
            return View();
            
        }
        public ActionResult Wii(string artikel)
        {
            ArtikelRepo arepo = new ArtikelRepo(new ArtikelSQLContext());
            if (artikel == null)
            {

                ViewBag.artikelen = arepo.GetAll(new Categorie { ID = 5 });
                return View();
            }
            ViewBag.artikel = arepo.Get(Convert.ToInt32(artikel));
            return View();
        }

    }
}
