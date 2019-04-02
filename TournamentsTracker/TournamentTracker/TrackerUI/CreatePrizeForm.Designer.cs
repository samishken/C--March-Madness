namespace TrackerUI
{
	partial class CreatePrizeForm
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
			this.placeNumberLabel = new System.Windows.Forms.Label();
			this.placeNumberValue = new System.Windows.Forms.TextBox();
			this.priceAmountValue = new System.Windows.Forms.TextBox();
			this.priceAmountLabel = new System.Windows.Forms.Label();
			this.placeNameValue = new System.Windows.Forms.TextBox();
			this.placeNameLabel = new System.Windows.Forms.Label();
			this.pricePercentageValue = new System.Windows.Forms.TextBox();
			this.pricePercentageLable = new System.Windows.Forms.Label();
			this.orLabel = new System.Windows.Forms.Label();
			this.createPrizeButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// HeaderLabel
			// 
			this.HeaderLabel.AutoSize = true;
			this.HeaderLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.HeaderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.HeaderLabel.Location = new System.Drawing.Point(13, 9);
			this.HeaderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.HeaderLabel.Name = "HeaderLabel";
			this.HeaderLabel.Size = new System.Drawing.Size(209, 50);
			this.HeaderLabel.TabIndex = 12;
			this.HeaderLabel.Text = "Create Prize";
			// 
			// placeNumberLabel
			// 
			this.placeNumberLabel.AutoSize = true;
			this.placeNumberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.placeNumberLabel.Location = new System.Drawing.Point(33, 84);
			this.placeNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.placeNumberLabel.Name = "placeNumberLabel";
			this.placeNumberLabel.Size = new System.Drawing.Size(144, 30);
			this.placeNumberLabel.TabIndex = 13;
			this.placeNumberLabel.Text = "Place Number";
			this.placeNumberLabel.Click += new System.EventHandler(this.placeNumberLabel_Click);
			// 
			// placeNumberValue
			// 
			this.placeNumberValue.Location = new System.Drawing.Point(205, 79);
			this.placeNumberValue.Name = "placeNumberValue";
			this.placeNumberValue.Size = new System.Drawing.Size(189, 35);
			this.placeNumberValue.TabIndex = 14;
			this.placeNumberValue.TextChanged += new System.EventHandler(this.placeNumberValue_TextChanged);
			// 
			// priceAmountValue
			// 
			this.priceAmountValue.Location = new System.Drawing.Point(205, 167);
			this.priceAmountValue.Name = "priceAmountValue";
			this.priceAmountValue.Size = new System.Drawing.Size(189, 35);
			this.priceAmountValue.TabIndex = 16;
			this.priceAmountValue.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// priceAmountLabel
			// 
			this.priceAmountLabel.AutoSize = true;
			this.priceAmountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.priceAmountLabel.Location = new System.Drawing.Point(33, 170);
			this.priceAmountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.priceAmountLabel.Name = "priceAmountLabel";
			this.priceAmountLabel.Size = new System.Drawing.Size(139, 30);
			this.priceAmountLabel.TabIndex = 15;
			this.priceAmountLabel.Text = "Price Amount";
			this.priceAmountLabel.Click += new System.EventHandler(this.label1_Click);
			// 
			// placeNameValue
			// 
			this.placeNameValue.Location = new System.Drawing.Point(205, 123);
			this.placeNameValue.Name = "placeNameValue";
			this.placeNameValue.Size = new System.Drawing.Size(189, 35);
			this.placeNameValue.TabIndex = 18;
			this.placeNameValue.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// placeNameLabel
			// 
			this.placeNameLabel.AutoSize = true;
			this.placeNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.placeNameLabel.Location = new System.Drawing.Point(33, 127);
			this.placeNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.placeNameLabel.Name = "placeNameLabel";
			this.placeNameLabel.Size = new System.Drawing.Size(124, 30);
			this.placeNameLabel.TabIndex = 17;
			this.placeNameLabel.Text = "Place Name";
			this.placeNameLabel.Click += new System.EventHandler(this.label2_Click);
			// 
			// pricePercentageValue
			// 
			this.pricePercentageValue.Location = new System.Drawing.Point(205, 311);
			this.pricePercentageValue.Name = "pricePercentageValue";
			this.pricePercentageValue.Size = new System.Drawing.Size(189, 35);
			this.pricePercentageValue.TabIndex = 20;
			this.pricePercentageValue.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
			// 
			// pricePercentageLable
			// 
			this.pricePercentageLable.AutoSize = true;
			this.pricePercentageLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.pricePercentageLable.Location = new System.Drawing.Point(33, 316);
			this.pricePercentageLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.pricePercentageLable.Name = "pricePercentageLable";
			this.pricePercentageLable.Size = new System.Drawing.Size(167, 30);
			this.pricePercentageLable.TabIndex = 19;
			this.pricePercentageLable.Text = "Price Percentage";
			this.pricePercentageLable.Click += new System.EventHandler(this.label3_Click);
			// 
			// orLabel
			// 
			this.orLabel.AutoSize = true;
			this.orLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.orLabel.Location = new System.Drawing.Point(200, 239);
			this.orLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.orLabel.Name = "orLabel";
			this.orLabel.Size = new System.Drawing.Size(58, 30);
			this.orLabel.TabIndex = 21;
			this.orLabel.Text = "-OR-";
			// 
			// createPrizeButton
			// 
			this.createPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.createPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
			this.createPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			this.createPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.createPrizeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.createPrizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.createPrizeButton.Location = new System.Drawing.Point(205, 387);
			this.createPrizeButton.Name = "createPrizeButton";
			this.createPrizeButton.Size = new System.Drawing.Size(189, 61);
			this.createPrizeButton.TabIndex = 26;
			this.createPrizeButton.Text = "Create Prize";
			this.createPrizeButton.UseVisualStyleBackColor = true;
			// 
			// CreatePrizeForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(566, 508);
			this.Controls.Add(this.createPrizeButton);
			this.Controls.Add(this.orLabel);
			this.Controls.Add(this.pricePercentageValue);
			this.Controls.Add(this.pricePercentageLable);
			this.Controls.Add(this.placeNameValue);
			this.Controls.Add(this.placeNameLabel);
			this.Controls.Add(this.priceAmountValue);
			this.Controls.Add(this.priceAmountLabel);
			this.Controls.Add(this.placeNumberValue);
			this.Controls.Add(this.placeNumberLabel);
			this.Controls.Add(this.HeaderLabel);
			this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
			this.Name = "CreatePrizeForm";
			this.Text = "Create Prize  ";
			this.Load += new System.EventHandler(this.CreatePrizeForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label HeaderLabel;
		private System.Windows.Forms.Label placeNumberLabel;
		private System.Windows.Forms.TextBox placeNumberValue;
		private System.Windows.Forms.TextBox priceAmountValue;
		private System.Windows.Forms.Label priceAmountLabel;
		private System.Windows.Forms.TextBox placeNameValue;
		private System.Windows.Forms.Label placeNameLabel;
		private System.Windows.Forms.TextBox pricePercentageValue;
		private System.Windows.Forms.Label pricePercentageLable;
		private System.Windows.Forms.Label orLabel;
		private System.Windows.Forms.Button createPrizeButton;
	}
}