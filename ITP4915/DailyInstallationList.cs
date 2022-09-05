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
	public partial class DailyInstallationList : Form
	{
		String address;
		MySqlConnection sqlConn = new MySqlConnection();
		MySqlCommand sqlCmd = new MySqlCommand();
		DataTable sqlDt = new DataTable();

		MySqlDataAdapter DtA = new MySqlDataAdapter();
		MySqlDataReader sqlRd;
		DataSet DS = new DataSet();
		string search;
		int button;
		string sqlQuery;

		public DailyInstallationList()
		{
			InitializeComponent();
		}

		private void DailyInstallationList_Load(object sender, EventArgs e)
		{

		}

		private void textBoxDelID_TextChanged(object sender, EventArgs e)
		{

			search = null;

			if (button == 1)
			{
				search = " AND Delivery.DeliveryID LIKE '%" + textBoxDelID.Text + "%'";
				dataGridView1.DataSource = viewDaily();
			}

		}


		public DataTable viewDaily()
		{
			DataTable dt = new DataTable();
			string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;



			using (MySqlConnection con = new MySqlConnection(connString))
			{

				using (MySqlCommand cmd = new MySqlCommand("SELECT Delivery.DeliveryID,Delivery.installation,SalesOrder.orderID,Delivery.customerID from Delivery,SalesOrder where Delivery.orderID = SalesOrder.orderID  AND Delivery.status ='in delivery'  " + search + " AND DATE(DeliveryDate) = CURDATE() AND installation IS NOT null;", con))
				{
					con.Open();

					MySqlDataReader reader = cmd.ExecuteReader();

					dt.Load(reader);



				}
			}


			return dt;
		}


		public DataTable MyOrder()
		{
			DataTable dt = new DataTable();
			string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;



			using (MySqlConnection con = new MySqlConnection(connString))
			{
			
				using (MySqlCommand cmd = new MySqlCommand("SELECT Delivery.DeliveryID,Delivery.installation,SalesOrder.orderID,Delivery.customerID,installationEmp.installationEmp from Delivery,SalesOrder, installationEmp where Delivery.orderID = SalesOrder.orderID  AND installationEmp.deliveryID =Delivery.DeliveryID " + search + " AND DATE(DeliveryDate) = CURDATE() AND installation IS NOT null AND installationEmp.installationEmp='" +ID.EmpID+"';", con))
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

				using (MySqlCommand cmd = new MySqlCommand("SELECT * from  orderItem where orderID=" + textBoxOrderID.Text, con))
				{
					con.Open();

					MySqlDataReader reader = cmd.ExecuteReader();

					dt.Load(reader);



				}
			}
			return dt;

		}

		private void buttonViewDaily_Click(object sender, EventArgs e)
		{
			button = 1;
			label8.Visible = true;
			textBoxDelID.Visible = true;
			search = null;
			dataGridView1.Enabled = true;
			dataGridView1.DataSource = viewDaily();
		}


		private void buttonViewItems_Click(object sender, EventArgs e)
		{
			button = 2;
			label8.Visible = false;
			textBoxDelID.Visible = false;
			search = null;
			if (string.IsNullOrWhiteSpace(textBoxOrderID.Text))
			{
				MessageBox.Show("YOU MUST SELECT A DELIVERY FIRST!");
			}
			else
			{
				dataGridView1.Enabled = false;
				dataGridView1.DataSource = viewItems();
			}

		}


		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}


		private void buttonTakeOrder_Click(object sender, EventArgs e)
		{
			

		}

		public class ID
		{
			public static string EmpID;

		}

		private void buttonViewDaily_Click_1(object sender, EventArgs e)
		{
			button = 1;
			label8.Visible = true;
			textBoxDelID.Visible = true;
			search = null;
			dataGridView1.Enabled = true;
			dataGridView1.DataSource = viewDaily();
		}

		private void buttonViewItems_Click_1(object sender, EventArgs e)
		{
			button = 2;
			label8.Visible = false;
			textBoxDelID.Visible = false;
			search = null;
			if (string.IsNullOrWhiteSpace(textBoxOrderID.Text))
			{
				MessageBox.Show("YOU MUST SELECT A DELIVERY FIRST!");
			}
			else
			{
				dataGridView1.Enabled = false;
				dataGridView1.DataSource = viewItems();
			}
		}

		private void buttonTakeOrder_Click_1(object sender, EventArgs e)
		{


			



			if (sqlConn.State == ConnectionState.Open)
			{
				sqlConn.Close();
			}
			textBoxAddress.Text = address;

			sqlConn.ConnectionString = "server=localhost;user id=root;password=64959441;database=ITP4915";
			sqlConn.Open();

			MySqlCommand sqlCmd = new MySqlCommand();
			sqlCmd.Connection = sqlConn;
			sqlCmd.CommandText = "UPDATE ITP4915.Delivery SET  status ='installing' WHERE deliveryID =@deliveryID";


			sqlCmd.CommandType = CommandType.Text;
			sqlCmd.Parameters.AddWithValue("@deliveryID", textBoxDeliveryID.Text);



			sqlCmd.ExecuteNonQuery();
			sqlConn.Close();
			sqlCmd.Parameters.Clear();
			MessageBox.Show("You have accepted this order :)");

			if (sqlConn.State == ConnectionState.Open)
			{
				sqlConn.Close();
			}


			sqlConn.Open();
			sqlQuery = "INSERT INTO installationEmp VALUES("+ textBoxDeliveryID.Text +", '"+ID.EmpID +"')";
			sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
			sqlRd = sqlCmd.ExecuteReader();
			sqlConn.Close();





			textBoxCustomerID.UseSystemPasswordChar = false;
			textBoxCustomerName.UseSystemPasswordChar = false;
			textBoxAddress.UseSystemPasswordChar = false;
			textBoxPhoneNumber.UseSystemPasswordChar = false;
		}

		private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
		{
			textBoxDeliveryID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
			textBoxDeliveryDate.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
			textBoxOrderID.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
			textBoxCustomerID.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();


			if (sqlConn.State == ConnectionState.Open)
			{
				sqlConn.Close();
			}

			sqlConn.ConnectionString = "server=localhost;user id=root;password=64959441;database=ITP4915";
			sqlConn.Open();
			sqlCmd.Connection = sqlConn;
			sqlCmd.CommandText = "SELECT customerName,address,PhoneNum FROM ITP4915.customer WHERE customerID ='" + textBoxCustomerID.Text + "'";
			sqlCmd.CommandType = CommandType.Text;

			sqlRd = sqlCmd.ExecuteReader();
			if (sqlRd.Read())
			{
				textBoxCustomerName.Text = (sqlRd["customerName"].ToString());
				address = (sqlRd["address"].ToString());
				textBoxPhoneNumber.Text = (sqlRd["PhoneNum"].ToString());


			}

			else
			{
				textBoxCustomerName.Text = null;
				textBoxAddress.Text = null;
				textBoxPhoneNumber.Text = null;

			}
			sqlRd.Close();
			sqlConn.Close();
			sqlCmd.Parameters.Clear();
			textBoxCustomerID.UseSystemPasswordChar = true;
			textBoxCustomerName.UseSystemPasswordChar = true;
			textBoxAddress.UseSystemPasswordChar = true;
			textBoxPhoneNumber.UseSystemPasswordChar = true;
		}

		private void buttonMyOrder_Click(object sender, EventArgs e)
		{
			label8.Visible = true;
			textBoxDelID.Visible = true;
			search = null;
			dataGridView1.Enabled = true;
			dataGridView1.DataSource = MyOrder();
		}
	}
}
