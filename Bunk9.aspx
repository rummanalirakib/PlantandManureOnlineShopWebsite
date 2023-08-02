﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Bunk9.aspx.cs" Inherits="Bunk9" %>

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
        <h2 font-size: xx-large" style="font-size: xx-large">Admin Log Out</h2>
     <br />
     <br />
      </div>
      	 <section id="theme-showcase">
            <form id="form1" runat="server">
              <div class="row" align="center">
         <div class="mb-3">
          <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="XX-Large" 
              Height="35px" Text="Do you sure want to log out? " Width="479px" 
                style="text-align: left"></asp:Label>
          </div>
          <br />
          <br />
          <div class="mb-3">
          <asp:Button ID="Button1" runat="server" Font-Bold="True" Font-Size="XX-Large" 
              onclick="Button1_Click" Text="Yes" Width="100px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
          <asp:Button ID="Button2" runat="server" Font-Bold="True" Font-Size="XX-Large" 
              onclick="Button2_Click" Text="No" Width="100px" />
         </div>
      </div>
      
      </form>
          </section>
        
      </div>
      </div>
</body>
</html>
