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
using System.Data.SqlClient;

namespace ITP4915
{




    public partial class Staff : Form
    {

        string sdepartment = "";
        string sPosition = "";
        string sstoreID = "";

        MySqlConnection sqlConn = new MySqlConnection();
        MySqlCommand sqlCmd = new MySqlCommand();
        DataTable sqlDt = new DataTable();
        String sqlQuery;
        MySqlDataAdapter DtA = new MySqlDataAdapter();
        MySqlDataReader sqlRd;
        DataSet DS = new DataSet();
        string search, emp_ID;


        public String emp_name, emp_id, hkID, password, position, storeID, department, Sposition;



        public Staff()
        {
            InitializeComponent();


        }




        private void Staff_Load(object sender, EventArgs e)
        {

            sqlCmd = new MySqlCommand();
            sqlConn.ConnectionString = "server=localhost;user id=root;password=64959441;database=ITP4915";
            sqlConn.Open();
            sqlCmd.Connection = sqlConn;
            sqlCmd.CommandText = "SELECT storeID FROM emp GROUP BY storeID";
            sqlRd = sqlCmd.ExecuteReader();
            while (sqlRd.Read())
            {
                StoreID_combox.Items.Add(sqlRd["storeID"]);
   
            }
            sqlConn.Close();


            sqlCmd = new MySqlCommand();
            sqlConn.ConnectionString = "server=localhost;user id=root;password=64959441;database=ITP4915";
            sqlConn.Open();
            sqlCmd.Connection = sqlConn;
            sqlCmd.CommandText = "SELECT department FROM emp GROUP BY department";
            sqlRd = sqlCmd.ExecuteReader();
            while (sqlRd.Read())
            {
                Deparment_combox.Items.Add(sqlRd["department"]);
            }
            sqlConn.Close();

            sqlCmd = new MySqlCommand();
            sqlConn.ConnectionString = "server=localhost;user id=root;password=64959441;database=ITP4915";
            sqlConn.Open();
            sqlCmd.Connection = sqlConn;
            sqlCmd.CommandText = "SELECT position FROM emp GROUP BY position";
            sqlRd = sqlCmd.ExecuteReader();
            while (sqlRd.Read())
            {
                Postion_combox.Items.Add(sqlRd["position"]);
       
            }
            sqlConn.Close();

            dataGridView1.DataSource = upLoadData();
            button2.Visible = false;
            button3.Visible = false;
            if (CreateOrder.Customer.ccheck == 1)
            {
                button2.Visible = true;
                button3.Visible = true;
            }



        }

