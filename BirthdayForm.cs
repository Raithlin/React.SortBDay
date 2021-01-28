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
			BindingSource bs = new BindingSource();
			bs.DataSource = birthdayList.Birthdays;
			BirthdayGridView.DataSource = bs;
		}
	}
}