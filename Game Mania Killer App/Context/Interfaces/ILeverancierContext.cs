using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_Mania_Killer_App.Models;

namespace Game_Mania_Killer_App.Context.Interfaces
{
    public interface ILeverancierContext
    {
        List<Leverancier> GetAll();
        bool Add(Leverancier leverancier);
        bool Delete(Leverancier leverancier);

    }
}
