namespace Integrated_Projects
{
	partial class ChefArea
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChefArea));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radioNotFin = new System.Windows.Forms.RadioButton();
			this.radioFin = new System.Windows.Forms.RadioButton();
			this.btnLogout = new System.Windows.Forms.Button();
			this.cmbOrderID = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.btnDeliver = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.radioNotFin);
			this.groupBox1.Controls.Add(this.radioFin);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.groupBox1.Location = new System.Drawing.Point(12, 330);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(400, 88);
			this.groupBox1.TabIndex = 18;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Delivery Status";
			// 
			// radioNotFin
			// 
			this.radioNotFin.AutoSize = true;
			this.radioNotFin.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.radioNotFin.Location = new System.Drawing.Point(135, 55);
			this.radioNotFin.Name = "radioNotFin";
			this.radioNotFin.Size = new System.Drawing.Size(145, 24);
			this.radioNotFin.TabIndex = 1;
			this.radioNotFin.TabStop = true;
			this.radioNotFin.Text = "Not Yet Finished";
			this.radioNotFin.UseVisualStyleBackColor = true;
			// 
			// radioFin
			// 
			this.radioFin.AutoSize = true;
			this.radioFin.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.radioFin.Location = new System.Drawing.Point(135, 25);
			this.radioFin.Name = "radioFin";
			this.radioFin.Size = new System.Drawing.Size(87, 24);
			this.radioFin.TabIndex = 0;
			this.radioFin.TabStop = true;
			this.radioFin.Text = "Finished";
			this.radioFin.UseVisualStyleBackColor = true;
			// 
			// btnLogout
			// 
			this.btnLogout.BackColor = System.Drawing.SystemColors.Desktop;
			this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnLogout.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.btnLogout.Location = new System.Drawing.Point(197, 107);
			this.btnLogout.Name = "btnLogout";
			this.btnLogout.Size = new System.Drawing.Size(200, 65);
			this.btnLogout.TabIndex = 17;
			this.btnLogout.Text = "Logout";
			this.btnLogout.UseVisualStyleBackColor = false;
			this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
			// 
			// cmbOrderID
			// 
			this.cmbOrderID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.cmbOrderID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.cmbOrderID.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.cmbOrderID.FormattingEnabled = true;
			this.cmbOrderID.Location = new System.Drawing.Point(147, 186);
			this.cmbOrderID.Name = "cmbOrderID";
			this.cmbOrderID.Size = new System.Drawing.Size(250, 28);
			this.cmbOrderID.TabIndex = 15;
			this.cmbOrderID.SelectedIndexChanged += new System.EventHandler(this.cmbOrderID_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label1.Location = new System.Drawing.Point(24, 189);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(70, 20);
			this.label1.TabIndex = 13;
			this.label1.Text = "Order ID";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label2.Location = new System.Drawing.Point(24, 227);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(89, 20);
			this.label2.TabIndex = 19;
			this.label2.Text = "Description";
			// 
			// richTextBox1
			// 
			this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.richTextBox1.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.richTextBox1.Location = new System.Drawing.Point(147, 224);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(250, 100);
			this.richTextBox1.TabIndex = 20;
			this.richTextBox1.Text = "";
			// 
			// btnDeliver
			// 
			this.btnDeliver.BackColor = System.Drawing.SystemColors.ControlDark;
			this.btnDeliver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnDeliver.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnDeliver.Location = new System.Drawing.Point(197, 38);
			this.btnDeliver.Name = "btnDeliver";
			this.btnDeliver.Size = new System.Drawing.Size(200, 65);
			this.btnDeliver.TabIndex = 24;
			this.btnDeliver.Text = "Cooked";
			this.btnDeliver.UseVisualStyleBackColor = false;
			this.btnDeliver.Click += new System.EventHandler(this.btnDeliver_Click);
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
			// ChefArea
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.ClientSize = new System.Drawing.Size(425, 425);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnDeliver);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnLogout);
			this.Controls.Add(this.cmbOrderID);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "ChefArea";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ChefArea";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioNotFin;
		private System.Windows.Forms.RadioButton radioFin;
		private System.Windows.Forms.Button btnLogout;
		private System.Windows.Forms.ComboBox cmbOrderID;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Button btnDeliver;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}