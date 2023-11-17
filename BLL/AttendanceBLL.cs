using DTO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
