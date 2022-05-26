namespace ITP4915
{
	partial class profile
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
			this.labelEmpName = new System.Windows.Forms.Label();
			this.labelEmpID = new System.Windows.Forms.Label();
			this.labelPosition = new System.Windows.Forms.Label();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.SuspendLayout();
			// 
			// labelEmpName
			// 
			this.labelEmpName.AutoSize = true;
			this.labelEmpName.Location = new System.Drawing.Point(206, 233);
			this.labelEmpName.Name = "labelEmpName";
			this.labelEmpName.Size = new System.Drawing.Size(54, 18);
			this.labelEmpName.TabIndex = 0;
			this.labelEmpName.Text = "Name:";
			this.labelEmpName.Click += new System.EventHandler(this.label1_Click);
			// 
			// labelEmpID
			// 
			this.labelEmpID.AutoSize = true;
			this.labelEmpID.Location = new System.Drawing.Point(206, 166);
			this.labelEmpID.Name = "labelEmpID";
			this.labelEmpID.Size = new System.Drawing.Size(104, 18);
			this.labelEmpID.TabIndex = 1;
			this.labelEmpID.Text = "Employee ID:";
			// 
			// labelPosition
			// 
			this.labelPosition.AutoSize = true;
			this.labelPosition.Location = new System.Drawing.Point(206, 304);
			this.labelPosition.Name = "labelPosition";
			this.labelPosition.Size = new System.Drawing.Size(68, 18);
			this.labelPosition.TabIndex = 2;
			this.labelPosition.Text = "Position:";
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Location = new System.Drawing.Point(588, 319);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(117, 18);
			this.linkLabel1.TabIndex = 3;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Reset Password";
			// 
			// profile
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.labelPosition);
			this.Controls.Add(this.labelEmpID);
			this.Controls.Add(this.labelEmpName);
			this.Name = "profile";
			this.Text = "profile";
			this.Load += new System.EventHandler(this.profile_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelEmpName;
		private System.Windows.Forms.Label labelEmpID;
		private System.Windows.Forms.Label labelPosition;
		private System.Windows.Forms.LinkLabel linkLabel1;
	}
}