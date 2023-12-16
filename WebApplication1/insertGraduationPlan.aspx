<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="insertGraduationPlan.aspx.cs" Inherits="WebApplication1.insertGraduationPlan" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label runat="server" Text="Insert a graduation plan:"></asp:Label>
        </div>
        <div>
            <asp:Label runat="server" Text="Semester code:"></asp:Label>&nbsp;</div>
        <div class="">
            <asp:TextBox ID="Semester_Code" runat="server"></asp:TextBox>&nbsp;</div>
        <div class="">
            <asp:Label runat="server" Text="Expected Graduation Date:"></asp:Label>&nbsp;</div>
        <div class="">
            <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
<%--            <asp:TextBox ID="Expected_GradDate" runat="server"></asp:TextBox>&nbsp;</div>--%>
        <div class="">
            <asp:Label runat="server" Text="Semester Credit Hours:"></asp:Label>&nbsp;</div>
        <div class="">
            <asp:TextBox ID="Credit_Hours" runat="server"></asp:TextBox>&nbsp;</div>
        <div class="">
            <asp:Label runat="server" Text="Advisor id:"></asp:Label>&nbsp;</div>
        <div class="">
            <asp:TextBox ID="Advisor_ID" runat="server"></asp:TextBox>&nbsp;</div>
        <div class="">
            <asp:Label runat="server" Text="Student ID:"></asp:Label>&nbsp;</div>
        <div class="">
            <asp:TextBox ID="Student_ID" runat="server"></asp:TextBox>&nbsp;</div>
        <div class="">
            <asp:Button runat="server" OnClick="btn_insertGradPlan_Click" Text="Insert"></asp:Button>&nbsp;</div>
        <div class="">
            &nbsp;</div>
    </form>
</body>
</html>
