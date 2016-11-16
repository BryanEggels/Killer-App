using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Game_Mania_Killer_App.Context.Interfaces;
using Game_Mania_Killer_App.Models;

namespace Game_Mania_Killer_App.Context
{
    public class ReviewSQLContext : IReviewContext
    {
        public bool Add(Review review)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Review review)
        {
            throw new NotImplementedException();
        }

        public List<Review> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Review> GetAll(Klant klant)
        {
            throw new NotImplementedException();
        }
    }
}