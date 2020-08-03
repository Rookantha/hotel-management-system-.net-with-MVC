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
	public partial class Expenditure : Form
	{
		ConnectServer server = new ConnectServer();
		static int count = 0;

		void ExpenseIDSetup()
		{
			IncomeExpenditure expense = new IncomeExpenditure();
			txtExpensesID.Text = expense.ExpenseID().ToString();
		}
		public Expenditure()
		{
			InitializeComponent();
			ExpenseIDSetup();
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			AccounantArea accountant = new AccounantArea();
			this.Hide();
			accountant.Show();
		}

		private void btnInsert_Click(object sender, EventArgs e)
		{
			IncomeExpenditure expense = new IncomeExpenditure();
			

			if (txtExpensesID.Text == "" || txtExpenseAmount.Text == "" || txtExpenseDescription.Text == "")
			{
				MessageBox.Show("Text Feilds Cannot Be Empty.!");
			}
			else
			{
				int ExpID = Convert.ToInt32(txtExpensesID.Text.Trim());
				double ExpAmount = Convert.ToDouble(txtExpenseAmount.Text.Trim());
				string ExpDesc = txtExpenseDescription.Text.Trim();
				DateTime EmpJoin = DateTime.Now;
				string ExpDate = EmpJoin.ToString("yyyy-MM-dd");
				expense.Insert_Expenditure(ExpID, ExpDate, ExpAmount, ExpDesc);
			}

			ExpenseIDSetup();
			txtExpenseAmount.Clear();
			txtExpenseDescription.Clear();
		}
	}
}
