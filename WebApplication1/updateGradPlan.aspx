<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="updateGradPlan.aspx.cs" Inherits="WebApplication1.updateGradPlan" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Update expected graduation date in a certain graduation plan"></asp:Label>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Expected Graduation Date:"></asp:Label>
            <br />
            <asp:Calendar ID="graduation_date" runat="server"></asp:Calendar>
            <asp:Label ID="Label3" runat="server" Text="Student Id:"></asp:Label>
            <br />
            <asp:TextBox ID="student_id" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" OnClick="btn_update_Click" runat="server" Text="Update" />
            <br />
            <asp:Button runat="server" ID="btnRedirect" Text="Go to Advisor page" CssClass="red-button" PostBackUrl="advisorpage.aspx" />

        </div>
    </form>
</body>
</html>
