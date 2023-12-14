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
    public partial class StudToCourseInst : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Add any initialization logic if needed
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                try
                {
                    String connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
                    SqlConnection conn = new SqlConnection(connStr);

                    int courseNum = int.Parse(courseId.Text);
                    int instID = int.Parse(instructorId.Text);
                    int studID = int.Parse(studentId.Text);
                    String semCode = semesterCode.Text;

                   


                    SqlCommand SICTinsert = new SqlCommand("Procedures_AdminLinkStudent", conn);
                    SICTinsert.CommandType = CommandType.StoredProcedure;
                    SICTinsert.Parameters.Add(new SqlParameter("@cours_id", courseNum));
                    SICTinsert.Parameters.Add(new SqlParameter("@instructor_id", instID));
                    SICTinsert.Parameters.Add(new SqlParameter("@studentID", studID));
                    SICTinsert.Parameters.Add(new SqlParameter("@semester_code", semCode));



                    conn.Open();
                    SICTinsert.ExecuteNonQuery();
                    conn.Close();
                    Response.Write("Linked a student to a course with a specific instructor");
                }
                catch (SqlException sq) {

                    String connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
                    SqlConnection conn = new SqlConnection(connStr);

                    int courseNum = int.Parse(courseId.Text);
                    int instID = int.Parse(instructorId.Text);
                    int studID = int.Parse(studentId.Text);

                    if (!IsIdValid(courseNum, "Course", "course_id", conn))
                    {
                        ClientScript.RegisterStartupScript(GetType(), "alert", "alert('Non-existing Course ID. Please enter a valid Course ID.');", true);
                        return;
                    }
                    if (!IsIdValid(instID, "Instructor", "instructor_id", conn))
                    {
                        ClientScript.RegisterStartupScript(GetType(), "alert", "alert('Non-existing intructor ID. Please enter a valid Instructor ID.');", true);
                        return;
                    }
                    if (!IsIdValid(studID, "Student", "student_id", conn))
                    {
                        ClientScript.RegisterStartupScript(GetType(), "alert", "alert('Non-existing Student ID. Please enter a valid Student ID.');", true);
                        return;
                    }
                    ClientScript.RegisterStartupScript(GetType(), "alert", "alert('Duplicate Record detected make sure that the values entered are correct');", true);

                }
            }
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrEmpty(courseId.Text) || string.IsNullOrEmpty(instructorId.Text) || string.IsNullOrEmpty(studentId.Text) || string.IsNullOrEmpty(semesterCode.Text))
            {
                ClientScript.RegisterStartupScript(GetType(), "alert", "alert('All fields are required.');", true);
                return false;
            }

            int courseIdValue, instructorIdValue, studentIdValue;

            if (!int.TryParse(courseId.Text, out courseIdValue))
            {
                ClientScript.RegisterStartupScript(GetType(), "alert", "alert('Course ID should be an Integer.');", true);
                return false;
            }

            if (!int.TryParse(instructorId.Text, out instructorIdValue))
            {
                ClientScript.RegisterStartupScript(GetType(), "alert", "alert('Instructor ID should be an Integer.');", true);
                return false;
            }

            if (!int.TryParse(studentId.Text, out studentIdValue))
            {
                ClientScript.RegisterStartupScript(GetType(), "alert", "alert('Student ID should be an Integer.');", true);
                return false;
            }


            return true;
        }

        private bool IsIdValid(int id, string tableName, string columnName, SqlConnection connection)
        {
            SqlCommand command = new SqlCommand($"SELECT COUNT(*) FROM {tableName} WHERE {columnName} = @ID", connection);
            command.Parameters.Add(new SqlParameter("@ID", id));

            connection.Open();
            int count = (int)command.ExecuteScalar();
            connection.Close();

            return count > 0;
        }
    }
}