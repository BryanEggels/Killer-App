using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Game_Mania_Killer_App.Models
{
    public class Leverancier : User
    {
        public string Lnaam { get; set; }
        public Adres adres { get; set; }
    }
}