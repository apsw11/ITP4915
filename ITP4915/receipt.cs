using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915
{
    public partial class receipt : Form
    {
        public receipt()
        {
            InitializeComponent();
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void receipt_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.DataSource = SharedData.Items;
            label9.Text = CreateOrder.Order.orderId;
            label10.Text = CreateOrder.Order.Payment;
            label11.Text = CreateOrder.Order.customerID;
            if (CreateOrder.Order.DeliveryYN == true)
            {
                label13.Text = CreateOrder.Order.deliveryNo;
                label14.Text = CreateOrder.Order.DeliveryDate;
                if (CreateOrder.Order.InstallationYN == true)
                {
                    string s = CreateOrder.Order.InstallationDate;
                    label20.Text = s;
                }
                else
                {
                    label21.Visible = false;
                    label20.Visible = false;
                }
            }
            else
            {
                label2.Visible = false;
                label4.Visible = false;
                label13.Visible = false;
                label14.Visible = false;
                label21.Visible = false;
                label20.Visible = false;
            }
            int a = 0;
            label16.Text = CreateOrder.Order.amount;
            label18.Text = CreateOrder.Order.deposit;
            if (CreateOrder.Order.deposit == "null")
            {
                label18.Visible = false;
                label17.Visible = false;
                a = Int32.Parse(label16.Text);

            }

            if (label18.Text != "null")
            {
                a = Int32.Parse(label16.Text) + Int32.Parse(label18.Text);

            }

            label19.Text = CreateOrder.Order.total;







        }


        public class Order
        {

            public static string orderId;
            public static string Payment;
            public static string customerID;
            public static string deliveryNo;
            public static string DeliveryDate;
            public static string InstallationDate;
            public static string amount;
            public static string deposit;




        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }
    }
}
