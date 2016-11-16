using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Game_Mania_Killer_App.Context.Interfaces;
using Game_Mania_Killer_App.Models;

namespace Game_Mania_Killer_App.Repos
{
    public class ReviewRepo 
    {
        private IReviewContext context;


        public ReviewRepo(IReviewContext context)
        {
            this.context = context;
        }
        public bool Add(Review review)
        {
            return context.Add(review);
        }

        public bool Delete(Review review)
        {
            return context.Delete(review);
        }

        public List<Review> GetAll()
        {
            return context.GetAll();
        }

        public List<Review> GetAll(Klant klant)
        {
            return context.GetAll(klant);
        }
    }
}