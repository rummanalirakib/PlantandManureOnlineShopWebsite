<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddProductImage1.aspx.cs" Inherits="AddProductImage1" %>

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
        <h2 style="font-size: xx-large">Add Product</h2>
      </div>
      	 <section id="theme-showcase">
          <form id="frm" runat="server">
           <table>
              <tr>
                <td>product Type</td>
                <td><asp:TextBox ID="t1" runat="server"></asp:TextBox></td>
              </tr>

              <tr>
                <td>product Name</td>
                <td><asp:TextBox ID="t2" runat="server"></asp:TextBox></td>
              </tr>

              <tr>
                <td>product Details</td>
                <td><asp:TextBox ID="t3" runat="server"></asp:TextBox></td>
              </tr>

              <tr>
                <td>product Price</td>
                <td><asp:TextBox ID="t4" runat="server"></asp:TextBox></td>
              </tr>

              <tr>
                <td>product Quantity</td>
                <td><asp:TextBox ID="t5" runat="server"></asp:TextBox></td>
              </tr>

              <tr>
                <td>product Image</td>
                <td>
                <asp:FileUpload id="f1" runat="server" />
                </td>
              </tr>
              <tr>
              <td colspan="2" align="center">
              <asp:Button ID="b1" runat="server" Text="upload" onclick="b1_Click"/>
              </td>
              </tr>
           </table> 
           </form>
          </section>
        
      </div>
</div>
</body>
</html>

