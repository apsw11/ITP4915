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
	public partial class viewPurchaseOrder : Form
	{
		MySqlConnection sqlConn = new MySqlConnection();
		MySqlCommand sqlCmd = new MySqlCommand();
		DataTable sqlDt = new DataTable();

		MySqlDataAdapter DtA = new MySqlDataAdapter();
		MySqlDataReader sqlRd;
		DataSet DS = new DataSet();
		string search;
		int button;
		string sqlQuery;
		public viewPurchaseOrder()
		{
			InitializeComponent();
		}

		public class ID
		{
			public static string EmpID;
			public static string storeID;
			public static string department;
		}

		private DataTable viewAllOrder()
		{
			DataTable dt = new DataTable();
			string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;



			using (MySqlConnection con = new MySqlConnection(connString))
			{

				using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM purchaseorder WHERE empID LIKE'P%' " + search, con))
				{
					con.Open();

					MySqlDataReader reader = cmd.ExecuteReader();

					dt.Load(reader);



				}
			}


			return dt;
		}

		private void viewPurchaseOrder_Load(object sender, EventArgs e)
		{

		}

		private void buttonViewOrder_Click(object sender, EventArgs e)
		{
			if (ID.department == "A") {
				buttonDeny.Visible = true;
				buttonApprove.Visible = true;
			}
			
			button = 1;
			dataGridView1.Enabled = true;
			dataGridView1.DataSource = viewAllOrder();
		}


		public DataTable viewItems()
		{

			DataTable dt = new DataTable();
			string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;



			using (MySqlConnection con = new MySqlConnection(connString))
			{

				using (MySqlCommand cmd = new MySqlCommand("SELECT ReorderRequestItem.RequestID,ReorderRequestItem.itemID,item.itemName,ReorderRequestItem.qty, item.supplierID from ReorderRequestItem,item  where ReorderRequestItem.itemID=item.itemID  AND ReorderRequestItem.RequestID=" + textBoxOrderID.Text + "" + search, con))
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
			buttonApprove.Visible= false;
			buttonDeny.Visible= false;
			
			if (string.IsNullOrWhiteSpace(textBoxOrderID.Text))
			{
				MessageBox.Show("YOU MUST SELECT A ORDER FIRST!");
				button = 1;
			}

			else { 
				dataGridView1.Enabled = false;
				dataGridView1.DataSource = viewItems(); 
			}
				
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
			textBoxOrderID.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
			textBoxOrderDate.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
			textBoxEmployee.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
			textBoxStatus.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
			textBoxComment.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
		}

		private void buttonApprove_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(textBox1.Text))
			{
				MessageBox.Show("YOU MUST CHOOSE THE ORDER!");
			}

			else {

				DialogResult Result = MessageBox.Show("Are you sure to approve purchase order id:" + textBox1.Text + "? ", "Confirm Message", MessageBoxButtons.OKCancel);
				if (Result == DialogResult.OK) {


					if (sqlConn.State == ConnectionState.Open)
					{
						sqlConn.Close();
					}

					sqlConn.ConnectionString = "server=localhost;user id=root;password=64959441;database=ITP4915";
					sqlConn.Open();

					MySqlCommand sqlCmd = new MySqlCommand();
					sqlCmd.Connection = sqlConn;
					sqlCmd.CommandText = "UPDATE ITP4915.PurchaseOrder SET PurchaseOrder.approval ='approval' WHERE PurchaseOrder.PurchaseID = @orderID";


					sqlCmd.CommandType = CommandType.Text;
					sqlCmd.Parameters.AddWithValue("@orderID", textBox1.Text);
					try
					{
						sqlCmd.ExecuteNonQuery();
						sqlConn.Close();
						sqlCmd.Parameters.Clear();
						MessageBox.Show("Purchase Order Approved");

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

					MySqlCommand sqlCmd1 = new MySqlCommand();
					sqlCmd1.Connection = sqlConn;
					sqlCmd1.CommandText = "UPDATE ITP4915.ReorderRequest SET ReorderRequest.`check` ='Not Checked' WHERE ReorderRequest.RequestID = @orderID";


					sqlCmd1.CommandType = CommandType.Text;
					sqlCmd1.Parameters.AddWithValue("@orderID", textBoxOrderID.Text);
					try
					{
						sqlCmd1.ExecuteNonQuery();
						sqlConn.Close();
						dataGridView1.DataSource = viewAllOrder();
						sqlCmd.Parameters.Clear();
						MessageBox.Show("Re-Order Request Approved");

					}





					catch (Exception ex)
					{
						MessageBox.Show("try again!");
					}



				}


			}
		}

		private void buttonDeny_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(textBoxOrderID.Text))
			{
				MessageBox.Show("YOU MUST CHOOSE THE ORDER!");
			}


			else
			{
				DialogResult Result = MessageBox.Show("Are you sure to deny purchase order id:" + textBox1.Text + "? ", "Confirm Message", MessageBoxButtons.OKCancel);

				if (Result == DialogResult.OK)
				{

					if (sqlConn.State == ConnectionState.Open)
					{
						sqlConn.Close();
					}

					sqlConn.ConnectionString = "server=localhost;user id=root;password=64959441;database=ITP4915";
					sqlConn.Open();

					MySqlCommand sqlCmd = new MySqlCommand();
					sqlCmd.Connection = sqlConn;
					sqlCmd.CommandText = "UPDATE ITP4915.ReorderRequest SET ReorderRequest.approval ='deny' WHERE ReorderRequest.RequestID = @orderID";


					sqlCmd.CommandType = CommandType.Text;
					sqlCmd.Parameters.AddWithValue("@orderID", textBoxOrderID.Text);
					try
					{
						sqlCmd.ExecuteNonQuery();
						sqlConn.Close();
						dataGridView1.DataSource = viewAllOrder();
						sqlCmd.Parameters.Clear();
						MessageBox.Show("Request denied");

					}

					catch (Exception ex)
					{
						MessageBox.Show("try again");
					}


					if (sqlConn.State == ConnectionState.Open)
					{
						sqlConn.Close();
					}

					sqlConn.ConnectionString = "server=localhost;user id=root;password=64959441;database=ITP4915";
					sqlConn.Open();

					MySqlCommand sqlCmd2 = new MySqlCommand();
					sqlCmd2.Connection = sqlConn;
					sqlCmd2.CommandText = "UPDATE ITP4915.ReorderRequest SET ReorderRequest.comment =@comment WHERE ReorderRequest.RequestID = @orderID";


					sqlCmd2.CommandType = CommandType.Text;
					sqlCmd2.Parameters.AddWithValue("@orderID", textBoxOrderID.Text);
					sqlCmd2.Parameters.AddWithValue("@comment", textBoxComment.Text);

					try
					{
						sqlCmd2.ExecuteNonQuery();
						sqlConn.Close();
						dataGridView1.DataSource = viewAllOrder();
						sqlCmd2.Parameters.Clear();
						MessageBox.Show("Comment Recorded");

					}

					catch (Exception ex)
					{
						MessageBox.Show("try again");
					}



					if (sqlConn.State == ConnectionState.Open)
					{
						sqlConn.Close();
					}

					sqlConn.ConnectionString = "server=localhost;user id=root;password=64959441;database=ITP4915";
					sqlConn.Open();

					MySqlCommand sqlCmd3 = new MySqlCommand();
					sqlCmd3.Connection = sqlConn;
					sqlCmd3.CommandText = "UPDATE ITP4915.PurchaseOrder SET PurchaseOrder.approval ='deny' WHERE PurchaseOrder.PurchaseID  = @orderID";


					sqlCmd3.CommandType = CommandType.Text;
					sqlCmd3.Parameters.AddWithValue("@orderID", textBox1.Text);
					try
					{
						sqlCmd3.ExecuteNonQuery();
						sqlConn.Close();
						dataGridView1.DataSource = viewAllOrder();
						sqlCmd3.Parameters.Clear();
						MessageBox.Show("Purchase Order denied");

					}

					catch (Exception ex)
					{
						MessageBox.Show("try again");
					}



					if (sqlConn.State == ConnectionState.Open)
					{
						sqlConn.Close();
					}

					sqlConn.ConnectionString = "server=localhost;user id=root;password=64959441;database=ITP4915";
					sqlConn.Open();

					MySqlCommand sqlCmd4 = new MySqlCommand();
					sqlCmd4.Connection = sqlConn;
					sqlCmd4.CommandText = "UPDATE ITP4915.PurchaseOrder SET PurchaseOrder.comment =@comment WHERE PurchaseOrder.PurchaseID = @orderID";


					sqlCmd4.CommandType = CommandType.Text;
					sqlCmd4.Parameters.AddWithValue("@orderID", textBox1.Text);
					sqlCmd4.Parameters.AddWithValue("@comment", textBoxComment.Text);

					try
					{
						sqlCmd4.ExecuteNonQuery();
						sqlConn.Close();
						dataGridView1.DataSource = viewAllOrder();
						sqlCmd4.Parameters.Clear();
						MessageBox.Show("Purchase Order Comment Recorded");

					}

					catch (Exception ex)
					{
						MessageBox.Show("try again");
					}

					textBoxComment.Text = null;

				}

			}
		}
	}
}
