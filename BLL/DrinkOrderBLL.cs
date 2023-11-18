using DAL;
using System;

namespace BLL
{
    public class DrinkOrderBLL
    {
        private DrinkOrderDAL DrinkOderDAL = new DrinkOrderDAL();
        public decimal CalculateProfit()
        {
            return DrinkOderDAL.CalculateProfit();
        }
        public int GetDrinkOrderId(int drinkId, int quantity, DateTime time)
        {
            return DrinkOderDAL.GetDrinkOrderId(drinkId, quantity, time);
        }

        public void CreateDrinkOrder(int DrinkId, int Quantity, DateTime Time, int UserId)
        {
            DrinkOderDAL.CreateDrinkOrder(DrinkId, Quantity, Time, UserId);
        }

        public decimal CalculateDailyProfit(DateTime date)
        {
            return DrinkOderDAL.CalculateDailyProfit(date);
        }

        public decimal CalculateMonthlyProfit(int month, int year)
        {
            return DrinkOderDAL.CalculateMonthlyProfit((int)month, (int)year);
        }

        public decimal CalculateYearlyProfit(int year)
        { 
            return DrinkOderDAL.CalculateYearlyProfit((int)year);
        }
    }
}
