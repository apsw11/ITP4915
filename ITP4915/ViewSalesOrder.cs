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
using System.Configuration;

namespace ITP4915
{
	public partial class ViewSalesOrder : Form
	{

		MySqlConnection sqlConn = new MySqlConnection();
		MySqlCommand sqlCmd = new MySqlCommand();
		DataTable sqlDt = new DataTable();
		
		MySqlDataAdapter DtA = new MySqlDataAdapter();
		MySqlDataReader sqlRd;
		DataSet DS = new DataSet();
		string search;
		int button;
		public ViewSalesOrder()
		{
			InitializeComponent();
		}

		private DataTable viewSalesOrder()
		{
			DataTable dt = new DataTable();
			string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;



			using (MySqlConnection con = new MySqlConnection(connString))
			{

				using (MySqlCommand cmd = new MySqlCommand("SELECT salesOrder.orderID,salesOrder.orderDate,salesorder.amount,salesorder.payment,customer.customerID,customer.customerName,customer.address,customer.PhoneNum,salesorder.deposit FROM salesOrder,customer  WHERE salesorder.customerID = customer.customerID AND salesorder.cancel='N'  AND storeID ='" + ID.storeID + "'" +search, con))
				{
					con.Open();

					MySqlDataReader reader = cmd.ExecuteReader();

					dt.Load(reader);



				}
			}


			return dt;
		}

		private DataTable viewCancelOrder() {

			DataTable dt = new DataTable();
			string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;



			using (MySqlConnection con = new MySqlConnection(connString))
			{

				using (MySqlCommand cmd = new MySqlCommand("SELECT salesOrder.orderID,salesOrder.orderDate,salesorder.amount,salesorder.payment,customer.customerID,customer.customerName,customer.address,customer.PhoneNum,salesorder.deposit FROM salesOrder,customer  WHERE salesorder.customerID = customer.customerID AND salesorder.cancel='Y'  AND storeID ='" + ID.storeID + "'" + search, con))
				{
					con.Open();

					MySqlDataReader reader = cmd.ExecuteReader();

					dt.Load(reader);



				}
			}


			return dt;
		}

		public DataTable viewItems()
		{

			DataTable dt = new DataTable();
			string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;



			using (MySqlConnection con = new MySqlConnection(connString))
			{

				using (MySqlCommand cmd = new MySqlCommand("SELECT orderItem.orderID,orderItem.itemID,item.itemName,item.price,orderItem.qty from orderItem,item  where orderItem.itemID=item.itemID  AND orderID='" + textBoxOrderID.Text + "'" + search, con))
				{
					con.Open();

					MySqlDataReader reader = cmd.ExecuteReader();

					dt.Load(reader);



				}
			}


			return dt;
		}
		private void ViewSalesOrder_Load(object sender, EventArgs e)
		{

			
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (sqlConn.State == ConnectionState.Open)
			{
				sqlConn.Close();
			}


			DateTime dateValue = DateTime.Parse(textBoxDeliveryDate.Text);
			string formatForMySql = dateValue.ToString("yyyy-MM-dd HH:mm");

			DateTime dateValue2 = DateTime.Parse(textBoxInstallation.Text);
			string formatForMySql2 = dateValue.ToString("yyyy-MM-dd HH:mm");

			sqlConn.ConnectionString = "server=localhost;user id=root;password=64959441;database=ITP4915";
			sqlConn.Open();

			MySqlCommand sqlCmd = new MySqlCommand();
			sqlCmd.Connection = sqlConn;
			sqlCmd.CommandText = "UPDATE ITP4915.SalesOrder,ITP4915.customer,ITP4915.Delivery SET  SalesOrder.payment =@payment,customer.customerName=@Name,customer.address=@address,customer.PhoneNum=@PhoneNum,Delivery.DeliveryDate=@DDate,Delivery.installation=@DI   WHERE SalesOrder.customerID = customer.customerID AND SalesOrder.orderID =Delivery.orderID AND SalesOrder.orderID = @orderID";


			sqlCmd.CommandType = CommandType.Text;
			sqlCmd.Parameters.AddWithValue("@orderID", textBoxOrderID.Text);
			sqlCmd.Parameters.AddWithValue("@Name", textBoxCustomerName.Text);
			sqlCmd.Parameters.AddWithValue("@payment", textBoxPayment.Text);
			sqlCmd.Parameters.AddWithValue("@address", textBoxAddress.Text);
			sqlCmd.Parameters.AddWithValue("@PhoneNum", textBoxPhone.Text);
			sqlCmd.Parameters.AddWithValue("@DDate", formatForMySql);
			sqlCmd.Parameters.AddWithValue("@DI", formatForMySql2);

			try
			{
				sqlCmd.ExecuteNonQuery();
				sqlConn.Close();
				viewSalesOrder();
				buttonUpdate.Enabled = false;

				textBoxPayment.ReadOnly = true;
				textBoxCustomerName.ReadOnly = true;
				textBoxAddress.ReadOnly = true;
				textBoxPhone.ReadOnly = true;
				textBoxDeliveryDate.ReadOnly = true;
				textBoxInstallation.ReadOnly = true;
				textBoxStatus.ReadOnly = true;
				MessageBox.Show("data updated!");

			}

			catch (Exception ex)
			{
				MessageBox.Show("input the data again!");
			}
		}

