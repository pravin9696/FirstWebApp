using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string s1 = "";
            if (Request.Cookies["c1"]!=null)
            {
                s1 += Request.Cookies["c1"].Value+"*";
            }

            Response.Cookies["c1"].Value = s1+"pune";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string s1 = "";
            if (Request.Cookies["c1"] != null)
            {
                s1 += Request.Cookies["c1"].Value + "*";
            }

            Response.Cookies["c1"].Value = s1 + "Nagpur";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Label1.Text = "";
            if (Request.Cookies["c1"] != null)
            {
                string []temp = Request.Cookies["c1"].Value.Split('*');
                foreach (string item in temp)
                {
                    Label1.Text +="<br/>" +item;
                }
                
            }
        }
    }
}