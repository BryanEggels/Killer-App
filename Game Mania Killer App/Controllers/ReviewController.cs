using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Game_Mania_Killer_App.Models;
using Game_Mania_Killer_App.Context;
using Game_Mania_Killer_App.Repos;

namespace Game_Mania_Killer_App.Controllers
{
    public class ReviewController : Controller
    {
        // Post: Review
        [HttpPost]
        public ActionResult add(string comment, string titel, int artikel, int score)
        {
            User u = (User)this.Session["User"];
            ReviewRepo repo = new ReviewRepo(new ReviewSQLContext());
            repo.Add(new Review
                {
                    Artikel = new Artikel
                    {
                        Artikelnummer = artikel
                    },
                    Comment = comment,
                    Score = score,
                    Titel = titel,
                    Klant = new Klant
                        {
                            ID = u.ID
                        }
                });

            return Redirect(Request.UrlReferrer.PathAndQuery);
        }
    }
}