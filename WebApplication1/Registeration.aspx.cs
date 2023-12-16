using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace m3
{
    public partial class Registeration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void Student_Click(object sender, EventArgs e)
        {

            Response.Redirect("Login.aspx");

        }

        protected void Admin_Click(object sender, EventArgs e)
        {
            Response.Redirect("login1.aspx");
        }

        protected void Advisor_Click(object sender, EventArgs e)
        {
            Response.Redirect("Advisor.aspx");
        }
    }



}