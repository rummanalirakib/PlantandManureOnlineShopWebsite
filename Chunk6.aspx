<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Chunk6.aspx.cs" Inherits="Chunk6" %>

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
        <h2 style="font-size: xx-large">Review</h2>
     </li>
     </ul>
      </div>
      <br />
      	 <section id="theme-showcase">
            <form id="form1" runat="server">
            <div class="text-md-left">
          <asp:TextBox ID="CommentBox" runat="server" TextMode="MultiLine" Width="750px">Put Your Comment Here</asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<br />
          <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Post" 
              Width="200px" align="center" Height="30" />
      </div>
      <br />
      <br />
      <br />
      <br />
       <asp:DataList ID="DataList1" runat="server" DataKeyField="Id" 
          DataSourceID="SqlDataSource1" onitemcommand="DataList1_ItemCommand">
          <ItemTemplate>
              <table class="style4">
                  <tr>
                      <td class="style2">
                          <asp:Label ID="Label2" runat="server" ForeColor="White" Text="Label"></asp:Label>
                      </td>
                      <td class="style2">
                          <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Size="Large" 
                              ForeColor="Blue" Text='<%# Eval("UserName") %>' Width="200px"></asp:Label>
                      </td>
                      <td class="style2">
                          <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Size="Medium" 
                              Text='<%# Eval("ReviewText") %>' Width="500px"></asp:Label>
                      </td>
                      <td class="style2" width="100px">
                          <asp:ImageButton ID="ImageButton1" runat="server" Height="26px" 
                              ImageUrl="~/images/dele.jpg" Width="81px" CommandName="DeleteComment" 
                              CommandArgument='<%# Eval("Id") %>'/>
                      </td>
                      <td class="style2" width="100px">
                          <asp:ImageButton ID="ImageButton2" runat="server" Height="20px" 
                              ImageUrl="~/images/like.png" Width="82px" CommandName="LikePress" 
                              CommandArgument='<%# Eval("Id") %>'/>
                      </td>
                      <td class="style2">
                          <asp:Label ID="Label5" runat="server" Text='<%# Eval("LikeButton") %>' 
                              Width="100px"></asp:Label>
                      </td>
                  </tr>
              </table>
              <table class="style1">
              </table>
          </ItemTemplate>
      </asp:DataList>   
      <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
          ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
          SelectCommand="SELECT * FROM [Review]"></asp:SqlDataSource>
      </form>
          </section>
        
      </div>
</div>
</body>
</html>




