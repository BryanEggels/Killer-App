using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Game_Mania_Killer_App.Context.Interfaces;
using Game_Mania_Killer_App.Models;

namespace Game_Mania_Killer_App.Repos
{
    public class BestellingRepo
    {
        private IBestellingContext context;

        public BestellingRepo(IBestellingContext context)
        {
            this.context = context;
        }
        public bool Add(Bestelling bestelling)
        {
            return context.Add(bestelling);
        }

        public bool Delete(Bestelling bestelling)
        {
            return context.Delete(bestelling);
        }

        public List<Bestelling> GetAll()
        {
            return context.GetAll();
        }

        public List<Bestelling> GetAll(Klant klant)
        {
            return context.GetAll(klant);
        }
    }
}