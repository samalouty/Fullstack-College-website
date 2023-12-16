using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class advisingstudents : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);
            int id = (int)Session["user"];
            String s = "SELECT * from Student where advisor_id=" + id;

            SqlCommand advising = new SqlCommand(s, conn);

            conn.Open();
            SqlDataReader rdr = advising.ExecuteReader(CommandBehavior.CloseConnection);


            GridView gridView = new GridView();
            gridView.AutoGenerateColumns = true;
            gridView.DataSource = rdr;
            gridView.DataBind();

            form1.Controls.Add(gridView);
        }
    }
}