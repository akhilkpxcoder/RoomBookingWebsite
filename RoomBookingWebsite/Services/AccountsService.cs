using RoomBookingWebsite.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace RoomBookingWebsite.Services
{
    public class AccountsService
    {
        SqlConnection sqlCon = new SqlConnection("Data Source=DESKTOP-M0QEFOA\\SQLEXPRESS; Database=RoomBooking; Integrated Security=True;Connect Timeout=30;Encrypt=False;");
        public ClientModel SigninService(string username, string password)
        {
            ClientModel clientModel =new ClientModel();
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("UserDetailsMasterSP",sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@StatementType", "Select");
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                clientModel.ID = Convert.ToInt32(dr["ID"]);
                clientModel.FirstName = dr["FirstName"].ToString();
                clientModel.LastName = dr["LastName"].ToString();
                clientModel.DOB = dr["DateOfBirth"].ToString();
                clientModel.Gender = dr["Gender"].ToString();
                clientModel.Address = dr["Address"].ToString();
                clientModel.Email = dr["Email"].ToString();
                clientModel.Phone_Number = dr["PhoneNumber"].ToString();
                clientModel.Username = dr["Username"].ToString();
                clientModel.State = dr["State"].ToString();
                clientModel.City = dr["City"].ToString();
                clientModel.UserType = dr["UserType"].ToString();
            }
            sqlCon.Close();
            return clientModel;
        }
        public String SignupService(ClientModel clientModel)
        {
            sqlCon.Open();
            SqlCommand cmd = new SqlCommand("UserDetailsMasterSP", sqlCon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@StatementType", "SelectDuplicate");
            cmd.Parameters.AddWithValue("@email",clientModel.Email);
            cmd.Parameters.AddWithValue("@phone_number",clientModel.Phone_Number);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                return "User already exist";
            }
            sqlCon.Close();
            sqlCon.Open();
            cmd = new SqlCommand("UserDetailsMasterSP", sqlCon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@StatementType", "Insert");
            cmd.Parameters.AddWithValue("@first_name",clientModel.FirstName);
            cmd.Parameters.AddWithValue("@last_name", clientModel.LastName);
            cmd.Parameters.AddWithValue("@dob", clientModel.DOB);
            cmd.Parameters.AddWithValue("@gender", clientModel.Gender);
            cmd.Parameters.AddWithValue("@address", clientModel.Address);
            cmd.Parameters.AddWithValue("@email", clientModel.Email);
            cmd.Parameters.AddWithValue("@phone_number", clientModel.Phone_Number);
            cmd.Parameters.AddWithValue("@state", clientModel.State);
            cmd.Parameters.AddWithValue("@city", clientModel.City);
            cmd.Parameters.AddWithValue("@username", clientModel.Username);
            cmd.Parameters.AddWithValue("@password", clientModel.Password);
            cmd.Parameters.AddWithValue("@usertype", "Client");
            cmd.ExecuteNonQuery();
            sqlCon.Close();
            return "User Added Sucessfully";
        }

    }
}