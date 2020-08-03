namespace Integrated_Projects
{
	partial class DeliveryAgentArea
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeliveryAgentArea));
			this.label1 = new System.Windows.Forms.Label();
			this.cmbOrderID = new System.Windows.Forms.ComboBox();
			this.btnLogout = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radioAgentNot = new System.Windows.Forms.RadioButton();
			this.radioAgent = new System.Windows.Forms.RadioButton();
			this.label3 = new System.Windows.Forms.Label();
			this.btnDeliver = new System.Windows.Forms.Button();
			this.txtTableID = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label1.Location = new System.Drawing.Point(24, 189);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(70, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "Order ID";
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
			this.cmbOrderID.TabIndex = 4;
			this.cmbOrderID.SelectedIndexChanged += new System.EventHandler(this.cmbOrderID_SelectedIndexChanged);
			// 
			// btnLogout
			// 
			this.btnLogout.BackColor = System.Drawing.SystemColors.Desktop;
			this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnLogout.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.btnLogout.Location = new System.Drawing.Point(197, 109);
			this.btnLogout.Name = "btnLogout";
			this.btnLogout.Size = new System.Drawing.Size(200, 65);
			this.btnLogout.TabIndex = 7;
			this.btnLogout.Text = "Logout";
			this.btnLogout.UseVisualStyleBackColor = false;
			this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.radioAgentNot);
			this.groupBox1.Controls.Add(this.radioAgent);
			this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.groupBox1.Location = new System.Drawing.Point(12, 285);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(400, 88);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Delivery Status";
			// 
			// radioAgentNot
			// 
			this.radioAgentNot.AutoSize = true;
			this.radioAgentNot.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.radioAgentNot.Location = new System.Drawing.Point(135, 54);
			this.radioAgentNot.Name = "radioAgentNot";
			this.radioAgentNot.Size = new System.Drawing.Size(151, 24);
			this.radioAgentNot.TabIndex = 1;
			this.radioAgentNot.TabStop = true;
			this.radioAgentNot.Text = "Not Yet Delivered";
			this.radioAgentNot.UseVisualStyleBackColor = true;
			// 
			// radioAgent
			// 
			this.radioAgent.AutoSize = true;
			this.radioAgent.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.radioAgent.Location = new System.Drawing.Point(135, 21);
			this.radioAgent.Name = "radioAgent";
			this.radioAgent.Size = new System.Drawing.Size(93, 24);
			this.radioAgent.TabIndex = 0;
			this.radioAgent.TabStop = true;
			this.radioAgent.Text = "Delivered";
			this.radioAgent.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label3.Location = new System.Drawing.Point(24, 227);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(108, 20);
			this.label3.TabIndex = 9;
			this.label3.Text = "Table Number";
			// 
			// btnDeliver
			// 
			this.btnDeliver.BackColor = System.Drawing.SystemColors.ControlDark;
			this.btnDeliver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnDeliver.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnDeliver.Location = new System.Drawing.Point(197, 38);
			this.btnDeliver.Name = "btnDeliver";
			this.btnDeliver.Size = new System.Drawing.Size(200, 65);
			this.btnDeliver.TabIndex = 11;
			this.btnDeliver.Text = "Delivered";
			this.btnDeliver.UseVisualStyleBackColor = false;
			this.btnDeliver.Click += new System.EventHandler(this.btnDeliver_Click);
			// 
			// txtTableID
			// 
			this.txtTableID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.txtTableID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtTableID.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.txtTableID.Location = new System.Drawing.Point(147, 224);
			this.txtTableID.Name = "txtTableID";
			this.txtTableID.Size = new System.Drawing.Size(250, 26);
			this.txtTableID.TabIndex = 12;
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
			// DeliveryAgentArea
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.ClientSize = new System.Drawing.Size(425, 425);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.txtTableID);
			this.Controls.Add(this.btnDeliver);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnLogout);
			this.Controls.Add(this.cmbOrderID);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "DeliveryAgentArea";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "DeliveryAgentArea";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cmbOrderID;
		private System.Windows.Forms.Button btnLogout;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioAgentNot;
		private System.Windows.Forms.RadioButton radioAgent;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnDeliver;
		private System.Windows.Forms.TextBox txtTableID;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}