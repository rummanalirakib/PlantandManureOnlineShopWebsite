<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Chunk1.aspx.cs" Inherits="Chunk1" %>

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
          <div class="heading-title" style="font-size: xx-large">User Home Page</div>
          <br />
                <div class="row" align="center">
                    <div class="mb-3">
                        <img src="images/1.jpg" class="img-rounded" alt="Cinque Terre">
                        <br />
                        <br />
                        <p style="font-size: xx-large">WelCome To Plant and Manure Online Shop Website</p>
                        <br />
                        <p style="font-size: xx-large">Start Your Planting tree journey with us.</p>
                        <br />
                        <br />
                        <img src="images/2.jpg" class="img-rounded" alt="Cinque Terre">
                    </div>
                </div>
          </section>
        
      </div>
</div>
</body>
</html>

