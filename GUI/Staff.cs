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

					int rowIndex = TableUserOrder.Rows.Add(); // Add a new row

					// Set the values in the specific cells
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

			// Remove all identified rows
			foreach (DataGridViewRow row in rowsToDelete)
			{
				TableUserOrder.Rows.Remove(row);
			}
		}

        private void btnDeleteRows_Click(object sender, EventArgs e)
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

