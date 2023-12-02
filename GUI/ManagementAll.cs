using System;
using System.Collections.Generic;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using DTO;
using BLL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

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
            btnCalculateProfit.Enabled = false;
            btnCalculateRevenue.Enabled = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            AdditemtoComboBox();
			ShowStaffs();
		}

        //Hiển thị thông tin nhân viên vào bảng
		public void ShowStaffs()
		{
			List<StaffDTO> staff = new List<StaffDTO>();
			staff = staffBLL.GetAllStaff();
			TableShowStaff.DataSource = staff;
			TableShowStaff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			TableShowStaff.Columns[4].HeaderText = "StoreId";
		}

        //Thêm các lựa chọn vào combobox
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

        //xử lý sự kiện showOrder
        private void btnShowOrder_Click(object sender, EventArgs e)
        {
            DateTime time = inputTimeShowOrder.Value;
            TableShowOrder.Columns.Clear();
            string option = optionShowOrder.Text.ToString();
            //kiểm tra option đã được chọn hay chưa
            if (option != "option")
            {
                //xử lý sự kiện show order theo ngày tháng năm và toàn thời gian
                List<OrderDTO> filteredOrders = new List<OrderDTO>();
                filteredOrders = filtedOders(option);
                TableShowOrder.DataSource = filteredOrders;
                TableShowOrder.Columns.Remove("PointUse");
                TableShowOrder.Columns.Remove("Status");
                TableShowOrder.Columns[1].HeaderText = "StoreId";
                TableShowOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                btnCalculateRevenue.Enabled = true;
                btnCalculateProfit.Enabled = true;
            }
            else
            {
                MessageBox.Show("Please choose an option to show orders.");
            }
        }
        //xử lý sự kiện tính doanh thu
        private void btnCalculateRevenue_Click(object sender, EventArgs e) 
        {
            string option = optionShowOrder.Text.ToString();
            //kiểm tra option đã được chọn hay chưa
            if (option != "option")
            {
                //xử lý sự kiện tính doanh thu theo ngày tháng năm và toàn thời gian
                List<OrderDTO> filteredOrders = new List<OrderDTO>();
                filteredOrders = filtedOders(option);
                int totalRevenue = 0;
                foreach (OrderDTO order in filteredOrders)
                {
                    totalRevenue += order.Total;
                }
                if (labelRevenue.Text == "")
                {
                    labelRevenue.Text = totalRevenue.ToString() + " VND";
                    labelRevenue.Visible = true;
                } else
                {
                    labelRevenue.Text = "";
                    labelRevenue.Visible = false;
                }  
            }
            else
            {
                MessageBox.Show("Please choose an option to show Revenue.");
            }
        }

        //Xử lý sự kiện thêm nhân viên
        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            //kiểm tra đầu vào
            if (inputName.Text == "" || inputSalary.Text == "" || inputShift.Text == "" || inputUserId.Text == "")
            {
                MessageBox.Show("Please enter all information");
            }
            else
            {
                //Thêm nhân viên mới vào csdl, UserID dc tạo tự động
                StaffDTO staff = new StaffDTO();
                staff.Salary = int.Parse(inputSalary.Text.ToString());
                staff.Name = inputName.Text.ToString();
                staff.Shift = inputShift.Text.ToString();
                staff.UserId = int.Parse(inputUserId.Text.ToString());
                staffBLL.CreateStaff(staff);
                ShowStaffs();
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            inputName.Text = string.Empty;
            inputSalary.Text = string.Empty;
            inputShift.Text = string.Empty;
            inputStaffId.Text = string.Empty;
            inputUserId.Text = string.Empty;
            btnAddStaff.Enabled = true;
        }

        //Tính lợi nhuận
        private void btnCalculateProfit_Click(object sender, EventArgs e)
        {
            
            DateTime time = inputTimeShowOrder.Value;
            string option = optionShowOrder.Text.ToString();
            //kiểm tra option đã được chọn hay chưa
            if (option != "option")
            {
                //xử lý sự kiện tính lãi theo ngày tháng năm và toàn thời gian
                decimal profit =0;
                if (option == "Date")
                {
                    profit = DrinkOrderBLL.CalculateDailyProfit(time.Date);
                }
                else if (option == "Month")
                {
                    profit = DrinkOrderBLL.CalculateMonthlyProfit(time.Month,time.Year);
                }
                else if (option == "Year")
                {
                    profit = DrinkOrderBLL.CalculateYearlyProfit(time.Year);
                }
                else if (option == "All Order")
                {
                    profit = DrinkOrderBLL.CalculateProfit();
                }

                int intprofit = Convert.ToInt32(profit);
                if (labelProfit.Text == "")
                {
                    labelProfit.Text = intprofit.ToString() + " VND";
                    labelProfit.Visible = true;
                }
                else
                {
                    labelProfit.Text = "";
                    labelProfit.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Please choose an option to show Profit.");
            }

        }

        //update thông tin nhân viên
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


        //Xóa nhân viên(chuyển trại thái từ 1 thành 0)
        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {
            if (inputStaffId.Text == "")
            {
                MessageBox.Show("Please choose Staff in table");
            }
            else
            {
                staffBLL.UpdateStaffStatus(int.Parse(inputStaffId.Text));
                ShowStaffs();
              

            }
        }
        // hiển thị product vào bảng
        private void btnShowProduct_Click(object sender, EventArgs e)
        {
            List<ProductDTO> products = new List<ProductDTO>();
            products = productBLL.GetProducts();
            TableShowOrder.DataSource = products;
            TableShowOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TableShowOrder.Columns[0].HeaderText = "ProductId";
            TableShowOrder.Columns[1].HeaderText = "Product Name";
            TableShowOrder.Columns[4].HeaderText = "Provide Quantity";
            btnCalculateProfit.Enabled = false;
            btnCalculateRevenue.Enabled = false;
        }

        // update thông tin product
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
        //log out
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        //Xử lý sự kiện RowHeaderMouseClick của bảng Order
        private void TableShowOrder_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Nếu có dòng dc chọn thì set data vào text field
                if(TableShowOrder.Columns.Count > 4)
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
        }

        //Xử lý sự kiện RowHeaderMouseClick của bảng Staff
        private void TableShowStaff_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Nếu có dòng dc chọn thì set data vào text field
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
                btnAddStaff.Enabled = false;
            }
        }

        //Xử lý lọc Order theo lưa chọn ngày tháng năm
        private List<OrderDTO> filtedOders(string option)
        {
            DateTime time = inputTimeShowOrder.Value;
            List<OrderDTO> orders = orderBLL.GetOrders();
            List<OrderDTO> filteredOrders = new List<OrderDTO>();

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
            else if (option == "All Order")
            {
                filteredOrders = orders;
            }

            return filteredOrders;
        }

        private void buttonClaer_Click(object sender, EventArgs e)
        {
            textBoxSearch.Text = string.Empty;
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            List<StaffDTO> staffList = new List<StaffDTO>();
            foreach (var staff in staffBLL.GetAllStaff())
            {
                String id = Convert.ToString(staff.StaffId);
                if (id.Contains(textBoxSearch.Text) || staff.Name.Contains(textBoxSearch.Text))
                {
                    staffList.Add(staff);
                }
            }
            TableShowStaff.DataSource = staffList;
            TableShowStaff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TableShowStaff.Columns[4].HeaderText = "StoreId";
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            textBoxSearch.Text= string.Empty;
        }



        private void btnExcelOrder_Click(object sender, EventArgs e)
        {
            ExportToExcel(TableShowOrder);
        }

        private void btnExcelStaff_Click(object sender, EventArgs e)
        {
            ExportToExcel(TableShowStaff);
        }

        public void ExportToExcel(DataGridView dataGridView)
        {
            if (dataGridView.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất ra Excel!");
                return;
            }

            // Tạo một ứng dụng Excel
            Excel.Application excelApp = new Excel.Application();

            // Tạo một Workbook mới
            Excel.Workbook excelWorkbook = excelApp.Workbooks.Add(Type.Missing);

            // Tạo một Worksheet mới và đặt nó làm Worksheet đầu tiên
            Excel.Worksheet excelWorksheet = (Excel.Worksheet)excelWorkbook.Sheets[1];

            // Xuất tiêu đề
            for (int i = 1; i < dataGridView.Columns.Count + 1; i++)
            {
                excelWorksheet.Cells[1, i] = dataGridView.Columns[i - 1].HeaderText;
            }

            // Xuất dữ liệu
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView.Columns.Count; j++)
                {
                    excelWorksheet.Cells[i + 2, j + 1] = dataGridView.Rows[i].Cells[j].Value.ToString();
                }
            }

            // Mở Excel
            excelApp.Visible = true;
        }


    }
}
