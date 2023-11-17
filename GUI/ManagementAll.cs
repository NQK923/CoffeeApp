﻿using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using DTO;
using BLL;

namespace GUI
{
    public partial class ManagementAll : Form
	{
		private OrderBLL orderBLL = new OrderBLL();
		private StaffBLL staffBLL = new StaffBLL();
		private DrinkOrderBLL DrinkOrderBLL = new DrinkOrderBLL();
		private ProductBLL productBLL = new ProductBLL();
		public ManagementAll()
		{
			InitializeComponent();
			AdditemtoComboBox();
			ShowStaffs();
		}

        private void btnShowOrder_Click_1(object sender, EventArgs e)
		{
			
			DateTime time = inputTimeShowOrder.Value;
			TableShowOrder.Columns.Clear();
			string option = optionShowOrder.Text.ToString();
			if (option != "option")
			{
				List<OrderDTO> orders = orderBLL.GetOrders();
				List<OrderDTO> filteredOrders = new List<OrderDTO>(); // Create a new list for filtered orders

				if (option == "Date")
				{
					filteredOrders = orders.FindAll(order => order.DateTime.Date == time.Date
                        && order.DateTime.Month == time.Month && order.DateTime.Year == time.Year);
				}
				else if (option == "Month")
				{
					filteredOrders = orders.FindAll(order => order.DateTime.Month == time.Month
						&& order.DateTime.Year == time.Year);
				}
				else if (option == "Year")
				{
					filteredOrders = orders.FindAll(order => order.DateTime.Year == time.Year);
				}
				else if (option == "All table")
				{
					filteredOrders = orderBLL.GetOrders();
				}
				TableShowOrder.DataSource = filteredOrders;
				TableShowOrder.Columns.Remove("PointUse");
				TableShowOrder.Columns.Remove("Status");
				TableShowOrder.Columns[1].HeaderText = "StoreId";
				TableShowOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			}
			else
			{
				MessageBox.Show("Please choose an option to show orders.");
			}
		}


		private void btnCalculateRevenue_Click(object sender, EventArgs e)
		{
			List<OrderDTO> orders = new List<OrderDTO>();
			orders = orderBLL.GetOrders();
			int totalRevenue = 0;
			foreach (OrderDTO order in orders)
			{
				totalRevenue += order.Total;
			}
			labelRevenue.Text = totalRevenue.ToString() + "VND";
		}

		private void btnAddStaff_Click(object sender, EventArgs e)
		{
			if (inputName.Text == "" || inputSalary.Text == "" || inputShift.Text == "" || inputUserId.Text == "")
			{
				MessageBox.Show("Please enter all information");
			}
			else
			{
				StaffDTO staff = new StaffDTO();
				staff.Salary = int.Parse(inputSalary.Text.ToString());
				staff.Name = inputName.Text.ToString();
				staff.Shift = inputShift.Text.ToString();
				staff.UserId = int.Parse(inputUserId.Text.ToString());
				staffBLL.CreateStaff(staff);
				ShowStaffs();
			}

		}
		private void TableShowStaff_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow selectedRow = TableShowStaff.Rows[e.RowIndex];
				int staffId = (int)selectedRow.Cells["StaffId"].Value;
				string name = (string)selectedRow.Cells["Name"].Value;
				string shift = (string)selectedRow.Cells["Shift"].Value;
				int storeId = (int)selectedRow.Cells["UserId"].Value;
				int salary = (int)selectedRow.Cells["Salary"].Value;

