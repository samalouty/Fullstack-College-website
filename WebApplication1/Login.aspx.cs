using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Data;
using System.Web.Management;

namespace m3
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Signin_Click(object sender, EventArgs e)
        {
            try
            {
                
                string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
                //Create as new Connection
                SqlConnection conn = new SqlConnection(connStr);              
                int id = Int16.Parse(username.Text);
                String pass = password.Text;
                if (pass == "")
                {
                    ClientScript.RegisterStartupScript(GetType(), "alert", "alert('Please Add a valid username and password');", true);
                }
                conn.Open();
                SqlCommand loginfn = new SqlCommand("Select dbo.FN_StudentLogin (@Student_id,@password)", conn);
                loginfn.CommandType = CommandType.Text;
                loginfn.Parameters.Add(new SqlParameter("@Student_id", id));
                loginfn.Parameters.Add(new SqlParameter("@password", pass));
                bool success = Convert.ToBoolean(loginfn.ExecuteScalar());
                conn.Close();
                if (success == true)
                {
                    Session["user"] = id;
                    Response.Redirect("Options.aspx");

                }
                else
                {
                    Response.Write("Invalid login");

                }
            }
            catch (System.FormatException ex)
            {
                ClientScript.RegisterStartupScript(GetType(), "alert", "alert('Please Add a valid username and password');", true);
            }

           
        }

        protected void Register_Click(object sender, EventArgs e)
        {
            {

                Response.Redirect("Signup.aspx");

            }
        }

        protected void Back_Click(object sender, EventArgs e)
        {

            Response.Redirect("FrontPage.aspx");
        }

     
       
    }
}