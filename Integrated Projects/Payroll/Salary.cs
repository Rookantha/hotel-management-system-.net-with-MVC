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

namespace Integrated_Projects.Payroll
{
	public partial class Salary : Form
	{
		private void btnInsert_Click(object sender, EventArgs e)
		{
			SalaryCalculation calc = new SalaryCalculation();

			if (txtDaysWorked.Text == "" || txtEPF8.Text == "" || txtEPF12.Text == "" || txtETF3.Text == "" || txtFinal.Text == "")
			{
				MessageBox.Show("Press Calculate button before continue");
			}
			else
			{
				if (cmbEmpID.Text == "" ||  txtSalID.Text == "")
				{
					MessageBox.Show("Please Select Employee ID to Continue");
				}
				else
				{
					int EmpID = Convert.ToInt32(cmbEmpID.Text.Trim());
					DateTime date = DateTime.Now;
					string PaidDate = date.ToString("yyyy-MM-dd");
					string RawPaidDate = date.ToString("yyyy-MM");

					if (calc.CheckPaid(EmpID, RawPaidDate))
					{
						int SalID = Convert.ToInt32(txtSalID.Text.Trim());
						int DWork = Convert.ToInt32(txtDaysWorked.Text.Trim());
						double EPF8 = Convert.ToDouble(txtEPF8.Text.Trim());
						double EPF12 = Convert.ToDouble(txtEPF12.Text.Trim());
						double ETF3 = Convert.ToDouble(txtETF3.Text.Trim());
						double Salary = Convert.ToDouble(txtFinal.Text.Trim());
						calc.Insert_into_SalaryDatabase(SalID, EmpID, DWork, PaidDate, EPF8, EPF12, ETF3, Salary);
					}
					else
					{
						MessageBox.Show("Salary Already Paid for this Month");
					}
				}
				
			}
		}

		void SalaryID_Setup()
		{
			SalaryCalculation calc = new SalaryCalculation();
			txtSalID.Text = calc.SalaryID().ToString();
		}
		void FillCombo_with_EmployeeID()
		{
			SalaryCalculation calc = new SalaryCalculation();
			List<string> range = calc.FillComboID();
			foreach (string item in range)
			{
				cmbEmpID.Items.Add(item);
			}
		}
		void ClearText()
		{
			txtDaysWorked.Clear();
			txtFinal.Clear();
			txtEPF8.Clear();
			txtEPF12.Clear();
			txtETF3.Clear();
			txtAdvance.Clear();
			txtLoan.Clear();
		}
		public Salary()
		{
			InitializeComponent();
			FillCombo_with_EmployeeID();
		}


		private void btnBack_Click(object sender, EventArgs e)
		{
			PayrollHome home = new PayrollHome();
			this.Hide();
			home.Show();
		}

		private void cmbEmpID_SelectedIndexChanged(object sender, EventArgs e)
		{
			SalaryCalculation calc = new SalaryCalculation();
			Tuple<string, string, double> result = calc.IndexChange(cmbEmpID.Text);
			txtEmpName.Text = result.Item1;
			txtDesignation.Text = result.Item2;
			txtBasicSal.Text = result.Item3.ToString();
			ClearText();
			SalaryID_Setup();
		}

		private void btnCalculate_Click(object sender, EventArgs e)
		{
			SalaryCalculation calc = new SalaryCalculation();
			string Date = monthCalendar1.SelectionRange.Start.ToString("yyyy-MM");
			Tuple<int,double,double,double,double,double,double> resultcalculated = calc.CalculateSalary(cmbEmpID.Text, Date);
			txtDaysWorked.Text = resultcalculated.Item1.ToString();
			txtFinal.Text = resultcalculated.Item2.ToString();
			txtEPF8.Text = resultcalculated.Item3.ToString();
			txtEPF12.Text = resultcalculated.Item4.ToString();
			txtETF3.Text = resultcalculated.Item5.ToString();
			txtAdvance.Text = resultcalculated.Item6.ToString();
			txtLoan.Text = resultcalculated.Item7.ToString();
		}

		private void Salary_Load(object sender, EventArgs e)
		{
			
		}
	}
}
