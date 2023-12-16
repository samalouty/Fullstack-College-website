<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Phone.aspx.cs" Inherits="m3.Phone" %>

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
            <asp:Label ID="phone1" runat="server" Text="Add your phone number(s)"></asp:Label>
             <br /><br />
     <asp:TextBox ID="phonenumber" runat="server"></asp:TextBox>
 <br /><br />
 <asp:Button ID="click" runat="server" Text="Click to add" OnClick="click_Click" CssClass="submit-button"/>
<br /><br />
     <asp:Button ID="Back" runat="server" Text="Back" OnClick="Back_Click"   CssClass="submit-button"/>
 <br />
        </div>

    </form>
</body>
</html>
