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
	public partial class ViewSalesOrder : Form
	{

		MySqlConnection sqlConn = new MySqlConnection();
		MySqlCommand sqlCmd = new MySqlCommand();
		DataTable sqlDt = new DataTable();
		
		MySqlDataAdapter DtA = new MySqlDataAdapter();
		MySqlDataReader sqlRd;
		DataSet DS = new DataSet();
		public ViewSalesOrder()
		{
			InitializeComponent();
		}

		private void upLoadData()
		{
			sqlConn.ConnectionString = "server=localhost;user id=root;password=64959441;database=ITP4915";

			sqlConn.Open();
			sqlCmd.Connection = sqlConn;
			sqlCmd.CommandText = "SELECT * FROM ITP4915.SalesOrder";

			sqlRd = sqlCmd.ExecuteReader();
			sqlDt.Load(sqlRd);
			sqlRd.Close();
			sqlConn.Close();
			dataGridView1.DataSource = sqlDt;
		}
		private void ViewSalesOrder_Load(object sender, EventArgs e)
		{

			upLoadData();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (sqlConn.State == ConnectionState.Open)
			{
				sqlConn.Close();
			}

			sqlConn.ConnectionString = "server=localhost;user id=root;password=64959441;database=ITP4915";
			sqlConn.Open();

			MySqlCommand sqlCmd = new MySqlCommand();
			sqlCmd.Connection = sqlConn;
			sqlCmd.CommandText = "UPDATE ITP4915.SalesOrder SET delivery = @delivery, payment = @payment  WHERE orderID = @orderID";


			sqlCmd.CommandType = CommandType.Text;
			sqlCmd.Parameters.AddWithValue("@orderID", textBoxOrderID.Text);
			sqlCmd.Parameters.AddWithValue("@delivery", textBoxDelivery.Text);
			sqlCmd.Parameters.AddWithValue("@payment", textBoxPayment.Text);

			try
			{
				sqlCmd.ExecuteNonQuery();
				sqlConn.Close();
				upLoadData();
				buttonUpdate.Enabled = false;
				textBoxDelivery.ReadOnly = true;
				textBoxPayment.ReadOnly = true;
				MessageBox.Show("data updated!");

			}

			catch (Exception ex) {
				MessageBox.Show("input the data again!");
			}




		}

		private void buttonEdit_Click(object sender, EventArgs e)
		{
			buttonUpdate.Enabled = true;
			textBoxDelivery.ReadOnly = false;
			textBoxPayment.ReadOnly = false;
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			textBoxOrderID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
			textBoxOrderDate.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
			textBoxAmount.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
			textBoxDelivery.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
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
			DataView dv = new DataView(sqlDt);
			dv.RowFilter = string.Format("convert(orderID,'System.String') LIKE '%{0}%'", textBoxSerach.Text);
			dataGridView1.DataSource = dv;
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
