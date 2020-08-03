namespace Integrated_Projects.Payroll
{
	partial class Salary
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Salary));
			this.btnCalculate = new System.Windows.Forms.Button();
			this.btnBack = new System.Windows.Forms.Button();
			this.btnInsert = new System.Windows.Forms.Button();
			this.label20 = new System.Windows.Forms.Label();
			this.txtLoan = new System.Windows.Forms.TextBox();
			this.txtAdvance = new System.Windows.Forms.TextBox();
			this.label18 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.txtSalID = new System.Windows.Forms.TextBox();
			this.txtFinal = new System.Windows.Forms.TextBox();
			this.txtETF3 = new System.Windows.Forms.TextBox();
			this.txtEPF12 = new System.Windows.Forms.TextBox();
			this.txtEPF8 = new System.Windows.Forms.TextBox();
			this.txtDaysWorked = new System.Windows.Forms.TextBox();
			this.txtEmpName = new System.Windows.Forms.TextBox();
			this.txtDesignation = new System.Windows.Forms.TextBox();
			this.cmbEmpID = new System.Windows.Forms.ComboBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtBasicSal = new System.Windows.Forms.TextBox();
			this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnCalculate
			// 
			this.btnCalculate.BackColor = System.Drawing.SystemColors.ControlDark;
			this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnCalculate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnCalculate.Location = new System.Drawing.Point(218, 12);
			this.btnCalculate.Name = "btnCalculate";
			this.btnCalculate.Size = new System.Drawing.Size(200, 65);
			this.btnCalculate.TabIndex = 36;
			this.btnCalculate.Text = "Calculate";
			this.btnCalculate.UseVisualStyleBackColor = false;
			this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
			// 
			// btnBack
			// 
			this.btnBack.BackColor = System.Drawing.SystemColors.Desktop;
			this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnBack.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.btnBack.Location = new System.Drawing.Point(218, 154);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(200, 65);
			this.btnBack.TabIndex = 37;
			this.btnBack.Text = "Back";
			this.btnBack.UseVisualStyleBackColor = false;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// btnInsert
			// 
			this.btnInsert.BackColor = System.Drawing.SystemColors.ControlDark;
			this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnInsert.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnInsert.Location = new System.Drawing.Point(218, 83);
			this.btnInsert.Name = "btnInsert";
			this.btnInsert.Size = new System.Drawing.Size(200, 65);
			this.btnInsert.TabIndex = 40;
			this.btnInsert.Text = "Pay AND Insert";
			this.btnInsert.UseVisualStyleBackColor = false;
			this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label20.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label20.Location = new System.Drawing.Point(9, 588);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(136, 20);
			this.label20.TabIndex = 72;
			this.label20.Text = "Final Salary (LKR)";
			// 
			// txtLoan
			// 
			this.txtLoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.txtLoan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtLoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtLoan.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.txtLoan.Location = new System.Drawing.Point(169, 554);
			this.txtLoan.Name = "txtLoan";
			this.txtLoan.ReadOnly = true;
			this.txtLoan.Size = new System.Drawing.Size(249, 26);
			this.txtLoan.TabIndex = 71;
			// 
			// txtAdvance
			// 
			this.txtAdvance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.txtAdvance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtAdvance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAdvance.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.txtAdvance.Location = new System.Drawing.Point(169, 522);
			this.txtAdvance.Name = "txtAdvance";
			this.txtAdvance.ReadOnly = true;
			this.txtAdvance.Size = new System.Drawing.Size(249, 26);
			this.txtAdvance.TabIndex = 70;
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label18.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label18.Location = new System.Drawing.Point(9, 556);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(90, 20);
			this.label18.TabIndex = 69;
			this.label18.Text = "Loan (LKR)";
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label19.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label19.Location = new System.Drawing.Point(9, 524);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(116, 20);
			this.label19.TabIndex = 68;
			this.label19.Text = "Advance (LKR)";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label17.Location = new System.Drawing.Point(9, 269);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(74, 20);
			this.label17.TabIndex = 67;
			this.label17.Text = "Salary ID";
			// 
			// txtSalID
			// 
			this.txtSalID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.txtSalID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtSalID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSalID.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.txtSalID.Location = new System.Drawing.Point(169, 267);
			this.txtSalID.Name = "txtSalID";
			this.txtSalID.ReadOnly = true;
			this.txtSalID.Size = new System.Drawing.Size(249, 26);
			this.txtSalID.TabIndex = 66;
			// 
			// txtFinal
			// 
			this.txtFinal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.txtFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFinal.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.txtFinal.Location = new System.Drawing.Point(169, 586);
			this.txtFinal.Name = "txtFinal";
			this.txtFinal.ReadOnly = true;
			this.txtFinal.Size = new System.Drawing.Size(249, 26);
			this.txtFinal.TabIndex = 65;
			// 
			// txtETF3
			// 
			this.txtETF3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.txtETF3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtETF3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtETF3.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.txtETF3.Location = new System.Drawing.Point(169, 490);
			this.txtETF3.Name = "txtETF3";
			this.txtETF3.ReadOnly = true;
			this.txtETF3.Size = new System.Drawing.Size(249, 26);
			this.txtETF3.TabIndex = 61;
			// 
			// txtEPF12
			// 
			this.txtEPF12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.txtEPF12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtEPF12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEPF12.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.txtEPF12.Location = new System.Drawing.Point(169, 459);
			this.txtEPF12.Name = "txtEPF12";
			this.txtEPF12.ReadOnly = true;
			this.txtEPF12.Size = new System.Drawing.Size(249, 26);
			this.txtEPF12.TabIndex = 60;
			// 
			// txtEPF8
			// 
			this.txtEPF8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.txtEPF8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtEPF8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEPF8.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.txtEPF8.Location = new System.Drawing.Point(169, 427);
			this.txtEPF8.Name = "txtEPF8";
			this.txtEPF8.ReadOnly = true;
			this.txtEPF8.Size = new System.Drawing.Size(249, 26);
			this.txtEPF8.TabIndex = 59;
			// 
			// txtDaysWorked
			// 
			this.txtDaysWorked.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.txtDaysWorked.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtDaysWorked.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDaysWorked.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.txtDaysWorked.Location = new System.Drawing.Point(169, 363);
			this.txtDaysWorked.Name = "txtDaysWorked";
			this.txtDaysWorked.Size = new System.Drawing.Size(249, 26);
			this.txtDaysWorked.TabIndex = 57;
			// 
			// txtEmpName
			// 
			this.txtEmpName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.txtEmpName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtEmpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEmpName.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.txtEmpName.Location = new System.Drawing.Point(169, 331);
			this.txtEmpName.Name = "txtEmpName";
			this.txtEmpName.ReadOnly = true;
			this.txtEmpName.Size = new System.Drawing.Size(249, 26);
			this.txtEmpName.TabIndex = 55;
			// 
			// txtDesignation
			// 
			this.txtDesignation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.txtDesignation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtDesignation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDesignation.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.txtDesignation.Location = new System.Drawing.Point(169, 299);
			this.txtDesignation.Name = "txtDesignation";
			this.txtDesignation.ReadOnly = true;
			this.txtDesignation.Size = new System.Drawing.Size(249, 26);
			this.txtDesignation.TabIndex = 54;
			// 
			// cmbEmpID
			// 
			this.cmbEmpID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.cmbEmpID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.cmbEmpID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbEmpID.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.cmbEmpID.FormattingEnabled = true;
			this.cmbEmpID.Location = new System.Drawing.Point(169, 233);
			this.cmbEmpID.Name = "cmbEmpID";
			this.cmbEmpID.Size = new System.Drawing.Size(249, 28);
			this.cmbEmpID.TabIndex = 53;
			this.cmbEmpID.SelectedIndexChanged += new System.EventHandler(this.cmbEmpID_SelectedIndexChanged);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label9.Location = new System.Drawing.Point(9, 492);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(66, 20);
			this.label9.TabIndex = 49;
			this.label9.Text = "ETF 3%";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label8.Location = new System.Drawing.Point(9, 461);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(76, 20);
			this.label8.TabIndex = 48;
			this.label8.Text = "EPF 12%";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label7.Location = new System.Drawing.Point(9, 429);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(67, 20);
			this.label7.TabIndex = 47;
			this.label7.Text = "EPF 8%";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label5.Location = new System.Drawing.Point(9, 365);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(104, 20);
			this.label5.TabIndex = 45;
			this.label5.Text = "Worked Days";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label3.Location = new System.Drawing.Point(9, 333);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(125, 20);
			this.label3.TabIndex = 43;
			this.label3.Text = "Employee Name";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label2.Location = new System.Drawing.Point(9, 236);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 20);
			this.label2.TabIndex = 42;
			this.label2.Text = "Employee ID";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label1.Location = new System.Drawing.Point(9, 301);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(103, 20);
			this.label1.TabIndex = 41;
			this.label1.Text = "Job Category";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label6.Location = new System.Drawing.Point(9, 397);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(141, 20);
			this.label6.TabIndex = 46;
			this.label6.Text = "Basic Salary (LKR)";
			// 
			// txtBasicSal
			// 
			this.txtBasicSal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.txtBasicSal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtBasicSal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBasicSal.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.txtBasicSal.Location = new System.Drawing.Point(169, 395);
			this.txtBasicSal.Name = "txtBasicSal";
			this.txtBasicSal.Size = new System.Drawing.Size(249, 26);
			this.txtBasicSal.TabIndex = 58;
			// 
			// monthCalendar1
			// 
			this.monthCalendar1.Location = new System.Drawing.Point(102, 618);
			this.monthCalendar1.Name = "monthCalendar1";
			this.monthCalendar1.TabIndex = 75;
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
			this.pictureBox1.TabIndex = 76;
			this.pictureBox1.TabStop = false;
			// 
			// Salary
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.ClientSize = new System.Drawing.Size(430, 788);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.monthCalendar1);
			this.Controls.Add(this.label20);
			this.Controls.Add(this.txtLoan);
			this.Controls.Add(this.txtAdvance);
			this.Controls.Add(this.label18);
			this.Controls.Add(this.label19);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.txtSalID);
			this.Controls.Add(this.txtFinal);
			this.Controls.Add(this.txtETF3);
			this.Controls.Add(this.txtEPF12);
			this.Controls.Add(this.txtEPF8);
			this.Controls.Add(this.txtBasicSal);
			this.Controls.Add(this.txtDaysWorked);
			this.Controls.Add(this.txtEmpName);
			this.Controls.Add(this.txtDesignation);
			this.Controls.Add(this.cmbEmpID);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnInsert);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.btnCalculate);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Salary";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Salary";
			this.Load += new System.EventHandler(this.Salary_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btnCalculate;
		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.Button btnInsert;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.TextBox txtLoan;
		private System.Windows.Forms.TextBox txtAdvance;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.TextBox txtSalID;
		private System.Windows.Forms.TextBox txtFinal;
		private System.Windows.Forms.TextBox txtETF3;
		private System.Windows.Forms.TextBox txtEPF12;
		private System.Windows.Forms.TextBox txtEPF8;
		private System.Windows.Forms.TextBox txtDaysWorked;
		private System.Windows.Forms.TextBox txtEmpName;
		private System.Windows.Forms.TextBox txtDesignation;
		private System.Windows.Forms.ComboBox cmbEmpID;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtBasicSal;
		private System.Windows.Forms.MonthCalendar monthCalendar1;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}