using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ShoppingOnline.AppCode
{
    public class DBlayer
    {
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["online"].ConnectionString);
       
        public static DataTable Sel(SqlCommand cmd)
        {

            SqlCommand cmm = cmd;
            cmm.Connection = con;
            SqlDataAdapter adapter = new SqlDataAdapter(cmm);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;


        }

        public static bool Seldr(SqlCommand cmd)
        {
            //SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["online"].ConnectionString);
            cmd.Connection = con;
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                con.Close();
                return true;
            }
            con.Close();
            return false;




        }
        public static int Dml(SqlCommand cmd)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["online"].ConnectionString);
            cmd.Connection = con;
            con.Open();

            int roweffect = cmd.ExecuteNonQuery();


            con.Close();
            return roweffect;
        }
        public static void Truncate(SqlCommand cmd)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["online"].ConnectionString);
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteReader();
            con.Close();
        }
    }
}