using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using DTO;

namespace GUI
{
    public partial class ManagementAll : Form
	{
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
				List<Order> orders = GetOrders();
				List<Order> filteredOrders = new List<Order>(); // Create a new list for filtered orders

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
					filteredOrders = GetOrders();
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
			List<Order> orders = new List<Order>();
			orders = GetOrders();
			int totalRevenue = 0;
			foreach (Order order in orders)
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
				Staff staff = new Staff();
				staff.Salary = int.Parse(inputSalary.Text.ToString());
				staff.Name = inputName.Text.ToString();
				staff.Shift = inputShift.Text.ToString();
				staff.UserId = int.Parse(inputUserId.Text.ToString());
				CreateStaff(staff);
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
			decimal profit = CalculateProfit();
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
				Staff staff = new Staff();
				staff.StaffId = int.Parse(inputStaffId.Text);
				staff.Shift = inputShift.Text.ToString();
				staff.Name = inputName.Text.ToString();
				staff.UserId = int.Parse(inputUserId.Text.ToString());
				staff.Salary = int.Parse(inputSalary.Text.ToString());
				UpdateStaff(staff);
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
				DeleteStaff(int.Parse(inputStaffId.Text));
				ShowStaffs();
				
			}


		}
		public void ShowStaffs()
		{
			List<Staff> staff = new List<Staff>();
			staff = GetAllStaff();
			TableShowStaff.DataSource = staff;
			TableShowStaff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			TableShowStaff.Columns[4].HeaderText = "StoreId";
		}
		private void btnShowProduct_Click(object sender, EventArgs e)
		{
			List<Product> products = new List<Product>();
			products = GetProducts();
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
				Product product = new Product();
				product.Cost = decimal.Parse(inputProductCost.Text);
				product.DrinkName = inputProductName.Text.ToString();
				product.Price = decimal.Parse(inputProductPrice.Text);
				product.Provider = inputProductQuantity.Text.ToString();
				product.DrinkId = int.Parse(inputProductId.Text);
				UpdateDrink(product);
				List<Product> products = new List<Product>();

				products = GetProducts();
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
		
		public decimal CalculateProfit()
		{
			decimal totalProfit = 0;

			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();

				// Retrieve data from the DrinkOrder table and join with the Drink table to get price and cost information
				string query = "SELECT DO.DrinkOrderId, DO.DrinkId, DO.Quantity, D.Price, D.Cost FROM DrinkOrder DO " +
							   "INNER JOIN Drink D ON DO.DrinkId = D.DrinkId";

				using (SqlCommand command = new SqlCommand(query, connection))
				using (SqlDataReader reader = command.ExecuteReader())
				{
					while (reader.Read())
					{
						int drinkOrderId = (int)reader["DrinkOrderId"];
						int drinkId = (int)reader["DrinkId"];
						int quantity = (int)reader["Quantity"];
						decimal price = (decimal)reader["Price"];
						decimal cost = (decimal)reader["Cost"];

						decimal profit = (price - cost) * quantity;
						totalProfit += profit;
					}
				}
			}

			return totalProfit;
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


		

		public List<Product> GetProducts()
		{
			List<Product> products = new List<Product>();

			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();

				string query = "SELECT DrinkId, DrinkName, Price, Cost, Provider FROM Drink";

				using (SqlCommand command = new SqlCommand(query, connection))
				using (SqlDataReader reader = command.ExecuteReader())
				{
					while (reader.Read())
					{
						Product drink = new Product
						{
							DrinkId = reader.GetInt32(0),
							DrinkName = reader.GetString(1),
							Price = reader.GetDecimal(2),
							Cost = reader.GetDecimal(3),
							Provider = reader.GetString(4)
						};

						products.Add(drink);
					}
				}
			}

			return products;
		}
		public void UpdateDrink(Product product)
		{
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();

				string query = "UPDATE Drink SET DrinkName = @DrinkName, Price = @Price, Cost = @Cost, Provider = @Provider WHERE DrinkId = @DrinkId";

				using (SqlCommand command = new SqlCommand(query, connection))
				{

					command.Parameters.AddWithValue("@DrinkId", product.DrinkId);
					command.Parameters.AddWithValue("@DrinkName", product.DrinkName);
					command.Parameters.AddWithValue("@Price", product.Price);
					command.Parameters.AddWithValue("@Cost", product.Cost);
					command.Parameters.AddWithValue("@Provider", product.Provider);

					command.ExecuteNonQuery();
				}
			}
		}
		
	}

}
