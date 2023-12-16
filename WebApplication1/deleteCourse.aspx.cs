using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class deleteCourse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_deleteCourse_Click(object sender, EventArgs e)
        {
            try
            {
                string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
                int StudentId = Int32.Parse(student_id.Text);
                String SemCode = (semester_code.Text);
                int CourseId = Int32.Parse(course_id.Text);


                SqlConnection conn = new SqlConnection(connStr);

                SqlCommand AdvisorDeleteCourse = new SqlCommand("Procedures_AdvisorDeleteFromGP", conn);
                AdvisorDeleteCourse.CommandType = CommandType.StoredProcedure;
                AdvisorDeleteCourse.Parameters.Add(new SqlParameter("@studentID", StudentId));
                AdvisorDeleteCourse.Parameters.Add(new SqlParameter("@sem_code", SemCode));
                AdvisorDeleteCourse.Parameters.Add(new SqlParameter("@courseID", CourseId));


                conn.Open();
                int i = AdvisorDeleteCourse.ExecuteNonQuery();
                conn.Close();
                if (i > 0) { Response.Write("successful"); }
                else { Response.Write("Unsuccessful"); }
            }

            catch (FormatException ex)
            {
                Response.Write("Input is invalid, Try again!");
            }

        }
    }
}

