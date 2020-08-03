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

namespace Integrated_Projects.Income_Expenditure
{
	public partial class Profits : Form
	{
		ConnectServer server = new ConnectServer();

		int ProID;
		void ProfitIDSetup()
		{
			IncomeExpenditure profit = new IncomeExpenditure();
			ProID = profit.ProfitID();
		}
		public Profits()
		{
			InitializeComponent();
			ProfitIDSetup();
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			AccounantArea accountant = new AccounantArea();
			this.Hide();
			accountant.Show();
		}

		double ProLoss;
		int ProfitID;
		string Date;

		private void btnCalculate_Click(object sender, EventArgs e)
		{
			IncomeExpenditure profit = new IncomeExpenditure();
			Date = monthCalendarIncome.SelectionRange.Start.ToString("yyyy-MM");
			Tuple<double, double,int> result = profit.Check_Profit(Date);
			txtMonthIncome.Text = result.Item1.ToString();
			txtMonthExpense.Text = result.Item2.ToString();
			ProfitID = result.Item3;
			txtPLoss.Text = (result.Item1 - result.Item2).ToString();
			ProLoss = (result.Item1 - result.Item2);
		}


		string Type;
		private void button1_Click(object sender, EventArgs e)
		{
			IncomeExpenditure check = new IncomeExpenditure();
			if (ProLoss > 0)
			{
				Type = "Profit";
			}
			else
			{
				Type = "Loss";
			}

			if (txtMonthIncome.Text == "" || txtMonthExpense.Text == "" || txtPLoss.Text == "")
			{
				MessageBox.Show("Text Fields Cannot Be Empty");
			}
			else
			{
				if (check.CheckInserted(Date))
				{
					check.Insert_Profit(ProfitID,Type,Date,ProLoss);

					txtPLoss.Clear();
					txtMonthIncome.Clear();
					txtMonthExpense.Clear();
				}
				else
				{
					MessageBox.Show("Calculations Already Inserted for this Month");
				}
			}
		}

		private void btnPrint_Click(object sender, EventArgs e)
		{

		}
	}
}
