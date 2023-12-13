<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login1.aspx.cs" Inherits="WebApplication1.login1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Page</title>
    <style>
        body {
            font-family: 'Arial', sans-serif;
            background-color: #f5f5f5;
            text-align: center;

        }

        #form1 {
            background-color: #ffffff;
            width: 300px;
            margin: 100px auto;
            padding: 20px;
            border-radius: 5px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
        }

        .label {
            display: block;
            text-align: left;
            margin-bottom: 5px;
            font-weight: bold;
            color: #333333;
        }

        .textbox {
            width: 100%;
            padding: 8px;
            margin-bottom: 10px;
            box-sizing: border-box;
            border: 1px solid #ccc;
            border-radius: 4px;
        }

        .button {
            background-color: #4caf50;
            color: #fff;
            padding: 10px;
            border: none;
            border-radius: 4px;
            cursor: pointer;
        }

        .button:hover {
            background-color: #45a049;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2 style="color: #333333;">Admin Log in</h2><br />

            <label class="label">User ID:</label>
            <asp:TextBox runat="server" ID="txtUserId" CssClass="textbox"></asp:TextBox><br />

            <label class="label">Password:</label>
            <asp:TextBox runat="server" ID="txtPassword" TextMode="Password" CssClass="textbox"></asp:TextBox><br />

            <asp:Button runat="server" Text="Login" OnClick="btnLogin_Click" CssClass="button" />
        </div>
    </form>
</body>
</html>
