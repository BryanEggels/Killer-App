using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Game_Mania_Killer_App.Models
{
    public class Categorie
    {
        public int ID { get; set; }
        public string Naam { get; set; }
        public int ParentID { get; set; }

        public List<Artikel> Artikelen { get; set; }
    }
}