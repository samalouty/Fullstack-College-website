<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="loginADV.aspx.cs" Inherits="WebApplication1.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div><asp:Label runat="server" Text="Please Login"></asp:Label>
            
        </div>
        <div class=""><asp:Label runat="server" Text="Username:"></asp:Label>
            &nbsp;</div>
        <div class=""><asp:TextBox ID="username" runat="server"></asp:TextBox>
            &nbsp;</div>
        <div class="">
            <asp:Label runat="server" Text="Password:"></asp:Label>&nbsp;</div>
        <div class="">
            <asp:TextBox ID="password" runat="server"></asp:TextBox>&nbsp;</div>
        <div class=""><asp:Button ID="signin" runat="server" OnClick="login2" Text="Log In"></asp:Button>
            &nbsp;</div>
        <div class="">
            <asp:Button runat="server" OnClick="btnRegister_Click" Text="Register Now"></asp:Button>&nbsp;</div>
    </form>
</body>
</html>
