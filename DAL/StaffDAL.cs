using System.Collections.Generic;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class StaffDAL
    {
        private string connectionString = @"Data Source=DESKTOP-0HUV1DN\SQLEXPRESS;Initial Catalog=Coffee;User ID=sa;Password=123;TrustServerCertificate=true;";

        public List<StaffDTO> GetStaffByUserId(int userId)
        {
            List<StaffDTO> staffList = new List<StaffDTO>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Define your SQL query to select staff by UserId
                string query = "SELECT StaffId, Name, Shift, Salary, UserId FROM Staff WHERE UserId = @UserId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserId", userId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            StaffDTO staff = new StaffDTO
                            {
                                StaffId = (int)reader["StaffId"],
                                Name = reader["Name"].ToString(),
                                Shift = reader["Shift"].ToString(),
                                Salary = (int)reader["Salary"],
                                UserId = (int)reader["UserId"]
                            };

                            staffList.Add(staff);
                        }
                    }
                }
            }
            return staffList;
        }

        public void CreateStaff(StaffDTO newStaff)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Define your SQL query to insert a new Staff record
                string query = "INSERT INTO Staff (Name, Shift, Salary, UserId) VALUES (@Name, @Shift, @Salary, @UserId)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", newStaff.Name);
                    command.Parameters.AddWithValue("@Shift", newStaff.Shift);
                    command.Parameters.AddWithValue("@Salary", newStaff.Salary);
                    command.Parameters.AddWithValue("@UserId", newStaff.UserId);
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<StaffDTO> GetAllStaff()
        {
            List<StaffDTO> staffList = new List<StaffDTO>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Define your SQL query to select all staff
                string query = "SELECT StaffId, Name, Shift, Salary, UserId FROM Staff";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            StaffDTO staff = new StaffDTO
                            {
                                StaffId = (int)reader["StaffId"],
                                Name = reader["Name"].ToString(),
                                Shift = reader["Shift"].ToString(),
                                Salary = (int)reader["Salary"],
                                UserId = (int)reader["UserId"]
                            };

                            staffList.Add(staff);
                        }
                    }
                }
            }
            return staffList;
        }

        public void UpdateStaff(StaffDTO staff)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Define your SQL query to update the Staff record
                string query = "UPDATE Staff " +
                               "SET Name = @Name, Shift = @Shift, Salary = @Salary " +
                               "WHERE StaffId = @StaffId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StaffId", staff.StaffId);
                    command.Parameters.AddWithValue("@Name", staff.Name);
                    command.Parameters.AddWithValue("@Shift", staff.Shift);
                    command.Parameters.AddWithValue("@Salary", staff.Salary);

                    command.ExecuteNonQuery();
                }
            }
        }
        public void DeleteStaff(int staffId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM Staff WHERE StaffId = @StaffId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StaffId", staffId);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
