using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
public partial class bunk3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        t1.Text = Session["valuePass"].ToString();
        t2.Text = Session["valuePass1"].ToString();
    }
    protected void b1_Click(object sender, EventArgs e)
    {
        if (Session["valuePass1"].ToString() == "0")
        {
            if (t3.Text != "" && t4.Text != "" && t5.Text != "")
            {
                int p = Convert.ToInt32(Session["valuePass"].ToString());
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                conn.Open();
                string update = "update product set ProductDetails=@PD,ProductQuantity=@PQ,ProductPrice=@PP where ProductId=@PI";
                SqlCommand com = new SqlCommand(update, conn);
                com.Parameters.Add("PD", t3.Text);
                com.Parameters.Add("PQ", t5.Text);
                com.Parameters.Add("PP", t4.Text);
                com.Parameters.Add("PI", p);
                com.ExecuteNonQuery();
                string variable1 = "Product Details Has been Updated";
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + variable1 + "');", true);
            }
            else
            {
                string variable1 = "You can't keep any field empty";
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + variable1 + "');", true);
            }
        }
        else if (Session["valuePass1"].ToString() == "1")
        {
            if (t3.Text != "" && t4.Text != "" && t5.Text != "")
            {
                int p = Convert.ToInt32(Session["valuePass"].ToString());
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                conn.Open();
                string update = "update product1 set ProductDetails=@PD,ProductQuantity=@PQ,ProductPrice=@PP where ProductId=@PI";
                SqlCommand com = new SqlCommand(update, conn);
                com.Parameters.Add("PD", t3.Text);
                com.Parameters.Add("PQ", t5.Text);
                com.Parameters.Add("PP", t4.Text);
                com.Parameters.Add("PI", p);
                com.ExecuteNonQuery();
                string variable1 = "Product Details Has been Updated";
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + variable1 + "');", true);
                Response.Redirect("bunk3.aspx");
            }
            else
            {
                string variable1 = "You can't keep any field empty";
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + variable1 + "');", true);
            }
        }
        else if (Session["valuePass1"].ToString() == "2")
        {
            if (t3.Text != "" && t4.Text != "" && t5.Text != "")
            {
                int p = Convert.ToInt32(Session["valuePass"].ToString());
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                conn.Open();
                string update = "update product2 set ProductDetails=@PD,ProductQuantity=@PQ,ProductPrice=@PP where ProductId=@PI";
                SqlCommand com = new SqlCommand(update, conn);
                com.Parameters.Add("PD", t3.Text);
                com.Parameters.Add("PQ", t5.Text);
                com.Parameters.Add("PP", t4.Text);
                com.Parameters.Add("PI", p);
                com.ExecuteNonQuery();
                string variable1 = "Product Details Has been Updated";
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + variable1 + "');", true);
            }
            else
            {
                string variable1 = "You can't keep any field empty";
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + variable1 + "');", true);
            }
        }
    }
}