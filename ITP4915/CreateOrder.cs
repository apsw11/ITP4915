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
using System.Data.SqlClient;


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
        Data da = new Data();
        String sqlQuery;
        string payment, search;
        string wsid, itemid,wsqty;
        public int amount;
        string[] check = new string[20];  //check instore data
        int checkTimes ;
        string udd; //not display in datagrewview data
        int wsform;
        double ndeposit;
        Boolean deposit = false;
        public CreateOrder()
        {
            InitializeComponent();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ViewCustomer vc = new ViewCustomer();
            Customer.ccheck = 1;
            vc.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            search = null;
           
            dgvi();
            button8.Enabled = true;
            button9.Enabled = false;
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CreateOrder_Load(object sender, EventArgs e)
        {
            textBox7.Text = getID.empID;
            textBox8.Text = getID.storeID;
            textBox1.Text = "1";
            label7.Visible = false;
            label9.Visible = false;
            radioButton1.Checked = true;
            button8.Enabled = false;
            cleardata();
            

        }
        private DataTable GetWarehouseItem()
        {   

            udd = null;
            for (int i = 0; i < check.Count() - 1; i++) { udd += check[i]; };
            wsform = 1;
            DataTable dtEmployees = new DataTable();

            string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;

            using (MySqlConnection con = new MySqlConnection(connString))
            {

                using (MySqlCommand cmd = new MySqlCommand("Select w.warehouseID,i.itemID,i.itemName,i.detail,i.price,w.qty FROM warehouseItem as w,item as i Where i.itemID = w.itemID " + udd + search , con))
                {
                    con.Open();

                    MySqlDataReader reader = cmd.ExecuteReader();

                    dtEmployees.Load(reader);
                    
                    

                }
            }
          
            
            return dtEmployees;
            

        }
        private DataTable GetInstoreItem()
        {
            udd = null;
            for (int i =0 ; i< check.Count() -1;i++){ udd += check[i]; };
            wsform = 2;
            DataTable dtEmployees = new DataTable();

            string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;

            using (MySqlConnection con = new MySqlConnection(connString))
            {
                using (MySqlCommand cmd = new MySqlCommand("Select s.storeID,i.itemID,i.itemName,i.detail,i.price,s.qty FROM instoreItem as s,Item as i Where i.itemID = s.itemID and storeID = '"+getID.storeID +"' " + udd + search + ";", con))
                {
                    con.Open();

                    MySqlDataReader reader = cmd.ExecuteReader();

                    dtEmployees.Load(reader);
                }
            }
           
            return dtEmployees;
            

        }

        private void nochoose()
        {
            if (dataGridView1.Rows[0].Cells[0].Value != null) {
                wsid = dataGridView1.Rows[0].Cells[0].Value.ToString();
                itemid = dataGridView1.Rows[0].Cells[1].Value.ToString();
                price = dataGridView1.Rows[0].Cells[4].Value.ToString();
                Itemname = dataGridView1.Rows[0].Cells[2].Value.ToString();
                wsqty = dataGridView1.Rows[0].Cells[5].Value.ToString();
            }else button8.Enabled = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            search = null;
            dgvw();
            
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
       
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows[0].Cells[0].Value != null) {
                if (Int32.Parse(wsqty) > Int32.Parse(textBox1.Text)) {

                    ItemModel model = new ItemModel
                    {
                        Wsid = wsid,
                        ItemId = itemid,
                        ItemName = Itemname,
                        Quantity = Int32.Parse(textBox1.Text),
                        Price = Convert.ToDecimal(price)
                    };

                    SharedData.Items.Add(model);

                    int x = Int32.Parse(price);
                    int y = Int32.Parse(textBox1.Text);






                    label10.Text = amount.ToString();

                    check[checkTimes] = "and i.itemid not like '%" + itemid + "%' ";
                    checkTimes += 1;


                    if (wsform == 2)
                    {
                        dgvi();
                    amount = amount + x * y;
                    }
                    if (wsform == 1)
                    {
                        
                        dgvw();
                        deposit = true;
                        button7.Enabled = true;
                        label7.Visible = true;
                        label8.Visible = true;
                        if (x > 5000)
                            ndeposit = ndeposit + x * y * 0.2;
                        label9.Text = ndeposit.ToString();
                    }

                }
                else MessageBox.Show("Error!Not enough of item!");
            }
            else MessageBox.Show("Error!It is null!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = SharedData.Items;
            button8.Enabled = false;
            button9.Enabled = true;
            wsform = 3;

        }

        private void button6_Click(object sender, EventArgs e)
        {


            if (!string.IsNullOrWhiteSpace(textBox3.Text))
            {
                dataGridView1.DataSource = SharedData.Items;
                if (dataGridView1.Rows[0].Cells[0].Value != null)
                {
                    
                   
                    if (deposit == true && string.IsNullOrWhiteSpace(getDate.ddate) || deposit == false)
                    {

                        sqlConn.ConnectionString = "server=localhost;user id=root;password=64959441;database=ITP4915";


                        try
                        {
                            sqlConn.Open();
                            //salesorder
                            sqlQuery = "insert into ITP4915.SalesOrder (orderID,orderDate,amount,delivery,payment,customerID,storeID,emp_id" +
                                ")" +
                             " value(NULL, CURDATE()," + amount + ",NULL " + ",'" + payment + "','" + textBox3.Text + "','" + textBox8.Text + "','" + textBox7.Text + "');  ";


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

                        sqlConn.Open();
                        sqlQuery = "Select MAX(orderId) FROM SalesOrder; ";
                        sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
                        int orderId = (int)sqlCmd.ExecuteScalar();
                        sqlConn.Close();


                        //orderitem_loop

                        //update cart data

                        for (int i = 0; i < dataGridView1.Rows.Count - 2; i++)
                        {
                            string constring = "server=localhost;user id=root;password=64959441;database=ITP4915"; sqlConn.Close();
                            string query = "insert into ITP4915.orderItem(orderID, itemID, qty) values ('" + orderId + "', @itemid,@qty);";
                            MySqlConnection conDataBase = new MySqlConnection(constring);
                            MySqlCommand cmdDataBase = new MySqlCommand(query, conDataBase);
                            MySqlDataReader myReader;


                            cmdDataBase.Parameters.AddWithValue("@itemid", dataGridView1.Rows[i].Cells[0].Value);
                            cmdDataBase.Parameters.AddWithValue("@qty", dataGridView1.Rows[i].Cells[2].Value);
                            //cmdDataBase.Parameters.Clear();

                            conDataBase.Open();
                            myReader = cmdDataBase.ExecuteReader();

                            while (myReader.Read())
                            {

                            }
                            conDataBase.Close();
                        }





                        //insert delivery
                        if (deposit == true)
                        {
                            try
                            {
                                sqlConn.Open();
                                //salesorder
                                sqlQuery = "insert into ITP4915.Delivery" +
                                 " value(NULL,'" + getDate.ddate + "', '" + getDate.idate + "','" + textBox3.Text + "',null," + textBox7.Text + ");  ";


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

                            sqlConn.Open();
                            sqlQuery = "Select MAX(deliveryID) FROM Delivery; ";
                            sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
                            int deliveryId = (int)sqlCmd.ExecuteScalar();
                            sqlConn.Close();

                            try
                            {
                                sqlConn.Open();
                                //salesorder
                                sqlQuery = "insert into ITP4915.Delivery_empGeneral" +
                                 " value(" + deliveryId + ", 'I00001','" + getDate.ddate + "','" + getDate.Dsessions + "'); ";


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

                            MessageBox.Show("Order send. Need Printed receipts?", "Receipts", MessageBoxButtons.YesNo);
                            this.Close();   





                        }

                        //-qty update
                        // /*
                        for (int i = 0; i < dataGridView1.Rows.Count ; i++)
                        {
                            if(dataGridView1.Rows[i].Cells[0].Value != null)
                            {
                                string constring = "server=localhost;user id=root;password=64959441;database=ITP4915"; sqlConn.Close();
                                if (checkwsqty(i) == 1) {

                                    string query = "update instoreItem set qty = (qty- '@qty') where itemID = '@itemid');";
                                    MySqlConnection conDataBase = new MySqlConnection(constring);
                                    MySqlCommand cmdDataBase = new MySqlCommand(query, conDataBase);
                                    MySqlDataReader myReader;


                                    cmdDataBase.Parameters.AddWithValue("@itemid", Int32.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString()));
                                    cmdDataBase.Parameters.AddWithValue("@qty", dataGridView1.Rows[i].Cells[2].Value);
                                    //cmdDataBase.Parameters.Clear();

                                    conDataBase.Open();
                                    myReader = cmdDataBase.ExecuteReader();

                                    while (myReader.Read())
                                    {

                                    }
                                    conDataBase.Close();
                                }
                                if (checkwsqty(i) == 2) 
                                {
                                string query = "update warehouseItem set qty =(qty- '@qty') where itemID = '@itemid');";
                                MySqlConnection conDataBase = new MySqlConnection(constring);
                                MySqlCommand cmdDataBase = new MySqlCommand(query, conDataBase);
                                MySqlDataReader myReader;


                                cmdDataBase.Parameters.AddWithValue("@itemid", Int32.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString()));
                                cmdDataBase.Parameters.AddWithValue("@qty", dataGridView1.Rows[i].Cells[2].Value);
                                //cmdDataBase.Parameters.Clear();

                                conDataBase.Open();
                                myReader = cmdDataBase.ExecuteReader();

                                while (myReader.Read())
                                {

                                }
                                conDataBase.Close();
                                }
                              }
                            if (checkwsqty(i) == 0)
                            {
                                //Store or Warehouse ID no found
                            }
                        }





                        // */

                    }
                    else MessageBox.Show("Please choose date!");
                }
                else MessageBox.Show("Please add something in cart!");
            }
            else MessageBox.Show("Please chooese customer!");
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
            if (dataGridView1.Rows[0].Cells[0].Value != null) {
                if (wsform == 2 || wsform == 1)
                {
                    wsid = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    itemid = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    price = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                    Itemname = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                    wsqty = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                }
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
            public static int ccheck;
        }
        public class getID
        {
            public static string empID;
            public static string storeID;

            
        }
        public class getDate
        {
            public static string ddate;
         
            public static string idate;
            public static string Dsessions;


        }
        private int checkwsqty(int i)
        {
            string[] aWarehouseID = {"KB"};
            string[] aInstoreID = { "K", "T" };
        if (dataGridView1.Rows[i].Cells[0].Value != null){
                for (int x = 0; x < aWarehouseID.Count(); x++)
                {
                    ;
                    if (dataGridView1.Rows[i].Cells[0].Value.ToString() == aWarehouseID[x])

                    {

                        return 2;
                    }
                }
                for (int x = 0; x < aInstoreID.Count(); x++)
                {

                    if (dataGridView1.Rows[i].Cells[0].Value.ToString() == aInstoreID[x])
                    {

                        return 1;
                    }
                }

            }

            return 0;

            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cleardata();
            textBox1.Text = "1";
            label7.Visible = false;
            label9.Visible = false;
            radioButton1.Checked = true;
            button8.Enabled = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            search = null;
            if (wsform == 1 || wsform == 2)
            {
                if (wsform == 1) { 
                    search = " AND (warehouseID like '%" + textBox6.Text + "%' ";
            }
                    if (wsform == 2) { 
                search = " AND (storeID like '%" + textBox6.Text + "%' ";
                }
                search += " or i.itemID like '%" + textBox6.Text + "%' ";
                search += " or i.itemName like '%" + textBox6.Text + "%' ";
                search += " or i.detail like '%" + textBox6.Text + "%' ";
                search += " or i.price like '%" + textBox6.Text + "%' )";

                if (wsform == 1)
                    dgvw();
                if (wsform == 2)
                    dgvi();

                label6.Text = search;
            }
            /*
             * if ()
            {
                ItemModel itemModel = Items.SingleOrDefault(p => p.itemId == 1);
            }
            */
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            payment = "credit card";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                textBox1.Text = 0.ToString();
            double number = double.Parse(textBox1.Text);
            textBox1.Text = number.ToString();
            if (number <= 50 && number >= 0)
            {
                return;
            }
            MessageBox.Show("qty > 50 or < 0", "error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBox1.Text = "1";
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            textBox3.Text = Customer.customerId;
            textBox4.Text = Customer.customerName;
            textBox5.Text = Customer.phoneNum;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            payment = "cash";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Date da = new Date();
            da.Show();
           
        }

        private void cleardata()
        {
            Customer.customerId = null;
            Customer.customerName = null;
            Customer.phoneNum = null;
            getDate.ddate = null;
            getDate.Dsessions = null;
            getDate.idate = null;
            SharedData.Items.Clear();
        }
        private void dgvi()
        {
            dataGridView1.DataSource = GetInstoreItem();
            nochoose();
            button8.Enabled = true;
            button9.Enabled = false;
        }
        private void dgvw()
        {
            dataGridView1.DataSource = GetWarehouseItem();
            nochoose();

            button8.Enabled = true;
            button9.Enabled = false;
        }
    }
}
