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

		public BirthdayList()
		{
			Birthdays = new List<Birthday>();
		}
	}
}