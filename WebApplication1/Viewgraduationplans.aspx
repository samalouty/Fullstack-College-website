<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Viewgraduationplans.aspx.cs" Inherits="WebApplication1.Viewgraduationplans" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView" runat="server">
            </asp:GridView>
            <asp:Button runat="server" ID="btnRedirect" Text="Go to Admin Page" CssClass="red-button" PostBackUrl="AdminPage.aspx" />

        </div>
    </form>
</body>
</html>
