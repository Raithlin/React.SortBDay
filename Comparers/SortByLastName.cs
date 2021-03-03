using System;
using System.Collections.Generic;
using React.SortBDay.Common;

namespace React.SortBDay
{
	public class SortByLastName : IComparer<Birthday>
	{
		public int Compare(Birthday x, Birthday y)
		{
			return x.LastName.CompareTo(y.LastName);
		}
	}
}