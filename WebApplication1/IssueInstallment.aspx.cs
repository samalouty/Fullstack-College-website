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
    public partial class IssueInstallment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_IssueInstallment_Click(object sender, EventArgs e)
        {
            try
            {
                String connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
                //create a new connection
                SqlConnection conn = new SqlConnection(connStr);
                int PaymentID = Int16.Parse(payID.Text);

                SqlCommand IssueInstall = new SqlCommand("[Procedures_AdminIssueInstallment]", conn);
                IssueInstall.CommandType = CommandType.StoredProcedure;
                IssueInstall.Parameters.Add(new SqlParameter("@payment_id", PaymentID));


                conn.Open();
                IssueInstall.ExecuteNonQuery();
                conn.Close();
                Response.Write("Installment issued.");
            }
            catch (System.OverflowException ex) {
                ClientScript.RegisterStartupScript(GetType(), "alert", "alert('Invalid input!');", true);

            }
            catch(System.Data.SqlClient.SqlException ex)
            {
                ClientScript.RegisterStartupScript(GetType(), "alert", "alert('Cannot issue installment with this ID.');", true);

            }
        }
    }
}