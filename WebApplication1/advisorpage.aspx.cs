using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace WebApplication1
{
    public partial class advisingStudents : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
            }
        protected void btnViewAdvising_Click(object sender, EventArgs e)
        {
            Response.Redirect("advisingstudents.aspx");
        }
        protected void btnInsertGradPlan_Click(object sender, EventArgs e)
        {
            Response.Redirect("insertGraduationPlan.aspx");
        }
        protected void btnInsertCourse_Click(object sender, EventArgs e)
        {
            Response.Redirect("insertCourses.aspx");
        }
        protected void btnUpdateGradPlan_Click(object sender, EventArgs e)
        {
            Response.Redirect("updateGradPlan.aspx");
        }
        protected void btnDeleteCourse_Click(object sender, EventArgs e)
        {
            Response.Redirect("deleteCourse.aspx");
        }
        protected void btnViewAssigned_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewAssignedStudentsForMajor.aspx");
        }
        protected void btnViewRequests_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewAdvisorRequests.aspx");
        }
        protected void btnViewPending_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewAdvisorPendingRequests.aspx");
        }
        protected void btnAppExtraCredit_Click(object sender, EventArgs e)
        {
            Response.Redirect("appExtraCreditHours.aspx");
        }
        protected void btnAppExtraCourses_Click(object sender, EventArgs e)
        {
            Response.Redirect("appExtraCourses.aspx");
        }
    }

    }
