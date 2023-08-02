using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
public partial class Bunk6 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void DataCheckCalculation(object source, DataListCommandEventArgs e)
    {
        if (e.CommandName == "UnBlockUser")
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            conn.Open();
            string str = e.CommandArgument.ToString();
            int p = Convert.ToInt32(str);
            string query = "Delete from BlockUser where BlockId='" + p + "'";
            SqlCommand com = new SqlCommand(query, conn);
            com.ExecuteNonQuery();
            conn.Close();
            Response.Redirect("Bunk6.aspx");
        }
    }
}