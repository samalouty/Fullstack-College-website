<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GradPlan.aspx.cs" Inherits="M3.GradPlan" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
       <style>
    body {
        font-family: 'Arial', sans-serif;
        background-color: #f5f5f5;
        margin: 0;
        padding: 0;
    }

    form {
        max-width: 800px;
        margin: 20px auto;
        padding: 20px;
        background-color: #fff;
        border-radius: 5px;
        box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
    }

    h2 {
        color: #333;
    }

    table {
        width: 100%;
        border-collapse: collapse;
        margin-top: 20px;
    }

    th, td {
        padding: 10px;
        border: 1px solid #ddd;
        text-align: left;
    }

    th {
        background-color: #4caf50;
        color: #fff;
    }

    tr:nth-child(even) {
        background-color: #f2f2f2;
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
        <div>
            <h2>Gradutaion Plan</h2><br />
            <asp:Label ID="Name" runat="server" Text="Name: "></asp:Label>
            <asp:Label ID="nLabel" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:Label ID="PI" runat="server" Text="Plan id: "></asp:Label>
            <asp:Label ID="piLabel" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:Label ID="SC" runat="server" Text="Semester code: "></asp:Label>
            <asp:Label ID="scLabel" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:Label ID="SCH" runat="server" Text="Semester credit hours: "></asp:Label>
            <asp:Label ID="schLabel" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:Label ID="EGD" runat="server" Text="Expected Graduation Date: "></asp:Label>
            <asp:Label ID="egdLabel" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Aid" runat="server" Text="Advisor id: "></asp:Label>
            <asp:Label ID="aidLabel" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Sid" runat="server" Text="Student id: "></asp:Label>
            <asp:Label ID="sidLabel" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Courses" runat="server" Text="Courses:"></asp:Label>
            <br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <br />
            <asp:Button ID="Back" runat="server" Text="Back" OnClick="Back_Click" CssClass="submit-button"/>
        </div>
    </form>
</body>
</html>
