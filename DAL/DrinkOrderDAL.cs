using System;
using System.Data.SqlClient;

namespace DAL
{
    public class DrinkOrderDAL
    {
        private string connectionString = @"Data Source=DESKTOP-0HUV1DN\SQLEXPRESS;Initial Catalog=Coffee;User ID=sa;Password=123;TrustServerCertificate=true;";
        public decimal CalculateProfit()
        {
            decimal totalProfit = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Retrieve data from the DrinkOrder table and join with the Drink table to get price and cost information
                string query = "SELECT DO.DrinkOrderId, DO.DrinkId, DO.Quantity, D.Price, D.Cost FROM DrinkOrder DO " +
                               "INNER JOIN Drink D ON DO.DrinkId = D.DrinkId";

                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int drinkOrderId = (int)reader["DrinkOrderId"];
                        int drinkId = (int)reader["DrinkId"];
                        int quantity = (int)reader["Quantity"];
                        decimal price = (decimal)reader["Price"];
                        decimal cost = (decimal)reader["Cost"];

                        decimal profit = (price - cost) * quantity;
                        totalProfit += profit;
                    }
                }
            }
            return totalProfit;
        }

        public int GetDrinkOrderId(int drinkId, int quantity, DateTime time)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT DrinkOrderId FROM DrinkOrder WHERE DrinkId = @DrinkId AND Quantity = @Quantity AND Time = @Time";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DrinkId", drinkId);
                    command.Parameters.AddWithValue("@Quantity", quantity);
                    command.Parameters.AddWithValue("@Time", time);

                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        int drinkOrderId;
                        if (int.TryParse(result.ToString(), out drinkOrderId))
                        {
                            return drinkOrderId;
                        }
                    }
                }
            }

            return -1; // Drink order not found
        }

        public void CreateDrinkOrder(int DrinkId, int Quantity, DateTime Time, int UserId)
        {
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO DrinkOrder ( DrinkId, Quantity,Time,UserId) " +
                                   "VALUES (@DrinkId, @Quantity,@Time,@UserId)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@DrinkId", DrinkId);
                        command.Parameters.AddWithValue("@Quantity", Quantity);
                        command.Parameters.AddWithValue("@Time", Time);
                        command.Parameters.AddWithValue("@UserId", UserId);
                        command.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}
