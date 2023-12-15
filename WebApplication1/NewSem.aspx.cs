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
    public partial class NewSem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {

                try
                {
                    String connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
                    SqlConnection conn = new SqlConnection(connStr);

                    String start_date = startDate.Text;
                    String end_date = endDate.Text;
                    String semester_code = semesterCode.Text;

                    SqlCommand newSem = new SqlCommand("AdminAddingSemester", conn);
                    newSem.CommandType = CommandType.StoredProcedure;
                    newSem.Parameters.Add(new SqlParameter("@start_date", start_date));
                    newSem.Parameters.Add(new SqlParameter("@end_date", end_date));
                    newSem.Parameters.Add(new SqlParameter("@semester_code", semester_code));

                    if(DateTime.Parse(end_date) < DateTime.Parse(start_date))
                    {
                        ClientScript.RegisterStartupScript(GetType(), "alert", "alert('Start date must be before the end date');", true);
                        return; 
                    }


                    conn.Open();
                    newSem.ExecuteNonQuery();
                    conn.Close();
                    Response.Write("New Semester added");
                }
                catch (Exception ex)
                {
                    ClientScript.RegisterStartupScript(GetType(), "alert", "alert('Can not enter duplicate record, make sure that the Semester Code is correct.');", true);

                }
            }
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrEmpty(startDate.Text) || string.IsNullOrEmpty(endDate.Text) || string.IsNullOrEmpty(semesterCode.Text))
            {
                ClientScript.RegisterStartupScript(GetType(), "alert", "alert('All fields are required.');", true);
                return false;
            }
            if (semesterCode.Text[0] != 'W' && semesterCode.Text[0] != 'S' || semesterCode.Text.Length >6)
            {
                ClientScript.RegisterStartupScript(GetType(), "alert", "alert('Enter a valid semester Code');", true);
                return false;
            }

            return true;
        }
    }
}