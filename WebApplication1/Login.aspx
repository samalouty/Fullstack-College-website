<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="m3.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        body {
            font-family: 'Arial', sans-serif;
            background-color: #f5f5f5;
            text-align: center;
            margin: 0;
            padding: 0;
        }

        .form {
            background-color: #ffffff;
            width: 300px;
            margin: 50px auto;
            padding: 20px;
            border-radius: 5px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
}
.submit-button {
    background-color: #4caf50;
    color: #fff;
    padding: 10px;
    border: none;
    border-radius: 4px;
    cursor: pointer;
 }

.submit-button:hover {
    background-color: #45a049;
}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="form">

                <asp:Label ID="pleaselogin" runat="server" Text="Please Login"></asp:Label>
<br /><br />
            Username:
            <br />
  <asp:TextBox ID="username" runat="server"></asp:TextBox>
<br /><br />
      Password:  <br />
  <asp:TextBox ID="password" runat="server" TextMode="Password"></asp:TextBox>
 <br /><br />
      <asp:Button ID="Signin" runat="server" Text="Signin " OnClick="Signin_Click"  CssClass="submit-button" />
 <br /><br /><br /><br />
  <asp:Label ID="noaccount" runat="server" Text="Don't have an account?"></asp:Label>
  <br />
      <asp:Button ID="Register" runat="server" OnClick="Register_Click" Text="Register"   CssClass="submit-button" />
  <br /><br /><br />
  <asp:Button ID="Back" runat="server" OnClick="Back_Click" Text="Back" CssClass="submit-button"/></div>
       
    </form>
</body>
</html>
