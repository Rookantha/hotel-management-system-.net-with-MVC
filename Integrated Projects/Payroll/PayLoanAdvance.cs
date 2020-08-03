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
	public partial class PayLoanAdvance : Form
	{
		void FillComboID()
		{
			AdvanceLoan Advance = new AdvanceLoan();
			List<string> range = Advance.FillComboID();
			foreach (string item in range)
			{
				cmbEmpID.Items.Add(item);
			}
		}
		public PayLoanAdvance()
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

		private void cmbEmpID_SelectedIndexChanged(object sender, EventArgs e)
		{
			AdvanceLoan Advance = new AdvanceLoan();
			Tuple<int, double> result = Advance.IndexChange(cmbEmpID.Text);
			txtInstallment.Text = result.Item1.ToString();
			txtLoanAmount.Text = result.Item2.ToString();
		}

		double Payments;
		private void btnCheck_Click(object sender, EventArgs e)
		{
			if (txtLoanPayNow.Text == "")
			{
				MessageBox.Show("Please enter Paying Installment Count");
			}
			else
			{
				int install = Convert.ToInt32(txtInstallment.Text);//12
				double loan = Convert.ToDouble(txtLoanAmount.Text);//12000
				int Payinstall = Convert.ToInt32(txtLoanPayNow.Text);//2
				double oneinstall = Convert.ToDouble(loan / install);//1000
				Payments = Convert.ToDouble(Payinstall * oneinstall);//1
				double newLoan = loan - Payments;
				int newInstall = install - Payinstall;
				txtRemain.Text = newInstall.ToString();
				txtLoanRemain.Text = newLoan.ToString();
			}
			
		}

		private void btnInsert_Click(object sender, EventArgs e)
		{
			AdvanceLoan advance = new AdvanceLoan();
			if (txtLoanRemain.Text=="" || txtRemain.Text == "")
			{
				MessageBox.Show("Press Check button before continue");
			}
			else
			{
				advance.Update_Loan(Convert.ToInt32(cmbEmpID.Text), Convert.ToInt32(txtRemain.Text), Payments);
			}
			
			cmbEmpID.ResetText();
			txtInstallment.Clear();
			txtLoanAmount.Clear();
			txtLoanPayNow.Clear();
			txtLoanRemain.Clear();
			txtRemain.Clear();
		}
	}
}
