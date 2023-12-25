using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class NewSession : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userCount"]!=null)
            {
                Label2.Text = Session["userCount"].ToString();
            }
            else
            {
                Label2.Text = "Session of userCount not available!!!";
            }
            Label3.Text = Session["scount"].ToString();
            Label4.Text = Application["appcount"].ToString();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session.Abandon();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Session["userCount"] = 0;
            Session.Timeout = 1;


            Session["loginid"] = "admin";
            Response.Redirect("home.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int apcount = int.Parse(Application["appcount"].ToString());

            int sscount = int.Parse(Session["scount"].ToString());
            apcount++;
            sscount++;
            Application["appcount"] = apcount;
            Session["scount"] = sscount;
            
        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {

        }
    }
}