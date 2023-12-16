<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="advisorRegister.aspx.cs" Inherits="WebApplication1.advisorRegister" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label runat="server" Text="Advisor Registration:"></asp:Label>
        </div>
        <div class="">
            <asp:Label runat="server" Text="Name"></asp:Label>&nbsp;</div>
        <div class="">
            <asp:TextBox ID="Advisor_Name" runat="server"></asp:TextBox>&nbsp;</div>
        <div class="">
            <asp:Label runat="server" Text="Password"></asp:Label>&nbsp;</div>
        <div class="">
            <asp:TextBox ID="Advisor_Password" runat="server"></asp:TextBox>&nbsp;</div>
        <div class="">
            <asp:Label runat="server" Text="Email"></asp:Label>&nbsp;</div>
        <div class="">
            <asp:TextBox ID="Advisor_Email" runat="server"></asp:TextBox>&nbsp;</div>
        <div class="">
            <asp:Label runat="server" Text="Office"></asp:Label>&nbsp;</div>
        <div class="">
            <asp:TextBox ID="Advisor_Office" runat="server"></asp:TextBox>
            &nbsp;</div>
        <div class="">
            <asp:Button runat="server" OnClick="Register" Text="Register"></asp:Button>&nbsp;</div>
        <div class="">
            &nbsp;</div>
    </form>
</body>
</html>
