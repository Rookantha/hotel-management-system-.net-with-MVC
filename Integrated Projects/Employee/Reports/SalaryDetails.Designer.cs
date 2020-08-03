namespace Integrated_Projects.Employee.Reports
{
	partial class SalaryDetails
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalaryDetails));
			this.dataSalaryView = new System.Windows.Forms.DataGridView();
			this.btnBack = new System.Windows.Forms.Button();
			this.cmbID = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.monthSalary = new System.Windows.Forms.MonthCalendar();
			this.btnMonthSalary = new System.Windows.Forms.Button();
			this.btnAllSalary = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.dataSalaryView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataSalaryView
			// 
			this.dataSalaryView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataSalaryView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.dataSalaryView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataSalaryView.Location = new System.Drawing.Point(12, 244);
			this.dataSalaryView.Name = "dataSalaryView";
			this.dataSalaryView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dataSalaryView.Size = new System.Drawing.Size(836, 175);
			this.dataSalaryView.TabIndex = 0;
			// 
			// btnBack
			// 
			this.btnBack.BackColor = System.Drawing.SystemColors.Desktop;
			this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnBack.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.btnBack.Location = new System.Drawing.Point(648, 154);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(200, 65);
			this.btnBack.TabIndex = 2;
			this.btnBack.Text = "Back";
			this.btnBack.UseVisualStyleBackColor = false;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// cmbID
			// 
			this.cmbID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.cmbID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.cmbID.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.cmbID.FormattingEnabled = true;
			this.cmbID.Location = new System.Drawing.Point(370, 202);
			this.cmbID.Name = "cmbID";
			this.cmbID.Size = new System.Drawing.Size(121, 28);
			this.cmbID.TabIndex = 4;
			this.cmbID.SelectedIndexChanged += new System.EventHandler(this.cmbID_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label1.Location = new System.Drawing.Point(379, 179);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 20);
			this.label1.TabIndex = 5;
			this.label1.Text = "Employee ID";
			// 
			// monthSalary
			// 
			this.monthSalary.Location = new System.Drawing.Point(317, 12);
			this.monthSalary.Name = "monthSalary";
			this.monthSalary.TabIndex = 6;
			// 
			// btnMonthSalary
			// 
			this.btnMonthSalary.BackColor = System.Drawing.SystemColors.ControlDark;
			this.btnMonthSalary.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnMonthSalary.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnMonthSalary.Location = new System.Drawing.Point(648, 12);
			this.btnMonthSalary.Name = "btnMonthSalary";
			this.btnMonthSalary.Size = new System.Drawing.Size(200, 65);
			this.btnMonthSalary.TabIndex = 7;
			this.btnMonthSalary.Text = "Monthly Salary Details";
			this.btnMonthSalary.UseVisualStyleBackColor = false;
			this.btnMonthSalary.Click += new System.EventHandler(this.btnMonthSalary_Click);
			// 
			// btnAllSalary
			// 
			this.btnAllSalary.BackColor = System.Drawing.SystemColors.ControlDark;
			this.btnAllSalary.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnAllSalary.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnAllSalary.Location = new System.Drawing.Point(648, 83);
			this.btnAllSalary.Name = "btnAllSalary";
			this.btnAllSalary.Size = new System.Drawing.Size(200, 65);
			this.btnAllSalary.TabIndex = 8;
			this.btnAllSalary.Text = "All Salary Details";
			this.btnAllSalary.UseVisualStyleBackColor = false;
			this.btnAllSalary.Click += new System.EventHandler(this.btnAllSalary_Click);
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
			this.pictureBox1.TabIndex = 62;
			this.pictureBox1.TabStop = false;
			// 
			// SalaryDetails
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.ClientSize = new System.Drawing.Size(860, 431);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnAllSalary);
			this.Controls.Add(this.btnMonthSalary);
			this.Controls.Add(this.monthSalary);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cmbID);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.dataSalaryView);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "SalaryDetails";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SalaryDetails";
			((System.ComponentModel.ISupportInitialize)(this.dataSalaryView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataSalaryView;
		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.ComboBox cmbID;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.MonthCalendar monthSalary;
		private System.Windows.Forms.Button btnMonthSalary;
		private System.Windows.Forms.Button btnAllSalary;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}