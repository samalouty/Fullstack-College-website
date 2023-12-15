using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class NewCourse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                String connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
                SqlConnection conn = new SqlConnection(connStr);

                int semNum = Int16.Parse(semester.Text);
                int creditH = Int16.Parse(creditHours.Text);

                SqlCommand newCourse = new SqlCommand("Procedures_AdminAddingCourse", conn);
                newCourse.CommandType = CommandType.StoredProcedure;
                newCourse.Parameters.Add(new SqlParameter("@major",major.Text ));
                newCourse.Parameters.Add(new SqlParameter("@semester", semester.Text));
                newCourse.Parameters.Add(new SqlParameter("@credit_hours", creditH));
                newCourse.Parameters.Add(new SqlParameter("@name", courseName.Text));
                newCourse.Parameters.Add(new SqlParameter("@is_offered", offered.Checked));


                conn.Open();
                newCourse.ExecuteNonQuery();
                conn.Close();
                Response.Write("New Course added");
            }
        }

        private bool ValidateForm()
        {
            int creditHoursTest;
            int semesterTest; 
            if (string.IsNullOrEmpty(major.Text) || string.IsNullOrEmpty(semester.Text) || string.IsNullOrEmpty(creditHours.Text) || string.IsNullOrEmpty(courseName.Text))
            {
                ClientScript.RegisterStartupScript(GetType(), "alert", "alert('All fields are required.');", true);
                return false;
            }

            if (!int.TryParse(semester.Text, out semesterTest))
            {
                ClientScript.RegisterStartupScript(GetType(), "alert", "alert('Semester number must be an integer.');", true);
                return false;
            }

            if (!int.TryParse(creditHours.Text, out creditHoursTest))
            {
                ClientScript.RegisterStartupScript(GetType(), "alert", "alert('Credit Hours must be an integer.');", true);
                return false;
            }

            if (semesterTest<=0 || semesterTest >=11) {
                ClientScript.RegisterStartupScript(GetType(), "alert", "alert('Semester must be between 1 and 10.');", true);
                return false;
            }

            if (creditHoursTest <= 0 || creditHoursTest >= 61)
            {
                ClientScript.RegisterStartupScript(GetType(), "alert", "alert('Credit Hours must be between 1 and 60.');", true);
                return false;
            }


            return true;
        }
    }
}