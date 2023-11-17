using DTO;
using DAL;
using System.Collections.Generic;

namespace BLL
{
    public class AttendanceBLL
    {
        AttendanceDAL AttendanceDAL = new AttendanceDAL();
        public void CreateAttendance(AttendanceDTO newAttendance)
        {
            AttendanceDAL.CreateAttendance(newAttendance);
        }

        public List<AttendanceDTO> GetAttendance()
        {
            return AttendanceDAL.GetAttendance();
        }
    }
}
