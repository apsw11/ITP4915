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
	public partial class ModifyInstallation : Form
	{
		MySqlConnection sqlConn = new MySqlConnection();
		MySqlCommand sqlCmd = new MySqlCommand();
		DataTable sqlDt = new DataTable();

		MySqlDataAdapter DtA = new MySqlDataAdapter();
		MySqlDataReader sqlRd;
		DataSet DS = new DataSet();

		int button;
		String address;

		string search;
		public ModifyInstallation()
		{
			InitializeComponent();
		}

		private void ModifyInstallation_Load(object sender, EventArgs e)
		{
			if (sqlConn.State == ConnectionState.Open)
			{
				sqlConn.Close();
			}


			sqlCmd.Parameters.Clear();


			sqlConn.ConnectionString = "server=localhost;user id=root;password=64959441;database=ITP4915";

			sqlConn.Open();
			sqlCmd.Connection = sqlConn;
			sqlCmd.CommandText = "SELECT * FROM ITP4915.delivery_emp"; //change right here
			sqlCmd.CommandType = CommandType.Text;
			sqlRd = sqlCmd.ExecuteReader();

			while (sqlRd.Read())
			{
				string empid = (sqlRd["delivery_empID"].ToString());  //change right here

			}
		}

		private void buttonEdit_Click(object sender, EventArgs e)
		{
			textBoxAddress.Text = address;

			textBoxDeliveryDate.ReadOnly = false;
			textBoxCustomerName.ReadOnly = false;
			textBoxAddress.ReadOnly = false;
			textBoxPhoneNumber.ReadOnly = false;
			textBoxWorker.ReadOnly = false;
			buttonUpdate.Visible = true;

			textBoxCustomerName.UseSystemPasswordChar = false;
			textBoxAddress.UseSystemPasswordChar = false;
			textBoxPhoneNumber.UseSystemPasswordChar = false;
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			if (sqlConn.State == ConnectionState.Open)
			{
				sqlConn.Close();
			}

			DateTime dateValue = DateTime.Parse(textBoxDeliveryDate.Text);
			string formatForMySql = dateValue.ToString("yyyy-MM-dd HH:mm");

			sqlConn.ConnectionString = "server=localhost;user id=root;password=64959441;database=ITP4915";
			sqlConn.Open();

			MySqlCommand sqlCmd = new MySqlCommand();
			sqlCmd.Connection = sqlConn;
			sqlCmd.CommandText = "UPDATE Delivery,customer,delivery_empGeneral SET  Delivery.installation =@DeliveryDate,customer.customerName=@Name,customer.address=@address,customer.PhoneNum=@PhoneNum,delivery_empGeneral.delivery_empID=@empID  WHERE Delivery.customerID = customer.customerID AND Delivery.DeliveryID =delivery_empGeneral.deliveryID AND Delivery.DeliveryID=@DeliveryID";


			sqlCmd.CommandType = CommandType.Text;
			sqlCmd.Parameters.AddWithValue("@DeliveryDate", formatForMySql);
			sqlCmd.Parameters.AddWithValue("@Name", textBoxCustomerName.Text);
			sqlCmd.Parameters.AddWithValue("@address", textBoxAddress.Text);
			sqlCmd.Parameters.AddWithValue("@PhoneNum", textBoxPhoneNumber.Text);
			sqlCmd.Parameters.AddWithValue("@empID", textBoxWorker.Text);
			sqlCmd.Parameters.AddWithValue("DeliveryID", textBoxDeliveryID.Text);

			try
			{
				sqlCmd.ExecuteNonQuery();
				sqlConn.Close();

				MessageBox.Show("data updated!");
				textBoxDeliveryDate.ReadOnly = true;
				textBoxCustomerName.ReadOnly = true;
				textBoxAddress.ReadOnly = true;
				textBoxPhoneNumber.ReadOnly = true;
				textBoxWorker.ReadOnly = true;
				buttonUpdate.Visible = false;

				textBoxCustomerName.UseSystemPasswordChar = true;
				textBoxAddress.UseSystemPasswordChar = true;
				textBoxPhoneNumber.UseSystemPasswordChar = true;

				textBoxDeliveryDate.Text = null;
				textBoxCustomerName.Text = null;
				textBoxAddress.Text = null;
				textBoxPhoneNumber.Text = null;
				textBoxWorker.Text = null;
				textBoxDeliveryID.Text = null;
				textBoxOrderID.Text = null;
				textBoxCustomerID.Text = null;


			}

			catch (Exception ex)
			{
				MessageBox.Show("input the data again!");
			}

			if (button == 1) { dataGridView1.DataSource = ViewDelivery(); }
			else
				dataGridView1.DataSource = Today();
		}

		public class ID
		{
			public static string EmpID;

		}

		private DataTable ViewDelivery()
		{
			DataTable dt = new DataTable();
			string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;


			using (MySqlConnection con = new MySqlConnection(connString))
			{

				using (MySqlCommand cmd = new MySqlCommand("SELECT Delivery.DeliveryID,Delivery.installation,SalesOrder.orderID,Delivery.customerID,delivery_empGeneral.delivery_empID from Delivery,SalesOrder,delivery_empGeneral where  Delivery.orderID = SalesOrder.orderID AND Delivery.DeliveryID=delivery_empGeneral.deliveryID" + search, con))
				{
					con.Open();

					MySqlDataReader reader = cmd.ExecuteReader();

					dt.Load(reader);
					dataGridView1.DataSource = dt;


				}
			}





			return dt;
		}

		private void buttonViewDeliver_Click(object sender, EventArgs e)
		{
			
		}

		private DataTable Today()
		{
			DataTable dt = new DataTable();
			string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;

			//	try {
			using (MySqlConnection con = new MySqlConnection(connString))
			{

				using (MySqlCommand cmd = new MySqlCommand("SELECT Delivery.DeliveryID,Delivery.installation,SalesOrder.orderID,Delivery.customerID,delivery_empGeneral.delivery_empID from Delivery,SalesOrder,delivery_empGeneral where  Delivery.DeliveryID=delivery_empGeneral.deliveryID AND Delivery.orderID = SalesOrder.orderID " + search + " AND DATE(DeliveryDate) = CURDATE();", con))
				{
					con.Open();

					MySqlDataReader reader = cmd.ExecuteReader();

					dt.Load(reader);

					dataGridView1.DataSource = dt;

				}
			}
			//	}
			//	catch (Exception e) { search = null;  MessageBox.Show("YOU SHOULD INPUT A NUMBER!"); }


			return dt; ;
		}

		

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			textBoxDeliveryID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
			textBoxDeliveryDate.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
			textBoxOrderID.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
			textBoxCustomerID.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
			textBoxWorker.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
			textBoxAddress.Text = null;

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


		}



		private void textBoxWorkMan_TextChanged(object sender, EventArgs e)
		{
			search = null;
			search = " AND Delivery.DeliveryID LIKE '%" + textBoxDelID.Text + "%'";

			if (button == 1) { dataGridView1.DataSource = ViewDelivery(); }
			else
				dataGridView1.DataSource = Today();


		}

		private void buttonViewDeliver_Click_1(object sender, EventArgs e)
		{
			search = null;
			dataGridView1.DataSource = ViewDelivery();
			button = 1;
		}

		private void buttonToday_Click_1(object sender, EventArgs e)
		{
			search = null;
			dataGridView1.DataSource = Today();
			button = 2;
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void textBoxDeliveryDate_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
