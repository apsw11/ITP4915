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
    public partial class Date : Form
    {
        public string CustomFormat { get; set; }
        MySqlConnection sqlConn = new MySqlConnection();
        MySqlCommand sqlCmd = new MySqlCommand();
        DataTable sqlDt = new DataTable();

        MySqlDataAdapter DtA = new MySqlDataAdapter();
        MySqlDataReader sqlRd;
        DataSet DS = new DataSet();
        string ddate, dtime, itime, idate, ds;
        string dddate;
        int v = 0;
        String sqlQuery;
        public Date()
        {
            InitializeComponent();
        }

        private void Date_Load(object sender, EventArgs e)
        {


            dataGridView1.DataSource = GetDelivery();
            dataGridView1.Columns[0].DefaultCellStyle.Format = "yyyy-MM-dd hh:mm:ss";
            GetempCount();

            CreateOrder.getDate.yninstallation = "N";


            SetMyCustomFormat();
        }
        private DataTable GetDelivery()
        {
            DataTable dtEmployees = new DataTable();

            string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;

            using (MySqlConnection con = new MySqlConnection(connString))
            {
                using (MySqlCommand cmd = new MySqlCommand("Select date, delivery_sessions,count(delivery_sessions) FROM  Delivery_empGeneral Group by date ,delivery_sessions ; ", con))  //Where i.itemID = s.itemID and date = " + selectDate ";
                {
                    con.Open();

                    MySqlDataReader reader = cmd.ExecuteReader();

                    dtEmployees.Load(reader);
                }
            }
            return dtEmployees;
        }
        private void GetempCount()
        {

            DataTable dtEmployees = new DataTable();

            string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;

            using (MySqlConnection con = new MySqlConnection(connString))
            {
                using (MySqlCommand cmd = new MySqlCommand("Select counT(*) FROM delivery_emp; ", con))  //Where i.itemID = s.itemID and date = " + selectDate ";
                {
                    con.Open();

                    MySqlDataReader reader = cmd.ExecuteReader();

                    dtEmployees.Load(reader);
                }
            }

            v = Int32.Parse(dtEmployees.Rows[0][0].ToString());






        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            ddate = dateTimePicker1.Text;

            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            radioButton3.Enabled = true;
            dataGridView1.Columns[0].DefaultCellStyle.Format = "yyyy-MM-dd hh:mm:ss";

            dddate = dateTimePicker1.Text;
            dddate = dddate.Substring(0, 10);

            dataGridView1.DataSource = UpdateDelivery();

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {


                string s = dataGridView1.Rows[i].Cells[1].Value.ToString();
                if (Equals(s, "A"))
                {
                    if (Int32.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()) >= v)
                    {
                        radioButton1.Enabled = false;

                    }
                }
                if (Equals(s, "P"))
                {
                    if (Int32.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()) >= v)
                    {
                        radioButton2.Enabled = false;

                    }
                }
                if (Equals(s, "N"))
                {
                    if (Int32.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()) >= v)
                    {
                        radioButton3.Enabled = false;

                    }
                }





            }

        }












        private DataTable UpdateDelivery()
        {
            DataTable dtEmployees = new DataTable();

            string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;

            using (MySqlConnection con = new MySqlConnection(connString))
            {
                using (MySqlCommand cmd = new MySqlCommand("Select date, delivery_sessions,count(delivery_sessions) FROM  Delivery_empGeneral where date like '%" + dddate + "%' Group by date ,delivery_sessions ;", con))  //Where i.itemID = s.itemID and date = " + selectDate ";
                {
                    con.Open();

                    MySqlDataReader reader = cmd.ExecuteReader();

                    dtEmployees.Load(reader);
                }
            }
            return dtEmployees;
        }




        public void SetMyCustomFormat()
        {
            // Set the Format type and the CustomFormat string.
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy'-'MM'-'dd";

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ds != null)
            {
                if (listBox1.SelectedItem != null)
                {

                    dtime = listBox1.SelectedItems[0].ToString() + ":00";



                    ddate = dateTimePicker1.Text + " " + dtime;


                    itime = this.listBox1.SelectedItem.ToString();
                    string hour = itime.Substring(0, 2);
                    int hours = Int32.Parse(hour) + 2;

                    hour = hours.ToString() + itime.Substring(2);

                    if (CreateOrder.getDate.yninstallation == "Y")
                    {
                        idate = "'" + dateTimePicker1.Text + " " + hour + ":00'";
                    }


                    if (CreateOrder.getDate.yninstallation == "N")
                    {
                        idate = "null";
                    }


                    string date = dateTimePicker1.Text;



                    CreateOrder.getDate.ddate = ddate;
                    CreateOrder.getDate.date = dddate;
                    CreateOrder.getDate.Dsessions = ds;
                    CreateOrder.getDate.idate = idate;


                    this.Close();

                }
                else MessageBox.Show("Select time");
            }
            else MessageBox.Show("Select Day Chart");




        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // dtime = "09:00:00";
            ds = "A";
            listBox1.Items.Clear();

            listBox1.Items.Add("09:00");
            listBox1.Items.Add("09:30");
            listBox1.Items.Add("10:00");
            listBox1.Items.Add("10:30");
            listBox1.Items.Add("11:00");
            listBox1.Items.Add("11:30");
            listBox1.Items.Add("12:00");
            listBox1.Items.Add("12:30");



        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            // dtime = "13:00:00";
            ds = "P";
            listBox1.Items.Clear();
            listBox1.Items.Add("13:00");
            listBox1.Items.Add("13:30");
            listBox1.Items.Add("14:00");
            listBox1.Items.Add("14:30");
            listBox1.Items.Add("15:00");
            listBox1.Items.Add("15:30");
            listBox1.Items.Add("16:00");
            listBox1.Items.Add("16:30");
            listBox1.Items.Add("17:00");
            listBox1.Items.Add("17:30");



        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            /* if ()
             {
                 if (dateTimePicker2.Text == dateTimePicker2.Text)
                 {

                 }
             }
             MessageBox.Show("Installation time should be slower than delivery time", "error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            */
        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        private void guna2ToggleSwitch1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (guna2ToggleSwitch1.Checked == true)
            {

                CreateOrder.getDate.yninstallation = "Y";
            }
            if (guna2ToggleSwitch1.Checked == false)
            {

                CreateOrder.getDate.yninstallation = "N";
         
            }

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            dtime = "18:00:00";
            ds = "N";
            listBox1.Items.Clear();
            listBox1.Items.Add("18:00");
            listBox1.Items.Add("18:30");
            listBox1.Items.Add("19:00");
            listBox1.Items.Add("19:30");
            listBox1.Items.Add("20:00");
            listBox1.Items.Add("20:30");
            listBox1.Items.Add("21:00");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = UpdateDelivery();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
