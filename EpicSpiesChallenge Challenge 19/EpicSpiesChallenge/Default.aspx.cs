using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EpicSpiesChallenge
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
            
        {
            if (!Page.IsPostBack)
            {
                previousAssignmentCalendar.SelectedDate = DateTime.Today;
                newAssignmentCalendar.SelectedDate = DateTime.Today.AddDays(14);
                projectedCalendar.SelectedDate = DateTime.Today.AddDays(21);
            }
        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            TimeSpan totalDaysOfAssignment = projectedCalendar.SelectedDate.Subtract(newAssignmentCalendar.SelectedDate);
            double totalCost = totalDaysOfAssignment.TotalDays * 500.0;
            if (totalDaysOfAssignment.TotalDays > 21)
            {
                totalCost += 1000.0;
            }


            resultLabel.Text= String.Format("Assignment of {0} has been approved for Project {1}. Your budget is {2:C}",
            spyTextBox.Text, projectTextBox.Text, totalCost);

            TimeSpan timeBetweenAssignments = newAssignmentCalendar.SelectedDate.Subtract(previousAssignmentCalendar.SelectedDate);
            if (timeBetweenAssignments.TotalDays < 14)
            {
                resultLabel.Text = "Error, Must allow at least 2 weeks inbetween previous assignment and new assignment.";

                DateTime earliestNewAssignmentDate = previousAssignmentCalendar.SelectedDate.AddDays(14);

                newAssignmentCalendar.SelectedDate = earliestNewAssignmentDate;
                newAssignmentCalendar.VisibleDate = earliestNewAssignmentDate;
            }
                    }
    }
}