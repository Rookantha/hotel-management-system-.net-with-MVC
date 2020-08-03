namespace Integrated_Projects.Payroll
{
	partial class PayLoanAdvance
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayLoanAdvance));
			this.btnBack = new System.Windows.Forms.Button();
			this.btnInsert = new System.Windows.Forms.Button();
			this.txtLoanAmount = new System.Windows.Forms.TextBox();
			this.txtInstallment = new System.Windows.Forms.TextBox();
			this.cmbEmpID = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtRemain = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtLoanRemain = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtLoanPayNow = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.btnCheck = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnBack
			// 
			this.btnBack.BackColor = System.Drawing.SystemColors.Desktop;
			this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnBack.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.btnBack.Location = new System.Drawing.Point(248, 154);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(200, 65);
			this.btnBack.TabIndex = 51;
			this.btnBack.Text = "Back";
			this.btnBack.UseVisualStyleBackColor = false;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// btnInsert
			// 
			this.btnInsert.BackColor = System.Drawing.SystemColors.ControlDark;
			this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnInsert.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnInsert.Location = new System.Drawing.Point(248, 83);
			this.btnInsert.Name = "btnInsert";
			this.btnInsert.Size = new System.Drawing.Size(200, 65);
			this.btnInsert.TabIndex = 47;
			this.btnInsert.Text = "Pay";
			this.btnInsert.UseVisualStyleBackColor = false;
			this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
			// 
			// txtLoanAmount
			// 
			this.txtLoanAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.txtLoanAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtLoanAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtLoanAmount.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.txtLoanAmount.Location = new System.Drawing.Point(205, 296);
			this.txtLoanAmount.Name = "txtLoanAmount";
			this.txtLoanAmount.Size = new System.Drawing.Size(243, 26);
			this.txtLoanAmount.TabIndex = 46;
			// 
			// txtInstallment
			// 
			this.txtInstallment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.txtInstallment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtInstallment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtInstallment.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.txtInstallment.Location = new System.Drawing.Point(205, 265);
			this.txtInstallment.Name = "txtInstallment";
			this.txtInstallment.ReadOnly = true;
			this.txtInstallment.Size = new System.Drawing.Size(243, 26);
			this.txtInstallment.TabIndex = 44;
			// 
			// cmbEmpID
			// 
			this.cmbEmpID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.cmbEmpID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.cmbEmpID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbEmpID.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.cmbEmpID.FormattingEnabled = true;
			this.cmbEmpID.Location = new System.Drawing.Point(205, 231);
			this.cmbEmpID.Name = "cmbEmpID";
			this.cmbEmpID.Size = new System.Drawing.Size(243, 28);
			this.cmbEmpID.TabIndex = 43;
			this.cmbEmpID.SelectedIndexChanged += new System.EventHandler(this.cmbEmpID_SelectedIndexChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label5.Location = new System.Drawing.Point(8, 298);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(150, 20);
			this.label5.TabIndex = 41;
			this.label5.Text = "Loan Amount (LKR)";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label3.Location = new System.Drawing.Point(8, 267);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(95, 20);
			this.label3.TabIndex = 39;
			this.label3.Text = "Installments";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label2.Location = new System.Drawing.Point(8, 234);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 20);
			this.label2.TabIndex = 38;
			this.label2.Text = "Employee ID";
			// 
			// txtRemain
			// 
			this.txtRemain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.txtRemain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtRemain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRemain.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.txtRemain.Location = new System.Drawing.Point(205, 392);
			this.txtRemain.Name = "txtRemain";
			this.txtRemain.ReadOnly = true;
			this.txtRemain.Size = new System.Drawing.Size(243, 26);
			this.txtRemain.TabIndex = 55;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label4.Location = new System.Drawing.Point(8, 394);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(175, 20);
			this.label4.TabIndex = 54;
			this.label4.Text = "Installments Remaining";
			// 
			// txtLoanRemain
			// 
			this.txtLoanRemain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.txtLoanRemain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtLoanRemain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtLoanRemain.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.txtLoanRemain.Location = new System.Drawing.Point(205, 360);
			this.txtLoanRemain.Name = "txtLoanRemain";
			this.txtLoanRemain.Size = new System.Drawing.Size(243, 26);
			this.txtLoanRemain.TabIndex = 57;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label1.Location = new System.Drawing.Point(8, 362);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(184, 20);
			this.label1.TabIndex = 56;
			this.label1.Text = "Loan Amount Due (LKR)";
			// 
			// txtLoanPayNow
			// 
			this.txtLoanPayNow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.txtLoanPayNow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtLoanPayNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtLoanPayNow.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.txtLoanPayNow.Location = new System.Drawing.Point(205, 328);
			this.txtLoanPayNow.Name = "txtLoanPayNow";
			this.txtLoanPayNow.Size = new System.Drawing.Size(243, 26);
			this.txtLoanPayNow.TabIndex = 59;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label6.Location = new System.Drawing.Point(8, 330);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(146, 20);
			this.label6.TabIndex = 58;
			this.label6.Text = "Installments Paying";
			// 
			// btnCheck
			// 
			this.btnCheck.BackColor = System.Drawing.SystemColors.ControlDark;
			this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCheck.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnCheck.Location = new System.Drawing.Point(248, 12);
			this.btnCheck.Name = "btnCheck";
			this.btnCheck.Size = new System.Drawing.Size(200, 65);
			this.btnCheck.TabIndex = 60;
			this.btnCheck.Text = "Check";
			this.btnCheck.UseVisualStyleBackColor = false;
			this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
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
			this.pictureBox1.TabIndex = 61;
			this.pictureBox1.TabStop = false;
			// 
			// PayLoanAdvance
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.ClientSize = new System.Drawing.Size(460, 460);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnCheck);
			this.Controls.Add(this.txtLoanPayNow);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtLoanRemain);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtRemain);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.btnInsert);
			this.Controls.Add(this.txtLoanAmount);
			this.Controls.Add(this.txtInstallment);
			this.Controls.Add(this.cmbEmpID);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "PayLoanAdvance";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "PayLoanAdvance";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.Button btnInsert;
		private System.Windows.Forms.TextBox txtLoanAmount;
		private System.Windows.Forms.TextBox txtInstallment;
		private System.Windows.Forms.ComboBox cmbEmpID;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtRemain;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtLoanRemain;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtLoanPayNow;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btnCheck;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}