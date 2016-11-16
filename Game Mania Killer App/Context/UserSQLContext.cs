using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Game_Mania_Killer_App.Context.Interfaces;
using Game_Mania_Killer_App.Models;

namespace Game_Mania_Killer_App.Context
{
    public class UserSQLContext : IUserContext
    {
        public List<User> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}