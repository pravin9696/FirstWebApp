using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class NewCookieForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //1
            Response.Cookies["Count"].Value = "100 ";
            Response.Cookies["Count"].Expires = DateTime.Now.AddYears(1);

            //2
            HttpCookie c1 = new HttpCookie("count2", "999");
            c1.Expires = DateTime.Now.AddDays(1);
            c1.Secure = true;
            
            Response.Cookies.Add(c1);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (Request.Cookies["Count"] != null)
            {


                Label1.Text = Request.Cookies["Count"].Value;
            }
            else
            {
                Label1.Text = "Count cookie not available";
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            HttpCookie temp;
            Label1.Text = "";
            for (int i = 0; i < Request.Cookies.Count; i++)
            {
                temp = Request.Cookies[i];
                Label1.Text += "<br/>" + temp.Name;
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            /*
            HttpCookie c1 = new HttpCookie("Count");
            c1.Expires = DateTime.Now.AddDays(-1);
            Response.Cookies.Add(c1);
            */
            Response.Cookies["count2"].Expires = DateTime.Now.AddYears(-1);
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            HttpCookie temp;
            Label1.Text = "";
            for (int i = 0; i < Request.Cookies.Count; i++)
            {
                temp = Request.Cookies[i];
                string cookieName = temp.Name;
                Response.Cookies[cookieName].Expires = DateTime.Now.AddYears(-1);
            }
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            HttpCookie cartItem;

            foreach (ListItem item in CheckBoxList1.Items)
            {
                if (item.Selected)
                {
                    cartItem = new HttpCookie(item.Text, item.Value);
                    cartItem.Expires = DateTime.Now.AddDays(100);
                    Response.Cookies.Add(cartItem);
                }
            }
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Label2.Text = "Cart Items :<br/>";
            HttpCookie temp;
            for (int i = 0; i < Request.Cookies.Count; i++)
            {
                temp = Request.Cookies[i];
                string cookieName = temp.Name;
                Label2.Text += "<br/>" + cookieName;
            }
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            int totalBill = 0;
           
            HttpCookie temp;
            for (int i = 0; i < Request.Cookies.Count; i++)
            {
                temp = Request.Cookies[i];
                int cost = int.Parse( temp.Value);
                totalBill+= cost;
               
            }
            Label3.Text = "Total Bill:"+totalBill;
        }
    }
}