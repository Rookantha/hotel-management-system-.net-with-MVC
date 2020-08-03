namespace Integrated_Projects.Payroll
{
	partial class Advances_Loans
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Advances_Loans));
			this.cmbType = new System.Windows.Forms.ComboBox();
			this.btnInsert = new System.Windows.Forms.Button();
			this.txtLoanAmount = new System.Windows.Forms.TextBox();
			this.txtAdvanceAmount = new System.Windows.Forms.TextBox();
			this.txtEmpName = new System.Windows.Forms.TextBox();
			this.cmbEmpID = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnBack = new System.Windows.Forms.Button();
			this.txtMonths = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// cmbType
			// 
			this.cmbType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.cmbType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.cmbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbType.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.cmbType.FormattingEnabled = true;
			this.cmbType.Items.AddRange(new object[] {
            "Advance",
            "Loan"});
			this.cmbType.Location = new System.Drawing.Point(205, 279);
			this.cmbType.Name = "cmbType";
			this.cmbType.Size = new System.Drawing.Size(243, 28);
			this.cmbType.TabIndex = 32;
			this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
			// 
			// btnInsert
			// 
			this.btnInsert.BackColor = System.Drawing.SystemColors.ControlDark;
			this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnInsert.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnInsert.Location = new System.Drawing.Point(248, 12);
			this.btnInsert.Name = "btnInsert";
			this.btnInsert.Size = new System.Drawing.Size(200, 65);
			this.btnInsert.TabIndex = 30;
			this.btnInsert.Text = "Insert";
			this.btnInsert.UseVisualStyleBackColor = false;
			this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
			// 
			// txtLoanAmount
			// 
			this.txtLoanAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.txtLoanAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtLoanAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtLoanAmount.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.txtLoanAmount.Location = new System.Drawing.Point(205, 345);
			this.txtLoanAmount.Name = "txtLoanAmount";
			this.txtLoanAmount.Size = new System.Drawing.Size(243, 26);
			this.txtLoanAmount.TabIndex = 29;
			// 
			// txtAdvanceAmount
			// 
			this.txtAdvanceAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.txtAdvanceAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtAdvanceAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAdvanceAmount.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.txtAdvanceAmount.Location = new System.Drawing.Point(205, 313);
			this.txtAdvanceAmount.Name = "txtAdvanceAmount";
			this.txtAdvanceAmount.Size = new System.Drawing.Size(243, 26);
			this.txtAdvanceAmount.TabIndex = 28;
			// 
			// txtEmpName
			// 
			this.txtEmpName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.txtEmpName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtEmpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEmpName.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.txtEmpName.Location = new System.Drawing.Point(205, 247);
			this.txtEmpName.Name = "txtEmpName";
			this.txtEmpName.ReadOnly = true;
			this.txtEmpName.Size = new System.Drawing.Size(243, 26);
			this.txtEmpName.TabIndex = 27;
			// 
			// cmbEmpID
			// 
			this.cmbEmpID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.cmbEmpID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.cmbEmpID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbEmpID.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.cmbEmpID.FormattingEnabled = true;
			this.cmbEmpID.Location = new System.Drawing.Point(205, 213);
			this.cmbEmpID.Name = "cmbEmpID";
			this.cmbEmpID.Size = new System.Drawing.Size(243, 28);
			this.cmbEmpID.TabIndex = 26;
			this.cmbEmpID.SelectedIndexChanged += new System.EventHandler(this.cmbEmpID_SelectedIndexChanged);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label8.Location = new System.Drawing.Point(8, 282);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(43, 20);
			this.label8.TabIndex = 24;
			this.label8.Text = "Type";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label5.Location = new System.Drawing.Point(8, 347);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(150, 20);
			this.label5.TabIndex = 21;
			this.label5.Text = "Loan Amount (LKR)";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label4.Location = new System.Drawing.Point(8, 315);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(176, 20);
			this.label4.TabIndex = 20;
			this.label4.Text = "Advance Amount (LKR)";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label3.Location = new System.Drawing.Point(8, 249);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(125, 20);
			this.label3.TabIndex = 19;
			this.label3.Text = "Employee Name";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label2.Location = new System.Drawing.Point(8, 216);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 20);
			this.label2.TabIndex = 18;
			this.label2.Text = "Employee ID";
			// 
			// btnBack
			// 
			this.btnBack.BackColor = System.Drawing.SystemColors.Desktop;
			this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnBack.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.btnBack.Location = new System.Drawing.Point(248, 83);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(200, 65);
			this.btnBack.TabIndex = 35;
			this.btnBack.Text = "Back";
			this.btnBack.UseVisualStyleBackColor = false;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// txtMonths
			// 
			this.txtMonths.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.txtMonths.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtMonths.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMonths.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.txtMonths.Location = new System.Drawing.Point(205, 377);
			this.txtMonths.Name = "txtMonths";
			this.txtMonths.Size = new System.Drawing.Size(243, 26);
			this.txtMonths.TabIndex = 37;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label1.Location = new System.Drawing.Point(8, 379);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(159, 20);
			this.label1.TabIndex = 36;
			this.label1.Text = "Time Period (Months)";
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
			// Advances_Loans
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.ClientSize = new System.Drawing.Size(460, 460);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.txtMonths);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.cmbType);
			this.Controls.Add(this.btnInsert);
			this.Controls.Add(this.txtLoanAmount);
			this.Controls.Add(this.txtAdvanceAmount);
			this.Controls.Add(this.txtEmpName);
			this.Controls.Add(this.cmbEmpID);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Advances_Loans";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Advances_Loans";
			this.Load += new System.EventHandler(this.Advances_Loans_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cmbType;
		private System.Windows.Forms.Button btnInsert;
		private System.Windows.Forms.TextBox txtLoanAmount;
		private System.Windows.Forms.TextBox txtAdvanceAmount;
		private System.Windows.Forms.TextBox txtEmpName;
		private System.Windows.Forms.ComboBox cmbEmpID;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.TextBox txtMonths;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}