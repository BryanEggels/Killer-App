using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Game_Mania_Killer_App.Context.Interfaces;
using Game_Mania_Killer_App.Models;

namespace Game_Mania_Killer_App.Repos
{
    public class ArtikelRepo
    {
        private IArtikelContext context;

        public ArtikelRepo(IArtikelContext context)
        {
            this.context = context;
        }
        public bool Add(Artikel artikel)
        {
            return context.Add(artikel);
        }

        public bool Delete(Artikel artikel)
        {
            return context.Delete(artikel);
        }

        public List<Artikel> GetAll()
        {
            return context.GetAll();
        }

        public List<Artikel> GetAll(Categorie categorie)
        {
            return context.GetAll(categorie);
        }
        public Artikel Get(int artikelnummer)
        {
            return context.Get(artikelnummer);
        }
    }
}