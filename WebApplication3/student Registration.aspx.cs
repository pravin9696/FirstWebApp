using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class student_Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            int deleted;
            if(DropDownlist1.SelectedIndex==1)
            {
                deleted = 0;
            }
            else
            {
                deleted = 1;
            }
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-E43S078\SQLEXPRESS;Initial Catalog=GTHPractice;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into tbllogin values(@username,@pass,@deleted)";
            cmd.CommandType = System.Data.CommandType.Text; ;
            cmd.Parameters.AddWithValue("@username", TextBox1.Text);
            cmd.Parameters.AddWithValue("@pass", TextBox2.Text);
            cmd.Parameters.AddWithValue("@deleted", deleted);

            int n= cmd.ExecuteNonQuery();
            if (n>0)
            {
                Response.Write("<script>alert('Record inserted Successfully......')</script>");
            }
            else
            {
                Response.Write("<script>alert('Record not inserted!!!!!!')</script>");
            }

            con.Close();

        }
    }
}