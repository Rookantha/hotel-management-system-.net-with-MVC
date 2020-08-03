namespace Integrated_Projects.Payroll
{
	partial class PayrollHome
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayrollHome));
			this.btnSalary = new System.Windows.Forms.Button();
			this.btnAdvance = new System.Windows.Forms.Button();
			this.btnBack = new System.Windows.Forms.Button();
			this.btnLoanSettle = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnSalary
			// 
			this.btnSalary.BackColor = System.Drawing.SystemColors.ControlDark;
			this.btnSalary.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnSalary.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnSalary.Location = new System.Drawing.Point(203, 73);
			this.btnSalary.Name = "btnSalary";
			this.btnSalary.Size = new System.Drawing.Size(200, 65);
			this.btnSalary.TabIndex = 2;
			this.btnSalary.Text = "Salary";
			this.btnSalary.UseVisualStyleBackColor = false;
			this.btnSalary.Click += new System.EventHandler(this.btnSalary_Click);
			// 
			// btnAdvance
			// 
			this.btnAdvance.BackColor = System.Drawing.SystemColors.ControlDark;
			this.btnAdvance.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnAdvance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnAdvance.Location = new System.Drawing.Point(203, 144);
			this.btnAdvance.Name = "btnAdvance";
			this.btnAdvance.Size = new System.Drawing.Size(200, 65);
			this.btnAdvance.TabIndex = 9;
			this.btnAdvance.Text = "Advance / Loans";
			this.btnAdvance.UseVisualStyleBackColor = false;
			this.btnAdvance.Click += new System.EventHandler(this.btnAdvance_Click);
			// 
			// btnBack
			// 
			this.btnBack.BackColor = System.Drawing.SystemColors.Desktop;
			this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnBack.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.btnBack.Location = new System.Drawing.Point(203, 286);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(200, 65);
			this.btnBack.TabIndex = 11;
			this.btnBack.Text = "Back";
			this.btnBack.UseVisualStyleBackColor = false;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// btnLoanSettle
			// 
			this.btnLoanSettle.BackColor = System.Drawing.SystemColors.ControlDark;
			this.btnLoanSettle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnLoanSettle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnLoanSettle.Location = new System.Drawing.Point(203, 215);
			this.btnLoanSettle.Name = "btnLoanSettle";
			this.btnLoanSettle.Size = new System.Drawing.Size(200, 65);
			this.btnLoanSettle.TabIndex = 12;
			this.btnLoanSettle.Text = "Settle Loan";
			this.btnLoanSettle.UseVisualStyleBackColor = false;
			this.btnLoanSettle.Click += new System.EventHandler(this.btnLoanSettle_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(12, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(150, 150);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 59;
			this.pictureBox1.TabStop = false;
			// 
			// PayrollHome
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.ClientSize = new System.Drawing.Size(425, 425);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnLoanSettle);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.btnAdvance);
			this.Controls.Add(this.btnSalary);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "PayrollHome";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Payroll Home";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnSalary;
		private System.Windows.Forms.Button btnAdvance;
		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.Button btnLoanSettle;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}