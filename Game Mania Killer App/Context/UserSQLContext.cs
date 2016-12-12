using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Game_Mania_Killer_App.Context.Interfaces;
using Game_Mania_Killer_App.Models;
using System.Data.SqlClient;

namespace Game_Mania_Killer_App.Context
{
    public class UserSQLContext : IUserContext
    {
        public List<User> GetAll()
        {
            throw new NotImplementedException();
        }
        public User Login(string Gebruikersnaam, string Wachtwoord)
        {
            string query = "SELECT * FROM [User] WHERE Gebruikersnaam = @Gebruiker and [Wachtwoord] = @Wachtwoord;";

            using (SqlConnection con = Database.Connection)
            {
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@Gebruiker", Gebruikersnaam);
                cmd.Parameters.AddWithValue("@Wachtwoord", Wachtwoord);

                try
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        return new User
                        {
                            ID = Convert.ToInt32(reader["ID"]),
                            Voornaam = reader["Voornaam"].ToString(),
                            Achternaam = reader["Achternaam"].ToString(),
                            Gebruikersnaam = reader["Gebruikersnaam"].ToString()
                        };
                    }
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.Message);
                }
                return null;

            }
        }

        public int Add(User user)
        {
            string query = "INSERT INTO [User] (Voornaam, Achternaam, Gebruikersnaam, Wachtwoord) VALUES (@Voornaam, @Achternaam, @Gebruikersnaam, @Wachtwoord)" +
                "SELECT SCOPE_IDENTITY()";

            using (SqlConnection con = Database.Connection)
            {
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@Voornaam", user.Voornaam);
                cmd.Parameters.AddWithValue("@Achternaam", user.Achternaam);
                cmd.Parameters.AddWithValue("@Gebruikersnaam", user.Gebruikersnaam);
                cmd.Parameters.AddWithValue("@Wachtwoord", user.Wachtwoord);

                try
                {
                    return Convert.ToInt32(cmd.ExecuteScalar());

                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.Message);
                }
                return 0;
            }
        }
        public User GetByID(int UserID)
        {
            string query = "SELECT * FROM [User] WHERE ID = @id;";

            using (SqlConnection con = Database.Connection)
            {
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@id", UserID);

                try
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    {
                        return new User
                        {
                            ID = Convert.ToInt32(reader["ID"]),
                            Voornaam = reader["Voornaam"].ToString(),
                            Achternaam = reader["Achternaam"].ToString(),
                            Gebruikersnaam = reader["Gebruikersnaam"].ToString()
                        };
                    }
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.Message);
                }
                return null;
            }

        }
    }
}