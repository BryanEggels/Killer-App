using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Game_Mania_Killer_App.Context.Interfaces;
using Game_Mania_Killer_App.Models;

namespace Game_Mania_Killer_App.Context
{
    public class BestellingSQLContext : IBestellingContext
    {
        public bool Add(Bestelling bestelling)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Bestelling bestelling)
        {
            throw new NotImplementedException();
        }

        public List<Bestelling> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Bestelling> GetAll(Klant klant)
        {
            throw new NotImplementedException();
        }
    }
}