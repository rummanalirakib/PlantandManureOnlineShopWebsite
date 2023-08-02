using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class Chunk8 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["new"] != null)
        {
           // User4.Text = Session["new"].ToString();
        }
        else
        {
            Session["new"] = null;
            Response.Redirect("Chunk2.aspx");
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Chunk3.aspx");
    }
    protected void Logout_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        conn.Open();
        Session["new"] = null;
        Session.RemoveAll();
        Session.Clear();
        string insertQuery = "DELETE from GiveOrder";
        SqlCommand com = new SqlCommand(insertQuery, conn);
        com.ExecuteNonQuery();
        conn.Close();
        Response.Redirect("Chunk.aspx");
    }
}