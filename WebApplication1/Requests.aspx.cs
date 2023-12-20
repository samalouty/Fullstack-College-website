using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace m3
{
    public partial class Requests : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Click_Click(object sender, EventArgs e)
        {
            try
            {
                string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
                //Create as new Connection
                SqlConnection conn = new SqlConnection(connStr);
                int id = (int)Session["user"];
                String type = "course";
                int cid = Int32.Parse(box1.Text);
                String comm = box2.Text;
                SqlCommand AddCourserequest = new SqlCommand("Procedures_StudentSendingCourseRequest", conn);
                AddCourserequest.CommandType = CommandType.StoredProcedure;
                AddCourserequest.Parameters.Add(new SqlParameter("@courseID", cid));
                AddCourserequest.Parameters.Add(new SqlParameter("@StudentID ", id));
                AddCourserequest.Parameters.Add(new SqlParameter("@type ", type));
                AddCourserequest.Parameters.Add(new SqlParameter("@comment ", comm));
                box1.Text = String.Empty;
                box2.Text = String.Empty;
                conn.Open();
                AddCourserequest.ExecuteNonQuery();
                conn.Close();

                ClientScript.RegisterStartupScript(GetType(), "alert", "alert('Request Added Successfully');", true);
            }

            catch (System.FormatException ex)
            {
                ClientScript.RegisterStartupScript(GetType(), "alert", "alert('input cannot be empty or invalid datatype!');", true);


            }
            catch (OverflowException)
            {

                ClientScript.RegisterStartupScript(GetType(), "alert", "alert('Invalid Course ID!');", true);
            }

        }
        protected void Click0_Click(object sender, EventArgs e)
        {
            try {

                string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
                //Create as new Connection
                SqlConnection conn = new SqlConnection(connStr);
                int id = (int)Session["user"];
                String type = "credit_hours";
                int ch = Int32.Parse(box3.Text);
                String comm = box4.Text;
                SqlCommand AddCHequest = new SqlCommand("Procedures_StudentSendingCHRequest", conn);
                AddCHequest.CommandType = CommandType.StoredProcedure;
                AddCHequest.Parameters.Add(new SqlParameter("@StudentID", id));
                AddCHequest.Parameters.Add(new SqlParameter("@credit_hours", ch));
                AddCHequest.Parameters.Add(new SqlParameter("@type", type));
                AddCHequest.Parameters.Add(new SqlParameter("@comment", comm));
                box3.Text = String.Empty;
                box4.Text = String.Empty;
                conn.Open();
                AddCHequest.ExecuteNonQuery();
                conn.Close();

                ClientScript.RegisterStartupScript(GetType(), "alert", "alert('Request Added Successfully');", true);
            }
            catch(System.FormatException ex)
            {
                ClientScript.RegisterStartupScript(GetType(), "alert", "alert('input cannot be empty or invalid datatype!');", true);



            }
            catch (OverflowException)
            {

                ClientScript.RegisterStartupScript(GetType(), "alert", "alert('Invalid Course ID!');", true);
            }



        }

        protected void Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("Options.aspx");
        }
    }
}