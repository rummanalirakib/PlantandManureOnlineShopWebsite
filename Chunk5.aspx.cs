using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
public partial class Chunk5 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["new"] != null)
        {
          //  User2.Text = Session["new"].ToString();
            try
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                conn.Open();
                string checkuser = "select sum(ProductQuantity) from GiveOrder";
                SqlCommand com = new SqlCommand(checkuser, conn);
                int temp1 = Convert.ToInt32(com.ExecuteScalar().ToString());
                conn.Close();
                if (temp1 > 0)
                {
                    addsomething3.Text = Convert.ToString(temp1);
                }
            }
            catch (Exception ex)
            {
                //  Response.Write("Error: " + ex.ToString());
            }
        }
    }
    protected void DataList1_ItemCommand1(object source, DataListCommandEventArgs e)
    {
        if (e.CommandName == "addtocart" && Session["new"] != null)
        {

            try
            {
                string str = e.CommandArgument.ToString();
                int p = Convert.ToInt32(str);
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                conn.Open();
                string checkuser = "select count(*) from GiveOrder where ProductId='" + p + "' AND ProductType='" + 2 + "'";
                SqlCommand com = new SqlCommand(checkuser, conn);
                int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
                string chek = "select ProductName from product2 where ProductId='" + p + "'";
                com = new SqlCommand(chek, conn);
                string chek1 = com.ExecuteScalar().ToString();
                string chek2 = "select ProductPrice from product2 where ProductId='" + p + "'";
                com = new SqlCommand(chek2, conn);
                int chek3 = Convert.ToInt32(com.ExecuteScalar().ToString());
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + temp + "');", true);
                Response.Write(p);
                if (temp == 1)
                {
                    string check = "select ProductQuantity from GiveOrder where ProductId='" + p + "' AND ProductType='" + 2 + "'";
                    com = new SqlCommand(check, conn);
                    int temp1 = Convert.ToInt32(com.ExecuteScalar().ToString());
                    temp1 = temp1 + 1;
                    string w = "select ProductPrice from GiveOrder where ProductId='" + p + "' AND ProductType='" + 2 + "'";
                    com = new SqlCommand(w, conn);
                    int temp2 = Convert.ToInt32(com.ExecuteScalar().ToString());
                    int temp3 = temp2 + temp2;
                    string w1 = "select Id from GiveOrder where ProductId='" + p + "' AND ProductType='" + 2 + "'";
                    com = new SqlCommand(w1, conn);
                    int temp10 = Convert.ToInt32(com.ExecuteScalar().ToString());
                    string check1 = "update GiveOrder set ProductQuantity=@PQ,ProductPrice=@PP where Id=@I";
                    com = new SqlCommand(check1, conn);
                    com.Parameters.Add("PQ", temp1);
                    com.Parameters.Add("PP", temp3);
                    com.Parameters.Add("I", temp10);
                    com.ExecuteNonQuery();
                    string insertQuery1 = "select ProductQuantity from product2 where ProductId='" + p + "'";
                    com = new SqlCommand(insertQuery1, conn);
                    int temp4 = Convert.ToInt32(com.ExecuteScalar().ToString());
                    temp4 = temp4 - 1;
                    string updateQuery = "update product2 set ProductQuantity=@PQ where ProductId=@PI";
                    com = new SqlCommand(updateQuery, conn);
                    com.Parameters.Add("PQ", temp4);
                    com.Parameters.Add("PI", p);
                    com.ExecuteNonQuery();
                    Response.Redirect("Chunk5.aspx");

                }
                else
                {
                    string insertQuery = "insert into GiveOrder(ProductId,ProductType,ProductName,ProductQuantity,ProductPrice) values(@ProductId,@ProductType,@productName,@ProductQuantity,@ProductPrice)";
                    com = new SqlCommand(insertQuery, conn);
                    com.Parameters.AddWithValue("@ProductId", p);
                    com.Parameters.AddWithValue("@ProductType", 2);
                    com.Parameters.AddWithValue("@ProductName", chek1);
                    com.Parameters.AddWithValue("@ProductQuantity", 1);
                    com.Parameters.AddWithValue("@ProductPrice", chek3);
                    com.ExecuteNonQuery();
                    string insertQuery1 = "select ProductQuantity from product2 where ProductId='" + p + "'";
                    com = new SqlCommand(insertQuery1, conn);
                    int temp1 = Convert.ToInt32(com.ExecuteScalar().ToString());
                    temp1 = temp1 - 1;
                    string updateQuery = "update product2 set ProductQuantity=@PQ where ProductId=@PI";
                    com = new SqlCommand(updateQuery, conn);
                    com.Parameters.Add("PQ", temp1);
                    com.Parameters.Add("PI", p);
                    com.ExecuteNonQuery();
                    Response.Redirect("Chunk5.aspx");
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                //  Response.Write("Error: " + ex.ToString());
            }
        }
        else
        {
            string variable2 = "You have to sign in to add to cart.";
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + variable2 + "');", true);
        }
    }
}