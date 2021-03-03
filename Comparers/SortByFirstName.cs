using System;
using System.Collections.Generic;
using React.SortBDay.Common;

namespace React.SortBDay
{
	public class SortByFirstName : IComparer<Birthday>
	{
		public int Compare(Birthday x, Birthday y)
		{
			return x.FirstName.CompareTo(y.FirstName);
		}
	}
}