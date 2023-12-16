using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class advisorRegister : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Register(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            String name=(Advisor_Name.Text);
            String Password = Advisor_Password.Text;
            String Email = Advisor_Email.Text;
            String Office = Advisor_Office.Text;

            SqlConnection conn= new SqlConnection(connStr);

            SqlCommand AdvisorRegistration = new SqlCommand("Procedures_AdvisorRegistration", conn);
                    AdvisorRegistration.CommandType = CommandType.StoredProcedure;
                AdvisorRegistration.Parameters.Add(new SqlParameter("@advisor_name", name));
                    AdvisorRegistration.Parameters.Add(new SqlParameter("@Password", Password));
                    AdvisorRegistration.Parameters.Add(new SqlParameter("@Email",Email));
                    AdvisorRegistration.Parameters.Add(new SqlParameter("@Office",Office));
                    SqlParameter ID = AdvisorRegistration.Parameters.Add("@Advisor_id",SqlDbType.Int);
                ID.Direction = ParameterDirection.Output;
                conn.Open();
            AdvisorRegistration.ExecuteNonQuery();
            conn.Close();
           int advisorID=(int)ID.Value;    
            if (advisorID>0)
            {
                Response.Write("Your Advisor ID is "+ advisorID);

            }
            else
            {
                Response.Write("Advisor Registration Failed.Try Again");
            }




        }
    }
}