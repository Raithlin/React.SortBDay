using System;
using System.Configuration;
using System.Windows.Forms;
using React.SortBDay.Common;

namespace React.SortBDay
{
	public partial class BirthdayForm : Form
	{
		private readonly Log log;
		private BirthdayList birthdayList;

		private delegate void SafeCallDelegate(BirthdayList birthdayList);

		public BirthdayForm()
		{
			InitializeComponent();
			log = new Log();
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void BirthdayForm_Load(object sender, EventArgs e)
		{
			try
			{
				if (LoadBirthdays())
				{
					SetBirthdays();
				}
				else
				{
					MessageBox.Show("No birthdays found. Starting from scratch...", "Hi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch (Exception ex)
			{
				log.LogInstance.Error(ex, nameof(BirthdayForm_Load));
				MessageBox.Show("An error occurred while loading. Chances are we were not able to load any birthdays for you.", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void AddButton_Click(object sender, EventArgs e)
		{
			using (var childForm = new AddPersonForm(log))
			{
				if (childForm.ShowDialog() == DialogResult.OK)
				{
					var newBirthday = childForm.Birthday;
					birthdayList.Birthdays.Add(newBirthday);
					SaveBirthdays();
					SetBirthdays();
				}
			}
		}

		private bool LoadBirthdays()
		{
			try
			{
				using (FileIO fileIO = new FileIO(ConfigurationManager.AppSettings["DBFilePath"], log))
				{
					birthdayList = fileIO.LoadBirthdays();
				}
				return true;
			}
			catch (Exception ex)
			{
				log.LogInstance.Error(ex, nameof(LoadBirthdays));
				birthdayList = new BirthdayList();
				SetBirthdays();
				return false;
			}
		}

		private async void SaveBirthdays()
		{
			using (FileIO fileIO = new FileIO(ConfigurationManager.AppSettings["DBFilePath"], log))
			{
				await fileIO.SaveBirthdays(birthdayList).ConfigureAwait(false);
			}
		}

		private void BirthdayForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			SaveBirthdays();
		}

		private void SetBirthdays()
		{
			BirthdayGridView.DataSource = new BindingSource
			{
				DataSource = birthdayList.Birthdays
			};
			SetAverageAge();
		}

		private void SetAverageAge()
		{
			AverageAgeLabel.Text = birthdayList.Birthdays.Count == 0 ? string.Empty : $"Average age: {birthdayList.AverageAge:N0} years";
		}

		private void BirthdayGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (e.ColumnIndex == 3) return; //No sorting on Age because we can

			birthdayList.Sort((BirthdayList.SortBy)e.ColumnIndex);
			SetBirthdays();
		}
	}
}