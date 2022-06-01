namespace ITP4915
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.panel1 = new System.Windows.Forms.Panel();
			this.buttonBell = new System.Windows.Forms.Button();
			this.buttonProfile = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.buttonModifyItem = new System.Windows.Forms.Button();
			this.buttonViewOrder = new System.Windows.Forms.Button();
			this.buttonCreateOrder = new System.Windows.Forms.Button();
			this.buttonHome = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.labelEmpID = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panelDesktopPane = new System.Windows.Forms.Panel();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
			this.panel1.Controls.Add(this.buttonBell);
			this.panel1.Controls.Add(this.buttonProfile);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1620, 56);
			this.panel1.TabIndex = 0;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// buttonBell
			// 
			this.buttonBell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonBell.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBell.BackgroundImage")));
			this.buttonBell.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.buttonBell.FlatAppearance.BorderSize = 0;
			this.buttonBell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonBell.Location = new System.Drawing.Point(1486, 4);
			this.buttonBell.Name = "buttonBell";
			this.buttonBell.Size = new System.Drawing.Size(52, 46);
			this.buttonBell.TabIndex = 3;
			this.buttonBell.UseVisualStyleBackColor = true;
			this.buttonBell.Visible = false;
			this.buttonBell.Click += new System.EventHandler(this.buttonBell_Click);
			// 
			// buttonProfile
			// 
			this.buttonProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonProfile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonProfile.BackgroundImage")));
			this.buttonProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.buttonProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonProfile.Location = new System.Drawing.Point(1545, 6);
			this.buttonProfile.Name = "buttonProfile";
			this.buttonProfile.Size = new System.Drawing.Size(58, 45);
			this.buttonProfile.TabIndex = 2;
			this.buttonProfile.UseVisualStyleBackColor = true;
			this.buttonProfile.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Transparent;
			this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(12, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(42, 34);
			this.button1.TabIndex = 1;
			this.button1.UseVisualStyleBackColor = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.label1.Location = new System.Drawing.Point(76, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(145, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "Main Menu";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
			this.panel2.Controls.Add(this.buttonModifyItem);
			this.panel2.Controls.Add(this.buttonViewOrder);
			this.panel2.Controls.Add(this.buttonCreateOrder);
			this.panel2.Controls.Add(this.buttonHome);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel2.Location = new System.Drawing.Point(0, 56);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(196, 946);
			this.panel2.TabIndex = 1;
			// 
			// buttonModifyItem
			// 
			this.buttonModifyItem.FlatAppearance.BorderSize = 0;
			this.buttonModifyItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonModifyItem.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonModifyItem.ForeColor = System.Drawing.Color.White;
			this.buttonModifyItem.Location = new System.Drawing.Point(0, 363);
			this.buttonModifyItem.Margin = new System.Windows.Forms.Padding(4);
			this.buttonModifyItem.Name = "buttonModifyItem";
			this.buttonModifyItem.Size = new System.Drawing.Size(196, 108);
			this.buttonModifyItem.TabIndex = 8;
			this.buttonModifyItem.Text = "Modify Items";
			this.buttonModifyItem.UseVisualStyleBackColor = true;
			this.buttonModifyItem.Visible = false;
			this.buttonModifyItem.Click += new System.EventHandler(this.button7_Click);
			// 
			// buttonViewOrder
			// 
			this.buttonViewOrder.FlatAppearance.BorderSize = 0;
			this.buttonViewOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonViewOrder.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonViewOrder.ForeColor = System.Drawing.Color.White;
			this.buttonViewOrder.Location = new System.Drawing.Point(0, 222);
			this.buttonViewOrder.Margin = new System.Windows.Forms.Padding(4);
			this.buttonViewOrder.Name = "buttonViewOrder";
			this.buttonViewOrder.Size = new System.Drawing.Size(196, 108);
			this.buttonViewOrder.TabIndex = 7;
			this.buttonViewOrder.Text = "View order";
			this.buttonViewOrder.UseVisualStyleBackColor = true;
			this.buttonViewOrder.Click += new System.EventHandler(this.button6_Click);
			// 
			// buttonCreateOrder
			// 
			this.buttonCreateOrder.FlatAppearance.BorderSize = 0;
			this.buttonCreateOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonCreateOrder.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonCreateOrder.ForeColor = System.Drawing.Color.White;
			this.buttonCreateOrder.Location = new System.Drawing.Point(-4, 116);
			this.buttonCreateOrder.Margin = new System.Windows.Forms.Padding(4);
			this.buttonCreateOrder.Name = "buttonCreateOrder";
			this.buttonCreateOrder.Size = new System.Drawing.Size(196, 98);
			this.buttonCreateOrder.TabIndex = 6;
			this.buttonCreateOrder.Text = "CreateOrder";
			this.buttonCreateOrder.UseVisualStyleBackColor = true;
			this.buttonCreateOrder.Click += new System.EventHandler(this.button5_Click);
			// 
			// buttonHome
			// 
			this.buttonHome.FlatAppearance.BorderSize = 0;
			this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonHome.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonHome.ForeColor = System.Drawing.Color.White;
			this.buttonHome.Location = new System.Drawing.Point(0, 0);
			this.buttonHome.Margin = new System.Windows.Forms.Padding(4);
			this.buttonHome.Name = "buttonHome";
			this.buttonHome.Size = new System.Drawing.Size(196, 106);
			this.buttonHome.TabIndex = 5;
			this.buttonHome.Text = "Home";
			this.buttonHome.UseVisualStyleBackColor = true;
			this.buttonHome.Click += new System.EventHandler(this.button4_Click);
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.White;
			this.panel3.Controls.Add(this.labelEmpID);
			this.panel3.Controls.Add(this.label2);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(196, 56);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1424, 48);
			this.panel3.TabIndex = 2;
			this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
			// 
			// labelEmpID
			// 
			this.labelEmpID.AutoSize = true;
			this.labelEmpID.Font = new System.Drawing.Font("PMingLiU", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.labelEmpID.Location = new System.Drawing.Point(26, 14);
			this.labelEmpID.Name = "labelEmpID";
			this.labelEmpID.Size = new System.Drawing.Size(61, 18);
			this.labelEmpID.TabIndex = 1;
			this.labelEmpID.Text = "empid:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("PMingLiU", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.Location = new System.Drawing.Point(496, 14);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(51, 18);
			this.label2.TabIndex = 0;
			this.label2.Text = "Date:";
			// 
			// panelDesktopPane
			// 
			this.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelDesktopPane.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panelDesktopPane.ForeColor = System.Drawing.Color.Black;
			this.panelDesktopPane.Location = new System.Drawing.Point(196, 104);
			this.panelDesktopPane.Margin = new System.Windows.Forms.Padding(4);
			this.panelDesktopPane.Name = "panelDesktopPane";
			this.panelDesktopPane.Size = new System.Drawing.Size(1424, 898);
			this.panelDesktopPane.TabIndex = 3;
			this.panelDesktopPane.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktopPane_Paint);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1620, 1002);
			this.Controls.Add(this.panelDesktopPane);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Name = "Form1";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button buttonProfile;
		private System.Windows.Forms.Button buttonBell;
		private System.Windows.Forms.Label labelEmpID;
		private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelDesktopPane;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonViewOrder;
        private System.Windows.Forms.Button buttonCreateOrder;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.Button buttonModifyItem;
	}
}

