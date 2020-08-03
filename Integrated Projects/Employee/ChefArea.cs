using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integrated_Projects
{
	public partial class ChefArea : Form
	{
		void FillCombo_withOrderID()
		{
			Orders orderIDFill = new Orders();
			List<string> range = orderIDFill.Fill_CookOrderID();
			foreach (string item in range)
			{
				cmbOrderID.Items.Add(item);
			}
		}
		public ChefArea()
		{
			InitializeComponent();
			FillCombo_withOrderID();
		}

		private void btnLogout_Click(object sender, EventArgs e)
		{
			EmployeeLogin login = new EmployeeLogin();
			this.Hide();
			login.Show();
		}

		private void cmbOrderID_SelectedIndexChanged(object sender, EventArgs e)
		{
			DateTime today = DateTime.Now;
			string Date = today.ToString("yyyy-MM-dd");
			Orders ordValue = new Orders();
			Tuple<string> result = ordValue.CookIndexChangeSelection(cmbOrderID.Text,Date);
			richTextBox1.Text = result.Item1;
			radioNotFin.Checked=true;
		}

		private void btnDeliver_Click(object sender, EventArgs e)
		{
			Orders orderUpdate = new Orders();

			if (radioFin.Checked == false)
			{
				MessageBox.Show("Please Check Cook Status Before Continue");
			}
			else
			{
				orderUpdate.Update_Cook_Order(Convert.ToInt32(cmbOrderID.Text));
				ChefArea chef = new ChefArea();
				cmbOrderID.ResetText();
				richTextBox1.Clear();
				FillCombo_withOrderID();
				this.Dispose();
				chef.Show();
			}	
		}
	}
}