				inputName.Text = name.ToString();
				inputSalary.Text = salary.ToString();
				inputShift.Text = shift.ToString();
				inputUserId.Text = storeId.ToString();
				inputStaffId.Text = staffId.ToString();
			}
		}
		private void btnClearAll_Click(object sender, EventArgs e)
		{
			inputName.Text = string.Empty;
			inputSalary.Text = string.Empty;
			inputShift.Text = string.Empty;
			inputStaffId.Text = string.Empty;
			inputUserId.Text = string.Empty;

		}

		private void btnCalculateProfit_Click(object sender, EventArgs e)
		{
			decimal profit = DrinkOrderBLL.CalculateProfit();
			labelProfit.Text = profit.ToString() + "VND";
		}
		private void btnUpdateStaff_Click(object sender, EventArgs e)
		{
			if (inputName.Text == "" || inputSalary.Text == "" || inputShift.Text == "" || inputUserId.Text == "")
			{
				MessageBox.Show("Please enter all information");
			}
			else
			{
				StaffDTO staff = new StaffDTO();
				staff.StaffId = int.Parse(inputStaffId.Text);
				staff.Shift = inputShift.Text.ToString();
				staff.Name = inputName.Text.ToString();
				staff.UserId = int.Parse(inputUserId.Text.ToString());
				staff.Salary = int.Parse(inputSalary.Text.ToString());
				staffBLL.UpdateStaff(staff);
				ShowStaffs();
				
			}
		}
		private void btnDeleteStaff_Click(object sender, EventArgs e)
		{
			if (inputStaffId.Text == "")
			{
				MessageBox.Show("Please choose Staff in table");
			}
			else
			{
				staffBLL.DeleteStaff(int.Parse(inputStaffId.Text));
				ShowStaffs();
				
			}
		}
		public void ShowStaffs()
		{
			List<StaffDTO> staff = new List<StaffDTO>();
			staff = staffBLL.GetAllStaff();
			TableShowStaff.DataSource = staff;
			TableShowStaff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			TableShowStaff.Columns[4].HeaderText = "StoreId";
		}
		private void btnShowProduct_Click(object sender, EventArgs e)
		{
			List<ProductDTO> products = new List<ProductDTO>();
			products = productBLL.GetProducts();
			TableShowOrder.DataSource = products;
			TableShowOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			TableShowOrder.Columns[0].HeaderText = "ProductId";
			TableShowOrder.Columns[1].HeaderText = "Product Name";
			TableShowOrder.Columns[4].HeaderText = "Provide Quantity";

		}
		private void btnUpdateProduct_Click(object sender, EventArgs e)
		{
			if (inputProductId.Text != "")
			{
				ProductDTO product = new ProductDTO();
				product.Cost = decimal.Parse(inputProductCost.Text);
				product.DrinkName = inputProductName.Text.ToString();
				product.Price = decimal.Parse(inputProductPrice.Text);
				product.Provider = inputProductQuantity.Text.ToString();
				product.DrinkId = int.Parse(inputProductId.Text);
				productBLL.UpdateDrink(product);
				List<ProductDTO> products = new List<ProductDTO>();

				products = productBLL.GetProducts();
				TableShowOrder.DataSource = products;
				TableShowOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			}
			else
			{
				MessageBox.Show("choose Product");
			}

		}

		private void TableShowOrder_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow selectedRow = TableShowOrder.Rows[e.RowIndex];
				decimal Cost = (decimal)selectedRow.Cells["Cost"].Value;
				string DrinkName = (string)selectedRow.Cells["DrinkName"].Value;
				decimal Price = (decimal)selectedRow.Cells["Price"].Value;
				string Provider = (string)selectedRow.Cells["Provider"].Value;
				int ProductId = (int)selectedRow.Cells["DrinkId"].Value;

				inputProductCost.Text = Cost.ToString();
				inputProductName.Text = DrinkName.ToString();
				inputProductPrice.Text = Price.ToString();
				inputProductQuantity.Text = Provider.ToString();
				inputProductId.Text = ProductId.ToString();
			}
		}
		
		public void AdditemtoComboBox()
		{
			inputShift.Items.Add("9h-12h");
			inputShift.Items.Add("12h-3h");
			inputShift.Items.Add("3h-6h");
			inputShift.Items.Add("6h-9h");
			inputShift.Items.Add("full time");
			inputUserId.Items.Add("1");
			inputUserId.Items.Add("2");
			optionShowOrder.Items.Add("Date");
			optionShowOrder.Items.Add("Month");
			optionShowOrder.Items.Add("Year");
			optionShowOrder.Items.Add("All Order");
		}	
	}
}
