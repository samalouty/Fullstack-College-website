<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Installements.aspx.cs" Inherits="M3.Installements" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Upcoming Installment</title>
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
            <h2>Installments</h2><br />
            <asp:Label ID="text" runat="server" Text="Deadline of the next installement is : "></asp:Label>
            <asp:Label ID="deadline" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:Button ID="Back" runat="server" Text="Back" OnClick="Back_Click" CssClass="submit-button" />
        </div>
    </form>
</body>
</html>
