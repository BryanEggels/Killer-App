using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Game_Mania_Killer_App.Context.Interfaces;
using Game_Mania_Killer_App.Models;

namespace Game_Mania_Killer_App.Repos
{
    public class AdresRepo
    {
        private IAdresContext context;

        public AdresRepo(IAdresContext context)
        {
            this.context = context;
        }
        public int Add(Adres adres)
        {
            return (int)context.Add(adres);
        }

        public bool Delete(Adres adres)
        {
            return context.Delete(adres);
        }

        public List<Adres> GetAll()
        {
            return context.GetAll();
        }
    }
}