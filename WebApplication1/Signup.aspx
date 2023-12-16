<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Signup.aspx.cs" Inherits="m3.Signup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Signup Page</title>
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
            <h2>Sign-up</h2><br />
            <asp:Label ID="Details" runat="server" Text="Please enter your details"></asp:Label>
                    <br/>
            <br />
            <asp:Label ID="First_Name" runat="server" Text="First Name"></asp:Label>
        <br/>
        <asp:TextBox ID="box1" runat="server"></asp:TextBox>
        <br/><br/>
        <asp:Label ID="Last_Name" runat="server" Text="Last Name"></asp:Label>
        <br/>
            <asp:TextBox ID="box2" runat="server"></asp:TextBox>
        <br/>
        <br/>
        <asp:Label ID="password" runat="server" Text="Password"></asp:Label>
        <br />
            <asp:TextBox ID="box3" runat="server"></asp:TextBox>
       <br />
        <br />
        <asp:Label ID="Faculty" runat="server" Text="Faculty"></asp:Label>
        <br />
            <asp:TextBox ID="box4" runat="server"></asp:TextBox>
        <br />
<br />
        <asp:Label ID="Email" runat="server" Text="Email"></asp:Label>
        <br />
            <asp:TextBox ID="box5" runat="server"></asp:TextBox>
        <br />
<br />
        <asp:Label ID="major" runat="server" Text="Major"></asp:Label>
        <br />
            <asp:TextBox ID="box6" runat="server"></asp:TextBox>
        <br />
<br />
        <asp:Label ID="semester" runat="server" Text="Semester"></asp:Label>
       <br />
            <asp:TextBox ID="box7" runat="server"></asp:TextBox>
        <br />
<br />
        <br />
<br />
            <asp:Button ID="Register" runat="server" Text="Register" OnClick="Register_Click"  CssClass="submit-button"/>
        <br />
<br />
        <asp:Button ID="Back" runat="server" OnClick="Back_Click" Text="Back To Login" CssClass="submit-button" />
        </div>

    </form>
</body>
</html>
