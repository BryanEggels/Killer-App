using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Game_Mania_Killer_App.Context.Interfaces;
using Game_Mania_Killer_App.Models;
using Game_Mania_Killer_App.Context;

namespace Game_Mania_Killer_App.Repos
{
    public class KlantRepo : IKlantContext
    {
        private IKlantContext context;

        public KlantRepo(IKlantContext context)
        {
            this.context = context;
        }
        public bool Add(Klant klant)
        {
            UserRepo urepo = new UserRepo(new UserSQLContext());

            AdresRepo arepo = new AdresRepo(new AdresSQLContext());

            klant.ID = urepo.Add(klant);
            if(klant.ID == 0)
            {
                return false;
            }
            klant.Adres.ID = arepo.Add(klant.Adres);
            return context.Add(klant);
        }

        public bool Delete(Klant klant)
        {
            return context.Delete(klant);
        }

        public List<Klant> GetAll()
        {
            return context.GetAll();
        }

        public Klant GetByID(int UserID)
        {
            UserRepo urepo = new UserRepo(new UserSQLContext());
            Klant k = context.GetByID(UserID);
            User u = urepo.GetByID(UserID);

            k.Voornaam = u.Voornaam;
            k.Gebruikersnaam = u.Gebruikersnaam;
            k.Achternaam = u.Achternaam;
            
            return k;
        }
    }
}