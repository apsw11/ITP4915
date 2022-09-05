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
	public partial class DailyDeliveryList : Form
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
		public DailyDeliveryList()
		{
			InitializeComponent();
		}

		private void DailyDeliveryList_Load(object sender, EventArgs e)
		{

		}

	

		public DataTable viewDaily()
		{
			DataTable dt = new DataTable();
			string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;



			using (MySqlConnection con = new MySqlConnection(connString))
			{

				using (MySqlCommand cmd = new MySqlCommand("SELECT Delivery.DeliveryID,Delivery.DeliveryDate,SalesOrder.orderID,Delivery.customerID,delivery_empGeneral.delivery_empID from Delivery,SalesOrder,delivery_empGeneral where Delivery.orderID = SalesOrder.orderID AND  Delivery.DeliveryID = delivery_empGeneral.deliveryID AND delivery_empGeneral.delivery_empID='" + ID.EmpID + "'" + search+ " AND Delivery.status = 'In Stock' AND DATE(DeliveryDate) = CURDATE();", con))
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
			else { 
				dataGridView1.Enabled = false;
				dataGridView1.DataSource = viewItems(); }
				
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
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

		private void buttonTakeOrder_Click(object sender, EventArgs e)
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
			sqlCmd.CommandText = "UPDATE ITP4915.Delivery SET  status ='in delivery' WHERE deliveryID =@deliveryID";


			sqlCmd.CommandType = CommandType.Text;
			sqlCmd.Parameters.AddWithValue("@deliveryID",  textBoxDeliveryID.Text);



				sqlCmd.ExecuteNonQuery();
				sqlConn.Close();
				sqlCmd.Parameters.Clear();
				MessageBox.Show("You have accepted this order :)");

			

		

			textBoxCustomerID.UseSystemPasswordChar = false;
			textBoxCustomerName.UseSystemPasswordChar=false;
			textBoxAddress.UseSystemPasswordChar=false;
			textBoxPhoneNumber.UseSystemPasswordChar=false;

		}

		public class ID
		{
			public static string EmpID;

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
	}
}
