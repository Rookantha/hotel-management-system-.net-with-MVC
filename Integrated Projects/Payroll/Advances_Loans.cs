using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using MySql.Data.MySqlClient;

namespace Integrated_Projects.Payroll
{
	public partial class Advances_Loans : Form
	{
		public Advances_Loans()
		{
			InitializeComponent();
			FillComboID();
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			PayrollHome home = new PayrollHome();
			this.Hide();
			home.Show();
		}

		private void btnInsert_Click(object sender, EventArgs e)
		{
			AdvanceLoan advance = new AdvanceLoan();
			if (cmbEmpID.Text == "" || txtEmpName.Text == "" || cmbType.Text == "")
			{
				MessageBox.Show("Fill Required Fields");
			}
			else
			{
				string Type = cmbType.Text.Trim();
				int EmpID = Convert.ToInt32(cmbEmpID.Text.Trim());
				DateTime grantdate = DateTime.Now;
				string Date = grantdate.ToString("yyyy-MM-dd");
				if (cmbType.Text == "Advance" && txtAdvanceAmount.Text == "")
				{
					MessageBox.Show("Advance Amount Field cannot be Null");
				}
				else if (cmbType.Text == "Advance" && txtAdvanceAmount.Text != "")
				{
					double AdvanceAmount = Convert.ToDouble(txtAdvanceAmount.Text);
					advance.Insert_Advance(Type, EmpID, AdvanceAmount, Date);
				}

				else if (cmbType.Text == "Loan" && txtLoanAmount.Text == "" && txtMonths.Text=="")
				{
					MessageBox.Show("Loan Amount Field cannot be Null");
				}

				else if (cmbType.Text == "Loan" && txtLoanAmount.Text != "" && txtMonths.Text != "")
				{
					double LoanAmount = Convert.ToDouble(txtLoanAmount.Text);
					int TimePeriod = Convert.ToInt32(txtMonths.Text.Trim());
					advance.Insert_Loan(Type, EmpID, LoanAmount, TimePeriod, Date);
				}
			}
		}

		private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				txtLoanAmount.Enabled = false;
				txtAdvanceAmount.Enabled = false;
				txtMonths.Enabled = false;
				if (cmbType.Text == "Advance")
				{
					txtAdvanceAmount.Enabled = true;
					txtLoanAmount.Enabled = false;
					txtMonths.Enabled = false;

				}
				else if (cmbType.Text == "Loan")
				{
					txtAdvanceAmount.Enabled = false;
					txtLoanAmount.Enabled = true;
					txtMonths.Enabled = true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("" + ex.Message);
			}
		}

		void FillComboID()//display Available employee ids in combobox list
		{
			SalaryCalculation calc = new SalaryCalculation();
			List<string> range = calc.FillComboID();
			foreach (string item in range)
			{
				cmbEmpID.Items.Add(item);
			}
		}
		private void cmbEmpID_SelectedIndexChanged(object sender, EventArgs e)
		{
			AdvanceLoan advance = new AdvanceLoan();
			txtEmpName.Text = advance.EmployeeName(Convert.ToInt32(cmbEmpID.Text));
		}

		private void Advances_Loans_Load(object sender, EventArgs e)
		{
			txtAdvanceAmount.Enabled = false;
			txtLoanAmount.Enabled = false;
			txtMonths.Enabled = false;
		}
	}
}
