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
    public partial class StudToAdv : System.Web.UI.Page
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

                    int studID = int.Parse(studentId.Text);
                    int advID = int.Parse(advisorId.Text);



                    SqlCommand studAdvLink = new SqlCommand("Procedures_AdminLinkStudentToAdvisor", conn);
                    studAdvLink.CommandType = CommandType.StoredProcedure;
                    studAdvLink.Parameters.Add(new SqlParameter("@studentID", studID));
                    studAdvLink.Parameters.Add(new SqlParameter("@advisorID", advID));



                    conn.Open();
                    int succ = studAdvLink.ExecuteNonQuery();
                    conn.Close();

                    if (succ == 0)
                    {
                        ClientScript.RegisterStartupScript(GetType(), "alert", "alert('Non-existing Student entered please re-enter Student ID.');", true);
                        return; 
                    }
                    conn.Close();

                    Response.Write("Linked Student With Advisor");
                }
                catch (SqlException ex)
                {
                    ClientScript.RegisterStartupScript(GetType(), "alert", "alert('Non-existing Advisor entered please re-enter Advisor ID.');", true);
                }

            }
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrEmpty(studentId.Text) || string.IsNullOrEmpty(advisorId.Text))
            {
                ClientScript.RegisterStartupScript(GetType(), "alert", "alert('All fields are required.');", true);
                return false;
            }

            int studentIdValue, advisorIdValue;

            if (!int.TryParse(studentId.Text, out studentIdValue))
            {
                ClientScript.RegisterStartupScript(GetType(), "alert", "alert('Student ID should be an Integer.');", true);
                return false;
            }

            if (!int.TryParse(advisorId.Text, out advisorIdValue))
            {
                ClientScript.RegisterStartupScript(GetType(), "alert", "alert('Advisor ID should be an Integer.');", true);
                return false;
            }


            return true;
        }
    }
}