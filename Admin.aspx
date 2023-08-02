<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin.aspx.cs" Inherits="Admin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html lang="en">
<head id="Head1" runat="server">

   <link href="css/bootstrap.css" rel="stylesheet" />
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <meta name="description" content="">
    <meta name="author" content="">
    <link rel="icon" href="../../../../favicon.ico">

    <title>Admin Page</title>

    <link href="../../dist/css/bootstrap.min.css" rel="stylesheet">

    <link href="jumbotron.css" rel="stylesheet">
  </head>

  <body>

    <main role="main">

       <div class="container">
      <div class="py-5 text-Left">
        <img class="d-block mx-auto mb-4" src="../../assets/brand/bootstrap-solid.svg" alt="" width="72" height="72">
        <h2>Admin Log In</h2>
      </div>

      <div class="row">
        <div class="col-md-8 order-md-1">
          <form id="Form1" runat="server" class="needs-validation" novalidate>
            <div class="mb-3">
              <asp:Label runat="server" ID="user2" 
                AssociatedControlId="user3" Text="User Name"/>
            <asp:TextBox runat="server" ID="user3"
                CssClass="form-control" placeholder="User Name" />
            </div>
            <div class="mb-3">
              <asp:Label runat="server" ID="pass2" 
                AssociatedControlId="pass3" Text="Password"/>
            <asp:TextBox runat="server" ID="pass3"
                CssClass="form-control" placeholder="Password" TextMode="Password" />
            </div>
            <hr class="mb-4">
            <asp:Button class="btn btn-primary btn-lg btn-block" runat="server" id="Button3" Text="Sign In" OnClick="signup1_Click" />
            <br></br>
          </form>
        </div>
      </div>

    </div>

    </main>
  </body>
</html>
