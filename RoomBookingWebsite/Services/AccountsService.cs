using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace RoomBookingWebsite.Services
{
    public class AccountsService
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-M0QEFOA\\SQLEXPRESS; Database=studentDB; Integrated Security=True;Connect Timeout=30;Encrypt=False;");
        public string SigninService(string username, string password)
        {
       
            using (SqlCommand cmd = new SqlCommand("Select * from Students where ID = 1", con))
            {
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    return dr["FirstName"].ToString();
                }
                con.Close();
            }
           
                return "";
        }

    }
}