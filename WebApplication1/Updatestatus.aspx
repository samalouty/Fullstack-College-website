<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Updatestatus.aspx.cs" Inherits="WebApplication1.Updatestatus" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
      <link rel="stylesheet" href="GreenStyles.css">

</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Student_ID" runat="server" Text="Student ID:"></asp:Label>
            <asp:TextBox ID="StudentID" runat="server"></asp:TextBox>
        </div>
        <asp:Button ID="Update" runat="server" OnClick="btnUpdateStatus_Click" Text="Update status" CssClass="submit-button"/>
        <asp:Button runat="server" ID="btnRedirect" Text="Go to Admin Page" CssClass="red-button" PostBackUrl="AdminPage.aspx" />
    </form>
</body>
</html>
