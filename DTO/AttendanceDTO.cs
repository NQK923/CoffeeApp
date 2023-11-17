using System;

namespace DTO
{
    public class AttendanceDTO
    {
        public int AttendanceId { get; set; }
        public int StaffId { get; set; }
        public string Status { get; set; }
        public DateTime DateTime { get; set; }
    }
}
