using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Game_Mania_Killer_App.Models
{
    public class Artikel
    {
        int Artikelnummer { get; set; }
        string Naam { get; set; }
        string Merk { get; set; }
        int Prijs { get; set; }
        int aantal { get; set; } //new
        Leverancier Leverancier { get; set; }
        Categorie Categorie { get; set; }

    }
}