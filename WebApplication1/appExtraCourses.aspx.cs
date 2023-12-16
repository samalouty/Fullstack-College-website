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
    public partial class appExtraCourses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_proceed2_click(object sender, EventArgs e)
        {
            try
            {
                string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
                int RequestId = Int32.Parse(request_id.Text);
                String SemCode = (current_semester_code.Text);



                SqlConnection conn = new SqlConnection(connStr);

                SqlCommand AdvisorApproveCourse = new SqlCommand("Procedures_AdvisorApproveRejectCourseRequest", conn);
                AdvisorApproveCourse.CommandType = CommandType.StoredProcedure;
                AdvisorApproveCourse.Parameters.Add(new SqlParameter("@requestID", RequestId));
                AdvisorApproveCourse.Parameters.Add(new SqlParameter("@current_sem_code", SemCode));


                conn.Open();
                int i = AdvisorApproveCourse.ExecuteNonQuery();
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