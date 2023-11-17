using System.Collections.Generic;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class AttendanceDAL
    {
        private string connectionString = @"Data Source=DESKTOP-0HUV1DN\SQLEXPRESS;Initial Catalog=Coffee;User ID=sa;Password=123;TrustServerCertificate=true;";
        public void CreateAttendance(AttendanceDTO newAttendance)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Define your SQL query to insert a new Attendance record
                string query = "INSERT INTO Attendance (StaffId, Status, DateTime) VALUES (@StaffId, @Status, @DateTime)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StaffId", newAttendance.StaffId);
                    command.Parameters.AddWithValue("@Status", newAttendance.Status);
                    command.Parameters.AddWithValue("@DateTime", newAttendance.DateTime);
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<AttendanceDTO> GetAttendance()
        {
            List<AttendanceDTO> attendanceList = new List<AttendanceDTO>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Define your SQL query
                string query = "SELECT AttendanceId, StaffId, Status, DateTime FROM Attendance";

                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        AttendanceDTO attendance = new AttendanceDTO
                        {
                            AttendanceId = reader.GetInt32(0),
                            StaffId = reader.GetInt32(1),
                            Status = reader.GetString(2),
                            DateTime = reader.GetDateTime(3)
                        };

                        attendanceList.Add(attendance);
                    }
                }
            }
            return attendanceList;
        }

    }
}
