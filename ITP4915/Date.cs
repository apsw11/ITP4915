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
        string ddate, dtime, itime, idate,ds;
        
        public Date()
        {
            InitializeComponent();
        }

        private void Date_Load(object sender, EventArgs e)
        {


            dataGridView1.DataSource = GetDelivery();
            dataGridView1.Columns[0].DefaultCellStyle.Format = "yyyy-MM-dd hh:mm:ss";
            listBox1.SelectedIndex = 0;
            radioButton1.Checked = true;


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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            

            dataGridView1.DataSource = UpdateDelivery();
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            radioButton3.Enabled = true;
            dataGridView1.Columns[0].DefaultCellStyle.Format = "yyyy-MM-dd hh:mm:ss";
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++) { 


                string s = dataGridView1.Rows[0].Cells[1].Value.ToString();
                if (Equals(s,"a"))
                {
                    if (Int32.Parse(dataGridView1.Rows[0].Cells[2].Value.ToString()) > 5)
                    {
                        radioButton1.Enabled = false;
                        
                    }
                }
                if (Equals(s, "p"))
                {
                    if (Int32.Parse(dataGridView1.Rows[0].Cells[2].Value.ToString()) > 5)
                    {
                        radioButton2.Enabled = false;
                        
                    }
                }
                if (Equals(s, "n"))
                {
                    if (Int32.Parse(dataGridView1.Rows[0].Cells[2].Value.ToString()) > 5)
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
                using (MySqlCommand cmd = new MySqlCommand("Select date, delivery_sessions,count(delivery_sessions) FROM  Delivery_empGeneral where date like '%" + ddate + "%' Group by "+ddate+",delivery_sessions ;", con))  //Where i.itemID = s.itemID and date = " + selectDate ";
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
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "yyyy'-'MM'-'dd";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {



            ddate = dateTimePicker1.Text + dtime;

            itime = this.listBox1.SelectedItem.ToString() + ":00";

            idate = dateTimePicker2.Text + itime;

            









            CreateOrder.getDate.ddate = ddate;

            CreateOrder.getDate.Dsessions = ds;
            CreateOrder.getDate.idate = idate;

            this.Close();

            
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
            dtime = "09:00";
            ds = "a";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            dtime = "13:00";
            ds = "p";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            dtime = "18:00";
            ds = "n";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource =  UpdateDelivery();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
