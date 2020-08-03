using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Integrated_Projects.Employee.Reports
{
	public partial class SalaryDetails : Form
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
		public SalaryDetails()
		{
			InitializeComponent();
			FillComboID();
		}


		ReportGeneration salary = new ReportGeneration();

		private void btnBack_Click(object sender, EventArgs e)
		{
			AdminArea admin = new AdminArea();
			this.Dispose();
			admin.Show();
		}

		private void cmbID_SelectedIndexChanged(object sender, EventArgs e)
		{
			dataSalaryView.ClearSelection();
			dataSalaryView.DataSource = salary.GetSalaryListIndividual(Convert.ToInt32(cmbID.Text));
		}

		private void btnMonthSalary_Click(object sender, EventArgs e)
		{
			cmbID.ResetText();
			string Date = monthSalary.SelectionRange.Start.ToString("yyyy-MM");
			dataSalaryView.ClearSelection();
			dataSalaryView.DataSource = salary.GetSalaryListMonth(Date);
		}

		private void btnAllSalary_Click(object sender, EventArgs e)
		{
			cmbID.ResetText();
			dataSalaryView.ClearSelection();
			dataSalaryView.DataSource = salary.GetSalaryListYear();
		}


		private void btnPrint_Click(object sender, EventArgs e)
		{
		}

		private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
		}

		private void printPreviewDialog1_Load(object sender, EventArgs e)
		{

		}
	}
}
