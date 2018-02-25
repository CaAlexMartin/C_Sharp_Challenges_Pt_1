using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeDaysBetweenDates
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void goButton_Click(object sender, EventArgs e)
        {

          
            if (dateCalendar1.SelectedDate > dateCalendar2.SelectedDate)
                {
                resultLabel.Text = "It has been " + dateCalendar1.SelectedDate
                .Subtract(dateCalendar2.SelectedDate)
                .TotalDays.ToString() + " days.";
            }
            else
            {
                resultLabel.Text = "It has been " + dateCalendar2.SelectedDate
                .Subtract(dateCalendar1.SelectedDate)
                .TotalDays.ToString() + " days.";
            }

                    }
    }
}