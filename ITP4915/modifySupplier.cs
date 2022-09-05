using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace ITP4915
{
	public partial class modifySupplier : Form
	{
		MySqlConnection sqlConn = new MySqlConnection();
		MySqlCommand sqlCmd = new MySqlCommand();
		DataTable sqlDt = new DataTable();
		String sqlQuery;
		MySqlDataAdapter DtA = new MySqlDataAdapter();
		MySqlDataReader sqlRd;
		DataSet DS = new DataSet();
		string search =null;
		public modifySupplier()
		{
			InitializeComponent();
		}

		private void modifySupplier_Load(object sender, EventArgs e)
		{
			dataGridView1.DataSource = viewSupplier();
		}

		private DataTable viewSupplier() {
			DataTable dt = new DataTable();
			string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;



			using (MySqlConnection con = new MySqlConnection(connString))
			{
				 
				using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM  Supplier " + search, con))
				{
					con.Open();

					MySqlDataReader reader = cmd.ExecuteReader();

					dt.Load(reader);



				}
			}


			return dt;
		}

		private void buttonEdit_Click(object sender, EventArgs e)
		{
			textBoxsupplierID.ReadOnly = false;
			textBoxsupplierName.ReadOnly = false;
			textBoxAddress.ReadOnly = false;
			textBoxPhoneNumber.ReadOnly = false;
			buttonUpdate.Visible = true;
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			textBoxsupplierID.ReadOnly = false;
			textBoxsupplierName.ReadOnly = false;
			textBoxAddress.ReadOnly = false;
			textBoxPhoneNumber.ReadOnly = false;
			buttonEnter.Visible = true;
			textBoxsupplierID.Text = null;
			textBoxsupplierName.Text = null;
			textBoxAddress.Text = null;
			textBoxPhoneNumber.Text = null;

		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			textBoxsupplierID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
			textBoxsupplierName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
			textBoxAddress.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
			textBoxPhoneNumber.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
		

		}

		private void textBoxSearch_TextChanged(object sender, EventArgs e)
		{
			search = null;
			search += "WHERE  supplierID LIKE '%" + textBoxSearch.Text + "%'";
			search += "or supplierName LIKE '%" + textBoxSearch.Text + "%'";
			search += "or supplierPhoneNumber   LIKE '%" + textBoxSearch.Text + "%'"; ;
			search += "or supplierAddress LIKE '%" + textBoxSearch.Text + "%' ";


			dataGridView1.DataSource = viewSupplier();
			viewSupplier();
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			if (sqlConn.State == ConnectionState.Open)
			{
				sqlConn.Close();
			}

			sqlConn.ConnectionString = "server=localhost;user id=root;password=64959441;database=ITP4915";
			sqlConn.Open();

			MySqlCommand sqlCmd = new MySqlCommand();
			sqlCmd.Connection = sqlConn;
			sqlCmd.CommandText = "UPDATE ITP4915.Supplier SET supplierName = @supplierName , supplierPhoneNumber=@supplierPhoneNumber,supplierAddress =@supplierAddress  WHERE supplierID = @supplierID";


			sqlCmd.CommandType = CommandType.Text;
			sqlCmd.Parameters.AddWithValue("@supplierID", textBoxsupplierID.Text);
			sqlCmd.Parameters.AddWithValue("@supplierName", textBoxsupplierName.Text);
			sqlCmd.Parameters.AddWithValue("@supplierPhoneNumber", textBoxPhoneNumber.Text);
			sqlCmd.Parameters.AddWithValue("@supplierAddress", textBoxAddress.Text);
			try
			{
				sqlCmd.ExecuteNonQuery();
				sqlConn.Close();
				viewSupplier();

				textBoxsupplierID.ReadOnly = true;
				textBoxsupplierName.ReadOnly = true;
				textBoxAddress.ReadOnly = true;
				textBoxPhoneNumber.ReadOnly = true;

				textBoxsupplierID.Text = null;
				textBoxsupplierName.Text = null;
				textBoxAddress.Text = null;
				textBoxPhoneNumber.Text = null;
				buttonUpdate.Visible = false;
				dataGridView1.DataSource = viewSupplier();
				MessageBox.Show("Data Updated!");

			}
			catch (Exception ex)
			{
				MessageBox.Show("Data Updated!");

			}
			
		}

		private void buttonEnter_Click(object sender, EventArgs e)
		{
			if (sqlConn.State == ConnectionState.Open)
			{
				sqlConn.Close();
			}
			sqlConn.ConnectionString = "server=localhost;user id=root;password=64959441;database=ITP4915";
			sqlConn.Open();

			MySqlCommand sqlCmd = new MySqlCommand();
			sqlCmd.Connection = sqlConn;

			sqlQuery = "insert into ITP4915.Supplier (supplierID,supplierName,supplierPhoneNumber,supplierAddress)" +
				 "value('" + textBoxsupplierID.Text + "'," + "'" + textBoxsupplierName.Text + "','" + textBoxAddress.Text + "',"  + textBoxPhoneNumber.Text + ")";
			sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
			sqlRd = sqlCmd.ExecuteReader();

			sqlConn.Close();

			buttonEnter.Visible = false;
	
			textBoxsupplierID.Text = null;
			textBoxsupplierName.Text = null;
			textBoxAddress.Text = null;
			textBoxPhoneNumber.Text = null;

			buttonEnter.Visible = false;
			textBoxsupplierID.ReadOnly = true;
			textBoxsupplierName.ReadOnly = true;
			textBoxAddress.ReadOnly = true;
			textBoxPhoneNumber.ReadOnly = true;
			MessageBox.Show("Supplier Added");
			dataGridView1.DataSource = viewSupplier();
			
		}
	}
}
