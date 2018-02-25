using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ConditionalRadioButtonChallenge
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (pencilRadioButton.Checked)
                resultLabel.Text = "You have selected pencil.";
            else if (penRadioButton.Checked)
                resultLabel.Text = "You have selected pen.";
            else if (phoneRadioButton.Checked)
                resultLabel.Text = "You have selected phone.";
            else if (tabletRadioButton.Checked)
                resultLabel.Text = "You have selected tablet";
            else resultLabel.Text = "Please make your selection.";
        }
    }
}
    