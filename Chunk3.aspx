<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Chunk3.aspx.cs" Inherits="Chunk3" %>

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
        <h2 style="font-size: xx-large">Fruit Tree</h2>
     </li>
     <li>
        <asp:Label ID="add" runat="server" Width="160px" Font-Size="X-Large" 
                  ForeColor="Black" Text="ADDTOCART"></asp:Label>
            <asp:Label ID="addsomething1" runat="server" Width="50px" Font-Bold="True" 
             ForeColor="Black" Font-Size="X-Large"></asp:Label>
     </li>
     </ul>
      </div>
      	 <section id="theme-showcase">
            <form id="form1" runat="server">


    <main role="main">

      <!-- Main jumbotron for a primary marketing message or call to action -->
       <div class="container">
      <div class="py-5 text-Left">
              <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                  ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
                  SelectCommand="SELECT * FROM [product]"></asp:SqlDataSource>
      </div>
       

    </div>

    </main>
      <asp:DataList ID="DataList1" runat="server" DataKeyField="ProductId" 
          DataSourceID="SqlDataSource1" RepeatColumns="4" 
          RepeatDirection="Horizontal" onitemcommand="DataList1_ItemCommand1">
          <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
          <ItemTemplate>
              <table class="style1" border="5">
                  <tr>
                      <td class="style1" align="center">
                          <asp:Label ID="Label1" runat="server" Text='<%# Eval("ProductId") %>'></asp:Label>
                      </td>
                  </tr>
                  <tr>
                      <td class="text-sm-center" align="center">
                          <asp:Label ID="Label2" runat="server" Text='<%# Eval("ProductName") %>'></asp:Label>
                      </td>
                  </tr>
                  <tr>
                      <td class="text-sm-center" align="center">
                          <asp:Label ID="Label3" runat="server" Text='<%# Eval("ProductDetails") %>'></asp:Label>
                      </td>
                  </tr>
                  <tr>
                      <td class="text-sm-center" align="center">
                          <asp:Label ID="Label4" runat="server" Text='<%# Eval("ProductPrice") %>'></asp:Label>
                          &nbsp;Taka</td>
                  </tr>
                  <tr>
                      <td class="text-sm-center" align="center">
                          Quantity:
                          <asp:Label ID="Label5" runat="server" Text='<%# Eval("ProductQuantity") %>'></asp:Label>
                      </td>
                  </tr>
                  <tr>
                      <td align="center">
                          <asp:Image ID="Image1" runat="server" Height="250px" 
                              ImageUrl='<%# Eval("ProductImage") %>' Width="250px" />
                      </td>
                  </tr>
                  <tr>
                      <td class="text-sm-center" align="center">
                          <asp:ImageButton ID="ImageButton1" runat="server" Height="50px" 
                              ImageUrl="~/images/addtocart.png" Width="250px" CommandName="addtocart" 
                              CommandArgument='<%# Eval("ProductId") %>'/>
                      </td>
                  </tr>
              </table>
          </ItemTemplate>
      </asp:DataList>
      </form>
          </section>
        
      </div>
</div>
</body>
</html>

