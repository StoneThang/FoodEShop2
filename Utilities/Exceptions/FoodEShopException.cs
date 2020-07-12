using System;
using System.Collections.Generic;
using System.Text;

namespace FoodEShopSolution.Utilities.Exceptions
{
    public class FoodEShopException : Exception
    {
        public FoodEShopException()
        {
        }

        public FoodEShopException(string message)
            : base(message)
        {
        }

        public FoodEShopException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
