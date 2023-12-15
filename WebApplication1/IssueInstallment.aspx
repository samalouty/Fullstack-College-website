<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IssueInstallment.aspx.cs" Inherits="WebApplication1.IssueInstallment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter payment ID:<asp:TextBox ID="payID" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Issue" runat="server" OnClick="btn_IssueInstallment_Click" Text="Issue" />
            <asp:Button runat="server" ID="btnRedirect" Text="Go to Admin Page" CssClass="red-button" PostBackUrl="AdminPage.aspx" />
        </div>
    </form>
</body>
</html>
