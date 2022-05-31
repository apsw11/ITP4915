using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace ITP4915
{
    public partial class CreateOrder : Form
    {
        MySqlConnection sqlConn = new MySqlConnection();
        MySqlCommand sqlCmd = new MySqlCommand();
        DataTable sqlDt = new DataTable();

        MySqlDataAdapter DtA = new MySqlDataAdapter();
        MySqlDataReader sqlRd;
        DataSet DS = new DataSet();

        public string price;
        public string Itemname;
        Form1 f1 = new Form1(); 
        String sqlQuery;
        public CreateOrder()
        {
            InitializeComponent();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ViewCustomer vc = new ViewCustomer();
            vc.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetInstoreItem();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CreateOrder_Load(object sender, EventArgs e)
        {
            rjTextBox2.Text = Convert.ToString(f1.getEmpID());
            textBox3.Text = Customer.customerId;
            textBox4.Text = Customer.customerName;
            textBox5.Text = Customer.phoneNum;

        }
        private DataTable GetWarehouseItem()
        {
            DataTable dtEmployees = new DataTable();

            string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;

            using (MySqlConnection con = new MySqlConnection(connString))
            {

                using (MySqlCommand cmd = new MySqlCommand("Select w.warehouseID,i.itemID,i.itemName,i.detail,i.price,w.qty FROM warehouseItem as w,Item as i Where i.itemID = w.itemID", con))
                {
                    con.Open();

                    MySqlDataReader reader = cmd.ExecuteReader();

                    dtEmployees.Load(reader);
                    string itemId = (reader["itemID"].ToString());
                    textBox6.Text = itemId;

                }
            }
            return dtEmployees;
        }
        private DataTable GetInstoreItem()
        {
            DataTable dtEmployees = new DataTable();

            string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;

            using (MySqlConnection con = new MySqlConnection(connString))
            {
                using (MySqlCommand cmd = new MySqlCommand("Select s.instoreID,i.itemID,i.itemName,i.detail,i.price,s.qty FROM instoreItem as s,Item as i Where i.itemID = s.itemID", con))
                {
                    con.Open();

                    MySqlDataReader reader = cmd.ExecuteReader();

                    dtEmployees.Load(reader);
                }
            }
            return dtEmployees;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetWarehouseItem();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //
        /*
        private void textBoxSerach_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(sqlDt);
            dv.RowFilter = string.Format("convert(orderID,'System.String') LIKE '%{0}%'", textBoxSerach.Text);
            dataGridView1.DataSource = dv;
        }
        */
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

            
            ItemModel model = new ItemModel
            {
                Wsid  =  textBox2.Text,
                ItemId = textBox1.Text,
                ItemName = Itemname,
                Quantity = 1,
                Price = Convert.ToDecimal(price)
            };
            SharedData.Items.Add(model);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = SharedData.Items;
            
        }

        private void button6_Click(object sender, EventArgs e)
        {

            sqlConn.ConnectionString = "server=localhost;user id=root;password=64959441;database=ITP4915";

            try
            {
                sqlConn.Open();
                //
                sqlQuery = "insert into ITP4915.customer (customerID,customerName,a ddress,PhoneNum)" +
                 "value('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox4.Text + "','" + textBox3.Text + "')";


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
            upLoadData();
        }

        private void upLoadData()
        {
            sqlConn.ConnectionString = "server=localhost;user id=root;password=64959441;database=ITP4915";

            sqlConn.Open();
            sqlCmd.Connection = sqlConn;
            sqlCmd.CommandText = "SELECT * FROM ITP4915.customer";

            sqlRd = sqlCmd.ExecuteReader();
            sqlDt.Load(sqlRd);
            sqlRd.Close();
            sqlConn.Close();
           // guna2DataGridView1.DataSource = sqlDt;
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell != null && dataGridView1.CurrentCell.Value != null) { 
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            price = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            Itemname= dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            
        }
        public void updataCustomer()
        {
            textBox3.Text = Customer.customerId;
            textBox4.Text = Customer.customerName;
            textBox5.Text = Customer.phoneNum;
        }
        public class Customer
        {

            public static string customerId;
            public static string customerName;
            public static string phoneNum;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }
    }
}
