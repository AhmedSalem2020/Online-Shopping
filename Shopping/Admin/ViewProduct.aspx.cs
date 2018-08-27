using ShoppingOnline.AppCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Shopping.Admin
{
    public partial class EditProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    if (Session["isadmin"] != null)
                    {
                        if (Session["isadmin"].ToString() != "1")
                            Response.Redirect("~/Annonymous/Home.aspx");

                    }
                    if (Session["id"] == null)
                    {
                        Response.Redirect("~/Annonymous/Home.aspx");
                    }
                    lv_data.DataSource = products.getAll2();
                    lv_data.DataBind();
                }catch(Exception ex)
                {
                    LogError.Error(ex, System.Reflection.MethodBase.GetCurrentMethod().Name);

                }
            }
        }
        protected string CutText(object text, int length)
        {
           
                if (DBNull.Value == text || text == null)
                    return "";
                string txt = text.ToString();
                if (txt.Length <= length) return txt;
                return txt.Substring(0, length);
          
        }
        protected void Lbtn_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                LinkButton lbtn = sender as LinkButton;
                int prod_id = int.Parse(lbtn.CommandArgument.ToString());
                Session.Add("prodid", prod_id);
                Response.Redirect("~/Admin/EditProduct.aspx");
            }catch(Exception ex)
            {
                LogError.Error(ex, System.Reflection.MethodBase.GetCurrentMethod().Name);

            }
        }
        protected void Lbtn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                LinkButton lbtn = sender as LinkButton;
                int prod_id = int.Parse(lbtn.CommandArgument.ToString());
                products.remove(prod_id);
                lv_data.DataSource = products.getAll();
                lv_data.DataBind();
            }catch(Exception ex)
            {
                LogError.Error(ex, System.Reflection.MethodBase.GetCurrentMethod().Name);

            }

        }

        protected void txt_search_TextChanged(object sender, EventArgs e)
        {
              string bookname = txt_search.Text;
                try
                {
                    if (bookname == products.getByName(bookname).Rows[0]["Prod_name"].ToString())
                    {
                        lv_data.DataSource = products.getByName(bookname);
                        lv_data.DataBind();
                    }

                }
                catch(Exception ex)
                {
                 LogError.Error(ex, System.Reflection.MethodBase.GetCurrentMethod().Name);

                }
        }
    }
}