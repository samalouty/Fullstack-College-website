<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InstToCourse.aspx.cs" Inherits="WebApplication1.InstToCourse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Instructor to Course</title>
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
        <div>
            <h2>Instructor to Course</h2>

            <asp:Label runat="server" Text="Course ID:"></asp:Label>
            <asp:TextBox runat="server" ID="courseId" />
           

            <asp:Label runat="server" Text="Instructor ID:"></asp:Label>
            <asp:TextBox runat="server" ID="instructorId" />
            

            <asp:Label runat="server" Text="Slot ID:"></asp:Label>
            <asp:TextBox runat="server" ID="slotId" />
            

            <asp:Button runat="server" ID="btnSubmit" Text="Submit" OnClientClick="return validateForm();" OnClick="btnSubmit_Click" CssClass="submit-button" />
        </div>
    </form>
</body>
</html>
