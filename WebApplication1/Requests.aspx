<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Requests.aspx.cs" Inherits="m3.Requests" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
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
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="form">
            <asp:Label ID="title" runat="server" Text="Course Request "></asp:Label>
             <br /> <br />
       <asp:Label ID="courseid" runat="server" Text="Courseid"></asp:Label>
 <br />
   <asp:TextBox ID="box1" runat="server"></asp:TextBox>
 <br /> <br />
       <asp:Label ID="Comment" runat="server" Text="Comments"></asp:Label>
   <br />
       <asp:TextBox ID="box2" runat="server"></asp:TextBox>
  <br /> <br />
   <asp:Button ID="Click" runat="server" Text="Add your Course request" OnClick="Click_Click"   CssClass="submit-button" />
  <br /> <br />  <br /> <br />
       <asp:Label ID="title1" runat="server" Text="Credit Hours Request "></asp:Label>
  <br /> <br />
       <asp:Label ID="credithours" runat="server" Text="CreditHours"></asp:Label>
  <br />
   <asp:TextBox ID="box3" runat="server"></asp:TextBox>
  <br /> <br />
       <asp:Label ID="Comment0" runat="server" Text="Comments"></asp:Label>
   <br /> 
   <asp:TextBox ID="box4" runat="server"></asp:TextBox>
   <br /> <br />
   <asp:Button ID="Click0" runat="server" Text="Add your Credit Hours request" OnClick="Click0_Click"   CssClass="submit-button"/>
   <br /> <br />  <br /> <br />
       <asp:Button ID="Back" runat="server" Text="Back" OnClick="Back_Click"   CssClass="submit-button" />

        </div>
    </form>
</body>
</html>
