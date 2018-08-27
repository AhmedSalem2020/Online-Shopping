using ShoppingOnline.AppCode;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShoppingOnline.User
{
    public partial class ViewProducts : System.Web.UI.Page
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
            //DataTable dt;
            lbl_res.Text = "";
            if (!IsPostBack)
            {
                if (Session["isadmin"] != null)
                {
                    if (int.Parse(Session["isadmin"].ToString()) == 1)
                    {
                        Response.Redirect("~/Admin/HomeAdmin.aspx");
                    }
                }

                if (lst_cate.SelectedIndex == 0 || lst_names.SelectedIndex == 0 || lst_price.SelectedIndex == 0)

                {
                    lst_cate.DataSource = products.getAllCate();
                    lst_cate.DataTextField = "Category_name";
                    lst_cate.DataValueField = "Category_id";
                    lst_cate.DataBind();
                    lst_names.DataSource = products.getProdNames();
                    lst_names.DataTextField = "Prod_name";
                    lst_names.DataValueField = "Prod_id";
                    lst_names.DataBind();
                    lst_price.DataSource = products.getProdPrice();
                    lst_price.DataTextField = "Prod_price";
                    lst_price.DataValueField = "Prod_id";
                    lst_price.DataBind();
                    
                        lstView_data.DataSource = products.getAll();
                        lstView_data.DataBind();
                        

                    
                }
            }

        }

        protected void lst_cate_SelectedIndexChanged(object sender, EventArgs e)
        {
            string category = lst_cate.SelectedItem.Text;
            ////if
            if (lst_cate.SelectedValue != "Select Category")
            {
                int id = int.Parse(lst_cate.SelectedValue);
                lstView_data.DataSource = products.getByCateg(category);
                lstView_data.DataBind();
                //--------------------
                // DataTable dt= products.getProdByCategory(id);
                //   if (!IsPostBack)

                lst_names.Items.Clear();
                lst_price.Items.Clear();

                lst_names.Items.Insert(0, new ListItem("Select Book"));
                lst_price.Items.Insert(0, new ListItem("Select Price"));

                lst_names.DataSource = products.getProdNamesByCat(id);
                lst_names.DataBind();
                lst_price.DataSource = products.getProdpriceByCat(id);
                lst_price.DataBind();

                lst_names.SelectedIndex = 0;
                lst_price.SelectedIndex = 0;

            }
            else
            {
                lst_names.Items.Clear();
                lst_price.Items.Clear();
                lst_cate.Items.Clear();
                lst_names.Items.Insert(0, new ListItem("Select Book"));
                lst_price.Items.Insert(0, new ListItem("Select Price"));
                lst_cate.Items.Insert(0, new ListItem("Select Category"));
                lstView_data.DataSource = products.getAll();
                lstView_data.DataBind();
                lst_cate.DataSource = products.getAllCate();
                lst_cate.DataBind();
                lst_names.DataSource = products.getProdNames();
                lst_names.DataBind();
                lst_price.DataSource = products.getProdPrice();
                lst_price.DataBind();
            }

        }

        protected void lst_names_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = lst_names.SelectedItem.Text;
            if (lst_names.SelectedValue != "Select Book")
            {


                int id = int.Parse(lst_names.SelectedValue);
                lstView_data.DataSource = products.getByName(name);
                lstView_data.DataBind();
               
                lst_cate.SelectedIndex = 0;
                lst_price.SelectedIndex = 0;
                
            }
            else
            {
                lst_names.Items.Clear();
                lst_price.Items.Clear();
                lst_cate.Items.Clear();
                lst_names.Items.Insert(0, new ListItem("Select Book"));
                lst_price.Items.Insert(0, new ListItem("Select Price"));
                lst_cate.Items.Insert(0, new ListItem("Select Category"));

                lstView_data.DataSource = products.getAll();
                lstView_data.DataBind();
                lst_cate.DataSource = products.getAllCate();
                lst_cate.DataBind();
                lst_names.DataSource = products.getProdNames();
                lst_names.DataBind();
                lst_price.DataSource = products.getProdPrice();
                lst_price.DataBind();
            }
        }

        protected void lst_price_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (/*lst_price.SelectedValue != "Select Price"*/ lst_price.SelectedItem.Text != "Select Price")
            {
                decimal price = decimal.Parse(lst_price.SelectedItem.Text);

                lstView_data.DataSource = products.getbyPrice(price);
                lstView_data.DataBind();
                lst_cate.SelectedIndex = 0;
                lst_names.SelectedIndex = 0;
                //lst_cate.SelectedIndex = lst_cate.Items.IndexOf(lst_cate.Items.FindByValue(lst_names.SelectedIndex.ToString()));
                //lst_cate.SelectedIndex = lst_cate.Items.IndexOf(lst_cate.Items.FindByValue(lst_price.SelectedIndex.ToString()));
            }
            else
            {
                lst_names.Items.Clear();
                lst_price.Items.Clear();
                lst_cate.Items.Clear();
                lst_names.Items.Insert(0, new ListItem("Select Book"));
                lst_price.Items.Insert(0, new ListItem("Select Price"));
                lst_cate.Items.Insert(0, new ListItem("Select Category"));

                lstView_data.DataSource = products.getAll();
                lstView_data.DataBind();
                lst_cate.DataSource = products.getAllCate();
                lst_cate.DataBind();
                lst_names.DataSource = products.getProdNames();
                lst_names.DataBind();
                lst_price.DataSource = products.getProdPrice();
                lst_price.DataBind();
            }
        }

        protected void txt_search_TextChanged(object sender, EventArgs e)
        {
            string bookname = txt_search.Text;
            // for (int i = 1; i < lst_names.Items.Count; i++)
            try
            {
                if (bookname == products.getByName(bookname).Rows[0]["Prod_name"].ToString())
                {
                    lstView_data.DataSource = products.getByName(bookname);
                    lstView_data.DataBind();
                }

            }
            catch
            {
                lbl_res.Text = "Not Found";
            }
            //finally
            //{

            //    lstView_data.Items.Remove();

            //}
        }
        protected void btn_Add_Click(object sender, EventArgs e)
        {
            if (Session["id"]!= null)
            {
                int user_id = int.Parse(Session["id"].ToString());
                Button btn = sender as Button;
                int prod_id = int.Parse(btn.CommandArgument.ToString());


                DataTable dt = new DataTable();
                dt = Cart_products.search(user_id, prod_id);

                if (dt.Rows.Count == 0)
                {

                    int i = Cart_products.insert(user_id, prod_id);
                }
                else
                {
                    int quant = (int)(dt.Rows[0]["quantity"]);

                    int l = Cart_products.change_quantity(user_id, prod_id, quant + 1);

                }

            }
            else
            {
                Lbl_cart.Text = "you are not allowed to add to you profile please login first.";
            }
        }
        //Samar
        protected string CutText(object text, int length)
        {
            if (DBNull.Value == text || text == null) return "";
            string txt = text.ToString();
            if (txt.Length <= length) return txt;
            return txt.Substring(0, length);
        }
        protected void lbtn_read_Click(object sender,EventArgs e)
        {
            LinkButton lbtn = sender as LinkButton;
            int prod_id = int.Parse(lbtn.CommandArgument.ToString());
            Lv_Read.DataSource = products.getByid(prod_id);
            Lv_Read.DataBind();
            Page.ClientScript.RegisterStartupScript(this.GetType(), "show", "showDialog();", true);

        }


        protected void btn_Cancel_Click(object sender, EventArgs e)
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "hide", "hideDialog();", true);

        }
    }
}