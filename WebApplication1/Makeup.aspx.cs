using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Cryptography;

namespace M3
{
    public partial class Makeup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("MainPage.aspx");
        }

        protected void Confirm_Click(object sender, EventArgs e)
        {
            int sid = (int)Session["user"];
            string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            try
            {
                string type = RadioButtonList1.SelectedValue.ToString();
                int cid = Int32.Parse(courseid.Text);
                string scode = semcode.Text;
                conn.Open();
                if (type.Equals("First Makeup")){
                    SqlCommand reg = new SqlCommand("Procedures_StudentRegisterFirstMakeup", conn);
                    reg.CommandType = CommandType.StoredProcedure;
                    reg.Parameters.Add(new SqlParameter("@StudentID", sid));
                    reg.Parameters.Add(new SqlParameter("@courseID", cid));
                    reg.Parameters.Add(new SqlParameter("@studentCurr_sem", scode));
                    int flag = reg.ExecuteNonQuery();
                    if (flag == 2)
                    {
                        Message.Text = "Change successful";
                    }
                    else
                    {
                        Message.Text = "You are not eligible to take 1st makeup for this course";
                    }
                }
                else if (type.Equals("Second Makeup"))
                {
                    SqlCommand reg = new SqlCommand("Procedures_StudentRegisterSecondMakeup", conn);
                    reg.CommandType = CommandType.StoredProcedure;
                    reg.Parameters.Add(new SqlParameter("@StudentID", sid));
                    reg.Parameters.Add(new SqlParameter("@courseID", cid));
                    reg.Parameters.Add(new SqlParameter("@studentCurr_sem", scode));
                    int flag = reg.ExecuteNonQuery();
                    if (flag == 2)
                    {
                        Message.Text = "Change successful";
                    }
                    else
                    {
                        Message.Text = "You are not eligible to take 2nd makeup for this course";
                    }
                }
                else { Message.Text = "Please select exam type"; }
                conn.Close();
            }
            catch (System.FormatException)
            {
                Message.Text = "Please enter valid information";
            }
            catch (System.Data.SqlClient.SqlException)
            {
                Message.Text = "You are already registered";
            }
        }
    }
}