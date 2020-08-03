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
	public partial class DeliveryAgentArea : Form
	{
		void FillCombo_withOrderID()
		{
			Orders orderIDFill = new Orders();
			List<string> range = orderIDFill.Fill_DeliveryOrderID();
			foreach (string item in range)
			{
				cmbOrderID.Items.Add(item);
			}
		}
		public DeliveryAgentArea()
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
			Tuple<string> result = ordValue.Deliver_IndexChangeSelection(cmbOrderID.Text, Date);
			txtTableID.Text = result.Item1;
			radioAgentNot.Checked = true;
		}

		private void btnDeliver_Click(object sender, EventArgs e)
		{
			Orders orderUpdate = new Orders();
			if (radioAgent.Checked == false)
			{
				MessageBox.Show("Please Check Delivery Status Before Continue");
			}
			else
			{
				orderUpdate.Update_Deliver_Order(Convert.ToInt32(cmbOrderID.Text));
				DeliveryAgentArea agent = new DeliveryAgentArea();
				cmbOrderID.ResetText();
				txtTableID.Clear();
				FillCombo_withOrderID();
				this.Dispose();
				agent.Show();
			}
		}
	}
}
