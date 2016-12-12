using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_Mania_Killer_App.Models;

namespace Game_Mania_Killer_App.Context.Interfaces
{
    public interface IKlantContext
    {
        bool Add(Klant klant);
        bool Delete(Klant klant);
        List<Klant> GetAll();
        Klant GetByID(int UserID);
    }
}
