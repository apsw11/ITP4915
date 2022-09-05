namespace ITP4915
{
	partial class modifySupplier
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxsupplierID = new System.Windows.Forms.TextBox();
			this.buttonEdit = new System.Windows.Forms.Button();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.textBoxsupplierName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxAddress = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.buttonUpdate = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.textBoxSearch = new System.Windows.Forms.TextBox();
			this.buttonEnter = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToOrderColumns = true;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(48, 106);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 62;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(852, 225);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("PMingLiU", 15F);
			this.label1.Location = new System.Drawing.Point(48, 399);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(149, 30);
			this.label1.TabIndex = 1;
			this.label1.Text = "supplier ID:";
			// 
			// textBoxsupplierID
			// 
			this.textBoxsupplierID.Font = new System.Drawing.Font("PMingLiU", 15F);
			this.textBoxsupplierID.Location = new System.Drawing.Point(256, 399);
			this.textBoxsupplierID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textBoxsupplierID.Name = "textBoxsupplierID";
			this.textBoxsupplierID.ReadOnly = true;
			this.textBoxsupplierID.Size = new System.Drawing.Size(148, 43);
			this.textBoxsupplierID.TabIndex = 2;
			// 
			// buttonEdit
			// 
			this.buttonEdit.Location = new System.Drawing.Point(51, 590);
			this.buttonEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.buttonEdit.Name = "buttonEdit";
			this.buttonEdit.Size = new System.Drawing.Size(132, 51);
			this.buttonEdit.TabIndex = 9;
			this.buttonEdit.Text = "Edit";
			this.buttonEdit.UseVisualStyleBackColor = true;
			this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
			// 
			// buttonAdd
			// 
			this.buttonAdd.Location = new System.Drawing.Point(256, 590);
			this.buttonAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(128, 51);
			this.buttonAdd.TabIndex = 10;
			this.buttonAdd.Text = "Add";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// textBoxsupplierName
			// 
			this.textBoxsupplierName.Font = new System.Drawing.Font("PMingLiU", 15F);
			this.textBoxsupplierName.Location = new System.Drawing.Point(730, 394);
			this.textBoxsupplierName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textBoxsupplierName.Name = "textBoxsupplierName";
			this.textBoxsupplierName.ReadOnly = true;
			this.textBoxsupplierName.Size = new System.Drawing.Size(148, 43);
			this.textBoxsupplierName.TabIndex = 12;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("PMingLiU", 15F);
			this.label2.Location = new System.Drawing.Point(538, 404);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(188, 30);
			this.label2.TabIndex = 11;
			this.label2.Text = "supplier Name:";
			// 
			// textBoxPhoneNumber
			// 
			this.textBoxPhoneNumber.Font = new System.Drawing.Font("PMingLiU", 15F);
			this.textBoxPhoneNumber.Location = new System.Drawing.Point(256, 482);
			this.textBoxPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
			this.textBoxPhoneNumber.ReadOnly = true;
			this.textBoxPhoneNumber.Size = new System.Drawing.Size(148, 43);
			this.textBoxPhoneNumber.TabIndex = 14;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("PMingLiU", 15F);
			this.label3.Location = new System.Drawing.Point(42, 486);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(192, 30);
			this.label3.TabIndex = 13;
			this.label3.Text = "Phone Number:";
			// 
			// textBoxAddress
			// 
			this.textBoxAddress.Font = new System.Drawing.Font("PMingLiU", 15F);
			this.textBoxAddress.Location = new System.Drawing.Point(730, 482);
			this.textBoxAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textBoxAddress.Name = "textBoxAddress";
			this.textBoxAddress.ReadOnly = true;
			this.textBoxAddress.Size = new System.Drawing.Size(148, 43);
			this.textBoxAddress.TabIndex = 16;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("PMingLiU", 15F);
			this.label4.Location = new System.Drawing.Point(616, 486);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(113, 30);
			this.label4.TabIndex = 15;
			this.label4.Text = "Address:";
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(730, 591);
			this.buttonUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.buttonUpdate.Name = "buttonUpdate";
			this.buttonUpdate.Size = new System.Drawing.Size(150, 50);
			this.buttonUpdate.TabIndex = 17;
			this.buttonUpdate.Text = "Update";
			this.buttonUpdate.UseVisualStyleBackColor = true;
			this.buttonUpdate.Visible = false;
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("PMingLiU", 12F);
			this.label5.Location = new System.Drawing.Point(50, 62);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(78, 24);
			this.label5.TabIndex = 18;
			this.label5.Text = "Search:";
			// 
			// textBoxSearch
			// 
			this.textBoxSearch.Font = new System.Drawing.Font("PMingLiU", 12F);
			this.textBoxSearch.Location = new System.Drawing.Point(192, 57);
			this.textBoxSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textBoxSearch.Name = "textBoxSearch";
			this.textBoxSearch.Size = new System.Drawing.Size(322, 36);
			this.textBoxSearch.TabIndex = 19;
			this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
			// 
			// buttonEnter
			// 
			this.buttonEnter.Location = new System.Drawing.Point(584, 591);
			this.buttonEnter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.buttonEnter.Name = "buttonEnter";
			this.buttonEnter.Size = new System.Drawing.Size(138, 50);
			this.buttonEnter.TabIndex = 20;
			this.buttonEnter.Text = "Enter";
			this.buttonEnter.UseVisualStyleBackColor = true;
			this.buttonEnter.Visible = false;
			this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
			// 
			// modifySupplier
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1200, 675);
			this.Controls.Add(this.buttonEnter);
			this.Controls.Add(this.textBoxSearch);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.buttonUpdate);
			this.Controls.Add(this.textBoxAddress);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBoxPhoneNumber);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBoxsupplierName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.buttonEdit);
			this.Controls.Add(this.textBoxsupplierID);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridView1);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "modifySupplier";
			this.Text = "modifySupplier";
			this.Load += new System.EventHandler(this.modifySupplier_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxsupplierID;
		private System.Windows.Forms.Button buttonEdit;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.TextBox textBoxsupplierName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxPhoneNumber;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxAddress;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button buttonUpdate;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBoxSearch;
		private System.Windows.Forms.Button buttonEnter;
	}
}