using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class CookieForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (Request.Cookies["userID"]!=null)
            {
                HttpCookie temp = Request.Cookies["userID"];
                Label1.Text=temp.Value;
            }
            else
            {
                Label1.Text = "Cookie not available";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie mycookie = new HttpCookie("userID", "admin");
            mycookie.Expires = DateTime.Now.AddDays(1);
            Response.Cookies.Add(mycookie);

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            HttpCookie tempCookie = Request.Cookies["userID"];
            tempCookie.Expires = DateTime.Now.AddDays(-1);
            Response.Cookies.Add(tempCookie);
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            HttpCookie mycookie1 = new HttpCookie("userID", "admin");
            mycookie1.Expires = DateTime.Now.AddDays(1);
            Response.Cookies.Add(mycookie1);
            
            mycookie1 = new HttpCookie("DOB", "01/01/2023");
            mycookie1.Expires = DateTime.Now.AddDays(1);
            Response.Cookies.Add(mycookie1);
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            HttpCookie temp;
            Label1.Text = "";

            for (int i = 0; i < Request.Cookies.Count; i++)
            {
                temp= Request.Cookies[i];
                Label1.Text += " "+temp.Value;

            }
        }
    }
}