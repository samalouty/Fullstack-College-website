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
    public partial class MainPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ViewGP(object sender, EventArgs e)
        {
            Response.Redirect("GradPlan.aspx");
        }

        protected void ViewUI(object sender, EventArgs e)
        {
            Response.Redirect("Installements.aspx");
        }

        protected void ViewCSI(object sender, EventArgs e)
        {
            Response.Redirect("CourseSlotInstructor.aspx");
        }

        protected void ViewE(object sender, EventArgs e)
        {
            Response.Redirect("Exams.aspx");
        }

        protected void ViewMR(object sender, EventArgs e)
        {
            Response.Redirect("Makeup.aspx");
        }

        protected void ViewCI(object sender, EventArgs e)
        {
            Response.Redirect("Instructors.aspx");
        }

        protected void ViewCP(object sender, EventArgs e)
        {
            Response.Redirect("Prerequisites.aspx");
        }

        protected void Logout_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Options.aspx");
        }
    }
}