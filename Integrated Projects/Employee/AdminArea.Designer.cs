namespace Integrated_Projects
{
	partial class AdminArea
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminArea));
			this.btnEmpRegister = new System.Windows.Forms.Button();
			this.btnEmployeeDetails = new System.Windows.Forms.Button();
			this.btnSalaryDetails = new System.Windows.Forms.Button();
			this.btnReports = new System.Windows.Forms.Button();
			this.btnLogout = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnEmpRegister
			// 
			this.btnEmpRegister.BackColor = System.Drawing.SystemColors.ControlDark;
			this.btnEmpRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEmpRegister.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnEmpRegister.Location = new System.Drawing.Point(197, 38);
			this.btnEmpRegister.Name = "btnEmpRegister";
			this.btnEmpRegister.Size = new System.Drawing.Size(200, 65);
			this.btnEmpRegister.TabIndex = 0;
			this.btnEmpRegister.Text = "Employee Registration";
			this.btnEmpRegister.UseVisualStyleBackColor = false;
			this.btnEmpRegister.Click += new System.EventHandler(this.btnEmpRegister_Click);
			// 
			// btnEmployeeDetails
			// 
			this.btnEmployeeDetails.BackColor = System.Drawing.SystemColors.ControlDark;
			this.btnEmployeeDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEmployeeDetails.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnEmployeeDetails.Location = new System.Drawing.Point(197, 109);
			this.btnEmployeeDetails.Name = "btnEmployeeDetails";
			this.btnEmployeeDetails.Size = new System.Drawing.Size(200, 65);
			this.btnEmployeeDetails.TabIndex = 1;
			this.btnEmployeeDetails.Text = "Employee Details";
			this.btnEmployeeDetails.UseVisualStyleBackColor = false;
			this.btnEmployeeDetails.Click += new System.EventHandler(this.btnEmployeeDetails_Click);
			// 
			// btnSalaryDetails
			// 
			this.btnSalaryDetails.BackColor = System.Drawing.SystemColors.ControlDark;
			this.btnSalaryDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSalaryDetails.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnSalaryDetails.Location = new System.Drawing.Point(197, 180);
			this.btnSalaryDetails.Name = "btnSalaryDetails";
			this.btnSalaryDetails.Size = new System.Drawing.Size(200, 65);
			this.btnSalaryDetails.TabIndex = 2;
			this.btnSalaryDetails.Text = "Salary Details";
			this.btnSalaryDetails.UseVisualStyleBackColor = false;
			this.btnSalaryDetails.Click += new System.EventHandler(this.btnSalaryDetails_Click);
			// 
			// btnReports
			// 
			this.btnReports.BackColor = System.Drawing.SystemColors.ControlDark;
			this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnReports.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnReports.Location = new System.Drawing.Point(197, 251);
			this.btnReports.Name = "btnReports";
			this.btnReports.Size = new System.Drawing.Size(200, 65);
			this.btnReports.TabIndex = 3;
			this.btnReports.Text = "Profitability";
			this.btnReports.UseVisualStyleBackColor = false;
			this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
			// 
			// btnLogout
			// 
			this.btnLogout.BackColor = System.Drawing.SystemColors.Desktop;
			this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLogout.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.btnLogout.Location = new System.Drawing.Point(197, 322);
			this.btnLogout.Name = "btnLogout";
			this.btnLogout.Size = new System.Drawing.Size(200, 65);
			this.btnLogout.TabIndex = 4;
			this.btnLogout.Text = "Logout";
			this.btnLogout.UseVisualStyleBackColor = false;
			this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(12, 8);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(150, 150);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 56;
			this.pictureBox1.TabStop = false;
			// 
			// AdminArea
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.ClientSize = new System.Drawing.Size(425, 425);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnLogout);
			this.Controls.Add(this.btnReports);
			this.Controls.Add(this.btnSalaryDetails);
			this.Controls.Add(this.btnEmployeeDetails);
			this.Controls.Add(this.btnEmpRegister);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "AdminArea";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AdminArea";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button btnEmpRegister;
		private System.Windows.Forms.Button btnEmployeeDetails;
		private System.Windows.Forms.Button btnSalaryDetails;
		private System.Windows.Forms.Button btnReports;
		private System.Windows.Forms.Button btnLogout;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}