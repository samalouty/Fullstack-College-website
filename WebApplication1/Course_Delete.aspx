<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Course_Delete.aspx.cs" Inherits="WebApplication1.Course_Delete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="GreenStyles.css">

</head>
<body>
    <form id="form1" runat="server">
        Enter course ID:<asp:TextBox ID="CourseID" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Delete" runat="server" OnClick="btnDelete" Text="Delete Course" CssClass ="submit-button"/>
        <asp:Button runat="server" ID="btnRedirect" Text="Go to Admin Page" CssClass="red-button" PostBackUrl="AdminPage.aspx" />
    </form>
</body>
</html>
