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
			if (string.IsNullOrWhiteSpace(textEmpID.Text) || string.IsNullOrWhiteSpace(textBoxPS.Text))
			{
				MessageBox.Show("YOU MUST INPUT THE EMPLOYEE ID AND PASSWORD TO LOGIN!");
			}
			else
			{

				if (sqlConn.State == ConnectionState.Open)
				{
					sqlConn.Close();
				}


				sqlCmd.Parameters.Clear();


				sqlConn.ConnectionString = "server=localhost;user id=root;password=64959441;database=ITP4915";

				sqlConn.Open();
				sqlCmd.Connection = sqlConn;
				sqlCmd.CommandText = "SELECT * FROM ITP4915.emp WHERE emp_id = @empID";
				sqlCmd.CommandType = CommandType.Text;
				sqlCmd.Parameters.AddWithValue("@empID", textEmpID.Text);
				sqlRd = sqlCmd.ExecuteReader();

				if (sqlRd.Read())
				{
					string empid = (sqlRd["emp_id"].ToString());
					string password = (sqlRd["password"].ToString());
					string position = (sqlRd["position"].ToString());
					string storeID = (sqlRd["storeID"].ToString());
					string department = (sqlRd["department"].ToString());

					if (empid == textEmpID.Text && password == textBoxPS.Text)
					{
						MessageBox.Show("Login Success!");

						if (department == "S")
						{
							Form1 F1 = new Form1();
							profile P1 = new profile();

							F1.setEmpID(empid);
							CreateOrder.getID.empID = empid;
							CreateOrder.getID.storeID = storeID;
							F1.setPosition(position);
							F1.setstoreID(storeID);
							DialogResult result = F1.ShowDialog();
						}

						else if (department == "I")
						{

							Inventory IN = new Inventory();
							profile P1 = new profile();

							IN.setEmpID(empid);
							IN.setPosition(position);
							IN.setstoreID(storeID);
							IN.setDepartment(department);
							DialogResult result = IN.ShowDialog();
						}

						else if (department == "T")
						{

							TechnicalSupport TS = new TechnicalSupport();
							profile P1 = new profile();

							TS.setEmpID(empid);
							TS.setPosition(position);
							TS.setstoreID(storeID);
							DialogResult result = TS.ShowDialog();
						}

						else if (department == "P")
						{
							PurchaseMain PM = new PurchaseMain();
							profile P1 = new profile();
							PM.setEmpID(empid);
							PM.setPosition(position);
							PM.setstoreID(storeID);
							PM.setDepartment(department);
							DialogResult result = PM.ShowDialog();
						}

						else if (department == "A") { 
						AccountingMain AC = new AccountingMain();
							profile P1 = new profile();
							AC.setEmpID(empid);
							AC.setPosition(position);
							AC.setstoreID(storeID);
							AC.setDepartment(department);
							DialogResult result = AC.ShowDialog();
						}

						Close();

					}

					else
					{
						MessageBox.Show("Employee ID or Password Wrong");
					}

				}


				else if (!sqlRd.Read())
				{
					MessageBox.Show("Employee ID or Password Wrong");
				}

			}
		}

        private void closebutton_Click(object sender, EventArgs e)
        {
			this.Close();
        }

        private void labelPassword_Click(object sender, EventArgs e)
        {

        }

        private void checkBox_Show_Hide_Password_CheckedChanged(object sender, EventArgs e)
        {
			if (checkBox_Show_Hide_Password.Checked)
			{
				textBoxPS.UseSystemPasswordChar = false;

			}
			else
			{
				textBoxPS.UseSystemPasswordChar = true;
			}
		}

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labpwdshow_Click(object sender, EventArgs e)
        {
			Forget_Password a = new Forget_Password();
			a.Show();
		}
    }
}
