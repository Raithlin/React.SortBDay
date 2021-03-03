using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace React.SortBDay.Common
{
	public class Birthday
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public DateTime DateofBirth { get; set; }
		public int Age { get { return GetCurrentAge(); } }

		private int GetCurrentAge()
		{
			if (DateofBirth == default) throw new ArgumentException("DateofBirth must not be null");
			return (DateofBirth.Month == DateTime.Today.Month && DateofBirth.Day < DateTime.Today.Day)
				|| DateofBirth.Month < DateTime.Today.Month
				? DateTime.Today.Year - DateofBirth.Year
				: DateTime.Today.Year - DateofBirth.Year - 1;
		}
	}
}