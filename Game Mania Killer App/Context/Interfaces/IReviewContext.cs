using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_Mania_Killer_App.Models;

namespace Game_Mania_Killer_App.Context.Interfaces
{
     public interface IReviewContext
    {
        List<Review> GetAll();
        List<Review> GetAll(Klant klant);
        List<Review> GetAll(Artikel artikel);
        bool Add(Review review);
        bool Delete(Review review);

    }
}
