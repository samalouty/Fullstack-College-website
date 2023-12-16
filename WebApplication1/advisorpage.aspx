<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="advisorpage.aspx.cs" Inherits="WebApplication1.advisingStudents" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    
    <form id="form1" runat="server">
        <div>
            <asp:Label runat="server" Text="Advisor Page"></asp:Label>
        </div>
        <div>&nbsp;<asp:Button runat="server" OnClick="btnViewAdvising_Click" Text="View Advising Students"></asp:Button></div>
        <div>&nbsp;<asp:Button runat="server" OnClick="btnInsertGradPlan_Click" Text="Insert Graduation Plan"></asp:Button></div>
        <div>&nbsp;<asp:Button runat="server" OnClick="btnInsertCourse_Click" Text="Insert Courses for a graduation plan"></asp:Button></div>
        <div>&nbsp;<asp:Button runat="server" OnClick="btnUpdateGradPlan_Click" Text="Update expected graduation date"></asp:Button></div>
        <div>&nbsp;<asp:Button runat="server" OnClick="btnDeleteCourse_Click" Text=" Delete course from a certain graduation plan" /></div>
        <div>&nbsp;<asp:Button runat="server" OnClick="btnViewAssigned_Click" Text="View all assigned students"></asp:Button></div>
        <div>&nbsp;<asp:Button runat="server" OnClick="btnViewRequests_Click" Text="View all requests"></asp:Button></div>
        <div>&nbsp;<asp:Button runat="server" OnClick="btnViewPending_Click" Text="View all pending requests"></asp:Button></div>
        <div>&nbsp;<asp:Button runat="server" OnClick="btnAppExtraCredit_Click" Text="Approve/ reject extra credit hours request"></asp:Button></div>
        <div>&nbsp;<asp:Button runat="server" OnClick="btnAppExtraCourses_Click" Text="Approve/ reject extra courses request"></asp:Button></div>
        <div>&nbsp;</div>
    </form>
</body>
</html>

