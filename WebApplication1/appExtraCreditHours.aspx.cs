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
    public partial class appExtraCreditHours : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_accept_Click(object sender, EventArgs e)
        {
            try
            {
                string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
                int RequestId = Int32.Parse(request_id.Text);
                String SemCode = (current_sem_code.Text);
               


                SqlConnection conn = new SqlConnection(connStr);

                SqlCommand AdvisorApproveCredit = new SqlCommand("Procedures_AdvisorApproveRejectCHRequest", conn);
                AdvisorApproveCredit.CommandType = CommandType.StoredProcedure;
                AdvisorApproveCredit.Parameters.Add(new SqlParameter("@requestID", RequestId));
                AdvisorApproveCredit.Parameters.Add(new SqlParameter("@current_sem_code", SemCode));


                conn.Open();
                int i = AdvisorApproveCredit.ExecuteNonQuery();
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