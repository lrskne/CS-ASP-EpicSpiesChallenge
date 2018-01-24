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
		protected void Page_Load(object sender, EventArgs e)
		{
			if ( !Page.IsPostBack)
			{
				// Notice you must add .Date, otherwise you get a date with the time, and the date will not get selected
				endDtPreviousCalendar.SelectedDate = DateTime.Today;

				DateTime todayPlus14 = DateTime.Today.AddDays(14);
				string stringTodayPlus14 = todayPlus14.ToString();
				startDtNewCalendar.SelectedDate = todayPlus14;
				startDtNewCalendar.VisibleDate = DateTime.Parse(todayPlus14.Month.ToString() + "/" +
					todayPlus14.Day + "/" + todayPlus14.Year.ToString());

				DateTime todayPlus21 = DateTime.Today.AddDays(21);
				endDtNewCalendar.SelectedDate = todayPlus21;
				endDtNewCalendar.VisibleDate = DateTime.Parse(todayPlus21.Month.ToString() + "/" +
					todayPlus21.Day + "/" + todayPlus21.Year.ToString());
			}
		}

		protected void AssignSpyButton_Click(object sender, EventArgs e)
		{
			DateTime Plus14 = startDtNewCalendar.SelectedDate.AddDays(14);
			if (startDtNewCalendar.SelectedDate < Plus14)
			{ resultLabel.Text = "New Start Date is too soon"; }
		}
	}
}