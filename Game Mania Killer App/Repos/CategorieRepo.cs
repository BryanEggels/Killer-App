using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Game_Mania_Killer_App.Context.Interfaces;
using Game_Mania_Killer_App.Models;

namespace Game_Mania_Killer_App.Repos
{
    public class CategorieRepo
    {
        private ICategorieContext context;

        public CategorieRepo(ICategorieContext context)
        {
            this.context = context;
        }

        public bool Add(Categorie categorie)
        {
            return context.Add(categorie);
        }

        public bool Delete(Categorie categorie)
        {
            return context.Delete(categorie);
        }

        public List<Categorie> GetAll()
        {
            return context.GetAll();
        }
    }
}