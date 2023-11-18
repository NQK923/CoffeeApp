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

		public void SetDataFromLogin(UserDTO data)
		{
			user = data;
		}
		public Management()
		{
			InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            AddItemsComboBox();


		}  
		private void ShowStaff_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow selectedRow = TableShowStaff.Rows[e.RowIndex];
				int staffId = (int)selectedRow.Cells["StaffId"].Value;
				inputStaffId.Text = staffId.ToString();
			}
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

        private void btnShowOrder_Click(object sender, EventArgs e)
        {
            DateTime time = inputTimeShowOrder.Value;
            TableShowOrder.Columns.Clear();
            string option = optionShowOrder.Text.ToString();
            if (option != "option")
            {
                List<OrderDTO> orders = OrderBLL.GetOrdersByUserId(user.UserId);
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
                    filteredOrders = OrderBLL.GetOrdersByUserId(user.UserId);
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
            orders = OrderBLL.GetOrdersByUserId(user.UserId);

            int totalRevenue = 0;
            foreach (OrderDTO order in orders)
            {
                totalRevenue += order.Total;
            }
            labelRevenue.Text = totalRevenue.ToString() + "VND";
        }

        private void btnShowStaff_Click(object sender, EventArgs e)
        {
            List<StaffDTO> staff = new List<StaffDTO>();
            staff = staffBLL.GetStaffByUserId(user.UserId);
            TableShowStaff.DataSource = staff;
            TableShowStaff.Columns[4].HeaderText = "StoreId";
            TableShowStaff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

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

        private void btnCalculateProfit_Click(object sender, EventArgs e)
        {
            decimal profit = userBLL.CalculateProfitForUser(user.UserId);
            labelProfit.Text = profit.ToString() + "VND";
        }

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
    }
}
