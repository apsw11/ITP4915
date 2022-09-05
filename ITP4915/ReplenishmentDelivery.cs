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
	public partial class ReplenishmentDelivery : Form
	{
		String address;
		MySqlConnection sqlConn = new MySqlConnection();
		MySqlCommand sqlCmd = new MySqlCommand();
		DataTable sqlDt = new DataTable();

		MySqlDataAdapter DtA = new MySqlDataAdapter();
		MySqlDataReader sqlRd;
		DataSet DS = new DataSet();
		string sqlQuery;
		int RID;


		string search;
		int button;
		public ReplenishmentDelivery()
		{
			InitializeComponent();
		}

		public DataTable viewDaily()
		{
			DataTable dt = new DataTable();
			string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;



			using (MySqlConnection con = new MySqlConnection(connString))
			{

				using (MySqlCommand cmd = new MySqlCommand("SELECT * from Delivery where  Delivery.status = 'In Warehouse'   AND DATE(DeliveryDate) = CURDATE();", con))
				{
					con.Open();

					MySqlDataReader reader = cmd.ExecuteReader();

					dt.Load(reader);



				}
			}


			return dt;
		}


		public DataTable myOrder()
		{
			DataTable dt = new DataTable();
			string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;



			using (MySqlConnection con = new MySqlConnection(connString))
			{

				using (MySqlCommand cmd = new MySqlCommand("SELECT replenishmentDelivery.deliveryID, Delivery.DeliveryDate,Delivery.RorderID FROM replenishmentDelivery,Delivery WHERE replenishmentDelivery.deliveryID = Delivery.DeliveryID AND replenishmentDelivery.replenishment_emp='"+ ID.EmpID + "'", con))
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

				using (MySqlCommand cmd = new MySqlCommand("SELECT * from  RorderItem where RorderID=" + textBoxOrderID.Text, con))
				{
					con.Open();

					MySqlDataReader reader = cmd.ExecuteReader();

					dt.Load(reader);



				}
			}
			return dt;

		}

		private void guna2GroupBox1_Click(object sender, EventArgs e)
		{

		}

		private void ReplenishmentDelivery_Load(object sender, EventArgs e)
		{

		}

		private void buttonViewDaily_Click(object sender, EventArgs e)
		{
			buttonTakeOrder.Enabled = true;
			label1.Text = "Delivery ID:";
			label2.Text = "Delivery Date";
			buttonTakeOrder.Enabled = true;
			button = 1;
			label8.Visible = true;
			textBoxDelID.Visible = true;
			search = null;
			dataGridView1.Enabled = true;
			dataGridView1.DataSource = viewDaily();
		}

		private void buttonViewItems_Click(object sender, EventArgs e)
		{
			buttonTakeOrder.Enabled = false;
			label1.Text = "Item ID:";
			label2.Text = "QTY";
			buttonTakeOrder.Enabled = true;
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
			
				dataGridView1.DataSource = viewItems();
			}
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (button == 1)
			{
				textBoxDeliveryID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
				textBoxDeliveryDate.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
				textBoxOrderID.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();

				sqlConn.ConnectionString = "server=localhost;user id=root;password=64959441;database=ITP4915";

				sqlConn.Open();
				sqlCmd.Connection = sqlConn;
				sqlCmd.CommandText = "SELECT store.address ,replenishmentOrder.storeID FROM store,replenishmentOrder WHERE store.storeID = replenishmentOrder.storeID  AND replenishmentOrder.RorderID =" + textBoxOrderID.Text;
				sqlCmd.CommandType = CommandType.Text;

				sqlRd = sqlCmd.ExecuteReader();
				if (sqlRd.Read())
				{
					textBox1.Text = (sqlRd["address"].ToString());


				}
				else
				{
					textBoxDeliveryID.Text = null;
					textBoxDeliveryDate.Text = null;
					textBoxOrderID.Text = null;
					textBox1.Text = null;
				}

				sqlRd.Close();
				sqlConn.Close();
				sqlCmd.Parameters.Clear();
			}

			if (button == 2) {
				textBoxDeliveryID.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
				textBoxDeliveryDate.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
				textBoxOrderID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
			}

			if (button == 3) {
				textBoxDeliveryID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
				textBoxDeliveryDate.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
				textBoxOrderID.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();

				sqlConn.ConnectionString = "server=localhost;user id=root;password=64959441;database=ITP4915";

				sqlConn.Open();
				sqlCmd.Connection = sqlConn;
				sqlCmd.CommandText = "SELECT store.address ,replenishmentOrder.storeID FROM store,replenishmentOrder WHERE store.storeID = replenishmentOrder.storeID  AND replenishmentOrder.RorderID =" + textBoxOrderID.Text;
				sqlCmd.CommandType = CommandType.Text;

				sqlRd = sqlCmd.ExecuteReader();
				if (sqlRd.Read())
				{
					textBox1.Text = (sqlRd["address"].ToString());


				}
				else
				{
					textBoxDeliveryID.Text = null;
					textBoxDeliveryDate.Text = null;
					textBoxOrderID.Text = null;
					textBox1.Text = null;
				}

				sqlRd.Close();
				sqlConn.Close();
				sqlCmd.Parameters.Clear();
			}
			
		



		
		}

		private void buttonTakeOrder_Click(object sender, EventArgs e)
		{
			if (sqlConn.State == ConnectionState.Open)
			{
				sqlConn.Close();
			}



			sqlConn.ConnectionString = "server=localhost;user id=root;password=64959441;database=ITP4915";
			sqlConn.Open();

			MySqlCommand sqlCmd = new MySqlCommand();
			sqlCmd.Connection = sqlConn;
			sqlCmd.CommandText = "UPDATE ITP4915.Delivery SET  status ='deliverying to store' WHERE deliveryID =@deliveryID";


			sqlCmd.CommandType = CommandType.Text;
			sqlCmd.Parameters.AddWithValue("@deliveryID", textBoxDeliveryID.Text);



			sqlCmd.ExecuteNonQuery();
			sqlConn.Close();
			sqlCmd.Parameters.Clear();
			MessageBox.Show("You have accepted this order :)");


			sqlConn.Open();
			sqlQuery = "INSERT INTO replenishmentDelivery VALUES("+textBoxDeliveryID.Text+", '"+ ID.EmpID + "' )";
			sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
			sqlRd = sqlCmd.ExecuteReader();
			sqlConn.Close();



		}
		public class ID
		{
			public static string EmpID ;

		}

		private void textBoxDelID_TextChanged(object sender, EventArgs e)
		{
			search = null;

			if (button == 1 || button == 3)
			{
				search = " AND replenishmentDelivery.deliveryID LIKE '%" + textBoxDelID.Text + "%'";
				dataGridView1.DataSource = viewDaily();
			}

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void buttonMyOrder_Click(object sender, EventArgs e)
		{
			buttonTakeOrder.Enabled = false;
			label1.Text = "Delivery ID:";
			label2.Text = "Delivery Date";
			button = 3;
			label8.Visible = true;
			textBoxDelID.Visible = true;
			search = null;
			dataGridView1.Enabled = true;
			dataGridView1.DataSource = myOrder();
			buttonTakeOrder.Enabled = false;

		}
	}
}
