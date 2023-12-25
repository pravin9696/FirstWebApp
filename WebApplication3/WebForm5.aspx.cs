using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Request.QueryString["userid"]!=null)
            {
                Label1.Text = "welcome :" + Request.QueryString["userid"].ToString();
            }
            else
            {
                Response.Write("<script>alert('login first')</script>");
                Response.Redirect("webform4.aspx");
            }
            //string fn = string.Empty;
            //string ln="";

            //if (Request.QueryString["firstname"] != null)
            //{
            //    fn = Request.QueryString["firstname"].ToString();
            //}
            //if (Request.QueryString["lastname"] != null)
            //{
            //    ln = Request.QueryString["lastname"].ToString();
            //}
            //Label1.Text = fn;
            //Label2.Text = ln;
        }
    }
}