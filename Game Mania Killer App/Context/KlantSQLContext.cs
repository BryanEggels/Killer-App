using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Game_Mania_Killer_App.Context.Interfaces;
using Game_Mania_Killer_App.Models;
using System.Data.SqlClient;
using Game_Mania_Killer_App.Repos;

namespace Game_Mania_Killer_App.Context
{
    public class KlantSQLContext : IKlantContext
    {
        public bool Add(Klant klant)
        {
            string userquery = "INSERT INTO Klant (GebruikersID, AdresID, [E-mail]) VALUES (@GebruikersID,@AdresID,@Email)";

            using (SqlConnection con = Database.Connection)
            {
                SqlCommand cmd = new SqlCommand(userquery, con);

                cmd.Parameters.AddWithValue("@GebruikersID", klant.ID);
                cmd.Parameters.AddWithValue("@AdresID", klant.Adres.ID);
                cmd.Parameters.AddWithValue("@Email", klant.E_mail);

                try
                {
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        return true;
                    }

                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.Message);
                }
                return false;
            }
        }
        public bool Delete(Klant klant)
        {
            throw new NotImplementedException();
        }

        public List<Klant> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}