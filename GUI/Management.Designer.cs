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
            this.TableShowOrder = new System.Windows.Forms.DataGridView();
            this.btnShowOrder = new System.Windows.Forms.Button();
            this.btnCalculateRevenue = new System.Windows.Forms.Button();
            this.labelRevenue = new System.Windows.Forms.Label();
            this.TableShowStaff = new System.Windows.Forms.DataGridView();
            this.btnShowStaff = new System.Windows.Forms.Button();
            this.inputStatus = new System.Windows.Forms.ComboBox();
            this.inputStaffId = new System.Windows.Forms.TextBox();
            this.btnAddAtendance = new System.Windows.Forms.Button();
            this.inputDateTime = new System.Windows.Forms.DateTimePicker();
            this.labelProfit = new System.Windows.Forms.Label();
            this.btnCalculateProfit = new System.Windows.Forms.Button();
            this.StaffID = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.inputTimeShowAttendance = new System.Windows.Forms.DateTimePicker();
            this.optionShowAttendance = new System.Windows.Forms.ComboBox();
            this.inputTimeShowOrder = new System.Windows.Forms.DateTimePicker();
            this.optionShowOrder = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnShowAttendance = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnExcelOrder = new System.Windows.Forms.Button();
            this.btnExcelStaff = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TableShowOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableShowStaff)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableShowOrder
            // 
            this.TableShowOrder.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.TableShowOrder.ColumnHeadersHeight = 34;
            this.TableShowOrder.Location = new System.Drawing.Point(494, 44);
            this.TableShowOrder.Margin = new System.Windows.Forms.Padding(2);
            this.TableShowOrder.Name = "TableShowOrder";
            this.TableShowOrder.RowHeadersWidth = 62;
            this.TableShowOrder.RowTemplate.Height = 33;
            this.TableShowOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TableShowOrder.Size = new System.Drawing.Size(626, 194);
            this.TableShowOrder.TabIndex = 0;
            // 
            // btnShowOrder
            // 
            this.btnShowOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnShowOrder.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnShowOrder.Location = new System.Drawing.Point(13, 19);
            this.btnShowOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowOrder.Name = "btnShowOrder";
            this.btnShowOrder.Size = new System.Drawing.Size(124, 43);
            this.btnShowOrder.TabIndex = 1;
            this.btnShowOrder.Text = "Show Order";
            this.btnShowOrder.UseVisualStyleBackColor = false;
            this.btnShowOrder.Click += new System.EventHandler(this.btnShowOrder_Click);
            // 
            // btnCalculateRevenue
            // 
            this.btnCalculateRevenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnCalculateRevenue.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCalculateRevenue.Location = new System.Drawing.Point(497, 250);
            this.btnCalculateRevenue.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalculateRevenue.Name = "btnCalculateRevenue";
            this.btnCalculateRevenue.Size = new System.Drawing.Size(124, 40);
            this.btnCalculateRevenue.TabIndex = 2;
            this.btnCalculateRevenue.Text = "Revenue";
            this.btnCalculateRevenue.UseVisualStyleBackColor = false;
            this.btnCalculateRevenue.Click += new System.EventHandler(this.btnCalculateRevenue_Click);
            // 
            // labelRevenue
            // 
            this.labelRevenue.AutoSize = true;
            this.labelRevenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.labelRevenue.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelRevenue.Location = new System.Drawing.Point(628, 256);
            this.labelRevenue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRevenue.Name = "labelRevenue";
            this.labelRevenue.Size = new System.Drawing.Size(0, 28);
            this.labelRevenue.TabIndex = 3;
            // 
            // TableShowStaff
            // 
            this.TableShowStaff.BackgroundColor = System.Drawing.Color.White;
            this.TableShowStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableShowStaff.Location = new System.Drawing.Point(494, 301);
            this.TableShowStaff.Margin = new System.Windows.Forms.Padding(2);
            this.TableShowStaff.Name = "TableShowStaff";
            this.TableShowStaff.RowHeadersWidth = 62;
            this.TableShowStaff.RowTemplate.Height = 33;
            this.TableShowStaff.Size = new System.Drawing.Size(626, 152);
            this.TableShowStaff.TabIndex = 4;
            this.TableShowStaff.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.TableShowStaff_RowHeaderMouseClick);
            // 
            // btnShowStaff
            // 
            this.btnShowStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnShowStaff.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnShowStaff.Location = new System.Drawing.Point(494, 472);
            this.btnShowStaff.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowStaff.Name = "btnShowStaff";
            this.btnShowStaff.Size = new System.Drawing.Size(127, 44);
            this.btnShowStaff.TabIndex = 5;
            this.btnShowStaff.Text = "Show Staff";
            this.btnShowStaff.UseVisualStyleBackColor = false;
            this.btnShowStaff.Click += new System.EventHandler(this.btnShowStaff_Click);
            // 
            // inputStatus
            // 
            this.inputStatus.BackColor = System.Drawing.Color.White;
            this.inputStatus.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.inputStatus.FormattingEnabled = true;
            this.inputStatus.Location = new System.Drawing.Point(128, 62);
            this.inputStatus.Margin = new System.Windows.Forms.Padding(2);
            this.inputStatus.Name = "inputStatus";
            this.inputStatus.Size = new System.Drawing.Size(146, 36);
            this.inputStatus.TabIndex = 15;
            // 
            // inputStaffId
            // 
            this.inputStaffId.BackColor = System.Drawing.Color.White;
            this.inputStaffId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.inputStaffId.Location = new System.Drawing.Point(128, 21);
            this.inputStaffId.Margin = new System.Windows.Forms.Padding(2);
            this.inputStaffId.Name = "inputStaffId";
            this.inputStaffId.ReadOnly = true;
            this.inputStaffId.Size = new System.Drawing.Size(121, 34);
            this.inputStaffId.TabIndex = 13;
            // 
            // btnAddAtendance
            // 
            this.btnAddAtendance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAddAtendance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAddAtendance.Location = new System.Drawing.Point(156, 144);
            this.btnAddAtendance.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddAtendance.Name = "btnAddAtendance";
            this.btnAddAtendance.Size = new System.Drawing.Size(142, 36);
            this.btnAddAtendance.TabIndex = 12;
            this.btnAddAtendance.Text = "Add Atendance";
            this.btnAddAtendance.UseVisualStyleBackColor = false;
            this.btnAddAtendance.Click += new System.EventHandler(this.btnAddAtendance_Click);
            // 
            // inputDateTime
            // 
            this.inputDateTime.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.inputDateTime.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.inputDateTime.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.inputDateTime.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.inputDateTime.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.inputDateTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.inputDateTime.Location = new System.Drawing.Point(128, 110);
            this.inputDateTime.Margin = new System.Windows.Forms.Padding(2);
            this.inputDateTime.Name = "inputDateTime";
            this.inputDateTime.Size = new System.Drawing.Size(270, 27);
            this.inputDateTime.TabIndex = 16;
            // 
            // labelProfit
            // 
            this.labelProfit.AutoSize = true;
            this.labelProfit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.labelProfit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelProfit.Location = new System.Drawing.Point(934, 256);
            this.labelProfit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProfit.Name = "labelProfit";
            this.labelProfit.Size = new System.Drawing.Size(0, 28);
            this.labelProfit.TabIndex = 18;
            // 
            // btnCalculateProfit
            // 
            this.btnCalculateProfit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnCalculateProfit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCalculateProfit.Location = new System.Drawing.Point(824, 250);
            this.btnCalculateProfit.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalculateProfit.Name = "btnCalculateProfit";
            this.btnCalculateProfit.Size = new System.Drawing.Size(103, 40);
            this.btnCalculateProfit.TabIndex = 17;
            this.btnCalculateProfit.Text = "Profit";
            this.btnCalculateProfit.UseVisualStyleBackColor = false;
            this.btnCalculateProfit.Click += new System.EventHandler(this.btnCalculateProfit_Click);
            // 
            // StaffID
            // 
            this.StaffID.AutoSize = true;
            this.StaffID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.StaffID.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.StaffID.Location = new System.Drawing.Point(8, 23);
            this.StaffID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StaffID.Name = "StaffID";
            this.StaffID.Size = new System.Drawing.Size(79, 28);
            this.StaffID.TabIndex = 19;
            this.StaffID.Text = "Staff ID:";
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Status.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Status.Location = new System.Drawing.Point(8, 66);
            this.Status.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(69, 28);
            this.Status.TabIndex = 20;
            this.Status.Text = "Status:";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Date.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Date.Location = new System.Drawing.Point(8, 110);
            this.Date.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(57, 28);
            this.Date.TabIndex = 21;
            this.Date.Text = "Date:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.StaffID);
            this.groupBox1.Controls.Add(this.Date);
            this.groupBox1.Controls.Add(this.inputStaffId);
            this.groupBox1.Controls.Add(this.btnAddAtendance);
            this.groupBox1.Controls.Add(this.inputDateTime);
            this.groupBox1.Controls.Add(this.Status);
            this.groupBox1.Controls.Add(this.inputStatus);
            this.groupBox1.Location = new System.Drawing.Point(23, 194);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(437, 191);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Attendance";
            // 
            // inputTimeShowAttendance
            // 
            this.inputTimeShowAttendance.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.inputTimeShowAttendance.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.inputTimeShowAttendance.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.inputTimeShowAttendance.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.inputTimeShowAttendance.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.inputTimeShowAttendance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.inputTimeShowAttendance.Location = new System.Drawing.Point(5, 93);
            this.inputTimeShowAttendance.Margin = new System.Windows.Forms.Padding(2);
            this.inputTimeShowAttendance.Name = "inputTimeShowAttendance";
            this.inputTimeShowAttendance.Size = new System.Drawing.Size(324, 34);
            this.inputTimeShowAttendance.TabIndex = 23;
            // 
            // optionShowAttendance
            // 
            this.optionShowAttendance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.optionShowAttendance.FormattingEnabled = true;
            this.optionShowAttendance.Location = new System.Drawing.Point(182, 26);
            this.optionShowAttendance.Margin = new System.Windows.Forms.Padding(2);
            this.optionShowAttendance.Name = "optionShowAttendance";
            this.optionShowAttendance.Size = new System.Drawing.Size(146, 36);
            this.optionShowAttendance.TabIndex = 24;
            this.optionShowAttendance.Text = "option";
            // 
            // inputTimeShowOrder
            // 
            this.inputTimeShowOrder.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.inputTimeShowOrder.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.inputTimeShowOrder.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.inputTimeShowOrder.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.inputTimeShowOrder.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.inputTimeShowOrder.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.inputTimeShowOrder.Location = new System.Drawing.Point(156, 21);
            this.inputTimeShowOrder.Margin = new System.Windows.Forms.Padding(2);
            this.inputTimeShowOrder.Name = "inputTimeShowOrder";
            this.inputTimeShowOrder.Size = new System.Drawing.Size(259, 27);
            this.inputTimeShowOrder.TabIndex = 25;
            // 
            // optionShowOrder
            // 
            this.optionShowOrder.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.optionShowOrder.FormattingEnabled = true;
            this.optionShowOrder.Location = new System.Drawing.Point(156, 66);
            this.optionShowOrder.Margin = new System.Windows.Forms.Padding(2);
            this.optionShowOrder.Name = "optionShowOrder";
            this.optionShowOrder.Size = new System.Drawing.Size(155, 36);
            this.optionShowOrder.TabIndex = 26;
            this.optionShowOrder.Text = "option";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.btnShowOrder);
            this.groupBox2.Controls.Add(this.optionShowOrder);
            this.groupBox2.Controls.Add(this.inputTimeShowOrder);
            this.groupBox2.Location = new System.Drawing.Point(23, 11);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(437, 129);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            // 
            // btnShowAttendance
            // 
            this.btnShowAttendance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnShowAttendance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnShowAttendance.Location = new System.Drawing.Point(5, 26);
            this.btnShowAttendance.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowAttendance.Name = "btnShowAttendance";
            this.btnShowAttendance.Size = new System.Drawing.Size(173, 36);
            this.btnShowAttendance.TabIndex = 28;
            this.btnShowAttendance.Text = "Show Attendance";
            this.btnShowAttendance.UseVisualStyleBackColor = false;
            this.btnShowAttendance.Click += new System.EventHandler(this.btnShowAttendance_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox3.Controls.Add(this.btnShowAttendance);
            this.groupBox3.Controls.Add(this.optionShowAttendance);
            this.groupBox3.Controls.Add(this.inputTimeShowAttendance);
            this.groupBox3.Location = new System.Drawing.Point(23, 389);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(437, 138);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Attendance";
            // 
            // btnExcelOrder
            // 
            this.btnExcelOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnExcelOrder.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnExcelOrder.Location = new System.Drawing.Point(1017, 0);
            this.btnExcelOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcelOrder.Name = "btnExcelOrder";
            this.btnExcelOrder.Size = new System.Drawing.Size(103, 40);
            this.btnExcelOrder.TabIndex = 30;
            this.btnExcelOrder.Text = "Excel";
            this.btnExcelOrder.UseVisualStyleBackColor = false;
            this.btnExcelOrder.Click += new System.EventHandler(this.btnExcelOrder_Click);
            // 
            // btnExcelStaff
            // 
            this.btnExcelStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnExcelStaff.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnExcelStaff.Location = new System.Drawing.Point(1017, 476);
            this.btnExcelStaff.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcelStaff.Name = "btnExcelStaff";
            this.btnExcelStaff.Size = new System.Drawing.Size(103, 40);
            this.btnExcelStaff.TabIndex = 31;
            this.btnExcelStaff.Text = "Excel";
            this.btnExcelStaff.UseVisualStyleBackColor = false;
            this.btnExcelStaff.Click += new System.EventHandler(this.btnExcelStaff_Click);
            // 
            // Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1154, 552);
            this.Controls.Add(this.btnExcelStaff);
            this.Controls.Add(this.btnExcelOrder);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.labelProfit);
            this.Controls.Add(this.btnCalculateProfit);
            this.Controls.Add(this.btnShowStaff);
            this.Controls.Add(this.TableShowStaff);
            this.Controls.Add(this.labelRevenue);
            this.Controls.Add(this.btnCalculateRevenue);
            this.Controls.Add(this.TableShowOrder);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Management";
            this.Text = "Management";
            ((System.ComponentModel.ISupportInitialize)(this.TableShowOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableShowStaff)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private Button btnExcelOrder;
        private Button btnExcelStaff;
    }
}