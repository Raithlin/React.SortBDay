
namespace React.SortBDay
{
	partial class AddPersonForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.FirstNameTextBox = new System.Windows.Forms.TextBox();
			this.LastNameTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.CancelCloseButton = new System.Windows.Forms.Button();
			this.SaveButton = new System.Windows.Forms.Button();
			this.DateOfBirthPicker = new System.Windows.Forms.DateTimePicker();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.FirstNameTextBox, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.LastNameTextBox, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.CancelCloseButton, 2, 3);
			this.tableLayoutPanel1.Controls.Add(this.SaveButton, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.DateOfBirthPicker, 1, 2);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 4;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(295, 112);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(15, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 26);
			this.label1.TabIndex = 0;
			this.label1.Text = "First Name";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(24, 26);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 26);
			this.label2.TabIndex = 1;
			this.label2.Text = "Last Name";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// FirstNameTextBox
			// 
			this.FirstNameTextBox.Location = new System.Drawing.Point(88, 3);
			this.FirstNameTextBox.Name = "FirstNameTextBox";
			this.FirstNameTextBox.Size = new System.Drawing.Size(100, 20);
			this.FirstNameTextBox.TabIndex = 5;
			// 
			// LastNameTextBox
			// 
			this.LastNameTextBox.Location = new System.Drawing.Point(88, 29);
			this.LastNameTextBox.Name = "LastNameTextBox";
			this.LastNameTextBox.Size = new System.Drawing.Size(100, 20);
			this.LastNameTextBox.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(3, 52);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(79, 26);
			this.label3.TabIndex = 2;
			this.label3.Text = "Date of Birth";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// CancelCloseButton
			// 
			this.CancelCloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.CancelCloseButton.Location = new System.Drawing.Point(194, 81);
			this.CancelCloseButton.Name = "CancelCloseButton";
			this.CancelCloseButton.Size = new System.Drawing.Size(75, 23);
			this.CancelCloseButton.TabIndex = 4;
			this.CancelCloseButton.Text = "&Cancel";
			this.CancelCloseButton.UseVisualStyleBackColor = true;
			this.CancelCloseButton.Click += new System.EventHandler(this.CancelButton_Click);
			// 
			// SaveButton
			// 
			this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.SaveButton.Location = new System.Drawing.Point(113, 81);
			this.SaveButton.Name = "SaveButton";
			this.SaveButton.Size = new System.Drawing.Size(75, 23);
			this.SaveButton.TabIndex = 3;
			this.SaveButton.Text = "&Save";
			this.SaveButton.UseVisualStyleBackColor = true;
			this.SaveButton.Click += new System.EventHandler(this.AcceptButton_Click);
			// 
			// DateOfBirthPicker
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.DateOfBirthPicker, 2);
			this.DateOfBirthPicker.Location = new System.Drawing.Point(88, 55);
			this.DateOfBirthPicker.Name = "DateOfBirthPicker";
			this.DateOfBirthPicker.Size = new System.Drawing.Size(200, 20);
			this.DateOfBirthPicker.TabIndex = 7;
			// 
			// AddPersonForm
			// 
			this.AcceptButton = this.SaveButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.CancelCloseButton;
			this.ClientSize = new System.Drawing.Size(295, 112);
			this.ControlBox = false;
			this.Controls.Add(this.tableLayoutPanel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AddPersonForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "New Birthday";
			this.Load += new System.EventHandler(this.AddPersonForm_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox FirstNameTextBox;
		private System.Windows.Forms.TextBox LastNameTextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button CancelCloseButton;
		private System.Windows.Forms.Button SaveButton;
		private System.Windows.Forms.DateTimePicker DateOfBirthPicker;
	}
}