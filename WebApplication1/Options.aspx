<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Options.aspx.cs" Inherits="m3.Options" %>

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
  .log-button {
    background-color: #FF5A5A;
color: #fff;
padding: 10px;
border: none;
border-radius: 4px;
cursor: pointer;
 }

.log-button:hover {
    background-color: #ff0000;
}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="form">
                        <asp:Label ID="title" runat="server" Text="Hello! Choose what do you want "></asp:Label>
            <br />
            <br />
            <asp:Button ID="Homepage" runat="server" Text="Homepage" OnClick="Homepage_Click"  CssClass="submit-button" />
            <br />
            <br />
                        <asp:Button ID="Button1" runat="server" Text="Add your phone number(s)" OnClick="phone_Click"  CssClass="submit-button"/>
        <br /> <br />
            <asp:Button ID="Button2" runat="server" Text="View info about courses" OnClick="Courses_Click"   CssClass="submit-button" />
        <br /> <br />
            <asp:Button ID="Button3" runat="server" Text="Add Requests " OnClick="Requests_Click"   CssClass="submit-button"/>
        <br /> <br />
            <asp:Button ID="Button4" runat="server" Text="Logout" OnClick="Back_Click"   CssClass="log-button" />
        <br /> <br />
        </div>
    </form>
</body>
</html>
