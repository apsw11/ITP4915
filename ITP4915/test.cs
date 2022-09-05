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
    public partial class test : Form
    {

        MySqlConnection sqlConn = new MySqlConnection();
        MySqlCommand sqlCmd = new MySqlCommand();
        DataTable sqlDt = new DataTable();

        MySqlDataAdapter DtA = new MySqlDataAdapter();
        MySqlDataReader sqlRd;
        DataSet DS = new DataSet();
        string[] dphba = new string[50];
        Random a = new Random();
        int c = 0;

        public test()
        {
            InitializeComponent();
        }

        private void test_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            testrows();


           
            

        }
        private void testrows()
        {
            sqlConn.ConnectionString = "server=localhost;user id=root;password=64959441;database=ITP4915";
            // get番个 个日 个时段 有几多人 


            


            string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;

            DataTable dtEmployees = new DataTable();

            using (MySqlConnection con = new MySqlConnection(connString))
            {
                using (MySqlCommand cmd = new MySqlCommand("Select delivery_empID FROM Delivery_emp Where not exists(select delivery_empID from delivery_empGeneral where date like '%2022-06-05%' and delivery_sessions like '%p%'and delivery_empGeneral.delivery_empID = delivery_emp.delivery_empID ); ", con))
                {
                    con.Open();

                    MySqlDataReader reader = cmd.ExecuteReader();

                    dtEmployees.Load(reader);
                  
                    for (int i = 0; i <= dtEmployees.Rows.Count-1; i++)
                    {
                        dphba[i] = dtEmployees.Rows[i][0].ToString();
                        //.Value.Tostring() = dphba[i];
                        c += 1;
                        
                    };

                    int d = 0;
                    if(c == 1)
                    {

                    }
                    if(c>1){
                        c = a.Next(0, c);
                    }


                    
            


                }
            }
            c = 0;
        }
    }
}
