using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Diagnostics;
public partial class Admin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void signup1_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        conn.Open();
        string checkuser = "select count(*) from admin where UserName='" + user3.Text + "' AND Password='" + pass3.Text + "'";
        SqlCommand com = new SqlCommand(checkuser, conn);
        int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
        conn.Close();
        if (temp == 1)
        {
            Session["new1"] = user3.Text;
            Response.Redirect("Bunk.aspx");
        }
        else
        {
            string variable = "The username or password is incorrect.";
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + variable + "');", true);
        }
    }
}