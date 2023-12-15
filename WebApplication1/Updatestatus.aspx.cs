using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.Win32.SafeHandles;

namespace WebApplication1
{
    public partial class Updatestatus : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            try {
                String connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();

                SqlConnection conn = new SqlConnection(connStr);
                int id = Int16.Parse(StudentID.Text);

                SqlCommand Slot_Delete = new SqlCommand("[Procedure_AdminUpdateStudentStatus]", conn);
                Slot_Delete.CommandType = CommandType.StoredProcedure;
                Slot_Delete.Parameters.Add(new SqlParameter("@student_id", id));


                if (!IsIdValid(id, "Student", "student_id", conn))
                {

                    ClientScript.RegisterStartupScript(GetType(), "alert", "alert('Non-existing Student ID. Please enter a valid Student ID.');", true);
                    return;
                }
                    conn.Open();  
                Slot_Delete.ExecuteNonQuery();
                conn.Close();
                Response.Write("Status updated.");
            }
            catch(System.FormatException ex)
            {
                ClientScript.RegisterStartupScript(GetType(), "alert", "alert('Incorrect input.');", true);

            }
            catch(System.OverflowException ex)
            {
                ClientScript.RegisterStartupScript(GetType(), "alert", "alert('input too large.');", true);

            }
        
            }
        
        public bool IsIdValid(int id, string tableName, string columnName, SqlConnection connection)
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