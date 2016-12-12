using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_Mania_Killer_App.Models;

namespace Game_Mania_Killer_App.Context.Interfaces
{
    public interface IUserContext
    {
        List<User> GetAll();
        User Login(string Gebruikersnaam, string Wachtwoord);
        int Add(User user);
        User GetByID(int UserID);

    }
}
