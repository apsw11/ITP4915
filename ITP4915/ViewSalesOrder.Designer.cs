namespace ITP4915
{
	partial class ViewSalesOrder
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewSalesOrder));
			this.labelOrderID = new System.Windows.Forms.Label();
			this.textBoxOrderID = new System.Windows.Forms.TextBox();
			this.textBoxOrderDate = new System.Windows.Forms.TextBox();
			this.labelOrderDate = new System.Windows.Forms.Label();
			this.textBoxAmount = new System.Windows.Forms.TextBox();
			this.labelAmount = new System.Windows.Forms.Label();
			this.textBoxDeliveryDate = new System.Windows.Forms.TextBox();
			this.labelDelivery = new System.Windows.Forms.Label();
			this.labelPayment = new System.Windows.Forms.Label();
			this.buttonUpdate = new System.Windows.Forms.Button();
			this.textBoxPayment = new System.Windows.Forms.TextBox();
			this.labelSerach = new System.Windows.Forms.Label();
			this.textBoxSerach = new System.Windows.Forms.TextBox();
			this.buttonEdit = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxCID = new System.Windows.Forms.TextBox();
			this.textBoxAddress = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxPhone = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxCustomerName = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxDeliveryID = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBoxInstallation = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.textBoxStatus = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.buttonViewOrder = new System.Windows.Forms.Button();
			this.buttonViewOrderItem = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.showcustomerInfo = new Guna.UI2.WinForms.Guna2GroupBox();
			this.guna2ToggleSwitch1 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
			this.label8 = new System.Windows.Forms.Label();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonViewCancel = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.showcustomerInfo.SuspendLayout();
			this.SuspendLayout();
			// 
			// labelOrderID
			// 
			this.labelOrderID.AutoSize = true;
			this.labelOrderID.BackColor = System.Drawing.Color.Transparent;
			this.labelOrderID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.labelOrderID.ForeColor = System.Drawing.Color.White;
			this.labelOrderID.Location = new System.Drawing.Point(96, 431);
			this.labelOrderID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelOrderID.Name = "labelOrderID";
			this.labelOrderID.Size = new System.Drawing.Size(74, 21);
			this.labelOrderID.TabIndex = 1;
			this.labelOrderID.Text = "OrderID:";
			// 
			// textBoxOrderID
			// 
			this.textBoxOrderID.BackColor = System.Drawing.Color.White;
			this.textBoxOrderID.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxOrderID.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.textBoxOrderID.Location = new System.Drawing.Point(211, 433);
			this.textBoxOrderID.Margin = new System.Windows.Forms.Padding(2);
			this.textBoxOrderID.Name = "textBoxOrderID";
			this.textBoxOrderID.ReadOnly = true;
			this.textBoxOrderID.Size = new System.Drawing.Size(123, 22);
			this.textBoxOrderID.TabIndex = 2;
			this.textBoxOrderID.TextChanged += new System.EventHandler(this.textBoxOrderID_TextChanged);
			// 
			// textBoxOrderDate
			// 
			this.textBoxOrderDate.BackColor = System.Drawing.Color.White;
			this.textBoxOrderDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxOrderDate.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.textBoxOrderDate.Location = new System.Drawing.Point(211, 473);
			this.textBoxOrderDate.Margin = new System.Windows.Forms.Padding(2);
			this.textBoxOrderDate.Name = "textBoxOrderDate";
			this.textBoxOrderDate.ReadOnly = true;
			this.textBoxOrderDate.Size = new System.Drawing.Size(123, 22);
			this.textBoxOrderDate.TabIndex = 4;
			// 
			// labelOrderDate
			// 
			this.labelOrderDate.AutoSize = true;
			this.labelOrderDate.BackColor = System.Drawing.Color.Transparent;
			this.labelOrderDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.labelOrderDate.ForeColor = System.Drawing.Color.White;
			this.labelOrderDate.Location = new System.Drawing.Point(96, 473);
			this.labelOrderDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelOrderDate.Name = "labelOrderDate";
			this.labelOrderDate.Size = new System.Drawing.Size(97, 21);
			this.labelOrderDate.TabIndex = 3;
			this.labelOrderDate.Text = "Order Date:";
			// 
			// textBoxAmount
			// 
			this.textBoxAmount.BackColor = System.Drawing.Color.White;
			this.textBoxAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxAmount.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.textBoxAmount.Location = new System.Drawing.Point(211, 517);
			this.textBoxAmount.Margin = new System.Windows.Forms.Padding(2);
			this.textBoxAmount.Name = "textBoxAmount";
			this.textBoxAmount.ReadOnly = true;
			this.textBoxAmount.Size = new System.Drawing.Size(123, 22);
			this.textBoxAmount.TabIndex = 6;
			// 
			// labelAmount
			// 
			this.labelAmount.AutoSize = true;
			this.labelAmount.BackColor = System.Drawing.Color.Transparent;
			this.labelAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.labelAmount.ForeColor = System.Drawing.Color.White;
			this.labelAmount.Location = new System.Drawing.Point(96, 515);
			this.labelAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelAmount.Name = "labelAmount";
			this.labelAmount.Size = new System.Drawing.Size(76, 21);
			this.labelAmount.TabIndex = 5;
			this.labelAmount.Text = "Amount:";
			// 
			// textBoxDeliveryDate
			// 
			this.textBoxDeliveryDate.BackColor = System.Drawing.Color.White;
			this.textBoxDeliveryDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxDeliveryDate.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.textBoxDeliveryDate.Location = new System.Drawing.Point(547, 472);
			this.textBoxDeliveryDate.Margin = new System.Windows.Forms.Padding(2);
			this.textBoxDeliveryDate.Name = "textBoxDeliveryDate";
			this.textBoxDeliveryDate.ReadOnly = true;
			this.textBoxDeliveryDate.Size = new System.Drawing.Size(123, 22);
			this.textBoxDeliveryDate.TabIndex = 8;
			// 
			// labelDelivery
			// 
			this.labelDelivery.AutoSize = true;
			this.labelDelivery.BackColor = System.Drawing.Color.Transparent;
			this.labelDelivery.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.labelDelivery.ForeColor = System.Drawing.Color.White;
			this.labelDelivery.Location = new System.Drawing.Point(399, 472);
			this.labelDelivery.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelDelivery.Name = "labelDelivery";
			this.labelDelivery.Size = new System.Drawing.Size(119, 21);
			this.labelDelivery.TabIndex = 7;
			this.labelDelivery.Text = "Delivery Date:";
			// 
			// labelPayment
			// 
			this.labelPayment.AutoSize = true;
			this.labelPayment.BackColor = System.Drawing.Color.Transparent;
			this.labelPayment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.labelPayment.ForeColor = System.Drawing.Color.White;
			this.labelPayment.Location = new System.Drawing.Point(96, 561);
			this.labelPayment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelPayment.Name = "labelPayment";
			this.labelPayment.Size = new System.Drawing.Size(82, 21);
			this.labelPayment.TabIndex = 9;
			this.labelPayment.Text = "Payment:";
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Enabled = false;
			this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.buttonUpdate.Location = new System.Drawing.Point(1105, 608);
			this.buttonUpdate.Margin = new System.Windows.Forms.Padding(2);
			this.buttonUpdate.Name = "buttonUpdate";
			this.buttonUpdate.Size = new System.Drawing.Size(87, 35);
			this.buttonUpdate.TabIndex = 14;
			this.buttonUpdate.Text = "Update";
			this.buttonUpdate.UseVisualStyleBackColor = true;
			this.buttonUpdate.Click += new System.EventHandler(this.button2_Click);
			// 
			// textBoxPayment
			// 
			this.textBoxPayment.BackColor = System.Drawing.Color.White;
			this.textBoxPayment.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxPayment.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.textBoxPayment.Location = new System.Drawing.Point(211, 561);
			this.textBoxPayment.Margin = new System.Windows.Forms.Padding(2);
			this.textBoxPayment.Name = "textBoxPayment";
			this.textBoxPayment.ReadOnly = true;
			this.textBoxPayment.Size = new System.Drawing.Size(123, 22);
			this.textBoxPayment.TabIndex = 10;
			// 
			// labelSerach
			// 
			this.labelSerach.AutoSize = true;
			this.labelSerach.BackColor = System.Drawing.Color.Transparent;
			this.labelSerach.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.labelSerach.ForeColor = System.Drawing.Color.White;
			this.labelSerach.Location = new System.Drawing.Point(95, 52);
			this.labelSerach.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelSerach.Name = "labelSerach";
			this.labelSerach.Size = new System.Drawing.Size(61, 21);
			this.labelSerach.TabIndex = 11;
			this.labelSerach.Text = "Search";
			// 
			// textBoxSerach
			// 
			this.textBoxSerach.BackColor = System.Drawing.Color.White;
			this.textBoxSerach.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxSerach.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.textBoxSerach.Location = new System.Drawing.Point(192, 52);
			this.textBoxSerach.Margin = new System.Windows.Forms.Padding(2);
			this.textBoxSerach.Name = "textBoxSerach";
			this.textBoxSerach.Size = new System.Drawing.Size(156, 22);
			this.textBoxSerach.TabIndex = 12;
			this.textBoxSerach.TextChanged += new System.EventHandler(this.textBoxSerach_TextChanged);
			this.textBoxSerach.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSerach_KeyPress);
			// 
			// buttonEdit
			// 
			this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.buttonEdit.Location = new System.Drawing.Point(239, 616);
			this.buttonEdit.Margin = new System.Windows.Forms.Padding(2);
			this.buttonEdit.Name = "buttonEdit";
			this.buttonEdit.Size = new System.Drawing.Size(61, 27);
			this.buttonEdit.TabIndex = 13;
			this.buttonEdit.Text = "Edit";
			this.buttonEdit.UseVisualStyleBackColor = true;
			this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(15, 11);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(108, 21);
			this.label1.TabIndex = 15;
			this.label1.Text = "Customer ID:";
			// 
			// textBoxCID
			// 
			this.textBoxCID.BackColor = System.Drawing.Color.White;
			this.textBoxCID.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxCID.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.textBoxCID.Location = new System.Drawing.Point(179, 13);
			this.textBoxCID.Margin = new System.Windows.Forms.Padding(2);
			this.textBoxCID.Name = "textBoxCID";
			this.textBoxCID.ReadOnly = true;
			this.textBoxCID.Size = new System.Drawing.Size(124, 22);
			this.textBoxCID.TabIndex = 16;
			// 
			// textBoxAddress
			// 
			this.textBoxAddress.BackColor = System.Drawing.Color.White;
			this.textBoxAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxAddress.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.textBoxAddress.Location = new System.Drawing.Point(179, 97);
			this.textBoxAddress.Margin = new System.Windows.Forms.Padding(2);
			this.textBoxAddress.Name = "textBoxAddress";
			this.textBoxAddress.ReadOnly = true;
			this.textBoxAddress.Size = new System.Drawing.Size(124, 22);
			this.textBoxAddress.TabIndex = 18;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(15, 95);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(74, 21);
			this.label2.TabIndex = 17;
			this.label2.Text = "Address:";
			// 
			// textBoxPhone
			// 
			this.textBoxPhone.BackColor = System.Drawing.Color.White;
			this.textBoxPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxPhone.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.textBoxPhone.Location = new System.Drawing.Point(179, 141);
			this.textBoxPhone.Margin = new System.Windows.Forms.Padding(2);
			this.textBoxPhone.Name = "textBoxPhone";
			this.textBoxPhone.ReadOnly = true;
			this.textBoxPhone.Size = new System.Drawing.Size(124, 22);
			this.textBoxPhone.TabIndex = 20;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(15, 141);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(63, 21);
			this.label3.TabIndex = 19;
			this.label3.Text = "Phone:";
			// 
			// textBoxCustomerName
			// 
			this.textBoxCustomerName.BackColor = System.Drawing.Color.White;
			this.textBoxCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxCustomerName.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.textBoxCustomerName.Location = new System.Drawing.Point(179, 53);
			this.textBoxCustomerName.Margin = new System.Windows.Forms.Padding(2);
			this.textBoxCustomerName.Name = "textBoxCustomerName";
			this.textBoxCustomerName.ReadOnly = true;
			this.textBoxCustomerName.Size = new System.Drawing.Size(124, 22);
			this.textBoxCustomerName.TabIndex = 22;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(15, 53);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(137, 21);
			this.label4.TabIndex = 21;
			this.label4.Text = "Customer Name:";
			// 
			// textBoxDeliveryID
			// 
			this.textBoxDeliveryID.BackColor = System.Drawing.Color.White;
			this.textBoxDeliveryID.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxDeliveryID.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.textBoxDeliveryID.Location = new System.Drawing.Point(547, 432);
			this.textBoxDeliveryID.Margin = new System.Windows.Forms.Padding(2);
			this.textBoxDeliveryID.Name = "textBoxDeliveryID";
			this.textBoxDeliveryID.ReadOnly = true;
			this.textBoxDeliveryID.Size = new System.Drawing.Size(123, 22);
			this.textBoxDeliveryID.TabIndex = 24;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(399, 432);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 21);
			this.label5.TabIndex = 23;
			this.label5.Text = "Delivery ID:";
			// 
			// textBoxInstallation
			// 
			this.textBoxInstallation.BackColor = System.Drawing.Color.White;
			this.textBoxInstallation.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxInstallation.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.textBoxInstallation.Location = new System.Drawing.Point(547, 516);
			this.textBoxInstallation.Margin = new System.Windows.Forms.Padding(2);
			this.textBoxInstallation.Name = "textBoxInstallation";
			this.textBoxInstallation.ReadOnly = true;
			this.textBoxInstallation.Size = new System.Drawing.Size(123, 22);
			this.textBoxInstallation.TabIndex = 28;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(399, 514);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(143, 21);
			this.label6.TabIndex = 27;
			this.label6.Text = "Installation Time:";
			// 
			// textBoxStatus
			// 
			this.textBoxStatus.BackColor = System.Drawing.Color.White;
			this.textBoxStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxStatus.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.textBoxStatus.Location = new System.Drawing.Point(546, 560);
			this.textBoxStatus.Margin = new System.Windows.Forms.Padding(2);
			this.textBoxStatus.Name = "textBoxStatus";
			this.textBoxStatus.ReadOnly = true;
			this.textBoxStatus.Size = new System.Drawing.Size(123, 22);
			this.textBoxStatus.TabIndex = 26;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(399, 561);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(61, 21);
			this.label7.TabIndex = 25;
			this.label7.Text = "Status:";
			// 
			// buttonViewOrder
			// 
			this.buttonViewOrder.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.buttonViewOrder.Location = new System.Drawing.Point(99, 100);
			this.buttonViewOrder.Margin = new System.Windows.Forms.Padding(2);
			this.buttonViewOrder.Name = "buttonViewOrder";
			this.buttonViewOrder.Size = new System.Drawing.Size(116, 33);
			this.buttonViewOrder.TabIndex = 29;
			this.buttonViewOrder.Text = "View Order";
			this.buttonViewOrder.UseVisualStyleBackColor = true;
			this.buttonViewOrder.Click += new System.EventHandler(this.buttonViewOrder_Click);
			// 
			// buttonViewOrderItem
			// 
			this.buttonViewOrderItem.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.buttonViewOrderItem.Location = new System.Drawing.Point(275, 100);
			this.buttonViewOrderItem.Margin = new System.Windows.Forms.Padding(2);
			this.buttonViewOrderItem.Name = "buttonViewOrderItem";
			this.buttonViewOrderItem.Size = new System.Drawing.Size(158, 33);
			this.buttonViewOrderItem.TabIndex = 30;
			this.buttonViewOrderItem.Text = "View Order Items";
			this.buttonViewOrderItem.UseVisualStyleBackColor = true;
			this.buttonViewOrderItem.Click += new System.EventHandler(this.buttonViewOrderItem_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToOrderColumns = true;
			this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(85)))), ((int)(((byte)(148)))));
			this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(91, 159);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dataGridView1.RowHeadersWidth = 62;
			this.dataGridView1.RowTemplate.Height = 31;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(963, 256);
			this.dataGridView1.TabIndex = 31;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(1058, 7);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(217, 146);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 32;
			this.pictureBox1.TabStop = false;
			// 
			// showcustomerInfo
			// 
			this.showcustomerInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(52)))), ((int)(((byte)(98)))));
			this.showcustomerInfo.BorderThickness = 0;
			this.showcustomerInfo.Controls.Add(this.textBoxCID);
			this.showcustomerInfo.Controls.Add(this.label1);
			this.showcustomerInfo.Controls.Add(this.label2);
			this.showcustomerInfo.Controls.Add(this.textBoxAddress);
			this.showcustomerInfo.Controls.Add(this.label3);
			this.showcustomerInfo.Controls.Add(this.textBoxPhone);
			this.showcustomerInfo.Controls.Add(this.label4);
			this.showcustomerInfo.Controls.Add(this.textBoxCustomerName);
			this.showcustomerInfo.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(137)))), ((int)(((byte)(220)))));
			this.showcustomerInfo.CustomBorderThickness = new System.Windows.Forms.Padding(0);
			this.showcustomerInfo.FillColor = System.Drawing.Color.Empty;
			this.showcustomerInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.showcustomerInfo.ForeColor = System.Drawing.Color.White;
			this.showcustomerInfo.Location = new System.Drawing.Point(711, 420);
			this.showcustomerInfo.Name = "showcustomerInfo";
			this.showcustomerInfo.Size = new System.Drawing.Size(343, 200);
			this.showcustomerInfo.TabIndex = 58;
			this.showcustomerInfo.Visible = false;
			// 
			// guna2ToggleSwitch1
			// 
			this.guna2ToggleSwitch1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.guna2ToggleSwitch1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.guna2ToggleSwitch1.CheckedState.InnerBorderColor = System.Drawing.Color.White;
			this.guna2ToggleSwitch1.CheckedState.InnerColor = System.Drawing.Color.White;
			this.guna2ToggleSwitch1.Location = new System.Drawing.Point(1061, 172);
			this.guna2ToggleSwitch1.Name = "guna2ToggleSwitch1";
			this.guna2ToggleSwitch1.Size = new System.Drawing.Size(35, 20);
			this.guna2ToggleSwitch1.TabIndex = 59;
			this.guna2ToggleSwitch1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
			this.guna2ToggleSwitch1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
			this.guna2ToggleSwitch1.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
			this.guna2ToggleSwitch1.UncheckedState.InnerColor = System.Drawing.Color.White;
			this.guna2ToggleSwitch1.CheckedChanged += new System.EventHandler(this.guna2ToggleSwitch1_CheckedChanged);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.label8.ForeColor = System.Drawing.Color.White;
			this.label8.Location = new System.Drawing.Point(1101, 171);
			this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(164, 21);
			this.label8.TabIndex = 60;
			this.label8.Text = "Show Customer Info";
			// 
			// buttonCancel
			// 
			this.buttonCancel.Location = new System.Drawing.Point(91, 616);
			this.buttonCancel.Margin = new System.Windows.Forms.Padding(2);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 27);
			this.buttonCancel.TabIndex = 61;
			this.buttonCancel.Text = "Cancel Order";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// buttonViewCancel
			// 
			this.buttonViewCancel.Location = new System.Drawing.Point(483, 100);
			this.buttonViewCancel.Name = "buttonViewCancel";
			this.buttonViewCancel.Size = new System.Drawing.Size(147, 33);
			this.buttonViewCancel.TabIndex = 62;
			this.buttonViewCancel.Text = "View Cancel order";
			this.buttonViewCancel.UseVisualStyleBackColor = true;
			this.buttonViewCancel.Click += new System.EventHandler(this.buttonViewCancel_Click);
			// 
			// ViewSalesOrder
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(52)))), ((int)(((byte)(98)))));
			this.ClientSize = new System.Drawing.Size(1283, 685);
			this.Controls.Add(this.buttonViewCancel);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.guna2ToggleSwitch1);
			this.Controls.Add(this.showcustomerInfo);
			this.Controls.Add(this.buttonUpdate);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.buttonViewOrderItem);
			this.Controls.Add(this.buttonViewOrder);
			this.Controls.Add(this.textBoxInstallation);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.textBoxStatus);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.textBoxDeliveryID);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.buttonEdit);
			this.Controls.Add(this.textBoxSerach);
			this.Controls.Add(this.labelSerach);
			this.Controls.Add(this.textBoxPayment);
			this.Controls.Add(this.labelPayment);
			this.Controls.Add(this.textBoxDeliveryDate);
			this.Controls.Add(this.labelDelivery);
			this.Controls.Add(this.textBoxAmount);
			this.Controls.Add(this.labelAmount);
			this.Controls.Add(this.textBoxOrderDate);
			this.Controls.Add(this.labelOrderDate);
			this.Controls.Add(this.textBoxOrderID);
			this.Controls.Add(this.labelOrderID);
			this.Controls.Add(this.pictureBox1);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "ViewSalesOrder";
			this.ShowInTaskbar = false;
			this.Text = "ViewSalesOrder";
			this.Load += new System.EventHandler(this.ViewSalesOrder_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.showcustomerInfo.ResumeLayout(false);
			this.showcustomerInfo.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label labelOrderID;
		private System.Windows.Forms.TextBox textBoxOrderID;
		private System.Windows.Forms.TextBox textBoxOrderDate;
		private System.Windows.Forms.Label labelOrderDate;
		private System.Windows.Forms.TextBox textBoxAmount;
		private System.Windows.Forms.Label labelAmount;
		private System.Windows.Forms.TextBox textBoxDeliveryDate;
		private System.Windows.Forms.Label labelDelivery;
		private System.Windows.Forms.Label labelPayment;
		private System.Windows.Forms.Button buttonUpdate;
		private System.Windows.Forms.TextBox textBoxPayment;
		private System.Windows.Forms.Label labelSerach;
		private System.Windows.Forms.TextBox textBoxSerach;
		private System.Windows.Forms.Button buttonEdit;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxCID;
		private System.Windows.Forms.TextBox textBoxAddress;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxPhone;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxCustomerName;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBoxDeliveryID;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBoxInstallation;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBoxStatus;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button buttonViewOrder;
		private System.Windows.Forms.Button buttonViewOrderItem;
		private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2GroupBox showcustomerInfo;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch1;
        private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonViewCancel;
	}
}