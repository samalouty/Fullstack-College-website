<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminPage.aspx.cs" Inherits="WebApplication1.AdminPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin Page</title>
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

        .button {
            background-color: #4caf50;
            color: #fff;
            padding: 10px;
            margin: 5px;
            border: none;
            border-radius: 4px;
            cursor: pointer;
        }

        .button:hover {
            background-color: #45a049;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
       <div class="form">
            <h2>Admin Functions Part 1</h2><br />

            <asp:Button runat="server" ID="btnListAdvisors" Text="List All Advisors" CssClass="button" OnClick="btnListAdvisors_Click" /><br />
            <asp:Button runat="server" ID="btnListStudentsAdvisors" Text="List Students with Advisors" CssClass="button" OnClick="btnListStudentsAdvisors_Click" /><br />
            <asp:Button runat="server" ID="btnListPendingRequests" Text="List All Pending Requests" CssClass="button" OnClick="btnListPendingRequests_Click" /><br />
            <asp:Button runat="server" ID="btnAddNewSemester" Text="Add New Semester" CssClass="button" OnClick="btnAddNewSemester_Click" /><br />
            <asp:Button runat="server" ID="btnAddNewCourse" Text="Add New Course" CssClass="button" OnClick="btnAddNewCourse_Click" /><br />
            <asp:Button runat="server" ID="btnLinkInstructorToCourse" Text="Link Instructor to Course" CssClass="button" OnClick="btnLinkInstructorToCourse_Click" /><br />
            <asp:Button runat="server" ID="btnLinkStudentToAdvisor" Text="Link Student to Advisor" CssClass="button" OnClick="btnLinkStudentToAdvisor_Click" /><br />
            <asp:Button runat="server" ID="btnLinkStudentToCourseInstructor" Text="Link Student to Course with Instructor" CssClass="button" OnClick="btnLinkStudentToCourseInstructor_Click" /><br />
            <asp:Button runat="server" ID="btnViewInstructorDetails" Text="View Instructor Details" CssClass="button" OnClick="btnViewInstructorDetails_Click" /><br />
            <asp:Button runat="server" ID="btnFetchAllSemesters" Text="Fetch All Semesters with Courses" CssClass="button" OnClick="btnFetchAllSemesters_Click" /><br />
        </div>

         <div class="form">
                <h2>Admin Functions Part 2</h2><br />

                <asp:Button runat="server" ID="btnDeleteCourse" Text="Delete a Course with Slots" CssClass="button" OnClick="btnDeleteCourse_Click" /><br />
                <asp:Button runat="server" ID="btnDeleteSlot" Text="Delete Slot of a Course" CssClass="button" OnClick="btnDeleteSlot_Click" /><br />
                <asp:Button runat="server" ID="btnAddMakeupExam" Text="Add Makeup Exam for a Course" CssClass="button" OnClick="btnAddMakeupExam_Click" /><br />
                <asp:Button runat="server" ID="btnViewPaymentDetails" Text="View Payment Details" CssClass="button" OnClick="btnViewPaymentDetails_Click" /><br />
                <asp:Button runat="server" ID="btnIssueInstallments" Text="Issue Installments for Payment" CssClass="button" OnClick="btnIssueInstallments_Click" /><br />
                <asp:Button runat="server" ID="btnUpdateStudentStatus" Text="Update Student Status" CssClass="button" OnClick="btnUpdateStudentStatus_Click" /><br />
                <asp:Button runat="server" ID="btnViewActiveStudents" Text="View Active Students" CssClass="button" OnClick="btnViewActiveStudents_Click" /><br />
                <asp:Button runat="server" ID="btnViewGraduationPlans" Text="View Graduation Plans" CssClass="button" OnClick="btnViewGraduationPlans_Click" /><br />
                <asp:Button runat="server" ID="btnViewTranscriptDetails" Text="View Transcript Details" CssClass="button" OnClick="btnViewTranscriptDetails_Click" /><br />
                <asp:Button runat="server" ID="btnFetchAllSemesters2" Text="Fetch All Semesters with Courses" CssClass="button" OnClick="btnFetchAllSemesters2_Click" /><br />
            </div>


    </form>
</body>
</html>
