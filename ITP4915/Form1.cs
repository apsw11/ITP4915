using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ITP4915
{
	public partial class Form1 : Form
	{
		string empID;
		string storeID;
		string position;

		private Form activeForm;
		MySqlConnection sqlConn = new MySqlConnection(); //Hugo加,改咗就好多嘢都做唔到
		MySqlCommand sqlCmd = new MySqlCommand();
		DataTable sqlDt = new DataTable();

		MySqlDataAdapter DtA = new MySqlDataAdapter();
		MySqlDataReader sqlRd;
		DataSet DS = new DataSet();
		public Form1()
		{
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			profile p1 = new profile();
			p1.setEmpID(Convert.ToString(empID));
			DialogResult result = p1.ShowDialog();
			
		}


		public void showBell() {

			if (sqlConn.State == ConnectionState.Open)
			{
				sqlConn.Close();
			}


			sqlCmd.Parameters.Clear();
			sqlConn.ConnectionString = "server=localhost;user id=root;password=64959441;database=ITP4915";

			sqlConn.Open();
			sqlCmd.Connection = sqlConn;
			sqlCmd.CommandText = "SELECT instoreItem.storeID,Item.itemID,instoreItem.qty FROM ITP4915.instoreItem,Item WHERE instoreItem.itemID=Item.itemID AND instoreItem.qty < Item.reorderLv AND instoreItem.requested ='N' AND storeID =@storeID";
			sqlCmd.CommandType = CommandType.Text;
			sqlCmd.Parameters.AddWithValue("@storeID", getstoreID());
			sqlRd = sqlCmd.ExecuteReader();

			if (sqlRd.Read()) //判斷顯示鍾仔
			{
				buttonBell.Visible = true;
				buttonBell.Enabled = true;
				
			}
			sqlRd.Close();
			sqlConn.Close();
			sqlCmd.Parameters.Clear();

		}


		public class bell
		{
			public static Boolean Bell;
			
		}



		private void Form1_Load(object sender, EventArgs e)
		{
			CreateOrder co = new CreateOrder();
			showBell();
			labelEmpID.Text ="Employee ID:" + empID;
			//Convert.ToString (getEmpID());

			if (getPosition()== "Manager") { //判斷顯示 Modify Item
			buttonModifyItem.Visible = true;
				buttonSupplier.Visible = true;
				button2.Visible = true;
			}




		}

		private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			ViewSalesOrder view = new ViewSalesOrder();
			view.ShowDialog();

		}

		private string getPosition() 
		{
			return position;
		}

		internal void setPosition(string v)
		{
			position = v;
		}

		public string getEmpID()
		{
			return empID;
		}

		internal void setEmpID(string v)
		{
			empID = v;
		}

		internal void setstoreID(string v)
		{
			storeID = v;
		}

		private string getstoreID()
		{
			return storeID;
		}

		public void OpenChildForm(Form childForm, object btnSender)
		{
			if (activeForm != null)
				activeForm.Close();
			//ActivateButton(btnSender);

			activeForm = childForm;
			childForm.TopLevel = false;
			childForm.FormBorderStyle = FormBorderStyle.None;
			childForm.Dock = DockStyle.Fill;
			this.panelDesktopPane.Controls.Add(childForm);
			this.panelDesktopPane.Tag = childForm;
			childForm.BringToFront();
			childForm.Show();
			//lblTitle.Text = childForm.Text;
		}

        private void button4_Click(object sender, EventArgs e)
        {
			showBell();
			OpenChildForm(new Home(), sender);
		}

        private void panelDesktopPane_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
			showBell();
			OpenChildForm(new CreateOrder(), sender);
		}

        private void button6_Click(object sender, EventArgs e)
        {
			showBell();
			ViewSalesOrder.ID.storeID = getstoreID();
			OpenChildForm(new ViewSalesOrder(), sender);
		}

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
		private void Home(object sender, PaintEventArgs e) { }

		private void button7_Click(object sender, EventArgs e)
		{
			showBell();
			OpenChildForm(new Items(), sender);
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void buttonBell_Click(object sender, EventArgs e) //未搬去childFrom,唔知搬唔搬好
		{
			buttonBell.Visible = false;
			replenishment.ID.storeID = getstoreID();
			replenishment.ID.EmpID= getEmpID();
			OpenChildForm(new replenishment(), sender);
			
		}

        private void buttonViewCustomer_Click(object sender, EventArgs e)
        {
			showBell();
			OpenChildForm(new ViewCustomer(), sender);
		}

        private void closebutton_Click(object sender, EventArgs e)
        {
			this.Close();
		}

		private void buttonSupplier_Click(object sender, EventArgs e)
		{
			showBell();
			OpenChildForm(new modifySupplier(), sender);
		}

		private void buttonViewROrder_Click(object sender, EventArgs e)
		{
			showBell();
			ViewrReplenishmentOrder.ID.storeID = getstoreID();
			OpenChildForm(new ViewrReplenishmentOrder(), sender);
		}

		private void buttonViewDepositOrder_Click(object sender, EventArgs e)
		{
			showBell();
			ViewDepositOrder.ID.storeID = getstoreID();
			OpenChildForm(new ViewDepositOrder(), sender);
		}

        private void button2_Click_1(object sender, EventArgs e)
        {
			OpenChildForm(new Staff(), sender);
		}
    }
}
