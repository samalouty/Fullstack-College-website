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
            Response.Redirect("ViewInstDetails.aspx");
        }

        protected void btnFetchAllSemesters_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewSemCourses.aspx");
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            Response.Redirect("login1.aspx");
        }















        protected void btnDeleteCourse_Click(object sender, EventArgs e)
        {
            Response.Redirect("Course_Delete.aspx");
        }

        protected void btnDeleteSlot_Click(object sender, EventArgs e)
        {
            Response.Redirect("Slot_Delete.aspx");
        }

        protected void btnAddMakeupExam_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddMakeup_Exam.aspx");
        }

        protected void btnViewPaymentDetails_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewPaymentDetails.aspx");
        }

        protected void btnIssueInstallments_Click(object sender, EventArgs e)
        {
            Response.Redirect("IssueInstallment.aspx");
        }

        protected void btnUpdateStudentStatus_Click(object sender, EventArgs e)
        {
            Response.Redirect("Updatestatus.aspx");
        }

        protected void btnViewActiveStudents_Click(object sender, EventArgs e)
        {
            Response.Redirect("Fetchactivestudents.aspx");
        }

        protected void btnViewGraduationPlans_Click(object sender, EventArgs e)
        {
            Response.Redirect("Viewgraduationplans.aspx");
        }

        protected void btnViewTranscriptDetails_Click(object sender, EventArgs e)
        {
            Response.Redirect("Viewtranscript.aspx");
        }

        protected void btnFetchAllSemesters2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Fetchsemesters.aspx");
        }
    }
}