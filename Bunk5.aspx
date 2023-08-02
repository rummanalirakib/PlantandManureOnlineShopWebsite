<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Bunk5.aspx.cs" Inherits="Bunk5" %>

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
        <h2 style="font-size: xx-large">User</h2>
      </div>
      	 <section id="theme-showcase">
            <form id="form1" runat="server">
              
      
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
                SelectCommand="SELECT * FROM [Registration]"></asp:SqlDataSource>
            <asp:DataList ID="DataList1" runat="server" DataKeyField="Id" 
                DataSourceID="SqlDataSource1" RepeatColumns="5" 
                RepeatDirection="Horizontal" onitemcommand="DataList1_ItemCommand">
                <ItemTemplate>
                    <table class="style1" border="5">
                        <tr>
                            <td class="center" height="50px" width="200px" align="center">
                                Id:<asp:Label ID="Label1" runat="server" Text='<%# Eval("Id") %>'></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="center" height="50px" width="200" align="center">
                                First Name:
                                <asp:Label ID="Label2" runat="server" Text='<%# Eval("FirstName") %>'></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="center" height="50px" width="200px" align="center">
                                Last Name:
                                <asp:Label ID="Label3" runat="server" Text='<%# Eval("LastName") %>'></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="center" height="50px" width="200px" align="center">
                                User Name:
                                <asp:Label ID="Label4" runat="server" Text='<%# Eval("UserName") %>'></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="center" height="50px" width="200" align="center">
                                Phone:
                                <asp:Label ID="Label5" runat="server" Text='<%# Eval("Phone") %>'></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="center" height="100px" width="200px" align="center">
                                Address:
                                <asp:Label ID="Label6" runat="server" Text='<%# Eval("Address") %>'></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="center" height="50" width="200" align="center">
                                Password:
                                <asp:Label ID="Label7" runat="server" Text='<%# Eval("Password") %>'></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="center" align="center">
                                <asp:ImageButton ID="ImageButton1" runat="server" CommandName="DeleteUser" 
                                    ImageUrl="~/images/delete1.jpg" Width="101px" CommandArgument='<%# Eval("Id") %>'/>
                            </td>
                        </tr>
                        <tr>
                            <td class="center" align="center">
                                <asp:ImageButton ID="ImageButton2" runat="server" CommandName="BlockUser" 
                                    ImageUrl="~/images/Block.png" Width="101px" CommandArgument='<%# Eval("Id") %>'/>
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
