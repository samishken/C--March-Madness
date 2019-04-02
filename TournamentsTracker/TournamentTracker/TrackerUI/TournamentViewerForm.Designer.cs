namespace TrackerUI
{
	partial class TournamentViewerForm
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
			this.HeaderLabel = new System.Windows.Forms.Label();
			this.TournamentName = new System.Windows.Forms.Label();
			this.roundLabel = new System.Windows.Forms.Label();
			this.roundDropDown = new System.Windows.Forms.ComboBox();
			this.unplayedOnlyCheckBox = new System.Windows.Forms.CheckBox();
			this.matchUpListBox = new System.Windows.Forms.ListBox();
			this.teamOneName = new System.Windows.Forms.Label();
			this.teamOneScoreLabel = new System.Windows.Forms.Label();
			this.teamOneScoreValue = new System.Windows.Forms.TextBox();
			this.teamTwoScoreText = new System.Windows.Forms.TextBox();
			this.teamTwoScoreLabel = new System.Windows.Forms.Label();
			this.teamTwoName = new System.Windows.Forms.Label();
			this.vsLabel = new System.Windows.Forms.Label();
			this.scoreButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// HeaderLabel
			// 
			this.HeaderLabel.AutoSize = true;
			this.HeaderLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.HeaderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.HeaderLabel.Location = new System.Drawing.Point(32, 43);
			this.HeaderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.HeaderLabel.Name = "HeaderLabel";
			this.HeaderLabel.Size = new System.Drawing.Size(214, 50);
			this.HeaderLabel.TabIndex = 0;
			this.HeaderLabel.Text = "Tournament:";
			// 
			// TournamentName
			// 
			this.TournamentName.AutoSize = true;
			this.TournamentName.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TournamentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.TournamentName.Location = new System.Drawing.Point(239, 43);
			this.TournamentName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.TournamentName.Name = "TournamentName";
			this.TournamentName.Size = new System.Drawing.Size(150, 50);
			this.TournamentName.TabIndex = 1;
			this.TournamentName.Text = "<none>";
			// 
			// roundLabel
			// 
			this.roundLabel.AutoSize = true;
			this.roundLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.roundLabel.Location = new System.Drawing.Point(24, 109);
			this.roundLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.roundLabel.Name = "roundLabel";
			this.roundLabel.Size = new System.Drawing.Size(94, 37);
			this.roundLabel.TabIndex = 2;
			this.roundLabel.Text = "Round";
			// 
			// roundDropDown
			// 
			this.roundDropDown.FormattingEnabled = true;
			this.roundDropDown.Location = new System.Drawing.Point(125, 101);
			this.roundDropDown.Name = "roundDropDown";
			this.roundDropDown.Size = new System.Drawing.Size(252, 45);
			this.roundDropDown.TabIndex = 3;
			// 
			// unplayedOnlyCheckBox
			// 
			this.unplayedOnlyCheckBox.AutoSize = true;
			this.unplayedOnlyCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.unplayedOnlyCheckBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.unplayedOnlyCheckBox.Location = new System.Drawing.Point(125, 162);
			this.unplayedOnlyCheckBox.Name = "unplayedOnlyCheckBox";
			this.unplayedOnlyCheckBox.Size = new System.Drawing.Size(209, 41);
			this.unplayedOnlyCheckBox.TabIndex = 4;
			this.unplayedOnlyCheckBox.Text = "Unplayed Only";
			this.unplayedOnlyCheckBox.UseVisualStyleBackColor = true;
			// 
			// matchUpListBox
			// 
			this.matchUpListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.matchUpListBox.FormattingEnabled = true;
			this.matchUpListBox.ItemHeight = 37;
			this.matchUpListBox.Location = new System.Drawing.Point(41, 235);
			this.matchUpListBox.Name = "matchUpListBox";
			this.matchUpListBox.Size = new System.Drawing.Size(336, 224);
			this.matchUpListBox.TabIndex = 5;
			// 
			// teamOneName
			// 
			this.teamOneName.AutoSize = true;
			this.teamOneName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.teamOneName.Location = new System.Drawing.Point(412, 226);
			this.teamOneName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.teamOneName.Name = "teamOneName";
			this.teamOneName.Size = new System.Drawing.Size(165, 37);
			this.teamOneName.TabIndex = 6;
			this.teamOneName.Text = "<team one>";
			// 
			// teamOneScoreLabel
			// 
			this.teamOneScoreLabel.AutoSize = true;
			this.teamOneScoreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.teamOneScoreLabel.Location = new System.Drawing.Point(412, 272);
			this.teamOneScoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.teamOneScoreLabel.Name = "teamOneScoreLabel";
			this.teamOneScoreLabel.Size = new System.Drawing.Size(82, 37);
			this.teamOneScoreLabel.TabIndex = 7;
			this.teamOneScoreLabel.Text = "Score";
			// 
			// teamOneScoreValue
			// 
			this.teamOneScoreValue.Location = new System.Drawing.Point(501, 266);
			this.teamOneScoreValue.Name = "teamOneScoreValue";
			this.teamOneScoreValue.Size = new System.Drawing.Size(92, 43);
			this.teamOneScoreValue.TabIndex = 8;
			// 
			// teamTwoScoreText
			// 
			this.teamTwoScoreText.Location = new System.Drawing.Point(499, 417);
			this.teamTwoScoreText.Name = "teamTwoScoreText";
			this.teamTwoScoreText.Size = new System.Drawing.Size(92, 43);
			this.teamTwoScoreText.TabIndex = 11;
			// 
			// teamTwoScoreLabel
			// 
			this.teamTwoScoreLabel.AutoSize = true;
			this.teamTwoScoreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.teamTwoScoreLabel.Location = new System.Drawing.Point(412, 423);
			this.teamTwoScoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.teamTwoScoreLabel.Name = "teamTwoScoreLabel";
			this.teamTwoScoreLabel.Size = new System.Drawing.Size(82, 37);
			this.teamTwoScoreLabel.TabIndex = 10;
			this.teamTwoScoreLabel.Text = "Score";
			// 
			// teamTwoName
			// 
			this.teamTwoName.AutoSize = true;
			this.teamTwoName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.teamTwoName.Location = new System.Drawing.Point(412, 377);
			this.teamTwoName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.teamTwoName.Name = "teamTwoName";
			this.teamTwoName.Size = new System.Drawing.Size(165, 37);
			this.teamTwoName.TabIndex = 9;
			this.teamTwoName.Text = "<team two>";
			// 
			// vsLabel
			// 
			this.vsLabel.AutoSize = true;
			this.vsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.vsLabel.Location = new System.Drawing.Point(494, 331);
			this.vsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.vsLabel.Name = "vsLabel";
			this.vsLabel.Size = new System.Drawing.Size(70, 37);
			this.vsLabel.TabIndex = 12;
			this.vsLabel.Text = "-VS-";
			// 
			// scoreButton
			// 
			this.scoreButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.scoreButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
			this.scoreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			this.scoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.scoreButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.scoreButton.Location = new System.Drawing.Point(613, 331);
			this.scoreButton.Name = "scoreButton";
			this.scoreButton.Size = new System.Drawing.Size(88, 37);
			this.scoreButton.TabIndex = 13;
			this.scoreButton.Text = "Score";
			this.scoreButton.UseVisualStyleBackColor = true;
			// 
			// TournamentViewerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(830, 618);
			this.Controls.Add(this.scoreButton);
			this.Controls.Add(this.vsLabel);
			this.Controls.Add(this.teamTwoScoreText);
			this.Controls.Add(this.teamTwoScoreLabel);
			this.Controls.Add(this.teamTwoName);
			this.Controls.Add(this.teamOneScoreValue);
			this.Controls.Add(this.teamOneScoreLabel);
			this.Controls.Add(this.teamOneName);
			this.Controls.Add(this.matchUpListBox);
			this.Controls.Add(this.unplayedOnlyCheckBox);
			this.Controls.Add(this.roundDropDown);
			this.Controls.Add(this.roundLabel);
			this.Controls.Add(this.TournamentName);
			this.Controls.Add(this.HeaderLabel);
			this.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
			this.Name = "TournamentViewerForm";
			this.Text = "Tournament Viewer";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label HeaderLabel;
		private System.Windows.Forms.Label TournamentName;
		private System.Windows.Forms.Label roundLabel;
		private System.Windows.Forms.ComboBox roundDropDown;
		private System.Windows.Forms.CheckBox unplayedOnlyCheckBox;
		private System.Windows.Forms.ListBox matchUpListBox;
		private System.Windows.Forms.Label teamOneName;
		private System.Windows.Forms.Label teamOneScoreLabel;
		private System.Windows.Forms.TextBox teamOneScoreValue;
		private System.Windows.Forms.TextBox teamTwoScoreText;
		private System.Windows.Forms.Label teamTwoScoreLabel;
		private System.Windows.Forms.Label teamTwoName;
		private System.Windows.Forms.Label vsLabel;
		private System.Windows.Forms.Button scoreButton;
	}
}

