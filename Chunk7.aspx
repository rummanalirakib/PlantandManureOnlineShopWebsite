<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Chunk7.aspx.cs" Inherits="Chunk7" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<!DOCTYPE html>
<html>
<head>
<meta name="viewport" content="width=device-width, initial-scale=1.0">
<style>
body {
  margin: 0;
  font-family: "Lato", sans-serif;
}

.sidebar {
  margin: 0;
  padding: 0;
  width: 200px;
  background-color: #f1f1f1;
  position: fixed;
  height: 100%;
  overflow: auto;
}

.sidebar a {
  display: block;
  color: black;
  padding: 16px;
  text-decoration: none;
}
 
.sidebar a.active {
  background-color: #4CAF50;
  color: white;
}

.sidebar a:hover:not(.active) {
  background-color: #555;
  color: white;
}

div.content {
  margin-left: 200px;
  padding: 1px 16px;
  height: 1000px;
}

@media screen and (max-width: 700px) {
  .sidebar {
    width: 100%;
    height: auto;
    position: relative;
  }
  .sidebar a {float: left;}
  div.content {margin-left: 0;}
}

@media screen and (max-width: 400px) {
  .sidebar a {
    text-align: center;
    float: none;
  }
}
</style>
</head>
<body>
<div class="sidebar">
  <a href="Chunk3.aspx">Fruit Tree</a>
  <a href="Chunk4.aspx">Flower Tree</a>
  <a href="Chunk5.aspx">Manure</a>
  <a href="Chunk6.aspx">Review</a>
  <a href="Chunk7.aspx">Add to Cart</a>
  <a href="Chunk8.aspx">Log Out</a>
</div>

<div class="content">
        <div id="main" class="span9">
      <div class="py-5 text-Left">
      <ul>
      <li>
        <h2 style="font-size: xx-large">Add To Cart</h2>
     </li>
     </ul>
      </div>
      	 <section id="theme-showcase">
            <form id="form1" runat="server">
            <br /><br />
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
                SelectCommand="SELECT * FROM [GiveOrder]"></asp:SqlDataSource>
            <asp:DataList ID="DataList1" runat="server" DataKeyField="Id" 
                DataSourceID="SqlDataSource1" onitemcommand="DataList1_ItemCommand1" 
                RepeatColumns="4" RepeatDirection="Horizontal">
                <ItemTemplate>
                    <table class="style1" border="5">
                        <tr>
                            <td class="center" height="50" width="200" align="center">
                                Id:
                                <asp:Label ID="Label1" runat="server" Text='<%# Eval("Id") %>'></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="center" height="50" width="200" align="center">
                                Product Id:
                                <asp:Label ID="Label2" runat="server" Text='<%# Eval("ProductId") %>'></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="center" height="50" width="200" align="center">
                                Product Name:
                                <asp:Label ID="Label3" runat="server" Text='<%# Eval("ProductName") %>'></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="center" height="50" width="200" align="center">
                                Quantity:
                                <asp:Label ID="Label4" runat="server" Text='<%# Eval("ProductQuantity") %>'></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="center" height="50" width="200" align="center">
                                <asp:Label ID="Label5" runat="server" Text='<%# Eval("ProductPrice") %>'></asp:Label>
                                &nbsp;Taka</td>
                        </tr>
                        <tr>
                            <td align="center">
                                <asp:ImageButton ID="ImageButton1" runat="server" CommandName="DeleteCart" 
                                    Height="60px" ImageUrl="~/images/delete.jpg" Width="250px" CommandArgument='<%# Eval("Id") %>'/>
                            </td>
                        </tr>
                    </table>
                </ItemTemplate>
            </asp:DataList>
            <br />
       <div class="row" align="center">
          <br />
          <br />
          <br />
           <div class="mb-3">
          <asp:Label ID="addtocartinfo" runat="server" Font-Bold="True" 
              Font-Size="XX-Large" ForeColor="#0000CC" Width="693px" Height="41px"></asp:Label>
              </div>
          <br />
          <br />
       <div class="mb-3">
          <asp:Button ID="Button1" runat="server" Enabled="False" Font-Bold="True" 
              Font-Size="Large" Height="59px" onclick="Button1_Click" 
              Text="Put Your Order For Online Delivery" Width="309px" />
      </div>
      </div>
      </form>
          </section>
        
      </div>
</div>
</body>
</html>
