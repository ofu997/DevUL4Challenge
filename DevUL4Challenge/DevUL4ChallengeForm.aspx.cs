using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DevUL4Challenge
{
	public partial class DevUL4ChallengeForm : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
		}
		DateTime firstCalendarDate;

		protected void Calendar1_SelectionChanged(object sender, EventArgs e)
		{
			//DateTime firstCalendarDate = Calendar1.SelectedDate;
		}

		protected void Calendar2_SelectionChanged(object sender, EventArgs e)
		{
			//DateTime secondCalendarDate = Calendar2.SelectedDate;
			//double difference = (secondCalendarDate - firstCalendarDate).TotalDays;
			//.Subtract(firstCalendarDate);
			//resultLabel.Text = difference.ToString();
		}

		protected void okButton_Click(object sender, EventArgs e)
		{
			if (Calendar1.SelectedDate > Calendar2.SelectedDate)
			{
				DateTime first = Calendar1.SelectedDate;
				DateTime second = Calendar2.SelectedDate;
				TimeSpan difference = first - second;
				double days = difference.TotalDays;
				string result = days.ToString();
				resultLabel.Text = result;
			}
			else
			{
				resultLabel.Text = Calendar2.SelectedDate
					.Subtract(Calendar1.SelectedDate)
					.TotalDays
					.ToString();
			}
		}
	}
}