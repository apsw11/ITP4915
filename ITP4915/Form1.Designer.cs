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
            this.closebutton = new System.Windows.Forms.Button();
            this.buttonBell = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonProfile = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonViewDepositOrder = new System.Windows.Forms.Button();
            this.buttonViewROrder = new System.Windows.Forms.Button();
            this.buttonSupplier = new System.Windows.Forms.Button();
            this.buttonViewCustomer = new System.Windows.Forms.Button();
            this.buttonModifyItem = new System.Windows.Forms.Button();
            this.buttonViewOrder = new System.Windows.Forms.Button();
            this.buttonCreateOrder = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelEmpID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(137)))), ((int)(((byte)(220)))));
            this.panel1.Controls.Add(this.closebutton);
            this.panel1.Controls.Add(this.buttonBell);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonProfile);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1069, 51);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // closebutton
            // 
            this.closebutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(137)))), ((int)(((byte)(220)))));
            this.closebutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closebutton.BackgroundImage")));
            this.closebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.closebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closebutton.FlatAppearance.BorderSize = 0;
            this.closebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closebutton.Location = new System.Drawing.Point(1021, 2);
            this.closebutton.Margin = new System.Windows.Forms.Padding(2);
            this.closebutton.Name = "closebutton";
            this.closebutton.Size = new System.Drawing.Size(47, 44);
            this.closebutton.TabIndex = 11;
            this.closebutton.UseVisualStyleBackColor = false;
            this.closebutton.Click += new System.EventHandler(this.closebutton_Click);
            // 
            // buttonBell
            // 
            this.buttonBell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBell.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBell.BackgroundImage")));
            this.buttonBell.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonBell.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBell.FlatAppearance.BorderSize = 0;
            this.buttonBell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBell.Location = new System.Drawing.Point(887, 3);
            this.buttonBell.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBell.Name = "buttonBell";
            this.buttonBell.Size = new System.Drawing.Size(52, 40);
            this.buttonBell.TabIndex = 3;
            this.buttonBell.UseVisualStyleBackColor = true;
            this.buttonBell.Visible = false;
            this.buttonBell.Click += new System.EventHandler(this.buttonBell_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(11, 14);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 23);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(57, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Main Menu";
            // 
            // buttonProfile
            // 
            this.buttonProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(137)))), ((int)(((byte)(220)))));
            this.buttonProfile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonProfile.BackgroundImage")));
            this.buttonProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonProfile.FlatAppearance.BorderSize = 0;
            this.buttonProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProfile.ForeColor = System.Drawing.Color.Transparent;
            this.buttonProfile.Location = new System.Drawing.Point(945, 1);
            this.buttonProfile.Margin = new System.Windows.Forms.Padding(2);
            this.buttonProfile.Name = "buttonProfile";
            this.buttonProfile.Size = new System.Drawing.Size(71, 44);
            this.buttonProfile.TabIndex = 2;
            this.buttonProfile.UseVisualStyleBackColor = false;
            this.buttonProfile.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(52)))), ((int)(((byte)(98)))));
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.buttonViewDepositOrder);
            this.panel2.Controls.Add(this.buttonViewROrder);
            this.panel2.Controls.Add(this.buttonSupplier);
            this.panel2.Controls.Add(this.buttonViewCustomer);
            this.panel2.Controls.Add(this.buttonModifyItem);
            this.panel2.Controls.Add(this.buttonViewOrder);
            this.panel2.Controls.Add(this.buttonCreateOrder);
            this.panel2.Controls.Add(this.buttonHome);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 51);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(157, 532);
            this.panel2.TabIndex = 1;
            // 
            // buttonViewDepositOrder
            // 
            this.buttonViewDepositOrder.FlatAppearance.BorderSize = 0;
            this.buttonViewDepositOrder.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonViewDepositOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonViewDepositOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonViewDepositOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonViewDepositOrder.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.buttonViewDepositOrder.ForeColor = System.Drawing.Color.White;
            this.buttonViewDepositOrder.Location = new System.Drawing.Point(3, 379);
            this.buttonViewDepositOrder.Name = "buttonViewDepositOrder";
            this.buttonViewDepositOrder.Size = new System.Drawing.Size(154, 52);
            this.buttonViewDepositOrder.TabIndex = 12;
            this.buttonViewDepositOrder.Text = "View Deposit Order";
            this.buttonViewDepositOrder.UseVisualStyleBackColor = true;
            this.buttonViewDepositOrder.Click += new System.EventHandler(this.buttonViewDepositOrder_Click);
            // 
            // buttonViewROrder
            // 
            this.buttonViewROrder.FlatAppearance.BorderSize = 0;
            this.buttonViewROrder.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonViewROrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonViewROrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonViewROrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonViewROrder.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.buttonViewROrder.ForeColor = System.Drawing.Color.White;
            this.buttonViewROrder.Location = new System.Drawing.Point(3, 212);
            this.buttonViewROrder.Name = "buttonViewROrder";
            this.buttonViewROrder.Size = new System.Drawing.Size(151, 65);
            this.buttonViewROrder.TabIndex = 11;
            this.buttonViewROrder.Text = "View Replenishment Order";
            this.buttonViewROrder.UseVisualStyleBackColor = true;
            this.buttonViewROrder.Click += new System.EventHandler(this.buttonViewROrder_Click);
            // 
            // buttonSupplier
            // 
            this.buttonSupplier.FlatAppearance.BorderSize = 0;
            this.buttonSupplier.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonSupplier.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonSupplier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSupplier.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.buttonSupplier.ForeColor = System.Drawing.Color.White;
            this.buttonSupplier.Location = new System.Drawing.Point(3, 322);
            this.buttonSupplier.Name = "buttonSupplier";
            this.buttonSupplier.Size = new System.Drawing.Size(154, 51);
            this.buttonSupplier.TabIndex = 10;
            this.buttonSupplier.Text = "Modify Supplier";
            this.buttonSupplier.UseVisualStyleBackColor = true;
            this.buttonSupplier.Visible = false;
            this.buttonSupplier.Click += new System.EventHandler(this.buttonSupplier_Click);
            // 
            // buttonViewCustomer
            // 
            this.buttonViewCustomer.FlatAppearance.BorderSize = 0;
            this.buttonViewCustomer.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonViewCustomer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonViewCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonViewCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonViewCustomer.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.buttonViewCustomer.ForeColor = System.Drawing.Color.White;
            this.buttonViewCustomer.Location = new System.Drawing.Point(3, 162);
            this.buttonViewCustomer.Name = "buttonViewCustomer";
            this.buttonViewCustomer.Size = new System.Drawing.Size(151, 53);
            this.buttonViewCustomer.TabIndex = 9;
            this.buttonViewCustomer.Text = "View Customer";
            this.buttonViewCustomer.UseVisualStyleBackColor = true;
            this.buttonViewCustomer.Click += new System.EventHandler(this.buttonViewCustomer_Click);
            // 
            // buttonModifyItem
            // 
            this.buttonModifyItem.FlatAppearance.BorderSize = 0;
            this.buttonModifyItem.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonModifyItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonModifyItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonModifyItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModifyItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.buttonModifyItem.ForeColor = System.Drawing.Color.White;
            this.buttonModifyItem.Location = new System.Drawing.Point(3, 283);
            this.buttonModifyItem.Name = "buttonModifyItem";
            this.buttonModifyItem.Size = new System.Drawing.Size(154, 51);
            this.buttonModifyItem.TabIndex = 8;
            this.buttonModifyItem.Text = "Modify Items";
            this.buttonModifyItem.UseVisualStyleBackColor = true;
            this.buttonModifyItem.Visible = false;
            this.buttonModifyItem.Click += new System.EventHandler(this.button7_Click);
            // 
            // buttonViewOrder
            // 
            this.buttonViewOrder.FlatAppearance.BorderSize = 0;
            this.buttonViewOrder.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonViewOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonViewOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonViewOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonViewOrder.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.buttonViewOrder.ForeColor = System.Drawing.Color.White;
            this.buttonViewOrder.Location = new System.Drawing.Point(3, 104);
            this.buttonViewOrder.Name = "buttonViewOrder";
            this.buttonViewOrder.Size = new System.Drawing.Size(154, 52);
            this.buttonViewOrder.TabIndex = 7;
            this.buttonViewOrder.Text = "View Sales Order";
            this.buttonViewOrder.UseVisualStyleBackColor = true;
            this.buttonViewOrder.Click += new System.EventHandler(this.button6_Click);
            // 
            // buttonCreateOrder
            // 
            this.buttonCreateOrder.FlatAppearance.BorderSize = 0;
            this.buttonCreateOrder.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonCreateOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonCreateOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonCreateOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateOrder.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.buttonCreateOrder.ForeColor = System.Drawing.Color.White;
            this.buttonCreateOrder.Location = new System.Drawing.Point(0, 44);
            this.buttonCreateOrder.Name = "buttonCreateOrder";
            this.buttonCreateOrder.Size = new System.Drawing.Size(157, 54);
            this.buttonCreateOrder.TabIndex = 6;
            this.buttonCreateOrder.Text = "CreateOrder";
            this.buttonCreateOrder.UseVisualStyleBackColor = true;
            this.buttonCreateOrder.Click += new System.EventHandler(this.button5_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.FlatAppearance.BorderSize = 0;
            this.buttonHome.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.buttonHome.ForeColor = System.Drawing.Color.White;
            this.buttonHome.Location = new System.Drawing.Point(0, 0);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(152, 52);
            this.buttonHome.TabIndex = 5;
            this.buttonHome.Text = "Home";
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(116)))), ((int)(((byte)(194)))));
            this.panel3.Controls.Add(this.labelEmpID);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(157, 51);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(912, 39);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // labelEmpID
            // 
            this.labelEmpID.AutoSize = true;
            this.labelEmpID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelEmpID.ForeColor = System.Drawing.Color.White;
            this.labelEmpID.Location = new System.Drawing.Point(17, 9);
            this.labelEmpID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEmpID.Name = "labelEmpID";
            this.labelEmpID.Size = new System.Drawing.Size(51, 15);
            this.labelEmpID.TabIndex = 1;
            this.labelEmpID.Text = "empid:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(331, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Date:";
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPane.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDesktopPane.ForeColor = System.Drawing.Color.Black;
            this.panelDesktopPane.Location = new System.Drawing.Point(157, 90);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(912, 493);
            this.panelDesktopPane.TabIndex = 3;
            this.panelDesktopPane.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktopPane_Paint);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(3, 421);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 52);
            this.button2.TabIndex = 13;
            this.button2.Text = "Staff Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 583);
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Button buttonViewCustomer;
        private System.Windows.Forms.Button closebutton;
		private System.Windows.Forms.Button buttonSupplier;
		private System.Windows.Forms.Button buttonViewROrder;
		private System.Windows.Forms.Button buttonViewDepositOrder;
        private System.Windows.Forms.Button button2;
    }
}

