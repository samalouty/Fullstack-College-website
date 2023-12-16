using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace M3
{
    public partial class GradPlan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = (int)Session["user"];
            string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand GP = new SqlCommand("Select * from dbo.FN_StudentViewGP(@student_ID)", conn);
            GP.Parameters.Add(new SqlParameter("@student_ID", id));
            SqlDataReader reader = GP.ExecuteReader(CommandBehavior.CloseConnection);
            reader.Read();
            String name=reader.GetString(reader.GetOrdinal("Student_name"));
            nLabel.Text=name;
            int Planid = reader.GetInt32(reader.GetOrdinal("plan_id"));
            piLabel.Text = Planid+"";
            String semcode = reader.GetString(reader.GetOrdinal("semester_code"));
            scLabel.Text = semcode;
            int semch = reader.GetInt32(reader.GetOrdinal("semester_credit_hours"));
            schLabel.Text = semch+"";
            DateTime graddate = reader.GetDateTime(reader.GetOrdinal("expected_grad_date"));
            egdLabel.Text = graddate+"";
            int advisor = reader.GetInt32(reader.GetOrdinal("advisor_id"));
            aidLabel.Text = advisor+"";
            int student = reader.GetInt32(reader.GetOrdinal("student_id"));
            sidLabel.Text = student+"";
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("Name", typeof(string));

            do
            {
                DataRow newRow = dataTable.NewRow();
                newRow["ID"] = reader.GetInt32(reader.GetOrdinal("course_id"));
                newRow["Name"] = reader.GetString(reader.GetOrdinal("name"));
                dataTable.Rows.Add(newRow);
            } while (reader.Read());
            GridView1.DataSource = dataTable;
            GridView1.DataBind();
            conn.Close();
        }

        protected void Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("MainPage.aspx");
        }
    }
}