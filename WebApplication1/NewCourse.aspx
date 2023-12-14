<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewCourse.aspx.cs" Inherits="WebApplication1.NewCourse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>New Course</title>
    <style>
        body {
            font-family: 'Arial', sans-serif;
            background-color: #f5f5f5;
            text-align: center;
            margin: 0;
            padding: 0;
        }

        form {
            max-width: 400px;
            margin: 50px auto;
            padding: 20px;
            background-color: #fff;
            border-radius: 5px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
        }

        label {
            display: block;
            margin-bottom: 10px;
        }

        input {
            width: 100%;
            padding: 10px;
            margin-bottom: 15px;
            box-sizing: border-box;
        }

        button {
            background-color: #4caf50;
            color: #fff;
            padding: 10px;
            border: none;
            border-radius: 4px;
            cursor: pointer;
        }

        button:hover {
            background-color: #45a049;
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

        .red-button{
            background-color: #f90b31;
            color: #fff;
            padding: 10px;
            margin: 5px;
            border: none;
            border-radius: 4px;
            cursor: pointer;
        }

        .red-button:hover {
            background-color: #45a049;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>New Course</h2>

            <asp:Label runat="server" Text="Major:"></asp:Label>
            <asp:TextBox runat="server" ID="major" />

            <asp:Label runat="server" Text="Semester:"></asp:Label>
            <asp:TextBox runat="server" ID="semester" />

            <asp:Label runat="server" Text="Credit Hours:"></asp:Label>
            <asp:TextBox runat="server" ID="creditHours" />

            <asp:Label runat="server" Text="Course Name:"></asp:Label>
            <asp:TextBox runat="server" ID="courseName" />

            <asp:Label runat="server" Text="Offered:"></asp:Label>
            <asp:CheckBox runat="server" ID="offered" />

            <asp:Button runat="server" ID="btnSubmit" Text="Submit" OnClientClick="return validateForm();" OnClick="btnSubmit_Click"  CssClass="submit-button" />

            <asp:Button runat="server" ID="btnRedirect" Text="Go to Admin Page" CssClass="red-button" PostBackUrl="AdminPage.aspx" />

        </div>
    </form>
</body>
</html>
