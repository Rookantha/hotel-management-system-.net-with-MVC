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

namespace Integrated_Projects.Employee.Reports
{
	public partial class ProfitabilityDetails : Form
	{
		public ProfitabilityDetails()
		{
			InitializeComponent();
		}



		private void btnBack_Click(object sender, EventArgs e)
		{
			AdminArea admin = new AdminArea();
			this.Dispose();
			admin.Show();
		}

		private void cmbID_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		ReportGeneration incoming = new ReportGeneration();
		private void btnAll_Click(object sender, EventArgs e)
		{
			dataIncome.ClearSelection();
			dataExpense.ClearSelection();
			dataProfitability.ClearSelection();
			dataIncome.DataSource = incoming.GetIncomeListYear();
			dataExpense.DataSource = incoming.GetExpenseListYear();
			dataProfitability.DataSource = incoming.GetProfitListYear();
		}

		private void btnMonth_Click(object sender, EventArgs e)
		{
			string Date = monthprofit.SelectionRange.Start.ToString("yyyy-MM");
			dataIncome.ClearSelection();
			dataExpense.ClearSelection();
			dataProfitability.ClearSelection();
			dataIncome.DataSource = incoming.GetIncomeListMonth(Date);
			dataExpense.DataSource = incoming.GetExpenseListMonth(Date);
			dataProfitability.DataSource = incoming.GetProfitListMonth(Date);
		}
	}
}
