using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
public partial class Bunk8 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void DataList2_ItemCommand(object source, DataListCommandEventArgs e)
    {
        if (e.CommandName == "OrderConfirm")
        {
            try
            {
                string str = e.CommandArgument.ToString();
                int p = Convert.ToInt32(str);
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                conn.Open();
                string check1 = "update OrderPlaced set OrderConfirmation=@OC where Id=@I";
                SqlCommand com = new SqlCommand(check1, conn);
                com.Parameters.Add("OC", "Delivered");
                com.Parameters.Add("I", p);
                com.ExecuteNonQuery();
                conn.Close();
                Response.Redirect("Bunk8.aspx");
            }
            catch (Exception ex)
            {

            }
        }
        if (e.CommandName == "ShowProduct")
        {

            try
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                conn.Open();
                string query2 = "delete from ShowOrderedThings";
                SqlCommand com1 = new SqlCommand(query2, conn);
                com1.ExecuteNonQuery();
                string str = e.CommandArgument.ToString();
                int p = Convert.ToInt32(str);
                string query = "Select ProductInformation from OrderPlaced where Id='" + p + "'";
                SqlCommand com = new SqlCommand(query, conn);
                string str1 = com.ExecuteScalar().ToString();
                string[] words = str1.Split('/');

                int count1 = 0;
                int a = 0, b = 0, c = 0;
                string str3 = "";
                foreach (var word in words)
                {
                    count1++;
                    if (count1 % 4 == 1)
                    {
                        a = Convert.ToInt32(word);
                    }
                    else if (count1 % 4 == 2)
                    {
                        b = Convert.ToInt32(word);
                        Response.Write(b);
                        str3 += word;
                    }
                    else if (count1 % 4 == 3)
                    {
                        c = Convert.ToInt32(word);
                    }
                    if (count1 % 4 == 3)
                    {
                        if (b == 0)
                        {
                            string query1 = "select ProductImage from product where ProductId='" + a + "'";
                            com = new SqlCommand(query1, conn);
                            string image = com.ExecuteScalar().ToString();
                            string insertQuery = "insert into ShowOrderedThings(ProductId,ProductType,ProductQuantity,ProductImage) values(@PI,@PT,@PQ,@PIM)";
                            com = new SqlCommand(insertQuery, conn);
                            com.Parameters.AddWithValue("@PI", a);
                            com.Parameters.AddWithValue("@PT", b);
                            com.Parameters.AddWithValue("@PQ", c);
                            com.Parameters.AddWithValue("@PIM", image);
                            com.ExecuteNonQuery();
                        }
                        else if (b == 1)
                        {
                            string query1 = "select ProductImage from product1 where ProductId='" + a + "'";
                            com = new SqlCommand(query1, conn);
                            string image = com.ExecuteScalar().ToString();
                            string insertQuery = "insert into ShowOrderedThings(ProductId,ProductType,ProductQuantity,ProductImage) values(@PI,@PT,@PQ,@PIM)";
                            com = new SqlCommand(insertQuery, conn);
                            com.Parameters.AddWithValue("@PI", a);
                            com.Parameters.AddWithValue("@PT", b);
                            com.Parameters.AddWithValue("@PQ", c);
                            com.Parameters.AddWithValue("@PIM", image);
                            com.ExecuteNonQuery();
                        }
                        else if (b == 2)
                        {
                            string query1 = "select ProductImage from product2 where ProductId='" + a + "'";
                            com = new SqlCommand(query1, conn);
                            string image = com.ExecuteScalar().ToString();
                            string insertQuery = "insert into ShowOrderedThings(ProductId,ProductType,ProductQuantity,ProductImage) values(@PI,@PT,@PQ,@PIM)";
                            com = new SqlCommand(insertQuery, conn);
                            com.Parameters.AddWithValue("@PI", a);
                            com.Parameters.AddWithValue("@PT", b);
                            com.Parameters.AddWithValue("@PQ", c);
                            com.Parameters.AddWithValue("@PIM", image);
                            com.ExecuteNonQuery();
                        }
                        count1++;
                    }
                }
                conn.Close();
                Response.Redirect("Bunk11.aspx");
            }
            catch (Exception ex)
            {

            }
        }
    }
}