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

		public void Sort(SortBy sortColumn)
		{
			List<Birthday> sortedList = new List<Birthday>();
			foreach (var birthday in Birthdays)
			{
				if (sortedList.Count == 0)
				{
					sortedList.Add(birthday);
					continue;
				}
				bool inserted = false;
				switch (sortColumn)
				{
					case SortBy.FirstName:
						for (int i = 0; i < sortedList.Count; i++)
						{
							if (Convert.ToChar(birthday.FirstName.Substring(0, 1)) <= Convert.ToChar(sortedList[i].FirstName.Substring(0, 1)))
							{
								sortedList.Insert(i - 1, birthday);
								inserted = true;
								break;
							}
						}
						if (!inserted)
							sortedList.Add(birthday);
						break;

					case SortBy.LastName:
						for (int i = 0; i < sortedList.Count; i++)
						{
							if (Convert.ToChar(birthday.LastName.Substring(0, 1)) <= Convert.ToChar(sortedList[i].LastName.Substring(0, 1)))
							{
								sortedList.Insert(i - 1, birthday);
								inserted = true;
								break;
							}
						}
						if (!inserted)
							sortedList.Add(birthday);
						break;

					case SortBy.DateOfBirth:
						for (int i = 0; i < sortedList.Count; i++)
						{
							if (birthday.DateofBirth <= sortedList[i].DateofBirth)
							{
								sortedList.Insert(i - 1, birthday);
								inserted = true;
								break;
							}
						}
						if (!inserted)
							sortedList.Add(birthday);
						break;

					default:
						break;
				}
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