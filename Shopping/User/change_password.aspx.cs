using ShoppingOnline.AppCode;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Shopping.User
{
    public partial class change_password : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

        }
        protected void btn_change_Click(object sender, EventArgs e)
        {
            if (Session["id"].ToString() != null)
            {
                SqlCommand cmd = new SqlCommand("select * from Customer where cust_id=@id and cust_pass=@pass");
                cmd.Parameters.AddWithValue("@id", int.Parse(Session["id"].ToString()));
                cmd.Parameters.AddWithValue("@pass", int.Parse(txt_old_pass.Text));

                DataTable dt = DBlayer.Sel(cmd);

                if (dt.Rows.Count > 0)
                {
                    cmd = new SqlCommand("update Customer set Cust_pass=@newp where Cust_id=@id and Cust_pass=@oldp");
                    cmd.Parameters.AddWithValue("@id", int.Parse(Session["id"].ToString()));
                    cmd.Parameters.AddWithValue("oldp", int.Parse(dt.Rows[0]["cust_pass"].ToString()));
                    cmd.Parameters.AddWithValue("newp", int.Parse(txt_new_pass.Text));
                    if (DBlayer.Dml(cmd) > 0)
                    {
                        lbl_status.ForeColor = System.Drawing.Color.Green;
                        lbl_status.Text = "password changed ^_^";

                    }
                    else
                    {
                        lbl_status.Text = "enter data Again";

                    }



                }
                else
                {
                    lbl_status.ForeColor = System.Drawing.Color.Red;
                    lbl_status.Text = "Wrong Password";
                }





            }

        }
    }
}