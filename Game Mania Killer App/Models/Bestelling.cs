using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Mania_Killer_App.Models
{
    public class Bestelling
    {
        int Bestelnummer { get; set; }
        public User klant { get; set; }

        public List<Artikel> Artikelen{ get; set; }

        public Bestelling()
        {
            Artikelen = new List<Artikel>();
        }
    }
}
