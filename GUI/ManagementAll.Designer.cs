using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
	partial class ManagementAll
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagementAll));
			TableShowOrder = new DataGridView();
			btnShowOrder = new Button();
			btnCalculateRevenue = new Button();
			labelRevenue = new Label();
			TableShowStaff = new DataGridView();
			btnAddStaff = new Button();
			inputName = new TextBox();
			inputSalary = new TextBox();
			inputShift = new ComboBox();
			inputUserId = new ComboBox();
			labelProfit = new Label();
			btnCalculateProfit = new Button();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			StoreId = new Label();
			groupBox1 = new GroupBox();
			inputStaffId = new TextBox();
			label4 = new Label();
			btnUpdateStaff = new Button();
			btnDeleteStaff = new Button();
			optionShowOrder = new ComboBox();
			inputTimeShowOrder = new DateTimePicker();
			groupBox2 = new GroupBox();
			btnClearAll = new Button();
			btnUpdateProduct = new Button();
			groupBox4 = new GroupBox();
			inputProductQuantity = new TextBox();
			inputProductCost = new TextBox();
			inputProductPrice = new TextBox();
			inputProductName = new TextBox();
			inputProductId = new TextBox();
			label5 = new Label();
			label6 = new Label();
			label7 = new Label();
			label8 = new Label();
			label9 = new Label();
			btnShowProduct = new Button();
			((System.ComponentModel.ISupportInitialize)TableShowOrder).BeginInit();
			((System.ComponentModel.ISupportInitialize)TableShowStaff).BeginInit();
			groupBox1.SuspendLayout();
			groupBox4.SuspendLayout();
			SuspendLayout();
			// 
			// TableShowOrder
			// 
			TableShowOrder.BackgroundColor = Color.White;
			TableShowOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			TableShowOrder.Location = new Point(577, 42);
			TableShowOrder.Name = "TableShowOrder";
			TableShowOrder.RowHeadersWidth = 62;
			TableShowOrder.RowTemplate.Height = 33;
			TableShowOrder.Size = new Size(724, 295);
			TableShowOrder.TabIndex = 0;
			TableShowOrder.RowHeaderMouseClick += TableShowOrder_RowHeaderMouseClick;
			// 
			// btnShowOrder
			// 
			btnShowOrder.BackColor = Color.FromArgb(255, 192, 128);
			btnShowOrder.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btnShowOrder.Location = new Point(74, 72);
			btnShowOrder.Name = "btnShowOrder";
			btnShowOrder.Size = new Size(154, 50);
			btnShowOrder.TabIndex = 1;
			btnShowOrder.Text = "Show Order";
			btnShowOrder.UseVisualStyleBackColor = false;
			btnShowOrder.Click += btnShowOrder_Click_1;
			// 
			// btnCalculateRevenue
			// 
			btnCalculateRevenue.BackColor = Color.FromArgb(255, 192, 128);
			btnCalculateRevenue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btnCalculateRevenue.Location = new Point(577, 352);
			btnCalculateRevenue.Name = "btnCalculateRevenue";
			btnCalculateRevenue.Size = new Size(118, 45);
			btnCalculateRevenue.TabIndex = 2;
			btnCalculateRevenue.Text = "Revenue";
			btnCalculateRevenue.UseVisualStyleBackColor = false;
			btnCalculateRevenue.Click += btnCalculateRevenue_Click;
			// 
			// labelRevenue
			// 
			labelRevenue.AutoSize = true;
			labelRevenue.BackColor = Color.FromArgb(255, 192, 128);
			labelRevenue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			labelRevenue.Location = new Point(701, 359);
			labelRevenue.Name = "labelRevenue";
			labelRevenue.Size = new Size(0, 32);
			labelRevenue.TabIndex = 3;
			// 
			// TableShowStaff
			// 
			TableShowStaff.BackgroundColor = Color.White;
			TableShowStaff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			TableShowStaff.Location = new Point(577, 454);
			TableShowStaff.Name = "TableShowStaff";
			TableShowStaff.RowHeadersWidth = 62;
			TableShowStaff.RowTemplate.Height = 33;
			TableShowStaff.Size = new Size(724, 312);
			TableShowStaff.TabIndex = 4;
			TableShowStaff.RowHeaderMouseClick += TableShowStaff_RowHeaderMouseClick;
			// 
			// btnAddStaff
			// 
			btnAddStaff.BackColor = Color.FromArgb(255, 192, 128);
			btnAddStaff.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btnAddStaff.Location = new Point(577, 787);
			btnAddStaff.Name = "btnAddStaff";
			btnAddStaff.Size = new Size(124, 46);
			btnAddStaff.TabIndex = 5;
			btnAddStaff.Text = "Add Staff";
			btnAddStaff.UseVisualStyleBackColor = false;
			btnAddStaff.Click += btnAddStaff_Click;
			// 
			// inputName
			// 
			inputName.BackColor = Color.White;
			inputName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			inputName.Location = new Point(167, 89);
			inputName.Name = "inputName";
			inputName.Size = new Size(150, 39);
			inputName.TabIndex = 6;
			// 
			// inputSalary
			// 
			inputSalary.BackColor = Color.White;
			inputSalary.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			inputSalary.Location = new Point(167, 204);
			inputSalary.Name = "inputSalary";
			inputSalary.Size = new Size(150, 39);
			inputSalary.TabIndex = 8;
			// 
			// inputShift
			// 
			inputShift.BackColor = Color.White;
			inputShift.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			inputShift.FormattingEnabled = true;
			inputShift.Location = new Point(167, 147);
			inputShift.Name = "inputShift";
			inputShift.Size = new Size(182, 40);
			inputShift.TabIndex = 10;
			// 
			// inputUserId
			// 
			inputUserId.BackColor = Color.White;
			inputUserId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			inputUserId.FormattingEnabled = true;
			inputUserId.Location = new Point(167, 265);
			inputUserId.Name = "inputUserId";
			inputUserId.Size = new Size(182, 40);
			inputUserId.TabIndex = 11;
			// 
			// labelProfit
			// 
			labelProfit.AutoSize = true;
			labelProfit.BackColor = Color.FromArgb(255, 192, 128);
			labelProfit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			labelProfit.Location = new Point(984, 364);
			labelProfit.Name = "labelProfit";
			labelProfit.Size = new Size(0, 32);
			labelProfit.TabIndex = 13;
			// 
			// btnCalculateProfit
			// 
			btnCalculateProfit.BackColor = Color.FromArgb(255, 192, 128);
			btnCalculateProfit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btnCalculateProfit.Location = new Point(866, 352);
			btnCalculateProfit.Name = "btnCalculateProfit";
			btnCalculateProfit.Size = new Size(112, 45);
			btnCalculateProfit.TabIndex = 12;
			btnCalculateProfit.Text = "Profit";
			btnCalculateProfit.UseVisualStyleBackColor = false;
			btnCalculateProfit.Click += btnCalculateProfit_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.FromArgb(255, 192, 128);
			label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(77, 89);
			label1.Name = "label1";
			label1.Size = new Size(83, 32);
			label1.TabIndex = 14;
			label1.Text = "Name:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.BackColor = Color.FromArgb(255, 192, 128);
			label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label2.Location = new Point(83, 147);
			label2.Name = "label2";
			label2.Size = new Size(78, 32);
			label2.TabIndex = 15;
			label2.Text = "Shifts:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.BackColor = Color.FromArgb(255, 192, 128);
			label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label3.Location = new Point(78, 211);
			label3.Name = "label3";
			label3.Size = new Size(82, 32);
			label3.TabIndex = 16;
			label3.Text = "Salary:";
			// 
			// StoreId
			// 
			StoreId.AutoSize = true;
			StoreId.BackColor = Color.FromArgb(255, 192, 128);
			StoreId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			StoreId.Location = new Point(67, 268);
			StoreId.Name = "StoreId";
			StoreId.Size = new Size(94, 32);
			StoreId.TabIndex = 17;
			StoreId.Text = "StoreId:";
			// 
			// groupBox1
			// 
			groupBox1.BackColor = Color.FromArgb(255, 224, 192);
			groupBox1.Controls.Add(inputStaffId);
			groupBox1.Controls.Add(label4);
			groupBox1.Controls.Add(StoreId);
			groupBox1.Controls.Add(inputUserId);
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(inputSalary);
			groupBox1.Controls.Add(label1);
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(inputName);
			groupBox1.Controls.Add(inputShift);
			groupBox1.Location = new Point(157, 454);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(393, 312);
			groupBox1.TabIndex = 18;
			groupBox1.TabStop = false;
			groupBox1.Text = "Staff Information";
			// 
			// inputStaffId
			// 
			inputStaffId.BackColor = Color.White;
			inputStaffId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			inputStaffId.Location = new Point(166, 30);
			inputStaffId.Name = "inputStaffId";
			inputStaffId.ReadOnly = true;
			inputStaffId.Size = new Size(150, 39);
			inputStaffId.TabIndex = 19;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.BackColor = Color.FromArgb(255, 192, 128);
			label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label4.Location = new Point(73, 36);
			label4.Name = "label4";
			label4.Size = new Size(87, 32);
			label4.TabIndex = 18;
			label4.Text = "StaffId:";
			// 
			// btnUpdateStaff
			// 
			btnUpdateStaff.BackColor = Color.FromArgb(255, 192, 128);
			btnUpdateStaff.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btnUpdateStaff.Location = new Point(850, 787);
			btnUpdateStaff.Name = "btnUpdateStaff";
			btnUpdateStaff.Size = new Size(171, 46);
			btnUpdateStaff.TabIndex = 19;
			btnUpdateStaff.Text = "Update Staff";
			btnUpdateStaff.UseVisualStyleBackColor = false;
			btnUpdateStaff.Click += btnUpdateStaff_Click;
			// 
			// btnDeleteStaff
			// 
			btnDeleteStaff.BackColor = Color.FromArgb(255, 192, 128);
			btnDeleteStaff.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btnDeleteStaff.Location = new Point(1129, 787);
			btnDeleteStaff.Name = "btnDeleteStaff";
			btnDeleteStaff.Size = new Size(124, 46);
			btnDeleteStaff.TabIndex = 20;
			btnDeleteStaff.Text = "Delete Staff";
			btnDeleteStaff.UseVisualStyleBackColor = false;
			btnDeleteStaff.Click += btnDeleteStaff_Click;
			// 
			// optionShowOrder
			// 
			optionShowOrder.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			optionShowOrder.FormattingEnabled = true;
			optionShowOrder.Location = new Point(245, 128);
			optionShowOrder.Name = "optionShowOrder";
			optionShowOrder.Size = new Size(182, 40);
			optionShowOrder.TabIndex = 28;
			optionShowOrder.Text = "option";
			// 
			// inputTimeShowOrder
			// 
			inputTimeShowOrder.CalendarForeColor = Color.FromArgb(255, 192, 128);
			inputTimeShowOrder.CalendarMonthBackground = Color.FromArgb(255, 192, 128);
			inputTimeShowOrder.CalendarTitleBackColor = Color.FromArgb(255, 192, 128);
			inputTimeShowOrder.CalendarTitleForeColor = Color.FromArgb(255, 192, 128);
			inputTimeShowOrder.CalendarTrailingForeColor = Color.FromArgb(255, 192, 128);
			inputTimeShowOrder.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			inputTimeShowOrder.Location = new Point(245, 79);
			inputTimeShowOrder.Name = "inputTimeShowOrder";
			inputTimeShowOrder.Size = new Size(292, 31);
			inputTimeShowOrder.TabIndex = 27;
			// 
			// groupBox2
			// 
			groupBox2.BackColor = Color.FromArgb(255, 224, 192);
			groupBox2.Location = new Point(48, 42);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(502, 164);
			groupBox2.TabIndex = 29;
			groupBox2.TabStop = false;
			groupBox2.Text = "Option Show Table";
			// 
			// btnClearAll
			// 
			btnClearAll.BackColor = Color.FromArgb(255, 192, 128);
			btnClearAll.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btnClearAll.Location = new Point(323, 787);
			btnClearAll.Name = "btnClearAll";
			btnClearAll.Size = new Size(124, 46);
			btnClearAll.TabIndex = 30;
			btnClearAll.Text = "Clear All";
			btnClearAll.UseVisualStyleBackColor = false;
			btnClearAll.Click += btnClearAll_Click;
			// 
			// btnUpdateProduct
			// 
			btnUpdateProduct.BackColor = Color.FromArgb(255, 192, 128);
			btnUpdateProduct.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btnUpdateProduct.Location = new Point(1463, 352);
			btnUpdateProduct.Name = "btnUpdateProduct";
			btnUpdateProduct.Size = new Size(208, 44);
			btnUpdateProduct.TabIndex = 34;
			btnUpdateProduct.Text = "Update Product";
			btnUpdateProduct.UseVisualStyleBackColor = false;
			btnUpdateProduct.Click += btnUpdateProduct_Click;
			// 
			// groupBox4
			// 
			groupBox4.BackColor = Color.FromArgb(255, 224, 192);
			groupBox4.Controls.Add(inputProductQuantity);
			groupBox4.Controls.Add(inputProductCost);
			groupBox4.Controls.Add(inputProductPrice);
			groupBox4.Controls.Add(inputProductName);
			groupBox4.Controls.Add(inputProductId);
			groupBox4.Controls.Add(label5);
			groupBox4.Controls.Add(label6);
			groupBox4.Controls.Add(label7);
			groupBox4.Controls.Add(label8);
			groupBox4.Controls.Add(label9);
			groupBox4.Location = new Point(1361, 42);
			groupBox4.Name = "groupBox4";
			groupBox4.Size = new Size(410, 295);
			groupBox4.TabIndex = 33;
			groupBox4.TabStop = false;
			groupBox4.Text = "Product Infomation";
			// 
			// inputProductQuantity
			// 
			inputProductQuantity.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
			inputProductQuantity.Location = new Point(142, 219);
			inputProductQuantity.Name = "inputProductQuantity";
			inputProductQuantity.Size = new Size(208, 37);
			inputProductQuantity.TabIndex = 29;
			// 
			// inputProductCost
			// 
			inputProductCost.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
			inputProductCost.Location = new Point(142, 177);
			inputProductCost.Name = "inputProductCost";
			inputProductCost.Size = new Size(208, 37);
			inputProductCost.TabIndex = 28;
			// 
			// inputProductPrice
			// 
			inputProductPrice.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
			inputProductPrice.Location = new Point(142, 134);
			inputProductPrice.Name = "inputProductPrice";
			inputProductPrice.Size = new Size(208, 37);
			inputProductPrice.TabIndex = 27;
			// 
			// inputProductName
			// 
			inputProductName.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
			inputProductName.Location = new Point(142, 91);
			inputProductName.Name = "inputProductName";
			inputProductName.Size = new Size(208, 37);
			inputProductName.TabIndex = 26;
			// 
			// inputProductId
			// 
			inputProductId.BackColor = Color.White;
			inputProductId.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
			inputProductId.Location = new Point(142, 39);
			inputProductId.Name = "inputProductId";
			inputProductId.ReadOnly = true;
			inputProductId.Size = new Size(208, 37);
			inputProductId.TabIndex = 25;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.BackColor = Color.FromArgb(255, 192, 128);
			label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label5.Location = new Point(14, 224);
			label5.Name = "label5";
			label5.Size = new Size(111, 32);
			label5.TabIndex = 24;
			label5.Text = "Quantity:";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.BackColor = Color.FromArgb(255, 192, 128);
			label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label6.Location = new Point(59, 176);
			label6.Name = "label6";
			label6.Size = new Size(66, 32);
			label6.TabIndex = 23;
			label6.Text = "Cost:";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.BackColor = Color.FromArgb(255, 192, 128);
			label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label7.Location = new Point(55, 133);
			label7.Name = "label7";
			label7.Size = new Size(70, 32);
			label7.TabIndex = 22;
			label7.Text = "Price:";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.BackColor = Color.FromArgb(255, 192, 128);
			label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label8.Location = new Point(42, 91);
			label8.Name = "label8";
			label8.Size = new Size(83, 32);
			label8.TabIndex = 21;
			label8.Text = "Name:";
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.BackColor = Color.FromArgb(255, 192, 128);
			label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label9.Location = new Point(76, 44);
			label9.Name = "label9";
			label9.Size = new Size(49, 32);
			label9.TabIndex = 20;
			label9.Text = " ID:";
			// 
			// btnShowProduct
			// 
			btnShowProduct.BackColor = Color.FromArgb(255, 192, 128);
			btnShowProduct.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btnShowProduct.Location = new Point(1124, 353);
			btnShowProduct.Name = "btnShowProduct";
			btnShowProduct.Size = new Size(177, 44);
			btnShowProduct.TabIndex = 35;
			btnShowProduct.Text = "Show Product";
			btnShowProduct.UseVisualStyleBackColor = false;
			btnShowProduct.Click += btnShowProduct_Click;
			// 
			// ManagementAll
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
			ClientSize = new Size(1836, 887);
			Controls.Add(btnShowProduct);
			Controls.Add(btnUpdateProduct);
			Controls.Add(groupBox4);
			Controls.Add(btnClearAll);
			Controls.Add(optionShowOrder);
			Controls.Add(inputTimeShowOrder);
			Controls.Add(btnDeleteStaff);
			Controls.Add(btnUpdateStaff);
			Controls.Add(labelProfit);
			Controls.Add(btnCalculateProfit);
			Controls.Add(btnAddStaff);
			Controls.Add(TableShowStaff);
			Controls.Add(labelRevenue);
			Controls.Add(btnCalculateRevenue);
			Controls.Add(btnShowOrder);
			Controls.Add(TableShowOrder);
			Controls.Add(groupBox1);
			Controls.Add(groupBox2);
			Name = "ManagementAll";
			Text = "ManagementAll";
			((System.ComponentModel.ISupportInitialize)TableShowOrder).EndInit();
			((System.ComponentModel.ISupportInitialize)TableShowStaff).EndInit();
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			groupBox4.ResumeLayout(false);
			groupBox4.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView TableShowOrder;
		private Button btnShowOrder;
		private Button btnCalculateRevenue;
		private Label labelRevenue;
		private DataGridView TableShowStaff;
		private Button btnAddStaff;
		private TextBox inputName;
		private TextBox inputSalary;
		private ComboBox inputShift;
		private ComboBox inputUserId;
		private Label labelProfit;
		private Button btnCalculateProfit;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label StoreId;
		private GroupBox groupBox1;
		private Button btnUpdateStaff;
		private Button btnDeleteStaff;
		private ComboBox optionShowOrder;
		private DateTimePicker inputTimeShowOrder;
		private GroupBox groupBox2;
		private TextBox inputStaffId;
		private Label label4;
		private Button btnClearAll;
		private Button btnUpdateProduct;
		private GroupBox groupBox4;
		private TextBox inputProductQuantity;
		private TextBox inputProductCost;
		private TextBox inputProductPrice;
		private TextBox inputProductName;
		private TextBox inputProductId;
		private Label label5;
		private Label label6;
		private Label label7;
		private Label label8;
		private Label label9;
		private Button btnShowProduct;
	}
}