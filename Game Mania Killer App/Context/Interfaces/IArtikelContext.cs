using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_Mania_Killer_App.Models;

namespace Game_Mania_Killer_App.Context.Interfaces
{
    public interface IArtikelContext
    {
        List<Artikel> GetAll();
        List<Artikel> GetAll(Categorie categorie);

        bool Delete(Artikel artikel);
        bool Add(Artikel artikel);
    }
}
