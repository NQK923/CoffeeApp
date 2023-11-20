using System;
using System.Collections.Generic;
using DTO;
using System.Data.SqlClient;

namespace DAL
{
    public class OderDAL
    {
        private string connectionString = @"Data Source=DESKTOP-0HUV1DN\SQLEXPRESS;Initial Catalog=Coffee;User ID=sa;Password=123;TrustServerCertificate=true;";

        public List<OrderDTO> GetOrdersByUserId(int userId)
		{
			List<OrderDTO> orders = new List<OrderDTO>();

			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();

				// Define your SQL query to select orders by UserId
				string query = "SELECT OrderId, UserId, DateTime, PointUse, Status, Total FROM [Order] WHERE UserId = @UserId";

				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@UserId", userId);

					using (SqlDataReader reader = command.ExecuteReader())
					{
						while (reader.Read())
						{
							OrderDTO order = new OrderDTO
							{
								OrderId = (int)reader["OrderId"],
								UserId = (int)reader["UserId"],
								DateTime = (DateTime)reader["DateTime"],
								PointUse = (int)reader["PointUse"],
								Status = (bool)reader["Status"],
								Total = (int)reader["Total"]
							};

							orders.Add(order);
						}
					}
				}
			}

			return orders;
		}

        public List<OrderDTO> GetOrders()
        {
            List<OrderDTO> orders = new List<OrderDTO>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT OrderId, UserId, DateTime, PointUse, Status, Total FROM [Order]";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            OrderDTO order = new OrderDTO
                            {
                                OrderId = (int)reader["OrderId"],
                                UserId = (int)reader["UserId"],
                                DateTime = (DateTime)reader["DateTime"],
                                PointUse = (int)reader["PointUse"],
                                Status = (bool)reader["Status"],
                                Total = (int)reader["Total"]
                            };

                            orders.Add(order);
                        }
                    }
                }
            }
            return orders;
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

        public void CreateOrder(OrderDTO order)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO [Order] (UserId, DateTime, PointUse, Status, Total) " +
                               "VALUES (@UserId, @DateTime, @PointUse, @Status, @Total)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserId", order.UserId);
                    command.Parameters.AddWithValue("@DateTime", order.DateTime);
                    command.Parameters.AddWithValue("@PointUse", order.PointUse);
                    command.Parameters.AddWithValue("@Status", order.Status);
                    command.Parameters.AddWithValue("@Total", order.Total);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
