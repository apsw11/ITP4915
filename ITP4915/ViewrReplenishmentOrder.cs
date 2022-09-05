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
	public partial class ViewrReplenishmentOrder : Form
	{
		MySqlConnection sqlConn = new MySqlConnection();
		MySqlCommand sqlCmd = new MySqlCommand();
		DataTable sqlDt = new DataTable();

		MySqlDataAdapter DtA = new MySqlDataAdapter();
		MySqlDataReader sqlRd;
		DataSet DS = new DataSet();
		string search;
		int button;

		public ViewrReplenishmentOrder()
		{
			InitializeComponent();
		}

		public class ID
		{
			public static string storeID;
		}


		private DataTable viewAllOrder()
		{
			DataTable dt = new DataTable();
			string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;



			using (MySqlConnection con = new MySqlConnection(connString))
			{

				using (MySqlCommand cmd = new MySqlCommand("select * from replenishmentOrder  WHERE storeID ='" + ID.storeID + "'" + search, con))
				{
					con.Open();

					MySqlDataReader reader = cmd.ExecuteReader();

					dt.Load(reader);



				}
			}


			return dt;
		}

		private DataTable viewCOrder()
		{
			DataTable dt = new DataTable();
			string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;



			using (MySqlConnection con = new MySqlConnection(connString))
			{

				using (MySqlCommand cmd = new MySqlCommand("select * from replenishmentOrder  WHERE  status='Y' AND storeID ='" + ID.storeID + "'" + search, con))
				{
					con.Open();

					MySqlDataReader reader = cmd.ExecuteReader();

					dt.Load(reader);



				}
			}


			return dt;
		}


		private void ViewrReplenishmentOrder_Load(object sender, EventArgs e)
		{
			
		}

		private void buttonViewOrder_Click(object sender, EventArgs e)
		{
			dataGridView1.Enabled = true;
			labelOrderDate.Text = "Order Date:";
			labelAmount.Text = "Employee ID:";
			labelPayment.Text = "Status:";
			search = null;
			button = 1;
			buttonConfirm.Text = "Confirm";
			dataGridView1.DataSource = viewAllOrder();
	
		}

		private void textBoxSerach_TextChanged(object sender, EventArgs e)
		{
			/*
			search = null;
			if (button == 1)
			{
				search = " AND (salesOrder.orderID LIKE '%" + textBoxSerach.Text + "%'";
				search += "or salesorder.amount  LIKE '%" + textBoxSerach.Text + "%'";
				search += "or salesorder.payment LIKE '%" + textBoxSerach.Text + "%'";
				search += "or customer.customerID  LIKE '%" + textBoxSerach.Text + "%'";
				search += "or customer.customerName  LIKE '%" + textBoxSerach.Text + "%'";
				search += "or customer.address LIKE '%" + textBoxSerach.Text + "%'";
				search += "or customer.PhoneNum LIKE '%" + textBoxSerach.Text + "%' )";


				dataGridView1.DataSource = viewAllOrder();
			}

			if (button == 2)
			{
				search = " AND (orderItem.itemID LIKE '%" + textBoxSerach.Text + "%' ";
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


				dataGridView1.DataSource = viewCOrder();
			}

			*/
		}

		public DataTable viewItems()
		{

			DataTable dt = new DataTable();
			string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;



			using (MySqlConnection con = new MySqlConnection(connString))
			{

				using (MySqlCommand cmd = new MySqlCommand("SELECT RorderItem.RorderID,RorderItem.itemID,item.itemName,RorderItem.qty from RorderItem,item  where RorderItem.itemID=item.itemID  AND RorderItem.RorderID=" + textBoxOrderID.Text + "" + search, con))
				{
					con.Open();

					MySqlDataReader reader = cmd.ExecuteReader();

					dt.Load(reader);



				}
			}


			return dt;
		}

		private void buttonViewOrderItem_Click(object sender, EventArgs e)
		{
			search = null;
			button = 2;
		
			labelOrderDate.Text = "Item ID:";
			labelAmount.Text = "Item Name";
			labelPayment.Text = "qty:";
			if (string.IsNullOrWhiteSpace(textBoxOrderID.Text))
			{
				MessageBox.Show("YOU MUST SELECT A ORDER FIRST!");
				button = 1;
			}

			else
				dataGridView1.DataSource = viewItems();
		}

		private void buttonCorder_Click(object sender, EventArgs e)
		{
			dataGridView1.Enabled = true;
			labelOrderDate.Text = "Order Date:";
			labelAmount.Text = "Employee ID:";
			labelPayment.Text = "Status:";
			search = null;
			button = 1;
			buttonConfirm.Text = "Restore order";
			dataGridView1.DataSource = viewCOrder();
		}

		private void buttonConfirm_Click(object sender, EventArgs e)
		{
			string status ="" ;
			string orderID = null;

			if (string.IsNullOrWhiteSpace(textBoxOrderID.Text)) {
				MessageBox.Show("YOU MUST CHOOSE A ORDER!");
			}

			else

			if (buttonConfirm.Text == "Confirm")
			{



				sqlConn.ConnectionString = "server=localhost;user id=root;password=64959441;database=ITP4915";

				sqlConn.Open();
				sqlCmd.Connection = sqlConn;
				sqlCmd.CommandText = "select Delivery.status,orderID FROM Delivery where RorderID = " + textBoxOrderID.Text;
				sqlCmd.CommandType = CommandType.Text;

				sqlRd = sqlCmd.ExecuteReader();
				if (sqlRd.Read())
				{
					status = (sqlRd["status"].ToString());
					orderID= (sqlRd["orderID"].ToString());

				}
				sqlRd.Close();
				sqlConn.Close();
				sqlCmd.Parameters.Clear();

				if (status == "deliverying to store")
				{
					



					if (sqlConn.State == ConnectionState.Open)
					{
						sqlConn.Close();
					}

					sqlConn.ConnectionString = "server=localhost;user id=root;password=64959441;database=ITP4915";
					sqlConn.Open();

					MySqlCommand sqlCmd = new MySqlCommand();
					sqlCmd.Connection = sqlConn;
					sqlCmd.CommandText = "UPDATE ITP4915.replenishmentOrder SET replenishmentOrder.status ='Y' WHERE replenishmentOrder.RorderID = @orderID";


					sqlCmd.CommandType = CommandType.Text;
					sqlCmd.Parameters.AddWithValue("@orderID", textBoxOrderID.Text);
					try
					{
						sqlCmd.ExecuteNonQuery();
						sqlConn.Close();
						dataGridView1.DataSource = viewAllOrder();
						sqlCmd.Parameters.Clear();
						MessageBox.Show("Order Confirmed");

					}





					catch (Exception ex)
					{
						MessageBox.Show("try again!");
					}




					if (sqlConn.State == ConnectionState.Open)
					{
						sqlConn.Close();
					}

					sqlConn.ConnectionString = "server=localhost;user id=root;password=64959441;database=ITP4915";
					sqlConn.Open();

					MySqlCommand sqlCmda = new MySqlCommand();
					sqlCmda.Connection = sqlConn;
					sqlCmda.CommandText = "UPDATE Delivery SET status='In Stock' WHERE Delivery.RorderID= @orderID";


					sqlCmda.CommandType = CommandType.Text;
					sqlCmda.Parameters.AddWithValue("@orderID", textBoxOrderID.Text);
					try
					{
						sqlCmda.ExecuteNonQuery();
						sqlConn.Close();
						dataGridView1.DataSource = viewAllOrder();
						sqlCmda.Parameters.Clear();
						MessageBox.Show("Delivery status updated!");

					}





					catch (Exception ex)
					{
						MessageBox.Show("try again!");
					}


					

					if (orderID != "")
					{
						MessageBox.Show("The items of sales order " + orderID + " are ready ");
					}

					else {


						if (sqlConn.State == ConnectionState.Open)
						{
							sqlConn.Close();
						}

						sqlConn.ConnectionString = "server=localhost;user id=root;password=64959441;database=ITP4915";
						sqlConn.Open();

						MySqlCommand sqlCmd2 = new MySqlCommand();
						sqlCmd2.Connection = sqlConn;
						sqlCmd2.CommandText = "UPDATE instoreitem i1 INNER JOIN RorderItem R2 ON i1.itemID = R2.itemID SET i1.qty = i1.qty + R2.qty  WHERE R2.RorderID =@orderID AND i1.storeID='" + ID.storeID + "'";


						sqlCmd2.CommandType = CommandType.Text;

						sqlCmd2.Parameters.AddWithValue("@orderID", textBoxOrderID.Text);
						try
						{
							sqlCmd2.ExecuteNonQuery();
							sqlConn.Close();
							dataGridView1.DataSource = viewAllOrder();
							sqlCmd2.Parameters.Clear();
							MessageBox.Show("Store Item Updated!");

						}





						catch (Exception ex)
						{
							MessageBox.Show("try again! 2");
						}



						if (sqlConn.State == ConnectionState.Open)
						{
							sqlConn.Close();
						}

						sqlConn.ConnectionString = "server=localhost;user id=root;password=64959441;database=ITP4915";
						sqlConn.Open();

						MySqlCommand sqlCmd3 = new MySqlCommand();
						sqlCmd3.Connection = sqlConn;
						sqlCmd3.CommandText = "UPDATE instoreitem i1 INNER JOIN RorderItem R2 ON i1.itemID = R2.itemID SET i1.requested = 'N' WHERE R2.RorderID =@orderID AND i1.storeID='" + ID.storeID + "'";


						sqlCmd3.CommandType = CommandType.Text;

						sqlCmd3.Parameters.AddWithValue("@orderID", textBoxOrderID.Text);

						sqlCmd3.ExecuteNonQuery();
						sqlConn.Close();
						dataGridView1.DataSource = viewAllOrder();
						sqlCmd3.Parameters.Clear();


					}




				}

				else {
					MessageBox.Show("THE ORDER STILL IN WAREHOUSE!");
				}


				
			}

			else if (buttonConfirm.Text == "Restore order")
			{

				if (sqlConn.State == ConnectionState.Open)
				{
					sqlConn.Close();
				}

				sqlConn.ConnectionString = "server=localhost;user id=root;password=64959441;database=ITP4915";
				sqlConn.Open();

				MySqlCommand sqlCmd = new MySqlCommand();
				sqlCmd.Connection = sqlConn;
				sqlCmd.CommandText = "UPDATE ITP4915.replenishmentOrder SET replenishmentOrder.status ='N' WHERE replenishmentOrder.RorderID = @orderID";


				sqlCmd.CommandType = CommandType.Text;
				sqlCmd.Parameters.AddWithValue("@orderID", textBoxOrderID.Text);
				try
				{
					sqlCmd.ExecuteNonQuery();
					sqlConn.Close();
					dataGridView1.DataSource = viewAllOrder();
					sqlCmd.Parameters.Clear();
					MessageBox.Show("Order Restored");

				}


				catch (Exception ex)
				{
					MessageBox.Show("try again!");
				}

				if (sqlConn.State == ConnectionState.Open)
				{
					sqlConn.Close();
				}

				sqlConn.ConnectionString = "server=localhost;user id=root;password=64959441;database=ITP4915";
				sqlConn.Open();

				MySqlCommand sqlCmda = new MySqlCommand();
				sqlCmda.Connection = sqlConn;
				sqlCmda.CommandText = "UPDATE Delivery SET status='deliverying to store' WHERE Delivery.RorderID= @orderID";


				sqlCmda.CommandType = CommandType.Text;
				sqlCmda.Parameters.AddWithValue("@orderID", textBoxOrderID.Text);
				try
				{
					sqlCmda.ExecuteNonQuery();
					sqlConn.Close();
					dataGridView1.DataSource = viewAllOrder();
					sqlCmda.Parameters.Clear();
					MessageBox.Show("Delivery status updated!");

				}





				catch (Exception ex)
				{
					MessageBox.Show("try again!");
				}


				if (sqlConn.State == ConnectionState.Open)
				{
					sqlConn.Close();
				}

				sqlConn.ConnectionString = "server=localhost;user id=root;password=64959441;database=ITP4915";
				sqlConn.Open();

				MySqlCommand sqlCmd2 = new MySqlCommand();
				sqlCmd2.Connection = sqlConn;
				sqlCmd2.CommandText = "UPDATE instoreitem i1 INNER JOIN RorderItem R2 ON i1.itemID = R2.itemID SET i1.qty = i1.qty - R2.qty  WHERE R2.RorderID =@orderID AND i1.storeID='" + ID.storeID + "'";


				sqlCmd2.CommandType = CommandType.Text;

				sqlCmd2.Parameters.AddWithValue("@orderID", textBoxOrderID.Text);
				try
				{
					sqlCmd2.ExecuteNonQuery();
					sqlConn.Close();
					dataGridView1.DataSource = viewAllOrder();
					sqlCmd2.Parameters.Clear();
					MessageBox.Show("Store Item Updated!");

				}





				catch (Exception ex)
				{
					MessageBox.Show("try again! 2");
				}



				if (sqlConn.State == ConnectionState.Open)
				{
					sqlConn.Close();
				}

				sqlConn.ConnectionString = "server=localhost;user id=root;password=64959441;database=ITP4915";
				sqlConn.Open();

				MySqlCommand sqlCmd3 = new MySqlCommand();
				sqlCmd3.Connection = sqlConn;
				sqlCmd3.CommandText = "UPDATE instoreitem i1 INNER JOIN RorderItem R2 ON i1.itemID = R2.itemID SET i1.requested = 'Y' WHERE R2.RorderID =@orderID AND i1.storeID='" + ID.storeID + "'";


				sqlCmd3.CommandType = CommandType.Text;

				sqlCmd3.Parameters.AddWithValue("@orderID", textBoxOrderID.Text);

				sqlCmd3.ExecuteNonQuery();
				sqlConn.Close();
				dataGridView1.DataSource = viewAllOrder();
				sqlCmd3.Parameters.Clear();




			}
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{

			if (button == 1 || button == 3)
			{
				textBoxOrderID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
				textBoxOrderDate.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
				textBoxEmployee.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
				textBoxStatus.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
			}

			if (button == 2) {
				textBoxOrderID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
				textBoxOrderDate.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
				textBoxEmployee.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
				textBoxStatus.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();

			}
		
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
