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
    public partial class Forget_Password : Form
    {

        MySqlConnection sqlConn = new MySqlConnection();
        MySqlCommand sqlCmd = new MySqlCommand();
        DataTable sqlDt = new DataTable();

        MySqlDataAdapter DtA = new MySqlDataAdapter();
        MySqlDataReader sqlRd;
        DataSet DS = new DataSet();


        public String customerName, customerId, PhoneNum;



        public Forget_Password()
        {
            InitializeComponent();
        }

        private void Forget_Password_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("YOU MUST INPUT ALL TEXT!");
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
                sqlCmd.CommandText = "SELECT * FROM ITP4915.emp WHERE hkID = @hkID";
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("@hkID", textBox2.Text);
                sqlRd = sqlCmd.ExecuteReader();

                if (sqlRd.Read())
                {
                    string empid = (sqlRd["emp_id"].ToString());
                    string password = (sqlRd["password"].ToString());
                    string hkID = (sqlRd["hkID"].ToString());
                    string position = (sqlRd["position"].ToString());
                    string storeID = (sqlRd["storeID"].ToString());
                    string department = (sqlRd["department"].ToString());

                    if (hkID == textBox2.Text && empid == textBox1.Text)
                    {
                        MessageBox.Show(" Your Password is " + password);
                        sqlConn.Close();
                    }
                    else
                    {
                        MessageBox.Show("Wrong StaffID or HKID");
                        sqlConn.Close();
                    }
                }
                else if (!sqlRd.Read())
                {
                    MessageBox.Show("Wrong StaffID or HKID");
                }

            }

        }


        private void Forget_Load(object sender, EventArgs e)
        {
        }
    }
}



