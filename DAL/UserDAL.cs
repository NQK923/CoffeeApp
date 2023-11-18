using System.Collections.Generic;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class UserDAL
    {
        private string connectionString = @"Data Source=DESKTOP-0HUV1DN\SQLEXPRESS;Initial Catalog=Coffee;User ID=sa;Password=123;TrustServerCertificate=true;";

        public UserDTO getUserByUsernameAndPassword(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT UserId, Name, UserName, Point FROM [User] WHERE UserName=@Username AND Password=@Password";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            UserDTO user = new UserDTO
                            {
                                UserId = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                UserName = reader.GetString(2),
                                Point = reader.GetInt32(3)
                            };
                            return user;
                        }
                    }
                }
            }
            return null;
        }

        public List<string> getRole(int userId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string roleQuery = "SELECT R.Name FROM Role R " +
                                          "INNER JOIN UserRole UR ON R.RoleId = UR.RoleId " +
                                          "WHERE UR.UserId = @UserId";
                using (SqlCommand roleCommand = new SqlCommand(roleQuery, connection))
                {
                    roleCommand.Parameters.AddWithValue("@UserId", userId.ToString());

                    var roles = roleCommand.ExecuteReader();
                    var userRoles = new List<string>();
                    while (roles.Read())
                    {
                        userRoles.Add(roles.GetString(0));
                    }
                    roles.Close();

                    return userRoles;
                }
            }
        }
        public int getId(string username, string password)
        {
            System.Console.WriteLine("Test");
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT UserId FROM [User] WHERE username = @username AND password = @password", connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader.GetInt32(0);
                        }
                        else
                        {
                            return -1; // Trả về -1 nếu không tìm thấy nhân viên
                        }
                    }
                }
            }
        }
        public decimal CalculateProfitForUser(int userId)
        {
            decimal totalProfit = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Retrieve data from the DrinkOrder and Drink tables for a specific UserId
                string query = "SELECT DO.DrinkOrderId, DO.DrinkId, DO.Quantity, D.Price, D.Cost " +
                               "FROM DrinkOrder DO " +
                               "INNER JOIN Drink D ON DO.DrinkId = D.DrinkId " +
                               "WHERE DO.UserId = @UserId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserId", userId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int drinkId = (int)reader["DrinkId"];
                            int quantity = (int)reader["Quantity"];
                            decimal price = (decimal)reader["Price"];
                            decimal cost = (decimal)reader["Cost"];

                            decimal profit = (price - cost) * quantity;
                            totalProfit += profit;
                        }
                    }
                }
            }
            return totalProfit;
        }

        public bool CheckUsernameExists(string username)
        {
            string query = "SELECT COUNT(*) FROM [User] WHERE username = @username"; 

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);

                    connection.Open();
                    int count = (int)command.ExecuteScalar();

                    if (count > 0)
                        return true;
                    else
                        return false;
                }
            }
        }

        public string GetEmailFromUserName(string username)
        {
            string query = "SELECT Email FROM [User] WHERE username = @username";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);

                    connection.Open();
                    string email = command.ExecuteScalar().ToString();

                        return email;
                }
            }
        }
    }
}
