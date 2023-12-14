using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class AdminPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnListAdvisors_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdvisorList.aspx");

        }

        protected void btnListStudentsAdvisors_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdvisorWithStudent.aspx");
        }

        protected void btnListPendingRequests_Click(object sender, EventArgs e)
        {
            Response.Redirect("PendingRequests.aspx");
        }

        protected void btnAddNewSemester_Click(object sender, EventArgs e)
        {
            Response.Redirect("NewSem.aspx");
        }

        protected void btnAddNewCourse_Click(object sender, EventArgs e)
        {
            Response.Redirect("NewCourse.aspx");

        }

        protected void btnLinkInstructorToCourse_Click(object sender, EventArgs e)
        {
            Response.Redirect("InstToCourse.aspx");
        }

        protected void btnLinkStudentToAdvisor_Click(object sender, EventArgs e)
        {
            Response.Redirect("StudToAdv.aspx");
        }

        protected void btnLinkStudentToCourseInstructor_Click(object sender, EventArgs e)
        {
            Response.Redirect("StudToCourseInst.aspx");
        }

        protected void btnViewInstructorDetails_Click(object sender, EventArgs e)
        {
            // Implement logic to view all details of instructors along with their assigned courses
        }

        protected void btnFetchAllSemesters_Click(object sender, EventArgs e)
        {
            // Implement logic to fetch all semesters along with their offered courses
        }















        protected void btnDeleteCourse_Click(object sender, EventArgs e)
        {
            // Implement logic to delete a course along with its related slots
        }

        protected void btnDeleteSlot_Click(object sender, EventArgs e)
        {
            // Implement logic to delete a slot of a certain course if the course isn’t offered in the current semester
        }

        protected void btnAddMakeupExam_Click(object sender, EventArgs e)
        {
            // Implement logic to add a makeup exam for a certain course
        }

        protected void btnViewPaymentDetails_Click(object sender, EventArgs e)
        {
            // Implement logic to view details for all payments along with their corresponding students
        }

        protected void btnIssueInstallments_Click(object sender, EventArgs e)
        {
            // Implement logic to issue installments as per the number of installments for a certain payment
        }

        protected void btnUpdateStudentStatus_Click(object sender, EventArgs e)
        {
            // Implement logic to update a student status based on his/her financial status
        }

        protected void btnViewActiveStudents_Click(object sender, EventArgs e)
        {
            // Implement logic to fetch all details of active students
        }

        protected void btnViewGraduationPlans_Click(object sender, EventArgs e)
        {
            // Implement logic to view all graduation plans along with their initiated advisors
        }

        protected void btnViewTranscriptDetails_Click(object sender, EventArgs e)
        {
            // Implement logic to view all students transcript details
        }

        protected void btnFetchAllSemesters2_Click(object sender, EventArgs e)
        {
            // Implement logic to fetch all semesters along with their offered courses
        }
    }
}