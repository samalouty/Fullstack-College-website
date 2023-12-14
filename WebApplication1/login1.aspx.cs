using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class login1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {

                int adminUserId = 842;
                string adminPassword = "admin";

                int enteredUserId;
                if (int.TryParse(txtUserId.Text.Trim(), out enteredUserId))
                {
                    if (enteredUserId == adminUserId && txtPassword.Text.Trim() == adminPassword)
                    {
                        Response.Redirect("AdminPage.aspx");
                    }
                    else
                    {
                        Response.Write("<script>alert('Invalid credentials. Please try again.');</script>");
                    }
                }
                else
                {
                    Response.Write("<script>alert('Invalid User ID format. Please enter a valid number.');</script>");
                }
            }
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrEmpty(txtUserId.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                ClientScript.RegisterStartupScript(GetType(), "alert", "alert('All fields are required.');", true);
                return false;
            }

            return true;
        }
    }
}