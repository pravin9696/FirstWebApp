using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           // if (ViewState["gmailId"] != null)
            //    Response.Write("<script>alert('" + ViewState["gmailId"].ToString() + "')</script>");

        }
        protected void Page_PreRender(object sender, EventArgs e)
        {
            if (ViewState["gmailId"] != null)
                Response.Write("<script>alert('" + ViewState["gmailId"].ToString() + "')</script>");

        }
        //at server
        protected void Button1_Click(object sender, EventArgs e)
        {
           // Label1.Text = TextBox1.Text;
           // Label2.Text = TextBox1.Text;
            //HiddenField1.Value = "welcome " + TextBox1.Text;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            ViewState["gmailId"] = TextBox1.Text;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string fname = TextBox2.Text;
            string lname = TextBox3.Text;
            //query string
            //Response.Redirect("webform5.aspx?key=value&key=value&key=value");
            Response.Redirect("webform5.aspx?firstname=" + fname + "&lastname=" + lname);
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            if (TextBox2.Text=="admin"&&TextBox3.Text=="admin123")
            {
                Response.Redirect("webform5.aspx?userid=" + TextBox2.Text);
            }
            else
            {
                Response.Write("<script>alert('invalid user id or password')</script>");
            }
        }
    }
}