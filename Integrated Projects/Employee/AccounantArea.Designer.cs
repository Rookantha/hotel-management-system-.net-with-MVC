namespace Integrated_Projects
{
	partial class AccounantArea
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccounantArea));
			this.btnPayroll = new System.Windows.Forms.Button();
			this.btnIncome = new System.Windows.Forms.Button();
			this.btnProfit = new System.Windows.Forms.Button();
			this.btnExpenditure = new System.Windows.Forms.Button();
			this.btnLogout = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnPayroll
			// 
			this.btnPayroll.BackColor = System.Drawing.SystemColors.ControlDark;
			this.btnPayroll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnPayroll.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnPayroll.Location = new System.Drawing.Point(197, 38);
			this.btnPayroll.Name = "btnPayroll";
			this.btnPayroll.Size = new System.Drawing.Size(200, 65);
			this.btnPayroll.TabIndex = 1;
			this.btnPayroll.Text = "Payroll";
			this.btnPayroll.UseVisualStyleBackColor = false;
			this.btnPayroll.Click += new System.EventHandler(this.btnEmpRegister_Click);
			// 
			// btnIncome
			// 
			this.btnIncome.BackColor = System.Drawing.SystemColors.ControlDark;
			this.btnIncome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnIncome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnIncome.Location = new System.Drawing.Point(197, 109);
			this.btnIncome.Name = "btnIncome";
			this.btnIncome.Size = new System.Drawing.Size(200, 65);
			this.btnIncome.TabIndex = 2;
			this.btnIncome.Text = "Incomes";
			this.btnIncome.UseVisualStyleBackColor = false;
			this.btnIncome.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnProfit
			// 
			this.btnProfit.BackColor = System.Drawing.SystemColors.ControlDark;
			this.btnProfit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnProfit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnProfit.Location = new System.Drawing.Point(197, 251);
			this.btnProfit.Name = "btnProfit";
			this.btnProfit.Size = new System.Drawing.Size(200, 65);
			this.btnProfit.TabIndex = 3;
			this.btnProfit.Text = "Profit / Loss";
			this.btnProfit.UseVisualStyleBackColor = false;
			this.btnProfit.Click += new System.EventHandler(this.btnProfit_Click);
			// 
			// btnExpenditure
			// 
			this.btnExpenditure.BackColor = System.Drawing.SystemColors.ControlDark;
			this.btnExpenditure.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnExpenditure.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnExpenditure.Location = new System.Drawing.Point(197, 180);
			this.btnExpenditure.Name = "btnExpenditure";
			this.btnExpenditure.Size = new System.Drawing.Size(200, 65);
			this.btnExpenditure.TabIndex = 4;
			this.btnExpenditure.Text = "Expenditure";
			this.btnExpenditure.UseVisualStyleBackColor = false;
			this.btnExpenditure.Click += new System.EventHandler(this.btnExpenditure_Click);
			// 
			// btnLogout
			// 
			this.btnLogout.BackColor = System.Drawing.SystemColors.Desktop;
			this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnLogout.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.btnLogout.Location = new System.Drawing.Point(197, 322);
			this.btnLogout.Name = "btnLogout";
			this.btnLogout.Size = new System.Drawing.Size(200, 65);
			this.btnLogout.TabIndex = 5;
			this.btnLogout.Text = "Logout";
			this.btnLogout.UseVisualStyleBackColor = false;
			this.btnLogout.Click += new System.EventHandler(this.button4_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(12, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(150, 150);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 57;
			this.pictureBox1.TabStop = false;
			// 
			// AccounantArea
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.ClientSize = new System.Drawing.Size(425, 425);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnLogout);
			this.Controls.Add(this.btnExpenditure);
			this.Controls.Add(this.btnProfit);
			this.Controls.Add(this.btnIncome);
			this.Controls.Add(this.btnPayroll);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "AccounantArea";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AccounantArea";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnPayroll;
		private System.Windows.Forms.Button btnIncome;
		private System.Windows.Forms.Button btnProfit;
		private System.Windows.Forms.Button btnExpenditure;
		private System.Windows.Forms.Button btnLogout;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}