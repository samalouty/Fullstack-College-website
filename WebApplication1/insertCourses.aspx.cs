using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class insertCourses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_insertCourse_Click(object sender, EventArgs e)
        {
            try
            {
                string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
                int studentId = Int32.Parse(student_id.Text);
                String SemCode = (semester_code.Text);
                String CourseName = (course_name.Text);

                /* @Semester_code varchar(40), 
                    @expected_graduation_date date, 
                    @sem_credit_hours int,
                    @advisor_id int,
                    @student_id int */
                SqlConnection conn = new SqlConnection(connStr);

                SqlCommand AdvisorAddCourse = new SqlCommand("Procedures_AdvisorAddCourseGP", conn);
                AdvisorAddCourse.CommandType = CommandType.StoredProcedure;
                AdvisorAddCourse.Parameters.Add(new SqlParameter("@student_id", studentId));
                AdvisorAddCourse.Parameters.Add(new SqlParameter("@Semester_code", SemCode));
                AdvisorAddCourse.Parameters.Add(new SqlParameter("@course_name", CourseName));

                conn.Open();
                int i = AdvisorAddCourse.ExecuteNonQuery();
                conn.Close();
                if (i > 0) { Response.Write("successful"); }
                else { Response.Write("Unsuccessful"); }
            }

            catch (FormatException ex)
            {
                Response.Write("Input is invalid, Try again!");
            }

            catch (SqlException sq) {
                Response.Write("No graduation plan to add the course to");

            }

        }
    }
}