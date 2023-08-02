using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class AddProductImage1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void b1_Click(object sender, EventArgs e)
    {
        try
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            conn.Open();
            f1.SaveAs(Request.PhysicalApplicationPath + "./images/" + f1.FileName.ToString());
            if (t1.Text == "0")
            {
                string b = "images/" + f1.FileName.ToString();
                string insertQuery = "insert into product(ProductType,ProductName,ProductDetails,ProductPrice,ProductQuantity,ProductImage) values(@PT,@PN,@PD,@PP,@PQ,@PI)";
                SqlCommand com = new SqlCommand(insertQuery, conn);
                com.Parameters.AddWithValue("@PT", t1.Text);
                com.Parameters.AddWithValue("@PN", t2.Text);
                com.Parameters.AddWithValue("@PD", t3.Text);
                com.Parameters.AddWithValue("@PP", t4.Text);
                com.Parameters.AddWithValue("@PQ", t5.Text);
                com.Parameters.AddWithValue("@PI", b.ToString());
                com.ExecuteNonQuery();
                conn.Close();
            }
            else if (t1.Text == "1")
            {
                string b = "images/" + f1.FileName.ToString();
                string insertQuery = "insert into product1(ProductType,ProductName,ProductDetails,ProductPrice,ProductQuantity,ProductImage) values(@PT,@PN,@PD,@PP,@PQ,@PI)";
                SqlCommand com = new SqlCommand(insertQuery, conn);
                com.Parameters.AddWithValue("@PT", t1.Text);
                com.Parameters.AddWithValue("@PN", t2.Text);
                com.Parameters.AddWithValue("@PD", t3.Text);
                com.Parameters.AddWithValue("@PP", t4.Text);
                com.Parameters.AddWithValue("@PQ", t5.Text);
                com.Parameters.AddWithValue("@PI", b.ToString());
                com.ExecuteNonQuery();
                conn.Close();
            }
            else if (t1.Text == "2")
            {
                string b = "images/" + f1.FileName.ToString();
                string insertQuery = "insert into product2(ProductType,ProductName,ProductDetails,ProductPrice,ProductQuantity,ProductImage) values(@PT,@PN,@PD,@PP,@PQ,@PI)";
                SqlCommand com = new SqlCommand(insertQuery, conn);
                com.Parameters.AddWithValue("@PT", t1.Text);
                com.Parameters.AddWithValue("@PN", t2.Text);
                com.Parameters.AddWithValue("@PD", t3.Text);
                com.Parameters.AddWithValue("@PP", t4.Text);
                com.Parameters.AddWithValue("@PQ", t5.Text);
                com.Parameters.AddWithValue("@PI", b.ToString());
                com.ExecuteNonQuery();
                conn.Close();
            }

        }
        catch (Exception ex)
        {

        }
    }
}