<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrontPage.aspx.cs" Inherits="m3.Registeration" %>

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
            Chooose to login
            <br /><br />
            <asp:Button ID="Button1" runat="server" Text="Student" OnClick="Student_Click" CssClass="submit-button" />
<br /><br />
    <asp:Button ID="Button2" runat="server" Text="Admin" OnClick="Admin_Click" CssClass="submit-button" />
<br /><br />
<asp:Button ID="Button3" runat="server" Text="Advisor" OnClick="Advisor_Click" CssClass="submit-button "/>
<br /><br />
        </div>
    </form>
</body>
</html>
