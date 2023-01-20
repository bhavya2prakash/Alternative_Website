<%@ Page Language="C#" AutoEventWireup="true" CodeFile="signup.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1">
<style>
body {font-family: Arial, Helvetica, sans-serif;}
* {box-sizing: border-box;}

input[type=text], select, textarea {
  width: 100%;
  padding: 12px;
  border: 1px solid #ccc;
  border-radius: 4px;
  box-sizing: border-box;
  margin-top: 6px;
  margin-bottom: 16px;
  resize: vertical;
}

input[type=submit] {
  background-color: #4CAF50;
  color: white;
  padding: 12px 20px;
  border: none;
  border-radius: 4px;
  cursor: pointer;
}

input[type=submit]:hover {
  background-color: #45a049;
}

.container {
  border-radius: 5px;
  background-color: #f2f2f2;
  padding: 20px;
}
</style>
</head>
<body>
    <form id="form1" runat="server">
    <h3 align=CENTER>SIGN UP FORM</h3>

<div class="container">
  <form action="/action_page.php">
    <label for="fname">First Name</label>
  <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

    <label for="lname">Last Name</label>
  <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
<label for="EMAIL">EMAIL</label>
 <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
<label for="password">Password</label>
  <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
 
<label for="CON">CONTACT</label>
  <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
    <label for="country">Country</label>
  <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
<label for="state">State</label>
  <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
<label for="CITY">CITY</label>
  <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
    <label for="subject">ADDRESS</label>
  <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>

  <asp:Button ID="Button1" runat="server" Text="Button" onclick="Button1_Click1" />
  </form>
</div>

    </form>
</body>
</html>