		public class ID
		{
			public static string storeID;
		}
		private void buttonEdit_Click(object sender, EventArgs e)
		{
			buttonUpdate.Enabled = true;
			textBoxOrderID.ReadOnly = true;
			textBoxPayment.ReadOnly = false;
			textBoxCustomerName.ReadOnly = false;
			textBoxCID.ReadOnly = false;
			textBoxAddress.ReadOnly = false;
			textBoxPhone.ReadOnly = false;
			textBoxDeliveryDate.ReadOnly = false;
			textBoxInstallation.ReadOnly = false;
			textBoxStatus.ReadOnly = false;
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			textBoxOrderID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
			textBoxOrderDate.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
			textBoxAmount.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
			textBoxDeliveryDate.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
			textBoxPayment.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();


		}



		private void textBoxOrderID_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBoxSerach_KeyPress(object sender, KeyPressEventArgs e)
		{
			

		}

		private void textBoxSerach_TextChanged(object sender, EventArgs e)
		{
			search = null;
			if (button == 1) {
				search = " AND (salesOrder.orderID LIKE '%"+ textBoxSerach.Text+"%'";
				search += "or salesorder.amount  LIKE '%"+ textBoxSerach.Text + "%'";
				search += "or salesorder.payment LIKE '%" + textBoxSerach.Text + "%'";
				search += "or customer.customerID  LIKE '%" + textBoxSerach.Text + "%'";
				search += "or customer.customerName  LIKE '%" + textBoxSerach.Text + "%'";
				search += "or customer.address LIKE '%" + textBoxSerach.Text + "%'";
				search += "or customer.PhoneNum LIKE '%" + textBoxSerach.Text + "%' )";


				dataGridView1.DataSource = viewSalesOrder();
			}

			if (button == 2) {
				search = " AND (orderItem.itemID LIKE '%" + textBoxSerach.Text+"%' ";
				search += " or item.itemName LIKE '%" + textBoxSerach.Text + "%' ";
				search += " or item.price LIKE '%" + textBoxSerach.Text + "%' )"; 
				dataGridView1.DataSource = viewItems();
			}

			if (button == 3)
			{
				search = " AND (salesOrder.orderID LIKE '%" + textBoxSerach.Text + "%'";
				search += "or salesorder.amount  LIKE '%" + textBoxSerach.Text + "%'";
				search += "or salesorder.payment LIKE '%" + textBoxSerach.Text + "%'";
				search += "or customer.customerID  LIKE '%" + textBoxSerach.Text + "%'";
				search += "or customer.customerName  LIKE '%" + textBoxSerach.Text + "%'";
				search += "or customer.address LIKE '%" + textBoxSerach.Text + "%'";
				search += "or customer.PhoneNum LIKE '%" + textBoxSerach.Text + "%' )";


				dataGridView1.DataSource = viewCancelOrder();
			}

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			textBoxOrderID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
			textBoxOrderDate.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
			textBoxAmount.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
			textBoxPayment.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
			textBoxCID.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
			textBoxCustomerName.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
			textBoxAddress.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
			textBoxPhone.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();

			sqlConn.ConnectionString = "server=localhost;user id=root;password=64959441;database=ITP4915";

			sqlConn.Open();
			sqlCmd.Connection = sqlConn;
			sqlCmd.CommandText = "SELECT Delivery.DeliveryID,Delivery.DeliveryDate,Delivery.installation,Delivery.status FROM ITP4915.Delivery WHERE orderID =" + textBoxOrderID.Text;
			sqlCmd.CommandType = CommandType.Text;

			sqlRd = sqlCmd.ExecuteReader();
			if (sqlRd.Read())
			{
				textBoxDeliveryID.Text = (sqlRd["DeliveryID"].ToString());
				textBoxDeliveryDate.Text = (sqlRd["DeliveryDate"].ToString());
				textBoxInstallation.Text = (sqlRd["installation"].ToString());
				textBoxStatus.Text = (sqlRd["status"].ToString());
			}

			else
			{
				textBoxDeliveryID.Text = null;
				textBoxDeliveryDate.Text = null;
				textBoxInstallation.Text = null;
				textBoxStatus.Text = null;
			}
			sqlRd.Close();
			sqlConn.Close();
			sqlCmd.Parameters.Clear();
		}

