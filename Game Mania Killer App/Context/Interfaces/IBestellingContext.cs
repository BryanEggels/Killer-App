using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_Mania_Killer_App.Models;

namespace Game_Mania_Killer_App.Context.Interfaces
{
    public interface IBestellingContext
    {
        List<Bestelling> GetAll();
        List<Bestelling> GetAll(Klant klant);
        bool Add(Bestelling bestelling);
        bool Delete(Bestelling bestelling);

    }
}
