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
	public partial class replenishment : Form
	{
		MySqlConnection sqlConn = new MySqlConnection();
		MySqlCommand sqlCmd = new MySqlCommand();
		DataTable sqlDt = new DataTable();

		MySqlDataAdapter DtA = new MySqlDataAdapter();
		MySqlDataReader sqlRd;
		DataSet DS = new DataSet();
		string sqlQuery;
		int RID;

		public replenishment()
		{
			InitializeComponent();
		}



		public class ID { 
		public static string storeID;
		public static string EmpID;

		}

		private void replenishment_Load(object sender, EventArgs e)
		{
			sqlCmd.Parameters.Clear();
			sqlConn.ConnectionString = "server=localhost;user id=root;password=64959441;database=ITP4915";

			sqlConn.Open();
			sqlCmd.Connection = sqlConn;
			sqlCmd.CommandText = "SELECT instoreItem.storeID,Item.itemID,instoreItem.qty,Item.reorderAmount FROM ITP4915.instoreItem,Item WHERE instoreItem.itemID=Item.itemID AND  instoreItem.requested ='N' AND instoreItem.qty < Item.reorderLv AND storeID =@storeID";
			sqlCmd.CommandType = CommandType.Text;
			sqlCmd.Parameters.AddWithValue("@storeID", ID.storeID);
			sqlRd = sqlCmd.ExecuteReader();
			sqlDt.Load(sqlRd);
			dataGridView1.DataSource = sqlDt;
			sqlRd.Close();
			sqlConn.Close();

			label3.Text = "employee ID:" + ID.EmpID;

		}

		private void button2_Click(object sender, EventArgs e)
		{
			sqlConn.Open();
			sqlQuery = "INSERT INTO replenishmentOrder VALUES(NULL,now(),'" + ID.EmpID + "','" + ID.storeID + "' , default )";
			sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
			sqlRd = sqlCmd.ExecuteReader();
			sqlConn.Close();


			if (sqlConn.State == ConnectionState.Open)
			{
				sqlConn.Close();
			}

			sqlConn.Open();
			sqlQuery = "Select MAX(RorderID) FROM replenishmentOrder; ";
			sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
			int RorderId = (int)sqlCmd.ExecuteScalar();
			sqlConn.Close();

			sqlConn.Open();
			sqlQuery = "INSERT INTO Delivery VALUES(NULL,now(),null,null,null," + RorderId + ",'In Warehouse"+"' )";
			sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
			sqlRd = sqlCmd.ExecuteReader();
			sqlConn.Close();





			for (int i = 0; i < dataGridView1.Rows.Count - 1; i++) { 
			
				
					sqlConn.Open();
					sqlQuery = "Select MAX(RorderID) FROM replenishmentOrder; ";
					sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
					int orderId = (int)sqlCmd.ExecuteScalar();
					sqlConn.Close();


				


					sqlConn.Open();
					sqlQuery = "INSERT INTO RorderItem VALUES('" +orderId+"',"+" '"+dataGridView1.Rows[i].Cells[1].Value+"', "+ dataGridView1.Rows[i].Cells[3].Value+" )";
					sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
					sqlRd = sqlCmd.ExecuteReader();					
					sqlConn.Close();


				

			}

			for (int i = 0; i < dataGridView1.Rows.Count - 1; i++ ) {
				sqlConn.Open();
				sqlQuery = "UPDATE instoreItem SET requested ='Y' " + "WHERE itemID= '" + dataGridView1.Rows[i].Cells[1].Value + "'" + " AND instoreItem.storeID ='" + ID.storeID + "'";
				sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
				sqlCmd.ExecuteNonQuery();
				sqlConn.Close();
			}

			MessageBox.Show("Order Created!");
			Form1.bell.Bell = false;
			Close();

			
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int x = dataGridView1.CurrentCell.RowIndex;
			dataGridView1.Rows.RemoveAt(x);
		}
	}
}
