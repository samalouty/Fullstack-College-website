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
    public partial class insertGraduationPlan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_insertGradPlan_Click(object sender, EventArgs e)
        {

            try
            {
                string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
                String SemCode = (Semester_Code.Text);
                DateTime ExpectedGradDate = Calendar1.SelectedDate;
                int CreditHours = Int32.Parse(Credit_Hours.Text);
                int AdvisorId = Int32.Parse(Advisor_ID.Text);
                int StudentId = Int32.Parse(Student_ID.Text);

                SqlConnection conn = new SqlConnection(connStr);

                SqlCommand AdvisorCreateGP = new SqlCommand("Procedures_AdvisorCreateGP", conn);
                AdvisorCreateGP.CommandType = CommandType.StoredProcedure;
                AdvisorCreateGP.Parameters.Add(new SqlParameter("@Semester_code", SemCode));
                AdvisorCreateGP.Parameters.Add(new SqlParameter("@expected_graduation_date", ExpectedGradDate));
                AdvisorCreateGP.Parameters.Add(new SqlParameter("@sem_credit_hours", CreditHours));
                AdvisorCreateGP.Parameters.Add(new SqlParameter("@advisor_id", AdvisorId));
                AdvisorCreateGP.Parameters.Add(new SqlParameter("@student_id", StudentId));
                conn.Open();
                int i = AdvisorCreateGP.ExecuteNonQuery();
                conn.Close();
                if (i > 0) { Response.Write("successful"); }
                else { Response.Write("Unsuccessful"); }
            }
          
           catch (FormatException ex) { 
                Response.Write("Input is invalid, Try again!"); 
            }


        }
    }
}