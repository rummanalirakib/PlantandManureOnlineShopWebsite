using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
public partial class Bunk7 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void b1_Click(object sender, EventArgs e)
    {
        try
        {
            if (t1.Text != "" && t2.Text != "" && t3.Text != "")
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                conn.Open();
                string checkuser = "select count(*) from admin where UserName='" + t1.Text + "'";
                SqlCommand com = new SqlCommand(checkuser, conn);
                int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
                if (t2.Text == t3.Text)
                {
                    string insertQuery = "insert into admin(UserName,Password) values(@UN,@P)";
                    com = new SqlCommand(insertQuery, conn);
                    com.Parameters.AddWithValue("@UN", t1.Text);
                    com.Parameters.AddWithValue("@P", t2.Text);
                    com.ExecuteNonQuery();
                    string variable5 = "A new admin has been added.";
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + variable5 + "');", true);
                }
                else
                {
                    string variable5 = "Both Passwords are not same.";
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + variable5 + "');", true);
                }
            }
            else
            {
                string variable5 = "You can not keep any field empty";
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + variable5 + "');", true);
            }
        }
        catch (Exception ex)
        {

        }
    }
}