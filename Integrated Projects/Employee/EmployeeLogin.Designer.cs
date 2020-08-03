namespace Integrated_Projects
{
	partial class EmployeeLogin
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeLogin));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnReset = new System.Windows.Forms.Button();
			this.btnLogin = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.txtLogEmpMail = new System.Windows.Forms.TextBox();
			this.cmbLogType = new System.Windows.Forms.ComboBox();
			this.txtLogEmpPass = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.chkAttendance = new System.Windows.Forms.CheckBox();
			this.panel4 = new System.Windows.Forms.Panel();
			this.cmbLogEmpID = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(150, 5);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Padding = new System.Windows.Forms.Padding(25);
			this.pictureBox1.Size = new System.Drawing.Size(150, 150);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 16;
			this.pictureBox1.TabStop = false;
			// 
			// btnReset
			// 
			this.btnReset.BackColor = System.Drawing.SystemColors.Highlight;
			this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReset.Location = new System.Drawing.Point(125, 47);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(200, 40);
			this.btnReset.TabIndex = 5;
			this.btnReset.Text = "Reset";
			this.btnReset.UseVisualStyleBackColor = false;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// btnLogin
			// 
			this.btnLogin.BackColor = System.Drawing.SystemColors.Highlight;
			this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogin.Location = new System.Drawing.Point(125, 2);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(200, 40);
			this.btnLogin.TabIndex = 4;
			this.btnLogin.Text = "Login";
			this.btnLogin.UseVisualStyleBackColor = false;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// btnExit
			// 
			this.btnExit.BackColor = System.Drawing.Color.OrangeRed;
			this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnExit.Location = new System.Drawing.Point(125, 92);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(200, 40);
			this.btnExit.TabIndex = 19;
			this.btnExit.Text = "EXIT";
			this.btnExit.UseVisualStyleBackColor = false;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnLogin);
			this.panel1.Controls.Add(this.btnExit);
			this.panel1.Controls.Add(this.btnReset);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 410);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(450, 150);
			this.panel1.TabIndex = 20;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.pictureBox1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(450, 160);
			this.panel2.TabIndex = 21;
			// 
			// panel3
			// 
			this.panel3.AutoSize = true;
			this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel3.Location = new System.Drawing.Point(0, 160);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(0, 250);
			this.panel3.TabIndex = 22;
			// 
			// panel5
			// 
			this.panel5.AutoSize = true;
			this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel5.Location = new System.Drawing.Point(450, 160);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(0, 250);
			this.panel5.TabIndex = 24;
			// 
			// txtLogEmpMail
			// 
			this.txtLogEmpMail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.txtLogEmpMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.txtLogEmpMail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtLogEmpMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtLogEmpMail.ForeColor = System.Drawing.Color.White;
			this.txtLogEmpMail.Location = new System.Drawing.Point(113, 137);
			this.txtLogEmpMail.Name = "txtLogEmpMail";
			this.txtLogEmpMail.Size = new System.Drawing.Size(200, 26);
			this.txtLogEmpMail.TabIndex = 2;
			this.txtLogEmpMail.Text = "Email";
			this.txtLogEmpMail.Click += new System.EventHandler(this.txtLogEmpMail_Click);
			// 
			// cmbLogType
			// 
			this.cmbLogType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.cmbLogType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.cmbLogType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbLogType.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.cmbLogType.FormattingEnabled = true;
			this.cmbLogType.Items.AddRange(new object[] {
            "Job Category",
            "Manager",
            "Accountant",
            "Cashier",
            "Chef",
            "Delivery Agent"});
			this.cmbLogType.Location = new System.Drawing.Point(113, 45);
			this.cmbLogType.Name = "cmbLogType";
			this.cmbLogType.Size = new System.Drawing.Size(200, 28);
			this.cmbLogType.TabIndex = 0;
			// 
			// txtLogEmpPass
			// 
			this.txtLogEmpPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.txtLogEmpPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtLogEmpPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtLogEmpPass.ForeColor = System.Drawing.Color.White;
			this.txtLogEmpPass.Location = new System.Drawing.Point(113, 169);
			this.txtLogEmpPass.Name = "txtLogEmpPass";
			this.txtLogEmpPass.Size = new System.Drawing.Size(200, 26);
			this.txtLogEmpPass.TabIndex = 3;
			this.txtLogEmpPass.Text = "Password";
			this.txtLogEmpPass.Click += new System.EventHandler(this.txtLogEmpPass_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(173, 6);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 31);
			this.label2.TabIndex = 17;
			this.label2.Text = "Login";
			// 
			// chkAttendance
			// 
			this.chkAttendance.AutoSize = true;
			this.chkAttendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkAttendance.Location = new System.Drawing.Point(158, 201);
			this.chkAttendance.Name = "chkAttendance";
			this.chkAttendance.Size = new System.Drawing.Size(111, 24);
			this.chkAttendance.TabIndex = 18;
			this.chkAttendance.Text = "Attendance";
			this.chkAttendance.UseVisualStyleBackColor = true;
			// 
			// panel4
			// 
			this.panel4.AutoSize = true;
			this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.panel4.Controls.Add(this.label1);
			this.panel4.Controls.Add(this.cmbLogEmpID);
			this.panel4.Controls.Add(this.chkAttendance);
			this.panel4.Controls.Add(this.label2);
			this.panel4.Controls.Add(this.txtLogEmpPass);
			this.panel4.Controls.Add(this.cmbLogType);
			this.panel4.Controls.Add(this.txtLogEmpMail);
			this.panel4.Location = new System.Drawing.Point(12, 166);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(426, 238);
			this.panel4.TabIndex = 25;
			// 
			// cmbLogEmpID
			// 
			this.cmbLogEmpID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.cmbLogEmpID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.cmbLogEmpID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbLogEmpID.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.cmbLogEmpID.FormattingEnabled = true;
			this.cmbLogEmpID.Location = new System.Drawing.Point(113, 103);
			this.cmbLogEmpID.Name = "cmbLogEmpID";
			this.cmbLogEmpID.Size = new System.Drawing.Size(200, 28);
			this.cmbLogEmpID.TabIndex = 19;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(163, 79);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 20);
			this.label1.TabIndex = 20;
			this.label1.Text = "Employee ID";
			// 
			// EmployeeLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.ClientSize = new System.Drawing.Size(450, 560);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel5);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.ForeColor = System.Drawing.SystemColors.Control;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "EmployeeLogin";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "EmployeeLogin";
			this.Load += new System.EventHandler(this.EmployeeLogin_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.TextBox txtLogEmpMail;
		private System.Windows.Forms.ComboBox cmbLogType;
		private System.Windows.Forms.TextBox txtLogEmpPass;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox chkAttendance;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.ComboBox cmbLogEmpID;
		private System.Windows.Forms.Label label1;
	}
}