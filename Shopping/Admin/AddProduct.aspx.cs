using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.IO;
using ShoppingOnline.AppCode;
using System.Data;

namespace ShoppingOnline.Admin
{
    public partial class AddProduct : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode =UnobtrusiveValidationMode.None;
            try
            {
               
                if (!IsPostBack)
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
                    //to fill ddl_category with categories name
                    ddl_category.DataSource = Category.getAll();
                    ddl_category.DataTextField = "Category_Name";
                    ddl_category.DataValueField = "Category_id";
                    ddl_category.DataBind();
                    if (Session["category"] != null)
                    {
                        ddl_category.SelectedItem.Text=Session["category"].ToString();
                    }
                }
            }
            catch(Exception ex)
            {
                LogError.Error(ex, System.Reflection.MethodBase.GetCurrentMethod().Name);
            }
        }

        protected void btn_addprod_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValid)
                {
                    string path = "~/prodimg/" + ddl_category.SelectedItem.Text + "/" + fu_prodimag.FileName;
                    if (fu_prodimag.HasFile)
                    {
                        string ext = Path.GetExtension(fu_prodimag.FileName);
                        if (ext == ".jpg" || ext == ".png" || ext == ".PNG" || ext == ".JPG")
                        {
                            fu_prodimag.SaveAs(Server.MapPath(path));
                            products.Add(txt_prodName.Text, txt_prodDesc.Text, int.Parse(txt_prodPrice.Text), int.Parse(txt_prodQuantity.Text), path, int.Parse(ddl_category.SelectedValue));
                            Page.ClientScript.RegisterStartupScript(this.GetType(), "show", " showDialog();", true);

                        }
                        else
                        {
                            lbl_doneOrError.Text = "Wrong image path";
                            lbl_doneOrError.Style.Add("color", "red");
                        }
                    }
                }

            }
            catch(Exception ex)
            {
                LogError.Error(ex, System.Reflection.MethodBase.GetCurrentMethod().Name);
            }
        }

        protected void btn_Cancel_Click(object sender, EventArgs e)
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "hide", "hideDialog();", true);
        }
        protected void btn_editproduct_Click(object sender, EventArgs e)
        {
            DataTable dt = products.getByName(txt_prodName.Text);
            if(dt.Rows.Count!=0)
            {
                Session.Add("prodid", dt.Rows[0][0]);
                Response.Redirect("~/Admin/EditProduct.aspx");
            }
            
        }
        protected void btn_addpromotion_Click(object sender, EventArgs e)
        {
            DataTable dt = products.getByName(txt_prodName.Text);
            if (dt.Rows.Count != 0)
            {
                Session.Add("prodid", dt.Rows[0][0]);
                Response.Redirect("~/Admin/AddPromotion.aspx");
            }
        }
        
    }
}