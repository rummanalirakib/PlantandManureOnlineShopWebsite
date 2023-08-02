using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class Chunk6 : System.Web.UI.Page
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
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            conn.Open();
            string str = Session["new"].ToString();
            string insertQuery = "insert into Review(UserName,ReviewText,LikeButton) values(@UN,@RT,@LB)";
            SqlCommand com = new SqlCommand(insertQuery, conn);
            com.Parameters.AddWithValue("@UN", str);
            com.Parameters.AddWithValue("@RT", CommentBox.Text);
            com.Parameters.AddWithValue("@LB", 0);
            com.ExecuteNonQuery();
            conn.Close();
            Response.Redirect("Chunk6.aspx");
        }
        catch (Exception ex)
        {

        }
    }
    protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
    {
        if (e.CommandName == "LikePress")
        {
            try
            {
                string str = e.CommandArgument.ToString();
                int p = Convert.ToInt32(str);
                string str1 = Session["new"].ToString();
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                conn.Open();
                String query = "select count(*) from LikeHisab where Id='" + p + "' AND UserName='" + str1 + "'";
                SqlCommand com = new SqlCommand(query, conn);
                int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
                if (temp == 0)
                {
                    String query1 = "insert into LikeHisab(Id,UserName) values(@I,@UN)";
                    com = new SqlCommand(query1, conn);
                    com.Parameters.AddWithValue("@I", p);
                    com.Parameters.AddWithValue("@UN", str1);
                    com.ExecuteNonQuery();
                    String query2 = "Select LikeButton from Review where Id='" + p + "'";
                    com = new SqlCommand(query2, conn);
                    int temp1 = Convert.ToInt32(com.ExecuteScalar().ToString());
                    temp1 = temp1 + 1;
                    string query3 = "update Review set LikeButton=@LB where Id=@I";
                    com = new SqlCommand(query3, conn);
                    com.Parameters.Add("LB", temp1);
                    com.Parameters.Add("I", p);
                    com.ExecuteNonQuery();
                }
                else
                {
                    string delete = "Delete from LikeHisab where Id='" + p + "' AND UserName='" + str1 + "'";
                    com = new SqlCommand(delete, conn);
                    com.ExecuteNonQuery();
                    String query2 = "Select LikeButton from Review where Id='" + p + "'";
                    com = new SqlCommand(query2, conn);
                    int temp1 = Convert.ToInt32(com.ExecuteScalar().ToString());
                    temp1 = temp1 - 1;
                    string query3 = "update Review set LikeButton=@LB where Id=@I";
                    com = new SqlCommand(query3, conn);
                    com.Parameters.Add("LB", temp1);
                    com.Parameters.Add("I", p);
                    com.ExecuteNonQuery();
                }
                conn.Close();
                Response.Redirect("Chunk6.aspx");
            }
            catch (Exception ex)
            {

            }
        }
        if (e.CommandName == "DeleteComment")
        {
            try
            {
                string str = e.CommandArgument.ToString();
                int p = Convert.ToInt32(str);
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                conn.Open();
                string str2 = Session["new"].ToString();
                String query = "Select count(*) from Review where Id='" + p + "' AND UserName='" + str2 + "'";
                SqlCommand com = new SqlCommand(query, conn);
                int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
                if (temp == 1)
                {
                    string delete = "Delete from Review where Id='" + p + "'";
                    com = new SqlCommand(delete, conn);
                    com.ExecuteNonQuery();
                }
                else
                {
                    string variable3 = "This is not your id.So you don't have the permission to delete this comment.";
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + variable3 + "');", true);
                }
                conn.Close();
                Response.Redirect("Chunk6.aspx");
            }
            catch (Exception ex)
            {

            }
        }
    }
}