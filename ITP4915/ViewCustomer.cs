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

        public String customerName,customerId,PhoneNum;


        public ViewCustomer()
        {
            InitializeComponent();
           
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
            guna2DataGridView1.DataSource = sqlDt;
        }
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewCustomer_Load(object sender, EventArgs e)
        {
            upLoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1 != null && textBox2 != null && textBox3 != null)
            {
                if (richTextBox1 != null)
                {

                    // upLoadDat
                    sqlConn.ConnectionString = "server=localhost;user id=root;password=64959441;database=ITP4915";

                    try
                    {
                        sqlConn.Open();
                        sqlQuery = "insert into ITP4915.customer (customerID,customerName,address,PhoneNum)" +
                         "value('" + textBox1.Text + "','" + textBox2.Text +"','" + richTextBox1.Text +"','" + textBox3.Text + "')";


                        sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
                        sqlRd = sqlCmd.ExecuteReader();
                        


                        sqlConn.Close();
                    }
                    catch(Exception ex) { 
                    MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        sqlConn.Close();
                    }
                    upLoadData();
                }
            }
        }

        private void rjTextBox1__TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            customerName = guna2DataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            customerId = guna2DataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            PhoneNum = guna2DataGridView1.SelectedRows[0].Cells[3].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            CreateOrder.Customer.customerId = customerId;
            CreateOrder.Customer.customerName = customerName;
            CreateOrder.Customer.phoneNum = PhoneNum;
            CreateOrder c = new CreateOrder();
            c.updataCustomer();
            this.Close();
        }
    }
}
