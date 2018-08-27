using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using ShoppingOnline.AppCode;

namespace ShoppingOnline.Annonymous
{
    public partial class home : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT p1.* FROM Product p1 LEFT JOIN Product p2 ON (p1.Category_id = p2.Category_id AND p1.Prod_id < p2.Prod_id) WHERE p2.Prod_id IS NULL");

            datalist_home.DataSource = DBlayer.Sel(cmd); 
            datalist_home.DataBind();

        }
    }
}