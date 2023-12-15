<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Slot_Delete.aspx.cs" Inherits="WebApplication1.Slot_Delete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
      <link rel="stylesheet" href="GreenStyles.css">

</head>
<body>
    <form id="form1" runat="server">
        Enter current Semester:<asp:TextBox ID="SemID" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="DeleteSlot" runat="server" OnClick="btnDeleteSlot" Text="Delete Slot" CssClass ="submit-button" />
        <asp:Button runat="server" ID="btnRedirect" Text="Go to Admin Page" CssClass="red-button" PostBackUrl="AdminPage.aspx" />
    </form>
</body>
</html>
