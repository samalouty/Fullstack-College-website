using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Course_Delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnDelete(object sender, EventArgs e)
        {
            try
            {

                String connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
                //create a new connection
                SqlConnection conn = new SqlConnection(connStr);
                int id = Int16.Parse(CourseID.Text);

                SqlCommand Course_Delete = new SqlCommand("Procedures_AdminDeleteCourse", conn);
                Course_Delete.CommandType = CommandType.StoredProcedure;
                Course_Delete.Parameters.Add(new SqlParameter("@CourseID", id));

                conn.Open();
                int x = Course_Delete.ExecuteNonQuery();
                if (x <= 0) {
                    ClientScript.RegisterStartupScript(GetType(), "alert", "alert('Non-existing Course ID.');", true);
                    conn.Close();
                    return;
                }
                conn.Close();
                Response.Write("Course deleted.");


            }

            catch (System.FormatException ex)
            {
                ClientScript.RegisterStartupScript(GetType(), "alert", "alert('Please enter a valid input.');", true);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                ClientScript.RegisterStartupScript(GetType(), "alert", "alert('Cannot delete this course.');", true);

            }
            catch (System.OverflowException ex)
            {
                ClientScript.RegisterStartupScript(GetType(), "alert", "alert('Course ID too large.');", true);
            }
        }
    }
}