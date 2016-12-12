using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Game_Mania_Killer_App.Context.Interfaces;
using Game_Mania_Killer_App.Models;
using System.Data.SqlClient;
using Game_Mania_Killer_App.Repos;
using Game_Mania_Killer_App.Context;

namespace Game_Mania_Killer_App.Context
{
    public class ReviewSQLContext : IReviewContext
    {
        public bool Add(Review review)
        {
            string query = "INSERT INTO Review (ArtikelID,KlantID,Score,Comment,Titel) VALUES (@artikel,@klant,@score,@comment,@titel)";

            using (SqlConnection con = Database.Connection)
            {
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@artikel", review.Artikel.Artikelnummer);
                cmd.Parameters.AddWithValue("@klant", review.Klant.ID);
                cmd.Parameters.AddWithValue("@score", review.Score);
                cmd.Parameters.AddWithValue("@comment", review.Comment);
                cmd.Parameters.AddWithValue("@titel", review.Titel);
                
                try
                {
                    if(cmd.ExecuteNonQuery() > 0)
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
        public List<Review> GetAll(Artikel artikel)
        {
            List<Review> reviews = new List<Review>();
            KlantRepo krepo = new KlantRepo(new KlantSQLContext());
            string select_query = "SELECT * FROM Review WHERE ArtikelID = @id";

            using (SqlConnection con = Database.Connection)
            {
                SqlCommand select_cmd = new SqlCommand(select_query, con);
                select_cmd.Parameters.AddWithValue("@id", artikel.Artikelnummer);

                try
                {
                    SqlDataReader reader = select_cmd.ExecuteReader();
                    while (reader.Read())
                    {


                        reviews.Add(new Review
                        {
                            Comment = reader["Comment"].ToString(),
                            Score = Convert.ToInt32(reader["Score"]),
                            Titel = reader["Titel"].ToString(),
                            Klant = krepo.GetByID(Convert.ToInt32(reader["KlantID"])), //casten werkt hier niet omdat een user niet altijd een klant is.
                            Artikel = new Artikel                                             //dit moet via de klantrepo gebeuren en dan een klant returnen
                            {
                                Artikelnummer = Convert.ToInt32(reader["ArtikelID"])
                            }
                        });
                    }
                    return reviews;

                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.Message);
                }
                return reviews;
            }         
        }
    }
}