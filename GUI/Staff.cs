using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI
{
    public partial class staff : Form
	{
		public void SetDataFromUserOrder(List<int> data, Order order, int number)
		{
			if (TableUserOrder.Columns.Contains("Number") &&
				TableUserOrder.Columns.Contains("DrinkName") &&
				TableUserOrder.Columns.Contains("Quantity") &&
				TableUserOrder.Columns.Contains("Price"))
			{
				foreach (int item in data)
				{
					Tuple<int, string, decimal> drinkDetails = GetDrinkDetailsByOrderId(item);

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
        string connectionString = "Data Source=DESKTOP-0HUV1DN\\SQLEXPRESS;Initial Catalog=Coffee;User ID=sa;Password=123;TrustServerCertificate=true;";

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
				MessageBox.Show("It not a number. Plese enter a number");
			}
		}

		public Tuple<int, string, decimal> GetDrinkDetailsByOrderId(int drinkOrderId)
		{
			int quantity = 0;
			string drinkName = "";
			decimal price = 0;

			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();

				// Query to get the Quantity and DrinkId from DrinkOrder
				string query = "SELECT Quantity, DrinkId FROM DrinkOrder WHERE DrinkOrderId = @DrinkOrderId";

				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@DrinkOrderId", drinkOrderId);

					using (SqlDataReader reader = command.ExecuteReader())
					{
						if (reader.Read())
						{
							quantity = (int)reader["Quantity"];
							int drinkId = (int)reader["DrinkId"];

							// Close the first SqlDataReader to avoid the error
							reader.Close();

							// Query to get DrinkName and Price from Drink
							string drinkQuery = "SELECT DrinkName, Price FROM Drink WHERE DrinkId = @DrinkId";

							using (SqlCommand drinkCommand = new SqlCommand(drinkQuery, connection))
							{
								drinkCommand.Parameters.AddWithValue("@DrinkId", drinkId);

								using (SqlDataReader drinkReader = drinkCommand.ExecuteReader())
								{
									if (drinkReader.Read())
									{
										drinkName = drinkReader["DrinkName"].ToString();
										price = (decimal)drinkReader["Price"];
									}
								}
							}
						}
					}
				}
			}

			return new Tuple<int, string, decimal>(quantity, drinkName, price);
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

	}
}

