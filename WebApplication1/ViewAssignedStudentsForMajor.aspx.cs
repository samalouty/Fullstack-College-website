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
    public partial class ViewAssignedStudentsForMajor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void submit(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            int id = (int)Session["user"];



            SqlCommand cmd = new SqlCommand("Procedures_AdvisorViewAssignedStudents", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@AdvisorID", id));
            cmd.Parameters.Add(new SqlParameter("@major", major.Text));


            conn.Open();

            SqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            GridView gridView = new GridView();
            gridView.AutoGenerateColumns = true;
            gridView.DataSource = rdr;
            gridView.DataBind();

            form1.Controls.Add(gridView);
        }
    }
}