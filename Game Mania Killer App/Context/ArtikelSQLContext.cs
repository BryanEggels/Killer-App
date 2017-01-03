using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Game_Mania_Killer_App.Context.Interfaces;
using Game_Mania_Killer_App.Models;
using System.Data.SqlClient;

namespace Game_Mania_Killer_App.Context
{
    public class ArtikelSQLContext : IArtikelContext
    {
        public bool Add(Artikel artikel)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Artikel artikel)
        {
            throw new NotImplementedException();
        }

        public List<Artikel> GetAll()
        {
            List<Artikel> artikelen = new List<Artikel>();
            string select_query = "SELECT Artikelnummer,Naam,Merk,Prijs,Afbeelding,Afbeelding,Leverancier,CategorieID FROM Artikel";

            using (SqlConnection con = Database.Connection)
            {
                SqlCommand select_cmd = new SqlCommand(select_query, con);

                try
                {
                    SqlDataReader reader = select_cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        artikelen.Add(new Artikel
                        {
                            Artikelnummer = Convert.ToInt32(reader["Artikelnummer"]),
                            Naam = reader["Naam"].ToString(),
                            Merk = reader["Merk"].ToString(),                    
                            Prijs = Convert.ToDouble((reader["Prijs"])),
                            Afbeelding = reader["Afbeelding"].ToString(),

                            Leverancier = new Leverancier
                            {
                                ID = Convert.ToInt32(reader["Leverancier"])
                            },
                            Categorie = new Categorie
                            {
                                ID = Convert.ToInt32(reader["CategorieID"])
                            }
                        });
                    }
                    
                    
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.Message);
                }
                return artikelen;
            }
        }

        public List<Artikel> GetAll(Categorie categorie)
        {
            List<Artikel> artikelen = new List<Artikel>();
            string select_query = "SELECT Artikelnummer,Naam,Merk,Prijs,Afbeelding,Afbeelding,Description,Leverancier,CategorieID "
                +"FROM Artikel WHERE CategorieID = @id";

            using (SqlConnection con = Database.Connection)
            {
                SqlCommand select_cmd = new SqlCommand(select_query, con);
                select_cmd.Parameters.AddWithValue("@id", categorie.ID);

                try
                {
                    SqlDataReader reader = select_cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        artikelen.Add(new Artikel
                        {
                            Artikelnummer = Convert.ToInt32(reader["Artikelnummer"]),
                            Naam = reader["Naam"].ToString(),
                            Merk = reader["Merk"].ToString(),
                            Prijs = Convert.ToDouble(reader["Prijs"]),
                            Afbeelding = reader["Afbeelding"].ToString(),
                            Description = reader["Description"].ToString(),

                            Leverancier = new Leverancier
                            {
                                ID = Convert.ToInt32(reader["Leverancier"])
                            },
                            Categorie = new Categorie
                            {
                                ID = Convert.ToInt32(reader["CategorieID"])
                            }
                        });
                    }


                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.Message);
                }
                return artikelen;
            }
        }

        public Artikel Get(int artikelnummer)
        {
            string select_query = "SELECT Artikelnummer,Naam,Merk,Prijs,Afbeelding,Afbeelding,Description,Leverancier,CategorieID "
                +"FROM Artikel WHERE Artikelnummer = @id";

            using (SqlConnection con = Database.Connection)
            {
                SqlCommand select_cmd = new SqlCommand(select_query, con);
                select_cmd.Parameters.AddWithValue("@id", artikelnummer);

                try
                {
                    SqlDataReader reader = select_cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        return new Artikel
                        {
                            Artikelnummer = Convert.ToInt32(reader["Artikelnummer"]),
                            Naam = reader["Naam"].ToString(),
                            Merk = reader["Merk"].ToString(),
                            Prijs = Convert.ToDouble(reader["Prijs"]),
                            Afbeelding = reader["Afbeelding"].ToString(),
                            Description = reader["Description"].ToString(),

                            Leverancier = new Leverancier
                            {
                                ID = Convert.ToInt32(reader["Leverancier"])
                            },
                            Categorie = new Categorie
                            {
                                ID = Convert.ToInt32(reader["CategorieID"])
                            }
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