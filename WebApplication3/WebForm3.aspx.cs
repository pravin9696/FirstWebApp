using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var a1 = Request.QueryString["userid"];
            var a2 = Request.QueryString["password"];
            if ((Request.QueryString["userid"]!=null) && (Request.QueryString["password"] !=null))
            {
                Label1.Text = Request.QueryString["userid"].ToString();
                Label2.Text = Request.QueryString[1].ToString();
            }
        }
    }
}