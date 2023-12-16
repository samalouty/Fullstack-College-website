<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CourseSlotInstructor.aspx.cs" Inherits="M3.CourseSlotInstructor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>CourseSlotInstructor</title>
    <style>
     body {
         font-family: 'Arial', sans-serif;
         background-color: #f5f5f5;
         margin: 0;
         padding: 0;
     }

     form {
         max-width: 800px;
         margin: 20px auto;
         padding: 20px;
         background-color: #fff;
         border-radius: 5px;
         box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
     }

     h2 {
         color: #333;
     }

     table {
         width: 100%;
         border-collapse: collapse;
         margin-top: 20px;
     }

     th, td {
         padding: 10px;
         border: 1px solid #ddd;
         text-align: left;
     }

     th {
         background-color: #4caf50;
         color: #fff;
     }

     tr:nth-child(even) {
         background-color: #f2f2f2;
     }
                 .submit-button {
    background-color: #4caf50;
    color: #fff;
    padding: 10px;
    border: none;
    border-radius: 4px;
    cursor: pointer;
     }

    .submit-button:hover {
        background-color: #45a049;
    }
 </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Advising_systemConnectionString %>" SelectCommand="SELECT [CourseID], [Course], [instructor_id], [Instructor] FROM [Courses_Slots_Instructor]" ProviderName="<%$ ConnectionStrings:Advising_systemConnectionString.ProviderName %>"></asp:SqlDataSource>
         <div>
            <h2>Course,Slots and Instructors</h2><br />
            <asp:Label ID="Fcourse" runat="server" Text="Filter course"></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="Course" DataValueField="CourseID">
                <asp:ListItem>None</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:Label ID="Finstructor" runat="server" Text="Filter instructors"></asp:Label>
            <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource1" DataTextField="Instructor" DataValueField="instructor_id">
                <asp:ListItem>None</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:Button ID="Show" runat="server" Text="Show Table" OnClick="Show_Click"  CssClass="submit-button"/>
             <br />
             <asp:Button ID="Button1" runat="server" Text="Clear filters" CssClass="submit-button" OnClick="Page_Load" />
            <br /><br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <br />
            <asp:Button ID="Back" runat="server" Text="Back" OnClick="Back_Click"  CssClass="submit-button"/>
        </div>
    </form>
</body>
</html>
