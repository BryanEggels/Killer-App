using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Game_Mania_Killer_App.Context.Interfaces;
using Game_Mania_Killer_App.Models;

namespace Game_Mania_Killer_App.Repos
{
    public class UserRepo : IUserContext
    {
        private IUserContext context;
        public UserRepo(IUserContext context)
        {
            this.context = context;
        }
        public List<User> GetAll()
        {
            return context.GetAll();
        }
    }
}