using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
	partial class Management
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Management));
			TableShowOrder = new DataGridView();
			btnShowOrder = new Button();
			btnCalculateRevenue = new Button();
			labelRevenue = new Label();
			TableShowStaff = new DataGridView();
			btnShowStaff = new Button();
			inputStatus = new ComboBox();
			inputStaffId = new TextBox();
			btnAddAtendance = new Button();
			inputDateTime = new DateTimePicker();
			labelProfit = new Label();
			btnCalculateProfit = new Button();
			StaffID = new Label();
			Status = new Label();
			Date = new Label();
			groupBox1 = new GroupBox();
			inputTimeShowAttendance = new DateTimePicker();
			optionShowAttendance = new ComboBox();
			inputTimeShowOrder = new DateTimePicker();
			optionShowOrder = new ComboBox();
			groupBox2 = new GroupBox();
			btnShowAttendance = new Button();
			groupBox3 = new GroupBox();
			((System.ComponentModel.ISupportInitialize)TableShowOrder).BeginInit();
			((System.ComponentModel.ISupportInitialize)TableShowStaff).BeginInit();
			groupBox3.SuspendLayout();
			SuspendLayout();
			// 
			// TableShowOrder
			// 
			TableShowOrder.BackgroundColor = SystemColors.ControlLightLight;
			TableShowOrder.ColumnHeadersHeight = 34;
			TableShowOrder.Location = new Point(617, 68);
			TableShowOrder.Name = "TableShowOrder";
			TableShowOrder.RowHeadersWidth = 62;
			TableShowOrder.RowTemplate.Height = 33;
			TableShowOrder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			TableShowOrder.Size = new Size(782, 303);
			TableShowOrder.TabIndex = 0;
			// 
			// btnShowOrder
			// 
			btnShowOrder.BackColor = Color.FromArgb(255, 192, 128);
			btnShowOrder.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btnShowOrder.Location = new Point(93, 100);
			btnShowOrder.Name = "btnShowOrder";
			btnShowOrder.Size = new Size(177, 44);
			btnShowOrder.TabIndex = 1;
			btnShowOrder.Text = "Show Order";
			btnShowOrder.UseVisualStyleBackColor = false;
			btnShowOrder.Click += btnShowOrder_Click;
			// 
			// btnCalculateRevenue
			// 
			btnCalculateRevenue.BackColor = Color.FromArgb(255, 192, 128);
			btnCalculateRevenue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btnCalculateRevenue.Location = new Point(621, 392);
			btnCalculateRevenue.Name = "btnCalculateRevenue";
			btnCalculateRevenue.Size = new Size(149, 44);
			btnCalculateRevenue.TabIndex = 2;
			btnCalculateRevenue.Text = "Revenue";
			btnCalculateRevenue.UseVisualStyleBackColor = false;
			btnCalculateRevenue.Click += btnCalculateRevenue_Click;
			// 
			// labelRevenue
			// 
			labelRevenue.AutoSize = true;
			labelRevenue.Location = new Point(776, 407);
			labelRevenue.Name = "labelRevenue";
			labelRevenue.Size = new Size(0, 25);
			labelRevenue.TabIndex = 3;
			// 
			// TableShowStaff
			// 
			TableShowStaff.BackgroundColor = Color.White;
			TableShowStaff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			TableShowStaff.Location = new Point(617, 471);
			TableShowStaff.Name = "TableShowStaff";
			TableShowStaff.RowHeadersWidth = 62;
			TableShowStaff.RowTemplate.Height = 33;
			TableShowStaff.Size = new Size(782, 237);
			TableShowStaff.TabIndex = 4;
			TableShowStaff.RowHeaderMouseClick += ShowStaff_RowHeaderMouseClick;
			// 
			// btnShowStaff
			// 
			btnShowStaff.BackColor = Color.FromArgb(255, 192, 128);
			btnShowStaff.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btnShowStaff.Location = new Point(617, 737);
			btnShowStaff.Name = "btnShowStaff";
			btnShowStaff.Size = new Size(151, 49);
			btnShowStaff.TabIndex = 5;
			btnShowStaff.Text = "Show Staff";
			btnShowStaff.UseVisualStyleBackColor = false;
			btnShowStaff.Click += btnShowStaff_Click;
			// 
			// inputStatus
			// 
			inputStatus.BackColor = Color.White;
			inputStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			inputStatus.FormattingEnabled = true;
			inputStatus.Location = new Point(253, 571);
			inputStatus.Name = "inputStatus";
			inputStatus.Size = new Size(182, 40);
			inputStatus.TabIndex = 15;
			// 
			// inputStaffId
			// 
			inputStaffId.BackColor = Color.White;
			inputStaffId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			inputStaffId.Location = new Point(253, 508);
			inputStaffId.Name = "inputStaffId";
			inputStaffId.ReadOnly = true;
			inputStaffId.Size = new Size(150, 39);
			inputStaffId.TabIndex = 13;
			// 
			// btnAddAtendance
			// 
			btnAddAtendance.BackColor = Color.FromArgb(255, 192, 128);
			btnAddAtendance.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btnAddAtendance.Location = new Point(126, 737);
			btnAddAtendance.Name = "btnAddAtendance";
			btnAddAtendance.Size = new Size(177, 49);
			btnAddAtendance.TabIndex = 12;
			btnAddAtendance.Text = "Add Atendance";
			btnAddAtendance.UseVisualStyleBackColor = false;
			btnAddAtendance.Click += btnAddAtendance_Click;
			// 
			// inputDateTime
			// 
			inputDateTime.CalendarForeColor = Color.FromArgb(255, 192, 128);
			inputDateTime.CalendarMonthBackground = Color.FromArgb(255, 192, 128);
			inputDateTime.CalendarTitleBackColor = Color.FromArgb(255, 192, 128);
			inputDateTime.CalendarTitleForeColor = Color.FromArgb(255, 192, 128);
			inputDateTime.CalendarTrailingForeColor = Color.FromArgb(255, 192, 128);
			inputDateTime.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			inputDateTime.Location = new Point(253, 639);
			inputDateTime.Name = "inputDateTime";
			inputDateTime.Size = new Size(294, 31);
			inputDateTime.TabIndex = 16;
			// 
			// labelProfit
			// 
			labelProfit.AutoSize = true;
			labelProfit.Location = new Point(1007, 411);
			labelProfit.Name = "labelProfit";
			labelProfit.Size = new Size(0, 25);
			labelProfit.TabIndex = 18;
			// 
			// btnCalculateProfit
			// 
			btnCalculateProfit.BackColor = Color.FromArgb(255, 192, 128);
			btnCalculateProfit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btnCalculateProfit.Location = new Point(895, 392);
			btnCalculateProfit.Name = "btnCalculateProfit";
			btnCalculateProfit.Size = new Size(112, 44);
			btnCalculateProfit.TabIndex = 17;
			btnCalculateProfit.Text = "Profit";
			btnCalculateProfit.UseVisualStyleBackColor = false;
			btnCalculateProfit.Click += btnCalculateProfit_Click;
			// 
			// StaffID
			// 
			StaffID.AutoSize = true;
			StaffID.BackColor = Color.FromArgb(255, 192, 128);
			StaffID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			StaffID.Location = new Point(146, 511);
			StaffID.Name = "StaffID";
			StaffID.Size = new Size(97, 32);
			StaffID.TabIndex = 19;
			StaffID.Text = "Staff ID:";
			// 
			// Status
			// 
			Status.AutoSize = true;
			Status.BackColor = Color.FromArgb(255, 192, 128);
			Status.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			Status.Location = new Point(157, 571);
			Status.Name = "Status";
			Status.Size = new Size(83, 32);
			Status.TabIndex = 20;
			Status.Text = "Status:";
			// 
			// Date
			// 
			Date.AutoSize = true;
			Date.BackColor = Color.FromArgb(255, 192, 128);
			Date.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			Date.Location = new Point(168, 639);
			Date.Name = "Date";
			Date.Size = new Size(69, 32);
			Date.TabIndex = 21;
			Date.Text = "Date:";
			// 
			// groupBox1
			// 
			groupBox1.BackColor = Color.FromArgb(255, 224, 192);
			groupBox1.Location = new Point(117, 471);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(457, 237);
			groupBox1.TabIndex = 22;
			groupBox1.TabStop = false;
			groupBox1.Text = "Attendance";
			// 
			// inputTimeShowAttendance
			// 
			inputTimeShowAttendance.CalendarForeColor = Color.FromArgb(255, 192, 128);
			inputTimeShowAttendance.CalendarMonthBackground = Color.FromArgb(255, 192, 128);
			inputTimeShowAttendance.CalendarTitleBackColor = Color.FromArgb(255, 192, 128);
			inputTimeShowAttendance.CalendarTitleForeColor = Color.FromArgb(255, 192, 128);
			inputTimeShowAttendance.CalendarTrailingForeColor = Color.FromArgb(255, 192, 128);
			inputTimeShowAttendance.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			inputTimeShowAttendance.Location = new Point(6, 101);
			inputTimeShowAttendance.Name = "inputTimeShowAttendance";
			inputTimeShowAttendance.Size = new Size(404, 39);
			inputTimeShowAttendance.TabIndex = 23;
			// 
			// optionShowAttendance
			// 
			optionShowAttendance.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			optionShowAttendance.FormattingEnabled = true;
			optionShowAttendance.Location = new Point(228, 45);
			optionShowAttendance.Name = "optionShowAttendance";
			optionShowAttendance.Size = new Size(182, 40);
			optionShowAttendance.TabIndex = 24;
			optionShowAttendance.Text = "option";
			// 
			// inputTimeShowOrder
			// 
			inputTimeShowOrder.CalendarForeColor = Color.FromArgb(255, 192, 128);
			inputTimeShowOrder.CalendarMonthBackground = Color.FromArgb(255, 192, 128);
			inputTimeShowOrder.CalendarTitleBackColor = Color.FromArgb(255, 192, 128);
			inputTimeShowOrder.CalendarTitleForeColor = Color.FromArgb(255, 192, 128);
			inputTimeShowOrder.CalendarTrailingForeColor = Color.FromArgb(255, 192, 128);
			inputTimeShowOrder.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			inputTimeShowOrder.Location = new Point(276, 107);
			inputTimeShowOrder.Name = "inputTimeShowOrder";
			inputTimeShowOrder.Size = new Size(292, 31);
			inputTimeShowOrder.TabIndex = 25;
			// 
			// optionShowOrder
			// 
			optionShowOrder.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			optionShowOrder.FormattingEnabled = true;
			optionShowOrder.Location = new Point(276, 156);
			optionShowOrder.Name = "optionShowOrder";
			optionShowOrder.Size = new Size(182, 40);
			optionShowOrder.TabIndex = 26;
			optionShowOrder.Text = "option";
			// 
			// groupBox2
			// 
			groupBox2.BackColor = Color.FromArgb(255, 224, 192);
			groupBox2.Location = new Point(86, 68);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(488, 165);
			groupBox2.TabIndex = 27;
			groupBox2.TabStop = false;
			// 
			// btnShowAttendance
			// 
			btnShowAttendance.BackColor = Color.FromArgb(255, 192, 128);
			btnShowAttendance.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btnShowAttendance.Location = new Point(6, 40);
			btnShowAttendance.Name = "btnShowAttendance";
			btnShowAttendance.Size = new Size(216, 49);
			btnShowAttendance.TabIndex = 28;
			btnShowAttendance.Text = "Show Attendance";
			btnShowAttendance.UseVisualStyleBackColor = false;
			btnShowAttendance.Click += btnShowAttendance_Click;
			// 
			// groupBox3
			// 
			groupBox3.BackColor = Color.FromArgb(255, 224, 192);
			groupBox3.Controls.Add(btnShowAttendance);
			groupBox3.Controls.Add(optionShowAttendance);
			groupBox3.Controls.Add(inputTimeShowAttendance);
			groupBox3.Location = new Point(1419, 471);
			groupBox3.Name = "groupBox3";
			groupBox3.Size = new Size(417, 237);
			groupBox3.TabIndex = 29;
			groupBox3.TabStop = false;
			groupBox3.Text = "Attendance";
			// 
			// Management
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.Control;
			BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
			ClientSize = new Size(1859, 862);
			Controls.Add(groupBox3);
			Controls.Add(optionShowOrder);
			Controls.Add(inputTimeShowOrder);
			Controls.Add(Date);
			Controls.Add(Status);
			Controls.Add(StaffID);
			Controls.Add(labelProfit);
			Controls.Add(btnCalculateProfit);
			Controls.Add(inputDateTime);
			Controls.Add(inputStatus);
			Controls.Add(inputStaffId);
			Controls.Add(btnAddAtendance);
			Controls.Add(btnShowStaff);
			Controls.Add(TableShowStaff);
			Controls.Add(labelRevenue);
			Controls.Add(btnCalculateRevenue);
			Controls.Add(btnShowOrder);
			Controls.Add(TableShowOrder);
			Controls.Add(groupBox1);
			Controls.Add(groupBox2);
			Name = "Management";
			Text = "Management";
			((System.ComponentModel.ISupportInitialize)TableShowOrder).EndInit();
			((System.ComponentModel.ISupportInitialize)TableShowStaff).EndInit();
			groupBox3.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView TableShowOrder;
		private Button btnShowOrder;
		private Button btnCalculateRevenue;
		private Label labelRevenue;
		private DataGridView TableShowStaff;
		private Button btnShowStaff;
		private ComboBox inputStatus;
		private TextBox inputStaffId;
		private Button btnAddAtendance;
		private DateTimePicker inputDateTime;
		private Label labelProfit;
		private Button btnCalculateProfit;
		private Label StaffID;
		private Label Status;
		private Label Date;
		private GroupBox groupBox1;
		private DateTimePicker inputTimeShowAttendance;
		private ComboBox optionShowAttendance;
		private DateTimePicker inputTimeShowOrder;
		private ComboBox optionShowOrder;
		private GroupBox groupBox2;
		private Button btnShowAttendance;
		private GroupBox groupBox3;
	}
}