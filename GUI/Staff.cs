using DTO;
using BLL;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI
{
    public partial class staff : Form
	{
		private OrderBLL orderBLL=new OrderBLL();
		//Lấy dữ liệu order từ data của OrderID
		public void SetDataFromUserOrder(List<int> data, OrderDTO order, int number)
		{
			if (TableUserOrder.Columns.Contains("Number") &&
				TableUserOrder.Columns.Contains("DrinkName") &&
				TableUserOrder.Columns.Contains("Quantity") &&
				TableUserOrder.Columns.Contains("Price"))
			{
				foreach (int item in data)
				{
					Tuple<int, string, decimal> drinkDetails = orderBLL.GetDrinkDetailsByOrderId(item);

					int rowIndex = TableUserOrder.Rows.Add(); 

					//Set dữ liệu vào bảng
					TableUserOrder["Number", rowIndex].Value = number.ToString();
					TableUserOrder["DrinkName", rowIndex].Value = drinkDetails.Item2;
					TableUserOrder["Quantity", rowIndex].Value = drinkDetails.Item1.ToString();
					TableUserOrder["Price", rowIndex].Value = drinkDetails.Item3.ToString();

				}
			}
		}
		public staff()
		{
			InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
		public void DeleteRowsByDrinkOrderId(int drinkOrderId)
		{
			List<DataGridViewRow> rowsToDelete = new List<DataGridViewRow>();

			foreach (DataGridViewRow row in TableUserOrder.Rows)
			{
				int columnIndex = TableUserOrder.Columns["Number"].Index;

				if (row.Cells[columnIndex].Value != null && row.Cells[columnIndex].Value.ToString() == drinkOrderId.ToString())
				{
					rowsToDelete.Add(row);
				}
			}
			foreach (DataGridViewRow row in rowsToDelete)
			{
				TableUserOrder.Rows.Remove(row);
			}
		}

        private void btnComplete_Click(object sender, EventArgs e)
        {
            int RowDelete;
            if (int.TryParse(NumberOrderComplete.Text, out RowDelete))
            {

                DeleteRowsByDrinkOrderId(RowDelete);
                NumberOrderComplete.Text = "";
                MessageBox.Show("Complete Order" + RowDelete);
            }
            else
            {
                MessageBox.Show("It not a number. Please enter a number");
            }
        }
    }
}

