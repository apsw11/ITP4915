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
	public partial class TechnicalSupport : Form
	{
		string empID;
		string storeID;
		string position;
		private Form activeForm;

		public TechnicalSupport()
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

		private void TechnicalSupport_Load(object sender, EventArgs e)
		{
			labelEmp.Text = "Employee ID:" + empID;
			if (getPosition() == "Manager")
			{ //判斷顯示 Modify Item
				buttonMody.Visible = true;
			}

			DailyDeliveryList.ID.EmpID = empID;
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void buttonProfile_Click(object sender, EventArgs e)
		{
			profile p1 = new profile();
			p1.setEmpID(Convert.ToString(empID));
			DialogResult result = p1.ShowDialog();
		}

		private void buttonMody_Click(object sender, EventArgs e)
		{
			DailyInstallationList.ID.EmpID = empID;
			OpenChildForm(new DailyInstallationList(), sender);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			OpenChildForm(new ModifyInstallation(), sender);
		}

		private void buttonHome_Click(object sender, EventArgs e)
		{
			OpenChildForm(new Home(), sender);
		}

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
