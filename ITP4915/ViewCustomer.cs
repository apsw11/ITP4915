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
using MySql.Data;
using System.Runtime;


namespace ITP4915
{
    public partial class ViewCustomer : Form
    {

        MySqlConnection sqlConn = new MySqlConnection();
        MySqlCommand sqlCmd = new MySqlCommand();
        DataTable sqlDt = new DataTable();
        String sqlQuery;
        MySqlDataAdapter DtA = new MySqlDataAdapter();
        MySqlDataReader sqlRd;
        DataSet DS = new DataSet();
        string search,customerID;


        public String customerName,customerId,PhoneNum;


        public ViewCustomer()
        {
            InitializeComponent();
           
        }
       
       
        private DataTable upLoadData()
        {
            
            DataTable dtEmployees = new DataTable();

            string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;

            using (MySqlConnection con = new MySqlConnection(connString))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM customer" + search , con))
                {
                    con.Open();

                    MySqlDataReader reader = cmd.ExecuteReader();

                    dtEmployees.Load(reader);
                }
            }

            return dtEmployees;

        }
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewCustomer_Load(object sender, EventArgs e)
        {
            

            dataGridView1.DataSource = upLoadData();
            button2.Visible = false;
            button3.Visible = false;
            if (CreateOrder.Customer.ccheck == 1)
            {
                button2.Visible = true;
                button3.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = upLoadData();
            customerID = dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[0].Value.ToString();
            customerID = customerID.Substring(2);
            int acustomerID = Int32.Parse(customerID) + 1;
            customerID = acustomerID.ToString();
            customerID = "CA" + customerID.PadLeft(4, '0');




            if (!string.IsNullOrWhiteSpace(textBox2.Text))
            {
                if (!string.IsNullOrWhiteSpace(maskedTextBox1.Text))
                {


                    if (!string.IsNullOrWhiteSpace(richTextBox1.Text))
                    {

                        // upLoadDat
                        sqlConn.ConnectionString = "server=localhost;user id=root;password=64959441;database=ITP4915";

                        try
                        {
                            sqlConn.Open();
                            sqlQuery = "insert into ITP4915.customer (customerID,customerName,address,PhoneNum)" +
                             "value('" + customerID + "','" + textBox2.Text + "','" + richTextBox1.Text + "','" + maskedTextBox1.Text + "')";


                            sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
                            sqlRd = sqlCmd.ExecuteReader();



                            sqlConn.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            sqlConn.Close();
                        }
                        dataGridView1.DataSource = upLoadData();
                    }
                    else MessageBox.Show("Please type address!");
                }
                else MessageBox.Show("Please type phoneNumber!");
            }
            else MessageBox.Show("Please type name!");
        }

        private void rjTextBox1__TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            customerName = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            customerId = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            PhoneNum = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            search = null;
            search = " where (customerID like '%" + textBox4.Text + "%' ";
            search += "or customerName like '%" + textBox4.Text + "%' ";
            search += "or address like '%" + textBox4.Text + "%' ";
            search += "or PhoneNum like '%" + textBox4.Text + "%')";


            dataGridView1.DataSource = upLoadData();


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            CreateOrder.Customer.customerId = customerId;
            CreateOrder.Customer.customerName = customerName;
            CreateOrder.Customer.phoneNum = PhoneNum;
            CreateOrder.Customer.ccheck = 0;
            CreateOrder c = new CreateOrder();

            c.updataCustomer();

            this.Close();
        }
    }
}
