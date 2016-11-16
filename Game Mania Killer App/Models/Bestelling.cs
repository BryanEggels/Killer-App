using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Mania_Killer_App.Models
{
    class Bestelling
    {
        int Bestelnummer { get; set; }

        List<Artikel> Artikelen { get; set; }
    }
}
