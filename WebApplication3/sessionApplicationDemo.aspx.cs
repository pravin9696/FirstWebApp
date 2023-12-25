using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class sessionApplicationDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void Page_PreRender(object sender, EventArgs e)
        {
            lblApplication.Text = Application["apcount"].ToString();
            lblSession.Text = Session["scount"].ToString();
            if (Session["ssid"] != null)
            {
                Label2.Text = Session["ssid"].ToString();

            }
            if (Application["appid"] != null)
            {
                Label3.Text = Application["appid"].ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["ssid"] = TextBox1.Text;
            Application["appid"] = TextBox1.Text;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

           int apc=int.Parse( Application["apcount"].ToString());
           int sc=int.Parse( Session["scount"].ToString());
            apc++;
            sc++;
            Application["apcount"]=apc;
            Session["scount"]=sc;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Session.Abandon();
        }
    }
}