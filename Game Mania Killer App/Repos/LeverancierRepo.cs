using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Game_Mania_Killer_App.Context.Interfaces;
using Game_Mania_Killer_App.Models;

namespace Game_Mania_Killer_App.Repos
{
    public class LeverancierRepo
    {
        private ILeverancierContext context;
        public LeverancierRepo(ILeverancierContext context)
        {
            this.context = context;
        }
        public bool Add(Leverancier leverancier)
        {
            return context.Add(leverancier);
        }

        public bool Delete(Leverancier leverancier)
        {
            return context.Delete(leverancier);
        }

        public List<Leverancier> GetAll()
        {
            return context.GetAll();
        }
    }
}