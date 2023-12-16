using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace m3
{
    public partial class Options : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");

        }

        protected void Courses_Click(object sender, EventArgs e)
        {
            Response.Redirect("Courses.aspx");
        }

        protected void Requests_Click(object sender, EventArgs e)
        {
            Response.Redirect("Requests.aspx");
        }

        protected void phone_Click(object sender, EventArgs e)
        {

            Response.Redirect("Phone.aspx");
        }

        protected void Homepage_Click(object sender, EventArgs e)
        {
            Response.Redirect("MainPage.aspx");
        }
    }
}