namespace ITP4915
{
	partial class ViewrReplenishmentOrder
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewrReplenishmentOrder));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.textBoxSerach = new System.Windows.Forms.TextBox();
			this.labelSerach = new System.Windows.Forms.Label();
			this.buttonViewOrderItem = new System.Windows.Forms.Button();
			this.buttonViewOrder = new System.Windows.Forms.Button();
			this.buttonConfirm = new System.Windows.Forms.Button();
			this.buttonCorder = new System.Windows.Forms.Button();
			this.textBoxStatus = new System.Windows.Forms.TextBox();
			this.labelPayment = new System.Windows.Forms.Label();
			this.textBoxEmployee = new System.Windows.Forms.TextBox();
			this.labelAmount = new System.Windows.Forms.Label();
			this.textBoxOrderDate = new System.Windows.Forms.TextBox();
			this.labelOrderDate = new System.Windows.Forms.Label();
			this.textBoxOrderID = new System.Windows.Forms.TextBox();
			this.labelOrderID = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(1054, 13);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(217, 146);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 33;
			this.pictureBox1.TabStop = false;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(43, 213);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(797, 150);
			this.dataGridView1.TabIndex = 34;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// textBoxSerach
			// 
			this.textBoxSerach.BackColor = System.Drawing.Color.White;
			this.textBoxSerach.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxSerach.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.textBoxSerach.Location = new System.Drawing.Point(136, 119);
			this.textBoxSerach.Margin = new System.Windows.Forms.Padding(2);
			this.textBoxSerach.Name = "textBoxSerach";
			this.textBoxSerach.Size = new System.Drawing.Size(241, 22);
			this.textBoxSerach.TabIndex = 36;
			this.textBoxSerach.TextChanged += new System.EventHandler(this.textBoxSerach_TextChanged);
			// 
			// labelSerach
			// 
			this.labelSerach.AutoSize = true;
			this.labelSerach.BackColor = System.Drawing.Color.Transparent;
			this.labelSerach.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.labelSerach.ForeColor = System.Drawing.Color.White;
			this.labelSerach.Location = new System.Drawing.Point(39, 119);
			this.labelSerach.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelSerach.Name = "labelSerach";
			this.labelSerach.Size = new System.Drawing.Size(61, 21);
			this.labelSerach.TabIndex = 35;
			this.labelSerach.Text = "Search";
			// 
			// buttonViewOrderItem
			// 
			this.buttonViewOrderItem.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.buttonViewOrderItem.Location = new System.Drawing.Point(370, 163);
			this.buttonViewOrderItem.Margin = new System.Windows.Forms.Padding(2);
			this.buttonViewOrderItem.Name = "buttonViewOrderItem";
			this.buttonViewOrderItem.Size = new System.Drawing.Size(158, 33);
			this.buttonViewOrderItem.TabIndex = 38;
			this.buttonViewOrderItem.Text = "View Order Items";
			this.buttonViewOrderItem.UseVisualStyleBackColor = true;
			this.buttonViewOrderItem.Click += new System.EventHandler(this.buttonViewOrderItem_Click);
			// 
			// buttonViewOrder
			// 
			this.buttonViewOrder.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.buttonViewOrder.Location = new System.Drawing.Point(43, 163);
			this.buttonViewOrder.Margin = new System.Windows.Forms.Padding(2);
			this.buttonViewOrder.Name = "buttonViewOrder";
			this.buttonViewOrder.Size = new System.Drawing.Size(261, 33);
			this.buttonViewOrder.TabIndex = 37;
			this.buttonViewOrder.Text = "View All  Replenishment Order";
			this.buttonViewOrder.UseVisualStyleBackColor = true;
			this.buttonViewOrder.Click += new System.EventHandler(this.buttonViewOrder_Click);
			// 
			// buttonConfirm
			// 
			this.buttonConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.buttonConfirm.Location = new System.Drawing.Point(43, 550);
			this.buttonConfirm.Margin = new System.Windows.Forms.Padding(2);
			this.buttonConfirm.Name = "buttonConfirm";
			this.buttonConfirm.Size = new System.Drawing.Size(87, 35);
			this.buttonConfirm.TabIndex = 39;
			this.buttonConfirm.Text = "Confirm";
			this.buttonConfirm.UseVisualStyleBackColor = true;
			this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
			// 
			// buttonCorder
			// 
			this.buttonCorder.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.buttonCorder.Location = new System.Drawing.Point(627, 163);
			this.buttonCorder.Margin = new System.Windows.Forms.Padding(2);
			this.buttonCorder.Name = "buttonCorder";
			this.buttonCorder.Size = new System.Drawing.Size(213, 33);
			this.buttonCorder.TabIndex = 40;
			this.buttonCorder.Text = "View Confirmed Order ";
			this.buttonCorder.UseVisualStyleBackColor = true;
			this.buttonCorder.Click += new System.EventHandler(this.buttonCorder_Click);
			// 
			// textBoxStatus
			// 
			this.textBoxStatus.BackColor = System.Drawing.Color.White;
			this.textBoxStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxStatus.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.textBoxStatus.Location = new System.Drawing.Point(171, 508);
			this.textBoxStatus.Margin = new System.Windows.Forms.Padding(2);
			this.textBoxStatus.Name = "textBoxStatus";
			this.textBoxStatus.ReadOnly = true;
			this.textBoxStatus.Size = new System.Drawing.Size(123, 22);
			this.textBoxStatus.TabIndex = 48;
			// 
			// labelPayment
			// 
			this.labelPayment.AutoSize = true;
			this.labelPayment.BackColor = System.Drawing.Color.Transparent;
			this.labelPayment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.labelPayment.ForeColor = System.Drawing.Color.White;
			this.labelPayment.Location = new System.Drawing.Point(56, 508);
			this.labelPayment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelPayment.Name = "labelPayment";
			this.labelPayment.Size = new System.Drawing.Size(61, 21);
			this.labelPayment.TabIndex = 47;
			this.labelPayment.Text = "Status:";
			// 
			// textBoxEmployee
			// 
			this.textBoxEmployee.BackColor = System.Drawing.Color.White;
			this.textBoxEmployee.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxEmployee.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.textBoxEmployee.Location = new System.Drawing.Point(171, 464);
			this.textBoxEmployee.Margin = new System.Windows.Forms.Padding(2);
			this.textBoxEmployee.Name = "textBoxEmployee";
			this.textBoxEmployee.ReadOnly = true;
			this.textBoxEmployee.Size = new System.Drawing.Size(123, 22);
			this.textBoxEmployee.TabIndex = 46;
			// 
			// labelAmount
			// 
			this.labelAmount.AutoSize = true;
			this.labelAmount.BackColor = System.Drawing.Color.Transparent;
			this.labelAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.labelAmount.ForeColor = System.Drawing.Color.White;
			this.labelAmount.Location = new System.Drawing.Point(56, 462);
			this.labelAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelAmount.Name = "labelAmount";
			this.labelAmount.Size = new System.Drawing.Size(111, 21);
			this.labelAmount.TabIndex = 45;
			this.labelAmount.Text = "Employee ID:";
			// 
			// textBoxOrderDate
			// 
			this.textBoxOrderDate.BackColor = System.Drawing.Color.White;
			this.textBoxOrderDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxOrderDate.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.textBoxOrderDate.Location = new System.Drawing.Point(171, 420);
			this.textBoxOrderDate.Margin = new System.Windows.Forms.Padding(2);
			this.textBoxOrderDate.Name = "textBoxOrderDate";
			this.textBoxOrderDate.ReadOnly = true;
			this.textBoxOrderDate.Size = new System.Drawing.Size(123, 22);
			this.textBoxOrderDate.TabIndex = 44;
			// 
			// labelOrderDate
			// 
			this.labelOrderDate.AutoSize = true;
			this.labelOrderDate.BackColor = System.Drawing.Color.Transparent;
			this.labelOrderDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.labelOrderDate.ForeColor = System.Drawing.Color.White;
			this.labelOrderDate.Location = new System.Drawing.Point(56, 420);
			this.labelOrderDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelOrderDate.Name = "labelOrderDate";
			this.labelOrderDate.Size = new System.Drawing.Size(97, 21);
			this.labelOrderDate.TabIndex = 43;
			this.labelOrderDate.Text = "Order Date:";
			// 
			// textBoxOrderID
			// 
			this.textBoxOrderID.BackColor = System.Drawing.Color.White;
			this.textBoxOrderID.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxOrderID.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.textBoxOrderID.Location = new System.Drawing.Point(171, 380);
			this.textBoxOrderID.Margin = new System.Windows.Forms.Padding(2);
			this.textBoxOrderID.Name = "textBoxOrderID";
			this.textBoxOrderID.ReadOnly = true;
			this.textBoxOrderID.Size = new System.Drawing.Size(123, 22);
			this.textBoxOrderID.TabIndex = 42;
			// 
			// labelOrderID
			// 
			this.labelOrderID.AutoSize = true;
			this.labelOrderID.BackColor = System.Drawing.Color.Transparent;
			this.labelOrderID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.labelOrderID.ForeColor = System.Drawing.Color.White;
			this.labelOrderID.Location = new System.Drawing.Point(56, 378);
			this.labelOrderID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelOrderID.Name = "labelOrderID";
			this.labelOrderID.Size = new System.Drawing.Size(74, 21);
			this.labelOrderID.TabIndex = 41;
			this.labelOrderID.Text = "OrderID:";
			// 
			// ViewrReplenishmentOrder
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(52)))), ((int)(((byte)(98)))));
			this.ClientSize = new System.Drawing.Size(1283, 685);
			this.Controls.Add(this.textBoxStatus);
			this.Controls.Add(this.labelPayment);
			this.Controls.Add(this.textBoxEmployee);
			this.Controls.Add(this.labelAmount);
			this.Controls.Add(this.textBoxOrderDate);
			this.Controls.Add(this.labelOrderDate);
			this.Controls.Add(this.textBoxOrderID);
			this.Controls.Add(this.labelOrderID);
			this.Controls.Add(this.buttonCorder);
			this.Controls.Add(this.buttonConfirm);
			this.Controls.Add(this.buttonViewOrderItem);
			this.Controls.Add(this.buttonViewOrder);
			this.Controls.Add(this.textBoxSerach);
			this.Controls.Add(this.labelSerach);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.pictureBox1);
			this.Name = "ViewrReplenishmentOrder";
			this.Text = "ViewrReplenishmentOrder";
			this.Load += new System.EventHandler(this.ViewrReplenishmentOrder_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox textBoxSerach;
		private System.Windows.Forms.Label labelSerach;
		private System.Windows.Forms.Button buttonViewOrderItem;
		private System.Windows.Forms.Button buttonViewOrder;
		private System.Windows.Forms.Button buttonConfirm;
		private System.Windows.Forms.Button buttonCorder;
		private System.Windows.Forms.TextBox textBoxStatus;
		private System.Windows.Forms.Label labelPayment;
		private System.Windows.Forms.TextBox textBoxEmployee;
		private System.Windows.Forms.Label labelAmount;
		private System.Windows.Forms.TextBox textBoxOrderDate;
		private System.Windows.Forms.Label labelOrderDate;
		private System.Windows.Forms.TextBox textBoxOrderID;
		private System.Windows.Forms.Label labelOrderID;
	}
}