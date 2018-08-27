using ShoppingOnline.AppCode;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShoppingOnline.Admin
{
    public partial class AddCategory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
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

                //fill gv with all category
                gv_category.DataSource = Category.getAll();
                    gv_category.DataBind();
               
            }
            catch(Exception ex)
            {
                LogError.Error(ex, System.Reflection.MethodBase.GetCurrentMethod().Name);
            }
        }

        protected void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValid)
                {
                    // if txtbox not empty check if value exist
                    int count = Category.getByName(txt_categoryName.Text).Rows.Count;
                    if (count == 0)
                    {
                        //if not exist add to db and bind gv 
                        Category.add(txt_categoryName.Text);
                        gv_category.DataSource = Category.getAll();
                        gv_category.DataBind();

                        //to crate img folder for this category
                        var folder = Server.MapPath("~/prodimg/" + txt_categoryName.Text);
                        if (!Directory.Exists(folder))
                        {
                            Directory.CreateDirectory(folder);
                        }
                        txt_categoryName.Text = "";
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "show", "showDialog();", true);

                    }
                    else
                    {
                        //if category exist
                        lbl_error.Text = "This Category already exist";
                        txt_categoryName.Text = "";
                    }
                }
                
            }
            catch(Exception ex)
            {
                LogError.Error(ex, System.Reflection.MethodBase.GetCurrentMethod().Name);
            }
            


        }

        protected void gv_category_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            try
            {
                // if cancel changing return same data before change
                gv_category.EditIndex = -1;
                DataTable dt = Category.getAll();
                gv_category.DataSource = dt;
                gv_category.DataBind();
            }
            catch(Exception ex)
            {
                LogError.Error(ex, System.Reflection.MethodBase.GetCurrentMethod().Name);
            }
            
        }

        protected void gv_category_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                //delete category
                int Cat_id = (int)gv_category.DataKeys[e.RowIndex].Value;
                Category.remove(Cat_id);
                DataTable dt = Category.getAll();
                gv_category.DataSource = dt;
                gv_category.DataBind();
            }
            catch (Exception ex)
            {
                LogError.Error(ex, System.Reflection.MethodBase.GetCurrentMethod().Name);
            }

        }

        protected void gv_category_RowEditing(object sender, GridViewEditEventArgs e)
        {
            try
            {
                //edit in db
                gv_category.EditIndex = e.NewEditIndex;
                DataTable dt = Category.getAll();
                gv_category.DataSource = dt;
                gv_category.DataBind();
            }
            catch(Exception ex)
            {
                LogError.Error(ex, System.Reflection.MethodBase.GetCurrentMethod().Name);
            }



        }

        protected void gv_category_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                //update in db
                string CatName = ((TextBox)gv_category.Rows[e.RowIndex].FindControl("txt_edit")).Text;
                int Cat_id = (int)gv_category.DataKeys[e.RowIndex].Value;
                Category.edit(Cat_id, CatName);
                gv_category.EditIndex = -1;
                DataTable dt = Category.getAll();
                gv_category.DataSource = dt;
                gv_category.DataBind();
            }
            catch(Exception ex)
            {
                LogError.Error(ex, System.Reflection.MethodBase.GetCurrentMethod().Name);
            }
        }

        protected void btn_addProduct_Click(object sender, EventArgs e)
        {
            Session.Add("category", txt_categoryName.Text);
            Response.Redirect("~/Admin/AddProduct.aspx");
        }

        protected void btn_Cancel_Click(object sender, EventArgs e)
        {
            txt_categoryName.Text = "";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "hide", "hideDialog();", true);

        }

      
    }
}