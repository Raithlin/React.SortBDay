using System;
using System.Windows.Forms;
using React.SortBDay.Common;

namespace React.SortBDay
{
	public partial class AddPersonForm : Form
	{
		private readonly Log log;
		public Birthday Birthday { get; set; }

		public AddPersonForm(Log logInstance)
		{
			InitializeComponent();
			log = logInstance;
		}

		private void CancelButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void AcceptButton_Click(object sender, EventArgs e)
		{
			try
			{
				if (string.IsNullOrWhiteSpace(FirstNameTextBox.Text))
				{
					MessageBox.Show("Please enter your first name.", "We need a name!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
				if (DateOfBirthPicker.Value > DateTime.Now)
				{
					MessageBox.Show("You haven't even been born yet!", "Date of birth must be in the past", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}

				this.Birthday = new Birthday { FirstName = FirstNameTextBox.Text, LastName = LastNameTextBox.Text, DateofBirth = DateOfBirthPicker.Value };
				this.DialogResult = DialogResult.OK;
				this.Close();
			}
			catch (Exception ex)
			{
				log.LogInstance.Error(ex, nameof(AcceptButton_Click));
				throw;
			}
		}

		private void AddPersonForm_Load(object sender, EventArgs e)
		{
			FirstNameTextBox.Clear();
			LastNameTextBox.Clear();
			DateOfBirthPicker.Value = DateTime.Today;
		}
	}
}