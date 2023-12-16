<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="appExtraCourses.aspx.cs" Inherits="WebApplication1.appExtraCourses" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Approve/Reject courses request based on the student’s assigned credit hours"></asp:Label>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Request ID:"></asp:Label>
        <div>
            <asp:TextBox ID="request_id" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Current Semester code:"></asp:Label>
            <br />
            <asp:TextBox ID="current_semester_code" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" OnClick="btn_proceed2_click" runat="server" Text="Proceed" />
                    <asp:Button runat="server" ID="btnRedirect" Text="Go to Advisor page" CssClass="red-button" PostBackUrl="advisorpage.aspx" />

        </div>
    </form>
</body>
</html>
