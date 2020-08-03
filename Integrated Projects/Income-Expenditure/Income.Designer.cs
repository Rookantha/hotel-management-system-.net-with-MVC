namespace Integrated_Projects.Income_Expenditure
{
	partial class Income
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Income));
			this.btnBack = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtIncomeValue = new System.Windows.Forms.TextBox();
			this.txtDescription = new System.Windows.Forms.RichTextBox();
			this.btnInsert = new System.Windows.Forms.Button();
			this.txtIncomeID = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
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
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label2.Location = new System.Drawing.Point(8, 250);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(107, 20);
			this.label2.TabIndex = 10;
			this.label2.Text = "Income (LKR)";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label3.Location = new System.Drawing.Point(8, 300);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(89, 20);
			this.label3.TabIndex = 11;
			this.label3.Text = "Description";
			// 
			// txtIncomeValue
			// 
			this.txtIncomeValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.txtIncomeValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtIncomeValue.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.txtIncomeValue.Location = new System.Drawing.Point(150, 248);
			this.txtIncomeValue.Name = "txtIncomeValue";
			this.txtIncomeValue.Size = new System.Drawing.Size(273, 26);
			this.txtIncomeValue.TabIndex = 12;
			// 
			// txtDescription
			// 
			this.txtDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtDescription.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.txtDescription.Location = new System.Drawing.Point(150, 298);
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(273, 100);
			this.txtDescription.TabIndex = 14;
			this.txtDescription.Text = "";
			// 
			// btnInsert
			// 
			this.btnInsert.BackColor = System.Drawing.SystemColors.ControlDark;
			this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnInsert.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnInsert.Location = new System.Drawing.Point(223, 12);
			this.btnInsert.Name = "btnInsert";
			this.btnInsert.Size = new System.Drawing.Size(200, 65);
			this.btnInsert.TabIndex = 15;
			this.btnInsert.Text = "Insert";
			this.btnInsert.UseVisualStyleBackColor = false;
			this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
			// 
			// txtIncomeID
			// 
			this.txtIncomeID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.txtIncomeID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtIncomeID.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.txtIncomeID.Location = new System.Drawing.Point(150, 198);
			this.txtIncomeID.Name = "txtIncomeID";
			this.txtIncomeID.Size = new System.Drawing.Size(273, 26);
			this.txtIncomeID.TabIndex = 17;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label4.Location = new System.Drawing.Point(8, 200);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(83, 20);
			this.label4.TabIndex = 16;
			this.label4.Text = "Income ID";
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
			this.pictureBox1.TabIndex = 58;
			this.pictureBox1.TabStop = false;
			// 
			// Income
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.ClientSize = new System.Drawing.Size(435, 435);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.txtIncomeID);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnInsert);
			this.Controls.Add(this.txtDescription);
			this.Controls.Add(this.txtIncomeValue);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnBack);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Income";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Income";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtIncomeValue;
		private System.Windows.Forms.RichTextBox txtDescription;
		private System.Windows.Forms.Button btnInsert;
		private System.Windows.Forms.TextBox txtIncomeID;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}