using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integrated_Projects.Employee
{
	public partial class Cashier : Form
	{
		public Cashier()
		{
			InitializeComponent();
			InitializeMenu1();
			InitializeMenu2();
			InitializeMenu3();
			InitializeMenu4();
			InitializeMenu5();
			InitializeMenu6();
			InitializeMenu7();
			InitializeMenu8();
			InitializeMenu9();
			InitializeMenu10();
			InitializeMenu11();
			InitializeMenu12();
		}

		private void btnLogout_Click(object sender, EventArgs e)
		{
			EmployeeLogin login = new EmployeeLogin();
			this.Hide();
			login.Show();
		}

		double menu1=0.0, menu2 = 0.0, menu3 = 0.0, menu4 = 0.0, menu5 = 0.0, menu6 = 0.0;
		double menu7 = 0.0, menu8 = 0.0, menu9 = 0.0, menu10 = 0.0, menu11 = 0.0, menu12 = 0.0;
		double menu1Price, menu2Price, menu3Price, menu4Price, menu5Price, menu6Price;
		double menu7Price, menu8Price, menu9Price, menu10Price, menu11Price, menu12Price;
		string Order1, Order2, Order3, Order4, Order5, Order6, Order7, Order8, Order9, Order10, Order11, Order12, newline;
		
		//Menu1
		void InitializeMenu1()
		{
			if (cmbQty1.Text == "")
			{
				btnMenu1.Enabled = false;
				btnMenu1.BackColor = Color.Red;
				btnCancel1.Enabled = false;
				btnCancel1.BackColor = Color.Red;
			}
		}
		private void cmbQty1_SelectedIndexChanged_1(object sender, EventArgs e)
		{
			if (cmbQty1.Text != "")
			{
				btnMenu1.Enabled = true;
				btnMenu1.BackColor = Color.Lime;
				btnCancel1.Enabled = true;
				btnCancel1.BackColor = Color.Yellow;
			}
		}
		private void btnMenu1_Click_1(object sender, EventArgs e)
		{
			btnMenu1.Enabled = true;
			double unitPrice = Convert.ToDouble(lblPrice1.Text);
			int Quantity = Convert.ToInt32(cmbQty1.Text);
			menu1Price = unitPrice * Quantity;
			menu1 = menu1Price;
			Order1 = "Item : " + lblID1.Text + "\n	 Qty : " + Quantity;
			Sum();
		}
		private void btnCancel1_Click_1(object sender, EventArgs e)
		{
			double CurrentTotal = Sum();
			txtTotalPrice.Text = (CurrentTotal - menu1Price).ToString();
			cmbQty1.ResetText();
			InitializeMenu1();
			Order1 = "";
		}


		//Menu2
		void InitializeMenu2()
		{
			if (cmbQty2.Text == "")
			{
				btnMenu2.Enabled = false;
				btnMenu2.BackColor = Color.Red;
				btnCancel2.Enabled = false;
				btnCancel2.BackColor = Color.Red;
			}
		}
		private void cmbQty2_SelectedIndexChanged_1(object sender, EventArgs e)
		{
			if (cmbQty2.Text != "")
			{
				btnMenu2.Enabled = true;
				btnMenu2.BackColor = Color.Lime;
				btnCancel2.Enabled = true;
				btnCancel2.BackColor = Color.Yellow;
			}
		}
		private void btnMenu2_Click_1(object sender, EventArgs e)
		{
			btnMenu2.Enabled = true;
			double unitPrice = Convert.ToDouble(lblPrice2.Text);
			int Quantity = Convert.ToInt32(cmbQty2.Text);
			menu2Price = unitPrice * Quantity;
			menu2 = menu2Price;
			Order2 = "Item : " + lblID2.Text + "\n	 Qty : " + Quantity;
			Sum();
		}
		private void btnCancel2_Click_1(object sender, EventArgs e)
		{
			double CurrentTotal = Sum();
			txtTotalPrice.Text = (CurrentTotal - menu2Price).ToString();
			cmbQty2.ResetText();
			InitializeMenu2();
			Order2 = "";
		}


		//Menu3
		void InitializeMenu3()
		{
			if (cmbQty3.Text == "")
			{
				btnMenu3.Enabled = false;
				btnMenu3.BackColor = Color.Red;
				btnCancel3.Enabled = false;
				btnCancel3.BackColor = Color.Red;
			}
		}
		private void cmbQty3_SelectedIndexChanged_1(object sender, EventArgs e)
		{
			if (cmbQty3.Text != "")
			{
				btnMenu3.Enabled = true;
				btnMenu3.BackColor = Color.Lime;
				btnCancel3.Enabled = true;
				btnCancel3.BackColor = Color.Yellow;
			}
		}
		private void btnMenu3_Click_1(object sender, EventArgs e)
		{
			btnMenu3.Enabled = true;
			double unitPrice = Convert.ToDouble(lblPrice3.Text);
			int Quantity = Convert.ToInt32(cmbQty3.Text);
			menu3Price = unitPrice * Quantity;
			menu3 = menu3Price;
			Order3 = "Item : " + lblID3.Text + "\n	 Qty : " + Quantity;
			Sum();
		}
		private void btnCancel3_Click_1(object sender, EventArgs e)
		{
			double CurrentTotal = Sum();
			txtTotalPrice.Text = (CurrentTotal - menu3Price).ToString();
			cmbQty3.ResetText();
			InitializeMenu3();
			Order3 = "";
		}


		//Menu4
		void InitializeMenu4()
		{
			if (cmbQty4.Text == "")
			{
				btnMenu4.Enabled = false;
				btnMenu4.BackColor = Color.Red;
				btnCancel4.Enabled = false;
				btnCancel4.BackColor = Color.Red;
			}
		}
		private void cmbQty4_SelectedIndexChanged_1(object sender, EventArgs e)
		{
			if (cmbQty4.Text != "")
			{
				btnMenu4.Enabled = true;
				btnMenu4.BackColor = Color.Lime;
				btnCancel4.Enabled = true;
				btnCancel4.BackColor = Color.Yellow;
			}
		}
		private void btnMenu4_Click_1(object sender, EventArgs e)
		{
			btnMenu4.Enabled = true;
			double unitPrice = Convert.ToDouble(lblPrice4.Text);
			int Quantity = Convert.ToInt32(cmbQty4.Text);
			menu4Price = unitPrice * Quantity;
			menu4 = menu4Price;
			Order4 = "Item : " + lblID4.Text + "\n	 Qty : " + Quantity;
			Sum();
		}
		private void btnCancel4_Click_1(object sender, EventArgs e)
		{
			double CurrentTotal = Sum();
			txtTotalPrice.Text = (CurrentTotal - menu4Price).ToString();
			cmbQty4.ResetText();
			InitializeMenu4();
			Order4 = "";
		}


		//Menu5
		void InitializeMenu5()
		{
			if (cmbQty5.Text == "")
			{
				btnMenu5.Enabled = false;
				btnMenu5.BackColor = Color.Red;
				btnCancel5.Enabled = false;
				btnCancel5.BackColor = Color.Red;
			}
		}
		private void cmbQty5_SelectedIndexChanged_1(object sender, EventArgs e)
		{
			if (cmbQty5.Text != "")
			{
				btnMenu5.Enabled = true;
				btnMenu5.BackColor = Color.Lime;
				btnCancel5.Enabled = true;
				btnCancel5.BackColor = Color.Yellow;
			}
		}
		private void btnMenu5_Click_1(object sender, EventArgs e)
		{
			btnMenu5.Enabled = true;
			double unitPrice = Convert.ToDouble(lblPrice5.Text);
			int Quantity = Convert.ToInt32(cmbQty5.Text);
			menu5Price = unitPrice * Quantity;
			menu5 = menu5Price;
			Order5 = "Item : " + lblID5.Text + "\n	 Qty : " + Quantity;
			Sum();
		}

		private void btnCancel5_Click_1(object sender, EventArgs e)
		{
			double CurrentTotal = Sum();
			txtTotalPrice.Text = (CurrentTotal - menu5Price).ToString();
			cmbQty5.ResetText();
			InitializeMenu5();
			Order5 = "";
		}


		//Menu6
		void InitializeMenu6()
		{
			if (cmbQty6.Text == "")
			{
				btnMenu6.Enabled = false;
				btnMenu6.BackColor = Color.Red;
				btnCancel6.Enabled = false;
				btnCancel6.BackColor = Color.Red;
			}
		}
		private void cmbQty6_SelectedIndexChanged_1(object sender, EventArgs e)
		{
			if (cmbQty6.Text != "")
			{
				btnMenu6.Enabled = true;
				btnMenu6.BackColor = Color.Lime;
				btnCancel6.Enabled = true;
				btnCancel6.BackColor = Color.Yellow;
			}
		}
		private void btnMenu6_Click_1(object sender, EventArgs e)
		{
			btnMenu6.Enabled = true;
			double unitPrice = Convert.ToDouble(lblPrice6.Text);
			int Quantity = Convert.ToInt32(cmbQty6.Text);
			menu6Price = unitPrice * Quantity;
			menu6 = menu6Price;
			Order6 = "Item : " + lblID6.Text + "\n	 Qty : " + Quantity;
			Sum();
		}
		private void btnCancel6_Click_1(object sender, EventArgs e)
		{
			double CurrentTotal = Sum();
			txtTotalPrice.Text = (CurrentTotal - menu6Price).ToString();
			cmbQty6.ResetText();
			InitializeMenu6();
			Order6 = "";
		}


		//menu7
		void InitializeMenu7()
		{
			if (cmbQty6.Text == "")
			{
				btnMenu7.Enabled = false;
				btnMenu7.BackColor = Color.Red;
				btnCancel7.Enabled = false;
				btnCancel7.BackColor = Color.Red;
			}
		}
		private void cmbQty7_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cmbQty7.Text != "")
			{
				btnMenu7.Enabled = true;
				btnMenu7.BackColor = Color.Lime;
				btnCancel7.Enabled = true;
				btnCancel7.BackColor = Color.Yellow;
			}
		}
		private void btnMenu7_Click(object sender, EventArgs e)
		{
			btnMenu7.Enabled = true;
			double unitPrice = Convert.ToDouble(lblPrice7.Text);
			int Quantity = Convert.ToInt32(cmbQty7.Text);
			menu7Price = unitPrice * Quantity;
			menu7 = menu7Price;
			Order7 = "Item : " + lblID7.Text + "\n	 Qty : " + Quantity;
			Sum();
		}
		private void btnCancel7_Click(object sender, EventArgs e)
		{
			double CurrentTotal = Sum();
			txtTotalPrice.Text = (CurrentTotal - menu7Price).ToString();
			cmbQty7.ResetText();
			InitializeMenu7();
			Order7 = "";
		}

		//menu8
		void InitializeMenu8()
		{
			if (cmbQty8.Text == "")
			{
				btnMenu8.Enabled = false;
				btnMenu8.BackColor = Color.Red;
				btnCancel8.Enabled = false;
				btnCancel8.BackColor = Color.Red;
			}
		}
		private void cmbQty8_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cmbQty8.Text != "")
			{
				btnMenu8.Enabled = true;
				btnMenu8.BackColor = Color.Lime;
				btnCancel8.Enabled = true;
				btnCancel8.BackColor = Color.Yellow;
			}
		}
		private void btnMenu8_Click(object sender, EventArgs e)
		{
			btnMenu8.Enabled = true;
			double unitPrice = Convert.ToDouble(lblPrice8.Text);
			int Quantity = Convert.ToInt32(cmbQty8.Text);
			menu8Price = unitPrice * Quantity;
			menu8 = menu8Price;
			Order8 = "Item : " + lblID8.Text + "\n	 Qty : " + Quantity;
			Sum();
		}
		private void btnCancel8_Click(object sender, EventArgs e)
		{
			double CurrentTotal = Sum();
			txtTotalPrice.Text = (CurrentTotal - menu8Price).ToString();
			cmbQty8.ResetText();
			InitializeMenu8();
			Order8 = "";
		}


		//menu9
		void InitializeMenu9()
		{
			if (cmbQty9.Text == "")
			{
				btnMenu9.Enabled = false;
				btnMenu9.BackColor = Color.Red;
				btnCancel9.Enabled = false;
				btnCancel9.BackColor = Color.Red;
			}
		}
		private void cmbQty9_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cmbQty9.Text != "")
			{
				btnMenu9.Enabled = true;
				btnMenu9.BackColor = Color.Lime;
				btnCancel9.Enabled = true;
				btnCancel9.BackColor = Color.Yellow;
			}
		}
		private void btnMenu9_Click(object sender, EventArgs e)
		{
			btnMenu9.Enabled = true;
			double unitPrice = Convert.ToDouble(lblPrice9.Text);
			int Quantity = Convert.ToInt32(cmbQty9.Text);
			menu9Price = unitPrice * Quantity;
			menu9 = menu9Price;
			Order9 = "Item : " + lblID9.Text + "\n	 Qty : " + Quantity;
			Sum();
		}
		private void btnCancel9_Click(object sender, EventArgs e)
		{
			double CurrentTotal = Sum();
			txtTotalPrice.Text = (CurrentTotal - menu9Price).ToString();
			cmbQty9.ResetText();
			InitializeMenu9();
			Order9 = "";
		}


		//menu10
		void InitializeMenu10()
		{
			if (cmbQty10.Text == "")
			{
				btnMenu10.Enabled = false;
				btnMenu10.BackColor = Color.Red;
				btnCancel10.Enabled = false;
				btnCancel10.BackColor = Color.Red;
			}
		}
		private void cmbQty10_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cmbQty10.Text != "")
			{
				btnMenu10.Enabled = true;
				btnMenu10.BackColor = Color.Lime;
				btnCancel10.Enabled = true;
				btnCancel10.BackColor = Color.Yellow;
			}
		}
		private void btnMenu10_Click(object sender, EventArgs e)
		{
			btnMenu10.Enabled = true;
			double unitPrice = Convert.ToDouble(lblPrice10.Text);
			int Quantity = Convert.ToInt32(cmbQty10.Text);
			menu10Price = unitPrice * Quantity;
			menu10 = menu10Price;
			Order10 = "Item : " + lblID10.Text + "\n	 Qty : " + Quantity;
			Sum();
		}
		private void btnCancel10_Click(object sender, EventArgs e)
		{
			double CurrentTotal = Sum();
			txtTotalPrice.Text = (CurrentTotal - menu10Price).ToString();
			cmbQty10.ResetText();
			InitializeMenu10();
			Order10 = "";
		}


		//menu11
		void InitializeMenu11()
		{
			if (cmbQty11.Text == "")
			{
				btnMenu11.Enabled = false;
				btnMenu11.BackColor = Color.Red;
				btnCancel11.Enabled = false;
				btnCancel11.BackColor = Color.Red;
			}
		}
		private void cmbQty11_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cmbQty11.Text != "")
			{
				btnMenu11.Enabled = true;
				btnMenu11.BackColor = Color.Lime;
				btnCancel11.Enabled = true;
				btnCancel11.BackColor = Color.Yellow;
			}
		}
		private void btnMenu11_Click(object sender, EventArgs e)
		{
			btnMenu11.Enabled = true;
			double unitPrice = Convert.ToDouble(lblPrice11.Text);
			int Quantity = Convert.ToInt32(cmbQty11.Text);
			menu11Price = unitPrice * Quantity;
			menu11 = menu11Price;
			Order11 = "Item : " + lblID11.Text + "\n	 Qty : " + Quantity;
			Sum();
		}
		private void btnCancel11_Click(object sender, EventArgs e)
		{
			double CurrentTotal = Sum();
			txtTotalPrice.Text = (CurrentTotal - menu11Price).ToString();
			cmbQty11.ResetText();
			InitializeMenu11();
			Order11 = "";
		}


		//menu12
		void InitializeMenu12()
		{
			if (cmbQty12.Text == "")
			{
				btnMenu12.Enabled = false;
				btnMenu12.BackColor = Color.Red;
				btnCancel12.Enabled = false;
				btnCancel12.BackColor = Color.Red;
			}
		}
		private void cmbQty12_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cmbQty12.Text != "")
			{
				btnMenu12.Enabled = true;
				btnMenu12.BackColor = Color.Lime;
				btnCancel12.Enabled = true;
				btnCancel12.BackColor = Color.Yellow;
			}
		}
		private void btnMenu12_Click(object sender, EventArgs e)
		{
			btnMenu12.Enabled = true;
			double unitPrice = Convert.ToDouble(lblPrice12.Text);
			int Quantity = Convert.ToInt32(cmbQty12.Text);
			menu12Price = unitPrice * Quantity;
			menu12 = menu12Price;
			Order12 = "Item : " + lblID12.Text + "\n	 Qty : " + Quantity;
			Sum();
		}
		private void btnCancel12_Click(object sender, EventArgs e)
		{
			double CurrentTotal = Sum();
			txtTotalPrice.Text = (CurrentTotal - menu12Price).ToString();
			cmbQty12.ResetText();
			InitializeMenu12();
			Order12 = "";
		}

		public double Sum()
		{
			double Total = menu1 + menu2 + menu3 + menu4 + menu5 + menu6+ menu7 + menu8 + menu9 + menu10 + menu11 + menu12;
			txtTotalPrice.Text = Total.ToString();
			return Total;
		}

		double TotalAmount;
		private void txtPayAmount_TextChanged(object sender, EventArgs e)
		{
			txtBalance.Text = (Convert.ToDouble(txtPayAmount.Text) - Convert.ToDouble(txtTotalPrice.Text)).ToString();
		}

		private void btnNewOrder_Click(object sender, EventArgs e)
		{
			Cashier cash = new Cashier();
			Clear();
			this.Dispose();
			cash.Show();
		}

		private void txtOrder_Click(object sender, EventArgs e)
		{
			Orders passOrder = new Orders();
			if (cmbTableNo.Text == "" || txtTotalPrice.Text == "")
			{
				MessageBox.Show("Please Select Table Number and Item to Order");
			}
			else
			{
				string Date, Time;
				TotalAmount = Convert.ToDouble(txtTotalPrice.Text);
				DateTime GetDateTime = DateTime.Now;
				Date = GetDateTime.ToString("yyyy-MM-dd");
				Time = GetDateTime.ToString("HH:MM:SS");
				string Table = cmbTableNo.Text;
				string Description = Order1 + "\n" + Order2 + "\n" + Order3 + "\n" + Order4 + "\n" + Order5 + "\n" + Order6 + "\n"
				+ Order7 + "\n" + Order8 + "\n" + Order9 + "\n" + Order10 + "\n" + Order11 + "\n" + Order12;
				passOrder.InsertOrder(Description, Date, Time, Table);
				passOrder.InsertOrderIncome(TotalAmount, Date);
			}

			
		}
		public void Clear()
		{
			cmbTableNo.ResetText();
			txtTotalPrice.Clear();
			cmbQty1.ResetText();
			cmbQty2.ResetText();
			cmbQty3.ResetText();
			cmbQty4.ResetText();
			cmbQty5.ResetText();
			cmbQty6.ResetText();
			cmbQty7.ResetText();
			cmbQty8.ResetText();
			cmbQty9.ResetText();
			cmbQty10.ResetText();
			cmbQty11.ResetText();
			cmbQty12.ResetText();
			InitializeMenu1();
			InitializeMenu2();
			InitializeMenu3();
			InitializeMenu4();
			InitializeMenu5();
			InitializeMenu6();
			InitializeMenu7();
			InitializeMenu8();
			InitializeMenu9();
			InitializeMenu10();
			InitializeMenu11();
			InitializeMenu12();
		}
	}
}
