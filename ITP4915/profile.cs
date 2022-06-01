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
	public partial class profile : Form
	{

		MySqlConnection sqlConn = new MySqlConnection();
		MySqlCommand sqlCmd = new MySqlCommand();
		DataTable sqlDt = new DataTable();

		MySqlDataAdapter DtA = new MySqlDataAdapter();
		MySqlDataReader sqlRd;
		DataSet DS = new DataSet();

		string empID;
		public profile()
		{
			InitializeComponent();
		}

		private void profile_Load(object sender, EventArgs e)
		{
			if (sqlConn.State == ConnectionState.Open)
			{
				sqlConn.Close();
			}

			sqlCmd.Parameters.Clear();
			sqlConn.ConnectionString = "server=localhost;user id=root;password=64959441;database=ITP4915";
			sqlConn.Open();
			sqlCmd.Connection = sqlConn;
			sqlCmd.CommandText = "SELECT emp_id, emp_name, position FROM ITP4915.emp WHERE emp_id = @empID";
			sqlCmd.CommandType = CommandType.Text;
			sqlCmd.Parameters.AddWithValue("@empID", getEmpID());
			sqlRd = sqlCmd.ExecuteReader();


			if (sqlRd.Read())
			{
				labelEmpName.Text ="Name: " +(sqlRd["emp_id"].ToString());
				labelEmpID.Text ="Employee ID: " +(sqlRd["emp_name"].ToString());
				labelPosition.Text ="Position: "+ (sqlRd["position"].ToString());


			}

		}




		private string getEmpID()
		{
			return empID;
		}

		internal void setEmpID(string v)
		{
			empID = v;
		}


		private void label1_Click(object sender, EventArgs e)
		{

		}
	}
}
