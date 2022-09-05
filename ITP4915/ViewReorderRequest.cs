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
	public partial class ViewReorderRequest : Form
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
		public ViewReorderRequest()
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

				using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM ReorderRequest WHERE empID LIKE'I%' "+ search, con))
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

				using (MySqlCommand cmd = new MySqlCommand("select * from ReorderRequest  WHERE  approval='approved' AND `check`='Not Checked' " + search, con))
				{
					con.Open();

					MySqlDataReader reader = cmd.ExecuteReader();

					dt.Load(reader);



				}
			}


			return dt;
		}

		private void ViewReorderRequest_Load(object sender, EventArgs e)
		{
			
			
			if (ID.department == "P") {
				buttonConfirm.Text = "approval";
				buttonConfirm.Visible = true;
			}
		}

		private void buttonViewOrder_Click(object sender, EventArgs e)
		{
			if (ID.department == "P")
			{
				buttonConfirm.Visible = true;
				buttonDeny.Visible = true;
				dataGridView1.Enabled = true;
				labelOrderDate.Text = "Order Date:";
				labelAmount.Text = "Employee ID:";
				labelPayment.Text = "Status:";
				labelComment.Text = "Comment:";
				search = null;
				button = 1;

				dataGridView1.DataSource = viewAllOrder();
			}
			else {
				dataGridView1.Enabled = true;
				labelOrderDate.Text = "Order Date:";
				labelAmount.Text = "Employee ID:";
				labelPayment.Text = "Status:";
				labelComment.Text = "Comment:";
				search = null;
				button = 1;

				dataGridView1.DataSource = viewAllOrder();
				buttonConfirm.Visible = false;
			}
			
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
			buttonDeny.Visible = false;
			search = null;
			button = 2;
			buttonConfirm.Visible=false;
			labelOrderDate.Text = "Item ID:";
			labelAmount.Text = "Item Name";
			labelPayment.Text = "qty:";
			labelComment.Text = "Supplier ID:";
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
			buttonDeny.Visible = false;
			if (ID.department == "P")
			{
				buttonConfirm.Visible = false;
				dataGridView1.Enabled = true;
				labelOrderDate.Text = "Order Date:";
				labelAmount.Text = "Employee ID:";
				labelPayment.Text = "Status:";
				labelComment.Text = "Comment:";
				search = null;
				button = 1;

				dataGridView1.DataSource = viewCOrder();
			}


			else {
				buttonConfirm.Visible = true;
				dataGridView1.Enabled = true;
				labelOrderDate.Text = "Order Date:";
				labelAmount.Text = "Employee ID:";
				labelPayment.Text = "Status:";
				labelComment.Text = "Comment:";
				search = null;
				button = 1;

				dataGridView1.DataSource = viewCOrder();
			}
			
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (button == 1 || button == 3)
			{
				textBoxOrderID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
				textBoxOrderDate.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
				textBoxEmployee.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
				textBoxStatus.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
				textBoxComment.Text=dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
			}

			if (button == 2)
			{
				textBoxOrderID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
				textBoxOrderDate.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
				textBoxEmployee.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
				textBoxStatus.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
				textBoxComment.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();

			}
		}

		private void buttonConfirm_Click(object sender, EventArgs e)
		{
			if (buttonConfirm.Text == "Confirm")
			{
				if (string.IsNullOrWhiteSpace(textBoxOrderID.Text))
				{
					MessageBox.Show("YOU MUST CHOOSE THE ORDER!");
				}

				else
				{
					DialogResult Result= MessageBox.Show("Are you sure all the items of id:" + textBoxOrderID.Text +" are arrived? " ,"Confirm Message" , MessageBoxButtons.OKCancel);

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
						sqlCmd.CommandText = "UPDATE ITP4915.ReorderRequest SET ReorderRequest.`check` ='Checked' WHERE ReorderRequest.RequestID = @orderID";


						sqlCmd.CommandType = CommandType.Text;
						sqlCmd.Parameters.AddWithValue("@orderID", textBoxOrderID.Text);
						try
						{
							sqlCmd.ExecuteNonQuery();
							sqlConn.Close();
							dataGridView1.DataSource = viewAllOrder();
							sqlCmd.Parameters.Clear();
							MessageBox.Show("Request Confirmed");

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
						sqlCmd2.CommandText = "UPDATE warehouseItem w1 INNER JOIN ReorderRequestItem R2 ON w1.itemID = R2.itemID SET w1.qty = w1.qty + R2.qty  WHERE R2.RequestID  =@orderID ";


						sqlCmd2.CommandType = CommandType.Text;

						sqlCmd2.Parameters.AddWithValue("@orderID", textBoxOrderID.Text);
						try
						{
							sqlCmd2.ExecuteNonQuery();
							sqlConn.Close();
							dataGridView1.DataSource = viewAllOrder();
							sqlCmd2.Parameters.Clear();
							MessageBox.Show("Warehouse Item Updated!");

						}





						catch (Exception ex)
						{
							MessageBox.Show("try again! 2");
						}
					}


					


				}
			
			}

			else if (buttonConfirm.Text == "approval") {
				if (string.IsNullOrWhiteSpace(textBoxOrderID.Text))
				{
					MessageBox.Show("YOU MUST CHOOSE THE ORDER!");
				}

				else {
					DialogResult Result = MessageBox.Show("Are you sure to approve request id:" + textBoxOrderID.Text + "? ", "Confirm Message", MessageBoxButtons.OKCancel);

					if (Result == DialogResult.OK) {






						if (sqlConn.State == ConnectionState.Open)
						{
							sqlConn.Close();
						}

						sqlConn.ConnectionString = "server=localhost;user id=root;password=64959441;database=ITP4915";
						sqlConn.Open();

						MySqlCommand sqlCmd = new MySqlCommand();
						sqlCmd.Connection = sqlConn;
						sqlCmd.CommandText = "UPDATE ITP4915.ReorderRequest SET ReorderRequest.approval ='approved' WHERE ReorderRequest.RequestID = @orderID";


						sqlCmd.CommandType = CommandType.Text;
						sqlCmd.Parameters.AddWithValue("@orderID", textBoxOrderID.Text);
						try
						{
							sqlCmd.ExecuteNonQuery();
							sqlConn.Close();
							dataGridView1.DataSource = viewAllOrder();
							sqlCmd.Parameters.Clear();
							MessageBox.Show("Request approved");

						}





						catch (Exception ex)
						{
							MessageBox.Show("try again!");
						}


						sqlConn.ConnectionString = "server=localhost;user id=root;password=64959441;database=ITP4915";

						if (sqlConn.State == ConnectionState.Open)
						{
							sqlConn.Close();
						}

						sqlConn.Open();
						sqlQuery = "INSERT INTO  PurchaseOrder VALUES(NULL," + textBoxOrderID.Text + ", DEFAULT,'" + ID.EmpID + "',now(),null)";
						sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
						sqlRd = sqlCmd.ExecuteReader();
						sqlConn.Close();

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
				DialogResult Result = MessageBox.Show("Are you sure to deny request id:" + textBoxOrderID.Text + "? ", "Confirm Message", MessageBoxButtons.OKCancel);

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

					catch (Exception ex) {
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
						MessageBox.Show("Request denied");

					}

					catch (Exception ex)
					{
						MessageBox.Show("try again");
					}


				}

			}

		}
	}
}
