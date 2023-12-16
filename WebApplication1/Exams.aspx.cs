using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace M3
{
    public partial class Exams : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand CME = new SqlCommand("Select * from Courses_MakeupExams", conn);
            SqlDataReader reader = CME.ExecuteReader(CommandBehavior.CloseConnection);
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Exam ID", typeof(int));
            dataTable.Columns.Add("Date", typeof(DateTime));
            dataTable.Columns.Add("Type", typeof(string));
            dataTable.Columns.Add("Course ID", typeof(int));
            dataTable.Columns.Add("Course name", typeof(string));
            dataTable.Columns.Add("Course semester", typeof(int));
            reader.Read();
            do
            {
                DataRow newRow = dataTable.NewRow();
                newRow["Exam ID"] = reader.GetInt32(reader.GetOrdinal("exam_id"));
                newRow["Date"] = reader.GetDateTime(reader.GetOrdinal("date"));
                newRow["Type"] = reader.GetString(reader.GetOrdinal("type"));
                newRow["Course ID"] = reader.GetInt32(reader.GetOrdinal("course_id"));
                newRow["Course name"] = reader.GetString(reader.GetOrdinal("name"));
                newRow["Course Semester"] = reader.GetInt32(reader.GetOrdinal("semester"));
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