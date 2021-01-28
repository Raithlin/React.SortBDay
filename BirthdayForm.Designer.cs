
namespace React.SortBDay
{
	partial class BirthdayForm
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.BirthdayGridView = new System.Windows.Forms.DataGridView();
			this.AddButton = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.BirthdayGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.AccessibleDescription = "File menu";
			this.fileToolStripMenuItem.AccessibleName = "File Menu";
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.AccessibleDescription = "Close the application";
			this.exitToolStripMenuItem.AccessibleName = "Exit";
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
			this.exitToolStripMenuItem.Text = "E&xit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// BirthdayGridView
			// 
			this.BirthdayGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.BirthdayGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.BirthdayGridView.Location = new System.Drawing.Point(12, 288);
			this.BirthdayGridView.Name = "BirthdayGridView";
			this.BirthdayGridView.Size = new System.Drawing.Size(776, 150);
			this.BirthdayGridView.TabIndex = 1;
			// 
			// AddButton
			// 
			this.AddButton.AccessibleDescription = "Add a person to the list";
			this.AddButton.AccessibleName = "Add Person";
			this.AddButton.Location = new System.Drawing.Point(13, 28);
			this.AddButton.Name = "AddButton";
			this.AddButton.Size = new System.Drawing.Size(75, 23);
			this.AddButton.TabIndex = 2;
			this.AddButton.Text = "&Add";
			this.AddButton.UseVisualStyleBackColor = true;
			this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
			// 
			// BirthdayForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.AddButton);
			this.Controls.Add(this.BirthdayGridView);
			this.Controls.Add(this.menuStrip1);
			this.Name = "BirthdayForm";
			this.Text = "Birthday Sorter";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BirthdayForm_FormClosing);
			this.Load += new System.EventHandler(this.BirthdayForm_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.BirthdayGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.DataGridView BirthdayGridView;
		private System.Windows.Forms.Button AddButton;
	}
}

