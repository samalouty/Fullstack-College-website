<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="advisorpage.aspx.cs" Inherits="WebApplication1.advisingStudents" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel ="stylesheet" href ="GreenStyles.css">
</head>
<body>
    
    <form id="form1" runat="server">
        <div>
            <asp:Label runat="server" Text="Advisor Page"></asp:Label>
        </div>
        <div>&nbsp;<asp:Button runat="server" OnClick="btnViewAdvising_Click" Text="View Advising Students" CssClass="submit-button"></asp:Button></div> <br/>
        <div>&nbsp;<asp:Button runat="server" OnClick="btnInsertGradPlan_Click" Text="Insert Graduation Plan" CssClass="submit-button"></asp:Button></div><br/>
        <div>&nbsp;<asp:Button runat="server" OnClick="btnInsertCourse_Click" Text="Insert Courses for a graduation plan" CssClass="submit-button"></asp:Button></div><br/>
        <div>&nbsp;<asp:Button runat="server" OnClick="btnUpdateGradPlan_Click" Text="Update expected graduation date" CssClass="submit-button"></asp:Button></div><br/>
        <div>&nbsp;<asp:Button runat="server" OnClick="btnDeleteCourse_Click" Text=" Delete course from a certain graduation plan" CssClass="submit-button"/></div><br/>
        <div>&nbsp;<asp:Button runat="server" OnClick="btnViewAssigned_Click" Text="View all assigned students" CssClass="submit-button"></asp:Button></div><br/>
        <div>&nbsp;<asp:Button runat="server" OnClick="btnViewRequests_Click" Text="View all requests" CssClass="submit-button"></asp:Button></div><br/>
        <div>&nbsp;<asp:Button runat="server" OnClick="btnViewPending_Click" Text="View all pending requests" CssClass="submit-button"></asp:Button></div><br/>
        <div>&nbsp;<asp:Button runat="server" OnClick="btnAppExtraCredit_Click" Text="Approve/ reject extra credit hours request" CssClass="submit-button"></asp:Button></div><br/>
        <div>&nbsp;<asp:Button runat="server" OnClick="btnAppExtraCourses_Click" Text="Approve/ reject extra courses request" CssClass="submit-button"></asp:Button></div><br/>
         <asp:Button runat="server" ID="btnRedirect" Text="Log out" CssClass="red-button" PostBackUrl="loginADV.aspx" />

        <div>&nbsp;</div>
    </form>
</body>
</html>

