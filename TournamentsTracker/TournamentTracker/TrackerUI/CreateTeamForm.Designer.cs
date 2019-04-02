namespace TrackerUI
{
	partial class CreateTeamForm
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
			this.teamNameValue = new System.Windows.Forms.TextBox();
			this.teamNameLabel = new System.Windows.Forms.Label();
			this.HeaderLabel = new System.Windows.Forms.Label();
			this.addMemberButton = new System.Windows.Forms.Button();
			this.selectTeamMemberDropDown = new System.Windows.Forms.ComboBox();
			this.selectTeamMemberLabel = new System.Windows.Forms.Label();
			this.addNewMemberBox = new System.Windows.Forms.GroupBox();
			this.firstNameValue = new System.Windows.Forms.TextBox();
			this.firstNameLabel = new System.Windows.Forms.Label();
			this.lastNameValue = new System.Windows.Forms.TextBox();
			this.lastNameLabel = new System.Windows.Forms.Label();
			this.emailValue = new System.Windows.Forms.TextBox();
			this.emailLabel = new System.Windows.Forms.Label();
			this.cellPhoneValue = new System.Windows.Forms.TextBox();
			this.cellPhoneLabel = new System.Windows.Forms.Label();
			this.createMemberButton = new System.Windows.Forms.Button();
			this.teamMembersListBox = new System.Windows.Forms.ListBox();
			this.deleteSelectedMemberButton = new System.Windows.Forms.Button();
			this.createTeamtButton = new System.Windows.Forms.Button();
			this.addNewMemberBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// teamNameValue
			// 
			this.teamNameValue.Location = new System.Drawing.Point(40, 83);
			this.teamNameValue.Name = "teamNameValue";
			this.teamNameValue.Size = new System.Drawing.Size(385, 35);
			this.teamNameValue.TabIndex = 13;
			// 
			// teamNameLabel
			// 
			this.teamNameLabel.AutoSize = true;
			this.teamNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.teamNameLabel.Location = new System.Drawing.Point(47, 50);
			this.teamNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.teamNameLabel.Name = "teamNameLabel";
			this.teamNameLabel.Size = new System.Drawing.Size(124, 30);
			this.teamNameLabel.TabIndex = 12;
			this.teamNameLabel.Text = "Team Name";
			// 
			// HeaderLabel
			// 
			this.HeaderLabel.AutoSize = true;
			this.HeaderLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.HeaderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.HeaderLabel.Location = new System.Drawing.Point(31, 0);
			this.HeaderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.HeaderLabel.Name = "HeaderLabel";
			this.HeaderLabel.Size = new System.Drawing.Size(213, 50);
			this.HeaderLabel.TabIndex = 11;
			this.HeaderLabel.Text = "Create Team";
			// 
			// addMemberButton
			// 
			this.addMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.addMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
			this.addMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			this.addMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.addMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addMemberButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.addMemberButton.Location = new System.Drawing.Point(146, 198);
			this.addMemberButton.Name = "addMemberButton";
			this.addMemberButton.Size = new System.Drawing.Size(163, 37);
			this.addMemberButton.TabIndex = 19;
			this.addMemberButton.Text = "Add Member";
			this.addMemberButton.UseVisualStyleBackColor = true;
			// 
			// selectTeamMemberDropDown
			// 
			this.selectTeamMemberDropDown.FormattingEnabled = true;
			this.selectTeamMemberDropDown.Location = new System.Drawing.Point(40, 154);
			this.selectTeamMemberDropDown.Name = "selectTeamMemberDropDown";
			this.selectTeamMemberDropDown.Size = new System.Drawing.Size(385, 38);
			this.selectTeamMemberDropDown.TabIndex = 18;
			// 
			// selectTeamMemberLabel
			// 
			this.selectTeamMemberLabel.AutoSize = true;
			this.selectTeamMemberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.selectTeamMemberLabel.Location = new System.Drawing.Point(47, 121);
			this.selectTeamMemberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.selectTeamMemberLabel.Name = "selectTeamMemberLabel";
			this.selectTeamMemberLabel.Size = new System.Drawing.Size(207, 30);
			this.selectTeamMemberLabel.TabIndex = 17;
			this.selectTeamMemberLabel.Text = "Select Team Member";
			// 
			// addNewMemberBox
			// 
			this.addNewMemberBox.Controls.Add(this.createMemberButton);
			this.addNewMemberBox.Controls.Add(this.cellPhoneValue);
			this.addNewMemberBox.Controls.Add(this.cellPhoneLabel);
			this.addNewMemberBox.Controls.Add(this.emailValue);
			this.addNewMemberBox.Controls.Add(this.emailLabel);
			this.addNewMemberBox.Controls.Add(this.lastNameValue);
			this.addNewMemberBox.Controls.Add(this.lastNameLabel);
			this.addNewMemberBox.Controls.Add(this.firstNameValue);
			this.addNewMemberBox.Controls.Add(this.firstNameLabel);
			this.addNewMemberBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addNewMemberBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.addNewMemberBox.Location = new System.Drawing.Point(40, 241);
			this.addNewMemberBox.Name = "addNewMemberBox";
			this.addNewMemberBox.Size = new System.Drawing.Size(385, 292);
			this.addNewMemberBox.TabIndex = 20;
			this.addNewMemberBox.TabStop = false;
			this.addNewMemberBox.Text = "Add New Member";
			// 
			// firstNameValue
			// 
			this.firstNameValue.Location = new System.Drawing.Point(152, 51);
			this.firstNameValue.Name = "firstNameValue";
			this.firstNameValue.Size = new System.Drawing.Size(210, 43);
			this.firstNameValue.TabIndex = 10;
			// 
			// firstNameLabel
			// 
			this.firstNameLabel.AutoSize = true;
			this.firstNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.firstNameLabel.Location = new System.Drawing.Point(5, 57);
			this.firstNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.firstNameLabel.Name = "firstNameLabel";
			this.firstNameLabel.Size = new System.Drawing.Size(144, 37);
			this.firstNameLabel.TabIndex = 9;
			this.firstNameLabel.Text = "First Name";
			// 
			// lastNameValue
			// 
			this.lastNameValue.Location = new System.Drawing.Point(152, 100);
			this.lastNameValue.Name = "lastNameValue";
			this.lastNameValue.Size = new System.Drawing.Size(210, 43);
			this.lastNameValue.TabIndex = 12;
			// 
			// lastNameLabel
			// 
			this.lastNameLabel.AutoSize = true;
			this.lastNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.lastNameLabel.Location = new System.Drawing.Point(5, 103);
			this.lastNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lastNameLabel.Name = "lastNameLabel";
			this.lastNameLabel.Size = new System.Drawing.Size(142, 37);
			this.lastNameLabel.TabIndex = 11;
			this.lastNameLabel.Text = "Last Name";
			// 
			// emailValue
			// 
			this.emailValue.Location = new System.Drawing.Point(152, 149);
			this.emailValue.Name = "emailValue";
			this.emailValue.Size = new System.Drawing.Size(210, 43);
			this.emailValue.TabIndex = 14;
			// 
			// emailLabel
			// 
			this.emailLabel.AutoSize = true;
			this.emailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.emailLabel.Location = new System.Drawing.Point(5, 152);
			this.emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.emailLabel.Name = "emailLabel";
			this.emailLabel.Size = new System.Drawing.Size(88, 37);
			this.emailLabel.TabIndex = 13;
			this.emailLabel.Text = "Email:";
			// 
			// cellPhoneValue
			// 
			this.cellPhoneValue.Location = new System.Drawing.Point(152, 198);
			this.cellPhoneValue.Name = "cellPhoneValue";
			this.cellPhoneValue.Size = new System.Drawing.Size(210, 43);
			this.cellPhoneValue.TabIndex = 16;
			// 
			// cellPhoneLabel
			// 
			this.cellPhoneLabel.AutoSize = true;
			this.cellPhoneLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.cellPhoneLabel.Location = new System.Drawing.Point(5, 198);
			this.cellPhoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.cellPhoneLabel.Name = "cellPhoneLabel";
			this.cellPhoneLabel.Size = new System.Drawing.Size(138, 37);
			this.cellPhoneLabel.TabIndex = 15;
			this.cellPhoneLabel.Text = "Cellphone";
			// 
			// createMemberButton
			// 
			this.createMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.createMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
			this.createMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			this.createMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.createMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.createMemberButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.createMemberButton.Location = new System.Drawing.Point(106, 247);
			this.createMemberButton.Name = "createMemberButton";
			this.createMemberButton.Size = new System.Drawing.Size(163, 37);
			this.createMemberButton.TabIndex = 20;
			this.createMemberButton.Text = "Create Member";
			this.createMemberButton.UseVisualStyleBackColor = true;
			// 
			// teamMembersListBox
			// 
			this.teamMembersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.teamMembersListBox.FormattingEnabled = true;
			this.teamMembersListBox.ItemHeight = 30;
			this.teamMembersListBox.Location = new System.Drawing.Point(445, 83);
			this.teamMembersListBox.Name = "teamMembersListBox";
			this.teamMembersListBox.Size = new System.Drawing.Size(289, 452);
			this.teamMembersListBox.TabIndex = 21;
			// 
			// deleteSelectedMemberButton
			// 
			this.deleteSelectedMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.deleteSelectedMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
			this.deleteSelectedMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			this.deleteSelectedMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.deleteSelectedMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.deleteSelectedMemberButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.deleteSelectedMemberButton.Location = new System.Drawing.Point(638, 12);
			this.deleteSelectedMemberButton.Name = "deleteSelectedMemberButton";
			this.deleteSelectedMemberButton.Size = new System.Drawing.Size(96, 64);
			this.deleteSelectedMemberButton.TabIndex = 23;
			this.deleteSelectedMemberButton.Text = "Delete Selected";
			this.deleteSelectedMemberButton.UseVisualStyleBackColor = true;
			// 
			// createTeamtButton
			// 
			this.createTeamtButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.createTeamtButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
			this.createTeamtButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			this.createTeamtButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.createTeamtButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.createTeamtButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.createTeamtButton.Location = new System.Drawing.Point(445, 15);
			this.createTeamtButton.Name = "createTeamtButton";
			this.createTeamtButton.Size = new System.Drawing.Size(187, 61);
			this.createTeamtButton.TabIndex = 25;
			this.createTeamtButton.Text = "Create Team";
			this.createTeamtButton.UseVisualStyleBackColor = true;
			// 
			// CreateTeamForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(746, 537);
			this.Controls.Add(this.createTeamtButton);
			this.Controls.Add(this.deleteSelectedMemberButton);
			this.Controls.Add(this.teamMembersListBox);
			this.Controls.Add(this.addNewMemberBox);
			this.Controls.Add(this.addMemberButton);
			this.Controls.Add(this.selectTeamMemberDropDown);
			this.Controls.Add(this.selectTeamMemberLabel);
			this.Controls.Add(this.teamNameValue);
			this.Controls.Add(this.teamNameLabel);
			this.Controls.Add(this.HeaderLabel);
			this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
			this.Name = "CreateTeamForm";
			this.Text = "Create Team  ";
			this.addNewMemberBox.ResumeLayout(false);
			this.addNewMemberBox.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox teamNameValue;
		private System.Windows.Forms.Label teamNameLabel;
		private System.Windows.Forms.Label HeaderLabel;
		private System.Windows.Forms.Button addMemberButton;
		private System.Windows.Forms.ComboBox selectTeamMemberDropDown;
		private System.Windows.Forms.Label selectTeamMemberLabel;
		private System.Windows.Forms.GroupBox addNewMemberBox;
		private System.Windows.Forms.Button createMemberButton;
		private System.Windows.Forms.TextBox cellPhoneValue;
		private System.Windows.Forms.Label cellPhoneLabel;
		private System.Windows.Forms.TextBox emailValue;
		private System.Windows.Forms.Label emailLabel;
		private System.Windows.Forms.TextBox lastNameValue;
		private System.Windows.Forms.Label lastNameLabel;
		private System.Windows.Forms.TextBox firstNameValue;
		private System.Windows.Forms.Label firstNameLabel;
		private System.Windows.Forms.ListBox teamMembersListBox;
		private System.Windows.Forms.Button deleteSelectedMemberButton;
		private System.Windows.Forms.Button createTeamtButton;
	}
}