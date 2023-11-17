using DTO;
using DAL;
using System.Collections.Generic;

namespace BLL
{
    public class OrderBLL
    {
        private OderDAL oderDAL = new OderDAL();
        public List<OrderDTO> GetOrderDTOsByUserId(int userId)
        {
            return oderDAL.GetOrderDTOsByUserId(userId);
        }
    }
}
