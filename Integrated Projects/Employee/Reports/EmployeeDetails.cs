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

namespace Integrated_Projects.Employee.Reports
{
	public partial class EmployeeDetails : Form
	{
		void FillComboID()//display Available employee ids in combobox list
		{
			SalaryCalculation calc = new SalaryCalculation();
			List<string> range = calc.FillComboID();
			foreach (string item in range)
			{
				cmbID.Items.Add(item);
			}
		}
		public EmployeeDetails()
		{
			InitializeComponent();
			FillComboID();
		}


		ReportGeneration employee = new ReportGeneration();
		private void btnBack_Click(object sender, EventArgs e)
		{
			AdminArea admin = new AdminArea();
			this.Dispose();
			admin.Show();
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			dataEmployee.DataSource = employee.GetListIndiviual(Convert.ToInt32(cmbID.Text));
		}

		private void btnAll_Click(object sender, EventArgs e)
		{
			cmbID.ResetText();
			dataEmployee.DataSource = employee.GetListAll();
		}
	}
}
