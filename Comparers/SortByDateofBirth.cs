using System;
using System.Collections.Generic;

using React.SortBDay.Common;

namespace React.SortBDay
{
	public class SortByDateofBirth : IComparer<Birthday>
	{
		public int Compare(Birthday x, Birthday y)
		{
			return x.DateofBirth.CompareTo(y.DateofBirth);
		}
	}
}