		private void buttonViewOrder_Click(object sender, EventArgs e)
		{
			dataGridView1.Enabled = true;
			search = null;
			button = 1;
			dataGridView1.DataSource = viewSalesOrder();
			buttonCancel.Text = "Cancel";
		}

		private void buttonViewOrderItem_Click(object sender, EventArgs e)
		{
			search = null;
			button = 2;
			dataGridView1.Enabled = false;
			if (string.IsNullOrWhiteSpace(textBoxOrderID.Text))
			{
				MessageBox.Show("YOU MUST SELECT A ORDER FIRST!");
				button = 1;
			}

			else
				dataGridView1.DataSource = viewItems();
		}

		private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
		{
			textBoxOrderID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
			textBoxOrderDate.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
			textBoxAmount.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
			textBoxPayment.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
			textBoxCID.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
			textBoxCustomerName.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
			textBoxAddress.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
			textBoxPhone.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
			

			sqlConn.ConnectionString = "server=localhost;user id=root;password=64959441;database=ITP4915";

			sqlConn.Open();
			sqlCmd.Connection = sqlConn;
			sqlCmd.CommandText = "SELECT Delivery.DeliveryID,Delivery.DeliveryDate,Delivery.installation,Delivery.status FROM ITP4915.Delivery WHERE orderID =" + textBoxOrderID.Text;
			sqlCmd.CommandType = CommandType.Text;

			sqlRd = sqlCmd.ExecuteReader();
			if (sqlRd.Read())
			{
				textBoxDeliveryID.Text = (sqlRd["DeliveryID"].ToString());
				textBoxDeliveryDate.Text = (sqlRd["DeliveryDate"].ToString());
				textBoxInstallation.Text = (sqlRd["installation"].ToString());
				textBoxStatus.Text = (sqlRd["status"].ToString());

			}

			else
			{
				textBoxDeliveryID.Text = null;
				textBoxDeliveryDate.Text = null;
				textBoxInstallation.Text = null;
				textBoxStatus.Text = null;	
			}
			sqlRd.Close();
			sqlConn.Close();
			sqlCmd.Parameters.Clear();
		}

		private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
		{

		}

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
			
			
			if (showcustomerInfo.Visible == false)
			{
				showcustomerInfo.Visible =   true;

			}
			else
			{
				showcustomerInfo.Visible  = false;
			}

		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			if (buttonCancel.Text == "Cancel")
			{

				if (sqlConn.State == ConnectionState.Open)
				{
					sqlConn.Close();
				}

				sqlConn.ConnectionString = "server=localhost;user id=root;password=64959441;database=ITP4915";
				sqlConn.Open();

				MySqlCommand sqlCmd = new MySqlCommand();
				sqlCmd.Connection = sqlConn;
				sqlCmd.CommandText = "UPDATE ITP4915.SalesOrder SET SalesOrder.cancel ='Y' WHERE SalesOrder.orderID = @orderID";


				sqlCmd.CommandType = CommandType.Text;
				sqlCmd.Parameters.AddWithValue("@orderID", textBoxOrderID.Text);
				try
				{
					sqlCmd.ExecuteNonQuery();
					sqlConn.Close();
					dataGridView1.DataSource = viewSalesOrder();
					sqlCmd.Parameters.Clear();
					MessageBox.Show("Order Canceled");

				}


				catch (Exception ex)
				{
					MessageBox.Show("try again!");
				}
			}

			else if (buttonCancel.Text == "Restore order") {

				if (sqlConn.State == ConnectionState.Open)
				{
					sqlConn.Close();
				}

				sqlConn.ConnectionString = "server=localhost;user id=root;password=64959441;database=ITP4915";
				sqlConn.Open();

				MySqlCommand sqlCmd = new MySqlCommand();
				sqlCmd.Connection = sqlConn;
				sqlCmd.CommandText = "UPDATE ITP4915.SalesOrder SET SalesOrder.cancel ='N' WHERE SalesOrder.orderID = @orderID";


				sqlCmd.CommandType = CommandType.Text;
				sqlCmd.Parameters.AddWithValue("@orderID", textBoxOrderID.Text);
				try
				{
					sqlCmd.ExecuteNonQuery();
					sqlConn.Close();
					dataGridView1.DataSource = viewSalesOrder();
					sqlCmd.Parameters.Clear();
					MessageBox.Show("Order Restored");

				}


				catch (Exception ex)
				{
					MessageBox.Show("try again!");
				}
			}
			
		

		}

		private void buttonViewCancel_Click(object sender, EventArgs e)
		{
			dataGridView1.Enabled = true;
			search = null;
			button = 3;
			dataGridView1.DataSource = viewCancelOrder();
			buttonCancel.Text = "Restore order"; 
		}
	}
}
