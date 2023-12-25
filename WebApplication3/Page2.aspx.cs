using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class Page2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Page.PreviousPage!=null)
            {
                TextBox txtUser= (TextBox)PreviousPage.FindControl("TextBox1");
                Label1.Text=txtUser.Text;
            }
            Label2.Text = "";

            foreach (ListItem item in CheckBoxList1.Items)
            {
                if (item.Selected)
                {
                    Label2.Text += " " + item.Text;
                }
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Label2.Text = "";

            Label1.Text = RadioButtonList1.SelectedValue;

        }
    }
}