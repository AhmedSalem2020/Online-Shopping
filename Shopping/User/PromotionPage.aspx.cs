using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ShoppingOnline.AppCode;


namespace Shopping.User
{
    public partial class PromotionPage : System.Web.UI.Page
    {
        protected void Page_PreInit(object sender, EventArgs e)
        {
            if (Session["id"] != null) //check the user weather user is logged in or not
                this.Page.MasterPageFile = "~/User/users.Master";
            else
                this.Page.MasterPageFile = "~/Annonymous/Master.Master";

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lstView_data.DataSource = products.getPromotions();
                lstView_data.DataBind();
            }
        }
    }
}