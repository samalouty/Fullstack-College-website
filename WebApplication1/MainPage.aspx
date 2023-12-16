    <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="M3.MainPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home Page</title>
    <style>
        body {
            font-family: 'Arial', sans-serif;
            background-color: #f5f5f5;
            text-align: center;
            margin: 0;
            padding: 0;
        }

        .form {
            background-color: #ffffff;
            width: 300px;
            margin: 50px auto;
            padding: 20px;
            border-radius: 5px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
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

    .log-button {
      background-color: #FF5A5A;
  color: #fff;
  padding: 10px;
  border: none;
  border-radius: 4px;
  cursor: pointer;
   }

  .log-button:hover {
      background-color: #ff0000;
  }
    </style>
</head>
<body>
    <form id="form1" runat="server">
       <div class="form">
            <h2>Home Page</h2><br />

            <asp:Button ID="GP" runat="server" OnClick="ViewGP" Text="Graduation Plan" CssClass="submit-button"/><br /><br />
            <asp:Button ID="UI" runat="server" OnClick="ViewUI" Text="Upcoming Installment" CssClass="submit-button"/><br /> <br />
            <asp:Button ID="Exams" runat="server" OnClick="ViewE" Text="Exams" CssClass="submit-button"/><br /><br />
            <asp:Button ID="MR" runat="server" OnClick="ViewMR" Text="Makeup Registration" CssClass="submit-button"/><br /><br />
            <asp:Button ID="CSI" runat="server" OnClick="ViewCSI" Text="Courses,Slots and Instructors" CssClass="submit-button"/><br /><br />
            <asp:Button ID="CI" runat="server" OnClick="ViewCI" Text="Choose Instructor" CssClass="submit-button"/><br /><br />
            <asp:Button ID="CP" runat="server" OnClick="ViewCP" Text="Course Prerequisites" CssClass="submit-button"/><br /><br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Back" CssClass="submit-button" OnClick="Button1_Click"/>
            <br />
            <br />
            <asp:Button ID="Logout" runat="server" Text="Logout" OnClick="Logout_Click" CssClass="log-button"/>
        </div>

    </form>
</body>
</html>