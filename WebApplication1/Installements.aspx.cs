using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace M3
{
    public partial class Installements : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = (int)Session["user"];
            string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand insdeadline = new SqlCommand("Select dbo.FN_StudentUpcoming_installment(@student_ID)", conn);
            insdeadline.CommandType = CommandType.Text;
            insdeadline.Parameters.Add(new SqlParameter("@student_ID", id));
            deadline.Text= insdeadline.ExecuteScalar().ToString();
            if (deadline.Text == "")
            {
                text.Text = "No upcoming installement";
            }
            conn.Close();

        }

        protected void Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("MainPage.aspx");
        }
    }
}