using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;

namespace WebApplication1
{
    public partial class updateGradPlan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_update_Click(object sender, EventArgs e)
        {
            
                try
                {
                    string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
                    DateTime ExpectedGradDate = graduation_date.SelectedDate;
                    int studentId = Int32.Parse(student_id.Text);


                    SqlConnection conn = new SqlConnection(connStr);

                    SqlCommand AdvisorUpdateGradDate = new SqlCommand("Procedures_AdvisorUpdateGP", conn);
                    AdvisorUpdateGradDate.CommandType = CommandType.StoredProcedure;
                    AdvisorUpdateGradDate.Parameters.Add(new SqlParameter("@studentID", studentId));
                    AdvisorUpdateGradDate.Parameters.Add(new SqlParameter("@expected_grad_date", ExpectedGradDate));


                    conn.Open();
                    int i = AdvisorUpdateGradDate.ExecuteNonQuery();
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


