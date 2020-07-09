using System;
using System.Collections.Generic;
using System.Text;

namespace FoodEShopSolution.ViewModels.System.Users
{
    public class LoginRequest
    {
        public string UserName { get; set; } // admin1
        public string Password { get; set; }//Admin@123
        public bool RememberMe { get; set; }
    }
}
