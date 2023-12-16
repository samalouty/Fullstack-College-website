<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Instructors.aspx.cs" Inherits="M3.Instructors" %>

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
            <asp:Label ID="Label1" runat="server" Text="Please enter the requested information to choose your instructor:"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Message" runat="server" Text=" "></asp:Label>
            <br />
            <asp:Label ID="Label3" runat="server" Text="New Instructor ID:"></asp:Label>
            <br />
            <asp:TextBox ID="insid" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Course ID:"></asp:Label>
            <br />
            <asp:TextBox ID="courseid" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Text="Current Semester Code:"></asp:Label>
            <br />
            <asp:TextBox ID="semcode" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Confirm" runat="server" Text="Confirm" OnClick="Confirm_Click" CssClass="submit-button"/>
            <br />
            <br />
            <asp:Button ID="Back" runat="server" Text="Back" OnClick="Back_Click" CssClass="submit-button"/>
            <br />
        </div>
    </form>
</body>
</html>
