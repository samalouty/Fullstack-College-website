using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace M3
{
    public partial class Instructors : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Confirm_Click(object sender, EventArgs e)
        {
            int sid = (int)Session["user"];
            string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            try
            {
                int Iid = Int32.Parse(insid.Text);
                int cid = Int32.Parse(courseid.Text);
                string scode = semcode.Text;
                conn.Open();
                SqlCommand choose = new SqlCommand("Procedures_ChooseInstructor", conn);
                choose.CommandType = CommandType.StoredProcedure;
                choose.Parameters.Add(new SqlParameter("@StudentID", sid));
                choose.Parameters.Add(new SqlParameter("@instrucorID", Iid));
                choose.Parameters.Add(new SqlParameter("@CourseID", cid));
                choose.Parameters.Add(new SqlParameter("@current_semester_code", scode));
                int flag = choose.ExecuteNonQuery();
                if(flag == 0)
                {
                    Message.Text = "You are not taking this course in the current semester.";
                }
                else {
                    Message.Text = "Change successful.";
                        }
                conn.Close();
            }
            catch (System.FormatException)
            {
                Message.Text = "Please enter valid information.";
            }
            catch (SqlException)
            {
                Message.Text = "Non-existing Instructor, Please re-enter the instructor ID.";
            }
        }

        protected void Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("MainPage.aspx");
        }
    }
}