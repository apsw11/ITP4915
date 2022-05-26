namespace ITP4915
{
	partial class Login
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
			this.labelEmpID = new System.Windows.Forms.Label();
			this.textEmpID = new System.Windows.Forms.TextBox();
			this.textBoxPS = new System.Windows.Forms.TextBox();
			this.labelPassword = new System.Windows.Forms.Label();
			this.buttonLogin = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// labelEmpID
			// 
			this.labelEmpID.AutoSize = true;
			this.labelEmpID.Font = new System.Drawing.Font("PMingLiU", 12F);
			this.labelEmpID.Location = new System.Drawing.Point(211, 185);
			this.labelEmpID.Name = "labelEmpID";
			this.labelEmpID.Size = new System.Drawing.Size(137, 24);
			this.labelEmpID.TabIndex = 0;
			this.labelEmpID.Text = "Employee ID:";
			// 
			// textEmpID
			// 
			this.textEmpID.Font = new System.Drawing.Font("PMingLiU", 12F);
			this.textEmpID.Location = new System.Drawing.Point(370, 173);
			this.textEmpID.Name = "textEmpID";
			this.textEmpID.Size = new System.Drawing.Size(148, 36);
			this.textEmpID.TabIndex = 1;
			// 
			// textBoxPS
			// 
			this.textBoxPS.Font = new System.Drawing.Font("PMingLiU", 12F);
			this.textBoxPS.Location = new System.Drawing.Point(370, 265);
			this.textBoxPS.Name = "textBoxPS";
			this.textBoxPS.Size = new System.Drawing.Size(148, 36);
			this.textBoxPS.TabIndex = 3;
			this.textBoxPS.UseSystemPasswordChar = true;
			// 
			// labelPassword
			// 
			this.labelPassword.AutoSize = true;
			this.labelPassword.Font = new System.Drawing.Font("PMingLiU", 12F);
			this.labelPassword.Location = new System.Drawing.Point(211, 277);
			this.labelPassword.Name = "labelPassword";
			this.labelPassword.Size = new System.Drawing.Size(103, 24);
			this.labelPassword.TabIndex = 2;
			this.labelPassword.Text = "Password:";
			// 
			// buttonLogin
			// 
			this.buttonLogin.Location = new System.Drawing.Point(215, 352);
			this.buttonLogin.Name = "buttonLogin";
			this.buttonLogin.Size = new System.Drawing.Size(133, 42);
			this.buttonLogin.TabIndex = 4;
			this.buttonLogin.Text = "Enter";
			this.buttonLogin.UseVisualStyleBackColor = true;
			this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.buttonLogin);
			this.Controls.Add(this.textBoxPS);
			this.Controls.Add(this.labelPassword);
			this.Controls.Add(this.textEmpID);
			this.Controls.Add(this.labelEmpID);
			this.Name = "Login";
			this.Text = "Login";
			this.Load += new System.EventHandler(this.Login_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelEmpID;
		private System.Windows.Forms.TextBox textEmpID;
		private System.Windows.Forms.TextBox textBoxPS;
		private System.Windows.Forms.Label labelPassword;
		private System.Windows.Forms.Button buttonLogin;
	}
}