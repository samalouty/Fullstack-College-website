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
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void login2(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);
            int id=Int16.Parse(username.Text);
            String pass = password.Text;
            SqlCommand loginproc = new SqlCommand("Select dbo.[FN_AdvisorLogin](@advisor_id,@password)", conn);
            loginproc.CommandType= CommandType.Text;
            conn.Open();
            loginproc.Parameters.Add(new SqlParameter("@advisor_Id", id));
            loginproc.Parameters.Add(new SqlParameter("@password", pass));
            bool success = Convert.ToBoolean(loginproc.ExecuteScalar());
            conn.Close();
           
           

           
            if(success==true)
            {
                Session["user"] = id;
                Response.Write("Hello");
                Response.Redirect("advisorpage.aspx");
            }
            else
            {
                Response.Write("Invalid Login");
            }
        }
        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("advisorRegister.aspx");
        }
    }
}