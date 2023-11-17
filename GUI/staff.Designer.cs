namespace GUI
{
	partial class staff
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(staff));
			TableUserOrder = new DataGridView();
			Number = new DataGridViewTextBoxColumn();
			DrinkName = new DataGridViewTextBoxColumn();
			Quantity = new DataGridViewTextBoxColumn();
			Price = new DataGridViewTextBoxColumn();
			btnDeleteRows = new Button();
			NumberOrderComplete = new TextBox();
			label1 = new Label();
			((System.ComponentModel.ISupportInitialize)TableUserOrder).BeginInit();
			SuspendLayout();
			// 
			// TableUserOrder
			// 
			TableUserOrder.BackgroundColor = Color.White;
			TableUserOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			TableUserOrder.Columns.AddRange(new DataGridViewColumn[] { Number, DrinkName, Quantity, Price });
			TableUserOrder.Location = new Point(354, 90);
			TableUserOrder.Name = "TableUserOrder";
			TableUserOrder.RowHeadersWidth = 62;
			TableUserOrder.RowTemplate.Height = 33;
			TableUserOrder.Size = new Size(782, 364);
			TableUserOrder.TabIndex = 0;
			// 
			// Number
			// 
			Number.DataPropertyName = "None";
			Number.HeaderText = "Number Order";
			Number.MinimumWidth = 8;
			Number.Name = "Number";
			Number.Width = 180;
			// 
			// DrinkName
			// 
			DrinkName.HeaderText = "Drink Name";
			DrinkName.MinimumWidth = 8;
			DrinkName.Name = "DrinkName";
			DrinkName.Width = 180;
			// 
			// Quantity
			// 
			Quantity.HeaderText = "Quantity";
			Quantity.MinimumWidth = 8;
			Quantity.Name = "Quantity";
			Quantity.Width = 180;
			// 
			// Price
			// 
			Price.HeaderText = "Price";
			Price.MinimumWidth = 8;
			Price.Name = "Price";
			Price.Width = 180;
			// 
			// btnDeleteRows
			// 
			btnDeleteRows.BackColor = Color.FromArgb(255, 192, 128);
			btnDeleteRows.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btnDeleteRows.Location = new Point(777, 513);
			btnDeleteRows.Name = "btnDeleteRows";
			btnDeleteRows.Size = new Size(146, 39);
			btnDeleteRows.TabIndex = 1;
			btnDeleteRows.Text = "Complete";
			btnDeleteRows.UseVisualStyleBackColor = false;
			btnDeleteRows.Click += btnDeleteRows_Click;
			// 
			// NumberOrderComplete
			// 
			NumberOrderComplete.BackColor = Color.FromArgb(255, 192, 128);
			NumberOrderComplete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			NumberOrderComplete.Location = new Point(543, 513);
			NumberOrderComplete.Name = "NumberOrderComplete";
			NumberOrderComplete.Size = new Size(150, 39);
			NumberOrderComplete.TabIndex = 2;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.FromArgb(255, 192, 128);
			label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(354, 516);
			label1.Name = "label1";
			label1.Size = new Size(171, 32);
			label1.TabIndex = 3;
			label1.Text = "Number order:";
			// 
			// staff
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
			ClientSize = new Size(1376, 802);
			Controls.Add(label1);
			Controls.Add(NumberOrderComplete);
			Controls.Add(btnDeleteRows);
			Controls.Add(TableUserOrder);
			Name = "staff";
			Text = "staff";
			((System.ComponentModel.ISupportInitialize)TableUserOrder).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView TableUserOrder;
		private Button btnDeleteRows;
		private TextBox NumberOrderComplete;
		private DataGridViewTextBoxColumn Number;
		private DataGridViewTextBoxColumn DrinkName;
		private DataGridViewTextBoxColumn Quantity;
		private DataGridViewTextBoxColumn Price;
		private Label label1;
	}
}