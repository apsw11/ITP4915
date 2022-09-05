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
	public partial class ReorderRequest : Form
	{
		MySqlConnection sqlConn = new MySqlConnection();
		MySqlCommand sqlCmd = new MySqlCommand();
		DataTable sqlDt = new DataTable();

		MySqlDataAdapter DtA = new MySqlDataAdapter();
		MySqlDataReader sqlRd;
		DataSet DS = new DataSet();
		string search;
		int qty;
		string sqlQuery;

		public class ID
		{
			public static string EmpID;

		}
		public ReorderRequest()
		{
			InitializeComponent();
		}

		private void ReorderRequest_Load(object sender, EventArgs e)
		{

			DataTable dt = new DataTable();
			string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;



			using (MySqlConnection con = new MySqlConnection(connString))
			{

				using (MySqlCommand cmd = new MySqlCommand("SELECT warehouseitem.itemID, item.itemName , item.reorderLv , item.reorderAmount , warehouseitem.qty AS 'Inventory quantity' FROM warehouseitem, item WHERE warehouseitem.itemID = item.itemID" + search, con))
				{
					con.Open();

					MySqlDataReader reader = cmd.ExecuteReader();

					dt.Load(reader);



				}
			}

			DataGridViewCheckBoxColumn chkbox = new DataGridViewCheckBoxColumn();
			chkbox.HeaderText = "Select";
			chkbox.Width = 25;
			chkbox.Name = "DGVchkBox";
			
			dataGridView1.Columns.Insert(0, chkbox);

			dataGridView1.DataSource = dt;
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			DataTable dt = new DataTable();
			dt.Columns.Add("Item :");
			dt.Columns.Add("Item Name:");
			dt.Columns.Add("Reorder amount");
			foreach (DataGridViewRow dr in dataGridView1.Rows) {
				bool chkboxselect = Convert.ToBoolean(dr.Cells["DGVchkBox"].Value);
			

				if (chkboxselect) { 
				dt.Rows.Add(dr.Cells[1].Value,dr.Cells[2].Value,dr.Cells[4].Value);
				}

				dataGridView2.DataSource = dt;
			}

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{
		
		}

		private void button2_Click(object sender, EventArgs e)
		{
		
		}

		private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}

		private void button3_Click(object sender, EventArgs e)
		{
			sqlConn.ConnectionString = "server=localhost;user id=root;password=64959441;database=ITP4915";

			if (sqlConn.State == ConnectionState.Open)
			{
				sqlConn.Close();
			}

			sqlConn.Open();
			sqlQuery = "INSERT INTO  ReorderRequest VALUES(NULL,'" + ID.EmpID + "',now(),DEFAULT,NULL,NULL )";
			sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
			sqlRd = sqlCmd.ExecuteReader();
			sqlConn.Close();

			if (sqlConn.State == ConnectionState.Open)
			{
				sqlConn.Close();
			}

			for (int i = 0; i < dataGridView2.Rows.Count ; i++)
			{


				sqlConn.Open();
				sqlQuery = "Select MAX(RequestID) FROM ReorderRequest; ";
				sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
				int orderId = (int)sqlCmd.ExecuteScalar();
				sqlConn.Close();

			

				sqlConn.Open();
				sqlQuery = "INSERT INTO ReorderRequestItem VALUES( " + orderId + "," + " '" + dataGridView2.Rows[i].Cells[0].Value + "', " + dataGridView2.Rows[i].Cells[2].Value + " ) ;";
				sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
				sqlRd = sqlCmd.ExecuteReader();
				sqlConn.Close();


				

			}
			MessageBox.Show("Order Created!");


		}
	}
}
