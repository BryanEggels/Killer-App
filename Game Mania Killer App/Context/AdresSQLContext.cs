using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Game_Mania_Killer_App.Context.Interfaces;
using Game_Mania_Killer_App.Models;
using System.Data.SqlClient;

namespace Game_Mania_Killer_App.Context
{
    public class AdresSQLContext : IAdresContext
    {
        public int? Add(Adres adres)
        {
            string select_query = "SELECT ID FROM Adres WHERE Huisnummer = @Huisnummer and Straat = @Straat and Postcode = @Postcode and Plaats = @Plaats";

            using (SqlConnection con = Database.Connection)
            {
                SqlCommand select_cmd = new SqlCommand(select_query, con);

                select_cmd.Parameters.AddWithValue("@Huisnummer", adres.Huisnummer);
                select_cmd.Parameters.AddWithValue("@Straat", adres.Straat);
                select_cmd.Parameters.AddWithValue("@Postcode", adres.Postcode);
                select_cmd.Parameters.AddWithValue("@Plaats", adres.Plaats);
                try
                {
                    adres.ID = Convert.ToInt32(select_cmd.ExecuteScalar());
                    if (adres.ID != 0)
                    { 
                        return adres.ID;
                    }
                    else
                    {
                        string insert_query = "INSERT INTO Adres (Huisnummer,Straat,Postcode,Plaats) VALUES (@Huisnummer,@Straat,@Postcode,@Plaats)" +
                            "SELECT SCOPE_IDENTITY()";
                        SqlCommand insert_cmd = new SqlCommand(insert_query, con);
                        insert_cmd.Parameters.AddWithValue("@Huisnummer", adres.Huisnummer);
                        insert_cmd.Parameters.AddWithValue("@Straat", adres.Straat);
                        insert_cmd.Parameters.AddWithValue("@Postcode", adres.Postcode);
                        insert_cmd.Parameters.AddWithValue("@Plaats", adres.Plaats);
                        
                        return adres.ID = Convert.ToInt32(insert_cmd.ExecuteScalar()); //wtf is going on right here
                    }
                }
                catch(SqlException e)
                {
                    Console.WriteLine(e.Message);
                    return null;
                }
            }
        }
        public bool Delete(Adres adres)
        {
            throw new NotImplementedException();
        }

        public List<Adres> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}