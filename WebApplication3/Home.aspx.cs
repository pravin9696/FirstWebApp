using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class Home : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["loginid"]==null)
            {
                Response.Redirect("NewSession.aspx");
            }
            else
            {
                Label1.Text = "Welcome :" + Session["loginid"].ToString();
            }
            //if (Page.IsPostBack==true)
            //{
            //    Label1.Text = "page is post backed.......";
            //}
            //else
            //{
            //    Label1.Text = "first time paged loaded";
            //}
        }
        protected void Page_Init(object sender, EventArgs e)
        {
           
        }
        protected void Page_PreRender(object sender, EventArgs e)
        {
           
        }
        protected void Page_Unload(object sender, EventArgs e)
        {
           
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "button clicked..";
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            Label2.Text = TextBox1.Text;
        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
            // Response.Write("hello!!!!!");
            Response.Write("<script>alert('hello...');</script>");
            int n = 1234;
            Response.Write("<script>alert('value of n="+n+"')</script>") ;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int no = 999;
            //Response.Write("<script>alert('hello 123');</script>");
            Response.Write("<script>alert('welcome "+TextBox1.Text.Trim()+"')</script>");
           // Response.Redirect("login.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {

        }
    }
}