namespace Integrated_Projects.Employee.Reports
{
	partial class ProfitabilityDetails
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfitabilityDetails));
			this.dataIncome = new System.Windows.Forms.DataGridView();
			this.dataExpense = new System.Windows.Forms.DataGridView();
			this.dataProfitability = new System.Windows.Forms.DataGridView();
			this.btnBack = new System.Windows.Forms.Button();
			this.btnAll = new System.Windows.Forms.Button();
			this.btnMonth = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.monthprofit = new System.Windows.Forms.MonthCalendar();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.dataIncome)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataExpense)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataProfitability)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataIncome
			// 
			this.dataIncome.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataIncome.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.dataIncome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataIncome.Location = new System.Drawing.Point(9, 223);
			this.dataIncome.Name = "dataIncome";
			this.dataIncome.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dataIncome.Size = new System.Drawing.Size(720, 125);
			this.dataIncome.TabIndex = 0;
			// 
			// dataExpense
			// 
			this.dataExpense.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataExpense.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.dataExpense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataExpense.Location = new System.Drawing.Point(9, 377);
			this.dataExpense.Name = "dataExpense";
			this.dataExpense.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dataExpense.Size = new System.Drawing.Size(720, 125);
			this.dataExpense.TabIndex = 1;
			// 
			// dataProfitability
			// 
			this.dataProfitability.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataProfitability.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.dataProfitability.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataProfitability.Location = new System.Drawing.Point(9, 532);
			this.dataProfitability.Name = "dataProfitability";
			this.dataProfitability.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dataProfitability.Size = new System.Drawing.Size(720, 125);
			this.dataProfitability.TabIndex = 2;
			// 
			// btnBack
			// 
			this.btnBack.BackColor = System.Drawing.SystemColors.Desktop;
			this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnBack.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.btnBack.Location = new System.Drawing.Point(529, 154);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(200, 65);
			this.btnBack.TabIndex = 3;
			this.btnBack.Text = "Back";
			this.btnBack.UseVisualStyleBackColor = false;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// btnAll
			// 
			this.btnAll.BackColor = System.Drawing.SystemColors.ControlDark;
			this.btnAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnAll.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnAll.Location = new System.Drawing.Point(529, 83);
			this.btnAll.Name = "btnAll";
			this.btnAll.Size = new System.Drawing.Size(200, 65);
			this.btnAll.TabIndex = 7;
			this.btnAll.Text = "All Details";
			this.btnAll.UseVisualStyleBackColor = false;
			this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
			// 
			// btnMonth
			// 
			this.btnMonth.BackColor = System.Drawing.SystemColors.ControlDark;
			this.btnMonth.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnMonth.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnMonth.Location = new System.Drawing.Point(529, 12);
			this.btnMonth.Name = "btnMonth";
			this.btnMonth.Size = new System.Drawing.Size(200, 65);
			this.btnMonth.TabIndex = 8;
			this.btnMonth.Text = "Monthly Details";
			this.btnMonth.UseVisualStyleBackColor = false;
			this.btnMonth.Click += new System.EventHandler(this.btnMonth_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label2.Location = new System.Drawing.Point(14, 200);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 20);
			this.label2.TabIndex = 9;
			this.label2.Text = "Incomes";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label3.Location = new System.Drawing.Point(14, 354);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(79, 20);
			this.label3.TabIndex = 10;
			this.label3.Text = "Expenses";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label4.Location = new System.Drawing.Point(14, 509);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(85, 20);
			this.label4.TabIndex = 11;
			this.label4.Text = "Profitability";
			// 
			// monthprofit
			// 
			this.monthprofit.Location = new System.Drawing.Point(256, 12);
			this.monthprofit.Name = "monthprofit";
			this.monthprofit.TabIndex = 12;
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
			this.pictureBox1.TabIndex = 63;
			this.pictureBox1.TabStop = false;
			// 
			// ProfitabilityDetails
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.ClientSize = new System.Drawing.Size(738, 681);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.monthprofit);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnMonth);
			this.Controls.Add(this.btnAll);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.dataProfitability);
			this.Controls.Add(this.dataExpense);
			this.Controls.Add(this.dataIncome);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "ProfitabilityDetails";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ProfitabilityDetails";
			((System.ComponentModel.ISupportInitialize)(this.dataIncome)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataExpense)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataProfitability)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataIncome;
		private System.Windows.Forms.DataGridView dataExpense;
		private System.Windows.Forms.DataGridView dataProfitability;
		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.Button btnAll;
		private System.Windows.Forms.Button btnMonth;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.MonthCalendar monthprofit;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}