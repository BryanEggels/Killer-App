using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using Game_Mania_Killer_App.Repos;
using Game_Mania_Killer_App.Context;

namespace Game_Mania_Killer_App.Models
{
    public class Artikel
    {
        public int Artikelnummer { get; set; }
        public string Naam { get; set; }
        public string Merk { get; set; }
        public double Prijs { get; set; }
        public int Aantal { get; set; }
        public Leverancier Leverancier { get; set; }
        public Categorie Categorie { get; set; }
        public List<Review> Reviews
        {
            get
            {
                ReviewRepo repo = new ReviewRepo(new ReviewSQLContext());
                return repo.GetAll(this);
            }
        }
        public string Afbeelding { get; set; }
        public string Description { get; set; }

        public Artikel()
        {
            Aantal = 1;
        }

        public override string ToString()
        {
            return Naam;
        }

    }
}