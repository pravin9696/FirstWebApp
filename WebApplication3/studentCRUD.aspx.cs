using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Data.Common;

namespace WebApplication3
{
    public partial class studentCRUD : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-E43S078\\SQLEXPRESS;Initial Catalog=GTHPractice;Integrated Security=True");
            SqlDataAdapter adp = new SqlDataAdapter("select * from student", con);
            SqlCommandBuilder cmd = new SqlCommandBuilder(adp);
            DataSet ds = new DataSet();
            adp.Fill(ds, "student");

            DataRow dr = ds.Tables["student"].NewRow();
            dr[0] = int.Parse(TextBox1.Text);
            dr[1] = TextBox2.Text;
            dr[2] = int.Parse(TextBox3.Text);
            dr[3] = int.Parse(TextBox4.Text);
            ds.Tables["student"].Rows.Add(dr);
            int n=adp.Update(ds,"student");
            if (n>0)
            {
                Response.Write("<script>alert('inserted successfully')</script>");
            }
            else
            {
                Response.Write("<script>alert('NOT inserted!!!!!!!')</script>");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-E43S078\\SQLEXPRESS;Initial Catalog=GTHPractice;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("spinsertStudent", con);
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@roll", TextBox1.Text);
            cmd.Parameters.AddWithValue("@name", TextBox2.Text);
            cmd.Parameters.AddWithValue("@age", TextBox3.Text);
            cmd.Parameters.AddWithValue("@mob", TextBox4.Text);

            SqlDataAdapter adp = new SqlDataAdapter();
            adp.InsertCommand = cmd;

            int n = adp.InsertCommand.ExecuteNonQuery();
            if (n > 0)
            {
                Response.Write("<script>alert('inserted successfully')</script>");
            }
            else
            {
                Response.Write("<script>alert('NOT inserted!!!!!!!')</script>");
            }


        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-E43S078\\SQLEXPRESS;Initial Catalog=GTHPractice;Integrated Security=True");
            SqlDataAdapter adp = new SqlDataAdapter("select * from student where roll=@roll", con);
            SqlCommandBuilder cmd = new SqlCommandBuilder(adp);
            adp.SelectCommand.Parameters.AddWithValue("@roll", TextBox1.Text);
            DataSet ds = new DataSet();
            adp.Fill(ds, "student");

            if (ds.Tables["student"].Rows.Count>0)
            {
                Response.Write("<script>alert('found....')</script>");
            }
            else
            {

                Response.Write("<script>alert('NOT found!!!!')</script>");
            }


        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-E43S078\\SQLEXPRESS;Initial Catalog=GTHPractice;Integrated Security=True");
            SqlDataAdapter adp = new SqlDataAdapter("spSelectStudent", con);
            SqlCommandBuilder cmd = new SqlCommandBuilder(adp);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@roll", TextBox1.Text);
            DataSet ds = new DataSet();
            adp.Fill(ds, "student");

            if (ds.Tables["student"].Rows.Count > 0)
            {
                DataRow dr = ds.Tables["student"].Rows[0];
                Response.Write("<script>alert('found....')</script>");
                TextBox2.Text = dr[1].ToString();
            }
            else
            {

                Response.Write("<script>alert('NOT found!!!!')</script>");
            }
        }
    }
}