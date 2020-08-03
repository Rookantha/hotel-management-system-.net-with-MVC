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
	public partial class Income : Form
	{
		ConnectServer server = new ConnectServer();

		void IncomeIDSetup()
		{
			IncomeExpenditure income = new IncomeExpenditure();
			txtIncomeID.Text = income.IncomeID().ToString();
		}
		public Income()
		{
			InitializeComponent();
			IncomeIDSetup();
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			AccounantArea accountant = new AccounantArea();
			this.Hide();
			accountant.Show();
		}

		private void btnInsert_Click(object sender, EventArgs e)
		{
			IncomeExpenditure income = new IncomeExpenditure();
			if (txtIncomeID.Text=="" ||txtIncomeValue.Text==""||txtDescription.Text=="")
			{
				MessageBox.Show("Text Feilds Cannot Be Empty.!");
			}
			else
			{
				int IncID = Convert.ToInt32(txtIncomeID.Text.Trim());
				double IncAmount = Convert.ToDouble(txtIncomeValue.Text.Trim());
				string IncDesc = txtDescription.Text.Trim();
				DateTime Income = DateTime.Now;
				string IncDate = Income.ToString("yyyy-MM-dd");
				income.Insert_Income(IncID,IncDate,IncAmount,IncDesc);
			}

			IncomeIDSetup();
			txtDescription.Clear();
			txtIncomeValue.Clear();
		}
	}
}
