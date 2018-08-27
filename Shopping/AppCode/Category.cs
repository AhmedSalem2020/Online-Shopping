using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ShoppingOnline.AppCode
{
    public class Category
    {
        //select all
        public static DataTable getAll()
        {
            SqlCommand cmd = new SqlCommand("select * from Category");

            return DBlayer.Sel(cmd);
        }


        //select by id
        public static DataTable getById(int id)
        {
            SqlCommand cmd = new SqlCommand("select Category_name from Category where Category_id=@id");
            cmd.Parameters.AddWithValue("@id", id);

            return DBlayer.Sel(cmd);
        }
        //select by name
        public static DataTable getByName(string name)
        {
            SqlCommand cmd = new SqlCommand("select * from Category where Category_name=@name");
            cmd.Parameters.AddWithValue("@name", name);

            return DBlayer.Sel(cmd);
        }


        //update
        public static int edit(int id, string name)

        {
            SqlCommand cmd = new SqlCommand("update Category set Category_name=@name where Category_id=@id");
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@id", id);
            return DBlayer.Dml(cmd);

        }

        //delete

        public static int remove(int id)

        {
            SqlCommand cmd = new SqlCommand("delete from Category where Category_id=@id");
            cmd.Parameters.AddWithValue("@id", id);
            return DBlayer.Dml(cmd);

        }
        //insert

        public static int add(string name)

        {
            SqlCommand cmd = new SqlCommand("insert into Category values(@name)");
            cmd.Parameters.AddWithValue("@name", name);
            return DBlayer.Dml(cmd);

        }
    }
}