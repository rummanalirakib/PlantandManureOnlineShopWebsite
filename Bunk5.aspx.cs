using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
public partial class Bunk5 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
    {
        if (e.CommandName == "DeleteUser")
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                conn.Open();
                string str = e.CommandArgument.ToString();
                int p = Convert.ToInt32(str);
                string query = "Delete from Registration where Id='" + p + "'";
                SqlCommand com = new SqlCommand(query, conn);
                com.ExecuteNonQuery();
                conn.Close();
                Response.Redirect("Bunk5.aspx");
            }
            catch (Exception ex)
            {

            }
        }
        if (e.CommandName == "BlockUser")
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                conn.Open();
                string str = e.CommandArgument.ToString();
                int p = Convert.ToInt32(str);
                string query = "select UserName from Registration where Id='" + p + "'";
                SqlCommand com = new SqlCommand(query, conn);
                string username = com.ExecuteScalar().ToString();
                string query1 = "select Phone from Registration where Id='" + p + "'";
                com = new SqlCommand(query1, conn);
                string phone = com.ExecuteScalar().ToString();
                string query2 = "select count(BlockId) from BlockUser where PhoneNumber='" + phone + "'";
                com = new SqlCommand(query2, conn);
                int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
                if (temp == 0)
                {
                    string insertQuery = "insert into BlockUser(UserName,PhoneNumber) values(@UN,@PN)";
                    com = new SqlCommand(insertQuery, conn);
                    com.Parameters.AddWithValue("@UN", username);
                    com.Parameters.AddWithValue("@PN", phone);
                    com.ExecuteNonQuery();
                    string variable1 = "This user Hasbeen Blocked.";
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + variable1 + "');", true);
                    Response.Redirect("Bunk5.aspx");
                }
                else
                {
                    string variable1 = "This user is already in BlockList.";
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + variable1 + "');", true);
                }
                conn.Close();
            }
            catch (Exception ex)
            {

            }
        }
    }
}