<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Chunk.aspx.cs" Inherits="Chunk" %>

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
  <a href="Chunk1.aspx">Home</a>
  <a href="Chunk.aspx">Registration</a>
  <a href="Chunk2.aspx">LogIn</a>
  <a href="Chunk3.aspx">Fruit Tree</a>
  <a href="Chunk4.aspx">Flower Tree</a>
  <a href="Chunk5.aspx">Manure</a>
</div>

<div class="content">
   <div id="main" class="span9">
      	        	            <section id="theme-showcase">
            <br />
            <br />
            <div class="row" align="center">
              <div class="theme-img span6 boxshadow">
                <form id="Form1" runat="server" class="needs-validation" novalidate>
              <div class="mb-3" align="center">
               <div class="heading-title" style="font-size: xx-large">Registration</div>
              </div>
              <div class="mb-3" align="center">
            <asp:TextBox runat="server" ID="firstname1"
                CssClass="form-control" placeholder="First Name" Width="1000px" 
                      Font-Size="X-Large" />
              </div>
              <br />
              <div class="mb-3" align="center">
            <asp:TextBox runat="server" ID="lastname1"
                CssClass="form-control" placeholder="Last Name" Width="1000px" 
                      Font-Size="X-Large" />
              </div>
              <br />
             <div class="mb-3" align="center">
            <asp:TextBox runat="server" ID="username1"
                CssClass="form-control" placeholder="User Name" Width="1000px" 
                     Font-Size="X-Large" />
            </div>
            <br />
            <div class="mb-3" align="center">
            <asp:TextBox runat="server" ID="phone1"
                CssClass="form-control" placeholder="Phone Number" Width="1000" 
                    Font-Size="X-Large" />
            </div>
            <br />
            <div class="mb-3" align="center">
            <asp:TextBox runat="server" ID="address1"
                CssClass="form-control" placeholder="Address" Width="1000" 
                    Font-Size="X-Large" />
            </div>
            <br />
            <div class="mb-3" align="center">
            <asp:TextBox runat="server" ID="password1"
                CssClass="form-control" placeholder="Password" TextMode="Password" 
                    Width="1000" Font-Size="X-Large" />
            </div>
            <br />
            <div class="mb-3" align="center">
            <asp:TextBox runat="server" ID="confirmpassword1"
                CssClass="form-control" placeholder="Confirm Password" TextMode="Password" 
                    Width="1000px" Font-Size="X-Large" />
            </div>
            <br />
            <asp:Button class="btn btn-primary btn-lg btn-block" runat="server" id="Button1" 
                    Text="Sign Up" onclick="Button1_Click" Font-Size="X-Large" Width="200px" />
            <br></br>
            </form>
              </div><!-- theme-img -->
              
            </div><!-- row -->    
          </section>
        
      </div>
</div>
</body>
</html>
