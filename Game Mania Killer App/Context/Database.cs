using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;


namespace Game_Mania_Killer_App.Context
{
    class Database
    {
        public static SqlConnection Connection
        {
            get
            {
                SqlConnection connection = new SqlConnection(connectionstring);
                connection.Open();
                return connection;
            }
        }
        //!!!UPDATE CONNECTIONSTRING!!!
        private static string connectionstring = @"Data Source=192.168.20.200,20;Network Library=DBMSSOCN;Initial Catalog=Participation;User Id=sa;Password=admin;";
    }
}