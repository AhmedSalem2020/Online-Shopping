using ShoppingOnline.AppCode;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace ShoppingOnline
{
    public partial class cart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

            if (!IsPostBack)
            {
                if (Session["isadmin"] != null)
                {
                    if (int.Parse(Session["isadmin"].ToString()) == 1)
                    {
                        Response.Redirect("~/Admin/HomeAdmin.aspx");
                    }
                }
                if (Session["id"] != null)

                {
                    DataTable dt = Cart_products.getcart(int.Parse(Session["id"].ToString()));
                    if (dt.Rows.Count != 0)
                    {
                        gv_cart.DataSource = dt;
                        gv_cart.DataBind();
                        lbl_empty.Style.Add("display", "none");
                    }
                    else
                    {
                        btn_submit.Style.Add("display", "none");
                        btn_cancel.Style.Add("display", "none");

                    }


                }
                if (Session["id"] == null)
                {
                    Response.Redirect("~/Annonymous/Home.aspx");

                }
            }
            

        }

        protected void gv_cart_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = (int)gv_cart.DataKeys[e.RowIndex].Value;
            Cart_products.remove(int.Parse(Session["id"].ToString()), id);
            gv_cart.DataSource = Cart_products.getcart(int.Parse(Session["id"].ToString()));
            gv_cart.DataBind();

        }

        protected void gv_cart_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            if (IsValid)

            {
                int prodid = (int)gv_cart.DataKeys[e.RowIndex].Value;
                int a = int.Parse(((TextBox)gv_cart.Rows[e.RowIndex].FindControl("TextBox1")).Text);
                Cart_products.change_quantity(int.Parse(Session["id"].ToString()), prodid, a);
                gv_cart.EditIndex = -1;
                gv_cart.DataSource = Cart_products.getcart(int.Parse(Session["id"].ToString()));
                gv_cart.DataBind();
            }
        }

        protected void gv_cart_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gv_cart.EditIndex = e.NewEditIndex;
            gv_cart.DataSource = Cart_products.getcart(int.Parse(Session["id"].ToString()));
            gv_cart.DataBind();

        }

        protected void gv_cart_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gv_cart.EditIndex = -1;
            gv_cart.DataSource = Cart_products.getcart(int.Parse(Session["id"].ToString()));
            gv_cart.DataBind();

        }

        protected void btn_cancel_Click(object sender, EventArgs e)
        {
            Cart_products.empty(int.Parse(Session["id"].ToString()));
            gv_cart.DataSource = Cart_products.getcart(int.Parse(Session["id"].ToString()));
            gv_cart.DataBind();


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/User/ViewProducts.aspx");

        }

        protected void btn_submit_Click(object sender, EventArgs e)
        {
            if (gv_cart.Rows.Count != 0)
            {
                int UserID;
                int CartID;
                int.TryParse(Session["id"].ToString(), out UserID);
                CartID = UserID;
                // Creating an order 
                Order.insert(UserID);
                // Get the order ID of the order that was just created 
                DataTable dt = Order.selByUserID(UserID);
                int index = dt.Rows.Count - 1;
                int orderid;
                int.TryParse(dt.Rows[index][0].ToString(), out orderid);

                // Get the IDs and quantities of the products in the cart 
                DataTable ProductsDT = Cart_products.selectByCartID(CartID, orderid);
                for (int i = 0; i < ProductsDT.Rows.Count; i++)
                {

                    // Find the product in the Products table using its ID 
                    int.TryParse(ProductsDT.Rows[i][0].ToString(), out int ProdID);
                    // Get order id 
                    int.TryParse(ProductsDT.Rows[i][2].ToString(), out int orderId);
                    // Get the quantity from the  cartProduct table 
                    int.TryParse(ProductsDT.Rows[i][1].ToString(), out int quantity);

                    Order.insertOrderDetails(ProdID, orderId, quantity);
                    products.DecreaseQuantity(ProdID, quantity);

                }
                Order.insertprice(orderid);
                Response.Redirect("~/User/ViewProducts.aspx");
            }
        }

    }
    
}