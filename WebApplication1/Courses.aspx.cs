using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Web;
using System.Web.Configuration;
using System.Web.DynamicData;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace m3
{
    public partial class Tel_Courses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void optionalcourses_Click(object sender, EventArgs e)
        {
            try
            {
                string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
                //Create as new Connection
                SqlConnection conn = new SqlConnection(connStr);
                int id = (int)Session["user"];
                String scode = TextBox1.Text;
                Session["scode"] = scode;
                SqlCommand Viewoptional = new SqlCommand("Procedures_ViewOptionalCourse", conn);
                Viewoptional.CommandType = CommandType.StoredProcedure;
                Viewoptional.Parameters.Add(new SqlParameter("@StudentID", id));
                Viewoptional.Parameters.Add(new SqlParameter("@current_semester_code", scode));
                conn.Open();
                SqlDataReader rdr = Viewoptional.ExecuteReader(CommandBehavior.CloseConnection);
                DataTable dt = new DataTable();
                dt.Columns.Add("Course_id", typeof(int));
                dt.Columns.Add("Coursename", typeof(String));
                rdr.Read();
                do
                {
                    String cname = rdr.GetString(rdr.GetOrdinal("name"));
                    int courseid = rdr.GetInt32(rdr.GetOrdinal("course_id"));
                    DataRow newRow = dt.NewRow();
                    newRow["Course_id"] = courseid;
                    newRow["Coursename"] = cname;
                    dt.Rows.Add(newRow);
                }
                while (rdr.Read());
                GridView2.DataSource = dt;
                GridView2.DataBind();
                conn.Close();


            }
            catch (System.InvalidOperationException ex)

            {
                ClientScript.RegisterStartupScript(GetType(), "alert", "alert('Invalid semcode or no optional courses ');", true);
                DataTable dt = new DataTable();
                GridView2.DataSource = dt;
                GridView2.DataBind();



            }
        }

        protected void availablecourses_Click(object sender, EventArgs e)
        {
            try {
                string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
                //Create as new Connection
                SqlConnection conn = new SqlConnection(connStr);

                String code = TextBox1.Text;
                conn.Open();
                SqlCommand Viewavaialable = new SqlCommand("Select * from dbo.FN_SemsterAvailableCourses(@semstercode)", conn);
                Viewavaialable.CommandType = CommandType.Text;
                Viewavaialable.Parameters.Add(new SqlParameter("@semstercode", code));
                SqlDataReader rdr = Viewavaialable.ExecuteReader(CommandBehavior.CloseConnection);
                DataTable dt = new DataTable();
                dt.Columns.Add("Course_id", typeof(int));
                dt.Columns.Add("Coursename", typeof(String));
                rdr.Read();
                do
                {
                    String cname = rdr.GetString(rdr.GetOrdinal("name"));
                    int courseid = rdr.GetInt32(rdr.GetOrdinal("course_id"));
                    DataRow newRow = dt.NewRow();
                    newRow["Course_id"] = courseid;
                    newRow["Coursename"] = cname;
                    dt.Rows.Add(newRow);
                }
                while (rdr.Read());
                GridView1.DataSource = dt;
                GridView1.DataBind();
                conn.Close();

            
            }
            catch (System.InvalidOperationException ex)

            {
                ClientScript.RegisterStartupScript(GetType(), "alert", "alert('Invalid semcode or no available courses in this sem');", true);
                DataTable dt = new DataTable();
                GridView1.DataSource = dt;
                GridView1.DataBind();


            }
        }

        protected void requiredcourses_Click(object sender, EventArgs e)
        {

            try
            {
                string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
                //Create as new Connection
                SqlConnection conn = new SqlConnection(connStr);
                int id = (int)Session["user"];
                String scode = TextBox1.Text;
                Session["scode"] = scode;
                SqlCommand Viewrequired = new SqlCommand("Procedures_ViewRequiredCourses", conn);
                Viewrequired.CommandType = CommandType.StoredProcedure;
                Viewrequired.Parameters.Add(new SqlParameter("@StudentID", id));
                Viewrequired.Parameters.Add(new SqlParameter("@current_semester_code", scode));
                conn.Open();
                SqlDataReader rdr = Viewrequired.ExecuteReader(CommandBehavior.CloseConnection);
                DataTable dt = new DataTable();
                dt.Columns.Add("Course_id", typeof(int));
                dt.Columns.Add("Coursename", typeof(String));
                rdr.Read();
                do
                {
                    String cname = rdr.GetString(rdr.GetOrdinal("name"));
                    int courseid = rdr.GetInt32(rdr.GetOrdinal("course_id"));
                    DataRow newRow = dt.NewRow();
                    newRow["Course_id"] = courseid;
                    newRow["Coursename"] = cname;
                    dt.Rows.Add(newRow);
                }
                while (rdr.Read());
                GridView3.DataSource = dt;
                GridView3.DataBind();
                conn.Close();
            }
            catch (System.InvalidOperationException ex)

            {
                ClientScript.RegisterStartupScript(GetType(), "alert", "alert('Invalid semcode or no required courses ');", true);
                DataTable dt = new DataTable();
                GridView3.DataSource = dt;
                GridView3.DataBind();


            }


        }
        protected void missingcourses_Click(object sender, EventArgs e)
        {

            try
            {
                string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
                //Create as new Connection
                SqlConnection conn = new SqlConnection(connStr);
                int id = (int)Session["user"];
                SqlCommand Viewmissing = new SqlCommand("Procedures_ViewMS", conn);
                Viewmissing.CommandType = CommandType.StoredProcedure;
                Viewmissing.Parameters.Add(new SqlParameter("@StudentID", id));
                conn.Open();
                SqlDataReader rdr = Viewmissing.ExecuteReader(CommandBehavior.CloseConnection);
                DataTable dt = new DataTable();
                dt.Columns.Add("Course_id", typeof(int));
                dt.Columns.Add("Coursename", typeof(String));
                rdr.Read();
                do
                {
                    String cname = rdr.GetString(rdr.GetOrdinal("name"));
                    int courseid = rdr.GetInt32(rdr.GetOrdinal("course_id"));
                    DataRow newRow = dt.NewRow();
                    newRow["Course_id"] = courseid;
                    newRow["Coursename"] = cname;
                    dt.Rows.Add(newRow);
                }
                while (rdr.Read());
                GridView4.DataSource = dt;
                GridView4.DataBind();
                conn.Close();


            }
            catch (System.InvalidOperationException ex)

            {
                ClientScript.RegisterStartupScript(GetType(), "alert", "alert('Invalid semcode or no missing courses ');", true);
                DataTable dt = new DataTable();
                GridView4.DataSource = dt;
                GridView4.DataBind();


            }


        }

        protected void Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("Options.aspx");
        }
    }
}