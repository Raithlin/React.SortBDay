using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace React.SortBDay.Common
{
	internal class BirthdayList
	{
		public List<Birthday> Birthdays { get; set; }
		public SortBy SortedBy { get; set; }

		public BirthdayList()
		{
			Birthdays = new List<Birthday>();
		}

		public decimal AverageAge
		{
			get { return GetAverageAge(); }
		}

		private decimal GetAverageAge()
		{
			if (Birthdays?.Count == 0) return 0;
			decimal totalAge = 0;
			foreach (var birthday in Birthdays)
			{
				totalAge += birthday.Age;
			}
			return totalAge / Birthdays.Count;
		}

		public void Sort(SortBy sortColumn)
		{
			SortedBy = sortColumn;

			switch (SortedBy)
			{
				case SortBy.LastName:
					Birthdays.Sort(new SortByLastName());
					break;

				case SortBy.DateOfBirth:
					Birthdays.Sort(new SortByDateofBirth());
					break;

				default:
					Birthdays.Sort(new SortByFirstName());
					break;
			}
		}

		public enum SortBy
		{
			FirstName,
			LastName,
			DateOfBirth
		}
	}
}