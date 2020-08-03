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
	public partial class AccounantArea : Form
	{
		public AccounantArea()
		{
			InitializeComponent();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			EmployeeLogin EmpLogin = new EmployeeLogin();
			this.Hide();
			EmpLogin.Show();
		}

		private void btnEmpRegister_Click(object sender, EventArgs e)
		{
			Payroll.PayrollHome home = new Payroll.PayrollHome();
			this.Hide();
			home.Show();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Income_Expenditure.Income income = new Income_Expenditure.Income();
			this.Hide();
			income.Show();
		}

		private void btnExpenditure_Click(object sender, EventArgs e)
		{
			Income_Expenditure.Expenditure expenses = new Income_Expenditure.Expenditure();
			this.Hide();
			expenses.Show();
		}

		private void btnProfit_Click(object sender, EventArgs e)
		{
			Income_Expenditure.Profits profit = new Income_Expenditure.Profits();
			this.Hide();
			profit.Show();
		}
	}
}
