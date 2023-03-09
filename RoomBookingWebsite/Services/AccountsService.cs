using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace RoomBookingWebsite.Services
{
    public class AccountsService
    {
        public AccountsService() {
            string strcon = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            //create new sqlconnection and connection to database by using connection string from web.config file  
            SqlConnection con = new SqlConnection(strcon);
        }
        public string SigninService(string username, string password)
        {

            return "";
        }

    }
}