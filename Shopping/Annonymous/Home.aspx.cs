using ShoppingOnline.AppCode;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShoppingOnline.Annonymous
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_PreInit(object sender, EventArgs e)
        {
            if (Session["id"]!= null) //check the user weather user is logged in or not
                this.Page.MasterPageFile = "~/User/users.Master";
            else
                this.Page.MasterPageFile = "~/Annonymous/Master.Master";

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                // GitHub Test 000
                SqlCommand cmd = new SqlCommand("SELECT top(1) p1.* FROM Product p1 LEFT JOIN Product p2 ON (p1.Category_id = p2.Category_id AND p1.Prod_id < p2.Prod_id) WHERE p2.Prod_id IS NULL order by p1.Category_id desc");

                dlst_latest.DataSource = DBlayer.Sel(cmd);
                dlst_latest.DataBind();
            }catch(Exception ex)
            {
                LogError.Error(ex, System.Reflection.MethodBase.GetCurrentMethod().Name);

            }

        }


    }
}
