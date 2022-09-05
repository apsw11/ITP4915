namespace ITP4915
{
	partial class DailyDeliveryList
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DailyDeliveryList));
			this.buttonViewDaily = new System.Windows.Forms.Button();
			this.buttonViewItems = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxDeliveryID = new System.Windows.Forms.TextBox();
			this.textBoxDeliveryDate = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxOrderID = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxAddress = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxCustomerName = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBoxCustomerID = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.buttonTakeOrder = new System.Windows.Forms.Button();
			this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
			this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
			this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
			this.textBoxDelID = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.guna2GroupBox2.SuspendLayout();
			this.guna2GroupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonViewDaily
			// 
			this.buttonViewDaily.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.buttonViewDaily.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.buttonViewDaily.Location = new System.Drawing.Point(45, 592);
			this.buttonViewDaily.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.buttonViewDaily.Name = "buttonViewDaily";
			this.buttonViewDaily.Size = new System.Drawing.Size(204, 35);
			this.buttonViewDaily.TabIndex = 0;
			this.buttonViewDaily.Text = "View Daily Delivery List";
			this.buttonViewDaily.UseVisualStyleBackColor = true;
			this.buttonViewDaily.Click += new System.EventHandler(this.buttonViewDaily_Click);
			// 
			// buttonViewItems
			// 
			this.buttonViewItems.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.buttonViewItems.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.buttonViewItems.Location = new System.Drawing.Point(269, 592);
			this.buttonViewItems.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.buttonViewItems.Name = "buttonViewItems";
			this.buttonViewItems.Size = new System.Drawing.Size(204, 35);
			this.buttonViewItems.TabIndex = 1;
			this.buttonViewItems.Text = "View The Items of the Delivery";
			this.buttonViewItems.UseVisualStyleBackColor = true;
			this.buttonViewItems.Click += new System.EventHandler(this.buttonViewItems_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToOrderColumns = true;
			this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(85)))), ((int)(((byte)(148)))));
			this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.dataGridView1.Location = new System.Drawing.Point(40, 96);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.dataGridView1.RowHeadersWidth = 62;
			this.dataGridView1.RowTemplate.Height = 31;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(633, 483);
			this.dataGridView1.TabIndex = 2;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(21, 70);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 21);
			this.label1.TabIndex = 3;
			this.label1.Text = "Delivery ID:";
			// 
			// textBoxDeliveryID
			// 
			this.textBoxDeliveryID.Location = new System.Drawing.Point(177, 67);
			this.textBoxDeliveryID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.textBoxDeliveryID.Name = "textBoxDeliveryID";
			this.textBoxDeliveryID.Size = new System.Drawing.Size(202, 29);
			this.textBoxDeliveryID.TabIndex = 4;
			// 
			// textBoxDeliveryDate
			// 
			this.textBoxDeliveryDate.Location = new System.Drawing.Point(177, 106);
			this.textBoxDeliveryDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.textBoxDeliveryDate.Name = "textBoxDeliveryDate";
			this.textBoxDeliveryDate.Size = new System.Drawing.Size(202, 29);
			this.textBoxDeliveryDate.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(21, 109);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(119, 21);
			this.label2.TabIndex = 5;
			this.label2.Text = "Delivery Date:";
			// 
			// textBoxOrderID
			// 
			this.textBoxOrderID.Location = new System.Drawing.Point(177, 148);
			this.textBoxOrderID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.textBoxOrderID.Name = "textBoxOrderID";
			this.textBoxOrderID.Size = new System.Drawing.Size(202, 29);
			this.textBoxOrderID.TabIndex = 8;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(21, 148);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(78, 21);
			this.label3.TabIndex = 7;
			this.label3.Text = "Order ID:";
			// 
			// textBoxAddress
			// 
			this.textBoxAddress.Location = new System.Drawing.Point(177, 142);
			this.textBoxAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.textBoxAddress.Name = "textBoxAddress";
			this.textBoxAddress.Size = new System.Drawing.Size(202, 29);
			this.textBoxAddress.TabIndex = 14;
			this.textBoxAddress.UseSystemPasswordChar = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(21, 140);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(74, 21);
			this.label4.TabIndex = 13;
			this.label4.Text = "Address:";
			// 
			// textBoxCustomerName
			// 
			this.textBoxCustomerName.Location = new System.Drawing.Point(177, 103);
			this.textBoxCustomerName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.textBoxCustomerName.Name = "textBoxCustomerName";
			this.textBoxCustomerName.Size = new System.Drawing.Size(202, 29);
			this.textBoxCustomerName.TabIndex = 12;
			this.textBoxCustomerName.UseSystemPasswordChar = true;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(21, 101);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(137, 21);
			this.label5.TabIndex = 11;
			this.label5.Text = "Customer Name:";
			// 
			// textBoxCustomerID
			// 
			this.textBoxCustomerID.Location = new System.Drawing.Point(177, 62);
			this.textBoxCustomerID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.textBoxCustomerID.Name = "textBoxCustomerID";
			this.textBoxCustomerID.Size = new System.Drawing.Size(202, 29);
			this.textBoxCustomerID.TabIndex = 10;
			this.textBoxCustomerID.UseSystemPasswordChar = true;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(21, 62);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(108, 21);
			this.label6.TabIndex = 9;
			this.label6.Text = "Customer ID:";
			// 
			// textBoxPhoneNumber
			// 
			this.textBoxPhoneNumber.Location = new System.Drawing.Point(177, 182);
			this.textBoxPhoneNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
			this.textBoxPhoneNumber.Size = new System.Drawing.Size(202, 29);
			this.textBoxPhoneNumber.TabIndex = 16;
			this.textBoxPhoneNumber.UseSystemPasswordChar = true;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(21, 180);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(131, 21);
			this.label7.TabIndex = 15;
			this.label7.Text = "Phone Number:";
			// 
			// buttonTakeOrder
			// 
			this.buttonTakeOrder.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.buttonTakeOrder.Location = new System.Drawing.Point(540, 592);
			this.buttonTakeOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.buttonTakeOrder.Name = "buttonTakeOrder";
			this.buttonTakeOrder.Size = new System.Drawing.Size(133, 36);
			this.buttonTakeOrder.TabIndex = 17;
			this.buttonTakeOrder.Text = "Take Order";
			this.buttonTakeOrder.UseVisualStyleBackColor = true;
			this.buttonTakeOrder.Click += new System.EventHandler(this.buttonTakeOrder_Click);
			// 
			// guna2GroupBox2
			// 
			this.guna2GroupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(85)))), ((int)(((byte)(148)))));
			this.guna2GroupBox2.Controls.Add(this.textBoxOrderID);
			this.guna2GroupBox2.Controls.Add(this.label3);
			this.guna2GroupBox2.Controls.Add(this.textBoxDeliveryDate);
			this.guna2GroupBox2.Controls.Add(this.label2);
			this.guna2GroupBox2.Controls.Add(this.textBoxDeliveryID);
			this.guna2GroupBox2.Controls.Add(this.label1);
			this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(137)))), ((int)(((byte)(220)))));
			this.guna2GroupBox2.FillColor = System.Drawing.Color.Empty;
			this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.guna2GroupBox2.ForeColor = System.Drawing.Color.White;
			this.guna2GroupBox2.Location = new System.Drawing.Point(739, 373);
			this.guna2GroupBox2.Name = "guna2GroupBox2";
			this.guna2GroupBox2.Size = new System.Drawing.Size(412, 206);
			this.guna2GroupBox2.TabIndex = 19;
			this.guna2GroupBox2.Text = "Delivery Info";
			// 
			// guna2GroupBox1
			// 
			this.guna2GroupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(85)))), ((int)(((byte)(148)))));
			this.guna2GroupBox1.Controls.Add(this.textBoxPhoneNumber);
			this.guna2GroupBox1.Controls.Add(this.label6);
			this.guna2GroupBox1.Controls.Add(this.textBoxCustomerID);
			this.guna2GroupBox1.Controls.Add(this.label7);
			this.guna2GroupBox1.Controls.Add(this.label5);
			this.guna2GroupBox1.Controls.Add(this.textBoxAddress);
			this.guna2GroupBox1.Controls.Add(this.textBoxCustomerName);
			this.guna2GroupBox1.Controls.Add(this.label4);
			this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(137)))), ((int)(((byte)(220)))));
			this.guna2GroupBox1.FillColor = System.Drawing.Color.Empty;
			this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
			this.guna2GroupBox1.Location = new System.Drawing.Point(739, 96);
			this.guna2GroupBox1.Name = "guna2GroupBox1";
			this.guna2GroupBox1.Size = new System.Drawing.Size(412, 229);
			this.guna2GroupBox1.TabIndex = 20;
			this.guna2GroupBox1.Text = "Customer  Info";
			// 
			// guna2PictureBox1
			// 
			this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.guna2PictureBox1.ErrorImage = null;
			this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
			this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
			this.guna2PictureBox1.ImageRotate = 0F;
			this.guna2PictureBox1.Location = new System.Drawing.Point(1103, -6);
			this.guna2PictureBox1.Name = "guna2PictureBox1";
			this.guna2PictureBox1.Size = new System.Drawing.Size(181, 132);
			this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.guna2PictureBox1.TabIndex = 22;
			this.guna2PictureBox1.TabStop = false;
			this.guna2PictureBox1.UseTransparentBackground = true;
			// 
			// textBoxDelID
			// 
			this.textBoxDelID.Location = new System.Drawing.Point(223, 56);
			this.textBoxDelID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.textBoxDelID.Name = "textBoxDelID";
			this.textBoxDelID.Size = new System.Drawing.Size(267, 22);
			this.textBoxDelID.TabIndex = 43;
			this.textBoxDelID.TextChanged += new System.EventHandler(this.textBoxDelID_TextChanged);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.label8.ForeColor = System.Drawing.Color.White;
			this.label8.Location = new System.Drawing.Point(41, 56);
			this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(178, 21);
			this.label8.TabIndex = 42;
			this.label8.Text = "Search By Delivery ID:";
			// 
			// DailyDeliveryList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(52)))), ((int)(((byte)(98)))));
			this.ClientSize = new System.Drawing.Size(1283, 685);
			this.Controls.Add(this.textBoxDelID);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.guna2GroupBox1);
			this.Controls.Add(this.guna2GroupBox2);
			this.Controls.Add(this.buttonTakeOrder);
			this.Controls.Add(this.buttonViewItems);
			this.Controls.Add(this.buttonViewDaily);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.guna2PictureBox1);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "DailyDeliveryList";
			this.Text = "DailyDeliveryList";
			this.Load += new System.EventHandler(this.DailyDeliveryList_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.guna2GroupBox2.ResumeLayout(false);
			this.guna2GroupBox2.PerformLayout();
			this.guna2GroupBox1.ResumeLayout(false);
			this.guna2GroupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonViewDaily;
		private System.Windows.Forms.Button buttonViewItems;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxDeliveryID;
		private System.Windows.Forms.TextBox textBoxDeliveryDate;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxOrderID;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxAddress;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBoxCustomerName;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBoxCustomerID;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBoxPhoneNumber;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button buttonTakeOrder;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
		private System.Windows.Forms.TextBox textBoxDelID;
		private System.Windows.Forms.Label label8;
	}
}