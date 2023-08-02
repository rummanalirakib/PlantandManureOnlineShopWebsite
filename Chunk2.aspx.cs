using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class Chunk2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void signup_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        conn.Open();
        string checkuser = "select count(*) from Registration where UserName='" + user1.Text + "' AND Password='" + pass1.Text + "'";
        SqlCommand com = new SqlCommand(checkuser, conn);
        int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
        string checkuser1 = "select count(*) from BlockUser where UserName='" + user1.Text + "'";
        com = new SqlCommand(checkuser1, conn);
        int x = Convert.ToInt32(com.ExecuteScalar().ToString());
        conn.Close();
        if (x == 0)
        {
            if (temp == 1)
            {
                Session["new"] = user1.Text;
                Response.Redirect("Chunk3.aspx");
            }
            else
            {
                string variable = "The username or password is incorrect.";
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + variable + "');", true);
            }
        }
        else
        {
            string variable = "This User Has been Blocked.";
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + variable + "');", true);
        }
    }
}