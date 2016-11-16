using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Game_Mania_Killer_App.Context.Interfaces;
using Game_Mania_Killer_App.Models;

namespace Game_Mania_Killer_App.Context
{
    public class ArtikelSQLContext : IArtikelContext
    {
        public bool Add(Artikel artikel)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Artikel artikel)
        {
            throw new NotImplementedException();
        }

        public List<Artikel> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Artikel> GetAll(Categorie categorie)
        {
            throw new NotImplementedException();
        }
    }
}