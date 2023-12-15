<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddMakeup_Exam.aspx.cs" Inherits="WebApplication1.AddMakeup_Exam" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            type:<asp:TextBox ID="type" runat="server"></asp:TextBox>
            <br />
            date:<asp:TextBox ID="date" type="date" runat="server"></asp:TextBox>
            <br />
            courseID:<asp:TextBox ID="courseID" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Add" runat="server" OnClick="btnAddMakeup_Click" Text="Add" />
        <asp:Button runat="server" ID="btnRedirect" Text="Go to Admin Page" CssClass="red-button" PostBackUrl="AdminPage.aspx" />
        </div>
    </form>
</body>
</html>
