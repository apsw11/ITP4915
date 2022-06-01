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

		string storeID;
		string empID;
		public replenishment()
		{
			InitializeComponent();
		}

		private string getEmpID()
		{
			return empID;
		}

		internal void setEmpID(string v)
		{
			empID = v;
		}

		internal void setstoreID(string v)
		{
			storeID = v;
		}

		private string getstoreID()
		{
			return storeID;
		}

		private void replenishment_Load(object sender, EventArgs e)
		{
			sqlCmd.Parameters.Clear();
			sqlConn.ConnectionString = "server=localhost;user id=root;password=64959441;database=ITP4915";

			sqlConn.Open();
			sqlCmd.Connection = sqlConn;
			sqlCmd.CommandText = "SELECT * FROM ITP4915.instoreItem WHERE qty < 10 AND storeID = @storeID";
			sqlCmd.CommandType = CommandType.Text;
			sqlCmd.Parameters.AddWithValue("@storeID", getstoreID());
			sqlRd = sqlCmd.ExecuteReader();
			sqlDt.Load(sqlRd);
			dataGridView1.DataSource = sqlDt;
			sqlRd.Close();
			sqlConn.Close();

			label3.Text = "employee ID:" + getEmpID();

		}
	}
}