        private DataTable upLoadData()
        {

            DataTable dtEmployees = new DataTable();

            string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;

            using (MySqlConnection con = new MySqlConnection(connString))
            {
                using (MySqlCommand cmd = new MySqlCommand("Select * from emp where emp_id like '%" + sdepartment + position + storeID + "%';", con))
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






        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = upLoadData();

            int sp = 0;

            if (Postion_combox.Text == "Manager")
            {
                sp = 1;
            }
            else
            {
                sp = 0;
            }








            dataGridView1.DataSource = upLoadData();
            emp_id = dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Value.ToString();

            emp_id = emp_id.Substring(2);
            int acustomerID = Int32.Parse(emp_id) + 1;
            emp_id = acustomerID.ToString();
            emp_id = Deparment_combox.Text + sp + emp_id.PadLeft(4, '0');
 



            if (!string.IsNullOrWhiteSpace(StaffName_txt.Text))
            {
                if (!string.IsNullOrWhiteSpace(Passsword_txt.Text))
                {
                    if (!string.IsNullOrWhiteSpace(Postion_combox.Text))
                    {
                        if (!string.IsNullOrWhiteSpace(HKID_txt.Text))
                        {

                            // upLoadDat
                            sqlConn.ConnectionString = "server=localhost;user id=root;password=64959441;database=ITP4915";

                            try
                            {
                                sqlConn.Open();
                                sqlQuery = "insert into ITP4915.emp (emp_id,emp_name,hkID,password,position,storeID,department)" +
                                 "value('" + emp_id + "','" + StaffName_txt.Text + "','" + HKID_txt.Text + "','" + Passsword_txt.Text + "','" + Postion_combox.Text + "','" + StoreID_combox.Text + "','" + Deparment_combox.Text + "')";


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
                        else MessageBox.Show("Please type HKID!");
                    }
                    else MessageBox.Show("Please type the Position!");
                }
                else MessageBox.Show("Please type Password!");
            }
            else MessageBox.Show("Please type name!");
        }

        private void rjTextBox1__TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void StoreID_combox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = upLoadData();

            int sp = 0;

            if (Postion_combox.Text == "Manager")
            {
                sp = 1;
            }
            else
            {
                sp = 0;
            }








            dataGridView1.DataSource = upLoadData();
            if(dataGridView1.Rows.Count != 0) { 
            emp_id = dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Value.ToString();
         
            
            emp_id = emp_id.Substring(2);
            int acustomerID = Int32.Parse(emp_id) + 1;
            emp_id = acustomerID.ToString();
            emp_id = Deparment_combox.Text + sp + emp_id.PadLeft(4, '0');

            }
            else{
                emp_id = Deparment_combox.Text + sp + "0001";
            }


            if (!string.IsNullOrWhiteSpace(StaffName_txt.Text))
            {
                if (!string.IsNullOrWhiteSpace(Passsword_txt.Text))
                {
                    if (!string.IsNullOrWhiteSpace(Postion_combox.Text))
                    {
                        if (!string.IsNullOrWhiteSpace(HKID_txt.Text))
                        {

                            // upLoadDat
                            sqlConn.ConnectionString = "server=localhost;user id=root;password=64959441;database=ITP4915";

                            try
                            {
                                sqlConn.Open();
                                sqlQuery = "insert into ITP4915.emp (emp_id,emp_name,hkID,password,position,storeID,department)" +
                                 "value('" + emp_id + "','" + StaffName_txt.Text + "','" + HKID_txt.Text + "','" + Passsword_txt.Text + "','" + Postion_combox.Text + "','" + StoreID_combox.Text + "','" + Deparment_combox.Text + "')";


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
                        else MessageBox.Show("Please type HKID!");
                    }
                    else MessageBox.Show("Please type the Position!");
                }
                else MessageBox.Show("Please type Password!");
            }
            else MessageBox.Show("Please type name!");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            CreateOrder.Customer.ccheck = 0;
            CreateOrder c = new CreateOrder();

            c.updataCustomer();

            this.Close();
        }

        private void StaffName_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click_2(object sender, EventArgs e)
        {

        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
        
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void dataGridView1_CellClick_2(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
             
                if (dataGridView1.SelectedRows[0].Cells[0].Value != "")
                {


                    emp_ID = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    emp_name = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                    hkID = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                    password = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    position = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                    storeID = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                    department = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();

                    MessageBox.Show("selected");
         
                    


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {

            String PostionID;
            PostionID = Postion_combox.SelectedItem.ToString();

            if (PostionID == "Staff")
            {
                position = "0";
            }
            else if (PostionID == "Manager")
            {
                position = "1";
            }

            dataGridView1.DataSource = upLoadData();

        }

        private void StoreID_combox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            String checkStoreID;
            checkStoreID = StoreID_combox.SelectedItem.ToString();

            if (checkStoreID == "K")
            {
                storeID = "1";
            }
            else if (checkStoreID == "T")
            {
                storeID = "2";
            }

            dataGridView1.DataSource = upLoadData();
        }

        private void Deparment_combox_SelectedIndexChanged(object sender, EventArgs e)
        {
            sdepartment = Deparment_combox.SelectedItem.ToString();

            dataGridView1.DataSource = upLoadData();
        }

        private void Postion_combox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //
            String PostionID;
            PostionID = Postion_combox.SelectedItem.ToString();

            if (PostionID == "Staff")
            {
                position = "0";
            }
            else if (PostionID == "Manager")
            {
                position = "1";
            }

            dataGridView1.DataSource = upLoadData();





        }

        private void Postion_combox_SelectedIndexChanged(object sender, EventArgs e)
        {
            


        }

        private void Deparment_combox_Changed(object sender, EventArgs e)
        {

         

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            search = null;
            search = " where (emp_id like '%" + textBox4.Text + "%' ";
            search += "or customerName like '%" + textBox4.Text + "%' ";
            search += "or address like '%" + textBox4.Text + "%' ";
            search += "or PhoneNum like '%" + textBox4.Text + "%')";


            dataGridView1.DataSource = upLoadData();
        }



        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {
            search = null;
            search = " where (emp_id like '%" + textBox4.Text + "%' ";
            search += "or customerName like '%" + textBox4.Text + "%' ";
            search += "or address like '%" + textBox4.Text + "%' ";
            search += "or PhoneNum like '%" + textBox4.Text + "%')";


            dataGridView1.DataSource = upLoadData();

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {

        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {


            // CreateOrder.Customer.customerId = customerId;
            // CreateOrder.Customer.customerName = customerName;
            // CreateOrder.Customer.phoneNum = PhoneNum;
            CreateOrder.Customer.ccheck = 0;
            CreateOrder c = new CreateOrder();

            c.updataCustomer();

            this.Close();
        }
    }
}
