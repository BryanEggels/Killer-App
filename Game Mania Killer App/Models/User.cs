using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Game_Mania_Killer_App.Models
{
    public abstract class User
    {
        int ID;
        string Naam;
        string Achternaam;

        Adres Adres;

        public override string ToString()
        {
            return Naam + " " + Achternaam;
        }
    }
}