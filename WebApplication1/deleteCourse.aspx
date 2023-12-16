<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="deleteCourse.aspx.cs" Inherits="WebApplication1.deleteCourse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Delete certain course from certain graduation plan of certain student"></asp:Label>
        <div>
            <asp:Label ID="Label2" runat="server" Text="Student ID:"></asp:Label>
            <br />
            <asp:TextBox ID="student_id" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Semester Code:"></asp:Label>
            <br />
            <asp:TextBox ID="semester_code" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Course ID:"></asp:Label>
            <br />
            <asp:TextBox ID="course_id" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" OnClick="btn_deleteCourse_Click" runat="server" Text="Delete" />
        </div>
            <asp:Button runat="server" ID="btnRedirect" Text="Go to Advisor page" CssClass="red-button" PostBackUrl="advisorpage.aspx" />

    </form>
</body>
</html>
