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
using System.Globalization;

namespace Integrated_Projects
{
	public partial class EmployeeRegistration : Form
	{
		ConnectServer server = new ConnectServer();
		public void Clear()//Clear all Form Fields after Registeing the User
		{
			txtEmpFullname.Clear();
			txtEmail.Clear(); ;
			txtEmpNIC.Clear(); ;
			txtEmpContact.Clear(); ;
			cmbEmpJobCategory.ResetText();
			txtEmpPassword.Clear();
			txtEmpRePassword.Clear();
			txtEmpID.Clear();
			txtSalary.Clear();
		}
		public EmployeeRegistration()
		{
			InitializeComponent();
		}

		private void btnEmployeeLogin_Click(object sender, EventArgs e)//Take User to the Login Form
		{
			AdminArea admin = new AdminArea();
			this.Hide();
			admin.Show();
		}

		private void btnEmplyeeRegistration_Click(object sender, EventArgs e)//Register User in the Database
		{
			EmployeeRegisterLogin register = new EmployeeRegisterLogin();
			int EmpID = Convert.ToInt32(txtEmpID.Text.Trim());
			string EmpName = txtEmpFullname.Text.Trim();
			string EmpEmail = txtEmail.Text.Trim();
			string EmpNIC = txtEmpNIC.Text.Trim();
			string EmpContact = txtEmpContact.Text.Trim();
			string EmpCategory = cmbEmpJobCategory.Text.Trim();
			string EmpPassword = txtEmpPassword.Text.Trim();
			double Salary = Convert.ToDouble(txtSalary.Text.Trim());
			DateTime EmpJoin = DateTime.Now;
			string EmpJoinDate = EmpJoin.ToString("yyyy-MM-dd");

			if (txtEmpID.Text == "" || txtEmpFullname.Text == "" || txtEmpFullname.Text == "" || txtEmail.Text == "" || txtEmpNIC.Text == "" || txtEmpContact.Text == "" || cmbEmpJobCategory.Text == "" || txtEmpPassword.Text == "" || txtSalary.Text == "")
			{
				MessageBox.Show("Fill All Feilds With Relavant Details");
			}
			else if (txtEmpPassword.Text != txtEmpRePassword.Text)
			{
				MessageBox.Show("Two Passwords Doesn't Match");
			}
			else
			{
				register.EmployeeRegistration(EmpID, EmpName, EmpEmail, EmpNIC, EmpContact, EmpCategory, EmpJoinDate, EmpPassword, Salary);
			}
			Clear();
		}

		private void txtEmpID_Click(object sender, EventArgs e)
		{
			txtEmpID.Clear();
		}

		private void txtEmpFullname_Click(object sender, EventArgs e)
		{
			txtEmpFullname.Clear();
		}

		private void txtEmail_Click(object sender, EventArgs e)
		{
			txtEmail.Clear();
		}

		private void txtEmpNIC_Click(object sender, EventArgs e)
		{
			txtEmpNIC.Clear();
		}

		private void txtEmpContact_Click(object sender, EventArgs e)
		{
			txtEmpContact.Clear();
		}

		private void txtSalary_Click(object sender, EventArgs e)
		{
			txtSalary.Clear();
		}

		private void txtEmpPassword_Click(object sender, EventArgs e)
		{
			txtEmpPassword.Clear();
			txtEmpPassword.PasswordChar = '*';
		}

		private void txtEmpRePassword_Click(object sender, EventArgs e)
		{
			txtEmpRePassword.Clear();
			txtEmpRePassword.PasswordChar = '*';
		}
	}
}
