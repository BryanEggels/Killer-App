using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Game_Mania_Killer_App.Context.Interfaces;
using Game_Mania_Killer_App.Models;
using System.Data.SqlClient;
using System.Data;

namespace Game_Mania_Killer_App.Context
{
    public class BestellingSQLContext : IBestellingContext
    {
        public bool Add(Bestelling bestelling)
        {

            DataTable table = new DataTable();
            table.Columns.Add("Artikelnummer", typeof(int));
            table.Columns.Add("Aantal",typeof(int));

            foreach (Artikel a in bestelling.Artikelen)
            {
                table.Rows.Add(a.Artikelnummer, a.Aantal);
            }

            try
            {
                using (SqlConnection con = Database.Connection)
                {
                    SqlCommand com = new SqlCommand("dbo.insertbestelling", con);
                    com.CommandType = CommandType.StoredProcedure;
                    SqlParameter tvparam = com.Parameters.AddWithValue("@List", table);
                    tvparam.SqlDbType = SqlDbType.Structured;
                    SqlParameter klantparam = com.Parameters.AddWithValue("@KlantID", bestelling.klant.ID);

                    if (com.ExecuteNonQuery() > 1)
                    {
                        return true;
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            return false;
            
        }

        public bool Delete(Bestelling bestelling)
        {
            throw new NotImplementedException();
        }

        public List<Bestelling> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Bestelling> GetAll(Klant klant)
        {
            throw new NotImplementedException();
        }
    }
}