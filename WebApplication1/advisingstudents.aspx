<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="advisingstudents.aspx.cs" Inherits="WebApplication1.advisingstudents" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label runat="server" Text="All advising Students"></asp:Label>
            <asp:Button runat="server" ID="btnRedirect" Text="Go to Advisor page" CssClass="red-button" PostBackUrl="advisorpage.aspx" />

        </div>
    </form>
</body>
</html>
    
