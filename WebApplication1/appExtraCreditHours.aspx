<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="appExtraCreditHours.aspx.cs" Inherits="WebApplication1.appExtraCreditHours" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Accept/Reject Credit hours request"></asp:Label>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Request ID:"></asp:Label>
            <br />
            <asp:TextBox ID="request_id" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Current Semester Code:"></asp:Label>
            <br />
            <asp:TextBox ID="current_sem_code" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" OnClick="btn_accept_Click" runat="server" Text="Proceed" />
                    <asp:Button runat="server" ID="btnRedirect" Text="Go to Advisor page" CssClass="red-button" PostBackUrl="advisorpage.aspx" />

            
        </div>
    </form>
</body>
</html>
