﻿using DAL;
using DTO;
using System.Collections.Generic;

namespace BLL
{
    public class UserBLL
    {
        private UserDAL userDAL = new UserDAL();

        public UserDTO getUserByUsernameAndPassword(string username, string password)
        {
            return userDAL.getUserByUsernameAndPassword(username, password);
        }

        public List<string> getUserRoles(int userId)
        {
            return userDAL.getRole(userId);
        }

        public int getId(string username, string password)
        {
            return userDAL.getId(username, password);
        }

        public decimal CalculateProfitForUser(int userId)
        {
            return userDAL.CalculateProfitForUser(userId);
        }
    }
}