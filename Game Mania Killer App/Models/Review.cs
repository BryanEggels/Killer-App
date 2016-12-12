using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Game_Mania_Killer_App.Models
{
    public class Review
    {
        public string Comment { get; set; }
        public int Score { get; set; }
        public string Titel { get; set; }

        public Klant Klant { get; set; }
        public Artikel Artikel { get; set; }
    }
}