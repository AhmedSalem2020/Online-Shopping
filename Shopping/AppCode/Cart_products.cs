using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace ShoppingOnline.AppCode
{
    public class Cart_products
    {
        public static DataTable getProdNamesByid(int id)
        {
            SqlCommand cmd = new SqlCommand("select Prod_name,Prod_id from Product p where p.prod_id=@id ");
            cmd.Parameters.AddWithValue("@id", id);

            return DBlayer.Sel(cmd);
        }



        public static int insert (int cus_id,int prod_id)
        {

            SqlCommand cmd = new SqlCommand("insert into  cart values(@cus_id,@prod_id,@mount)");
            cmd.Parameters.AddWithValue("@cus_id", cus_id);
            cmd.Parameters.AddWithValue("@prod_id", prod_id);
            cmd.Parameters.AddWithValue("@mount",1);
            return DBlayer.Dml(cmd);
        }


        public static DataTable search(int cus_id, int prod_id)
        {

            SqlCommand cmd = new SqlCommand("select quantity from cart where customer_id=@c and prod_id=@p");
            cmd.Parameters.AddWithValue("@c", cus_id);
            cmd.Parameters.AddWithValue("@p", prod_id);

            return DBlayer.Sel(cmd);
        }



        public static int change_quantity(int cus_id, int prod_id,int quantity)
        {

            SqlCommand cmd = new SqlCommand("update cart set quantity= @mount where customer_id=@cus_id and prod_id= @prod_id ");
            cmd.Parameters.AddWithValue("@cus_id", cus_id);
            cmd.Parameters.AddWithValue("@prod_id", prod_id);
            cmd.Parameters.AddWithValue("@mount", quantity);

           return DBlayer.Dml(cmd);
        }


        public static DataTable getcart(int cus_id)
        {

            SqlCommand cmd = new SqlCommand("select p.prod_id as id ,prod_img as image, prod_name as productName, prod_price as price ,quantity as quantity from cart c, product p where customer_id=@c and c.prod_id=p.prod_id");
            cmd.Parameters.AddWithValue("@c", cus_id);

            return DBlayer.Sel(cmd);
        }



        public static int  remove(int cus_id,int prod_id)
        {

            SqlCommand cmd = new SqlCommand("delete from cart  where customer_id=@c and prod_id=@p");
            cmd.Parameters.AddWithValue("@c", cus_id);
            cmd.Parameters.AddWithValue("@p", prod_id);


            return DBlayer.Dml(cmd);
        }

        public static int empty(int cus_id)
        {

            SqlCommand cmd = new SqlCommand("delete from cart  where customer_id=@c");
            cmd.Parameters.AddWithValue("@c", cus_id);


            return DBlayer.Dml(cmd);
        }


        //nada
        public static DataTable selectByCartID(int cartid,int order)
        {
            SqlCommand cmd = new SqlCommand("select prod_id,quantity,Order_id from cart inner join [Order] on customer_id=Cust_id and cust_id=@custid and order_id=@orderid");
            cmd.Parameters.AddWithValue("@custid", cartid);
            cmd.Parameters.AddWithValue("@orderid", order);

            return DBlayer.Sel(cmd);
        }

        public static void trunccart()
        {
            SqlCommand cmd = new SqlCommand("truncate table cart");
            DBlayer.Truncate(cmd);
        }

    }
}