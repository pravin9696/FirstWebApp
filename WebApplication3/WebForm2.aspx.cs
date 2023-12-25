using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            HttpCookie hc;
            Label3.Text = "";
            for (int i = 0; i < Request.Cookies.Count; i++)
            {
                hc = Request.Cookies[i];
                Label3.Text += "<br/> " + hc.Value;
            }
           /* if (Page.IsPostBack)
            {
                if (ViewState["count"] != null)
                {
                    int cnt = int.Parse(ViewState["count"].ToString());
                    cnt++;
                    ViewState["count"] = cnt;
                    Response.Write("<script>alert('count=" + cnt + "')</script>");
                }
                else
                {
                    ViewState["count"] = 1;
                }

                if (ViewState["msg"] != null)
                {
                    Response.Write("<script>alert('" + ViewState["msg"] + "')</script>");
                }
            }
           */
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Label1.Text = "hello";
            Label2.Text = " Pune";
            Button2.Text="OK";
            Label2.Text = HiddenField1.Value;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HiddenField1.Value = "abcd";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm3.aspx?userid=admin&password=admin123");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            //Response.Cookies["un"].Value= "pravin";
            //Response.Cookies["un"].Expires = DateTime.Now.AddDays(1);
            HttpCookie ck = new HttpCookie("mycookie");
            ck.Value = "xyz";
            ck.Expires = DateTime.Now.AddYears(1);
            Response.Cookies.Add(ck);
        }
    }
}