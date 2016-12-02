using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_Mania_Killer_App.Models;

namespace Game_Mania_Killer_App.Context.Interfaces
{
    public interface IAdresContext
    {
        List<Adres> GetAll();
        int? Add(Adres adres);
        bool Delete(Adres adres);

    }
}
