using DTO;
using DAL;
using System.Collections.Generic;
using System;

namespace BLL
{
    public class OrderBLL
    {
        private OderDAL oderDAL = new OderDAL();
        public List<OrderDTO> GetOrdersByUserId(int userId)
        {
            return oderDAL.GetOrdersByUserId(userId);
        }
        public List<OrderDTO> GetOrders()
        {
            return oderDAL.GetOrders();
        }

        public Tuple<int, string, decimal> GetDrinkDetailsByOrderId(int drinkOrderId)
        {
            return oderDAL.GetDrinkDetailsByOrderId((int)drinkOrderId);
        }

        public void CreateOrder(OrderDTO order)
        {
            oderDAL.CreateOrder(order);
        }
    }
}
