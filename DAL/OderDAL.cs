using System;
using System.Collections.Generic;
using DTO;
using System.Data.SqlClient;

namespace DAL
{
    public class OderDAL
    {
        private string connectionString = "DataSource=DESKTOP-0HUV1DN\\SQLEXPRESS;InitialCatalog=Coffee;UserID=sa;Password=123;TrustServerCertificate=true;";

        public List<OrderDTO> GetOrderDTOsByUserId(int userId)
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
    }
}
