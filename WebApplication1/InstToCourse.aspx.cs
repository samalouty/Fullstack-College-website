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
    public partial class InstToCourse : System.Web.UI.Page
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

                int courseid = Int16.Parse(courseId.Text);
                int instID = Int16.Parse(instructorId.Text);
                int slotid = Int16.Parse(slotId.Text);


                SqlCommand instLink = new SqlCommand("Procedures_AdminLinkInstructor", conn);
                instLink.CommandType = CommandType.StoredProcedure;
                instLink.Parameters.Add(new SqlParameter("@cours_id", courseid));
                instLink.Parameters.Add(new SqlParameter("@instructor_id", instID));
                instLink.Parameters.Add(new SqlParameter("@slot_id", slotid));
                


                conn.Open();
                instLink.ExecuteNonQuery();
                conn.Close();
                Response.Write("Linked Instructor and Course to the Slot");
            }
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrEmpty(courseId.Text) || string.IsNullOrEmpty(instructorId.Text) || string.IsNullOrEmpty(slotId.Text))
            {
                ClientScript.RegisterStartupScript(GetType(), "alert", "alert('All fields are required.');", true);
                return false;
            }

            int courseIdValue, instructorIdValue, slotIdValue;

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

            if (!int.TryParse(slotId.Text, out slotIdValue))
            {
                ClientScript.RegisterStartupScript(GetType(), "alert", "alert('Slot ID should be an Integer.');", true);
                return false;
            }


            return true;
        }
    }
}