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

namespace ITP4915
{
	public partial class PurchaseMain : Form
	{
		string empID;
		string storeID;
		string position;
		string department;
		private Form activeForm;
		public PurchaseMain()
		{
			InitializeComponent();
		}

		public void OpenChildForm(Form childForm, object btnSender)
		{
			if (activeForm != null)
				activeForm.Close();
			//ActivateButton(btnSender);

			activeForm = childForm;
			childForm.TopLevel = false;
			childForm.FormBorderStyle = FormBorderStyle.None;
			childForm.Dock = DockStyle.Fill;
			this.panel4.Controls.Add(childForm);
			this.panel4.Tag = childForm;
			childForm.BringToFront();
			childForm.Show();
			//lblTitle.Text = childForm.Text;
		}

		private string getPosition()
		{
			return position;
		}

		internal void setPosition(string v)
		{
			position = v;
		}

		public string getEmpID()
		{
			return empID;
		}

		internal void setEmpID(string v)
		{
			empID = v;
		}

		internal void setstoreID(string v)
		{
			storeID = v;
		}

		private string getstoreID()
		{
			return storeID;
		}

		internal void setDepartment(string v)
		{
			department = v;
		}

		private string getDepartment()
		{
			return department;
		}

		private void PurchaseMain_Load(object sender, EventArgs e)
		{
	
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void buttonHome_Click(object sender, EventArgs e)
		{
			OpenChildForm(new Home(), sender);
		}

		private void buttonProfile_Click(object sender, EventArgs e)
		{
			profile p1 = new profile();
			p1.setEmpID(Convert.ToString(empID));
			DialogResult result = p1.ShowDialog();
		}

		private void closebutton_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void buttonViewReOrderRequest_Click(object sender, EventArgs e)
		{
			ViewReorderRequest.ID.EmpID = empID;
			ViewReorderRequest.ID.department = department;
			OpenChildForm(new ViewReorderRequest(), sender);
		}

		private void buttonPurchaseOrder_Click(object sender, EventArgs e)
		{
			viewPurchaseOrder.ID.EmpID = empID;
			viewPurchaseOrder.ID.department = department;
			OpenChildForm(new viewPurchaseOrder(), sender);
		}

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
