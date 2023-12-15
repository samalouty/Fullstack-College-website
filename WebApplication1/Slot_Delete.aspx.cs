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
    public partial class Slot_Delete : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnDeleteSlot(object sender, EventArgs e)
        {
            try
            {
                String connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
                //create a new connection
                SqlConnection conn = new SqlConnection(connStr);
                String id = SemID.Text;

                SqlCommand Slot_Delete = new SqlCommand("[Procedures_AdminDeleteSlots]", conn);
                Slot_Delete.CommandType = CommandType.StoredProcedure;
                Slot_Delete.Parameters.Add(new SqlParameter("@current_semester", id));
                if (string.IsNullOrEmpty(id))
                {
                    ClientScript.RegisterStartupScript(GetType(), "alert", "alert('Please enter an input.');", true);
                    return;
                }
                conn.Open();
                int x = Slot_Delete.ExecuteNonQuery();
                if (x <= 0)
                {
                    ClientScript.RegisterStartupScript(GetType(), "alert", "alert('Non-existing semester ID.');", true);
                    conn.Close();
                    return;
                }
                conn.Close();
                Response.Write("Slot deleted.");
            }
            catch (System.FormatException ex)
            {
                ClientScript.RegisterStartupScript(GetType(), "alert", "alert('Please enter a valid input.');", true);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                ClientScript.RegisterStartupScript(GetType(), "alert", "alert('Cannot delete this Slot.');", true);

            }
           
        }
    }
}