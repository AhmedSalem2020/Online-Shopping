using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ShoppingOnline.AppCode
{
    public class Customer
    {
        //select by id
        public static DataTable getById(int id)
        {
            SqlCommand cmd = new SqlCommand("select Cust_fname,Cust_lname,Cust_username,Cust_mail,Cust_address,Cust_phone from Customer where Cust_id=@id");
            cmd.Parameters.AddWithValue("@id", id);

            return DBlayer.Sel(cmd);
        }
        public static DataTable getAll()
        {
            SqlCommand cmd = new SqlCommand("select * from Customer ");

            return DBlayer.Sel(cmd);
        }
        public static DataTable getUsers()
        {
            SqlCommand cmd = new SqlCommand("select * from Customer where IsAdmin=0 ");

            return DBlayer.Sel(cmd);
        }
        //update
        public static int editstatus(int id, string newStatus)

        {
            SqlCommand cmd = new SqlCommand("update Customer  set State=@state where  Cust_id=@id");
            cmd.Parameters.AddWithValue("@state", newStatus);
            cmd.Parameters.AddWithValue("@id", id);

            return DBlayer.Dml(cmd);

        }

        //delete

        public static int remove(int id)

        {
            SqlCommand cmd = new SqlCommand("delete from Customer where Cust_id=@id");

            cmd.Parameters.AddWithValue("@id", id);
            return DBlayer.Dml(cmd);

        }
        //select
        public static DataTable getBlockedUsers()
        {
            SqlCommand cmd = new SqlCommand("select * from Customer where State='blocked' ");
            return DBlayer.Sel(cmd);
        }
        public static DataTable getPendingUsers()
        {
            SqlCommand cmd = new SqlCommand("select * from Customer where State='pending' ");
            return DBlayer.Sel(cmd);
        }
        public static DataTable getbyid(int id)
        {
            SqlCommand cmd = new SqlCommand("select Cust_fname,Cust_lname,Cust_username,Cust_mail,Cust_address,Cust_phone from Customer where Cust_id=@id");

            cmd.Parameters.AddWithValue("@id", id);
            return DBlayer.Sel(cmd);

        }


        public static int change(int id, string fname, string lname, string username, string mail, string address,int phone)
        {
            SqlCommand cmd = new SqlCommand("update Customer set Cust_fname =@n,Cust_lname=@n2,Cust_username=@n3 ,Cust_mail=@n4,Cust_address=@n5,Cust_phone=@n6 where Cust_id=@id");
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@n", fname);
            cmd.Parameters.AddWithValue("@n2", lname);
            cmd.Parameters.AddWithValue("@n3", username);
            cmd.Parameters.AddWithValue("@n4",mail);
            cmd.Parameters.AddWithValue("@n5",address);
            cmd.Parameters.AddWithValue("@n6",phone);



            return DBlayer.Dml(cmd);

        }
        public static DataTable emailsearch(string mail,int id)
        {
            SqlCommand cmd = new SqlCommand("select Cust_fnamefrom Customer where Cust_mail=@mail and Cust_id!=@id");

            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@mail", mail);

            return DBlayer.Sel(cmd);

        }


        public static DataTable usersearch(string user, int id)
        {
            SqlCommand cmd = new SqlCommand("select Cust_fnamefrom Customer where cust_username=@user and Cust_id!=@id");

            cmd.Parameters.AddWithValue("@id", id);

            cmd.Parameters.AddWithValue("@user",user);

            return DBlayer.Sel(cmd);

        }
    }
}