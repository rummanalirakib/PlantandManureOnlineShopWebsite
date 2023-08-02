using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class Chunk : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            if (firstname1.Text != "" && lastname1.Text != "" && username1.Text != "" && phone1.Text != "" && address1.Text != "" && password1.Text != "" && confirmpassword1.Text != "")
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                conn.Open();
                string checkuser = "select count(*) from Registration where UserName='" + username1.Text + "'";
                SqlCommand com = new SqlCommand(checkuser, conn);
                int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
                string checkuser2 = "select count(*) from Registration where Phone='" + phone1.Text + "'";
                com = new SqlCommand(checkuser2, conn);
                int y = Convert.ToInt32(com.ExecuteScalar().ToString());
                string checkuser1 = "select count(*) from BlockUser where PhoneNumber='" + phone1.Text + "'";
                com = new SqlCommand(checkuser1, conn);
                int x = Convert.ToInt32(com.ExecuteScalar().ToString());
                conn.Close();
                string str = password1.Text;
                string str1 = confirmpassword1.Text;
                if (x == 0)
                {
                    if (password1.Text == confirmpassword1.Text)
                    {
                        if (temp != 1 || y != 1)
                        {
                            if (phone1.Text.Length == 11)
                            {
                                conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                                conn.Open();
                                string insertQuery = "insert into Registration(FirstName,LastName,UserName,Phone,Address,Password) values(@f,@l,@u,@ph,@a,@pa)";
                                com = new SqlCommand(insertQuery, conn);
                                com.Parameters.AddWithValue("@f", firstname1.Text);
                                com.Parameters.AddWithValue("@l", lastname1.Text);
                                com.Parameters.AddWithValue("@u", username1.Text);
                                com.Parameters.AddWithValue("@ph", phone1.Text);
                                com.Parameters.AddWithValue("@a", address1.Text);
                                com.Parameters.AddWithValue("@pa", password1.Text);
                                com.ExecuteNonQuery();
                                string variable1 = "Your Registration is Successfull.";
                                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + variable1 + "');", true);
                                conn.Close();
                            }
                            else
                            {
                                string variable2 = "The phone number is not valid.";
                                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + variable2 + "');", true);
                            }
                        }
                        else
                        {
                            string variable3 = "The username or Phone Number has been Taken.";
                            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + variable3 + "');", true);
                        }
                    }
                    else
                    {
                        string variable4 = "Both Passwords are not same.";
                        ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + variable4 + "');", true);
                    }
                }
                else
                {
                    string variable5 = "This number hasbeen blocked by admin panel.";
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