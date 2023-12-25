using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class NewStudReg : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            /* SqlConnection con;
             SqlDataAdapter adp;
             DataSet ds;
             SqlCommandBuilder cmd;
            */
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-E43S078\\SQLEXPRESS;Initial Catalog=GTHPractice;Integrated Security=True");

            SqlDataAdapter adp = new SqlDataAdapter("select * from tblStudentTemp", con);
            SqlCommandBuilder scb = new SqlCommandBuilder(adp);
            DataSet ds = new DataSet();
            adp.Fill(ds, "tblStudentTemp");

            DataRow row = ds.Tables["tblStudentTemp"].NewRow();
            row["roll"] = txtRoll.Text;
            row["name"] = txtName.Text;
            row[2] = txtTotalMarks.Text;
            ds.Tables[0].Rows.Add(row);
           int n= adp.Update(ds, "tblStudentTemp");
            if (n>0)
            {
                Response.Write("<script>alert('record inserted successfully....')</script>");
            }
            else
            {
                Response.Write("<script>alert('Not inserted!!!!!!!!!!')</script>");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string qry = "select * from tblStudentTemp where name='" + txtName.Text+"'";
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-E43S078\\SQLEXPRESS;Initial Catalog=GTHPractice;Integrated Security=True");
            SqlDataAdapter adp = new SqlDataAdapter(qry, con);
            SqlCommandBuilder cmdb = new SqlCommandBuilder(adp);

            DataSet ds = new DataSet();
            adp.Fill(ds, "tblStudentTemp");
            if (ds.Tables["tblStudentTemp"].Rows.Count>0)
            {
                DataRow dr = ds.Tables["tblStudentTemp"].Rows[0];
                dr[1] = txtName.Text.Trim();//name
                dr[2] = txtTotalMarks.Text;//total marks
               int n= adp.Update(ds, "tblStudentTemp");
                if (n > 0)
                {
                    Response.Write("<script>alert('record updated successfully....')</script>");
                }
                else
                {
                    Response.Write("<script>alert('Not updated!!!!!!!!!!')</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('Record not available to update!!!!!!!!!!')</script>");
            }

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string qry = "select * from tblStudentTemp";
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-E43S078\\SQLEXPRESS;Initial Catalog=GTHPractice;Integrated Security=True");
            SqlDataAdapter adp = new SqlDataAdapter(qry, con);
            SqlCommandBuilder cmdb = new SqlCommandBuilder(adp);

            DataSet ds = new DataSet();
            adp.Fill(ds, "tblStudentTemp");

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                if (row[1].ToString()==txtName.Text.Trim())
                {
                    //row[1] = txtName.Text.Trim();//name
                    row[2] = txtTotalMarks.Text;//total marks
                }
            }
            int n = adp.Update(ds, "tblStudentTemp");
            if (n > 0)
            {
                Response.Write("<script>alert('n= "+n+"record updated successfully....')</script>");
            }
            else
            {
                Response.Write("<script>alert('Not updated!!!!!!!!!!')</script>");
            }

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string qry = "select * from tblStudentTemp where roll="+txtRoll.Text;
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-E43S078\\SQLEXPRESS;Initial Catalog=GTHPractice;Integrated Security=True");
            SqlDataAdapter adp = new SqlDataAdapter(qry, con);
            SqlCommandBuilder cmdb = new SqlCommandBuilder(adp);

            DataSet ds = new DataSet();
            adp.Fill(ds, "tblStudentTemp");
            if (ds.Tables["tblStudentTemp"].Rows.Count > 0)
            {
                DataRow dr = ds.Tables["tblStudentTemp"].Rows[0];
                dr.Delete();
                int n = adp.Update(ds, "tblStudentTemp");
                if (n > 0)
                {
                    Response.Write("<script>alert('record deleted  successfully....')</script>");
                }
                else
                {
                    Response.Write("<script>alert('Not delete !!!!!!!!!!')</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('Record not available for delete!!!!!!!!!!')</script>");
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            SqlConnection con= new SqlConnection("Data Source=DESKTOP-E43S078\\SQLEXPRESS;Initial Catalog=GTHPractice;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("spInsertStudent", con);
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@roll", txtRoll.Text);
            cmd.Parameters.AddWithValue("@name", txtName.Text);
            cmd.Parameters.AddWithValue("@tm", txtTotalMarks.Text);

            SqlDataAdapter adp = new SqlDataAdapter();
            adp.InsertCommand = cmd;
            int n=adp.InsertCommand.ExecuteNonQuery();
            if (n>0)
            {
                Response.Write("<script>alert('record inserted successfully....')</script>");
            }
            else
            {
                Response.Write("<script>alert('record NOT inserted !!!!!')</script>");
            }
            con.Close();
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-E43S078\\SQLEXPRESS;Initial Catalog=GTHPractice;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("spSelectStudByRoll", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@roll", txtRoll.Text);

            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = cmd;
            DataSet ds = new DataSet();
            adp.Fill(ds, "tblStudentTemp");
            if (ds.Tables["tblStudentTemp"].Rows.Count<=0)
            {
                Response.Write("<script>alert('Record not found!!!!');</script>");
                txtName.Text = "";
                txtTotalMarks.Text = "";
            }
            else
            {
                DataRow dr = ds.Tables[0].Rows[0];
                txtName.Text = dr[1].ToString();
                txtTotalMarks.Text = dr["total_marks"].ToString();
            }
            con.Close();

        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            SqlConnection con=new SqlConnection("Data Source=DESKTOP-E43S078\\SQLEXPRESS;Initial Catalog=GTHPractice;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("spSelectStudentAll", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter adp = new SqlDataAdapter(cmd);
             DataSet ds = new DataSet();
            adp.Fill(ds, "tblStudentTemp");
            GridView1.DataSource = ds.Tables["tblStudentTemp"];
            GridView1.DataBind();
            DropDownList1.DataSource = ds.Tables[0];
            DropDownList1.DataTextField = "name";
            DropDownList1.DataValueField = "roll";
            DropDownList1.DataBind();
            
            con.Close();

        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-E43S078\\SQLEXPRESS;Initial Catalog=GTHPractice;Integrated Security=True");

            SqlCommand cmd = new SqlCommand("spInsertStudent1", con);
            
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.InsertCommand = cmd;
            adp.InsertCommand.CommandType = CommandType.StoredProcedure;

            adp.InsertCommand.Parameters.AddWithValue("@roll", txtRoll.Text);
            adp.InsertCommand.Parameters.AddWithValue("@name", txtName.Text);
            adp.InsertCommand.Parameters.AddWithValue("@tm",txtTotalMarks.Text);
            con.Open();
            int n=adp.InsertCommand.ExecuteNonQuery();
            if (n>0)
            {
                Response.Write("<script>alert('Record inserted successfully...');</script>");
            }
            else
            {
                Response.Write("<script>alert('Record not inserted!!!!');</script>");
            }

            con.Close();

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBox1.Text = DropDownList1.SelectedValue;
        }
    }
}
