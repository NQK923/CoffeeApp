using DTO;
using DAL;
using System.Collections.Generic;

namespace BLL
{
    public class StaffBLL
    {
        private StaffDAL StaffDAL = new StaffDAL();
        public List<StaffDTO> GetStaffByUserId(int userId)
        {
            return StaffDAL.GetStaffByUserId(userId);
        }
        public void CreateStaff(StaffDTO newStaff)
        {
            StaffDAL.CreateStaff(newStaff);
        }
        public List<StaffDTO> GetAllStaff()
        {
            return StaffDAL.GetAllStaff();
        }
        public void UpdateStaff(StaffDTO staff)
        {
            StaffDAL.UpdateStaff(staff);
        }

        public void DeleteStaff(int staffId)
        {
            StaffDAL.DeleteStaff(staffId);
        }

        public void UpdateStaffStatus(int staffId)
        {
            StaffDAL.UpdateStaffStatus(staffId);
        }
    }
}