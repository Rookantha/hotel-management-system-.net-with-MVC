using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integrated_Projects.Payroll
{
	public partial class PayrollHome : Form
	{
		public PayrollHome()
		{
			InitializeComponent();
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			AccounantArea account = new AccounantArea();
			this.Hide();
			account.Show();
		}

		private void btnAdvance_Click(object sender, EventArgs e)
		{
			Advances_Loans advance = new Advances_Loans();
			this.Hide();
			advance.Show();
		}

		private void btnSalary_Click(object sender, EventArgs e)
		{
			Salary salary = new Salary();
			this.Hide();
			salary.Show();
		}

		private void btnLoanSettle_Click(object sender, EventArgs e)
		{
			PayLoanAdvance pay = new PayLoanAdvance();
			this.Hide();
			pay.Show();
		}
	}
}
