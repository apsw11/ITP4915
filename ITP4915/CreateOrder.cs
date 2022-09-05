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
        string wsid, itemid, wsqty;
        public int amount;
        string[] check = new string[40];  //check instore data
        int checkTimes;
        string udd; //not display in datagrewview data
        int wsform;
        int ndeposit = 0;
        string Selectaddress;
        string deliveryyn = "N";
        Boolean deposit = false;
        string checkdeposit;
        string depossit;
        string rorderId = "null";
        String[,] instoreqtycheck = new String[40, 2];
        Boolean firstTimeOpen;
        int isqtycheck = 0;
        Boolean deposityn;



        public CreateOrder()
        {
            InitializeComponent();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ViewCustomer vc = new ViewCustomer();
            Customer.ccheck = 1;
            vc.ShowDialog();
            textBox3.Text = Customer.customerId;
            textBox4.Text = Customer.customerName;
            textBox5.Text = Customer.phoneNum;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            search = null;

            dgvi();
            button8.Enabled = true;
            button9.Enabled = false;
            if (dataGridView1.Rows.Count == 1)
            {
                button8.Enabled = false;
                
            }


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
            radioButton3.Checked = true;
            Selectaddress = "null";
            textBox3.Text = "CA0000";





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

                using (MySqlCommand cmd = new MySqlCommand("Select w.warehouseID,i.itemID,i.itemName,i.detail,i.price,w.qty FROM warehouseItem as w,item as i Where i.itemID = w.itemID " + udd + search, con))
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
            for (int i = 0; i < check.Count() - 1; i++) { udd += check[i]; };
            wsform = 2;
            DataTable dtEmployees = new DataTable();

            string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;

            using (MySqlConnection con = new MySqlConnection(connString))
            {
                using (MySqlCommand cmd = new MySqlCommand("Select s.storeID,i.itemID,i.itemName,i.detail,i.price,s.qty FROM instoreItem as s,Item as i Where i.itemID = s.itemID and storeID = '" + getID.storeID + "' " + udd + search + ";", con))
                {
                    con.Open();

                    MySqlDataReader reader = cmd.ExecuteReader();

                    dtEmployees.Load(reader);
                }
            }


            //"Select * from emp where empid like '%"+department + Position  + store"%';";
            //string department ="";
            //string Position ="";
            //string store ="";
            //




            return dtEmployees;


        }

        private void nochoose()
        {
            if (dataGridView1.Rows[0].Cells[0].Value != null)
            {
                wsid = dataGridView1.Rows[0].Cells[0].Value.ToString();
                itemid = dataGridView1.Rows[0].Cells[1].Value.ToString();
                price = dataGridView1.Rows[0].Cells[4].Value.ToString();
                Itemname = dataGridView1.Rows[0].Cells[2].Value.ToString();
                wsqty = dataGridView1.Rows[0].Cells[5].Value.ToString();
            }
            else button8.Enabled = false;
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
            if (textBox1.Text != "")
            {
      
                if (dataGridView1.Rows.Count != 1) { 
                if (dataGridView1.SelectedRows[0].Cells[0].Value != null)
                {


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



                    //int r = dataGridView1.CurrentCell.RowIndex;


                    for (int r = 0; r < isqtycheck; r++)
                    {


                        if (instoreqtycheck[r, 0] == dataGridView1.SelectedRows[0].Cells[1].Value.ToString())
                        {
                            if (wsform == 2)
                            {

                                if (Int32.Parse(instoreqtycheck[r, 1]) >= y)
                                {

                                    amount = amount + x * y;
                                    label10.Text = amount.ToString();


                                }
                                if (Int32.Parse(instoreqtycheck[r, 1]) < y)
                                {


                                    if (x * y < 5000)
                                    {

                                        label7.Visible = true;
                                        label9.Visible = true;
                                        ndeposit += 0;
                                        label9.Text = ndeposit.ToString();
                                        checkdeposit = "b";
                                        deposityn = true;

                                    }
                                    if (x * y > 5000)
                                    {
                                        label7.Visible = true;

                                        label9.Visible = true;

                                        ndeposit += (int)Math.Round(x * y * 0.2);
                                        label9.Text = ndeposit.ToString();
                                        checkdeposit = "b";
                                        deposityn = true;



                                    }



                                    radioButton4.Checked = true;
                                    radioButton3.Enabled = false;
                                    deposit = true;


                                }
                            }

                        }

                    }
                    
                    check[checkTimes] = "and i.itemid not like '%" + itemid + "%' ";
                    checkTimes += 1;


                   
                   
             
                    dgvi();
                    int a = Int32.Parse(label10.Text) + Int32.Parse(label9.Text);
                    label14.Text = a.ToString();

                    if (dataGridView1.Rows.Count == 1)
                    {
                        
                        button8.Enabled = false;

                    }
                    }
                }
                else MessageBox.Show("Error!It is null!");
            }
            else MessageBox.Show("Error!qty is null!");
        }

        private void button3_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = SharedData.Items;
            button8.Enabled = false;
            button9.Enabled = true;
            wsform = 3;
            if (dataGridView1.Rows[0].Cells[0].Value != null)
            {
                wsid = dataGridView1.Rows[0].Cells[4].Value.ToString();
                itemid = dataGridView1.Rows[0].Cells[0].Value.ToString();
                price = dataGridView1.Rows[0].Cells[3].Value.ToString();
                Itemname = dataGridView1.Rows[0].Cells[1].Value.ToString();
                wsqty = dataGridView1.Rows[0].Cells[2].Value.ToString();
            }

            if (dataGridView1.Rows.Count == 1)
            {
                button9.Enabled = false;
              
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {


            if (!string.IsNullOrWhiteSpace(textBox3.Text))
            {
                dataGridView1.DataSource = SharedData.Items;
                if (dataGridView1.Rows[0].Cells[0].Value != null)
                {


                    if (deposit == true && getDate.ddate != null || deposit == false)
                    {


                        String[] nrorder = new String[50];
                        int[] nrqty = new int[50];
                        string rorderyn = "default";
                        Order.DeliveryYN = false;
                        Order.InstallationYN = false;
                        int lessfive = 0;
                        for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                        {
                            if (dataGridView1.Rows[0].Cells[0].Value != null) {
             
                                int a = Int32.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString()) * Int32.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
                            if (a<5000)
                            {
                             
                                    for (int r = 0; r < instoreqtycheck.GetUpperBound(0); r++) {
                                        
                                        if (instoreqtycheck[r, 0] == dataGridView1.Rows[i].Cells[0].Value.ToString()) {
                              
                                            if (Int32.Parse(instoreqtycheck[r, 1]) < Int32.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString())) {
                                                lessfive += a;
                                           
                                            }
                                        }
                                    }
                                    
                            }
                            }
                        }

              

                        int amountreal = amount + ndeposit * 5 + lessfive;

                        sqlConn.ConnectionString = "server=localhost;user id=root;password=64959441;database=ITP4915";
                        acheckdeposit();

                        if (deposityn == false)
                        {
                            depossit = "null";
                        }

                        try
                        {
                            sqlConn.Open();
                            //salesorder
                            sqlQuery = "insert into SalesOrder "
                             + "value(NULL, CURDATE()," + amountreal + ",'" + deliveryyn + "'" + ",'" + payment + "','" + textBox3.Text + "','" + textBox8.Text + "','" + textBox7.Text + "'," + depossit + ",default);  "; //,default


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

                        //reposit 
                        Order.orderId = orderId.ToString();
                        Order.Payment = payment;
                        Order.customerID = textBox3.Text;
                        Order.amount = amountreal.ToString();
                        Order.total = label14.Text;
                        if (deposityn == true)
                        {
                            Order.deposit = ndeposit.ToString();

                        }
                        else
                        {
                            Order.deposit = depossit.ToString();

                        }




                        //orderitem_loop

                        //update cart data

                        for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
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

                        //check qty

                        int nod = 0;
                        for (int i = 0; i <= dataGridView1.Rows.Count - 2; i++)
                        {
                            sqlConn.Open();
                            sqlQuery = "Select qty FROM instoreItem where itemID = '" + dataGridView1.Rows[i].Cells[0].Value.ToString() + "'; ";
                            sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
                            int reordercheck = (int)sqlCmd.ExecuteScalar();
                            if (reordercheck - Int32.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()) < 0)
                            {
                                nrorder[nod] = dataGridView1.Rows[i].Cells[0].Value.ToString();
                                nrqty[nod] = reordercheck;

                                nod++;

                            }
                            sqlConn.Close();
                        }

                        // qty
                        for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                        {
                            if (!object.ReferenceEquals(null, dataGridView1.Rows[i].Cells[0].Value))
                            {
                                int qtychecks = 0;
                                int qtynumber = 0;
                                string constring = "server=localhost;user id=root;password=64959441;database=ITP4915"; sqlConn.Close();
                                if (nrorder.Count() != 0)
                                {

                                    for (int j = 0; j < nrorder.Count() - 1; j++)
                                    {
                                        qtychecks++;
                                        if (dataGridView1.Rows[i].Cells[0].Value.ToString() == nrorder[j])
                                        {

                                            qtychecks--;
                                            qtynumber = j;


                                        }
                                    }
                                }
                                if (qtychecks == nrorder.Count() - 1)
                                {

                                    string query = "update instoreItem set qty = (qty-" + dataGridView1.Rows[i].Cells[2].Value.ToString() + ") where itemID = '" + dataGridView1.Rows[i].Cells[0].Value.ToString() + "' AND storeID like '%" + dataGridView1.Rows[i].Cells[4].Value.ToString() + "%';";
                                    MySqlConnection conDataBase = new MySqlConnection(constring);
                                    MySqlCommand cmdDataBase = new MySqlCommand(query, conDataBase);
                                    MySqlDataReader myReader;




                                    //cmdDataBase.Parameters.Clear();

                                    conDataBase.Open();
                                    myReader = cmdDataBase.ExecuteReader();

                                    while (myReader.Read())
                                    {

                                    }
                                    conDataBase.Close();


                                }



                                if (qtychecks != nrorder.Count() - 1)
                                {


                                    String query = "update warehouseItem set qty =(qty-" + (dataGridView1.Rows[i].Cells[2].Value.ToString()) + ") where itemID = '" + dataGridView1.Rows[i].Cells[0].Value.ToString() + "' ;";
                                    MySqlConnection conDataBase = new MySqlConnection(constring);
                                    MySqlCommand cmdDataBase = new MySqlCommand(query, conDataBase);
                                    MySqlDataReader myReader;


                                    //cmdDataBase.Parameters.Clear();

                                    conDataBase.Open();
                                    myReader = cmdDataBase.ExecuteReader();

                                    while (myReader.Read())
                                    {

                                    }
                                    conDataBase.Close();

                                }

                                if (checkwsqty(i) == 0)
                                {
                                    //Store or Warehouse ID no found
                                }


                            }

                        }





                        //reorder
                        if (nod != 0)
                        {
                            rorderyn = "'In Warehouse'";
                            try
                            {
                                sqlConn.Open();
                                //salesorder
                                sqlQuery = "insert into replenishmentOrder" +
                                    "" +
                                 " value(NULL, CURDATE(),'" + textBox7.Text + "','" + textBox8.Text + "',default);  ";


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
                            sqlQuery = "Select MAX(RorderId) FROM replenishmentOrder; ";
                            sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
                            rorderId = sqlCmd.ExecuteScalar().ToString();
                            sqlConn.Close();

                            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                            {
                                if (!object.ReferenceEquals(null, dataGridView1.Rows[i].Cells[0].Value))
                                {
                                    for (int j = 0; j <= nrorder.Count() - 2; j++)
                                        if (dataGridView1.Rows[i].Cells[0].Value.ToString() == nrorder[j])
                                        {





                                            //orderitem_loop

                                            //update cart data


                                            string constring = "server=localhost;user id=root;password=64959441;database=ITP4915"; sqlConn.Close();
                                            string query = "insert into ITP4915.RorderItem(rorderID, itemID, qty) values ('" + rorderId + "', @itemid,@qty);";
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
                                }
                            }
                        }

                        //insert delivery
                        if (deliveryyn == "Y")
                        {
                            try
                            {
                                sqlConn.Open();
                                //salesorder
                                sqlQuery = "insert into ITP4915.Delivery" +
                                 " value(NULL,'" + getDate.ddate + "', " + getDate.idate
                                 + "," + Selectaddress + "," + orderId + "," + rorderId + "," + rorderyn + "); ";


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
                            //receipt
                            Order.deliveryNo = deliveryId.ToString();
                            Order.DeliveryDate = getDate.ddate;
                            Order.InstallationDate = getDate.idate;
                            Order.DeliveryYN = true;
                            Order.InstallationYN = true;
                            if (CreateOrder.getDate.yninstallation == "N")
                            {
                                Order.InstallationYN = false;
                            }



                            //
                            string[] dphba = new string[50];
                            sqlConn.ConnectionString = "server=localhost;user id=root;password=64959441;database=ITP4915";
                            // 
                            int rdphba = 0;



                            string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;

                            DataTable dtEmployees = new DataTable();

                            using (MySqlConnection con = new MySqlConnection(connString))
                            {
                                using (MySqlCommand cmd = new MySqlCommand("Select delivery_empID FROM Delivery_emp Where not exists(select delivery_empID from delivery_empGeneral where date like '%" + getDate.date + "%' and delivery_sessions like '%" + getDate.Dsessions + "%'and delivery_empGeneral.delivery_empID = delivery_emp.delivery_empID ); ", con))
                                {
                                    con.Open();

                                    MySqlDataReader reader = cmd.ExecuteReader();

                                    dtEmployees.Load(reader);

                                    for (int i = 0; i <= dtEmployees.Rows.Count - 1; i++)
                                    {
                                        dphba[i] = dtEmployees.Rows[i][0].ToString();
                                        //.Value.Tostring() = dphba[i];
                                        rdphba += 1;

                                    };




                                }
                            }
                            Random a = new Random();
                            int c = 0;

                            if (rdphba == 1)
                            {
                                c = 0;
                            }
                            if (rdphba > 1)
                            {


                                c = a.Next(0, rdphba);
                            };
                            //a.Next(0, dphba.Count()-1)

                            // create 选择 ID
                            try
                            {


                                sqlConn.ConnectionString = "server=localhost;user id=root;password=64959441;database=ITP4915";
                                sqlConn.Open();
                                //salesorder
                                sqlQuery = "insert into ITP4915.Delivery_empGeneral" +
                               " value(" + deliveryId + ", '" + dphba[c] + "','" + getDate.date + "','" + getDate.Dsessions + "'); ";


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





                            //-qty update


                            // */





                        }
                        if (MessageBox.Show("Order send. Need Printed receipts?", "Receipts", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            receipt rp = new receipt();
                            rp.ShowDialog();
                        }
                        this.Close();

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

        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[0].Cells[0].Value != null)
            {
                if (wsform == 2 || wsform == 1)
                {
                    wsid = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    itemid = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    price = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                    Itemname = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                    wsqty = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                }
                if (wsform == 3)
                {
                    wsid = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                    itemid = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    price = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                    Itemname = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    textBox1.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();


                }
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count != 1)
            {
                if (dataGridView1.SelectedRows[0].Cells[0].Value != null)
                {
                    int rowsfind = dataGridView1.CurrentCell.RowIndex;
                    int depositcheck = 0;
                    for (int r = 0; r < isqtycheck; r++)
                    {


                        if (instoreqtycheck[r, 0] == dataGridView1.SelectedRows[0].Cells[0].Value.ToString())
                        {
                            if (Int32.Parse(instoreqtycheck[r, 1]) >= Int32.Parse(dataGridView1.SelectedRows[0].Cells[2].Value.ToString()))

                            {
                                amount -= Int32.Parse(dataGridView1.SelectedRows[0].Cells[3].Value.ToString()) * Int32.Parse(dataGridView1.SelectedRows[0].Cells[2].Value.ToString());
                                label10.Text = amount.ToString();


                            }
                            if (Int32.Parse(instoreqtycheck[r, 1]) < Int32.Parse(dataGridView1.SelectedRows[0].Cells[2].Value.ToString())) //remove if() 
                            {
                                ndeposit -= (int)Math.Round(Int32.Parse(dataGridView1.SelectedRows[0].Cells[3].Value.ToString()) * Int32.Parse(dataGridView1.SelectedRows[0].Cells[2].Value.ToString()) * 0.2);
                                label9.Text = ndeposit.ToString();


                            }

                        }

                        for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                        {
                            if (Int32.Parse(instoreqtycheck[r, 1]) < Int32.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()))
                            {
                                depositcheck += 1;
                            }

                        }
                    }
                    if (depositcheck == 0)
                    {


                        label7.Visible = false;

                        label9.Visible = false;
                        checkdeposit = "a";
                        ndeposit = 0;
                        label9.Text = ndeposit.ToString();
                        radioButton3.Enabled = true;
                        radioButton3.Enabled = true;
                        deposityn = false;


                    }
                    string y = "and i.itemid not like '%" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "%' ";
                    int x = dataGridView1.CurrentCell.RowIndex;



                    dataGridView1.Rows.RemoveAt(x);


                    for (int i = 0; i < check.Count(); i++)
                    {
                        if (check[i] == y)
                        {
                            check[i] = null;
                        }
                    }
                    int a = Int32.Parse(label10.Text) + Int32.Parse(label9.Text);
                    label14.Text = a.ToString();

                    if (dataGridView1.Rows.Count == 1)
                    {
                        button9.Enabled = false;

                    }
                }
            }
            else MessageBox.Show("It is null!");

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
            public static string date;
            public static string yninstallation;


        }

        public class Order
        {

            public static string orderId;
            public static string Payment;
            public static string customerID;
            public static string address;
            public static string deliveryNo;
            public static string DeliveryDate;
            public static string amount;
            public static string deposit;
            public static string InstallationDate;
            public static Boolean DeliveryYN;
            public static Boolean InstallationYN;
            public static string total;




        }
        private int checkwsqty(int i)
        {
            string[] aWarehouseID = { "KB" };
            string[] aInstoreID = { "K", "T" };

            for (int x = 0; x <= aWarehouseID.Count() - 1; x++)
            {

                if (dataGridView1.Rows[i].Cells[4].Value.ToString() == aWarehouseID[x])

                {

                    return 2;
                }
            }
            for (int x = 0; x <= aInstoreID.Count() - 1; x++)
            {

                if (dataGridView1.Rows[i].Cells[4].Value.ToString() == aInstoreID[x])
                {

                    return 1;
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
            amount = 0;
            ndeposit = 0;
            label14.Text = "0";
            label9.Text = "0";
            label10.Text = "0";

        }

        private void button10_Click(object sender, EventArgs e)
        {
            search = null;
            if (wsform == 1 || wsform == 2)
            {
                if (wsform == 1)
                {
                    search = " AND (warehouseID like '%" + textBox6.Text + "%' ";
                }
                if (wsform == 2)
                {
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



                //b.Contains(a);


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
            string checkqty = textBox1.Text;
            if (checkqty != "")
            {
                int number = Int32.Parse(textBox1.Text);
                if (number <= 50 && number >= 1)
                {

                    if (wsform == 3)
                    {
                        int a = Int32.Parse(price);
                        int b = Int32.Parse(dataGridView1.SelectedRows[0].Cells[2].Value.ToString());
                        int c = Int32.Parse(textBox1.Text);
                        if (dataGridView1.SelectedRows[0].Cells[0].Value != null)
                        {
                            int rowsfind = dataGridView1.CurrentCell.RowIndex;
                            int depositcheck = 0;
                            for (int r = 0; r < isqtycheck; r++)
                            {


                                if (instoreqtycheck[r, 0] == dataGridView1.SelectedRows[0].Cells[0].Value.ToString())
                                {
                                    if (Int32.Parse(instoreqtycheck[r, 1]) >= Int32.Parse(dataGridView1.SelectedRows[0].Cells[2].Value.ToString()))
                                    {

                                        amount = amount - (a * b);
                                        if (Int32.Parse(instoreqtycheck[r, 1]) >= c)
                                        {

                                            amount += (a * c);


                                        }
                                        if (Int32.Parse(instoreqtycheck[r, 1]) < c)
                                        {
                                            label7.Visible = true;
                                            label9.Visible = true;
                                            deposityn = true;
                                            radioButton4.Checked = true;
                                            radioButton3.Enabled = false;
                                            deposit = true;

                                            if (a * c < 5000)
                                            {

                                            }
                                            if (a * c >= 5000)
                                            {
                                                ndeposit += (int)Math.Round(a * c * 0.2);


                                            }
                                        }
                                    }
                                    if (Int32.Parse(instoreqtycheck[r, 1]) < Int32.Parse(dataGridView1.SelectedRows[0].Cells[2].Value.ToString()))
                                    {
                                        ndeposit -= (int)Math.Round(a * b * 0.2);
                                        if (Int32.Parse(instoreqtycheck[r, 1]) >= c)
                                        {

                                            amount += (a * c);
                                            radioButton3.Enabled = false;


                                        }
                                        if (Int32.Parse(instoreqtycheck[r, 1]) < c)
                                        {
                                            label7.Visible = true;
                                            label9.Visible = true;

                                            if (a * c < 5000)
                                            {

                                            }
                                            if (a * c >= 5000)
                                            {
                                                ndeposit += (int)Math.Round(a * c * 0.2);


                                            }
                                        }

                                    }

                                }


                            }
                        }











                        if (dataGridView1.SelectedRows[0].Cells[0].Value != null)
                        {
                            int x = dataGridView1.CurrentCell.RowIndex;


                            //Int32.Parse(dataGridView1.SelectedRows[0].Cells[2].Value.ToString());





                            int dgvCount = dataGridView1.Rows.Count - 2;


                            for (int k = 0; k <= dgvCount - x; k++)
                            {

                                if (k == 0)
                                {
                                    ItemModel model = new ItemModel
                                    {
                                        Wsid = dataGridView1.SelectedRows[0].Cells[4].Value.ToString(),
                                        ItemId = dataGridView1.SelectedRows[0].Cells[0].Value.ToString(),
                                        ItemName = dataGridView1.SelectedRows[0].Cells[1].Value.ToString(),
                                        Quantity = c,
                                        Price = Int32.Parse(dataGridView1.SelectedRows[0].Cells[3].Value.ToString())
                                    };
                                    SharedData.Items.Add(model);
                                }


                                if (k >= 1)
                                {
                                    ItemModel model = new ItemModel
                                    {
                                        Wsid = dataGridView1.Rows[x].Cells[4].Value.ToString(),
                                        ItemId = dataGridView1.Rows[x].Cells[0].Value.ToString(),
                                        ItemName = dataGridView1.Rows[x].Cells[1].Value.ToString(),
                                        Quantity = Int32.Parse(dataGridView1.Rows[x].Cells[2].Value.ToString()),
                                        Price = Int32.Parse(dataGridView1.Rows[x].Cells[3].Value.ToString())
                                    };
                                    SharedData.Items.Add(model);


                                }

                                dataGridView1.DataSource = SharedData.Items;



                                dataGridView1.Rows.RemoveAt(x);

                            }
                            int depositcheck = 0;
                            for (int r = 0; r < isqtycheck; r++)
                            {

                                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                                {
                                    if (Int32.Parse(instoreqtycheck[r, 1]) < Int32.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()))
                                    {
                                        depositcheck += 1;
                                    }

                                }
                            }
                   
                            if (depositcheck == 0)
                            {


                                label7.Visible = false;

                                label9.Visible = false;
                                checkdeposit = "a";
                                ndeposit = 0;
                                label9.Text = ndeposit.ToString();

                                deposityn = false;

                                radioButton4.Checked = false;
                                radioButton3.Enabled = true;


                            }





                            label10.Text = amount.ToString();
                            label9.Text = ndeposit.ToString();
                            int d = Int32.Parse(label10.Text) + Int32.Parse(label9.Text);
                            label14.Text = d.ToString();

                        }

                    }
                }
                else
                {
                    MessageBox.Show("qty > 50 or < 0", "error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox1.Text = "1";
                }
            }

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

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            search = null;
            if (wsform == 1 || wsform == 2)
            {
                if (wsform == 1)
                {
                    search = " AND (warehouseID like '%" + textBox6.Text + "%' ";
                }
                if (wsform == 2)
                {
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



                //b.Contains(a);


            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            Selectaddress = "null";
            deliveryyn = "N";
            button7.Enabled = false;
            deposit = false;  //help

        }

        private void radioButton4_CheckedChanged_1(object sender, EventArgs e)
        {
            Selectaddress = "'" + textBox3.Text + "'";
            deliveryyn = "Y";
            button7.Enabled = true;
            deposit = true;
        }

        private void cleardata()
        {
            Customer.customerId = null;
            Customer.customerName = null;
            Customer.phoneNum = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;

            getDate.ddate = null;
            getDate.Dsessions = null;
            getDate.idate = null;

            SharedData.Items.Clear();
            for (int i = 0; i < check.Count(); i++)
            {
                check[i] = null;
            }
            firstTimeOpen = true;

        }

        private void button10_Click_1(object sender, EventArgs e)
        {

        }

        private void button10_Click_2(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TabStopChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                textBox1.Text = 1.ToString();
            double number = double.Parse(textBox1.Text);
            textBox1.Text = number.ToString();
            if (number <= 50 && number >= 1)
            {
                MessageBox.Show("qty > 50 or < 0", "error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Text = "1";
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2GroupBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2GroupBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void dgvi()
        {
            dataGridView1.DataSource = GetInstoreItem();
            nochoose();
            button8.Enabled = true;

            button9.Enabled = false;
            if (firstTimeOpen == true)
            {
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    instoreqtycheck[i, 0] = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    instoreqtycheck[i, 1] = dataGridView1.Rows[i].Cells[5].Value.ToString();
                    isqtycheck++;

                }
            }
            firstTimeOpen = false;
        }
        private void dgvw()
        {
            dataGridView1.DataSource = GetWarehouseItem();
            nochoose();

            button8.Enabled = true;
            button9.Enabled = false;
        }
        private void acheckdeposit()
        {
            if (checkdeposit == "a")
            {
                depossit = "null";
            }
            if (checkdeposit != "a")
            {
                depossit = ndeposit.ToString();
            }
        }
    }
}
