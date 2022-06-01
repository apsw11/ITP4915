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
	public partial class Login : Form
	{

		MySqlConnection sqlConn = new MySqlConnection();
		MySqlCommand sqlCmd = new MySqlCommand();
		DataTable sqlDt = new DataTable();
		
		MySqlDataAdapter DtA = new MySqlDataAdapter();
		MySqlDataReader sqlRd;
		DataSet DS = new DataSet();
		public Login()
		{
			InitializeComponent();
		}

	

		private void Login_Load(object sender, EventArgs e)
		{

		}

		private void buttonLogin_Click(object sender, EventArgs e)
		{

			if (sqlConn.State == ConnectionState.Open)
			{
				sqlConn.Close();
			}


			sqlCmd.Parameters.Clear();

			if (string.IsNullOrWhiteSpace(textEmpID.Text) || string.IsNullOrWhiteSpace(textBoxPS.Text)) {
				MessageBox.Show("YOU MUST INPUT THE EMPLOYEE ID AND PASSWORD TO LOGIN!");
			}
			sqlConn.ConnectionString = "server=localhost;user id=root;password=64959441;database=ITP4915";

			sqlConn.Open();
			sqlCmd.Connection = sqlConn;
			sqlCmd.CommandText = "SELECT * FROM ITP4915.emp WHERE emp_id = @empID";
			sqlCmd.CommandType = CommandType.Text;
			sqlCmd.Parameters.AddWithValue("@empID", textEmpID.Text);
			sqlRd = sqlCmd.ExecuteReader();

			if (sqlRd.Read()) {
				string empid = (sqlRd["emp_id"].ToString());
				string password = (sqlRd["password"].ToString());
				string position = (sqlRd["position"].ToString());
				string storeID = (sqlRd["storeID"].ToString());
				
				if (empid == textEmpID.Text && password == textBoxPS.Text) {
					MessageBox.Show("Login Success!");

					Form1 F1 = new Form1();
					profile P1 = new profile();
					F1.setEmpID(empid);
					F1.setPosition(position);
					F1.setstoreID(storeID);
					DialogResult result = F1.ShowDialog();
					Close();

				}

				
			}
			else if (!sqlRd.Read()) {
				MessageBox.Show("Employee ID or Password Wrong");
			}
			

			
		}
	}
}
