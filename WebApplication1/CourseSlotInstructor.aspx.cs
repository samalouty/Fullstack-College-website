using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;

namespace M3
{
    public partial class CourseSlotInstructor : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand CSI = new SqlCommand("Select * from Courses_Slots_Instructor", conn);
            SqlDataReader reader = CSI.ExecuteReader(CommandBehavior.CloseConnection);
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Course ID", typeof(int));
            dataTable.Columns.Add("Course", typeof(String));
            dataTable.Columns.Add("Slot ID", typeof(String));
            dataTable.Columns.Add("Day", typeof(String));
            dataTable.Columns.Add("Time", typeof(string));
            dataTable.Columns.Add("Location", typeof(String));
            dataTable.Columns.Add("Instructor ID", typeof(int));
            dataTable.Columns.Add("Instructor", typeof(String));
            try { 
            reader.Read();
            do
            {
                DataRow newRow = dataTable.NewRow();
                newRow["Course ID"] = reader.GetInt32(reader.GetOrdinal("CourseID"));
                newRow["Course"] = reader.GetString(reader.GetOrdinal("Course"));
                newRow["Slot ID"] = reader.GetInt32(reader.GetOrdinal("slot_id"));
                newRow["day"] = reader.GetString(reader.GetOrdinal("day"));
                newRow["Time"] = reader.GetString(reader.GetOrdinal("time"));
                newRow["Location"] = reader.GetString(reader.GetOrdinal("location"));
                newRow["Instructor ID"] = reader.GetInt32(reader.GetOrdinal("instructor_id"));
                newRow["Instructor"] = reader.GetString(reader.GetOrdinal("Instructor"));
                dataTable.Rows.Add(newRow);
            } while (reader.Read());
            }
            catch (System.InvalidOperationException) {
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

        protected void Show_Click(object sender, EventArgs e)
        {
            int cid = Int16.Parse(DropDownList1.SelectedValue);
            int Iid = Int16.Parse(DropDownList2.SelectedValue);
            string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand SVS = new SqlCommand("Select * from dbo.FN_StudentViewSlot(@CourseID,@InstructorID)", conn);
            SVS.Parameters.Add(new SqlParameter("@CourseID", cid));
            SVS.Parameters.Add(new SqlParameter("@InstructorID", Iid));
            SqlDataReader reader = SVS.ExecuteReader(CommandBehavior.CloseConnection);
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Course ID", typeof(int));
            dataTable.Columns.Add("Course", typeof(String));
            dataTable.Columns.Add("Slot ID", typeof(String));
            dataTable.Columns.Add("Day", typeof(String));
            dataTable.Columns.Add("Time", typeof(string));
            dataTable.Columns.Add("Location", typeof(String));
            dataTable.Columns.Add("Instructor ID", typeof(int));
            dataTable.Columns.Add("Instructor", typeof(String));
            try
            {
                reader.Read();
                do
                {
                    DataRow newRow = dataTable.NewRow();
                    newRow["Course ID"] = reader.GetInt32(reader.GetOrdinal("CourseID"));
                    newRow["Course"] = reader.GetString(reader.GetOrdinal("Course"));
                    newRow["Slot ID"] = reader.GetInt32(reader.GetOrdinal("slot_id"));
                    newRow["day"] = reader.GetString(reader.GetOrdinal("day"));
                    newRow["Time"] = reader.GetString(reader.GetOrdinal("time"));
                    newRow["Location"] = reader.GetString(reader.GetOrdinal("location"));
                    newRow["Instructor ID"] = reader.GetInt32(reader.GetOrdinal("instructor_id"));
                    newRow["Instructor"] = reader.GetString(reader.GetOrdinal("Instructor"));
                    dataTable.Rows.Add(newRow);
                } while (reader.Read());
            }
            catch (System.InvalidOperationException) {
                dataTable.Clear();
            }
            
            GridView1.DataSource = dataTable;
            GridView1.DataBind();
            conn.Close();
        }
    }
}