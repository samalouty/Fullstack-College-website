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
    public partial class Phone : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void click_Click(object sender, EventArgs e)
        {
            try
            {

                string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
                //Create as new Connection
                SqlConnection conn = new SqlConnection(connStr);
                int id = (int)Session["user"];
                String num = phonenumber.Text;

                if (num == "")
                {

                    ClientScript.RegisterStartupScript(GetType(), "alert", "alert('input cannot be empty ');", true);

                    return;
                }
                SqlCommand Addnumber = new SqlCommand("Procedures_StudentaddMobile", conn);
                Addnumber.CommandType = CommandType.StoredProcedure;
                Addnumber.Parameters.Add(new SqlParameter("@StudentID", id));
                Addnumber.Parameters.Add(new SqlParameter("@mobile_number ", num));

                phonenumber.Text = String.Empty;
                conn.Open();
                Addnumber.ExecuteNonQuery();
                Response.Write("Phone added successfully!");
                conn.Close();
            }

            catch(System.Data.SqlClient.SqlException ex)
            {

                ClientScript.RegisterStartupScript(GetType(), "alert", "alert('You cannot enter a phone number twice,try again ');", true);

            }
          
        }

        protected void Back_Click(object sender, EventArgs e)
        {

            Response.Redirect("Options.aspx");
        }
    }
}