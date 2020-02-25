using StockMarket.BusinessLayer.Interfaces;
using StockMarket.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarket.BusinessLayer.Services
{
    public class LoginServices : ILoginServices
    {
        public bool Login(string UserName, string Password, string UserType)
        {
            return true;
        }

        public bool SignUp(User user)
        {
            return true;
        }
    }
}
