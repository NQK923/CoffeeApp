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
            this.TableShowOrder = new System.Windows.Forms.DataGridView();
            this.btnShowOrder = new System.Windows.Forms.Button();
            this.btnCalculateRevenue = new System.Windows.Forms.Button();
            this.labelRevenue = new System.Windows.Forms.Label();
            this.TableShowStaff = new System.Windows.Forms.DataGridView();
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.inputName = new System.Windows.Forms.TextBox();
            this.inputSalary = new System.Windows.Forms.TextBox();
            this.inputShift = new System.Windows.Forms.ComboBox();
            this.inputUserId = new System.Windows.Forms.ComboBox();
            this.labelProfit = new System.Windows.Forms.Label();
            this.btnCalculateProfit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.StoreId = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.inputStaffId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnUpdateStaff = new System.Windows.Forms.Button();
            this.btnDeleteStaff = new System.Windows.Forms.Button();
            this.optionShowOrder = new System.Windows.Forms.ComboBox();
            this.inputTimeShowOrder = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.inputProductQuantity = new System.Windows.Forms.TextBox();
            this.inputProductCost = new System.Windows.Forms.TextBox();
            this.inputProductPrice = new System.Windows.Forms.TextBox();
            this.inputProductName = new System.Windows.Forms.TextBox();
            this.inputProductId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnShowProduct = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.PictureBox();
            this.btnExcelOrder = new System.Windows.Forms.Button();
            this.btnExcelStaff = new System.Windows.Forms.Button();
            this.labelSearch = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonClearSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TableShowOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableShowStaff)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogout)).BeginInit();
            this.SuspendLayout();
            // 
            // TableShowOrder
            // 
            this.TableShowOrder.BackgroundColor = System.Drawing.Color.White;
            this.TableShowOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableShowOrder.Location = new System.Drawing.Point(360, 12);
            this.TableShowOrder.Margin = new System.Windows.Forms.Padding(2);
            this.TableShowOrder.Name = "TableShowOrder";
            this.TableShowOrder.RowHeadersWidth = 62;
            this.TableShowOrder.RowTemplate.Height = 33;
            this.TableShowOrder.Size = new System.Drawing.Size(579, 172);
            this.TableShowOrder.TabIndex = 0;
            this.TableShowOrder.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.TableShowOrder_RowHeaderMouseClick);
            // 
            // btnShowOrder
            // 
            this.btnShowOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnShowOrder.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnShowOrder.Location = new System.Drawing.Point(29, 111);
            this.btnShowOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowOrder.Name = "btnShowOrder";
            this.btnShowOrder.Size = new System.Drawing.Size(146, 34);
            this.btnShowOrder.TabIndex = 1;
            this.btnShowOrder.Text = "Show Order";
            this.btnShowOrder.UseVisualStyleBackColor = false;
            this.btnShowOrder.Click += new System.EventHandler(this.btnShowOrder_Click);
            // 
            // btnCalculateRevenue
            // 
            this.btnCalculateRevenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnCalculateRevenue.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCalculateRevenue.Location = new System.Drawing.Point(360, 194);
            this.btnCalculateRevenue.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalculateRevenue.Name = "btnCalculateRevenue";
            this.btnCalculateRevenue.Size = new System.Drawing.Size(108, 36);
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
            this.labelRevenue.Location = new System.Drawing.Point(380, 232);
            this.labelRevenue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRevenue.Name = "labelRevenue";
            this.labelRevenue.Size = new System.Drawing.Size(0, 28);
            this.labelRevenue.TabIndex = 3;
            // 
            // TableShowStaff
            // 
            this.TableShowStaff.BackgroundColor = System.Drawing.Color.White;
            this.TableShowStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableShowStaff.Location = new System.Drawing.Point(360, 308);
            this.TableShowStaff.Margin = new System.Windows.Forms.Padding(2);
            this.TableShowStaff.Name = "TableShowStaff";
            this.TableShowStaff.RowHeadersWidth = 62;
            this.TableShowStaff.RowTemplate.Height = 33;
            this.TableShowStaff.Size = new System.Drawing.Size(579, 182);
            this.TableShowStaff.TabIndex = 4;
            this.TableShowStaff.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.TableShowStaff_RowHeaderMouseClick);
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAddStaff.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAddStaff.Location = new System.Drawing.Point(360, 494);
            this.btnAddStaff.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(112, 36);
            this.btnAddStaff.TabIndex = 5;
            this.btnAddStaff.Text = "Add Staff";
            this.btnAddStaff.UseVisualStyleBackColor = false;
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // inputName
            // 
            this.inputName.BackColor = System.Drawing.Color.White;
            this.inputName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.inputName.Location = new System.Drawing.Point(111, 60);
            this.inputName.Margin = new System.Windows.Forms.Padding(2);
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(146, 34);
            this.inputName.TabIndex = 6;
            // 
            // inputSalary
            // 
            this.inputSalary.BackColor = System.Drawing.Color.White;
            this.inputSalary.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.inputSalary.Location = new System.Drawing.Point(111, 138);
            this.inputSalary.Margin = new System.Windows.Forms.Padding(2);
            this.inputSalary.Name = "inputSalary";
            this.inputSalary.Size = new System.Drawing.Size(146, 34);
            this.inputSalary.TabIndex = 8;
            // 
            // inputShift
            // 
            this.inputShift.BackColor = System.Drawing.Color.White;
            this.inputShift.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.inputShift.FormattingEnabled = true;
            this.inputShift.Location = new System.Drawing.Point(111, 98);
            this.inputShift.Margin = new System.Windows.Forms.Padding(2);
            this.inputShift.Name = "inputShift";
            this.inputShift.Size = new System.Drawing.Size(146, 36);
            this.inputShift.TabIndex = 10;
            // 
            // inputUserId
            // 
            this.inputUserId.BackColor = System.Drawing.Color.White;
            this.inputUserId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.inputUserId.FormattingEnabled = true;
            this.inputUserId.Location = new System.Drawing.Point(111, 176);
            this.inputUserId.Margin = new System.Windows.Forms.Padding(2);
            this.inputUserId.Name = "inputUserId";
            this.inputUserId.Size = new System.Drawing.Size(146, 36);
            this.inputUserId.TabIndex = 11;
            // 
            // labelProfit
            // 
            this.labelProfit.AutoSize = true;
            this.labelProfit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.labelProfit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelProfit.Location = new System.Drawing.Point(589, 232);
            this.labelProfit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProfit.Name = "labelProfit";
            this.labelProfit.Size = new System.Drawing.Size(0, 28);
            this.labelProfit.TabIndex = 13;
            // 
            // btnCalculateProfit
            // 
            this.btnCalculateProfit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnCalculateProfit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCalculateProfit.Location = new System.Drawing.Point(516, 195);
            this.btnCalculateProfit.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalculateProfit.Name = "btnCalculateProfit";
            this.btnCalculateProfit.Size = new System.Drawing.Size(90, 36);
            this.btnCalculateProfit.TabIndex = 12;
            this.btnCalculateProfit.Text = "Profit";
            this.btnCalculateProfit.UseVisualStyleBackColor = false;
            this.btnCalculateProfit.Click += new System.EventHandler(this.btnCalculateProfit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(19, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 28);
            this.label1.TabIndex = 14;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(19, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 28);
            this.label2.TabIndex = 15;
            this.label2.Text = "Shifts:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(19, 141);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 28);
            this.label3.TabIndex = 16;
            this.label3.Text = "Salary:";
            // 
            // StoreId
            // 
            this.StoreId.AutoSize = true;
            this.StoreId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.StoreId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.StoreId.Location = new System.Drawing.Point(19, 179);
            this.StoreId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StoreId.Name = "StoreId";
            this.StoreId.Size = new System.Drawing.Size(79, 28);
            this.StoreId.TabIndex = 17;
            this.StoreId.Text = "StoreId:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.inputStaffId);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.StoreId);
            this.groupBox1.Controls.Add(this.btnClearAll);
            this.groupBox1.Controls.Add(this.inputUserId);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.inputSalary);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.inputName);
            this.groupBox1.Controls.Add(this.inputShift);
            this.groupBox1.Location = new System.Drawing.Point(43, 249);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(280, 281);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Staff Information";
            // 
            // inputStaffId
            // 
            this.inputStaffId.BackColor = System.Drawing.Color.White;
            this.inputStaffId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.inputStaffId.Location = new System.Drawing.Point(111, 22);
            this.inputStaffId.Margin = new System.Windows.Forms.Padding(2);
            this.inputStaffId.Name = "inputStaffId";
            this.inputStaffId.ReadOnly = true;
            this.inputStaffId.Size = new System.Drawing.Size(146, 34);
            this.inputStaffId.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.Location = new System.Drawing.Point(19, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 28);
            this.label4.TabIndex = 18;
            this.label4.Text = "StaffId:";
            // 
            // btnClearAll
            // 
            this.btnClearAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnClearAll.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnClearAll.Location = new System.Drawing.Point(111, 214);
            this.btnClearAll.Margin = new System.Windows.Forms.Padding(2);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(122, 40);
            this.btnClearAll.TabIndex = 30;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = false;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnUpdateStaff
            // 
            this.btnUpdateStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnUpdateStaff.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnUpdateStaff.Location = new System.Drawing.Point(506, 494);
            this.btnUpdateStaff.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateStaff.Name = "btnUpdateStaff";
            this.btnUpdateStaff.Size = new System.Drawing.Size(136, 36);
            this.btnUpdateStaff.TabIndex = 19;
            this.btnUpdateStaff.Text = "Update Staff";
            this.btnUpdateStaff.UseVisualStyleBackColor = false;
            this.btnUpdateStaff.Click += new System.EventHandler(this.btnUpdateStaff_Click);
            // 
            // btnDeleteStaff
            // 
            this.btnDeleteStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnDeleteStaff.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnDeleteStaff.Location = new System.Drawing.Point(680, 494);
            this.btnDeleteStaff.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteStaff.Name = "btnDeleteStaff";
            this.btnDeleteStaff.Size = new System.Drawing.Size(109, 36);
            this.btnDeleteStaff.TabIndex = 20;
            this.btnDeleteStaff.Text = "Delete Staff";
            this.btnDeleteStaff.UseVisualStyleBackColor = false;
            this.btnDeleteStaff.Click += new System.EventHandler(this.btnDeleteStaff_Click);
            // 
            // optionShowOrder
            // 
            this.optionShowOrder.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.optionShowOrder.FormattingEnabled = true;
            this.optionShowOrder.Location = new System.Drawing.Point(29, 58);
            this.optionShowOrder.Margin = new System.Windows.Forms.Padding(2);
            this.optionShowOrder.Name = "optionShowOrder";
            this.optionShowOrder.Size = new System.Drawing.Size(146, 36);
            this.optionShowOrder.TabIndex = 28;
            this.optionShowOrder.Text = "option";
            // 
            // inputTimeShowOrder
            // 
            this.inputTimeShowOrder.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.inputTimeShowOrder.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.inputTimeShowOrder.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.inputTimeShowOrder.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.inputTimeShowOrder.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.inputTimeShowOrder.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.inputTimeShowOrder.Location = new System.Drawing.Point(29, 24);
            this.inputTimeShowOrder.Margin = new System.Windows.Forms.Padding(2);
            this.inputTimeShowOrder.Name = "inputTimeShowOrder";
            this.inputTimeShowOrder.Size = new System.Drawing.Size(252, 27);
            this.inputTimeShowOrder.TabIndex = 27;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.btnShowOrder);
            this.groupBox2.Controls.Add(this.inputTimeShowOrder);
            this.groupBox2.Controls.Add(this.optionShowOrder);
            this.groupBox2.Location = new System.Drawing.Point(38, 11);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(285, 171);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Option Show Table";
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnUpdateProduct.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnUpdateProduct.Location = new System.Drawing.Point(114, 205);
            this.btnUpdateProduct.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(167, 39);
            this.btnUpdateProduct.TabIndex = 34;
            this.btnUpdateProduct.Text = "Update Product";
            this.btnUpdateProduct.UseVisualStyleBackColor = false;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox4.Controls.Add(this.inputProductQuantity);
            this.groupBox4.Controls.Add(this.btnUpdateProduct);
            this.groupBox4.Controls.Add(this.inputProductCost);
            this.groupBox4.Controls.Add(this.inputProductPrice);
            this.groupBox4.Controls.Add(this.inputProductName);
            this.groupBox4.Controls.Add(this.inputProductId);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Location = new System.Drawing.Point(965, 12);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(302, 257);
            this.groupBox4.TabIndex = 33;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Product Infomation";
            // 
            // inputProductQuantity
            // 
            this.inputProductQuantity.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.inputProductQuantity.Location = new System.Drawing.Point(114, 169);
            this.inputProductQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.inputProductQuantity.Name = "inputProductQuantity";
            this.inputProductQuantity.Size = new System.Drawing.Size(167, 32);
            this.inputProductQuantity.TabIndex = 29;
            // 
            // inputProductCost
            // 
            this.inputProductCost.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.inputProductCost.Location = new System.Drawing.Point(114, 133);
            this.inputProductCost.Margin = new System.Windows.Forms.Padding(2);
            this.inputProductCost.Name = "inputProductCost";
            this.inputProductCost.Size = new System.Drawing.Size(167, 32);
            this.inputProductCost.TabIndex = 28;
            // 
            // inputProductPrice
            // 
            this.inputProductPrice.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.inputProductPrice.Location = new System.Drawing.Point(114, 97);
            this.inputProductPrice.Margin = new System.Windows.Forms.Padding(2);
            this.inputProductPrice.Name = "inputProductPrice";
            this.inputProductPrice.Size = new System.Drawing.Size(167, 32);
            this.inputProductPrice.TabIndex = 27;
            // 
            // inputProductName
            // 
            this.inputProductName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.inputProductName.Location = new System.Drawing.Point(114, 61);
            this.inputProductName.Margin = new System.Windows.Forms.Padding(2);
            this.inputProductName.Name = "inputProductName";
            this.inputProductName.Size = new System.Drawing.Size(167, 32);
            this.inputProductName.TabIndex = 26;
            // 
            // inputProductId
            // 
            this.inputProductId.BackColor = System.Drawing.Color.White;
            this.inputProductId.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.inputProductId.Location = new System.Drawing.Point(114, 25);
            this.inputProductId.Margin = new System.Windows.Forms.Padding(2);
            this.inputProductId.Name = "inputProductId";
            this.inputProductId.ReadOnly = true;
            this.inputProductId.Size = new System.Drawing.Size(167, 32);
            this.inputProductId.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.Location = new System.Drawing.Point(10, 169);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 28);
            this.label5.TabIndex = 24;
            this.label5.Text = "Quantity:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label6.Location = new System.Drawing.Point(47, 133);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 28);
            this.label6.TabIndex = 23;
            this.label6.Text = "Cost:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label7.Location = new System.Drawing.Point(44, 97);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 28);
            this.label7.TabIndex = 22;
            this.label7.Text = "Price:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label8.Location = new System.Drawing.Point(34, 61);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 28);
            this.label8.TabIndex = 21;
            this.label8.Text = "Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label9.Location = new System.Drawing.Point(62, 25);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 28);
            this.label9.TabIndex = 20;
            this.label9.Text = " ID:";
            // 
            // btnShowProduct
            // 
            this.btnShowProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnShowProduct.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnShowProduct.Location = new System.Drawing.Point(635, 196);
            this.btnShowProduct.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowProduct.Name = "btnShowProduct";
            this.btnShowProduct.Size = new System.Drawing.Size(154, 35);
            this.btnShowProduct.TabIndex = 35;
            this.btnShowProduct.Text = "Show Product";
            this.btnShowProduct.UseVisualStyleBackColor = false;
            this.btnShowProduct.Click += new System.EventHandler(this.btnShowProduct_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Image = global::GUI.Properties.Resources.logout_logo;
            this.btnLogout.Location = new System.Drawing.Point(1227, 274);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(40, 40);
            this.btnLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnLogout.TabIndex = 106;
            this.btnLogout.TabStop = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnExcelOrder
            // 
            this.btnExcelOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnExcelOrder.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnExcelOrder.Location = new System.Drawing.Point(830, 194);
            this.btnExcelOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcelOrder.Name = "btnExcelOrder";
            this.btnExcelOrder.Size = new System.Drawing.Size(109, 36);
            this.btnExcelOrder.TabIndex = 107;
            this.btnExcelOrder.Text = "Excel";
            this.btnExcelOrder.UseVisualStyleBackColor = false;
            this.btnExcelOrder.Click += new System.EventHandler(this.btnExcelOrder_Click);
            // 
            // btnExcelStaff
            // 
            this.btnExcelStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnExcelStaff.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnExcelStaff.Location = new System.Drawing.Point(830, 494);
            this.btnExcelStaff.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcelStaff.Name = "btnExcelStaff";
            this.btnExcelStaff.Size = new System.Drawing.Size(109, 36);
            this.btnExcelStaff.TabIndex = 108;
            this.btnExcelStaff.Text = "Excel";
            this.btnExcelStaff.UseVisualStyleBackColor = false;
            this.btnExcelStaff.Click += new System.EventHandler(this.btnExcelStaff_Click);
            // 
            // labelSearch
            // 
            this.labelSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.labelSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelSearch.Location = new System.Drawing.Point(965, 308);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelSearch.Size = new System.Drawing.Size(139, 32);
            this.labelSearch.TabIndex = 109;
            this.labelSearch.Text = "Search Staff ";
            this.labelSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSearch.Location = new System.Drawing.Point(965, 337);
            this.textBoxSearch.Multiline = true;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(218, 41);
            this.textBoxSearch.TabIndex = 110;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // buttonClearSearch
            // 
            this.buttonClearSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonClearSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonClearSearch.Location = new System.Drawing.Point(1181, 337);
            this.buttonClearSearch.Name = "buttonClearSearch";
            this.buttonClearSearch.Size = new System.Drawing.Size(86, 41);
            this.buttonClearSearch.TabIndex = 111;
            this.buttonClearSearch.Text = "Clear";
            this.buttonClearSearch.UseVisualStyleBackColor = false;
            this.buttonClearSearch.Click += new System.EventHandler(this.buttonClaer_Click);
            // 
            // ManagementAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1287, 551);
            this.Controls.Add(this.buttonClearSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.btnExcelStaff);
            this.Controls.Add(this.btnExcelOrder);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnShowProduct);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnDeleteStaff);
            this.Controls.Add(this.btnUpdateStaff);
            this.Controls.Add(this.labelProfit);
            this.Controls.Add(this.btnCalculateProfit);
            this.Controls.Add(this.btnAddStaff);
            this.Controls.Add(this.TableShowStaff);
            this.Controls.Add(this.labelRevenue);
            this.Controls.Add(this.btnCalculateRevenue);
            this.Controls.Add(this.TableShowOrder);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ManagementAll";
            this.Text = "ManagementAll";
            ((System.ComponentModel.ISupportInitialize)(this.TableShowOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableShowStaff)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private PictureBox btnLogout;
        private Button btnExcelOrder;
        private Button btnExcelStaff;
        private Label labelSearch;
        private TextBox textBoxSearch;
        private Button buttonClearSearch;
    }
}