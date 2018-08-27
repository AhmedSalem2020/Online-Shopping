using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ShoppingOnline.AppCode
{
    public class Order
    {
        public static int insert(int UserID)
        {
            SqlCommand command = new SqlCommand("insert into [Order] (Cust_id,Packing_date,state) values(@custid ,@pkdate,@state)");
            command.Parameters.AddWithValue("@custid",UserID);
            command.Parameters.AddWithValue("@pkdate", DateTime.Now);
            command.Parameters.AddWithValue("@state","pending");
            return DBlayer.Dml(command);
        }

        public static DataTable selByUserID( int UserID)
        {
            SqlCommand comnd = new SqlCommand("select top(1)Order_id from[order] where Cust_id =@custid order by order_id desc");
            comnd.Parameters.AddWithValue("@custid", UserID);
            return DBlayer.Sel(comnd);
        }

        public static int insertOrderDetails(int prodid,int orderid,int quantity)
        {
            SqlCommand cmd = new SqlCommand("insert into [OrderItem] values(@prod,@order,@quantity)");
            cmd.Parameters.AddWithValue("@prod", prodid);
            cmd.Parameters.AddWithValue("@order", orderid);
            cmd.Parameters.AddWithValue("@quantity", quantity);
            Cart_products.trunccart();
            return DBlayer.Dml(cmd);
        }
        public static DataTable totalPrice(int orderid)
        {
            SqlCommand cmd = new SqlCommand("SELECT sum(prod_price*quantity) from Product p inner join [OrderItem] ot on p.Prod_id=ot.Prod_id where Order_id=@orderid");
            cmd.Parameters.AddWithValue("@orderid", orderid);
            return DBlayer.Sel(cmd);
        }
        public static int insertprice(int orderid)
        {
            DataTable dt = totalPrice(orderid);

            SqlCommand cmd = new SqlCommand("update[order] set cost=@price,Deliver_date=@date where Order_id=@id");
            cmd.Parameters.AddWithValue("@price", decimal.Parse(dt.Rows[0][0].ToString()));
            cmd.Parameters.AddWithValue("@date",DateTime.Now.AddDays(15));
            cmd.Parameters.AddWithValue("@id", orderid);

            return DBlayer.Dml(cmd);
        }

        public static DataTable Pending()
        {

            SqlCommand cmd = new SqlCommand("select r.order_id,r.Packing_date,u.Cust_username from [Order] r,[Customer] u where u.Cust_id=r.cust_Id and r.state='pending'");
            DataTable dt = DBlayer.Sel(cmd);
            return dt;
        }

        public static DataTable Approved()
        {
            SqlCommand cmd = new SqlCommand("select r.order_id,r.Packing_date,u.Cust_username from [Order] r,[Customer] u where u.Cust_id=r.cust_Id and r.state='Approved'");
            DataTable dt = DBlayer.Sel(cmd);
            return dt;
        }
        public static DataTable Blocked()
        {
            SqlCommand cmd = new SqlCommand("select r.order_id,r.Packing_date,u.Cust_username from [Order] r,[Customer] u where u.Cust_id=r.cust_Id and r.state='Blocked'");
            DataTable dt = DBlayer.Sel(cmd);
            return dt;
        }

        public static int UpdateStatus(int id, string state)
        {
            SqlCommand cmd = new SqlCommand("update [Order] set state=@state where Order_id =@id");

            cmd.Parameters.AddWithValue("@state", state);
            cmd.Parameters.AddWithValue("@id", id);
            return DBlayer.Dml(cmd);

        }
        //Rasha
        public static DataTable pendingOrders_detailsbyid(int id)
        {
            SqlCommand cmd = new SqlCommand("SELECT Product.Prod_img, Product.Prod_name, Product.Prod_price, OrderItem.Quantity" +
                " FROM Product INNER JOIN  OrderItem ON Product.Prod_id = OrderItem.prod_id and OrderItem.Order_id =@id");

            cmd.Parameters.AddWithValue("@id", id);

            return DBlayer.Sel(cmd);

        }

        public static DataTable pendingOrdecustomer()
        {
            SqlCommand cmd = new SqlCommand("SELECT  Customer.Cust_fname + ' ' + Customer.Cust_lname as CustomerName, Customer.Cust_id, Customer.Cust_phone as phone, Customer.Cust_address as address, [Order].Order_id " +
                        "FROM   Customer INNER JOIN" +
                        " [Order] ON Customer.Cust_id = [Order].Cust_id and[Order].state = 'pending'");

            return DBlayer.Sel(cmd);

        }
        public static int approvingorder(int orderid)
        {
            SqlCommand cmd = new SqlCommand("update [Order] set state='Approved' where  [Order].order_id=@id  and[Order].state = 'pending'");

            cmd.Parameters.AddWithValue("@id", orderid);


            return DBlayer.Dml(cmd);

        }

        //samar
        public static DataTable numofpending()
        {
            SqlCommand cmd = new SqlCommand("Select count(order_id) from [order] where state='Pending'");
            return DBlayer.Sel(cmd);
        }




    }
}