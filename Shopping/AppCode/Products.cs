using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ShoppingOnline.AppCode

{
    public class products
    {
        public static DataTable getAll()
        {
            SqlCommand cmd = new SqlCommand("select * from Product where prod_quantity!=0");
            return DBlayer.Sel(cmd);
        }
        public static DataTable getPromotions()
        {
            SqlCommand cmd = new SqlCommand("select * from Product where promotion is not null ");
            return DBlayer.Sel(cmd);
        }
        public static DataTable getByCateg(string category)
        {
            SqlCommand cmd = new SqlCommand("select  p.prod_id,p.Prod_img , p.Prod_name  ,p.Prod_Desc,p.Prod_price,p.promotion ,c.Category_name from Product p , Category c where c.Category_name=@name and p.Category_id=c.Category_id and Prod_quantity!=0");
            cmd.Parameters.AddWithValue("@name", category);
            return DBlayer.Sel(cmd);
        }
        public static DataTable getByName(string name)
        {
            SqlCommand cmd = new SqlCommand("select  p.prod_id,p.Prod_img , p.Prod_name  ,p.Prod_Desc,p.Prod_price,promotion ,c.Category_name from Product p , Category c where p.prod_name=@name and p.Category_id=c.Category_id and prod_quantity!=0");
            cmd.Parameters.AddWithValue("@name", name);
            return DBlayer.Sel(cmd);
        }
        public static DataTable getbyPrice(decimal price)
        {
            SqlCommand cmd = new SqlCommand("select p.prod_id, p.Prod_img , p.Prod_name  ,p.Prod_Desc,p.Prod_price,p.promotion ,c.Category_name from Product p , Category c where p.Prod_price=@price and p.Category_id=c.Category_id and prod_quantity!=0");
            cmd.Parameters.AddWithValue("@price", price);
            return DBlayer.Sel(cmd);
        }
        public static DataTable getAllCate()
        {
            SqlCommand cmd = new SqlCommand("select c.* from Category c");
            return DBlayer.Sel(cmd);
        }
        public static DataTable getProdNames()
        {
            SqlCommand cmd = new SqlCommand("select Prod_name,Prod_id from Product where prod_quantity!=0");
            return DBlayer.Sel(cmd);
        }
        public static DataTable getProdPrice()
        {
            SqlCommand cmd = new SqlCommand("select Prod_price,Prod_id from Product where prod_quantity!=0 ");
            return DBlayer.Sel(cmd);
        }
        //--------------------------------------------------------------------------------------------------------
        public static DataTable getProdNamesByCat(int id)
        {
            SqlCommand cmd = new SqlCommand("select Prod_name,Prod_id from Product p where p.Category_id=@id and prod_quantity!=0");
            cmd.Parameters.AddWithValue("@id", id);

            return DBlayer.Sel(cmd);
        }
        public static DataTable getProdpriceByCat(int id)
        {
            SqlCommand cmd = new SqlCommand("select Prod_price,Prod_id from Product p where p.Category_id=@id and prod_quantity!=0");
            cmd.Parameters.AddWithValue("@id", id);

            return DBlayer.Sel(cmd);
        }
        public static DataTable getProdpriceByname(int id)
        {
            SqlCommand cmd = new SqlCommand("select Prod_price,Prod_id from Product p where p.Prod_id=@id and prod_quantity!=0");
            cmd.Parameters.AddWithValue("@id", id);

            return DBlayer.Sel(cmd);
        }


        //Samar
        //update product
        public static int edit(int id, string name,string Desc,int price,int quantity,string img1,string prom,int catid)

        {
            SqlCommand cmd = new SqlCommand("update product set Prod_name=@name,Prod_Desc=@desc,prod_price=@price,prod_img=@img,prod_quantity=@quantity,Category_id=@catid,promotion=@prom where prod_id=@id");
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@desc", Desc);
            cmd.Parameters.AddWithValue("@price", price);
            cmd.Parameters.AddWithValue("@prom", prom);
            cmd.Parameters.AddWithValue("@img", img1);
            cmd.Parameters.AddWithValue("@catid", catid);
            cmd.Parameters.AddWithValue("@quantity", quantity);
            cmd.Parameters.AddWithValue("@id", id);
            return DBlayer.Dml(cmd);

        }
        //insert product
        public static int Add(string name, string Desc, int price, int quantity, string img1, int catid)

        {
            SqlCommand cmd = new SqlCommand("insert into product (Prod_name,Prod_desc,Prod_price,Prod_img,Category_id,Prod_quantity) Values(@name,@desc,@price,@img,@catid,@quantity)");
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@desc", Desc);
            cmd.Parameters.AddWithValue("@price", price);
            cmd.Parameters.AddWithValue("@img", img1);
            cmd.Parameters.AddWithValue("@catid", catid);
            cmd.Parameters.AddWithValue("@quantity", quantity);

            return DBlayer.Dml(cmd);

        }
        //Update or delete or promotion
        public static int editprom (string prom,int id)
        {
            SqlCommand cmd = new SqlCommand("Update Product set promotion=@prom where prod_id=@id");
            if(prom=="NULL")
                cmd.Parameters.AddWithValue("@prom", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@prom", prom);
            cmd.Parameters.AddWithValue("@id",  id);

            return DBlayer.Dml(cmd);
        }

        //select promotion on product
        public static DataTable prom(int id)
        {
            SqlCommand cmd = new SqlCommand("Select promotion from Product where prod_id=@id");
            cmd.Parameters.AddWithValue("@id", id);

            return DBlayer.Sel(cmd);
        }
        //delete product

        public static int remove(int id)

        {
            SqlCommand cmd = new SqlCommand("delete from Product where prod_id=@id");
            cmd.Parameters.AddWithValue("@id", id);
            return DBlayer.Dml(cmd);

        }

        public static DataTable getAll2()
        {
            SqlCommand cmd = new SqlCommand("select * from Product");
            return DBlayer.Sel(cmd);
        }
        public static DataTable getByid(int id)
        {
            SqlCommand cmd = new SqlCommand("select * from Product where prod_id=@id");
            cmd.Parameters.AddWithValue("@id", id);
            return DBlayer.Sel(cmd);
        }

        public static DataTable getbyimg(string path)
        {
            SqlCommand cmd = new SqlCommand("select * from product where prod_img=@img");
            cmd.Parameters.AddWithValue("@img", path);
            return DBlayer.Sel(cmd);
        }
        //nada
        public static void DecreaseQuantity(int id,int quantity)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Product set Prod_Quantity=(Select Prod_Quantity From product where prod_id=@id)-@quantity where prod_id = @id");
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@quantity", quantity);
            //cmd.Parameters.Add("@kkkjk",SqlDbType.UniqueIdentifier,4,jjjjj)
            DBlayer.Dml(cmd);
        }
    }
}