<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="insertCourses.aspx.cs" Inherits="WebApplication1.insertCourses" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text=" Insert courses for a specific graduation plan.
"></asp:Label>
        </div>
        <asp:Label ID="Label2" runat="server" Text="Student ID:"></asp:Label>
        <br />
        <asp:TextBox ID="student_id" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Semester Code:"></asp:Label>
        <br />
        <asp:TextBox ID="semester_code" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Course Name:"></asp:Label>
        <br />
     
        <asp:TextBox ID="course_name" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" OnClick="btn_insertCourse_Click" runat="server" Text="Insert Course" />
    </form>
</body>
</html>
