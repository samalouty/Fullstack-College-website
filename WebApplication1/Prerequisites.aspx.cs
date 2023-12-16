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
    public partial class Prerequisites : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand CP = new SqlCommand("Select * from view_Course_prerequisites", conn);
            SqlDataReader reader = CP.ExecuteReader(CommandBehavior.CloseConnection);
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Course ID", typeof(int));
            dataTable.Columns.Add("Course", typeof(String));
            dataTable.Columns.Add("Major", typeof(String));
            dataTable.Columns.Add("Offered", typeof(Boolean));
            dataTable.Columns.Add("Credit Hours", typeof(int));
            dataTable.Columns.Add("Semester", typeof(String));
            dataTable.Columns.Add("Prerequisite ID", typeof(int));
            dataTable.Columns.Add("Prerequisite Name", typeof(String));
            try
            {
                reader.Read();
                do
                {
                    DataRow newRow = dataTable.NewRow();
                    newRow["Course ID"] = reader.GetInt32(reader.GetOrdinal("course_id"));
                    newRow["Course"] = reader.GetString(reader.GetOrdinal("name"));
                    newRow["Major"] = reader.GetString(reader.GetOrdinal("major"));
                    newRow["Offered"] = reader.GetBoolean(reader.GetOrdinal("is_offered"));
                    newRow["Credit Hours"] = reader.GetInt32(reader.GetOrdinal("credit_hours"));
                    newRow["Semester"] = reader.GetInt32(reader.GetOrdinal("semester"));
                    newRow["Prerequisite ID"] = reader.GetInt32(reader.GetOrdinal("preRequsite_course_id"));
                    newRow["Prerequisite Name"] = reader.GetString(reader.GetOrdinal("preRequsite_course_name"));
                    dataTable.Rows.Add(newRow);
                } while (reader.Read());
            }
            catch (System.InvalidOperationException)
            {
                dataTable.Clear();
            }
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