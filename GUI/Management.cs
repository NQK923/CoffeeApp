using DTO;
using BLL;
using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace GUI
{
    public partial class Management : Form

	{
		public UserDTO user { get; set; }
		public UserBLL userBLL = new UserBLL();
		public OrderBLL OrderBLL = new OrderBLL();
		public StaffBLL staffBLL = new StaffBLL();
		public AttendanceBLL AttendanceBLL = new AttendanceBLL();
        public DrinkOrderBLL DrinkOrderBLL = new DrinkOrderBLL();

		public void SetDataFromLogin(UserDTO data)
		{
			user = data;
		}
		public Management()
		{
			InitializeComponent();
            btnCalculateRevenue.Enabled = false;
            btnCalculateProfit.Enabled = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            AddItemsComboBox();


		}  
		public void AddItemsComboBox()
		{
			inputStatus.Items.Add("present");
			inputStatus.Items.Add("absent");
			inputStatus.Items.Add("late");
			optionShowAttendance.Items.Add("Date");
			optionShowAttendance.Items.Add("Month");
			optionShowOrder.Items.Add("Date");
			optionShowOrder.Items.Add("Month");
			optionShowOrder.Items.Add("Year");

		}
        //Xử lý sự kiện ShowOrder
        private void btnShowOrder_Click(object sender, EventArgs e)
        {
            //kiểm tra option đã được chọn hay chưa
            DateTime time = inputTimeShowOrder.Value;
            TableShowOrder.Columns.Clear();
            string option = optionShowOrder.Text.ToString();
            if (option != "option")
            {
                //xử lý sự kiện show order theo ngày tháng năm và toàn thời gian
                List<OrderDTO> orders = OrderBLL.GetOrdersByUserId(user.UserId);
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
                else if (option == "All table")
                {
                    filteredOrders = OrderBLL.GetOrdersByUserId(user.UserId);
                }

                TableShowOrder.DataSource = filteredOrders;
                TableShowOrder.Columns.Remove("PointUse");
                TableShowOrder.Columns.Remove("Status");
                TableShowOrder.Columns[1].HeaderText = "StoreId";
                TableShowOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                btnCalculateProfit.Enabled = true;
                btnCalculateRevenue.Enabled = true;
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
                }
                else
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

        //Hiển thị nhân viên
        private void btnShowStaff_Click(object sender, EventArgs e)
        {
            List<StaffDTO> staff = new List<StaffDTO>();
            staff = staffBLL.GetStaffByUserId(user.UserId);
            TableShowStaff.DataSource = staff;
            TableShowStaff.Columns[4].HeaderText = "StoreId";
            TableShowStaff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        //Chấm công cho nhân viên có đi làm hay vắng mặt
        private void btnAddAtendance_Click(object sender, EventArgs e)
        {
            if (inputStatus.Text == "")
            {
                MessageBox.Show("Please choose status");
            }
            else
            {
                List<AttendanceDTO> attendanceList = AttendanceBLL.GetAttendance();
                List<AttendanceDTO> filteredAttendance = new List<AttendanceDTO>();
                DateTime time = inputDateTime.Value;
                filteredAttendance = attendanceList.FindAll(attendance => attendance.DateTime.Date == time.Date
                        && attendance.DateTime.Month == time.Month && attendance.DateTime.Year == time.Year
                        && attendance.StaffId == int.Parse(inputStaffId.Text.ToString()));
                if (filteredAttendance.Count > 0)
                {
                    MessageBox.Show("Duplicate attendance record for the same StaffId and date already exists.");
                }
                else
                {
                    AttendanceDTO attendance = new AttendanceDTO();
                    attendance.DateTime = inputDateTime.Value;
                    attendance.StaffId = int.Parse(inputStaffId.Text.ToString());
                    attendance.Status = inputStatus.Text.ToString();
                    AttendanceBLL.CreateAttendance(attendance);

                    MessageBox.Show("Add Attendance Success");
                }
            }
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
                decimal profit = 0;
                if (option == "Date")
                {
                    profit = DrinkOrderBLL.CalculateDailyProfit(time.Date);
                }
                else if (option == "Month")
                {
                    profit = DrinkOrderBLL.CalculateMonthlyProfit(time.Month, time.Year);
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

        //Hiển thị bảng chấm công theo thời gian đã chọn
        private void btnShowAttendance_Click(object sender, EventArgs e)
        {

            DateTime time = inputTimeShowAttendance.Value;
            TableShowStaff.Columns.Clear();
            string option = optionShowAttendance.Text.ToString();
            if (option != "option")
            {
                List<AttendanceDTO> attendanceList = new List<AttendanceDTO>();
                attendanceList= AttendanceBLL.GetAttendance();
                List<AttendanceDTO> filteredAttendance = new List<AttendanceDTO>();
                System.Console.WriteLine(attendanceList);

                if (option == "Date")
                {
                    System.Console.WriteLine("date");
                    filteredAttendance = attendanceList.FindAll(attendance => attendance.DateTime.Date == time.Date
                        && attendance.DateTime.Month == time.Month && attendance.DateTime.Year == time.Year);
                }
                else if (option == "Month")
                    System.Console.WriteLine("date");
                {
                    filteredAttendance = attendanceList.FindAll(attendance => attendance.DateTime.Month == time.Month
                        && attendance.DateTime.Year == time.Year);
                }

                TableShowStaff.DataSource = filteredAttendance;
                TableShowStaff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                MessageBox.Show("Please choose an option to show attendance.");
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private List<OrderDTO> filtedOders(string option)
        {
            DateTime time = inputTimeShowOrder.Value;
            List<OrderDTO> orders = OrderBLL.GetOrders();
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

        private void TableShowStaff_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = TableShowStaff.Rows[e.RowIndex];
                int staffId = (int)selectedRow.Cells["StaffId"].Value;
                inputStaffId.Text = staffId.ToString();
            }
        }
    }
}
