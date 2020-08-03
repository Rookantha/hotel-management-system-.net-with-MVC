using FireSharp.Response;
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

namespace Integrated_Projects
{
	public partial class EmployeeLogin : Form
	{
		ConnectServer server = new ConnectServer();
		public void Clear()//Clear all Form Fields after Registeing the User
		{
			cmbLogType.ResetText();
			cmbLogEmpID.ResetText();
			txtLogEmpMail.Clear(); ;
			txtLogEmpPass.Clear();
		}

		bool result;
		public bool Validate(string EmpLogID, string EmpMail, string EmpPassword, string EmpJobType)
		{
			
			if (EmpLogID != null && EmpMail != null && EmpPassword != null && EmpJobType != null)
			{
				result = true;
			}
			else if (EmpLogID == null || EmpMail == null || EmpPassword == null || EmpJobType == null)
			{
				MessageBox.Show("All Fields Must be Filled");
			}
			else if (EmpLogID == null)
			{
				MessageBox.Show("Employee ID is required to Login");
			}
			else if (EmpMail == null)
			{
				MessageBox.Show("Employee Mail is required to Login");
			}
			else if (EmpPassword == null)
			{
				MessageBox.Show("Password is required to Login");
			}
			else if (EmpJobType == null)
			{
				MessageBox.Show("Please select Your relavent Job Type");
			}
			return result;
		}


		void FillCombo_with_EmployeeID()
		{
			EmployeeRegisterLogin log = new EmployeeRegisterLogin();
			List<string> range = log.FillComboLoginID();
			foreach (string item in range)
			{
				cmbLogEmpID.Items.Add(item);
			}
		}

		public EmployeeLogin()
		{
			InitializeComponent();
			FillCombo_with_EmployeeID();
		}

		

		private void btnReset_Click(object sender, EventArgs e)
		{
			Clear();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			EmployeeRegisterLogin login = new EmployeeRegisterLogin();

			if (cmbLogEmpID.Text==""|| txtLogEmpMail.Text==""|| txtLogEmpPass.Text==""|| cmbLogType.Text=="")
			{
				MessageBox.Show("Fill All the Fields");
			}
			else if(cmbLogEmpID.Text != "" && txtLogEmpMail.Text != "" && txtLogEmpPass.Text != "" && cmbLogType.Text != "")
			{
				string Category = cmbLogType.Text;
				int EmpID = Convert.ToInt32(cmbLogEmpID.Text);
				string Mail = txtLogEmpMail.Text;
				string Password = txtLogEmpPass.Text;
				DateTime attendance = DateTime.Now;
				string EmpAttendace = attendance.ToString("yyyy-MM-dd");
				string Time = attendance.ToString("hh:mm:ss");

				if (chkAttendance.Checked)
				{
					login.Attendance(EmpID, EmpAttendace, Time);
				}

				if (login.EmployeeLogin(Category, Mail, Password))
				{
					if (Category == "Manager")
					{
						AdminArea admin = new AdminArea();
						this.Hide();
						admin.Show();
					}

					else if (Category == "Accountant")
					{
						AccounantArea account = new AccounantArea();
						this.Hide();
						account.Show();
					}

					if (Category == "Cashier")
					{
						Employee.Cashier cash = new Employee.Cashier();
						this.Hide();
						cash.Show();
					}

					else if (Category == "Chef")
					{
						ChefArea chef = new ChefArea();
						this.Hide();
						chef.Show();
					}

					else if (Category == "Delivery Agent")
					{
						DeliveryAgentArea agent = new DeliveryAgentArea();
						this.Hide();
						agent.Show();
					}
				}
			}
		}
		private void EmployeeLogin_Load(object sender, EventArgs e)
		{
			cmbLogType.SelectedIndex = 0;
		}

		private void txtLogEmpID_Click(object sender, EventArgs e)
		{
			//txtLogEmpID.Clear();
		}

		private void txtLogEmpMail_Click(object sender, EventArgs e)
		{
			txtLogEmpMail.Clear();
		}

		private void txtLogEmpPass_Click(object sender, EventArgs e)
		{
			txtLogEmpPass.Clear();
			txtLogEmpPass.PasswordChar = '*';
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
