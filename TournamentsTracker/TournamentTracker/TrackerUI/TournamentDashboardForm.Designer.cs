﻿namespace TrackerUI
{
	partial class TournamentDashboardForm
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
			this.loadExistingTournamentDropDown = new System.Windows.Forms.ComboBox();
			this.loadExistingTournamentLabel = new System.Windows.Forms.Label();
			this.loadTournamentButton = new System.Windows.Forms.Button();
			this.createTournamentButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// HeaderLabel
			// 
			this.HeaderLabel.AutoSize = true;
			this.HeaderLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.HeaderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.HeaderLabel.Location = new System.Drawing.Point(57, 21);
			this.HeaderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.HeaderLabel.Name = "HeaderLabel";
			this.HeaderLabel.Size = new System.Drawing.Size(385, 50);
			this.HeaderLabel.TabIndex = 13;
			this.HeaderLabel.Text = "Tournament Dashboard";
			this.HeaderLabel.Click += new System.EventHandler(this.HeaderLabel_Click);
			// 
			// loadExistingTournamentDropDown
			// 
			this.loadExistingTournamentDropDown.FormattingEnabled = true;
			this.loadExistingTournamentDropDown.Location = new System.Drawing.Point(123, 116);
			this.loadExistingTournamentDropDown.Name = "loadExistingTournamentDropDown";
			this.loadExistingTournamentDropDown.Size = new System.Drawing.Size(252, 38);
			this.loadExistingTournamentDropDown.TabIndex = 15;
			// 
			// loadExistingTournamentLabel
			// 
			this.loadExistingTournamentLabel.AutoSize = true;
			this.loadExistingTournamentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.loadExistingTournamentLabel.Location = new System.Drawing.Point(123, 83);
			this.loadExistingTournamentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.loadExistingTournamentLabel.Name = "loadExistingTournamentLabel";
			this.loadExistingTournamentLabel.Size = new System.Drawing.Size(252, 30);
			this.loadExistingTournamentLabel.TabIndex = 14;
			this.loadExistingTournamentLabel.Text = "Load Existing Tournament";
			this.loadExistingTournamentLabel.Click += new System.EventHandler(this.loadExistingTournamentLabel_Click);
			// 
			// loadTournamentButton
			// 
			this.loadTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.loadTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
			this.loadTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			this.loadTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.loadTournamentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.loadTournamentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.loadTournamentButton.Location = new System.Drawing.Point(155, 169);
			this.loadTournamentButton.Name = "loadTournamentButton";
			this.loadTournamentButton.Size = new System.Drawing.Size(179, 37);
			this.loadTournamentButton.TabIndex = 16;
			this.loadTournamentButton.Text = "Load Tournament";
			this.loadTournamentButton.UseVisualStyleBackColor = true;
			this.loadTournamentButton.Click += new System.EventHandler(this.loadTournamentButton_Click);
			// 
			// createTournamentButton
			// 
			this.createTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.createTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
			this.createTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			this.createTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.createTournamentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.createTournamentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.createTournamentButton.Location = new System.Drawing.Point(123, 229);
			this.createTournamentButton.Name = "createTournamentButton";
			this.createTournamentButton.Size = new System.Drawing.Size(252, 61);
			this.createTournamentButton.TabIndex = 27;
			this.createTournamentButton.Text = "Create Tournament";
			this.createTournamentButton.UseVisualStyleBackColor = true;
			this.createTournamentButton.Click += new System.EventHandler(this.createTournamentButton_Click);
			// 
			// TournamentDashboardForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(525, 331);
			this.Controls.Add(this.createTournamentButton);
			this.Controls.Add(this.loadTournamentButton);
			this.Controls.Add(this.loadExistingTournamentDropDown);
			this.Controls.Add(this.loadExistingTournamentLabel);
			this.Controls.Add(this.HeaderLabel);
			this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
			this.Name = "TournamentDashboardForm";
			this.Text = "Tournament Dashboard ";
			this.Load += new System.EventHandler(this.TournamentDashboardForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label HeaderLabel;
		private System.Windows.Forms.ComboBox loadExistingTournamentDropDown;
		private System.Windows.Forms.Label loadExistingTournamentLabel;
		private System.Windows.Forms.Button loadTournamentButton;
		private System.Windows.Forms.Button createTournamentButton;
	}
}