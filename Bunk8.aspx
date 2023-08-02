<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Bunk8.aspx.cs" Inherits="Bunk8" %>

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
    .style1
    {
        width: 379px;
    }
    .style2
    {
        width: 336px;
    }
    .style3
    {
        width: 230px;
    }
    .style4
    {
        width: 230px;
        height: 106px;
    }
</style>
</head>
<body>
<div class="sidebar">
  <a href="Bunk.aspx">Admin Home</a>
  <a href="AddProductImage1.aspx">Add Product</a>
  <a href="Bunk1.aspx">Fruit Tree</a>
  <a href="Bunk2.aspx">Flower Tree</a>
  <a href="Bunk4.aspx">Manure</a>
  <a href="Bunk5.aspx">User</a>
  <a href="Bunk6.aspx">Blocked Users</a>
  <a href="Bunk7.aspx">Add Admin</a>
  <a href="Bunk8.aspx">Order Placed</a>
  <a href="Bunk9.aspx">Log Out</a>
</div>
<div class="content">
    <div id="main" class="span9">
      <div class="py-5 text-Left">
        <img class="d-block mx-auto mb-4" src="../../assets/brand/bootstrap-solid.svg" alt="" width="72" height="72">
        <h2 style="font-size: xx-large">Delivery Section</h2>
      </div>
      	 <section id="theme-showcase">
          <form id="frm" runat="server">
            
           <asp:DataList ID="DataList2" runat="server" DataKeyField="Id" 
               DataSourceID="SqlDataSource1" onitemcommand="DataList2_ItemCommand" 
               RepeatColumns="4" RepeatDirection="Horizontal">
               <ItemTemplate>
                   <table border="5" class="style1">
                       <tr>
                           <td class="style3" height="50" align="center">
                               Id:
                               <asp:Label ID="Label1" runat="server" Text='<%# Eval("Id") %>'></asp:Label>
                           </td>
                       </tr>
                       <tr>
                           <td class="style3" height="50" align="center">
                               <asp:Label ID="Label2" runat="server" Text='<%# Eval("UserName") %>'></asp:Label>
                           </td>
                       </tr>
                       <tr>
                           <td class="style3" height="50" align="center">
                               <asp:Label ID="Label3" runat="server" Text='<%# Eval("ProductPrice") %>'></asp:Label>
                               &nbsp;Taka</td>
                       </tr>
                       <tr>
                           <td class="style3" height="50" align="center">
                               Product Information:
                               <asp:Label ID="Label10" runat="server" Text='<%# Eval("ProductInformation") %>'></asp:Label>
                           </td>
                       </tr>
                       <tr>
                           <td class="style3" height="50" align="center">
                               <asp:Label ID="Label4" runat="server" Text='<%# Eval("OrderConfirmation") %>'></asp:Label>
                           </td>
                       </tr>
                       <tr>
                           <td class="style4" align="center">
                               <asp:ImageButton ID="ImageButton1" runat="server" CommandName="OrderConfirm" 
                                   ImageUrl="~/images/orderconfirmation.png" Width="100px" CommandArgument='<%# Eval("Id") %>'/>
                           </td>
                       </tr>
                       <tr>
                           <td class="style3" align="center">
                               <asp:ImageButton ID="ImageButton2" runat="server" CommandName="ShowProduct" 
                                   ImageUrl="~/images/Show.png" Width="100px" CommandArgument='<%# Eval("Id") %>' Height="70" />
                           </td>
                       </tr>
                   </table>
               </ItemTemplate>
           </asp:DataList>
           <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
               ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
               SelectCommand="SELECT * FROM [OrderPlaced]"></asp:SqlDataSource>
            
           </form>
          </section>
        
      </div><!-- main -->     
      </div>
</body>
</html>




