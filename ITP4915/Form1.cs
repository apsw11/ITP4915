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
	public partial class Form1 : Form
	{
		int empID;

		public Form1()
		{
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			profile p1 = new profile();
			p1.setEmpID(Convert.ToString(empID));
			DialogResult result = p1.ShowDialog();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			labelEmpID.Text ="Employee ID:" + Convert.ToString ( getEmpID());
		}

		private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			ViewSalesOrder view = new ViewSalesOrder();
			view.ShowDialog();

		}

		private int getEmpID()
		{
			return empID;
		}

		internal void setEmpID(string v)
		{
			empID = int.Parse(v);
		}

	}
}
