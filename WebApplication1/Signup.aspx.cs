using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace m3
{
    public partial class Signup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Register_Click(object sender, EventArgs e)
        {

            string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            //Create as new Connection
            SqlConnection conn = new SqlConnection(connStr);

            try
            {

                String fname = box1.Text;
                String lname = box2.Text;
                String pass = box3.Text;
                String fac = box4.Text;
                String mail = box5.Text;
                String maj = box6.Text;
                int sem = Int16.Parse(box7.Text);
                if (fname == "" || lname == "" || pass == "" || fac == "" || mail == "" || maj == "" || sem.ToString() == "")
                {

                    ClientScript.RegisterStartupScript(GetType(), "alert", "alert('Please enter valid info to register');", true);
                    return;

                }

                SqlCommand register = new SqlCommand("Procedures_StudentRegistration", conn);
                register.CommandType = CommandType.StoredProcedure;
                register.Parameters.Add(new SqlParameter("@first_name", fname));
                register.Parameters.Add(new SqlParameter("@last_name", lname));
                register.Parameters.Add(new SqlParameter("@password", pass));
                register.Parameters.Add(new SqlParameter("@faculty", fac));
                register.Parameters.Add(new SqlParameter("@email", mail));
                register.Parameters.Add(new SqlParameter("@major", maj));
                register.Parameters.Add(new SqlParameter("@Semester", sem));

                SqlParameter Student_id = register.Parameters.Add("@Student_id", SqlDbType.Int);
                Student_id.Direction = ParameterDirection.Output;
                conn.Open();
                register.ExecuteNonQuery();
                conn.Close();
                String s = "alert('Your id is:" + Student_id.Value +" ') ";
                ClientScript.RegisterStartupScript(GetType(), "alert", s, true);
              
               
            }
            catch (System.FormatException ex)

            {
                ClientScript.RegisterStartupScript(GetType(), "alert", "alert('Please enter valid info to register');", true);

            }

            catch (OverflowException)
            {

                ClientScript.RegisterStartupScript(GetType(), "alert", "alert('Invalid  ID!');", true);
            }

        }



        protected void Back_Click(object sender, EventArgs e)
        {

            Response.Redirect("Login.aspx");
        }
    }
}
    
