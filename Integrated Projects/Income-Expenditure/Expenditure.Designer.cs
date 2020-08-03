namespace Integrated_Projects.Income_Expenditure
{
	partial class Expenditure
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Expenditure));
			this.btnBack = new System.Windows.Forms.Button();
			this.txtExpenseDescription = new System.Windows.Forms.RichTextBox();
			this.txtExpenseAmount = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnInsert = new System.Windows.Forms.Button();
			this.txtExpensesID = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnBack
			// 
			this.btnBack.BackColor = System.Drawing.SystemColors.Desktop;
			this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnBack.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.btnBack.Location = new System.Drawing.Point(223, 83);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(200, 65);
			this.btnBack.TabIndex = 8;
			this.btnBack.Text = "Back";
			this.btnBack.UseVisualStyleBackColor = false;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// txtExpenseDescription
			// 
			this.txtExpenseDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.txtExpenseDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtExpenseDescription.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.txtExpenseDescription.Location = new System.Drawing.Point(150, 298);
			this.txtExpenseDescription.Name = "txtExpenseDescription";
			this.txtExpenseDescription.Size = new System.Drawing.Size(273, 100);
			this.txtExpenseDescription.TabIndex = 20;
			this.txtExpenseDescription.Text = "";
			// 
			// txtExpenseAmount
			// 
			this.txtExpenseAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.txtExpenseAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtExpenseAmount.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.txtExpenseAmount.Location = new System.Drawing.Point(150, 248);
			this.txtExpenseAmount.Name = "txtExpenseAmount";
			this.txtExpenseAmount.Size = new System.Drawing.Size(273, 26);
			this.txtExpenseAmount.TabIndex = 19;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label3.Location = new System.Drawing.Point(8, 300);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(89, 20);
			this.label3.TabIndex = 18;
			this.label3.Text = "Description";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label2.Location = new System.Drawing.Point(8, 250);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(139, 20);
			this.label2.TabIndex = 17;
			this.label2.Text = "Expenditure (LKR)";
			// 
			// btnInsert
			// 
			this.btnInsert.BackColor = System.Drawing.SystemColors.ControlDark;
			this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnInsert.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnInsert.Location = new System.Drawing.Point(223, 12);
			this.btnInsert.Name = "btnInsert";
			this.btnInsert.Size = new System.Drawing.Size(200, 65);
			this.btnInsert.TabIndex = 25;
			this.btnInsert.Text = "Insert";
			this.btnInsert.UseVisualStyleBackColor = false;
			this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
			// 
			// txtExpensesID
			// 
			this.txtExpensesID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.txtExpensesID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtExpensesID.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.txtExpensesID.Location = new System.Drawing.Point(150, 198);
			this.txtExpensesID.Name = "txtExpensesID";
			this.txtExpensesID.Size = new System.Drawing.Size(273, 26);
			this.txtExpensesID.TabIndex = 27;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label6.Location = new System.Drawing.Point(8, 200);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 20);
			this.label6.TabIndex = 26;
			this.label6.Text = "Expenses ID";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(12, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(150, 150);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 58;
			this.pictureBox1.TabStop = false;
			// 
			// Expenditure
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.ClientSize = new System.Drawing.Size(435, 435);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.txtExpensesID);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.btnInsert);
			this.Controls.Add(this.txtExpenseDescription);
			this.Controls.Add(this.txtExpenseAmount);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnBack);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Expenditure";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Expenditure";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.RichTextBox txtExpenseDescription;
		private System.Windows.Forms.TextBox txtExpenseAmount;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnInsert;
		private System.Windows.Forms.TextBox txtExpensesID;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}