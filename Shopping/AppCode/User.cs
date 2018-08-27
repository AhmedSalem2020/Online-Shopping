using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ShoppingOnline.AppCode
{
    public class user
    {
        public static DataTable selectAll()
        {
            SqlCommand command = new SqlCommand("select Cust_fName,Cust_lName,Cust_mail,Cust_username,Cust_ssnimg,Cust_address,status,Cust_phone,Cust_zipCode from [Customer]");
            DataTable dt = DBlayer.Sel(command);
            return dt;
        }

        public static DataTable checkId(string national_id)
        {
            SqlCommand command = new SqlCommand("select Cust_id from [Customer] where Cust_ssn=@nid");
            command.Parameters.AddWithValue("nid", national_id);
            DataTable dt = DBlayer.Sel(command);
            return dt;
        }

        public static bool checkEmail(string mail)
        {
            SqlCommand command = new SqlCommand("select Cust_id,Cust_mail from [Customer] where Cust_mail=@email");
            command.Parameters.AddWithValue("@email", mail);

            return DBlayer.Seldr(command);

        }
        public static bool checkUserName(string uname)
        {
            SqlCommand command = new SqlCommand("select Cust_id,Cust_mail from [Customer] where Cust_username=@Username");
            command.Parameters.AddWithValue("@Username", uname);

            return DBlayer.Seldr(command);

        }
        public static int insert(string national_id, int isadmin, string password, string fname, string lname, string email, string uname, string pic, string address, string state, string phone, int code)
        {
            SqlCommand command = new SqlCommand("insert into [Customer] (Cust_fName,Cust_lName,Cust_mail,Cust_username,Cust_ssnimg,Cust_address,state,Cust_phone,Cust_zipCode,Cust_pass,isAdmin,Cust_ssn) values(@Fname ,@Lname,@mail,@uname,@pict,@address,@state,@phone,@zipcode,@pass,@isAdmin,@nationalId)");
            command.Parameters.AddWithValue("Fname", fname);
            command.Parameters.AddWithValue("Lname", lname);
            command.Parameters.AddWithValue("mail", email);
            command.Parameters.AddWithValue("uname", uname);
            command.Parameters.AddWithValue("pict", pic);
            command.Parameters.AddWithValue("address", address);
            command.Parameters.AddWithValue("state", state);
            command.Parameters.AddWithValue("phone", phone);
            command.Parameters.AddWithValue("pass", password);
            command.Parameters.AddWithValue("nationalId", national_id);
            command.Parameters.AddWithValue("isAdmin", isadmin);
            command.Parameters.AddWithValue("zipcode", code);
            return DBlayer.Dml(command);

        }


        //rasha

        public static DataTable getbyid(int id)
        {
            SqlCommand cmd = new SqlCommand("select Cust_fname,Cust_lname,Cust_username,Cust_mail,Cust_address,Cust_phone from Customer where Cust_id=@id");

            cmd.Parameters.AddWithValue("@id", id);
            return DBlayer.Sel(cmd);

        }


        public static int change(int id, string fname, string lname, string username, string mail, string address,string phone)
        {
            SqlCommand cmd = new SqlCommand("update Customer set Cust_fname =@n,Cust_lname=@n2,Cust_username=@n3 ,Cust_mail=@n4,Cust_address=@n5,Cust_phone=@n6 where Cust_id=@id");
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@n", fname);
            cmd.Parameters.AddWithValue("@n2", lname);
            cmd.Parameters.AddWithValue("@n3", username);
            cmd.Parameters.AddWithValue("@n4", mail);
            cmd.Parameters.AddWithValue("@n5", address);
            cmd.Parameters.AddWithValue("@n6", phone);



            return DBlayer.Dml(cmd);

        }
        public static DataTable emailsearch(string mail, int id)
        {
            SqlCommand cmd = new SqlCommand("select Cust_fname from Customer where Cust_mail=@mail and Cust_id!=@id");

            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@mail", mail);

            return DBlayer.Sel(cmd);

        }


        public static DataTable usersearch(string user, int id)
        {
            SqlCommand cmd = new SqlCommand("select Cust_fname from Customer where cust_username=@user and Cust_id!=@id");

            cmd.Parameters.AddWithValue("@id", id);

            cmd.Parameters.AddWithValue("@user", user);

            return DBlayer.Sel(cmd);

        }
    }
}