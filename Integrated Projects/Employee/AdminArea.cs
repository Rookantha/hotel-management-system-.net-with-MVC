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
	public partial class AdminArea : Form
	{
		public AdminArea()
		{
			InitializeComponent();
		}

		private void btnEmpRegister_Click(object sender, EventArgs e)
		{
			EmployeeRegistration EmpRegistration = new EmployeeRegistration();
			this.Hide();
			EmpRegistration.Show();
		}

		private void btnLogout_Click(object sender, EventArgs e)
		{

			EmployeeLogin EmpLogin = new EmployeeLogin();
			this.Hide();
			EmpLogin.Show();
		}

		private void btnEmployeeDetails_Click(object sender, EventArgs e)
		{
			Employee.Reports.EmployeeDetails dataEmployee = new Employee.Reports.EmployeeDetails();
			this.Hide();
			dataEmployee.Show();
		}

		private void btnSalaryDetails_Click(object sender, EventArgs e)
		{
			Employee.Reports.SalaryDetails salary = new Employee.Reports.SalaryDetails();
			this.Hide();
			salary.Show();
		}

		private void btnReports_Click(object sender, EventArgs e)
		{
			Employee.Reports.ProfitabilityDetails profit = new Employee.Reports.ProfitabilityDetails();
			this.Hide();
			profit.Show();
		}
	}
}
