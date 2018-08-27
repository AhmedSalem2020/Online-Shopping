using ShoppingOnline.AppCode;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Shopping.Admin
{
    public partial class EditProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = new UnobtrusiveValidationMode();

            if (!IsPostBack)
            {
                try {
                    if (Session["isadmin"] != null)
                    {
                        if (Session["isadmin"].ToString() != "1")
                            Response.Redirect("~/Annonymous/Home.aspx");

                    }
                    if (Session["id"] == null)
                    {
                        Response.Redirect("~/Annonymous/Home.aspx");
                    }
                    ddl_category.DataSource = Category.getAll();
                    ddl_category.DataTextField = "Category_Name";
                    ddl_category.DataValueField = "Category_id";
                    ddl_category.DataBind();

                    if (Session["prodid"] != null)
                    {
                        DataTable dt = products.getByid(int.Parse(Session["prodid"].ToString()));
                        txt_prodName.Text = dt.Rows[0][1].ToString();
                        txt_prodDesc.Text = dt.Rows[0][2].ToString();
                        txt_prodPrice.Text = dt.Rows[0][3].ToString();
                        txt_prodQuantity.Text = dt.Rows[0][6].ToString();
                        ddl_category.SelectedValue = dt.Rows[0][5].ToString();
                        img_prod.ImageUrl = dt.Rows[0][4].ToString();
                        txt_prodProm.Text = dt.Rows[0][7].ToString();


                    }
                    else
                    {
                        Response.Redirect("~/Admin/HomeAdmin.aspx");
                    }
                }
                catch(Exception ex)
                {
                    LogError.Error(ex, System.Reflection.MethodBase.GetCurrentMethod().Name);

                }
            }

           
        }

        protected void btn_Editprod_Click(object sender, EventArgs e)
        {
            try
            {
                //update in db
                int prod_id = int.Parse(Session["prodid"].ToString());
                if (IsValid)
                {
                    string path = "~/prodimg/" + ddl_category.SelectedItem.Text + "/" + fu_prodimag.FileName;
                    if (fu_prodimag.HasFile)
                    {
                        string ext = Path.GetExtension(fu_prodimag.FileName);
                        if (ext == ".jpg" || ext == ".png" || ext == ".PNG" || ext == ".JPG")
                        {
                            //DataTable dt = products.getbyimg(path);
                            //if (dt.Rows.Count != 0)
                            //{
                                fu_prodimag.SaveAs(Server.MapPath(path));
                                products.edit(prod_id, txt_prodName.Text, txt_prodDesc.Text, int.Parse(txt_prodPrice.Text), int.Parse(txt_prodQuantity.Text), path, txt_prodProm.Text, int.Parse(ddl_category.SelectedValue));
                                Response.Redirect("~/Admin/ViewProduct.aspx");

                            //}
                        }
                        else
                        {
                            lbl_doneOrError.Text = "Wrong image path";
                            lbl_doneOrError.Style.Add("color", "red");
                        }

                    }
                    else
                    {
                        DataTable dt = products.getByid(prod_id);
                        path = dt.Rows[0][4].ToString();
                        products.edit(prod_id, txt_prodName.Text, txt_prodDesc.Text, int.Parse(txt_prodPrice.Text), int.Parse(txt_prodQuantity.Text), path, txt_prodProm.Text, int.Parse(ddl_category.SelectedValue));
                        Response.Redirect("~/Admin/ViewProduct.aspx");

                    }
                }

            }
            catch (Exception ex)
            {
                LogError.Error(ex, System.Reflection.MethodBase.GetCurrentMethod().Name);
            }
        }
    }
}