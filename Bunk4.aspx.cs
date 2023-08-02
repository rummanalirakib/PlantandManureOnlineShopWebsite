using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
public partial class Bunk4 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
    {
        if (e.CommandName == "DeleteTree")
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                conn.Open();
                string str = e.CommandArgument.ToString();
                int p = Convert.ToInt32(str);
                string query = "Delete from product2 where ProductId='" + p + "'";
                SqlCommand com = new SqlCommand(query, conn);
                com.ExecuteNonQuery();
                conn.Close();
                Response.Redirect("Bunk4.aspx");
            }
            catch (Exception ex)
            {

            }
        }
        if (e.CommandName == "UpdateTree")
        {
            Session["valuePass"] = e.CommandArgument.ToString();
            Session["valuePass1"] = "2";
            Response.Redirect("Bunk3.aspx");
        }
    }
}