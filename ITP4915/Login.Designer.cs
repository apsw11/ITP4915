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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.textEmpID = new System.Windows.Forms.TextBox();
            this.textBoxPS = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox_Show_Hide_Password = new System.Windows.Forms.CheckBox();
            this.labpwdshow = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.closebutton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textEmpID
            // 
            this.textEmpID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(85)))), ((int)(((byte)(148)))));
            this.textEmpID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textEmpID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textEmpID.ForeColor = System.Drawing.Color.White;
            this.textEmpID.Location = new System.Drawing.Point(325, 134);
            this.textEmpID.Margin = new System.Windows.Forms.Padding(2);
            this.textEmpID.Name = "textEmpID";
            this.textEmpID.Size = new System.Drawing.Size(181, 19);
            this.textEmpID.TabIndex = 1;
            this.textEmpID.Text = "S11001";
            // 
            // textBoxPS
            // 
            this.textBoxPS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(85)))), ((int)(((byte)(148)))));
            this.textBoxPS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxPS.ForeColor = System.Drawing.Color.White;
            this.textBoxPS.Location = new System.Drawing.Point(325, 208);
            this.textBoxPS.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPS.Name = "textBoxPS";
            this.textBoxPS.Size = new System.Drawing.Size(181, 19);
            this.textBoxPS.TabIndex = 3;
            this.textBoxPS.Text = "123";
            this.textBoxPS.UseSystemPasswordChar = true;
            // 
            // buttonLogin
            // 
            this.buttonLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(85)))), ((int)(((byte)(148)))));
            this.buttonLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(85)))), ((int)(((byte)(148)))));
            this.buttonLogin.Location = new System.Drawing.Point(251, 269);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(149, 28);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Enter";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(52)))), ((int)(((byte)(98)))));
            this.panel1.Controls.Add(this.buttonLogin);
            this.panel1.Controls.Add(this.textBoxPS);
            this.panel1.Controls.Add(this.checkBox_Show_Hide_Password);
            this.panel1.Controls.Add(this.textEmpID);
            this.panel1.Controls.Add(this.labpwdshow);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(42, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(674, 327);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // checkBox_Show_Hide_Password
            // 
            this.checkBox_Show_Hide_Password.AutoSize = true;
            this.checkBox_Show_Hide_Password.Location = new System.Drawing.Point(549, 299);
            this.checkBox_Show_Hide_Password.Name = "checkBox_Show_Hide_Password";
            this.checkBox_Show_Hide_Password.Size = new System.Drawing.Size(15, 14);
            this.checkBox_Show_Hide_Password.TabIndex = 9;
            this.checkBox_Show_Hide_Password.UseVisualStyleBackColor = true;
            this.checkBox_Show_Hide_Password.CheckedChanged += new System.EventHandler(this.checkBox_Show_Hide_Password_CheckedChanged);
            // 
            // labpwdshow
            // 
            this.labpwdshow.AutoSize = true;
            this.labpwdshow.BackColor = System.Drawing.Color.Transparent;
            this.labpwdshow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labpwdshow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labpwdshow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(85)))), ((int)(((byte)(148)))));
            this.labpwdshow.Location = new System.Drawing.Point(443, 301);
            this.labpwdshow.Name = "labpwdshow";
            this.labpwdshow.Size = new System.Drawing.Size(95, 15);
            this.labpwdshow.TabIndex = 8;
            this.labpwdshow.Text = "Show Password";
            this.labpwdshow.Click += new System.EventHandler(this.labpwdshow_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(85)))), ((int)(((byte)(148)))));
            this.label1.Location = new System.Drawing.Point(232, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 61);
            this.label1.TabIndex = 6;
            this.label1.Text = "LOGIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(85)))), ((int)(((byte)(148)))));
            this.label2.Location = new System.Drawing.Point(184, 208);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(85)))), ((int)(((byte)(148)))));
            this.label3.Location = new System.Drawing.Point(160, 134);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Employee ID:";
            // 
            // closebutton
            // 
            this.closebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.closebutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closebutton.BackgroundImage")));
            this.closebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.closebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closebutton.FlatAppearance.BorderSize = 0;
            this.closebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closebutton.Location = new System.Drawing.Point(698, 1);
            this.closebutton.Margin = new System.Windows.Forms.Padding(2);
            this.closebutton.Name = "closebutton";
            this.closebutton.Size = new System.Drawing.Size(60, 48);
            this.closebutton.TabIndex = 10;
            this.closebutton.UseVisualStyleBackColor = false;
            this.closebutton.Click += new System.EventHandler(this.closebutton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(52)))), ((int)(((byte)(98)))));
            this.ClientSize = new System.Drawing.Size(755, 351);
            this.Controls.Add(this.closebutton);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.TextBox textEmpID;
		private System.Windows.Forms.TextBox textBoxPS;
		private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button closebutton;
        private System.Windows.Forms.CheckBox checkBox_Show_Hide_Password;
        private System.Windows.Forms.Label labpwdshow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}