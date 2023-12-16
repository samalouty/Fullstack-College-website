<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewAssignedStudentsForMajor.aspx.cs" Inherits="WebApplication1.ViewAssignedStudentsForMajor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>My Advising Students</h2>
              <asp:Label runat="server" Text="Major:"></asp:Label>
              <asp:TextBox runat="server" ID="major" />
              <asp:Button runat="server" ID="btnSubmit" Text="Submit" OnClick="submit" />

        </div>
    </form>
</body>
</html>