using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class Chunk7 : System.Web.UI.Page
{
    int finalPrice = 0;
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
        try
        {

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            conn.Open();
            string str1 = "Select count(*) from GiveOrder";
            SqlCommand com = new SqlCommand(str1, conn);
            int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
            string str2 = "select sum(ProductPrice) from GiveOrder";
            com = new SqlCommand(str2, conn);
            finalPrice = Convert.ToInt32(com.ExecuteScalar().ToString());
            conn.Close();
            //   Button1.Enabled = false;
            if (temp == 0)
            {
                Response.Redirect("ShowProduct.aspx");
            }
            if (temp > 0)
            {
                Button1.Enabled = true;
                addtocartinfo.Text = "The    Total    Price     is: " + finalPrice;
            }
        }
        catch (Exception ex)
        {

        }
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        conn.Open();
        string query1 = "select ProductId,ProductType,ProductQuantity from GiveOrder";
        SqlCommand com = new SqlCommand(query1, conn);
        SqlDataReader rdr = com.ExecuteReader();
        string str = "";
        int x = 0;
        while (rdr.Read())
        {
            if (x > 0) str += "/";
            try
            {
                str += rdr.GetValue(0).ToString();
                str += "/";
                str += rdr.GetValue(1).ToString();
                str += "/";
                str += rdr.GetValue(2).ToString();
            }
            catch (Exception ex)
            {

            }
            x++;
        }
        conn.Close();
        conn.Open();
        string insertQuery = "insert into OrderPlaced(UserName,ProductPrice,OrderConfirmation,ProductInformation) values(@UN,@PP,@OC,@PI)";
        com = new SqlCommand(insertQuery, conn);
        com.Parameters.AddWithValue("@UN", Session["new"].ToString());
        com.Parameters.AddWithValue("@PP", finalPrice);
        com.Parameters.AddWithValue("@OC", "Not Delivered");
        com.Parameters.AddWithValue("@PI", str);
        com.ExecuteNonQuery();
        string query2 = "delete from GiveOrder";
        com = new SqlCommand(query2, conn);
        com.ExecuteNonQuery();
        conn.Close();
        string variable1 = "Your Order Has Been Placed.";
        ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + variable1 + "');", true);
        Response.Redirect("Chunk3.aspx");
    }
    protected void DataList1_ItemCommand1(object source, DataListCommandEventArgs e)
    {
        if (e.CommandName == "DeleteCart")
        {
            try
            {
                string str = e.CommandArgument.ToString();
                int p = Convert.ToInt32(str);
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                conn.Open();
                string str1 = "Select ProductId from GiveOrder where Id='" + p + "'";
                SqlCommand com = new SqlCommand(str1, conn);
                int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
                string str2 = "Select ProductType from GiveOrder where Id='" + p + "'";
                com = new SqlCommand(str2, conn);
                int temp1 = Convert.ToInt32(com.ExecuteScalar().ToString());
                string str3 = "Select ProductQuantity from GiveOrder where Id='" + p + "'";
                com = new SqlCommand(str3, conn);
                int temp2 = Convert.ToInt32(com.ExecuteScalar().ToString());
                string str4 = "Select ProductPrice from GiveOrder where Id='" + p + "'";
                com = new SqlCommand(str4, conn);
                int temp3 = Convert.ToInt32(com.ExecuteScalar().ToString());
                if (temp2 > 0)
                {
                    int temp4 = temp3 / temp2;
                    temp2 -= 1;
                    temp3 -= temp4;
                }
                string update = "update GiveOrder set ProductQuantity=@PQ,ProductPrice=@PP where Id=@I";
                com = new SqlCommand(update, conn);
                com.Parameters.Add("PQ", temp2);
                com.Parameters.Add("PP", temp3);
                com.Parameters.Add("I", p);
                com.ExecuteNonQuery();
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + temp1 + "');", true);
                if (temp2 == 0)
                {
                    string delete = "Delete from GiveOrder where Id='" + p + "'";
                    com = new SqlCommand(delete, conn);
                    com.ExecuteNonQuery();
                }
                if (temp1 == 0)
                {
                    string str5 = "Select ProductQuantity from product where ProductId='" + temp + "'";
                    com = new SqlCommand(str5, conn);
                    int temp5 = Convert.ToInt32(com.ExecuteScalar().ToString());
                    temp5 = temp5 + 1;
                    string update1 = "update product set ProductQuantity=@PQ where ProductId=@PI";
                    com = new SqlCommand(update1, conn);
                    com.Parameters.Add("PQ", temp5);
                    com.Parameters.Add("PI", temp);
                    com.ExecuteNonQuery();
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + temp5 + "');", true);
                }
                else if (temp1 == 1)
                {
                    string str5 = "Select ProductQuantity from product1 where ProductId='" + temp + "'";
                    com = new SqlCommand(str5, conn);
                    int temp5 = Convert.ToInt32(com.ExecuteScalar().ToString());
                    string update1 = "update product1 set ProductQuantity=@PQ where ProductId=@PI";
                    com = new SqlCommand(update1, conn);
                    temp5 += 1;
                    com.Parameters.Add("PQ", temp5);
                    com.Parameters.Add("PI", temp);
                    com.ExecuteNonQuery();
                }
                else if (temp1 == 2)
                {
                    string str5 = "Select ProductQuantity from product2 where ProductId='" + temp + "'";
                    com = new SqlCommand(str5, conn);
                    int temp5 = Convert.ToInt32(com.ExecuteScalar().ToString());
                    string update1 = "update product2 set ProductQuantity=@PQ where ProductId=@PI";
                    com = new SqlCommand(update1, conn);
                    temp5 += 1;
                    com.Parameters.Add("PQ", temp5);
                    com.Parameters.Add("PI", temp);
                    com.ExecuteNonQuery();
                }
                conn.Close();
                Response.Redirect("Chunk7.aspx");
            }
            catch (Exception ex)
            {

            }
        }
    }
}