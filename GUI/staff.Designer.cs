using System.Drawing;
using System.Windows.Forms;

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
            this.TableUserOrder = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DrinkName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnComplete = new System.Windows.Forms.Button();
            this.NumberOrderComplete = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TableUserOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // TableUserOrder
            // 
            this.TableUserOrder.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.TableUserOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableUserOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.DrinkName,
            this.Quantity,
            this.Price});
            this.TableUserOrder.Location = new System.Drawing.Point(76, 26);
            this.TableUserOrder.Margin = new System.Windows.Forms.Padding(2);
            this.TableUserOrder.Name = "TableUserOrder";
            this.TableUserOrder.RowHeadersWidth = 62;
            this.TableUserOrder.RowTemplate.Height = 33;
            this.TableUserOrder.Size = new System.Drawing.Size(785, 233);
            this.TableUserOrder.TabIndex = 0;
            // 
            // Number
            // 
            this.Number.DataPropertyName = "None";
            this.Number.HeaderText = "Number Order";
            this.Number.MinimumWidth = 8;
            this.Number.Name = "Number";
            this.Number.Width = 180;
            // 
            // DrinkName
            // 
            this.DrinkName.HeaderText = "Drink Name";
            this.DrinkName.MinimumWidth = 8;
            this.DrinkName.Name = "DrinkName";
            this.DrinkName.Width = 180;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 8;
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 180;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 8;
            this.Price.Name = "Price";
            this.Price.Width = 180;
            // 
            // btnComplete
            // 
            this.btnComplete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnComplete.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnComplete.Location = new System.Drawing.Point(445, 277);
            this.btnComplete.Margin = new System.Windows.Forms.Padding(2);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(134, 37);
            this.btnComplete.TabIndex = 1;
            this.btnComplete.Text = "Complete";
            this.btnComplete.UseVisualStyleBackColor = false;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // NumberOrderComplete
            // 
            this.NumberOrderComplete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.NumberOrderComplete.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.NumberOrderComplete.Location = new System.Drawing.Point(269, 278);
            this.NumberOrderComplete.Margin = new System.Windows.Forms.Padding(2);
            this.NumberOrderComplete.Name = "NumberOrderComplete";
            this.NumberOrderComplete.Size = new System.Drawing.Size(121, 34);
            this.NumberOrderComplete.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(84, 281);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Number order:";
            // 
            // staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(920, 373);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumberOrderComplete);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.TableUserOrder);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "staff";
            this.Text = "staff";
            ((System.ComponentModel.ISupportInitialize)(this.TableUserOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private DataGridView TableUserOrder;
		private Button btnComplete;
		private TextBox NumberOrderComplete;
		private DataGridViewTextBoxColumn Number;
		private DataGridViewTextBoxColumn DrinkName;
		private DataGridViewTextBoxColumn Quantity;
		private DataGridViewTextBoxColumn Price;
		private Label label1;
	}
}