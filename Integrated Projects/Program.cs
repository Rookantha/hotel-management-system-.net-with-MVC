using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using FireSharp;
using MySql.Data.MySqlClient;
using System.Data;

namespace Integrated_Projects
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new EmployeeLogin());
		}
	}



	class ConnectServer//serever connection settings
	{
		
		MySqlConnection connection = new MySqlConnection("datasource = 127.0.0.1; port=3306;username=root;password=;database=hotelramadhadb;SslMode=none;");
		public MySqlConnection ConPass()//pass Parameters
		{
			return connection;
		}
		public void ConnOpen()//Open Xampp Server connection
		{
			connection.Open();
		}
		public void ConnClose()//Close Xampp Server connection
		{
			connection.Close();
		}
	}

	class SalaryCalculation
	{
		string Name, Category;
		double Salary, EPF8, EPF12, ETF3, FinalSalary, BasicSalary;
		double LoanAmount, AdvanceAmount, Advance, AdvancePaid, AdvanceRemain;
		double Loan, LoanPaid, LoanRemain;
		int Period,MaxID,ResultCount;
		bool result;


		ConnectServer server = new ConnectServer();
		
		public bool CheckPaid(int EmpID, string Date)
		{
			try
			{
				server.ConnOpen();
				string query = "SELECT count(EmpID) FROM salary WHERE(EmpID = '"+EmpID+ "' and PayedDate LIKE \'" + Date + "%\')";
				MySqlCommand command = new MySqlCommand(query, server.ConPass());
				ResultCount = Convert.ToInt32(command.ExecuteScalar());
			}
			catch (Exception ex)
			{
				MessageBox.Show("" + ex.Message);
			}
			server.ConnClose();
			if (ResultCount == 1)
			{
				result = false;
			}
			else if (ResultCount == 0)
			{
				result = true;
			}
			
			return result;
		}
		public int SalaryID()
		{
			try
			{
				server.ConnOpen();
				MySqlCommand command = new MySqlCommand("select max(SalID) from salary", server.ConPass());
				MaxID = Convert.ToInt32(command.ExecuteScalar());
				MaxID++;
			}
			catch (Exception ex)
			{
				MessageBox.Show("" + ex.Message);
			}
			server.ConnClose();
			return MaxID;
		}
		

		public List<string> FillComboID()
		{
			
			List<string> Range = new List<string>();

			server.ConnOpen();
			string query = "select * from employee where JobCategory!='Manager'";
			MySqlCommand command = new MySqlCommand(query, server.ConPass());
			MySqlDataReader dtread;
			try
			{
				dtread = command.ExecuteReader();
				while (dtread.Read())
				{
					Range.Add(dtread.GetString("EmpID"));
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show("" + ex.Message);
			}
			server.ConnClose();
			return Range;
		}

		public Tuple<string, string, double> IndexChange(string EmployeeID)
		{
			server.ConnOpen();
			string query = "select * from employee where EmpID='" + EmployeeID + "'";
			MySqlCommand command = new MySqlCommand(query, server.ConPass());
			MySqlDataReader dtread;
			try
			{
				dtread = command.ExecuteReader();
				while (dtread.Read())
				{
					Name = (dtread["FullName"].ToString());
					Category = (dtread["JobCategory"].ToString());
					Salary = Convert.ToDouble(dtread["Salary"].ToString());
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("" + ex.Message);
			}
			server.ConnClose();
			var result = Tuple.Create(Name, Category, Salary);
			return result;
		}

		public Tuple<int, double, double, double, double, double, double> CalculateSalary(string EmployeeID, string Date)
		{
			MySqlCommand command;
			MySqlDataReader dtread;

			int count = 0;
			try
			{
				server.ConnOpen();
				string query = "SELECT count(EmpID) FROM attendance WHERE(EmpID ='" + EmployeeID + "' AND Date LIKE \'" + Date + "%\')";
				command = new MySqlCommand(query, server.ConPass());
				count = Convert.ToInt32(command.ExecuteScalar());
			}
			catch (Exception ex)
			{
				MessageBox.Show("" + ex.Message);
			}
			server.ConnClose();

			try
			{
				server.ConnOpen();
				string query = "select * from Advance_Loan where  (EmpID = '" + EmployeeID + "' and Type='Loan')";
				command = new MySqlCommand(query, server.ConPass());
				dtread = command.ExecuteReader();
				if (dtread.Read())
				{
					Loan = double.Parse(dtread["AmountRetrived"].ToString());
					LoanPaid = double.Parse(dtread["AmountPaid"].ToString());
					Period = int.Parse(dtread["PeriodMonths"].ToString());
				}
				LoanRemain = Loan - LoanPaid;
			}
			catch (Exception ex)
			{
				MessageBox.Show("" + ex.Message);
			}
			server.ConnClose();


			try
			{
				server.ConnOpen();
				string query = "select * from employee where EmpID = '" + EmployeeID +"'";
				command = new MySqlCommand(query, server.ConPass());
				dtread = command.ExecuteReader();
				if (dtread.Read())
				{
					BasicSalary = double.Parse(dtread["Salary"].ToString());
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("" + ex.Message);
			}
			server.ConnClose();


			try
			{
				server.ConnOpen();
				string query = "select * from Advance_Loan where  (EmpID = '" + EmployeeID + "'and Type='Advance')";
				command = new MySqlCommand(query, server.ConPass());
				dtread = command.ExecuteReader();
				if (dtread.Read())
				{
					Advance = double.Parse(dtread["AmountRetrived"].ToString());
					AdvancePaid = double.Parse(dtread["AmountPaid"].ToString());
				}
				AdvanceRemain = Advance - AdvancePaid;
			}
			catch (Exception ex)
			{
				MessageBox.Show("" + ex.Message);
			}
			server.ConnClose();
			EPF8 = (BasicSalary * 8 / 100);
			EPF12 = (BasicSalary * 12 / 100);
			ETF3 = (BasicSalary * 3 / 100);
			var resultcalc = Tuple.Create(count,CalculateFinalSalary(count),EPF8,EPF12,ETF3, Advance,Loan);
			return resultcalc;

		}

		public double CalculateFinalSalary(int counter)
		{
			if (counter > 20)
			{
				EPF8 = (BasicSalary) * 8 / 100;
				EPF12 = (BasicSalary) * 12 / 100;
				ETF3 = (BasicSalary) * 3 / 100;
				FinalSalary = BasicSalary - AdvanceAmount - LoanAmount - EPF8 - EPF12 - ETF3;
			}
			else if (counter < 20)//2% deduction from the final Salary
			{
				double semifinal;
				EPF8 = (BasicSalary) * 8 / 100;
				EPF12 = (BasicSalary) * 12 / 100;
				ETF3 = (BasicSalary) * 3 / 100;
				semifinal = BasicSalary - AdvanceAmount - LoanAmount - EPF8 - EPF12 - ETF3;
				FinalSalary = semifinal - ((semifinal) * 2 / 100);
			}

			return FinalSalary;
		}

		public void Insert_into_SalaryDatabase(int SalID,int EmpID,int DWork,string PaidDate,double EPF8, double EPF12, double ETF3, double Salary)
		{
			try
			{
				server.ConnOpen();
				string query = "insert into salary () values('" + SalID + "','" + EmpID + "','" + DWork + "','" + PaidDate + "','" + EPF8 + "','" + EPF12 + "','" + ETF3 + "','" + Salary + "')";
				MySqlCommand cmd = new MySqlCommand(query, server.ConPass());
				cmd.ExecuteNonQuery();
				MessageBox.Show("Salary Details Inserted Successfully..!");
			}
			catch (Exception ex)
			{
				MessageBox.Show("error caught please contact the developers" + ex.Message);
			}
			server.ConnClose();
		}
	}

	class AdvanceLoan
	{
		ConnectServer server = new ConnectServer();
		string Name, status;
		int Installments;
		double Loaned;

		public string EmployeeName(int EmpID)
		{

			server.ConnOpen();
			string query = "select * from employee where EmpID='" + EmpID + "'";
			MySqlCommand command = new MySqlCommand(query, server.ConPass());
			MySqlDataReader dtread;
			try
			{
				dtread = command.ExecuteReader();
				while (dtread.Read())
				{
					Name = (dtread["FullName"].ToString());
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("" + ex.Message);
			}
			server.ConnClose();
			return Name;
		}
		public void Insert_Advance(string Type, int EmpID, double AdvanceAmount, string Date)
		{
			try
			{
				server.ConnOpen();
				string query = "insert into Advance_Loan(EmpID,Date,AmountRetrived,Type) values('" + EmpID + "','" + Date + "','" + AdvanceAmount + "','" + Type + "')";
				MySqlCommand cmd = new MySqlCommand(query, server.ConPass());
				cmd.ExecuteNonQuery();
				MessageBox.Show("Advance Granted..!");
			}
			catch (Exception ex)
			{
				MessageBox.Show(""+ex.Message);
			}
			server.ConnClose();
		}

		public void Insert_Loan(string Type, int EmpID, double LoanAmount, int TimePeriod, string Date)
		{
			try
			{
				server.ConnOpen();
				string query = "select * from Advance_Loan where  (EmpID = '" + EmpID + "' and Type='Loan')";
				MySqlCommand command = new MySqlCommand(query, server.ConPass());
				MySqlDataReader dtread = command.ExecuteReader();
				if (dtread.Read())
				{
					status = (dtread["Status"].ToString());
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("" + ex.Message);
			}
			server.ConnClose();
			if (status == "Not Paid")
			{
				MessageBox.Show("Loan Already Taken..! \n Cannot Grant Again");
			}
			else
			{
				try
				{
					server.ConnOpen();
					string query1 = "insert into Advance_Loan(EmpID,Date,PeriodMonths,AmountRetrived,Type) values('" + EmpID + "','" + Date + "','" + TimePeriod + "','" + LoanAmount + "','" + Type + "')";
					MySqlCommand cmd = new MySqlCommand(query1, server.ConPass());
					cmd.ExecuteNonQuery();
					MessageBox.Show("Loan Granted..!");
				}
				catch (Exception ex)
				{
					MessageBox.Show("" + ex.Message);
				}
				server.ConnClose();
			}
		}
			
		public void Update_Loan(int EmpID,int NewInstall,double NewLoan)
		{
			try
			{
				server.ConnOpen();
				string query = "update advance_loan set PeriodMonths='" + NewInstall + "',AmountPaid='" + NewLoan + "' where EmpID='" + EmpID + "'";
				MySqlCommand command = new MySqlCommand(query, server.ConPass());
				command.ExecuteNonQuery();
				MessageBox.Show("Updated Sucessfully\n");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Oops: Something went wrong with the DB Connection Please try again\n\n" + ex.Message);
			}
			server.ConnClose();
			if (NewInstall == 0)
			{
				try
				{
					server.ConnOpen();
					string query = "update advance_loan set Status='Paid' where EmpID='" + EmpID + "'";
					MySqlCommand command = new MySqlCommand(query, server.ConPass());
					command.ExecuteNonQuery();
					MessageBox.Show("Loan Fully Settled");
				}
				catch (Exception ex)
				{
					MessageBox.Show("Oops: Something went wrong with the DB Connection Please try again\n\n" + ex.Message);
				}
				server.ConnClose();
			}
		}
		public List<string> FillComboID()
		{

			List<string> Range = new List<string>();

			server.ConnOpen();
			string query = "select * from advance_loan where Type='Loan' and Status!='Paid'";
			MySqlCommand command = new MySqlCommand(query, server.ConPass());
			MySqlDataReader dtread;
			try
			{
				dtread = command.ExecuteReader();
				while (dtread.Read())
				{
					Range.Add(dtread.GetString("EmpID"));
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show("" + ex.Message);
			}
			server.ConnClose();
			return Range;
		}

		public Tuple<int, double> IndexChange(string EmployeeID)
		{
			server.ConnOpen();
			string query = "select * from advance_loan where (EmpID='" + EmployeeID + "')";
			MySqlCommand command = new MySqlCommand(query, server.ConPass());
			MySqlDataReader dtread;
			try
			{
				dtread = command.ExecuteReader();
				while (dtread.Read())
				{
					Installments = Convert.ToInt32(dtread["PeriodMonths"].ToString());
					Loaned = Convert.ToDouble(dtread["AmountRetrived"].ToString());
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("" + ex.Message);
			}
			server.ConnClose();

			var result = Tuple.Create(Installments, Loaned);
			return result;
		}

	}

	class EmployeeRegisterLogin
	{
		ConnectServer server = new ConnectServer();
		public void EmployeeRegistration(int EmpID,string EmpName ,string EmpEmail ,string EmpNIC , string EmpContact , string EmpCategory , string EmpJoinDate , string EmpPassword ,double Salary)
		{
			try
			{
				server.ConnOpen();
				string query = "insert into employee () values('" + EmpID + "','" + EmpName + "','" + EmpEmail + "','" + EmpNIC + "','" + EmpContact + "','" + EmpCategory + "','" + EmpJoinDate + "','" + EmpPassword + "','" + Salary + "')";
				MySqlCommand cmd = new MySqlCommand(query, server.ConPass());
				cmd.ExecuteNonQuery();
				MessageBox.Show("Employee "+EmpName+" have successfully registered..!");
			}
			catch (Exception ex)
			{
				MessageBox.Show("error caught please contact the developers" + ex.Message);
			}
			server.ConnClose();
		}

		bool ret_result;
		public bool EmployeeLogin(string Type, string Mail, string Password)
		{
			try
			{
				server.ConnOpen();
				string query = "select * from employee where JobCategory='" + Type + "' and Email='" + Mail + "' and Password='" + Password + "'";
				MySqlDataAdapter adp = new MySqlDataAdapter(query, server.ConPass());
				DataTable dt = new DataTable();
				adp.Fill(dt);
				if (dt.Rows.Count == 1)
				{
					MessageBox.Show("Access Granted..!");
					ret_result = true;
				}
				else
				{
					MessageBox.Show("Access Denied..\n UserName or Password Incorrect..\n Please Try Again..!");
					ret_result = false;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Oops: Something went wrong with the DB Connection Please try again\n" + ex.Message);
			}
			server.ConnClose();
			return ret_result;
		}

		public void Attendance(int EmpID, string Date, string Time)
		{
			try
			{
				server.ConnOpen();
				string query = "insert into attendance () values('" + EmpID + "','" + Date + "','" + Time + "')";
				MySqlCommand cmd = new MySqlCommand(query, server.ConPass());
				cmd.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Cannot Mark Attendance Two Times a Day \n" + ex.Message);
			}
			server.ConnClose();
		}

		public List<string> FillComboLoginID()
		{

			List<string> Range = new List<string>();

			server.ConnOpen();
			string query = "select * from employee";
			MySqlCommand command = new MySqlCommand(query, server.ConPass());
			MySqlDataReader dtread;
			try
			{
				dtread = command.ExecuteReader();
				while (dtread.Read())
				{
					Range.Add(dtread.GetString("EmpID"));
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show("" + ex.Message);
			}
			server.ConnClose();
			return Range;
		}
	}

	class IncomeExpenditure
	{
		int MaxIncome, MaxExpense, MaxProfit, ResultCount;
		bool result;
		ConnectServer server = new ConnectServer();


		//Income
		public int IncomeID()
		{
			try
			{
				server.ConnOpen();
				MySqlCommand command = new MySqlCommand("select max(IncomeID) from incomes", server.ConPass());
				MaxIncome = Convert.ToInt32(command.ExecuteScalar());
				MaxIncome++;
			}
			catch (Exception ex)
			{
				MessageBox.Show("" + ex.Message);
			}
			server.ConnClose();
			return MaxIncome;
		}

		public void Insert_Income(int IncID, string IncDate, double IncAmount,string IncDesc)
		{
			try
			{
				server.ConnOpen();
				string query = "insert into Incomes () values('" + IncID + "','" + IncDate + "','" + IncAmount + "','" + IncDesc + "',null)";
				MySqlCommand cmd = new MySqlCommand(query, server.ConPass());
				cmd.ExecuteNonQuery();
				MessageBox.Show("Income Insereted..!");
			}
			catch (Exception ex)
			{
				MessageBox.Show("error caught please contact the developers" + ex.Message);
			}
			server.ConnClose();
		}

		//Expense
		public int ExpenseID()
		{
			try
			{
				server.ConnOpen();
				MySqlCommand command = new MySqlCommand("select max(ExpensesID) from expenses", server.ConPass());
				MaxExpense = Convert.ToInt32(command.ExecuteScalar());
				MaxExpense++;
			}
			catch (Exception ex)
			{
				MessageBox.Show("" + ex.Message);
			}
			server.ConnClose();
			return MaxExpense;
		}

		public void Insert_Expenditure(int ExpID, string ExpDate, double ExpAmount,string ExpDesc)
		{
			try
			{
				server.ConnOpen();
				string query = "insert into Expenses () values('" + ExpID + "','" + ExpDate + "','" + ExpAmount + "','" + ExpDesc + "')";
				MySqlCommand cmd = new MySqlCommand(query, server.ConPass());
				cmd.ExecuteNonQuery();
				MessageBox.Show("Expenditure Insereted...!");
			}
			catch (Exception ex)
			{
				MessageBox.Show("error caught please contact the developers" + ex.Message);
			}
			server.ConnClose();
		}


		//Profit
		public int ProfitID()
		{
			try
			{
				server.ConnOpen();
				MySqlCommand command = new MySqlCommand("select max(ProLossID) from profit_loss", server.ConPass());
				MaxProfit = Convert.ToInt32(command.ExecuteScalar());
				MaxProfit++;
			}
			catch (Exception ex)
			{
				MessageBox.Show("" + ex.Message);
			}
			server.ConnClose();
			return MaxProfit;
		}

		public bool CheckInserted(string Date)
		{
			try
			{
				server.ConnOpen();
				string query = "SELECT count(YearMonth) FROM profit_loss WHERE(YearMonth LIKE \'" + Date + "%\')";
				MySqlCommand command = new MySqlCommand(query, server.ConPass());
				ResultCount = Convert.ToInt32(command.ExecuteScalar());
			}
			catch (Exception ex)
			{
				MessageBox.Show("" + ex.Message);
			}
			server.ConnClose();
			if (ResultCount == 1)
			{
				result = false;
			}
			else if (ResultCount == 0)
			{
				result = true;
			}

			return result;
		}

		public void Insert_Profit(int PLID,string Category,string Date,double Amount)
		{
			try
			{
				server.ConnOpen();
				string query = "insert into profit_loss () values('" + PLID + "','" + Category + "','" + Date + "','" + Amount +"')";
				MySqlCommand cmd = new MySqlCommand(query, server.ConPass());
				cmd.ExecuteNonQuery();
				MessageBox.Show("Profit/Loss Details Inserted Successfully..!");
			}
			catch (Exception ex)
			{
				MessageBox.Show("error caught please contact the developers" + ex.Message);
			}
			server.ConnClose();
		}

		double Income, Expense;
		public Tuple<double, double,int> Check_Profit(string Date)
		{
			try
			{
				server.ConnOpen();
				string query = "SELECT SUM(IncomeAmount) FROM incomes WHERE(Date LIKE \'" + Date + "%\')";
				MySqlCommand command = new MySqlCommand(query, server.ConPass());
				Income = Convert.ToDouble(command.ExecuteScalar());
			}
			catch (Exception ex)
			{
				MessageBox.Show("" + ex.Message);
			}
			server.ConnClose();

			try
			{
				server.ConnOpen();
				string query = "SELECT SUM(ExpenseAmount) FROM Expenses WHERE(Date LIKE \'" + Date + "%\')";
				MySqlCommand command = new MySqlCommand(query, server.ConPass());
				Expense = Convert.ToDouble(command.ExecuteScalar());
			}
			catch (Exception ex)
			{
				MessageBox.Show("" + ex.Message);
			}
			server.ConnClose();
			var result = Tuple.Create(Income, Expense, ProfitID());
			return result;
		}
	}

	class Orders
	{
		int IncomeID,MaxOrdID;
		void IncomeIDSetup()
		{
			IncomeExpenditure income = new IncomeExpenditure();
			IncomeID = income.IncomeID();
		}
		
		ConnectServer server = new ConnectServer();

		//Cashier
		int OrderID;
		public int OrdID()
		{
			try
			{
				server.ConnOpen();
				MySqlCommand command = new MySqlCommand("select max(OrderID) from Orders", server.ConPass());
				MaxOrdID = Convert.ToInt32(command.ExecuteScalar());
				MaxOrdID++;
			}
			catch (Exception ex)
			{
				MessageBox.Show("" + ex.Message);
			}
			server.ConnClose();
			return MaxOrdID;
		}
		public void InsertOrder(string Description, string Date, string Time,string Table)
		{
			OrderID = OrdID();
			try
			{
				server.ConnOpen();
				string query = "insert into orders (OrderID,Description,Date,Time,TableNo) values('" + OrderID + "','" + Description + "','" + Date + "','" + Time+"','"+Table+"')";
				MySqlCommand cmd = new MySqlCommand(query, server.ConPass());
				cmd.ExecuteNonQuery();
				MessageBox.Show("Ordered Successfully..!");
			}
			catch (Exception ex)
			{
				MessageBox.Show("error caught please contact the developers" + ex.Message);
			}
			server.ConnClose();
		}
		
		//Insert Income
		public void InsertOrderIncome(double TotalAmount, string Date)
		{
			try
			{
				IncomeIDSetup();
				server.ConnOpen();
				string query = "insert into incomes (IncomeID,Date,IncomeAmount,Description,OrderID) values('" + IncomeID + "','" + Date + "','" + TotalAmount + "','Sales','" + OrderID + "')";
				MySqlCommand cmd = new MySqlCommand(query, server.ConPass());
				cmd.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				MessageBox.Show("error caught please contact the developers" + ex.Message);
			}
			server.ConnClose();
		}

		//Cook
		public List<string> Fill_CookOrderID()
		{

			List<string> Range = new List<string>();
			DateTime day = DateTime.Now;
			string Date = day.ToString("yyyy-MM-dd");
			server.ConnOpen();
			string query = "select * from orders where (CookStatus='Not Cooked' and Date='" + Date+"')";
			MySqlCommand command = new MySqlCommand(query, server.ConPass());
			MySqlDataReader dtread;
			try
			{
				dtread = command.ExecuteReader();
				while (dtread.Read())
				{
					Range.Add(dtread.GetString("OrderID"));
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show("" + ex.Message);
			}
			server.ConnClose();
			return Range;
		}
		string Description;
		public Tuple<string> CookIndexChangeSelection(string OrderID,string Date)
		{
			server.ConnOpen();
			string query = "select * from orders where OrderID='" + OrderID + "' and Date='"+Date+"'";
			MySqlCommand command = new MySqlCommand(query, server.ConPass());
			MySqlDataReader dtread;
			try
			{
				dtread = command.ExecuteReader();
				while (dtread.Read())
				{
					Description = (dtread["Description"].ToString());
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("" + ex.Message);
			}
			server.ConnClose();
			var result = Tuple.Create(Description);
			return result;
		}
		public void Update_Cook_Order(int OrderID)
		{
			DateTime day = DateTime.Now;
			string Date = day.ToString("yyyy-MM-dd");
			try
			{
				server.ConnOpen();
				string query = "update orders set CookStatus='Cooked' where (OrderID='" + OrderID + "' and Date='"+Date+ "')";
				MySqlCommand command = new MySqlCommand(query, server.ConPass());
				command.ExecuteNonQuery();
				MessageBox.Show("Order "+OrderID+" is Ready to Deliver\n");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Oops: Something went wrong with the DB Connection Please try again\n\n" + ex.Message);
			}
			server.ConnClose();
		}

		//DA
		public List<string> Fill_DeliveryOrderID()
		{

			List<string> Range = new List<string>();
			DateTime day = DateTime.Now;
			string Date = day.ToString("yyyy-MM-dd");
			server.ConnOpen();
			string query = "select * from orders where (DeliverStatus='Not Delivered' and CookStatus='Cooked' and Date='" + Date + "')";
			MySqlCommand command = new MySqlCommand(query, server.ConPass());
			MySqlDataReader dtread;
			try
			{
				dtread = command.ExecuteReader();
				while (dtread.Read())
				{
					Range.Add(dtread.GetString("OrderID"));
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show("" + ex.Message);
			}
			server.ConnClose();
			return Range;
		}
		string TableID;
		public Tuple<string> Deliver_IndexChangeSelection(string OrderID, string Date)
		{
			server.ConnOpen();
			string query = "select * from orders where OrderID='" + OrderID + "' and Date='" + Date + "'";
			MySqlCommand command = new MySqlCommand(query, server.ConPass());
			MySqlDataReader dtread;
			try
			{
				dtread = command.ExecuteReader();
				while (dtread.Read())
				{
					TableID = (dtread["TableNo"].ToString());
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("" + ex.Message);
			}
			server.ConnClose();
			var result = Tuple.Create(TableID);
			return result;
		}
		public void Update_Deliver_Order(int OrderID)
		{
			DateTime day = DateTime.Now;
			string Date = day.ToString("yyyy-MM-dd");
			try
			{
				server.ConnOpen();
				string query = "update orders set DeliverStatus='Delivered' where (OrderID='" + OrderID + "' and Date='" + Date + "')";
				MySqlCommand command = new MySqlCommand(query, server.ConPass());
				command.ExecuteNonQuery();
				MessageBox.Show("Order " + OrderID + " is Delivered\n");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Oops: Something went wrong with the DB Connection Please try again\n\n" + ex.Message);
			}
			server.ConnClose();
		}
	}

	class ReportGeneration
	{
		ConnectServer server = new ConnectServer();

		//Salary Data
		public DataTable GetSalaryListIndividual(int EmpID)
		{
			DataTable dt = new DataTable();
			string query = "select * from salary where EmpID='" + EmpID + "'";
			try
			{
				server.ConnOpen();
				MySqlCommand command = new MySqlCommand(query, server.ConPass());
				MySqlDataReader red = command.ExecuteReader();
				dt.Load(red);
			}
			catch (Exception ex)
			{
				MessageBox.Show("" + ex.Message);
			}
			server.ConnClose();

			return dt;
		}
		public DataTable GetSalaryListMonth(string Date)
		{
			DataTable dt = new DataTable();
			string query = "select * from salary where PayedDate LIKE \'" + Date + "%\'";
			try
			{
				server.ConnOpen();
				MySqlCommand command = new MySqlCommand(query, server.ConPass());
				MySqlDataReader red = command.ExecuteReader();
				dt.Load(red);
			}
			catch (Exception ex)
			{
				MessageBox.Show("" + ex.Message);
			}
			server.ConnClose();

			return dt;
		}
		public DataTable GetSalaryListYear()
		{
			DataTable dt = new DataTable();
			string query = "select * from salary";
			try
			{
				server.ConnOpen();
				MySqlCommand command = new MySqlCommand(query, server.ConPass());
				MySqlDataReader red = command.ExecuteReader();
				dt.Load(red);
			}
			catch (Exception ex)
			{
				MessageBox.Show("" + ex.Message);
			}
			server.ConnClose();

			return dt;
		}


		//Employee Data
		public DataTable GetListAll()
		{
			DataTable dt = new DataTable();
			string query = "select * from Employee where JobCategory!='Manager'";
			try
			{
				server.ConnOpen();
				MySqlCommand command = new MySqlCommand(query, server.ConPass());
				MySqlDataReader red = command.ExecuteReader();
				dt.Load(red);
			}
			catch (Exception ex)
			{
				MessageBox.Show("" + ex.Message);
			}
			server.ConnClose();

			return dt;
		}
		public DataTable GetListIndiviual(int EmpID)
		{
			DataTable dt = new DataTable();
			string query = "select * from Employee where EmpID='"+ EmpID + "'";
			try
			{
				server.ConnOpen();
				MySqlCommand command = new MySqlCommand(query, server.ConPass());
				MySqlDataReader red = command.ExecuteReader();
				dt.Load(red);
			}
			catch (Exception ex)
			{
				MessageBox.Show("" + ex.Message);
			}
			server.ConnClose();

			return dt;
		}


		//Profitability Data
		public DataTable GetIncomeListYear()
		{
			DataTable dt = new DataTable();
			string query = "select * from incomes";
			try
			{
				server.ConnOpen();
				MySqlCommand command = new MySqlCommand(query, server.ConPass());
				MySqlDataReader red = command.ExecuteReader();
				dt.Load(red);
			}
			catch (Exception ex)
			{
				MessageBox.Show("" + ex.Message);
			}
			server.ConnClose();

			return dt;
		}
		public DataTable GetExpenseListYear()
		{
			DataTable dt = new DataTable();
			string query = "select * from expenses";
			try
			{
				server.ConnOpen();
				MySqlCommand command = new MySqlCommand(query, server.ConPass());
				MySqlDataReader red = command.ExecuteReader();
				dt.Load(red);
			}
			catch (Exception ex)
			{
				MessageBox.Show("" + ex.Message);
			}
			server.ConnClose();

			return dt;
		}
		public DataTable GetProfitListYear()
		{
			DataTable dt = new DataTable();
			string query = "select * from profit_loss";
			try
			{
				server.ConnOpen();
				MySqlCommand command = new MySqlCommand(query, server.ConPass());
				MySqlDataReader red = command.ExecuteReader();
				dt.Load(red);
			}
			catch (Exception ex)
			{
				MessageBox.Show("" + ex.Message);
			}
			server.ConnClose();

			return dt;
		}

		public DataTable GetIncomeListMonth(string Date)
		{
			DataTable dt = new DataTable();
			string query = "select * from incomes where Date LIKE \'" + Date + "%\'";
			try
			{
				server.ConnOpen();
				MySqlCommand command = new MySqlCommand(query, server.ConPass());
				MySqlDataReader red = command.ExecuteReader();
				dt.Load(red);
			}
			catch (Exception ex)
			{
				MessageBox.Show("" + ex.Message);
			}
			server.ConnClose();

			return dt;
		}
		public DataTable GetExpenseListMonth(string Date)
		{
			DataTable dt = new DataTable();
			string query = "select * from expenses where Date LIKE \'" + Date + "%\'";
			try
			{
				server.ConnOpen();
				MySqlCommand command = new MySqlCommand(query, server.ConPass());
				MySqlDataReader red = command.ExecuteReader();
				dt.Load(red);
			}
			catch (Exception ex)
			{
				MessageBox.Show("" + ex.Message);
			}
			server.ConnClose();

			return dt;
		}
		public DataTable GetProfitListMonth(string Date)
		{
			DataTable dt = new DataTable();
			string query = "select * from profit_loss where YearMonth='" + Date + "'";
			try
			{
				server.ConnOpen();
				MySqlCommand command = new MySqlCommand(query, server.ConPass());
				MySqlDataReader red = command.ExecuteReader();
				dt.Load(red);
			}
			catch (Exception ex)
			{
				MessageBox.Show("" + ex.Message);
			}
			server.ConnClose();

			return dt;
		}
	}
}


