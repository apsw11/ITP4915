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
	public partial class Items : Form
	{
		MySqlConnection sqlConn = new MySqlConnection();
		MySqlCommand sqlCmd = new MySqlCommand();
		DataTable sqlDt = new DataTable();
		String sqlQuery;
		MySqlDataAdapter DtA = new MySqlDataAdapter();
		MySqlDataReader sqlRd;
		DataSet DS = new DataSet();
		public Items()
		{
			InitializeComponent();
		}

		private void loadItems() {
			sqlConn.ConnectionString = "server=localhost;user id=root;password=64959441;database=ITP4915";

			sqlConn.Open();
			sqlCmd.Connection = sqlConn;
			sqlCmd.CommandText = "SELECT * FROM ITP4915.item";

			sqlRd = sqlCmd.ExecuteReader();
			sqlDt.Load(sqlRd);
			sqlRd.Close();
			sqlConn.Close();
			dataGridView1.DataSource = sqlDt;
		}

		private void Items_Load(object sender, EventArgs e)
		{
			loadItems();
		}

		private void buttonEdit_Click(object sender, EventArgs e)
		{
			buttonUpdate.Visible = true;
			textBoxID.Enabled = false;
			textBoxName.Enabled = true;
			textBoxSID.Enabled = false;
			textBoxDetail.Enabled = true;
			textBoxPrice.Enabled = true;
			textBoxReorderLv.Enabled = true;
			textBoxReorderAmount.Enabled = true;
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			buttonEnter.Visible = true;	
			textBoxID.Enabled = true;
			textBoxName.Enabled = true;
			textBoxSID.Enabled = true;
			textBoxDetail.Enabled = true;
			textBoxPrice.Enabled = true;

	
			textBoxID.Text = null;
			textBoxName.Text = null;
			textBoxSID.Text = null;
			textBoxDetail.Text = null;
			textBoxPrice.Text = null;

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
			sqlCmd.CommandText = "UPDATE ITP4915.item SET itemName = @itemName, detail=@detail	,price =@price ,reorderLv=@reorderLv,reorderAmount=@reorderAmount WHERE itemID = @itemID";


			sqlCmd.CommandType = CommandType.Text;
			sqlCmd.Parameters.AddWithValue("@itemID", textBoxID.Text);
			sqlCmd.Parameters.AddWithValue("@itemName", textBoxName.Text);
			sqlCmd.Parameters.AddWithValue("@detail", textBoxDetail.Text);
			sqlCmd.Parameters.AddWithValue("@price", textBoxPrice.Text);
			sqlCmd.Parameters.AddWithValue("@reorderLv", textBoxReorderLv.Text);
			sqlCmd.Parameters.AddWithValue("@reorderAmount", textBoxReorderAmount.Text);
			try
			{
				sqlCmd.ExecuteNonQuery();
				sqlConn.Close();
				loadItems();
				buttonUpdate.Visible = false;

				textBoxID.Enabled = false;
				textBoxName.Enabled = false;
				textBoxSID.Enabled = false;
				textBoxDetail.Enabled = false;
				textBoxPrice.Enabled = false;
				textBoxReorderLv.Enabled = false;
				textBoxReorderAmount.Enabled = false;
				MessageBox.Show("Data Updated!");
			}

			catch (Exception ex)
			{
				MessageBox.Show("input the data again!");
			}

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			DataView dv = new DataView(sqlDt);
			dv.RowFilter = string.Format("convert(itemName ,'System.String') LIKE '%{0}%'", textBoxSearch.Text);
			dataGridView1.DataSource = dv;
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			textBoxID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
			textBoxName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
			textBoxDetail.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
			textBoxSID.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
			textBoxPrice.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
			textBoxReorderLv.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
			textBoxReorderAmount.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
		}

		private void buttonEnter_Click(object sender, EventArgs e)
		{
			sqlConn.Open();
			sqlQuery = "insert into ITP4915.item (itemID,itemName,detail,supplierID,price)" +
				 "value('" + textBoxID.Text + "'," + "'" + textBoxName.Text + "','" + textBoxDetail.Text + "','" + textBoxSID.Text + "'" + ", " + textBoxPrice.Text  + ")";
			sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
			sqlRd = sqlCmd.ExecuteReader();

			sqlConn.Close();

			buttonEnter.Visible = false;
			MessageBox.Show("Data created!");
			textBoxID.Text = null;
			textBoxName.Text = null;
			textBoxSID.Text = null;
			textBoxDetail.Text = null;
			textBoxPrice.Text = null;
			textBoxReorderLv.Text = null;
			textBoxReorderAmount.Text = null;
		}

		private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
		{
			textBoxID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
			textBoxName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
			textBoxDetail.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
			textBoxSID.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
			textBoxPrice.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
			textBoxReorderLv.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
			textBoxReorderAmount.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
		}

		private void buttonDelete_Click(object sender, EventArgs e)
		{

		}

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
			sqlConn.Open();
			sqlQuery = "insert into ITP4915.item (itemID,itemName,detail,supplierID,price)" +
				 "value('" + textBoxID.Text + "'," + "'" + textBoxName.Text + "','" + textBoxDetail.Text + "','" + textBoxSID.Text + "'" + ", " + textBoxPrice.Text + ")";
			sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
			sqlRd = sqlCmd.ExecuteReader();

			sqlConn.Close();

			buttonEnter.Visible = false;
			MessageBox.Show("Data created!");
			textBoxID.Text = null;
			textBoxName.Text = null;
			textBoxSID.Text = null;
			textBoxDetail.Text = null;
			textBoxPrice.Text = null;
			textBoxReorderLv.Text = null;
			textBoxReorderAmount.Text = null;
		}

        private void guna2CircleButton1_Click_1(object sender, EventArgs e)
        {
			if (sqlConn.State == ConnectionState.Open)
			{
				sqlConn.Close();
			}

			sqlConn.ConnectionString = "server=localhost;user id=root;password=64959441;database=ITP4915";
			sqlConn.Open();

			MySqlCommand sqlCmd = new MySqlCommand();
			sqlCmd.Connection = sqlConn;
			sqlCmd.CommandText = "UPDATE ITP4915.item SET itemName = @itemName, detail=@detail	,price =@price ,reorderLv=@reorderLv,reorderAmount=@reorderAmount WHERE itemID = @itemID";


			sqlCmd.CommandType = CommandType.Text;
			sqlCmd.Parameters.AddWithValue("@itemID", textBoxID.Text);
			sqlCmd.Parameters.AddWithValue("@itemName", textBoxName.Text);
			sqlCmd.Parameters.AddWithValue("@detail", textBoxDetail.Text);
			sqlCmd.Parameters.AddWithValue("@price", textBoxPrice.Text);
			sqlCmd.Parameters.AddWithValue("@reorderLv", textBoxReorderLv.Text);
			sqlCmd.Parameters.AddWithValue("@reorderAmount", textBoxReorderAmount.Text);
			try
			{
				sqlCmd.ExecuteNonQuery();
				sqlConn.Close();
				loadItems();
				buttonUpdate.Visible = false;

				textBoxID.Enabled = false;
				textBoxName.Enabled = false;
				textBoxSID.Enabled = false;
				textBoxDetail.Enabled = false;
				textBoxPrice.Enabled = false;
				textBoxReorderLv.Enabled = false;
				textBoxReorderAmount.Enabled = false;
				MessageBox.Show("Data Updated!");
			}

			catch (Exception E)
			{
				MessageBox.Show("input the data again!");
			}
        }
    }
}
