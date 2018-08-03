using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_EpicSpiesChallenge
{
	public partial class Default : System.Web.UI.Page
	{
		//dummy change 8/2/18 b
		protected void Page_Load(object sender, EventArgs e)
		{
			if ( !Page.IsPostBack)
			{
				// Notice you must add .Date, otherwise you get a date with the time, and the date will not get selected
				// could also be: endDtPreviousCalendar.SelectedDate = DateTime.Today;
				endDtPreviousCalendar.SelectedDate = DateTime.Now.Date;

				DateTime todayPlus14 = DateTime.Today.AddDays(14);
				startDtNewCalendar.SelectedDate = todayPlus14;
				startDtNewCalendar.VisibleDate = todayPlus14;


				DateTime todayPlus21 = DateTime.Today.AddDays(21);
				endDtNewCalendar.SelectedDate = todayPlus21;
				endDtNewCalendar.VisibleDate = todayPlus21;
			}
		}

		protected void AssignSpyButton_Click(object sender, EventArgs e)
		{
			DateTime dtPlus14 = endDtPreviousCalendar.SelectedDate.AddDays(14);
			if (startDtNewCalendar.SelectedDate < dtPlus14)
			{
				resultLabel.Text = "Error: Must allow at least two weeks between previous assignment and new assignment";
				startDtNewCalendar.SelectedDate = dtPlus14;
				startDtNewCalendar.VisibleDate = dtPlus14;
			}
			else
			{
				TimeSpan assignmentLength = endDtNewCalendar.SelectedDate.Subtract(startDtNewCalendar.SelectedDate);
				double payment = assignmentLength.Days * 500;
				// .TotalDays versus .Days .. .TotalDays does fractions of a day
				
				if (assignmentLength.TotalDays > 21)
				{
					payment += 1000.0;
				}

				//Formatting Currency
				//http://is.gd/formattingcurrency
				resultLabel.Text = String.Format("Assignment of {0} to assignment Project {1} " +
					"is authorized. Budget total Total: " +
					"{2:C}", 
					spyCodeNameTextBox.Text, newAssignmentNameTextBox.Text, payment);

			}
		}
	}
}