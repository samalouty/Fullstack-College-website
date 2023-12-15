using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Linq.Expressions;

namespace WebApplication1
{
    public partial class AddMakeup_Exam : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnAddMakeup_Click(object sender, EventArgs e)
        {
            try {

                String connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
                //create a new connection
                SqlConnection conn = new SqlConnection(connStr);
                String Type = type.Text;
                DateTime Date = DateTime.Parse(date.Text);
                int CourseID = Int16.Parse(courseID.Text);

                SqlCommand AddMakeup = new SqlCommand("[Procedures_AdminAddExam]", conn);
                AddMakeup.CommandType = CommandType.StoredProcedure;
                AddMakeup.Parameters.Add(new SqlParameter("@Type", Type));
                AddMakeup.Parameters.Add(new SqlParameter("@Date", Date));
                AddMakeup.Parameters.Add(new SqlParameter("@CourseID", CourseID));

                conn.Open();
                AddMakeup.ExecuteNonQuery();
                conn.Close();
                Response.Write("Makeup exam added.");
            }
            catch (System.FormatException ex)
            {
                ClientScript.RegisterStartupScript(GetType(), "alert", "alert('Please enter a valid input.');", true);
            }
            catch (System.OverflowException ex)
            {
                ClientScript.RegisterStartupScript(GetType(), "alert", "alert('input too big.');", true);

            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                ClientScript.RegisterStartupScript(GetType(), "alert", "alert('Course ID does not exist.');", true);
            }

        }
       
     
    }
}